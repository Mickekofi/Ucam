<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Departments
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
        Panel4 = New Panel()
        Label4 = New Label()
        btnSearch = New Button()
        txtSearch = New TextBox()
        dgvDepartments = New DataGridView()
        PanelInputBundle = New Panel()
        btnGenerateJson = New Button()
        txtJson = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        dtpYear = New DateTimePicker()
        txtQuota = New TextBox()
        Label2 = New Label()
        txtEmail = New TextBox()
        Label1 = New Label()
        txtName = New TextBox()
        Label3 = New Label()
        PanelRedDesign = New Panel()
        Panel3 = New Panel()
        btnAddDepartment = New Button()
        btnDeleteDepartment = New Button()
        btnUpdateDepartment = New Button()
        Panel1.SuspendLayout()
        PanelWithDgv.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgvDepartments, ComponentModel.ISupportInitialize).BeginInit()
        PanelInputBundle.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(PanelWithDgv)
        Panel1.Controls.Add(PanelInputBundle)
        Panel1.Controls.Add(PanelRedDesign)
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(2110, 1000)
        Panel1.TabIndex = 1
        ' 
        ' PanelWithDgv
        ' 
        PanelWithDgv.AutoScroll = True
        PanelWithDgv.BackColor = Color.White
        PanelWithDgv.Controls.Add(Panel4)
        PanelWithDgv.Controls.Add(dgvDepartments)
        PanelWithDgv.Location = New Point(0, 91)
        PanelWithDgv.Margin = New Padding(4, 5, 4, 5)
        PanelWithDgv.Name = "PanelWithDgv"
        PanelWithDgv.Size = New Size(2110, 909)
        PanelWithDgv.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(btnSearch)
        Panel4.Controls.Add(txtSearch)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Margin = New Padding(4, 5, 4, 5)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(2110, 70)
        Panel4.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(972, 24)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 33)
        Label4.TabIndex = 27
        Label4.Text = "Search"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.MediumSeaGreen
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Bold)
        btnSearch.ForeColor = Color.Transparent
        btnSearch.Location = New Point(950, 10)
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
        txtSearch.Location = New Point(1091, 19)
        txtSearch.Margin = New Padding(4, 5, 4, 5)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(294, 39)
        txtSearch.TabIndex = 26
        ' 
        ' dgvDepartments
        ' 
        dgvDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDepartments.BackgroundColor = Color.White
        dgvDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDepartments.Dock = DockStyle.Bottom
        dgvDepartments.Location = New Point(0, 70)
        dgvDepartments.Margin = New Padding(4, 5, 4, 5)
        dgvDepartments.Name = "dgvDepartments"
        dgvDepartments.ReadOnly = True
        dgvDepartments.RowHeadersWidth = 51
        dgvDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDepartments.Size = New Size(2110, 839)
        dgvDepartments.TabIndex = 0
        ' 
        ' PanelInputBundle
        ' 
        PanelInputBundle.BackColor = Color.White
        PanelInputBundle.Controls.Add(btnGenerateJson)
        PanelInputBundle.Controls.Add(txtJson)
        PanelInputBundle.Controls.Add(Label6)
        PanelInputBundle.Controls.Add(Label5)
        PanelInputBundle.Controls.Add(dtpYear)
        PanelInputBundle.Controls.Add(txtQuota)
        PanelInputBundle.Controls.Add(Label2)
        PanelInputBundle.Controls.Add(txtEmail)
        PanelInputBundle.Controls.Add(Label1)
        PanelInputBundle.Controls.Add(txtName)
        PanelInputBundle.Controls.Add(Label3)
        PanelInputBundle.Location = New Point(436, 86)
        PanelInputBundle.Margin = New Padding(4, 5, 4, 5)
        PanelInputBundle.Name = "PanelInputBundle"
        PanelInputBundle.Size = New Size(784, 861)
        PanelInputBundle.TabIndex = 0
        ' 
        ' btnGenerateJson
        ' 
        btnGenerateJson.BackColor = Color.MediumSeaGreen
        btnGenerateJson.FlatAppearance.BorderSize = 0
        btnGenerateJson.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Bold)
        btnGenerateJson.ForeColor = Color.Transparent
        btnGenerateJson.Location = New Point(19, 675)
        btnGenerateJson.Margin = New Padding(4, 5, 4, 5)
        btnGenerateJson.Name = "btnGenerateJson"
        btnGenerateJson.Size = New Size(364, 60)
        btnGenerateJson.TabIndex = 27
        btnGenerateJson.Text = "Generate Applicant Eligibility Code"
        btnGenerateJson.UseVisualStyleBackColor = False
        ' 
        ' txtJson
        ' 
        txtJson.BackColor = SystemColors.Info
        txtJson.Font = New Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtJson.ForeColor = SystemColors.ActiveCaptionText
        txtJson.Location = New Point(24, 745)
        txtJson.Margin = New Padding(4, 5, 4, 5)
        txtJson.Multiline = True
        txtJson.Name = "txtJson"
        txtJson.Size = New Size(733, 59)
        txtJson.TabIndex = 26
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
        Label6.Size = New Size(584, 51)
        Label6.TabIndex = 15
        Label6.Text = "Create A New Department"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Garamond", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(538, 480)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 36)
        Label5.TabIndex = 23
        Label5.Text = "Year"
        ' 
        ' dtpYear
        ' 
        dtpYear.CalendarMonthBackground = SystemColors.Info
        dtpYear.CustomFormat = "yyyy"
        dtpYear.Font = New Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpYear.Format = DateTimePickerFormat.Custom
        dtpYear.Location = New Point(399, 536)
        dtpYear.Margin = New Padding(4, 5, 4, 5)
        dtpYear.MinDate = New Date(2025, 1, 31, 0, 0, 0, 0)
        dtpYear.Name = "dtpYear"
        dtpYear.Size = New Size(358, 48)
        dtpYear.TabIndex = 22
        ' 
        ' txtQuota
        ' 
        txtQuota.BackColor = SystemColors.Info
        txtQuota.Font = New Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtQuota.ForeColor = SystemColors.ActiveCaptionText
        txtQuota.Location = New Point(19, 539)
        txtQuota.Margin = New Padding(4, 5, 4, 5)
        txtQuota.Name = "txtQuota"
        txtQuota.Size = New Size(340, 48)
        txtQuota.TabIndex = 19
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(19, 485)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(262, 33)
        Label2.TabIndex = 18
        Label2.Text = "*Department Quota"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.Info
        txtEmail.Font = New Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtEmail.ForeColor = SystemColors.ActiveCaptionText
        txtEmail.Location = New Point(19, 376)
        txtEmail.Margin = New Padding(4, 5, 4, 5)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(733, 48)
        txtEmail.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(19, 304)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(260, 33)
        Label1.TabIndex = 16
        Label1.Text = "*Department Email"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.Ivory
        txtName.Font = New Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtName.ForeColor = SystemColors.ActiveCaptionText
        txtName.Location = New Point(19, 191)
        txtName.Margin = New Padding(4, 5, 4, 5)
        txtName.Name = "txtName"
        txtName.Size = New Size(726, 48)
        txtName.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(16, 135)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(261, 33)
        Label3.TabIndex = 14
        Label3.Text = "*Department Name"
        ' 
        ' PanelRedDesign
        ' 
        PanelRedDesign.BackColor = Color.Red
        PanelRedDesign.Location = New Point(418, 120)
        PanelRedDesign.Margin = New Padding(4, 5, 4, 5)
        PanelRedDesign.Name = "PanelRedDesign"
        PanelRedDesign.Size = New Size(678, 859)
        PanelRedDesign.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Black
        Panel3.Controls.Add(btnAddDepartment)
        Panel3.Controls.Add(btnDeleteDepartment)
        Panel3.Controls.Add(btnUpdateDepartment)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Margin = New Padding(4, 5, 4, 5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(2110, 95)
        Panel3.TabIndex = 1
        ' 
        ' btnAddDepartment
        ' 
        btnAddDepartment.BackColor = Color.White
        btnAddDepartment.FlatAppearance.BorderSize = 0
        btnAddDepartment.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Bold)
        btnAddDepartment.ForeColor = Color.Black
        btnAddDepartment.Location = New Point(358, 16)
        btnAddDepartment.Margin = New Padding(4, 5, 4, 5)
        btnAddDepartment.Name = "btnAddDepartment"
        btnAddDepartment.Size = New Size(342, 60)
        btnAddDepartment.TabIndex = 12
        btnAddDepartment.Text = "Create Department"
        btnAddDepartment.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteDepartment
        ' 
        btnDeleteDepartment.BackColor = Color.White
        btnDeleteDepartment.FlatAppearance.BorderSize = 0
        btnDeleteDepartment.Font = New Font("Arial Rounded MT Bold", 12F)
        btnDeleteDepartment.ForeColor = Color.Black
        btnDeleteDepartment.Location = New Point(1150, 16)
        btnDeleteDepartment.Margin = New Padding(4, 5, 4, 5)
        btnDeleteDepartment.Name = "btnDeleteDepartment"
        btnDeleteDepartment.Size = New Size(342, 60)
        btnDeleteDepartment.TabIndex = 14
        btnDeleteDepartment.Text = "Delete Department"
        btnDeleteDepartment.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateDepartment
        ' 
        btnUpdateDepartment.BackColor = Color.White
        btnUpdateDepartment.FlatAppearance.BorderSize = 0
        btnUpdateDepartment.Font = New Font("Arial Rounded MT Bold", 12F)
        btnUpdateDepartment.ForeColor = Color.Black
        btnUpdateDepartment.Location = New Point(754, 16)
        btnUpdateDepartment.Margin = New Padding(4, 5, 4, 5)
        btnUpdateDepartment.Name = "btnUpdateDepartment"
        btnUpdateDepartment.Size = New Size(342, 60)
        btnUpdateDepartment.TabIndex = 13
        btnUpdateDepartment.Text = "Update Department"
        btnUpdateDepartment.UseVisualStyleBackColor = False
        ' 
        ' UC_Departments
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "UC_Departments"
        Size = New Size(2110, 1000)
        Panel1.ResumeLayout(False)
        PanelWithDgv.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dgvDepartments, ComponentModel.ISupportInitialize).EndInit()
        PanelInputBundle.ResumeLayout(False)
        PanelInputBundle.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelInputBundle As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpYear As DateTimePicker
    Friend WithEvents txtQuota As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddDepartment As Button
    Friend WithEvents btnDeleteDepartment As Button
    Friend WithEvents btnUpdateDepartment As Button
    Friend WithEvents PanelRedDesign As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelWithDgv As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvDepartments As DataGridView
    Friend WithEvents txtJson As TextBox
    Friend WithEvents btnGenerateJson As Button
    Friend WithEvents Label4 As Label

End Class
