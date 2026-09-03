<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Users
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Panel1 = New Panel()
        PanelWithDgv = New Panel()
        PanelWithSearch = New Panel()
        Label2 = New Label()
        btnSearch = New Button()
        txtSearch = New TextBox()
        dgvUsers = New DataGridView()
        PanelInputBundle = New Panel()
        lblpass = New Label()
        txtPassword = New TextBox()
        cmbDepartment = New ComboBox()
        LinkLabel2 = New LinkLabel()
        Label6 = New Label()
        Label1 = New Label()
        txtUsername = New TextBox()
        Label3 = New Label()
        PanelRedDesign = New Panel()
        PanelWithCrudButtons = New Panel()
        btnAddDepartmentalAdmin = New Button()
        btnDeleteDepartmentalAdmin = New Button()
        btnUpdateDepartmentalAdmin = New Button()
        Panel1.SuspendLayout()
        PanelWithDgv.SuspendLayout()
        PanelWithSearch.SuspendLayout()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        PanelInputBundle.SuspendLayout()
        PanelWithCrudButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Azure
        Panel1.Controls.Add(PanelWithDgv)
        Panel1.Controls.Add(PanelInputBundle)
        Panel1.Controls.Add(PanelRedDesign)
        Panel1.Controls.Add(PanelWithCrudButtons)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1922, 995)
        Panel1.TabIndex = 3
        ' 
        ' PanelWithDgv
        ' 
        PanelWithDgv.AutoScroll = True
        PanelWithDgv.BackColor = Color.White
        PanelWithDgv.Controls.Add(PanelWithSearch)
        PanelWithDgv.Controls.Add(dgvUsers)
        PanelWithDgv.Location = New Point(0, 76)
        PanelWithDgv.Margin = New Padding(4, 5, 4, 5)
        PanelWithDgv.Name = "PanelWithDgv"
        PanelWithDgv.Size = New Size(1922, 919)
        PanelWithDgv.TabIndex = 2
        ' 
        ' PanelWithSearch
        ' 
        PanelWithSearch.BackColor = Color.White
        PanelWithSearch.Controls.Add(Label2)
        PanelWithSearch.Controls.Add(btnSearch)
        PanelWithSearch.Controls.Add(txtSearch)
        PanelWithSearch.Dock = DockStyle.Top
        PanelWithSearch.Location = New Point(0, 0)
        PanelWithSearch.Margin = New Padding(4, 5, 4, 5)
        PanelWithSearch.Name = "PanelWithSearch"
        PanelWithSearch.Size = New Size(1896, 70)
        PanelWithSearch.TabIndex = 27
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(964, 16)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 33)
        Label2.TabIndex = 29
        Label2.Text = "*Search"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.MediumSeaGreen
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Bold)
        btnSearch.ForeColor = Color.Transparent
        btnSearch.Location = New Point(901, 11)
        btnSearch.Margin = New Padding(4, 5, 4, 5)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(14, 60)
        btnSearch.TabIndex = 15
        btnSearch.Text = "Go search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = SystemColors.Info
        txtSearch.Font = New Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = SystemColors.ActiveCaptionText
        txtSearch.Location = New Point(1091, 11)
        txtSearch.Margin = New Padding(4, 5, 4, 5)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(215, 39)
        txtSearch.TabIndex = 26
        ' 
        ' dgvUsers
        ' 
        dgvUsers.BackgroundColor = Color.White
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.Dock = DockStyle.Bottom
        dgvUsers.Location = New Point(0, 70)
        dgvUsers.Margin = New Padding(4, 5, 4, 5)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.ReadOnly = True
        dgvUsers.RowHeadersWidth = 51
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsers.Size = New Size(1896, 2366)
        dgvUsers.TabIndex = 0
        ' 
        ' PanelInputBundle
        ' 
        PanelInputBundle.BackColor = Color.White
        PanelInputBundle.Controls.Add(lblpass)
        PanelInputBundle.Controls.Add(txtPassword)
        PanelInputBundle.Controls.Add(cmbDepartment)
        PanelInputBundle.Controls.Add(LinkLabel2)
        PanelInputBundle.Controls.Add(Label6)
        PanelInputBundle.Controls.Add(Label1)
        PanelInputBundle.Controls.Add(txtUsername)
        PanelInputBundle.Controls.Add(Label3)
        PanelInputBundle.Location = New Point(436, 86)
        PanelInputBundle.Margin = New Padding(4, 5, 4, 5)
        PanelInputBundle.Name = "PanelInputBundle"
        PanelInputBundle.Size = New Size(784, 861)
        PanelInputBundle.TabIndex = 0
        ' 
        ' lblpass
        ' 
        lblpass.AutoSize = True
        lblpass.BackColor = Color.Transparent
        lblpass.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblpass.ForeColor = Color.Black
        lblpass.Location = New Point(19, 409)
        lblpass.Margin = New Padding(4, 0, 4, 0)
        lblpass.Name = "lblpass"
        lblpass.Size = New Size(235, 33)
        lblpass.TabIndex = 28
        lblpass.Text = "*Admin password"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Ivory
        txtPassword.Font = New Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = SystemColors.ActiveCaptionText
        txtPassword.Location = New Point(16, 465)
        txtPassword.Margin = New Padding(4, 5, 4, 5)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(726, 48)
        txtPassword.TabIndex = 27
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.BackColor = SystemColors.Info
        cmbDepartment.Font = New Font("Garamond", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbDepartment.ForeColor = Color.Red
        cmbDepartment.FormattingEnabled = True
        cmbDepartment.Location = New Point(19, 641)
        cmbDepartment.Margin = New Padding(4, 5, 4, 5)
        cmbDepartment.Name = "cmbDepartment"
        cmbDepartment.Size = New Size(726, 44)
        cmbDepartment.TabIndex = 26
        cmbDepartment.Text = "--Select Department--"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Segoe UI", 12F)
        LinkLabel2.Location = New Point(284, 811)
        LinkLabel2.Margin = New Padding(4, 0, 4, 0)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(211, 32)
        LinkLabel2.TabIndex = 25
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "I have a Problem ?"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(19, 19)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(625, 51)
        Label6.TabIndex = 15
        Label6.Text = "Create A New Administrator"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(19, 586)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(261, 33)
        Label1.TabIndex = 16
        Label1.Text = "*Department Name"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.Ivory
        txtUsername.Font = New Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = SystemColors.ActiveCaptionText
        txtUsername.Location = New Point(19, 261)
        txtUsername.Margin = New Padding(4, 5, 4, 5)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(726, 48)
        txtUsername.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(14, 196)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(239, 33)
        Label3.TabIndex = 14
        Label3.Text = "*Admin username"
        ' 
        ' PanelRedDesign
        ' 
        PanelRedDesign.BackColor = Color.Black
        PanelRedDesign.Location = New Point(418, 120)
        PanelRedDesign.Margin = New Padding(4, 5, 4, 5)
        PanelRedDesign.Name = "PanelRedDesign"
        PanelRedDesign.Size = New Size(678, 859)
        PanelRedDesign.TabIndex = 3
        ' 
        ' PanelWithCrudButtons
        ' 
        PanelWithCrudButtons.BackColor = Color.Black
        PanelWithCrudButtons.Controls.Add(btnAddDepartmentalAdmin)
        PanelWithCrudButtons.Controls.Add(btnDeleteDepartmentalAdmin)
        PanelWithCrudButtons.Controls.Add(btnUpdateDepartmentalAdmin)
        PanelWithCrudButtons.Dock = DockStyle.Top
        PanelWithCrudButtons.Location = New Point(0, 0)
        PanelWithCrudButtons.Margin = New Padding(4, 5, 4, 5)
        PanelWithCrudButtons.Name = "PanelWithCrudButtons"
        PanelWithCrudButtons.Size = New Size(1922, 76)
        PanelWithCrudButtons.TabIndex = 1
        ' 
        ' btnAddDepartmentalAdmin
        ' 
        btnAddDepartmentalAdmin.BackColor = Color.White
        btnAddDepartmentalAdmin.FlatAppearance.BorderSize = 0
        btnAddDepartmentalAdmin.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Bold)
        btnAddDepartmentalAdmin.ForeColor = Color.Black
        btnAddDepartmentalAdmin.Location = New Point(180, 5)
        btnAddDepartmentalAdmin.Margin = New Padding(4, 5, 4, 5)
        btnAddDepartmentalAdmin.Name = "btnAddDepartmentalAdmin"
        btnAddDepartmentalAdmin.Size = New Size(342, 60)
        btnAddDepartmentalAdmin.TabIndex = 12
        btnAddDepartmentalAdmin.Text = "Create ADMIN"
        btnAddDepartmentalAdmin.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteDepartmentalAdmin
        ' 
        btnDeleteDepartmentalAdmin.BackColor = Color.White
        btnDeleteDepartmentalAdmin.FlatAppearance.BorderSize = 0
        btnDeleteDepartmentalAdmin.Font = New Font("Arial Rounded MT Bold", 12F)
        btnDeleteDepartmentalAdmin.ForeColor = Color.Black
        btnDeleteDepartmentalAdmin.Location = New Point(1091, 5)
        btnDeleteDepartmentalAdmin.Margin = New Padding(4, 5, 4, 5)
        btnDeleteDepartmentalAdmin.Name = "btnDeleteDepartmentalAdmin"
        btnDeleteDepartmentalAdmin.Size = New Size(342, 60)
        btnDeleteDepartmentalAdmin.TabIndex = 14
        btnDeleteDepartmentalAdmin.Text = "Delete ADMIN"
        btnDeleteDepartmentalAdmin.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateDepartmentalAdmin
        ' 
        btnUpdateDepartmentalAdmin.BackColor = Color.White
        btnUpdateDepartmentalAdmin.FlatAppearance.BorderSize = 0
        btnUpdateDepartmentalAdmin.Font = New Font("Arial Rounded MT Bold", 12F)
        btnUpdateDepartmentalAdmin.ForeColor = Color.Black
        btnUpdateDepartmentalAdmin.Location = New Point(640, 5)
        btnUpdateDepartmentalAdmin.Margin = New Padding(4, 5, 4, 5)
        btnUpdateDepartmentalAdmin.Name = "btnUpdateDepartmentalAdmin"
        btnUpdateDepartmentalAdmin.Size = New Size(342, 60)
        btnUpdateDepartmentalAdmin.TabIndex = 13
        btnUpdateDepartmentalAdmin.Text = "Update ADMIN"
        btnUpdateDepartmentalAdmin.UseVisualStyleBackColor = False
        ' 
        ' UC_Users
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "UC_Users"
        Size = New Size(1922, 995)
        Panel1.ResumeLayout(False)
        PanelWithDgv.ResumeLayout(False)
        PanelWithSearch.ResumeLayout(False)
        PanelWithSearch.PerformLayout()
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        PanelInputBundle.ResumeLayout(False)
        PanelInputBundle.PerformLayout()
        PanelWithCrudButtons.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelWithDgv As Panel
    Friend WithEvents PanelWithSearch As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents PanelInputBundle As Panel
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelRedDesign As Panel
    Friend WithEvents PanelWithCrudButtons As Panel
    Friend WithEvents btnAddDepartmentalAdmin As Button
    Friend WithEvents btnDeleteDepartmentalAdmin As Button
    Friend WithEvents btnUpdateDepartmentalAdmin As Button
    Friend WithEvents lblpass As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label

End Class
