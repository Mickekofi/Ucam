<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuperAdminDashboard
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
        LinkLabel5 = New LinkLabel()
        Panel2 = New Panel()
        Label6 = New Label()
        btnReports = New Button()
        btnAdmins = New Button()
        btnPrograms = New Button()
        lblRecentActivity = New Label()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        gifBox = New PictureBox()
        PictureBox2 = New PictureBox()
        panelLeft = New Panel()
        btnDepartments = New Button()
        MenuStrip1 = New MenuStrip()
        MoreToolStripMenuItem = New ToolStripMenuItem()
        LogOutToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        pnlMainContent = New Panel()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(gifBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        panelLeft.SuspendLayout()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        pnlMainContent.SuspendLayout()
        SuspendLayout()
        ' 
        ' LinkLabel5
        ' 
        LinkLabel5.ActiveLinkColor = Color.Red
        LinkLabel5.AutoSize = True
        LinkLabel5.Font = New Font("Segoe UI", 8.25F)
        LinkLabel5.LinkColor = Color.Blue
        LinkLabel5.Location = New Point(1551, 1001)
        LinkLabel5.Margin = New Padding(4, 0, 4, 0)
        LinkLabel5.Name = "LinkLabel5"
        LinkLabel5.Size = New Size(490, 23)
        LinkLabel5.TabIndex = 6
        LinkLabel5.TabStop = True
        LinkLabel5.Text = "Find Our OpenSouce Project Achitecture and Documentation ?"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.ForeColor = SystemColors.ControlText
        Panel2.Location = New Point(501, 72)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(591, 95)
        Panel2.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Garamond", 25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(14, 25)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(646, 56)
        Label6.TabIndex = 16
        Label6.Text = "@SUPER ADMIN PORTAL"
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = SystemColors.ActiveCaptionText
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.Font = New Font("Arial Rounded MT Bold", 12F)
        btnReports.ForeColor = Color.White
        btnReports.Location = New Point(0, 480)
        btnReports.Margin = New Padding(4, 5, 4, 5)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(10, 95)
        btnReports.TabIndex = 6
        btnReports.Text = "Procees Reports"
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnAdmins
        ' 
        btnAdmins.BackColor = SystemColors.ActiveCaptionText
        btnAdmins.FlatAppearance.BorderSize = 0
        btnAdmins.Font = New Font("Arial Rounded MT Bold", 12F)
        btnAdmins.ForeColor = Color.White
        btnAdmins.Location = New Point(16, 755)
        btnAdmins.Margin = New Padding(4, 5, 4, 5)
        btnAdmins.Name = "btnAdmins"
        btnAdmins.Size = New Size(342, 91)
        btnAdmins.TabIndex = 5
        btnAdmins.Text = "Manage Admins"
        btnAdmins.UseVisualStyleBackColor = False
        ' 
        ' btnPrograms
        ' 
        btnPrograms.BackColor = SystemColors.ActiveCaptionText
        btnPrograms.FlatAppearance.BorderSize = 0
        btnPrograms.Font = New Font("Arial Rounded MT Bold", 12F)
        btnPrograms.ForeColor = Color.White
        btnPrograms.Location = New Point(16, 624)
        btnPrograms.Margin = New Padding(4, 5, 4, 5)
        btnPrograms.Name = "btnPrograms"
        btnPrograms.Size = New Size(342, 85)
        btnPrograms.TabIndex = 4
        btnPrograms.Text = "Manage Programs"
        btnPrograms.UseVisualStyleBackColor = False
        ' 
        ' lblRecentActivity
        ' 
        lblRecentActivity.AllowDrop = True
        lblRecentActivity.AutoEllipsis = True
        lblRecentActivity.AutoSize = True
        lblRecentActivity.Font = New Font("Garamond", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRecentActivity.ForeColor = Color.Teal
        lblRecentActivity.Location = New Point(602, 242)
        lblRecentActivity.Margin = New Padding(4, 0, 4, 0)
        lblRecentActivity.Name = "lblRecentActivity"
        lblRecentActivity.Size = New Size(326, 46)
        lblRecentActivity.TabIndex = 0
        lblRecentActivity.Text = "No Recent Activity"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Red
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(548, 58)
        Panel3.Margin = New Padding(4, 5, 4, 5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(709, 91)
        Panel3.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.greenhat
        PictureBox1.Location = New Point(92, 142)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(185, 188)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' gifBox
        ' 
        gifBox.BackColor = Color.Transparent
        gifBox.Image = My.Resources.Resources.useshape2
        gifBox.Location = New Point(-94, 72)
        gifBox.Margin = New Padding(4, 5, 4, 5)
        gifBox.Name = "gifBox"
        gifBox.Size = New Size(502, 339)
        gifBox.SizeMode = PictureBoxSizeMode.StretchImage
        gifBox.TabIndex = 2
        gifBox.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(562, 293)
        PictureBox2.Margin = New Padding(4, 5, 4, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(773, 666)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' panelLeft
        ' 
        panelLeft.AutoScroll = True
        panelLeft.BackColor = Color.Black
        panelLeft.BorderStyle = BorderStyle.FixedSingle
        panelLeft.Controls.Add(btnReports)
        panelLeft.Controls.Add(btnAdmins)
        panelLeft.Controls.Add(btnPrograms)
        panelLeft.Controls.Add(PictureBox1)
        panelLeft.Controls.Add(gifBox)
        panelLeft.Controls.Add(btnDepartments)
        panelLeft.Controls.Add(MenuStrip1)
        panelLeft.Dock = DockStyle.Left
        panelLeft.ForeColor = Color.MintCream
        panelLeft.Location = New Point(0, 0)
        panelLeft.Margin = New Padding(4, 5, 4, 5)
        panelLeft.Name = "panelLeft"
        panelLeft.Size = New Size(401, 1016)
        panelLeft.TabIndex = 3
        ' 
        ' btnDepartments
        ' 
        btnDepartments.BackColor = SystemColors.ActiveCaptionText
        btnDepartments.FlatAppearance.BorderSize = 0
        btnDepartments.Font = New Font("Arial Rounded MT Bold", 12F)
        btnDepartments.ForeColor = Color.White
        btnDepartments.Location = New Point(16, 480)
        btnDepartments.Margin = New Padding(4, 5, 4, 5)
        btnDepartments.Name = "btnDepartments"
        btnDepartments.Size = New Size(342, 95)
        btnDepartments.TabIndex = 1
        btnDepartments.Text = "Manage Departments"
        btnDepartments.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MoreToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 2, 0, 2)
        MenuStrip1.Size = New Size(408, 33)
        MenuStrip1.TabIndex = 10
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MoreToolStripMenuItem
        ' 
        MoreToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LogOutToolStripMenuItem})
        MoreToolStripMenuItem.Name = "MoreToolStripMenuItem"
        MoreToolStripMenuItem.Size = New Size(139, 29)
        MoreToolStripMenuItem.Text = "More Options"
        ' 
        ' LogOutToolStripMenuItem
        ' 
        LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        LogOutToolStripMenuItem.Size = New Size(182, 34)
        LogOutToolStripMenuItem.Text = "LOGOUT"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(panelLeft)
        Panel1.Controls.Add(pnlMainContent)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1924, 1016)
        Panel1.TabIndex = 1
        ' 
        ' pnlMainContent
        ' 
        pnlMainContent.AutoScroll = True
        pnlMainContent.BackColor = Color.White
        pnlMainContent.BorderStyle = BorderStyle.FixedSingle
        pnlMainContent.Controls.Add(lblRecentActivity)
        pnlMainContent.Controls.Add(Panel3)
        pnlMainContent.Controls.Add(LinkLabel5)
        pnlMainContent.Controls.Add(PictureBox2)
        pnlMainContent.Controls.Add(Panel2)
        pnlMainContent.Dock = DockStyle.Right
        pnlMainContent.ForeColor = SystemColors.InactiveBorder
        pnlMainContent.Location = New Point(404, 0)
        pnlMainContent.Margin = New Padding(571, 5, 4, 5)
        pnlMainContent.Name = "pnlMainContent"
        pnlMainContent.Size = New Size(1520, 1016)
        pnlMainContent.TabIndex = 2
        ' 
        ' SuperAdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1016)
        Controls.Add(Panel1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 5, 4, 5)
        Name = "SuperAdminDashboard"
        Text = "SuperAdminDashboard"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(gifBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        panelLeft.ResumeLayout(False)
        panelLeft.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        pnlMainContent.ResumeLayout(False)
        pnlMainContent.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnReports As Button
    Friend WithEvents btnAdmins As Button
    Friend WithEvents btnPrograms As Button
    Friend WithEvents lblRecentActivity As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gifBox As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents panelLeft As Panel
    Friend WithEvents btnDepartments As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem


End Class
