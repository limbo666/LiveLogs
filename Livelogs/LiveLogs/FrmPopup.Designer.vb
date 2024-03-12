<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPopup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPopup))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        lblLine = New Label()
        Label3 = New Label()
        lblTime = New Label()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(171, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 20)
        Label1.TabIndex = 0
        Label1.Text = "Keyword detected:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.LivelLogs_Logo
        PictureBox1.Location = New Point(2, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(84, 82)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.RoyalBlue
        Label2.Location = New Point(274, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 15)
        Label2.TabIndex = 2
        Label2.Text = "keyword here"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblLine
        ' 
        lblLine.BorderStyle = BorderStyle.FixedSingle
        lblLine.ForeColor = Color.DodgerBlue
        lblLine.Location = New Point(104, 41)
        lblLine.Name = "lblLine"
        lblLine.Size = New Size(363, 44)
        lblLine.TabIndex = 4
        lblLine.Text = "line goes here"
        lblLine.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(171, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 20)
        Label3.TabIndex = 5
        Label3.Text = "Event time (LiveLogs):"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = Color.RoyalBlue
        lblTime.Location = New Point(301, 20)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(78, 15)
        lblTime.TabIndex = 6
        lblTime.Text = "keyword here"
        lblTime.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(104, 86)
        Label4.Name = "Label4"
        Label4.Size = New Size(356, 20)
        Label4.TabIndex = 7
        Label4.Text = "Tip: Click on event text to copy it on the clipboard"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FrmPopup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(505, 104)
        Controls.Add(Label4)
        Controls.Add(lblTime)
        Controls.Add(Label3)
        Controls.Add(lblLine)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FrmPopup"
        ShowInTaskbar = False
        Text = "LiveLogs - Information"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLine As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label4 As Label
End Class
