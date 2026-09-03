<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePasswordForm
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
        lblOldPassword = New Label()
        btnChangePass = New Button()
        lblChangePassword = New Label()
        txtOldPassword = New TextBox()
        txtNewPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        lblNewPassword = New Label()
        lblConfirmPass = New Label()
        SuspendLayout()
        ' 
        ' lblOldPassword
        ' 
        lblOldPassword.AutoSize = True
        lblOldPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOldPassword.Location = New Point(433, 191)
        lblOldPassword.Name = "lblOldPassword"
        lblOldPassword.Size = New Size(146, 28)
        lblOldPassword.TabIndex = 0
        lblOldPassword.Text = "Old Password "
        ' 
        ' btnChangePass
        ' 
        btnChangePass.BackColor = Color.Green
        btnChangePass.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnChangePass.Location = New Point(545, 616)
        btnChangePass.Margin = New Padding(3, 4, 3, 4)
        btnChangePass.Name = "btnChangePass"
        btnChangePass.Size = New Size(389, 64)
        btnChangePass.TabIndex = 1
        btnChangePass.Text = "Change"
        btnChangePass.UseVisualStyleBackColor = False
        ' 
        ' lblChangePassword
        ' 
        lblChangePassword.AutoSize = True
        lblChangePassword.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblChangePassword.Location = New Point(522, 71)
        lblChangePassword.Name = "lblChangePassword"
        lblChangePassword.Size = New Size(420, 54)
        lblChangePassword.TabIndex = 2
        lblChangePassword.Text = "CHANGE PASSWORD"
        lblChangePassword.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtOldPassword
        ' 
        txtOldPassword.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        txtOldPassword.Location = New Point(433, 240)
        txtOldPassword.Margin = New Padding(3, 4, 3, 4)
        txtOldPassword.Name = "txtOldPassword"
        txtOldPassword.Size = New Size(582, 27)
        txtOldPassword.TabIndex = 3
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        txtNewPassword.Location = New Point(433, 389)
        txtNewPassword.Margin = New Padding(3, 4, 3, 4)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(582, 27)
        txtNewPassword.TabIndex = 4
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        txtConfirmPassword.Location = New Point(433, 523)
        txtConfirmPassword.Margin = New Padding(3, 4, 3, 4)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(582, 27)
        txtConfirmPassword.TabIndex = 5
        ' 
        ' lblNewPassword
        ' 
        lblNewPassword.AutoSize = True
        lblNewPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNewPassword.Location = New Point(437, 352)
        lblNewPassword.Name = "lblNewPassword"
        lblNewPassword.Size = New Size(150, 28)
        lblNewPassword.TabIndex = 6
        lblNewPassword.Text = "New Password"
        ' 
        ' lblConfirmPass
        ' 
        lblConfirmPass.AutoSize = True
        lblConfirmPass.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblConfirmPass.Location = New Point(437, 477)
        lblConfirmPass.Name = "lblConfirmPass"
        lblConfirmPass.Size = New Size(183, 28)
        lblConfirmPass.TabIndex = 7
        lblConfirmPass.Text = "Confirm Password"
        ' 
        ' ChangePasswordForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1448, 761)
        Controls.Add(lblConfirmPass)
        Controls.Add(lblNewPassword)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtNewPassword)
        Controls.Add(txtOldPassword)
        Controls.Add(lblChangePassword)
        Controls.Add(btnChangePass)
        Controls.Add(lblOldPassword)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ChangePasswordForm"
        Text = "ChangePasswordForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblOldPassword As Label
    Friend WithEvents btnChangePass As Button
    Friend WithEvents lblChangePassword As Label
    Friend WithEvents txtOldPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents lblConfirmPass As Label
End Class
