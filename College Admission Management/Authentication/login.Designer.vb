<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Panel1 = New Panel()
        Panel3 = New Panel()
        lblUserlogin = New Label()
        PictureBox1 = New PictureBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        lblUsername = New Label()
        lblPassword = New Label()
        lblStatus = New Label()
        Panel2 = New Panel()
        fadeTimer2 = New Timer(components)
        txtUserName = New TextBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(lblStatus)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1861, 936)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(txtUserName)
        Panel3.Controls.Add(lblUserlogin)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(txtPassword)
        Panel3.Controls.Add(btnLogin)
        Panel3.Controls.Add(lblUsername)
        Panel3.Controls.Add(lblPassword)
        Panel3.Location = New Point(519, 14)
        Panel3.Margin = New Padding(4, 5, 4, 5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1083, 959)
        Panel3.TabIndex = 11
        ' 
        ' lblUserlogin
        ' 
        lblUserlogin.AutoSize = True
        lblUserlogin.BackColor = Color.White
        lblUserlogin.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUserlogin.Location = New Point(595, 298)
        lblUserlogin.Margin = New Padding(4, 0, 4, 0)
        lblUserlogin.Name = "lblUserlogin"
        lblUserlogin.Size = New Size(325, 54)
        lblUserlogin.TabIndex = 0
        lblUserlogin.Text = "USER LOGIN"
        lblUserlogin.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Location = New Point(148, 103)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(392, 382)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        txtPassword.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(205, 662)
        txtPassword.Margin = New Padding(4, 5, 4, 5)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(814, 40)
        txtPassword.TabIndex = 4
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Red
        btnLogin.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.LavenderBlush
        btnLogin.Location = New Point(148, 768)
        btnLogin.Margin = New Padding(4, 5, 4, 5)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(506, 71)
        btnLogin.TabIndex = 2
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.White
        lblUsername.Font = New Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(53, 562)
        lblUsername.Margin = New Padding(4, 0, 4, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(115, 27)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.White
        lblPassword.Font = New Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(55, 671)
        lblPassword.Margin = New Padding(4, 0, 4, 0)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(110, 27)
        lblPassword.TabIndex = 5
        lblPassword.Text = "Password"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(803, 600)
        lblStatus.Margin = New Padding(4, 0, 4, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(0, 25)
        lblStatus.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(490, 135)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(47, 787)
        Panel2.TabIndex = 12
        ' 
        ' fadeTimer2
        ' 
        fadeTimer2.Interval = 30
        ' 
        ' txtUserName
        ' 
        txtUserName.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        txtUserName.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUserName.Location = New Point(191, 549)
        txtUserName.Margin = New Padding(4, 5, 4, 5)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(814, 40)
        txtUserName.TabIndex = 9
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1861, 936)
        Controls.Add(Panel1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "login"
        Text = "login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblUserlogin As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents fadeTimer2 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtUserName As TextBox
End Class
