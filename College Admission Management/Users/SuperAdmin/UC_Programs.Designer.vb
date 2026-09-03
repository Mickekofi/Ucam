<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Programs
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
        btnSearch = New Button()
        txtSearch = New TextBox()
        dgvPrograms = New DataGridView()
        PanelInputBundle = New Panel()
        chkIsActive = New CheckBox()
        numUpDownMinAggregate = New NumericUpDown()
        cmbDepartment = New ComboBox()
        LinkLabel2 = New LinkLabel()
        Label6 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtProgramName = New TextBox()
        Label3 = New Label()
        PanelRedDesign = New Panel()
        PanelWithCrudButtons = New Panel()
        Panel2 = New Panel()
        btnAddProgram = New Button()
        btnDeleteProgram = New Button()
        btnUpdateProgram = New Button()
        Panel1.SuspendLayout()
        PanelWithDgv.SuspendLayout()
        PanelWithSearch.SuspendLayout()
        CType(dgvPrograms, ComponentModel.ISupportInitialize).BeginInit()
        PanelInputBundle.SuspendLayout()
        CType(numUpDownMinAggregate, ComponentModel.ISupportInitialize).BeginInit()
        PanelWithCrudButtons.SuspendLayout()
        Panel2.SuspendLayout()
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
        Panel1.Size = New Size(1628, 1036)
        Panel1.TabIndex = 2
        ' 
        ' PanelWithDgv
        ' 
        PanelWithDgv.AutoScroll = True
        PanelWithDgv.BackColor = Color.White
        PanelWithDgv.Controls.Add(PanelWithSearch)
        PanelWithDgv.Controls.Add(dgvPrograms)
        PanelWithDgv.Dock = DockStyle.Fill
        PanelWithDgv.Location = New Point(0, 76)
        PanelWithDgv.Margin = New Padding(4, 5, 4, 5)
        PanelWithDgv.Name = "PanelWithDgv"
        PanelWithDgv.Size = New Size(1628, 960)
        PanelWithDgv.TabIndex = 2
        ' 
        ' PanelWithSearch
        ' 
        PanelWithSearch.BackColor = Color.White
        PanelWithSearch.Controls.Add(btnSearch)
        PanelWithSearch.Controls.Add(txtSearch)
        PanelWithSearch.Dock = DockStyle.Top
        PanelWithSearch.Location = New Point(0, 0)
        PanelWithSearch.Margin = New Padding(4, 5, 4, 5)
        PanelWithSearch.Name = "PanelWithSearch"
        PanelWithSearch.Size = New Size(1602, 82)
        PanelWithSearch.TabIndex = 27
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Red
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Bold)
        btnSearch.ForeColor = Color.Transparent
        btnSearch.Location = New Point(1102, 9)
        btnSearch.Margin = New Padding(4, 5, 4, 5)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(292, 60)
        btnSearch.TabIndex = 15
        btnSearch.Text = "Go search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = SystemColors.Info
        txtSearch.Font = New Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = SystemColors.ActiveCaptionText
        txtSearch.Location = New Point(454, 16)
        txtSearch.Margin = New Padding(4, 5, 4, 5)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(604, 39)
        txtSearch.TabIndex = 26
        ' 
        ' dgvPrograms
        ' 
        dgvPrograms.BackgroundColor = Color.White
        dgvPrograms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPrograms.Location = New Point(0, 79)
        dgvPrograms.Margin = New Padding(4, 5, 4, 5)
        dgvPrograms.Name = "dgvPrograms"
        dgvPrograms.ReadOnly = True
        dgvPrograms.RowHeadersWidth = 51
        dgvPrograms.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPrograms.Size = New Size(1601, 1542)
        dgvPrograms.TabIndex = 0
        ' 
        ' PanelInputBundle
        ' 
        PanelInputBundle.BackColor = Color.White
        PanelInputBundle.Controls.Add(chkIsActive)
        PanelInputBundle.Controls.Add(numUpDownMinAggregate)
        PanelInputBundle.Controls.Add(cmbDepartment)
        PanelInputBundle.Controls.Add(LinkLabel2)
        PanelInputBundle.Controls.Add(Label6)
        PanelInputBundle.Controls.Add(Label2)
        PanelInputBundle.Controls.Add(Label1)
        PanelInputBundle.Controls.Add(txtProgramName)
        PanelInputBundle.Controls.Add(Label3)
        PanelInputBundle.Location = New Point(436, 86)
        PanelInputBundle.Margin = New Padding(4, 5, 4, 5)
        PanelInputBundle.Name = "PanelInputBundle"
        PanelInputBundle.Size = New Size(784, 861)
        PanelInputBundle.TabIndex = 0
        ' 
        ' chkIsActive
        ' 
        chkIsActive.AutoSize = True
        chkIsActive.BackColor = SystemColors.Info
        chkIsActive.Checked = True
        chkIsActive.CheckState = CheckState.Checked
        chkIsActive.Font = New Font("Garamond", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkIsActive.ForeColor = Color.Red
        chkIsActive.Location = New Point(509, 550)
        chkIsActive.Margin = New Padding(4, 5, 4, 5)
        chkIsActive.Name = "chkIsActive"
        chkIsActive.Size = New Size(252, 40)
        chkIsActive.TabIndex = 29
        chkIsActive.Text = "Program Active"
        chkIsActive.UseVisualStyleBackColor = False
        ' 
        ' numUpDownMinAggregate
        ' 
        numUpDownMinAggregate.BackColor = SystemColors.Info
        numUpDownMinAggregate.Font = New Font("Garamond", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        numUpDownMinAggregate.Location = New Point(31, 545)
        numUpDownMinAggregate.Margin = New Padding(4, 5, 4, 5)
        numUpDownMinAggregate.Name = "numUpDownMinAggregate"
        numUpDownMinAggregate.Size = New Size(254, 43)
        numUpDownMinAggregate.TabIndex = 27
        numUpDownMinAggregate.TextAlign = HorizontalAlignment.Center
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.BackColor = SystemColors.Info
        cmbDepartment.Font = New Font("Garamond", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbDepartment.ForeColor = Color.Red
        cmbDepartment.FormattingEnabled = True
        cmbDepartment.Location = New Point(19, 360)
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
        Label6.ForeColor = Color.MediumSeaGreen
        Label6.Location = New Point(19, 19)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(515, 51)
        Label6.TabIndex = 15
        Label6.Text = "Create A New Program"
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
        Label2.Size = New Size(287, 33)
        Label2.TabIndex = 18
        Label2.Text = "*Minimum Aggregate"
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
        Label1.Size = New Size(261, 33)
        Label1.TabIndex = 16
        Label1.Text = "*Department Name"
        ' 
        ' txtProgramName
        ' 
        txtProgramName.BackColor = Color.Ivory
        txtProgramName.Font = New Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtProgramName.ForeColor = SystemColors.ActiveCaptionText
        txtProgramName.Location = New Point(19, 191)
        txtProgramName.Margin = New Padding(4, 5, 4, 5)
        txtProgramName.Name = "txtProgramName"
        txtProgramName.Size = New Size(726, 48)
        txtProgramName.TabIndex = 15
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
        Label3.Size = New Size(219, 33)
        Label3.TabIndex = 14
        Label3.Text = "*Program Name"
        ' 
        ' PanelRedDesign
        ' 
        PanelRedDesign.BackColor = Color.MediumSeaGreen
        PanelRedDesign.Location = New Point(418, 120)
        PanelRedDesign.Margin = New Padding(4, 5, 4, 5)
        PanelRedDesign.Name = "PanelRedDesign"
        PanelRedDesign.Size = New Size(678, 859)
        PanelRedDesign.TabIndex = 3
        ' 
        ' PanelWithCrudButtons
        ' 
        PanelWithCrudButtons.BackColor = Color.White
        PanelWithCrudButtons.Controls.Add(Panel2)
        PanelWithCrudButtons.Dock = DockStyle.Top
        PanelWithCrudButtons.Location = New Point(0, 0)
        PanelWithCrudButtons.Margin = New Padding(4, 5, 4, 5)
        PanelWithCrudButtons.Name = "PanelWithCrudButtons"
        PanelWithCrudButtons.Size = New Size(1628, 76)
        PanelWithCrudButtons.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Controls.Add(btnAddProgram)
        Panel2.Controls.Add(btnDeleteProgram)
        Panel2.Controls.Add(btnUpdateProgram)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(4, 4, 4, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1628, 84)
        Panel2.TabIndex = 15
        ' 
        ' btnAddProgram
        ' 
        btnAddProgram.BackColor = Color.White
        btnAddProgram.FlatAppearance.BorderSize = 0
        btnAddProgram.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Bold)
        btnAddProgram.ForeColor = Color.Black
        btnAddProgram.Location = New Point(182, 10)
        btnAddProgram.Margin = New Padding(4, 5, 4, 5)
        btnAddProgram.Name = "btnAddProgram"
        btnAddProgram.Size = New Size(342, 60)
        btnAddProgram.TabIndex = 15
        btnAddProgram.Text = "Add Prgram"
        btnAddProgram.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteProgram
        ' 
        btnDeleteProgram.BackColor = Color.White
        btnDeleteProgram.FlatAppearance.BorderSize = 0
        btnDeleteProgram.Font = New Font("Arial Rounded MT Bold", 12F)
        btnDeleteProgram.ForeColor = Color.Black
        btnDeleteProgram.Location = New Point(1104, 10)
        btnDeleteProgram.Margin = New Padding(4, 5, 4, 5)
        btnDeleteProgram.Name = "btnDeleteProgram"
        btnDeleteProgram.Size = New Size(342, 60)
        btnDeleteProgram.TabIndex = 17
        btnDeleteProgram.Text = "Delete Program"
        btnDeleteProgram.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateProgram
        ' 
        btnUpdateProgram.BackColor = Color.White
        btnUpdateProgram.FlatAppearance.BorderSize = 0
        btnUpdateProgram.Font = New Font("Arial Rounded MT Bold", 12F)
        btnUpdateProgram.ForeColor = Color.Black
        btnUpdateProgram.Location = New Point(651, 10)
        btnUpdateProgram.Margin = New Padding(4, 5, 4, 5)
        btnUpdateProgram.Name = "btnUpdateProgram"
        btnUpdateProgram.Size = New Size(342, 60)
        btnUpdateProgram.TabIndex = 16
        btnUpdateProgram.Text = "Update Program"
        btnUpdateProgram.UseVisualStyleBackColor = False
        ' 
        ' UC_Programs
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "UC_Programs"
        Size = New Size(1628, 1036)
        Panel1.ResumeLayout(False)
        PanelWithDgv.ResumeLayout(False)
        PanelWithSearch.ResumeLayout(False)
        PanelWithSearch.PerformLayout()
        CType(dgvPrograms, ComponentModel.ISupportInitialize).EndInit()
        PanelInputBundle.ResumeLayout(False)
        PanelInputBundle.PerformLayout()
        CType(numUpDownMinAggregate, ComponentModel.ISupportInitialize).EndInit()
        PanelWithCrudButtons.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelWithDgv As Panel
    Friend WithEvents PanelWithSearch As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvPrograms As DataGridView
    Friend WithEvents PanelInputBundle As Panel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProgramName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelRedDesign As Panel
    Friend WithEvents PanelWithCrudButtons As Panel
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents numUpDownMinAggregate As NumericUpDown
    Friend WithEvents chkIsActive As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAddProgram As Button
    Friend WithEvents btnDeleteProgram As Button
    Friend WithEvents btnUpdateProgram As Button

End Class
