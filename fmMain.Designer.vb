<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmMain))
        Me.Button_Calc = New System.Windows.Forms.Button()
        Me.TextBox_InputData = New System.Windows.Forms.TextBox()
        Me.TextBox_Lookup = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_TextUtf8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Hex = New System.Windows.Forms.RadioButton()
        Me.RadioButton_TextSjis = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_CRC64 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton_CRC32 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_CRC16 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_CRC8 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton_Custom = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Pre = New System.Windows.Forms.RadioButton()
        Me.GroupBox_Para = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Right = New System.Windows.Forms.RadioButton()
        Me.TextBox_PolynomiaFormula = New System.Windows.Forms.TextBox()
        Me.RadioButton_Left = New System.Windows.Forms.RadioButton()
        Me.TextBox_Final = New System.Windows.Forms.TextBox()
        Me.TextBox_Initial = New System.Windows.Forms.TextBox()
        Me.TextBox_Polynomia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox_Result = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Input = New System.Windows.Forms.CheckBox()
        Me.TextBox_ResultCRC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox_Para.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Calc
        '
        Me.Button_Calc.Location = New System.Drawing.Point(967, 341)
        Me.Button_Calc.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Calc.Name = "Button_Calc"
        Me.Button_Calc.Size = New System.Drawing.Size(231, 45)
        Me.Button_Calc.TabIndex = 0
        Me.Button_Calc.Text = "Calculate CRC"
        Me.Button_Calc.UseVisualStyleBackColor = True
        '
        'TextBox_InputData
        '
        Me.TextBox_InputData.Location = New System.Drawing.Point(7, 27)
        Me.TextBox_InputData.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_InputData.MaxLength = 1024
        Me.TextBox_InputData.Multiline = True
        Me.TextBox_InputData.Name = "TextBox_InputData"
        Me.TextBox_InputData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_InputData.Size = New System.Drawing.Size(911, 106)
        Me.TextBox_InputData.TabIndex = 1
        Me.TextBox_InputData.Text = "123456789"
        '
        'TextBox_Lookup
        '
        Me.TextBox_Lookup.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox_Lookup.Location = New System.Drawing.Point(11, 521)
        Me.TextBox_Lookup.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_Lookup.Multiline = True
        Me.TextBox_Lookup.Name = "TextBox_Lookup"
        Me.TextBox_Lookup.ReadOnly = True
        Me.TextBox_Lookup.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_Lookup.Size = New System.Drawing.Size(1187, 224)
        Me.TextBox_Lookup.TabIndex = 2
        Me.TextBox_Lookup.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 499)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Lookup Table"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_TextUtf8)
        Me.GroupBox1.Controls.Add(Me.RadioButton_Hex)
        Me.GroupBox1.Controls.Add(Me.RadioButton_TextSjis)
        Me.GroupBox1.Controls.Add(Me.TextBox_InputData)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 314)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(926, 170)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CRC Input Data"
        '
        'RadioButton_TextUtf8
        '
        Me.RadioButton_TextUtf8.AutoSize = True
        Me.RadioButton_TextUtf8.Location = New System.Drawing.Point(155, 141)
        Me.RadioButton_TextUtf8.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_TextUtf8.Name = "RadioButton_TextUtf8"
        Me.RadioButton_TextUtf8.Size = New System.Drawing.Size(137, 22)
        Me.RadioButton_TextUtf8.TabIndex = 4
        Me.RadioButton_TextUtf8.Text = "Text String(UTF-8)"
        Me.RadioButton_TextUtf8.UseVisualStyleBackColor = True
        '
        'RadioButton_Hex
        '
        Me.RadioButton_Hex.AutoSize = True
        Me.RadioButton_Hex.Location = New System.Drawing.Point(300, 141)
        Me.RadioButton_Hex.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_Hex.Name = "RadioButton_Hex"
        Me.RadioButton_Hex.Size = New System.Drawing.Size(87, 22)
        Me.RadioButton_Hex.TabIndex = 3
        Me.RadioButton_Hex.Text = "HEX string"
        Me.RadioButton_Hex.UseVisualStyleBackColor = True
        '
        'RadioButton_TextSjis
        '
        Me.RadioButton_TextSjis.AutoSize = True
        Me.RadioButton_TextSjis.Checked = True
        Me.RadioButton_TextSjis.Location = New System.Drawing.Point(14, 141)
        Me.RadioButton_TextSjis.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_TextSjis.Name = "RadioButton_TextSjis"
        Me.RadioButton_TextSjis.Size = New System.Drawing.Size(131, 22)
        Me.RadioButton_TextSjis.TabIndex = 2
        Me.RadioButton_TextSjis.TabStop = True
        Me.RadioButton_TextSjis.Text = "Text String(S-JIS)"
        Me.RadioButton_TextSjis.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton_CRC64)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.RadioButton_CRC32)
        Me.GroupBox2.Controls.Add(Me.RadioButton_CRC16)
        Me.GroupBox2.Controls.Add(Me.RadioButton_CRC8)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 13)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1184, 61)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CRC width"
        '
        'RadioButton_CRC64
        '
        Me.RadioButton_CRC64.AutoSize = True
        Me.RadioButton_CRC64.Location = New System.Drawing.Point(309, 26)
        Me.RadioButton_CRC64.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_CRC64.Name = "RadioButton_CRC64"
        Me.RadioButton_CRC64.Size = New System.Drawing.Size(69, 22)
        Me.RadioButton_CRC64.TabIndex = 4
        Me.RadioButton_CRC64.Tag = "64"
        Me.RadioButton_CRC64.Text = "CRC-64"
        Me.RadioButton_CRC64.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Bit length:"
        '
        'RadioButton_CRC32
        '
        Me.RadioButton_CRC32.AutoSize = True
        Me.RadioButton_CRC32.Location = New System.Drawing.Point(232, 26)
        Me.RadioButton_CRC32.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_CRC32.Name = "RadioButton_CRC32"
        Me.RadioButton_CRC32.Size = New System.Drawing.Size(69, 22)
        Me.RadioButton_CRC32.TabIndex = 3
        Me.RadioButton_CRC32.Tag = "32"
        Me.RadioButton_CRC32.Text = "CRC-32"
        Me.RadioButton_CRC32.UseVisualStyleBackColor = True
        '
        'RadioButton_CRC16
        '
        Me.RadioButton_CRC16.AutoSize = True
        Me.RadioButton_CRC16.Location = New System.Drawing.Point(155, 26)
        Me.RadioButton_CRC16.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_CRC16.Name = "RadioButton_CRC16"
        Me.RadioButton_CRC16.Size = New System.Drawing.Size(69, 22)
        Me.RadioButton_CRC16.TabIndex = 2
        Me.RadioButton_CRC16.Tag = "16"
        Me.RadioButton_CRC16.Text = "CRC-16"
        Me.RadioButton_CRC16.UseVisualStyleBackColor = True
        '
        'RadioButton_CRC8
        '
        Me.RadioButton_CRC8.AutoSize = True
        Me.RadioButton_CRC8.Checked = True
        Me.RadioButton_CRC8.Location = New System.Drawing.Point(85, 26)
        Me.RadioButton_CRC8.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_CRC8.Name = "RadioButton_CRC8"
        Me.RadioButton_CRC8.Size = New System.Drawing.Size(62, 22)
        Me.RadioButton_CRC8.TabIndex = 1
        Me.RadioButton_CRC8.TabStop = True
        Me.RadioButton_CRC8.Tag = "8"
        Me.RadioButton_CRC8.Text = "CRC-8"
        Me.RadioButton_CRC8.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.RadioButton_Custom)
        Me.GroupBox3.Controls.Add(Me.RadioButton_Pre)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 82)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1184, 61)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CRC parametrization"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(106, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(368, 26)
        Me.ComboBox1.TabIndex = 9
        '
        'RadioButton_Custom
        '
        Me.RadioButton_Custom.AutoSize = True
        Me.RadioButton_Custom.Location = New System.Drawing.Point(508, 26)
        Me.RadioButton_Custom.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_Custom.Name = "RadioButton_Custom"
        Me.RadioButton_Custom.Size = New System.Drawing.Size(71, 22)
        Me.RadioButton_Custom.TabIndex = 5
        Me.RadioButton_Custom.Tag = "2"
        Me.RadioButton_Custom.Text = "Custom"
        Me.RadioButton_Custom.UseVisualStyleBackColor = True
        '
        'RadioButton_Pre
        '
        Me.RadioButton_Pre.AutoSize = True
        Me.RadioButton_Pre.Checked = True
        Me.RadioButton_Pre.Location = New System.Drawing.Point(8, 26)
        Me.RadioButton_Pre.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_Pre.Name = "RadioButton_Pre"
        Me.RadioButton_Pre.Size = New System.Drawing.Size(91, 22)
        Me.RadioButton_Pre.TabIndex = 4
        Me.RadioButton_Pre.TabStop = True
        Me.RadioButton_Pre.Tag = "1"
        Me.RadioButton_Pre.Text = "Predefined "
        Me.RadioButton_Pre.UseVisualStyleBackColor = True
        '
        'GroupBox_Para
        '
        Me.GroupBox_Para.Controls.Add(Me.RadioButton_Right)
        Me.GroupBox_Para.Controls.Add(Me.TextBox_PolynomiaFormula)
        Me.GroupBox_Para.Controls.Add(Me.RadioButton_Left)
        Me.GroupBox_Para.Controls.Add(Me.TextBox_Final)
        Me.GroupBox_Para.Controls.Add(Me.TextBox_Initial)
        Me.GroupBox_Para.Controls.Add(Me.TextBox_Polynomia)
        Me.GroupBox_Para.Controls.Add(Me.Label5)
        Me.GroupBox_Para.Controls.Add(Me.Label4)
        Me.GroupBox_Para.Controls.Add(Me.Label3)
        Me.GroupBox_Para.Controls.Add(Me.CheckBox_Result)
        Me.GroupBox_Para.Controls.Add(Me.CheckBox_Input)
        Me.GroupBox_Para.Location = New System.Drawing.Point(11, 151)
        Me.GroupBox_Para.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox_Para.Name = "GroupBox_Para"
        Me.GroupBox_Para.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox_Para.Size = New System.Drawing.Size(1184, 155)
        Me.GroupBox_Para.TabIndex = 6
        Me.GroupBox_Para.TabStop = False
        Me.GroupBox_Para.Text = "CRC detailed parameters"
        '
        'RadioButton_Right
        '
        Me.RadioButton_Right.AutoSize = True
        Me.RadioButton_Right.Location = New System.Drawing.Point(508, 24)
        Me.RadioButton_Right.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_Right.Name = "RadioButton_Right"
        Me.RadioButton_Right.Size = New System.Drawing.Size(85, 22)
        Me.RadioButton_Right.TabIndex = 5
        Me.RadioButton_Right.Text = "Right feed"
        Me.RadioButton_Right.UseVisualStyleBackColor = True
        '
        'TextBox_PolynomiaFormula
        '
        Me.TextBox_PolynomiaFormula.Location = New System.Drawing.Point(258, 56)
        Me.TextBox_PolynomiaFormula.MaxLength = 256
        Me.TextBox_PolynomiaFormula.Name = "TextBox_PolynomiaFormula"
        Me.TextBox_PolynomiaFormula.Size = New System.Drawing.Size(919, 25)
        Me.TextBox_PolynomiaFormula.TabIndex = 16
        '
        'RadioButton_Left
        '
        Me.RadioButton_Left.AutoSize = True
        Me.RadioButton_Left.Checked = True
        Me.RadioButton_Left.Location = New System.Drawing.Point(396, 24)
        Me.RadioButton_Left.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_Left.Name = "RadioButton_Left"
        Me.RadioButton_Left.Size = New System.Drawing.Size(78, 22)
        Me.RadioButton_Left.TabIndex = 4
        Me.RadioButton_Left.TabStop = True
        Me.RadioButton_Left.Text = "Left feed"
        Me.RadioButton_Left.UseVisualStyleBackColor = True
        '
        'TextBox_Final
        '
        Me.TextBox_Final.Location = New System.Drawing.Point(101, 118)
        Me.TextBox_Final.MaxLength = 20
        Me.TextBox_Final.Name = "TextBox_Final"
        Me.TextBox_Final.Size = New System.Drawing.Size(151, 25)
        Me.TextBox_Final.TabIndex = 15
        '
        'TextBox_Initial
        '
        Me.TextBox_Initial.Location = New System.Drawing.Point(101, 87)
        Me.TextBox_Initial.MaxLength = 20
        Me.TextBox_Initial.Name = "TextBox_Initial"
        Me.TextBox_Initial.Size = New System.Drawing.Size(151, 25)
        Me.TextBox_Initial.TabIndex = 14
        '
        'TextBox_Polynomia
        '
        Me.TextBox_Polynomia.Location = New System.Drawing.Point(101, 56)
        Me.TextBox_Polynomia.MaxLength = 20
        Me.TextBox_Polynomia.Name = "TextBox_Polynomia"
        Me.TextBox_Polynomia.Size = New System.Drawing.Size(151, 25)
        Me.TextBox_Polynomia.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Final Xor Value"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Initial Value"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Polynomia"
        '
        'CheckBox_Result
        '
        Me.CheckBox_Result.AutoSize = True
        Me.CheckBox_Result.Location = New System.Drawing.Point(234, 25)
        Me.CheckBox_Result.Name = "CheckBox_Result"
        Me.CheckBox_Result.Size = New System.Drawing.Size(118, 22)
        Me.CheckBox_Result.TabIndex = 1
        Me.CheckBox_Result.Text = "Result reflected"
        Me.CheckBox_Result.UseVisualStyleBackColor = True
        '
        'CheckBox_Input
        '
        Me.CheckBox_Input.AutoSize = True
        Me.CheckBox_Input.Location = New System.Drawing.Point(101, 25)
        Me.CheckBox_Input.Name = "CheckBox_Input"
        Me.CheckBox_Input.Size = New System.Drawing.Size(113, 22)
        Me.CheckBox_Input.TabIndex = 0
        Me.CheckBox_Input.Text = "Input reflected"
        Me.CheckBox_Input.UseVisualStyleBackColor = True
        '
        'TextBox_ResultCRC
        '
        Me.TextBox_ResultCRC.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox_ResultCRC.Font = New System.Drawing.Font("ＭＳ ゴシック", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox_ResultCRC.ForeColor = System.Drawing.Color.Navy
        Me.TextBox_ResultCRC.Location = New System.Drawing.Point(967, 450)
        Me.TextBox_ResultCRC.MaxLength = 20
        Me.TextBox_ResultCRC.Name = "TextBox_ResultCRC"
        Me.TextBox_ResultCRC.ReadOnly = True
        Me.TextBox_ResultCRC.Size = New System.Drawing.Size(231, 26)
        Me.TextBox_ResultCRC.TabIndex = 16
        Me.TextBox_ResultCRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(964, 429)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 18)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Result CRC value"
        '
        'fmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 754)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox_ResultCRC)
        Me.Controls.Add(Me.GroupBox_Para)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Lookup)
        Me.Controls.Add(Me.Button_Calc)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "fmMain"
        Me.Text = "CRC Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox_Para.ResumeLayout(False)
        Me.GroupBox_Para.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Calc As Button
    Friend WithEvents TextBox_InputData As TextBox
    Friend WithEvents TextBox_Lookup As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton_Hex As RadioButton
    Friend WithEvents RadioButton_TextSjis As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton_CRC32 As RadioButton
    Friend WithEvents RadioButton_CRC16 As RadioButton
    Friend WithEvents RadioButton_CRC8 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton_Custom As RadioButton
    Friend WithEvents RadioButton_Pre As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox_Para As GroupBox
    Friend WithEvents CheckBox_Result As CheckBox
    Friend WithEvents CheckBox_Input As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Final As TextBox
    Friend WithEvents TextBox_Initial As TextBox
    Friend WithEvents TextBox_Polynomia As TextBox
    Friend WithEvents TextBox_ResultCRC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_PolynomiaFormula As TextBox
    Friend WithEvents RadioButton_Right As RadioButton
    Friend WithEvents RadioButton_Left As RadioButton
    Friend WithEvents RadioButton_TextUtf8 As RadioButton
    Friend WithEvents RadioButton_CRC64 As RadioButton
End Class
