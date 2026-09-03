<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PanelLeft = New Panel()
        lblRecentActivity = New Label()
        pnlMainContent = New Panel()
        PictureBox1 = New PictureBox()
        btnLogout = New Button()
        btnReports = New Button()
        btnAdmins = New Button()
        btnPrograms = New Button()
        btnDepartments = New Button()
        lblWelcome = New Label()
        PanelLeft.SuspendLayout()
        pnlMainContent.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelLeft
        ' 
        PanelLeft.BackColor = Color.White
        PanelLeft.BorderStyle = BorderStyle.FixedSingle
        PanelLeft.Controls.Add(lblRecentActivity)
        PanelLeft.Dock = DockStyle.Right
        PanelLeft.ForeColor = SystemColors.InactiveBorder
        PanelLeft.Location = New Point(316, 0)
        PanelLeft.Name = "PanelLeft"
        PanelLeft.Size = New Size(484, 450)
        PanelLeft.TabIndex = 0
        ' 
        ' lblRecentActivity
        ' 
        lblRecentActivity.AllowDrop = True
        lblRecentActivity.AutoEllipsis = True
        lblRecentActivity.AutoSize = True
        lblRecentActivity.Font = New Font("Segoe UI", 27F)
        lblRecentActivity.ForeColor = Color.Teal
        lblRecentActivity.Location = New Point(120, 160)
        lblRecentActivity.Name = "lblRecentActivity"
        lblRecentActivity.Size = New Size(312, 48)
        lblRecentActivity.TabIndex = 0
        lblRecentActivity.Text = "No Recent Activity"
        ' 
        ' pnlMainContent
        ' 
        pnlMainContent.BackColor = Color.Teal
        pnlMainContent.BorderStyle = BorderStyle.FixedSingle
        pnlMainContent.Controls.Add(PictureBox1)
        pnlMainContent.Controls.Add(btnLogout)
        pnlMainContent.Controls.Add(btnReports)
        pnlMainContent.Controls.Add(btnAdmins)
        pnlMainContent.Controls.Add(btnPrograms)
        pnlMainContent.Controls.Add(btnDepartments)
        pnlMainContent.Controls.Add(lblWelcome)
        pnlMainContent.Dock = DockStyle.Fill
        pnlMainContent.ForeColor = Color.MintCream
        pnlMainContent.Location = New Point(0, 0)
        pnlMainContent.Name = "pnlMainContent"
        pnlMainContent.Size = New Size(316, 450)
        pnlMainContent.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(89, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(91, 90)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.MediumAquamarine
        btnLogout.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnLogout.Location = New Point(22, 389)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(75, 27)
        btnLogout.TabIndex = 5
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Color.MediumAquamarine
        btnReports.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnReports.Location = New Point(22, 335)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(136, 26)
        btnReports.TabIndex = 4
        btnReports.Text = "View Report"
        btnReports.TextAlign = ContentAlignment.MiddleLeft
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnAdmins
        ' 
        btnAdmins.BackColor = Color.MediumAquamarine
        btnAdmins.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnAdmins.Location = New Point(22, 283)
        btnAdmins.Name = "btnAdmins"
        btnAdmins.Size = New Size(158, 27)
        btnAdmins.TabIndex = 3
        btnAdmins.Text = "Manage Admins"
        btnAdmins.TextAlign = ContentAlignment.MiddleLeft
        btnAdmins.UseVisualStyleBackColor = False
        ' 
        ' btnPrograms
        ' 
        btnPrograms.BackColor = Color.MediumAquamarine
        btnPrograms.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnPrograms.Location = New Point(22, 230)
        btnPrograms.Name = "btnPrograms"
        btnPrograms.Size = New Size(158, 29)
        btnPrograms.TabIndex = 2
        btnPrograms.Text = "Manage Programs"
        btnPrograms.TextAlign = ContentAlignment.MiddleLeft
        btnPrograms.UseVisualStyleBackColor = False
        ' 
        ' btnDepartments
        ' 
        btnDepartments.BackColor = Color.MediumAquamarine
        btnDepartments.FlatAppearance.BorderSize = 0
        btnDepartments.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDepartments.Location = New Point(22, 181)
        btnDepartments.Name = "btnDepartments"
        btnDepartments.Size = New Size(175, 27)
        btnDepartments.TabIndex = 1
        btnDepartments.Text = "Manage  Department"
        btnDepartments.TextAlign = ContentAlignment.MiddleLeft
        btnDepartments.UseVisualStyleBackColor = False
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblWelcome.ForeColor = SystemColors.ButtonHighlight
        lblWelcome.Location = New Point(37, 105)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(211, 25)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome, Super Admin"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pnlMainContent)
        Controls.Add(PanelLeft)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form1"
        Text = "Form1"
        PanelLeft.ResumeLayout(False)
        PanelLeft.PerformLayout()
        pnlMainContent.ResumeLayout(False)
        pnlMainContent.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelLeft As Panel
    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnPrograms As Button
    Friend WithEvents btnDepartments As Button
    Friend WithEvents btnAdmins As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblRecentActivity As Label

End Class
