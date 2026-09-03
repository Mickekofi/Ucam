<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartmentalAdminDashboard
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
        btnAutoAdmissions = New Button()
        PictureBox1 = New PictureBox()
        lblDepartment = New Label()
        lblRecentActivity = New Label()
        Panel3 = New Panel()
        gifBox = New PictureBox()
        btnAdmissions = New Button()
        PictureBox2 = New PictureBox()
        panelLeft = New Panel()
        MenuStrip1 = New MenuStrip()
        MoreOptionsToolStripMenuItem = New ToolStripMenuItem()
        LOGOUTToolStripMenuItem = New ToolStripMenuItem()
        pnlMainContent = New Panel()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(gifBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        panelLeft.SuspendLayout()
        MenuStrip1.SuspendLayout()
        pnlMainContent.SuspendLayout()
        Panel1.SuspendLayout()
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
        Panel2.Location = New Point(501, 72)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(591, 95)
        Panel2.TabIndex = 7
        ' 
        ' btnAutoAdmissions
        ' 
        btnAutoAdmissions.BackColor = Color.Black
        btnAutoAdmissions.FlatAppearance.BorderSize = 0
        btnAutoAdmissions.Font = New Font("Arial Rounded MT Bold", 12F)
        btnAutoAdmissions.ForeColor = Color.Transparent
        btnAutoAdmissions.Location = New Point(31, 720)
        btnAutoAdmissions.Margin = New Padding(4, 5, 4, 5)
        btnAutoAdmissions.Name = "btnAutoAdmissions"
        btnAutoAdmissions.Size = New Size(342, 85)
        btnAutoAdmissions.TabIndex = 4
        btnAutoAdmissions.Text = "Auto Admissions"
        btnAutoAdmissions.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.greenhat
        PictureBox1.Location = New Point(154, 208)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(128, 156)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.BackColor = Color.Transparent
        lblDepartment.Font = New Font("Garamond", 25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartment.ForeColor = Color.White
        lblDepartment.Location = New Point(14, 25)
        lblDepartment.Margin = New Padding(4, 0, 4, 0)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(620, 56)
        lblDepartment.TabIndex = 16
        lblDepartment.Text = "@DEPT ADMIN PORTAL"
        ' 
        ' lblRecentActivity
        ' 
        lblRecentActivity.AllowDrop = True
        lblRecentActivity.AutoEllipsis = True
        lblRecentActivity.AutoSize = True
        lblRecentActivity.Font = New Font("Garamond", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRecentActivity.ForeColor = Color.Teal
        lblRecentActivity.Location = New Point(782, 293)
        lblRecentActivity.Margin = New Padding(4, 0, 4, 0)
        lblRecentActivity.Name = "lblRecentActivity"
        lblRecentActivity.Size = New Size(326, 46)
        lblRecentActivity.TabIndex = 0
        lblRecentActivity.Text = "No Recent Activity"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Red
        Panel3.Controls.Add(lblDepartment)
        Panel3.Location = New Point(548, 58)
        Panel3.Margin = New Padding(4, 5, 4, 5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(709, 91)
        Panel3.TabIndex = 8
        ' 
        ' gifBox
        ' 
        gifBox.BackColor = Color.Transparent
        gifBox.Image = My.Resources.Resources.useshape2
        gifBox.Location = New Point(-16, 146)
        gifBox.Margin = New Padding(4, 5, 4, 5)
        gifBox.Name = "gifBox"
        gifBox.Size = New Size(420, 276)
        gifBox.SizeMode = PictureBoxSizeMode.StretchImage
        gifBox.TabIndex = 2
        gifBox.TabStop = False
        ' 
        ' btnAdmissions
        ' 
        btnAdmissions.BackColor = Color.Black
        btnAdmissions.FlatAppearance.BorderSize = 0
        btnAdmissions.Font = New Font("Arial Rounded MT Bold", 12F)
        btnAdmissions.ForeColor = Color.Transparent
        btnAdmissions.Location = New Point(12, 715)
        btnAdmissions.Margin = New Padding(4, 5, 4, 5)
        btnAdmissions.Name = "btnAdmissions"
        btnAdmissions.Size = New Size(12, 95)
        btnAdmissions.TabIndex = 1
        btnAdmissions.Text = "Manual Admissions"
        btnAdmissions.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(478, 272)
        PictureBox2.Margin = New Padding(4, 5, 4, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(790, 666)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' panelLeft
        ' 
        panelLeft.AutoScroll = True
        panelLeft.BackColor = Color.Black
        panelLeft.BorderStyle = BorderStyle.FixedSingle
        panelLeft.Controls.Add(btnAutoAdmissions)
        panelLeft.Controls.Add(PictureBox1)
        panelLeft.Controls.Add(gifBox)
        panelLeft.Controls.Add(btnAdmissions)
        panelLeft.Controls.Add(MenuStrip1)
        panelLeft.Dock = DockStyle.Left
        panelLeft.ForeColor = Color.MintCream
        panelLeft.Location = New Point(0, 0)
        panelLeft.Margin = New Padding(4, 5, 4, 5)
        panelLeft.Name = "panelLeft"
        panelLeft.Size = New Size(410, 969)
        panelLeft.TabIndex = 3
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MoreOptionsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 2, 0, 2)
        MenuStrip1.Size = New Size(408, 33)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MoreOptionsToolStripMenuItem
        ' 
        MoreOptionsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LOGOUTToolStripMenuItem})
        MoreOptionsToolStripMenuItem.Name = "MoreOptionsToolStripMenuItem"
        MoreOptionsToolStripMenuItem.Size = New Size(139, 29)
        MoreOptionsToolStripMenuItem.Text = "More Options"
        ' 
        ' LOGOUTToolStripMenuItem
        ' 
        LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        LOGOUTToolStripMenuItem.Size = New Size(182, 34)
        LOGOUTToolStripMenuItem.Text = "LOGOUT"
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
        pnlMainContent.Location = New Point(411, 0)
        pnlMainContent.Margin = New Padding(571, 5, 4, 5)
        pnlMainContent.Name = "pnlMainContent"
        pnlMainContent.Size = New Size(1513, 969)
        pnlMainContent.TabIndex = 2
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
        Panel1.Size = New Size(1924, 969)
        Panel1.TabIndex = 1
        ' 
        ' DepartmentalAdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 969)
        Controls.Add(Panel1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4)
        Name = "DepartmentalAdminDashboard"
        Text = "DepartmentalAdminDashboard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(gifBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        panelLeft.ResumeLayout(False)
        panelLeft.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        pnlMainContent.ResumeLayout(False)
        pnlMainContent.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAutoAdmissions As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblRecentActivity As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents gifBox As PictureBox
    Friend WithEvents btnAdmissions As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents panelLeft As Panel
    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MoreOptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
End Class
