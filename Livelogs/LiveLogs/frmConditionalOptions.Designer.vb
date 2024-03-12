<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConditionalOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConditionalOptions))
        LblInfoColor = New Label()
        LblWarningColor = New Label()
        lblErrorColor = New Label()
        lblCriticalColor = New Label()
        lblFatalColor = New Label()
        lblCustomColor = New Label()
        txtInfo = New TextBox()
        txtWarning = New TextBox()
        txtError = New TextBox()
        txtCritical = New TextBox()
        txtFatal = New TextBox()
        txtCustom = New TextBox()
        Colors = New GroupBox()
        Label9 = New Label()
        Label10 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        Button3 = New Button()
        Label13 = New Label()
        Label2 = New Label()
        txtPopup = New TextBox()
        GroupBox2 = New GroupBox()
        btnTest = New Button()
        Label12 = New Label()
        Label11 = New Label()
        btnBrowse = New Button()
        txtTargetPath = New TextBox()
        Label3 = New Label()
        txtIntegration = New TextBox()
        GroupBox3 = New GroupBox()
        Button2 = New Button()
        Label14 = New Label()
        Label4 = New Label()
        txtSound = New TextBox()
        tmrEasterEgg = New Timer(components)
        Colors.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblInfoColor
        ' 
        LblInfoColor.BackColor = Color.SeaGreen
        LblInfoColor.Location = New Point(205, 68)
        LblInfoColor.Name = "LblInfoColor"
        LblInfoColor.Size = New Size(18, 18)
        LblInfoColor.TabIndex = 0
        ' 
        ' LblWarningColor
        ' 
        LblWarningColor.BackColor = Color.Peru
        LblWarningColor.Location = New Point(205, 104)
        LblWarningColor.Name = "LblWarningColor"
        LblWarningColor.Size = New Size(18, 18)
        LblWarningColor.TabIndex = 1
        ' 
        ' lblErrorColor
        ' 
        lblErrorColor.BackColor = Color.IndianRed
        lblErrorColor.Location = New Point(205, 140)
        lblErrorColor.Name = "lblErrorColor"
        lblErrorColor.Size = New Size(18, 18)
        lblErrorColor.TabIndex = 2
        ' 
        ' lblCriticalColor
        ' 
        lblCriticalColor.BackColor = Color.Red
        lblCriticalColor.Location = New Point(205, 176)
        lblCriticalColor.Name = "lblCriticalColor"
        lblCriticalColor.Size = New Size(18, 18)
        lblCriticalColor.TabIndex = 3
        ' 
        ' lblFatalColor
        ' 
        lblFatalColor.BackColor = Color.Purple
        lblFatalColor.Location = New Point(205, 212)
        lblFatalColor.Name = "lblFatalColor"
        lblFatalColor.Size = New Size(18, 18)
        lblFatalColor.TabIndex = 4
        ' 
        ' lblCustomColor
        ' 
        lblCustomColor.BackColor = Color.SteelBlue
        lblCustomColor.Location = New Point(205, 248)
        lblCustomColor.Name = "lblCustomColor"
        lblCustomColor.Size = New Size(18, 18)
        lblCustomColor.TabIndex = 5
        ' 
        ' txtInfo
        ' 
        txtInfo.BorderStyle = BorderStyle.FixedSingle
        txtInfo.Location = New Point(50, 68)
        txtInfo.Name = "txtInfo"
        txtInfo.Size = New Size(118, 23)
        txtInfo.TabIndex = 6
        txtInfo.Text = "Info"
        ' 
        ' txtWarning
        ' 
        txtWarning.BorderStyle = BorderStyle.FixedSingle
        txtWarning.Location = New Point(50, 104)
        txtWarning.Name = "txtWarning"
        txtWarning.Size = New Size(118, 23)
        txtWarning.TabIndex = 7
        txtWarning.Text = "Warning"
        ' 
        ' txtError
        ' 
        txtError.BorderStyle = BorderStyle.FixedSingle
        txtError.Location = New Point(50, 140)
        txtError.Name = "txtError"
        txtError.Size = New Size(118, 23)
        txtError.TabIndex = 8
        txtError.Text = "Error"
        ' 
        ' txtCritical
        ' 
        txtCritical.BorderStyle = BorderStyle.FixedSingle
        txtCritical.Location = New Point(50, 176)
        txtCritical.Name = "txtCritical"
        txtCritical.Size = New Size(118, 23)
        txtCritical.TabIndex = 9
        txtCritical.Text = "Critical"
        ' 
        ' txtFatal
        ' 
        txtFatal.BorderStyle = BorderStyle.FixedSingle
        txtFatal.Location = New Point(50, 212)
        txtFatal.Name = "txtFatal"
        txtFatal.Size = New Size(118, 23)
        txtFatal.TabIndex = 10
        txtFatal.Text = "Fatal"
        ' 
        ' txtCustom
        ' 
        txtCustom.BorderStyle = BorderStyle.FixedSingle
        txtCustom.Location = New Point(50, 248)
        txtCustom.Name = "txtCustom"
        txtCustom.Size = New Size(118, 23)
        txtCustom.TabIndex = 11
        txtCustom.Text = "Boo"
        ' 
        ' Colors
        ' 
        Colors.Controls.Add(Label9)
        Colors.Controls.Add(Label10)
        Colors.Controls.Add(Label7)
        Colors.Controls.Add(Label8)
        Colors.Controls.Add(Label6)
        Colors.Controls.Add(Label5)
        Colors.Controls.Add(Label1)
        Colors.Controls.Add(txtCustom)
        Colors.Controls.Add(txtFatal)
        Colors.Controls.Add(txtCritical)
        Colors.Controls.Add(txtError)
        Colors.Controls.Add(txtWarning)
        Colors.Controls.Add(txtInfo)
        Colors.Controls.Add(lblCustomColor)
        Colors.Controls.Add(lblFatalColor)
        Colors.Controls.Add(lblCriticalColor)
        Colors.Controls.Add(lblErrorColor)
        Colors.Controls.Add(LblWarningColor)
        Colors.Controls.Add(LblInfoColor)
        Colors.Location = New Point(12, 12)
        Colors.Name = "Colors"
        Colors.Size = New Size(273, 293)
        Colors.TabIndex = 12
        Colors.TabStop = False
        Colors.Text = "Line color"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(25, 251)
        Label9.Name = "Label9"
        Label9.Size = New Size(13, 15)
        Label9.TabIndex = 18
        Label9.Text = "6"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(25, 215)
        Label10.Name = "Label10"
        Label10.Size = New Size(13, 15)
        Label10.TabIndex = 17
        Label10.Text = "5"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(25, 179)
        Label7.Name = "Label7"
        Label7.Size = New Size(13, 15)
        Label7.TabIndex = 16
        Label7.Text = "4"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(25, 143)
        Label8.Name = "Label8"
        Label8.Size = New Size(13, 15)
        Label8.TabIndex = 15
        Label8.Text = "3"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(26, 107)
        Label6.Name = "Label6"
        Label6.Size = New Size(13, 15)
        Label6.TabIndex = 14
        Label6.Text = "2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(26, 71)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 15)
        Label5.TabIndex = 13
        Label5.Text = "1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(50, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 30)
        Label1.TabIndex = 12
        Label1.Text = "Select keywords that will be colored " & vbCrLf & "in different colors on log window"
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(483, 492)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 27)
        Button1.TabIndex = 13
        Button1.Text = "OK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtPopup)
        GroupBox1.Location = New Point(302, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(284, 143)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        GroupBox1.Text = "Information window"
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(127, 103)
        Button3.Name = "Button3"
        Button3.Size = New Size(103, 27)
        Button3.TabIndex = 21
        Button3.Text = "Test window"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(41, 76)
        Label13.Name = "Label13"
        Label13.Size = New Size(53, 15)
        Label13.TabIndex = 19
        Label13.Text = "Keyword"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 45)
        Label2.TabIndex = 13
        Label2.Text = "Show an informational window " & vbCrLf & "when a line that contains this" & vbCrLf & "keyword is detected"
        ' 
        ' txtPopup
        ' 
        txtPopup.BorderStyle = BorderStyle.FixedSingle
        txtPopup.Location = New Point(112, 74)
        txtPopup.Name = "txtPopup"
        txtPopup.Size = New Size(118, 23)
        txtPopup.TabIndex = 13
        txtPopup.Text = "Bizzare"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnTest)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(btnBrowse)
        GroupBox2.Controls.Add(txtTargetPath)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtIntegration)
        GroupBox2.Location = New Point(12, 311)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(574, 171)
        GroupBox2.TabIndex = 15
        GroupBox2.TabStop = False
        GroupBox2.Text = "Program integration"
        ' 
        ' btnTest
        ' 
        btnTest.FlatStyle = FlatStyle.Flat
        btnTest.Location = New Point(351, 133)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(103, 27)
        btnTest.TabIndex = 19
        btnTest.Text = "Test launch"
        btnTest.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(48, 64)
        Label12.Name = "Label12"
        Label12.Size = New Size(53, 15)
        Label12.TabIndex = 18
        Label12.Text = "Keyword"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(48, 109)
        Label11.Name = "Label11"
        Label11.Size = New Size(53, 15)
        Label11.TabIndex = 17
        Label11.Text = "Program"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Location = New Point(462, 102)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(103, 27)
        btnBrowse.TabIndex = 16
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' txtTargetPath
        ' 
        txtTargetPath.BorderStyle = BorderStyle.FixedSingle
        txtTargetPath.Location = New Point(113, 104)
        txtTargetPath.Name = "txtTargetPath"
        txtTargetPath.Size = New Size(341, 23)
        txtTargetPath.TabIndex = 15
        txtTargetPath.Text = "C:\Windows\System32\Calc.exe"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(48, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(406, 15)
        Label3.TabIndex = 14
        Label3.Text = "Run an external program when a line than contains this keyword is detected"
        ' 
        ' txtIntegration
        ' 
        txtIntegration.BorderStyle = BorderStyle.FixedSingle
        txtIntegration.Location = New Point(113, 61)
        txtIntegration.Name = "txtIntegration"
        txtIntegration.Size = New Size(120, 23)
        txtIntegration.TabIndex = 14
        txtIntegration.Text = "Strange"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Button2)
        GroupBox3.Controls.Add(Label14)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(txtSound)
        GroupBox3.Location = New Point(302, 161)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(284, 144)
        GroupBox3.TabIndex = 15
        GroupBox3.TabStop = False
        GroupBox3.Text = "Sound"
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(127, 102)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 27)
        Button2.TabIndex = 20
        Button2.Text = "Test sound"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(41, 75)
        Label14.Name = "Label14"
        Label14.Size = New Size(53, 15)
        Label14.TabIndex = 20
        Label14.Text = "Keyword"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(41, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(182, 30)
        Label4.TabIndex = 13
        Label4.Text = "Play a sound when a line that " & vbCrLf & "contains this keyword is detected"
        ' 
        ' txtSound
        ' 
        txtSound.BorderStyle = BorderStyle.FixedSingle
        txtSound.Location = New Point(112, 73)
        txtSound.Name = "txtSound"
        txtSound.Size = New Size(118, 23)
        txtSound.TabIndex = 13
        txtSound.Text = "Weird"
        ' 
        ' tmrEasterEgg
        ' 
        tmrEasterEgg.Interval = 15000
        ' 
        ' frmConditionalOptions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(603, 531)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Button1)
        Controls.Add(Colors)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmConditionalOptions"
        ShowInTaskbar = False
        Text = "Livelogs - Conditional options"
        Colors.ResumeLayout(False)
        Colors.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LblInfoColor As Label
    Friend WithEvents LblWarningColor As Label
    Friend WithEvents lblErrorColor As Label
    Friend WithEvents lblCriticalColor As Label
    Friend WithEvents lblFatalColor As Label
    Friend WithEvents lblCustomColor As Label
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents txtWarning As TextBox
    Friend WithEvents txtError As TextBox
    Friend WithEvents txtCritical As TextBox
    Friend WithEvents txtFatal As TextBox
    Friend WithEvents txtCustom As TextBox
    Friend WithEvents Colors As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPopup As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtIntegration As TextBox
    Friend WithEvents txtTargetPath As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSound As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnTest As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents tmrEasterEgg As Timer
End Class
