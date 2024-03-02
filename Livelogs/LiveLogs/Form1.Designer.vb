<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        RichTextBox1 = New RichTextBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        CheckBox1 = New CheckBox()
        TextBox2 = New TextBox()
        Button2 = New Button()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        SelectLogFileToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        FindToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        Label2 = New Label()
        Panel1 = New Panel()
        Label4 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        RichTextBox1.Location = New Point(12, 56)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(648, 484)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = ""
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(10, 29)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 27)
        Button1.TabIndex = 2
        Button1.Text = "Start Reading"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(117, 7)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(558, 16)
        TextBox1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(497, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 5
        Label1.Text = "Lines:"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(21, 4)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(80, 19)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Autoscroll"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(11, 33)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(396, 16)
        TextBox2.TabIndex = 7
        TextBox2.Visible = False
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(414, 27)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 27)
        Button2.TabIndex = 8
        Button2.Text = "Find"
        Button2.UseVisualStyleBackColor = True
        Button2.Visible = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(672, 24)
        MenuStrip1.TabIndex = 9
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SelectLogFileToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' SelectLogFileToolStripMenuItem
        ' 
        SelectLogFileToolStripMenuItem.Name = "SelectLogFileToolStripMenuItem"
        SelectLogFileToolStripMenuItem.Size = New Size(153, 22)
        SelectLogFileToolStripMenuItem.Text = "Select log file..."
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(153, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FindToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(39, 20)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' FindToolStripMenuItem
        ' 
        FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        FindToolStripMenuItem.Size = New Size(180, 22)
        FindToolStripMenuItem.Text = "Find"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(180, 22)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(27, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 15)
        Label2.TabIndex = 10
        Label2.Text = "Selected log file"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Location = New Point(12, 546)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(648, 66)
        Panel1.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(497, 4)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 15)
        Label4.TabIndex = 14
        Label4.Text = "Current line: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(523, 33)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 15)
        Label5.TabIndex = 14
        Label5.Text = "Instances found:"
        Label5.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(117, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 15)
        Label3.TabIndex = 12
        Label3.Text = "File doesn't exist"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.Gainsboro
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(-16, 623)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(713, 47)
        Panel2.TabIndex = 13
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(672, 668)
        Controls.Add(Label5)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MinimumSize = New Size(688, 707)
        Name = "form1"
        Text = "LiveLogs"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectLogFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
