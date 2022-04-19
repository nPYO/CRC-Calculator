'*
'*  CRC8 / CRC16 / CRC32 / CRC64 計算クラス
'*
'*                                    2022.04.12
Public Class CRC_CALCULATION
    Public Enum BitFeed
        Left
        Right
    End Enum

    Private _BitLength As Integer        '* CRCビット長 8,16,32,64
    Private _Polynomial As ULong         '* 多項式の値
    Private _BitFeed As BitFeed          '* ビット送り方向
    Private _InitialValue As ULong       '* CRC 初期値
    Private _FinalXorValue As ULong      '* 最後の排他的論理和に使用する値
    Private _InputReflected As Boolean   '* 入力データのビット左右反転(True)
    Private _ResultRreflected As Boolean '* 出力データのビット左右反転(True)   
    Private _CrcMaskValue As ULong       '* CRCマスク値
    Private _CRCvalue As ULong           '* 現在のCRC値
    Private _CRCpoly As ULong            '* 実際に使用する多項式値(Rightシフト時に変形される)
    Private _CRCtable As ULong()         '* CRCテーブル

    '*
    '* BitLength  CRCビット長
    '* Polynomial 多項式
    '* InitialValue 初期値
    '* FinalXorValue 最終排他的論理和値
    '* InputReflected 入力反転(True)
    '* ResultRreflected 出力反転(True)
    '* feed 送り方向
    '*
    Public Sub New(BitLength As Integer, Polynomial As ULong, InitialValue As ULong, FinalXorValue As ULong, InputReflected As Boolean, ResultRreflected As Boolean, Optional feed As BitFeed = BitFeed.Left)

        Me._Polynomial = CType(Polynomial, ULong)
        Me._BitLength = BitLength
        Me._BitFeed = feed
        Me._FinalXorValue = FinalXorValue
        Me._InitialValue = InitialValue
        Me._InputReflected = InputReflected
        Me._ResultRreflected = ResultRreflected
        Me._CRCtable = New ULong(255) {}
        Me._CRCpoly = Me._Polynomial

        '* マスク値生成  --> (1 << BitLength) - 1  これだと vb.netではオーバーフローとなる
        Me._CrcMaskValue = 0
        For i As Integer = 0 To BitLength - 1
            Me._CrcMaskValue <<= 1
            Me._CrcMaskValue = Me._CrcMaskValue Or 1UL
        Next

        If (Me._BitFeed = BitFeed.Left) Then
            '* 左送り用のCRCテーブルを作成
            Dim msb As ULong = (1UL << (Me._BitLength - 1))
            For i As ULong = 0 To 255
                Dim c As ULong = i << (Me._BitLength - 8)
                For j As ULong = 0 To 7
                    c = (c << 1) Xor If((c And msb) <> 0UL, Me._CRCpoly, 0UL)
                Next
                Me._CRCtable(i) = c And Me._CrcMaskValue
            Next
        Else
            '* 多項式のビットを左右反転
            Me._CRCpoly = Me.reverseBit(Me._Polynomial, Me._BitLength) And Me._CrcMaskValue

            '* 右送り用のCRCテーブルを作成
            For i As ULong = 0 To 255
                Dim c As ULong = i
                For j As ULong = 0 To 7
                    c = If((c And 1UL) <> 0UL, Me._CRCpoly Xor (c >> 1), c >> 1)
                Next
                Me._CRCtable(i) = c And Me._CrcMaskValue
            Next
        End If
        Me.Initialize()
    End Sub

    '*
    '* CRCテーブルの複製を返す
    Public ReadOnly Property CRCtable() As ULong()
        Get
            Return If(Me._CRCtable Is Nothing, Nothing, Me._CRCtable.Clone)
        End Get
    End Property

    '*
    '* 現在のCRC値を破棄して初期値をセットする
    Public Sub Initialize()
        Me._CRCvalue = Me._InitialValue
    End Sub

    '*
    '* 現在のCRC値に対してバイト配列でCRCを更新
    Public Sub Calc(byteData As Byte(), ibStart As Integer, cbSize As Integer)
        Do While cbSize > 0
            Dim data As Byte = If(Me._InputReflected, Me.reverseBit(byteData(ibStart), 8) And &HFF, byteData(ibStart))
            Me._CRCvalue = If(Me._BitFeed = BitFeed.Left, Me._CRCtable(data Xor (Me._CRCvalue >> (Me._BitLength - 8)) And &HFFUL) Xor (Me._CRCvalue << 8), Me._CRCtable((data Xor Me._CRCvalue) And &HFFUL) Xor If(Me._BitLength > 8, Me._CRCvalue >> 8, 0))
            cbSize -= 1
            ibStart += 1
        Loop
    End Sub

    '*
    '*　現在のCRC値に最終処理を施して配列でCRC値を返す
    Public Function FinalValue() As Byte()
        Dim i As Integer = Me._BitLength / 8
        Dim data As Byte() = New Byte(i - 1) {}
        Dim crc As ULong = (Me._CRCvalue Xor Me._FinalXorValue)
        If Me._ResultRreflected Then crc = Me.reverseBit(crc, Me._BitLength)
        Do While i > 0
            i -= 1
            data(i) = CType((crc And &HFFUL), Byte)
            crc >>= 8
        Loop
        Return data
    End Function

    '*
    '* 入力値のビット列を逆順に並び替える
    Private Function reverseBit(n As ULong, bitLength As Integer) As ULong
        Dim Rtbl As ULong() = {&H0, &H8, &H4, &HC, &H2, &HA, &H6, &HE, &H1, &H9, &H5, &HD, &H3, &HB, &H7, &HF}
        Dim ret As ULong = n
        For i As Integer = 0 To bitLength - 1 Step 4
            ret = (ret << 4UL) Or Rtbl((n >> i) And &HFUL)
        Next
        Return ret
    End Function

End Class
