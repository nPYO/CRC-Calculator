'*
'*  CRC計算ツール
'*  参考：http://www.sunshine2k.de/coding/javascript/crc/crc_js.html
'*　参考サイトのツールをvb.Netに移植
'*　
Public Class fmMain
    Private _EventEnable As Boolean = True

    Private Sub fmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RadioButton_Left.Checked = True
        Me.RadioButton_CRC16.Checked = True
        Me.RadioButton_Hex.Checked = True
        Me.RadioButton_Pre.Checked = True
        Me.ComboBox1.Enabled = True
        Me.GroupBox_Para.Enabled = False

        Me.TextBox_InputData.Text = "0xF8 0x4A 0x9D 0x0B"
        Me.DisplayCrcParam()

    End Sub

    Private Sub RadioButton_CRC_TYPE_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_CRC8.CheckedChanged, RadioButton_CRC16.CheckedChanged, RadioButton_CRC32.CheckedChanged, RadioButton_CRC64.CheckedChanged
        Dim rb As RadioButton = DirectCast(sender, RadioButton)
        If Not rb.Checked Then Return

        If Not Me._EventEnable Then Return
        Me._EventEnable = False

        Dim obj As Object()
        Dim tbl As New DataTable
        tbl.Columns.Add("Type", GetType(String))
        tbl.Columns.Add("Polynomial", GetType(String))
        tbl.Columns.Add("InitialValue", GetType(String))
        tbl.Columns.Add("FinalXorValue", GetType(String))
        tbl.Columns.Add("Input reflected", GetType(Boolean))
        tbl.Columns.Add("Result reflected", GetType(Boolean))

        If rb.Tag = 8 AndAlso rb.Checked Then
            obj = New Object() {"CRC8", "0x7", "0x0", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC8_SAE_J1850", "0x1D", "0xFF", "0xFF", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC8_SAE_J1850_ZERO", "0x1D", "0x0", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC8_8H2F", "0x2F", "0xFF", "0xFF", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC8_CDMA2000", "0x9B", "0xFF", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC8_DARC", "0x39", "0x0", "0x0", True, True} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC8_DVB_S2", "0xD5", "0x0", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC8_EBU", "0x1D", "0xFF", "0x0", True, True} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC8_ICODE", "0x1D", "0xFD", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC8_ITU", "0x7", "0x0", "0x55", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC8_MAXIM", "0x31", "0x0", "0x0", True, True} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC8_ROHC", "0x7", "0xFF", "0x0", True, True} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC8_WCDMA", "0x9B", "0x0", "0x0", True, True} : tbl.Rows.Add(obj)

        ElseIf rb.Tag = 16 AndAlso rb.Checked Then
            obj = New Object() {"CRC16_CCIT_ZERO", "0x1021", "0x0", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_ARC", "0x8005", "0x0", "0x0", True, True} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_AUG_CCITT", "0x1021", "0x1D0F", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_BUYPASS", "0x8005", "0x0", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_CCITT_FALSE", "0x1021", "0xFFFF", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_CDMA2000", "0xC867", "0xFFFF", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_DDS_110", "0x8005", "0x800D", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_DECT_R", "0x589", "0x0", "0x1", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_DECT_X", "0x589", "0x0", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_DNP", "0x3D65", "0x0", "0xFFFF", True, True} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_EN_13757", "0x3D65", "0x0", "0xFFFF", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_GENIBUS", "0x1021", "0xFFFF", "0xFFFF", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_MAXIM", "0x8005", "0x0", "0xFFFF", True, True} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_MCRF4XX", "0x1021", "0xFFFF", "0x0", True, True} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_RIELLO", "0x1021", "0xB2AA", "0x0", True, True} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_T10_DIF", "0x8BB7", "0x0", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_TELEDISK", "0xA097", "0x0", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_YMS37157", "0x1021", "0x89EC", "0x0", True, True} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_USB", "0x8005", "0xFFFF", "0xFFFF", True, True} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC16_A", "0x1021", "0xC6C6", "0x0", True, True} : tbl.Rows.Add(obj)

        ElseIf rb.Tag = 32 AndAlso rb.Checked Then
            obj = New Object() {"CRC32", "0x4C11DB7", "0xFFFFFFFF", "0xFFFFFFFF", True, True} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC32_BZIP2", "0x4C11DB7", "0xFFFFFFFF", "0xFFFFFFFF", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC32_C", "0x1EDC6F41", "0xFFFFFFFF", "0xFFFFFFFF", True, True} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC32_D", "0xA833982B", "0xFFFFFFFF", "0xFFFFFFFF", True, True} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC32_MPEG2", "0x4C11DB7", "0xFFFFFFFF", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC32_POSIX", "0x4C11DB7", "0x0", "0xFFFFFFFF", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC32_Q", "0x814141AB", "0x0", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC32_JMACRC", "0x4C11DB7", "0xFFFFFFFF", "0x0", True, True} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC32_XFER", "0xAF", "0x0", "0x0", False, False} : tbl.Rows.Add(obj)

        ElseIf rb.Tag = 64 AndAlso rb.Checked Then
            obj = New Object() {"CRC64_ECMA_182", "0x42F0E1EBA9EA3693", "0x0", "0x0", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC64_GO_ISO", "0x000000000000001B", "0xFFFFFFFFFFFFFFFF", "0xFFFFFFFFFFFFFFFF", True, True} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC64_WE", "0x42F0E1EBA9EA3693", "0xFFFFFFFFFFFFFFFF", "0xFFFFFFFFFFFFFFFF", False, False} : tbl.Rows.Add(obj)
            obj = New Object() {"CRC64_XZ", "0x42F0E1EBA9EA3693", "0xFFFFFFFFFFFFFFFF", "0xFFFFFFFFFFFFFFFF", True, True} : tbl.Rows.Add(obj)

        End If

        If rb.Checked Then
            Me.ComboBox1.DataSource = tbl
            Me.ComboBox1.DisplayMember = "Type"
            Me.Button_Calc.PerformClick()
        End If

        Me._EventEnable = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cb As ComboBox = DirectCast(sender, ComboBox)
        If Not cb.Enabled Then Return
        Me.DisplayCrcParam()
    End Sub

    Private Sub DisplayCrcParam()
        Dim cb As ComboBox = Me.ComboBox1
        Dim idx As Integer = cb.SelectedIndex
        If idx >= 0 Then
            Me._EventEnable = False
            Dim row As DataRow = DirectCast(cb.DataSource, DataTable).Rows(idx)
            Me.CheckBox_Input.Checked = row.Field(Of Boolean)("Input reflected")
            Me.CheckBox_Result.Checked = row.Field(Of Boolean)("Result reflected")
            Me.TextBox_Initial.Text = row.Field(Of String)("InitialValue")
            Me.TextBox_Final.Text = row.Field(Of String)("FinalXorValue")
            Me.RadioButton_Left.Checked = True
            Me._EventEnable = True
            Me.TextBox_Polynomia.Text = row.Field(Of String)("Polynomial")
        End If
        Me.Button_Calc.PerformClick()

    End Sub

    Private Sub RadioButton_LeftRight_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Left.CheckedChanged, RadioButton_Right.CheckedChanged
        Me.Button_Calc.PerformClick()
    End Sub

    Private Sub CheckBox_Input_Result_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Result.CheckedChanged, CheckBox_Input.CheckedChanged
        Me.Button_Calc.PerformClick()
    End Sub

    Private Sub RadioButton_Config_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Pre.CheckedChanged, RadioButton_Custom.CheckedChanged
        Dim rb As RadioButton = DirectCast(sender, RadioButton)
        If rb.Checked Then
            Me.GroupBox_Para.Enabled = (rb.Tag = 2)
            Me.ComboBox1.Enabled = (rb.Tag = 1)
            If rb.Tag = 1 Then Me.ComboBox1_SelectedIndexChanged(Me.ComboBox1, Nothing)
        End If
    End Sub

    Private Sub TextBox_PolynomiaFormula_TextChanged(sender As Object, e As EventArgs) Handles TextBox_PolynomiaFormula.TextChanged
        If Not Me._EventEnable Then Return
        Me._EventEnable = False

        Dim tb As TextBox = DirectCast(sender, TextBox)

        Dim Polynomia As UInt64
        Dim res As String = If(Me.PolynomiaFormulaString_to_Value(tb.Text, Polynomia), $"0x{Polynomia.ToString($"X{Me.ByteSize.ToString()}")}", "- error -")
        Me.TextBox_Polynomia.Text = res

        Me._EventEnable = True
    End Sub

    Private Sub TextBox_Polynomia_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Polynomia.TextChanged
        If Not Me._EventEnable Then Return
        Me._EventEnable = False

        Dim tb As TextBox = DirectCast(sender, TextBox)

        Dim res As String = "- error -"
        Dim PolynomiaFormula As String = StrConv(tb.Text, vbNarrow + vbLowerCase).Replace(" ", "")
        Try
            Dim Polynomia As ULong
            If PolynomiaFormula.Length > 2 AndAlso PolynomiaFormula.Substring(0, 2) = "0x" Then
                Polynomia = Convert.ToUInt64(PolynomiaFormula, 16)
            Else
                Polynomia = Convert.ToUInt64(PolynomiaFormula, 10)
            End If
            If Polynomia <= 0 Then Throw New Exception("")
            If Not Me.PolynomiaValue_to_FormulaString(Polynomia, res) Then Throw New Exception("")
        Catch ex As Exception
        End Try
        Me.TextBox_PolynomiaFormula.Text = res

        Me._EventEnable = True
    End Sub

    Private Function isHEX(str As String) As Boolean
        For Each c As Char In str
            If "0123456789abcdefABCDEF".IndexOf(c) < 0 Then Return False
        Next
        Return True
    End Function

    Private Function isDEC(str As String) As Boolean
        For Each c As Char In str
            If "0123456789".IndexOf(c) < 0 Then Return False
        Next
        Return True
    End Function

    Private Sub Button_Calc_Click(sender As Object, e As EventArgs) Handles Button_Calc.Click
        Dim BitLength As Integer = Me.BitLegngth
        Dim Polynomial As ULong
        Dim initialValue As ULong
        Dim FinalXorValue As ULong
        Dim InputReflected As Boolean
        Dim ResultRreflected As Boolean
        Dim feed As CRC_CALCULATION.BitFeed

        Dim tmp As String
        Dim fmt As String = $"X{Me.ByteSize * 2}"

        '* 入力データ作成
        Dim inputData As Byte()
        If Me.RadioButton_Hex.Checked Then
            tmp = StrConv(Me.TextBox_InputData.Text, vbNarrow + vbLowerCase).Trim
            Dim s As String()
            If tmp.IndexOf(",") > 0 Then
                s = tmp.Split(",")
            ElseIf tmp.IndexOf(" ") > 0 Then
                s = tmp.Split(" ")
            Else
                s = New String() {tmp}
            End If

            Dim lst As New List(Of Byte)
            For Each h As String In s
                h = h.Replace(" ", "")
                If h.Length <= 0 Then Continue For

                Dim n As Integer = 0
                If h.Length > 2 AndAlso h.Substring(0, 2) = "0x" Then
                    If h.Length > 4 OrElse Not Me.isHEX(h.Substring(2)) Then
                        Me.TextBox_ResultCRC.Text = "- Error -"
                        Return
                    End If
                    n = Convert.ToInt16(h, 16)
                Else
                    If h.Length > 3 OrElse Not Me.isDEC(h) Then
                        Me.TextBox_ResultCRC.Text = "- Error -"
                        Return
                    End If
                    n = Convert.ToInt16(h, 10)
                    If n > 255 Then
                        Me.TextBox_ResultCRC.Text = "- Error -"
                        Return
                    End If
                End If

                lst.Add(CType(n, Byte))
            Next
            inputData = lst.ToArray()

        ElseIf Me.RadioButton_TextSjis.Checked Then
            inputData = System.Text.Encoding.GetEncoding("Shift_JIS").GetBytes(Me.TextBox_InputData.Text)

        Else
            inputData = System.Text.Encoding.UTF8.GetBytes(Me.TextBox_InputData.Text)

        End If

        Try
            With Me.TextBox_Polynomia
                tmp = StrConv(.Text, vbNarrow + vbLowerCase).Replace(" ", "")
                Polynomial = If(tmp.IndexOf("0x") = 0, Convert.ToUInt64(tmp, 16), Convert.ToUInt64(tmp, 10)) And Me.BitMask
                .Text = $"0x{Polynomial.ToString(fmt)}"
            End With

            Me.TextBox_PolynomiaFormula.Text = If(PolynomiaValue_to_FormulaString(Polynomial, tmp), tmp, "- error -")

            With Me.TextBox_Initial
                tmp = StrConv(.Text, vbNarrow + vbLowerCase).Replace(" ", "")
                initialValue = If(tmp.IndexOf("0x") = 0, Convert.ToUInt64(tmp, 16), Convert.ToUInt64(tmp, 10)) And Me.BitMask
                .Text = $"0x{initialValue.ToString(fmt)}"
            End With

            With Me.TextBox_Final
                tmp = StrConv(.Text, vbNarrow + vbLowerCase).Replace(" ", "")
                FinalXorValue = If(tmp.IndexOf("0x") = 0, Convert.ToUInt64(tmp, 16), Convert.ToUInt64(tmp, 10)) And Me.BitMask
                .Text = $"0x{FinalXorValue.ToString(fmt)}"
            End With

            InputReflected = Me.CheckBox_Input.Checked
            ResultRreflected = Me.CheckBox_Result.Checked
            feed = If(Me.RadioButton_Left.Checked, CRC_CALCULATION.BitFeed.Left, CRC_CALCULATION.BitFeed.Right)

        Catch ex As Exception
            Me.TextBox_ResultCRC.Text = "- Error -"

        End Try

        Dim crc As New CRC_CALCULATION(BitLength, Polynomial, initialValue, FinalXorValue, InputReflected, ResultRreflected, feed)
        crc.Calc(inputData, 0, inputData.Length)
        Dim c As Byte() = crc.FinalValue()
        Me.TextBox_ResultCRC.Text = $"0x{BitConverter.ToString(c).Replace("-", "")} "
        Me.dumpLookup(crc.CRCtable)

    End Sub

    Private ReadOnly Property BitLegngth() As Integer
        Get
            Dim bit As Integer = 64
            If Me.RadioButton_CRC8.Checked Then
                bit = 8
            ElseIf Me.RadioButton_CRC16.Checked Then
                bit = 16
            ElseIf Me.RadioButton_CRC32.Checked Then
                bit = 32
            End If
            Return bit
        End Get
    End Property

    Private ReadOnly Property BitMask() As UInt64
        Get
            Dim mask As UInt64 = 0
            Dim i As Integer = Me.BitLegngth
            Do While i > 0
                mask <<= 1
                mask += 1
                i -= 1
            Loop
            Return mask
        End Get
    End Property

    Private ReadOnly Property ByteSize() As Integer
        Get
            Return Me.BitLegngth / 8
        End Get
    End Property

    Private Sub dumpLookup(tbl As ULong())

        Me.TextBox_Lookup.Text = ""
        If tbl Is Nothing Then Return

        Dim charLength As Integer = Me.BitLegngth / 4
        Dim fmt As String = $"X{charLength}"
        Dim sb As New Text.StringBuilder

        Dim idx As Integer = 0
        For row As Integer = 0 To 15
            For col As Integer = 0 To 15
                tbl(idx).ToString(fmt)
                sb.Append($"0x{tbl(idx).ToString(fmt)}")
                If idx < 255 Then sb.Append(",")
                If col < 15 Then sb.Append(" ")
                idx += 1
            Next
            If row < 15 Then sb.AppendLine()
        Next

        Me.TextBox_Lookup.Text = sb.ToString
    End Sub

    '*
    '* 多項式の数式を数値に変換
    Private Function PolynomiaFormulaString_to_Value(FormulaString As String, ByRef PolynomiaValue As UInt64) As Boolean
        PolynomiaValue = 0

        '* 半角小文字変換＆スペースと^記号を全て削除
        Dim FormulaText As String = StrConv(FormulaString, vbNarrow + vbLowerCase).Replace(" ", "").Replace("^", "")
        Dim item As String() = FormulaText.Split("+") '* 各項分離

        Dim dic As New Dictionary(Of String, UInt64)
        For Each x As String In item
            If x.Length <= 0 Then Return False
            If x = "1" Then x = "x0"
            If x.Substring(0, 1) <> "x" Then Return False

            Dim v As String
            v = x.Substring(1)
            If v.Length <= 0 OrElse v.Length >= 3 Then Return False
            If Not Me.isDEC(v) Then Return False

            Dim n As ULong = UInt64.Parse(v)
            If n > 63 Then Continue For

            Dim ky As String = $"x{n.ToString}"
            If dic.ContainsKey(ky) Then Return False

            n = (1UL << n)
            dic.Add(ky, n)
            PolynomiaValue += n
        Next
        PolynomiaValue = PolynomiaValue And Me.BitMask

        Return True
    End Function

    '*
    '* 多項式の数値を数式に変換
    Private Function PolynomiaValue_to_FormulaString(PolynomiaValue As UInt64, ByRef FormulaString As String) As Boolean
        FormulaString = ""
        PolynomiaValue = PolynomiaValue And Me.BitMask

        Dim idx As Integer = 0
        Dim lst As New List(Of String)
        Do While PolynomiaValue > 0
            If (PolynomiaValue And 1UL) = 1UL Then
                If idx = 0 Then lst.Add("1") Else lst.Add($"x^{idx.ToString}")
            End If
            PolynomiaValue >>= 1
            idx += 1
        Loop
        If lst.Count <= 0 Then Return False

        idx = lst.Count - 1
        Do While idx >= 0
            FormulaString &= $"{lst(idx)}{If(idx > 0, " + ", "")}"
            idx -= 1
        Loop

        Return True
    End Function

End Class
