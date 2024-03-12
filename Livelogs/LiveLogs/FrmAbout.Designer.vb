<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAbout))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Label5 = New Label()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.New_Patch_Ver1_250x250
        PictureBox1.Location = New Point(3, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(87, 65)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(52, 136)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 15)
        Label1.TabIndex = 1
        Label1.Text = "Livelogs"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(127, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 2
        Label2.Text = "Version"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(108, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 15)
        Label3.TabIndex = 3
        Label3.Text = "Hand Water Pump"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(108, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 4
        Label4.Text = "© 2024"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-3, 10)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(232, 123)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(-3, 201)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(255, 89)
        Panel1.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(0, 163)
        Label5.Name = "Label5"
        Label5.Size = New Size(229, 15)
        Label5.TabIndex = 7
        Label5.Text = "A live log viewer for Windows"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(-3, 10)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(232, 123)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        PictureBox3.Visible = False
        ' 
        ' FrmAbout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(228, 283)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox3)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmAbout"
        ShowInTaskbar = False
        Text = "Livelogs - About"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
