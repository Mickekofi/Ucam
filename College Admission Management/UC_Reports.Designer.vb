<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Reports
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
        lblRejectedCount = New Label()
        lblAdmittedCount = New Label()
        lable4 = New Label()
        Label8 = New Label()
        lblTotalCount = New Label()
        labelC1 = New Label()
        dgvLogs = New DataGridView()
        PanelInputBundle = New Panel()
        Label9 = New Label()
        cmbProgram = New ComboBox()
        btnRefresh = New Button()
        cmbStatus = New ComboBox()
        Label2 = New Label()
        cmbDepartment = New ComboBox()
        Label6 = New Label()
        Label1 = New Label()
        LinkLabel2 = New LinkLabel()
        PanelRedDesign = New Panel()
        PanelWithCrudButtons = New Panel()
        btnReportControl = New Button()
        btnExportExcel = New Button()
        Panel1.SuspendLayout()
        PanelWithDgv.SuspendLayout()
        PanelWithSearch.SuspendLayout()
        CType(dgvLogs, ComponentModel.ISupportInitialize).BeginInit()
        PanelInputBundle.SuspendLayout()
        PanelWithCrudButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(PanelWithDgv)
        Panel1.Controls.Add(PanelInputBundle)
        Panel1.Controls.Add(PanelRedDesign)
        Panel1.Controls.Add(PanelWithCrudButtons)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1150, 817)
        Panel1.TabIndex = 4
        ' 
        ' PanelWithDgv
        ' 
        PanelWithDgv.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelWithDgv.BackColor = Color.Crimson
        PanelWithDgv.Controls.Add(PanelWithSearch)
        PanelWithDgv.Controls.Add(dgvLogs)
        PanelWithDgv.Location = New Point(0, 700)
        PanelWithDgv.Margin = New Padding(3, 4, 3, 4)
        PanelWithDgv.Name = "PanelWithDgv"
        PanelWithDgv.Size = New Size(4242, 2143)
        PanelWithDgv.TabIndex = 2
        ' 
        ' PanelWithSearch
        ' 
        PanelWithSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelWithSearch.BackColor = Color.Transparent
        PanelWithSearch.Controls.Add(lblRejectedCount)
        PanelWithSearch.Controls.Add(lblAdmittedCount)
        PanelWithSearch.Controls.Add(lable4)
        PanelWithSearch.Controls.Add(Label8)
        PanelWithSearch.Controls.Add(lblTotalCount)
        PanelWithSearch.Controls.Add(labelC1)
        PanelWithSearch.Location = New Point(0, 0)
        PanelWithSearch.Margin = New Padding(3, 4, 3, 4)
        PanelWithSearch.Name = "PanelWithSearch"
        PanelWithSearch.Size = New Size(10471, 56)
        PanelWithSearch.TabIndex = 27
        ' 
        ' lblRejectedCount
        ' 
        lblRejectedCount.AutoSize = True
        lblRejectedCount.BackColor = Color.Transparent
        lblRejectedCount.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRejectedCount.ForeColor = Color.Black
        lblRejectedCount.Location = New Point(1014, 12)
        lblRejectedCount.Name = "lblRejectedCount"
        lblRejectedCount.Size = New Size(23, 27)
        lblRejectedCount.TabIndex = 50
        lblRejectedCount.Text = "0"
        ' 
        ' lblAdmittedCount
        ' 
        lblAdmittedCount.AutoSize = True
        lblAdmittedCount.BackColor = Color.Transparent
        lblAdmittedCount.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAdmittedCount.ForeColor = Color.Black
        lblAdmittedCount.Location = New Point(731, 12)
        lblAdmittedCount.Name = "lblAdmittedCount"
        lblAdmittedCount.Size = New Size(23, 27)
        lblAdmittedCount.TabIndex = 49
        lblAdmittedCount.Text = "0"
        ' 
        ' lable4
        ' 
        lable4.AutoSize = True
        lable4.BackColor = Color.Transparent
        lable4.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lable4.ForeColor = Color.Black
        lable4.Location = New Point(838, 12)
        lable4.Name = "lable4"
        lable4.Size = New Size(186, 27)
        lable4.TabIndex = 48
        lable4.Text = "*Total Rejected :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(550, 12)
        Label8.Name = "Label8"
        Label8.Size = New Size(194, 27)
        Label8.TabIndex = 48
        Label8.Text = "*Total Admitted :"
        ' 
        ' lblTotalCount
        ' 
        lblTotalCount.AutoSize = True
        lblTotalCount.BackColor = Color.Transparent
        lblTotalCount.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalCount.ForeColor = Color.Black
        lblTotalCount.Location = New Point(334, 12)
        lblTotalCount.Name = "lblTotalCount"
        lblTotalCount.Size = New Size(23, 27)
        lblTotalCount.TabIndex = 48
        lblTotalCount.Text = "0"
        ' 
        ' labelC1
        ' 
        labelC1.AutoSize = True
        labelC1.BackColor = Color.Transparent
        labelC1.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelC1.ForeColor = Color.Black
        labelC1.Location = New Point(157, 12)
        labelC1.Name = "labelC1"
        labelC1.Size = New Size(186, 27)
        labelC1.TabIndex = 38
        labelC1.Text = "*Total Students :"
        ' 
        ' dgvLogs
        ' 
        dgvLogs.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        dgvLogs.BackgroundColor = Color.Black
        dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLogs.Location = New Point(0, 59)
        dgvLogs.Margin = New Padding(3, 4, 3, 4)
        dgvLogs.Name = "dgvLogs"
        dgvLogs.ReadOnly = True
        dgvLogs.RowHeadersWidth = 51
        dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLogs.Size = New Size(1298, 5267)
        dgvLogs.TabIndex = 0
        ' 
        ' PanelInputBundle
        ' 
        PanelInputBundle.BackColor = Color.White
        PanelInputBundle.Controls.Add(Label9)
        PanelInputBundle.Controls.Add(cmbProgram)
        PanelInputBundle.Controls.Add(btnRefresh)
        PanelInputBundle.Controls.Add(cmbStatus)
        PanelInputBundle.Controls.Add(Label2)
        PanelInputBundle.Controls.Add(cmbDepartment)
        PanelInputBundle.Controls.Add(Label6)
        PanelInputBundle.Controls.Add(Label1)
        PanelInputBundle.Controls.Add(LinkLabel2)
        PanelInputBundle.Location = New Point(349, 69)
        PanelInputBundle.Margin = New Padding(3, 4, 3, 4)
        PanelInputBundle.Name = "PanelInputBundle"
        PanelInputBundle.Size = New Size(627, 689)
        PanelInputBundle.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(21, 380)
        Label9.Name = "Label9"
        Label9.Size = New Size(202, 27)
        Label9.TabIndex = 47
        Label9.Text = "*Admission Status"
        ' 
        ' cmbProgram
        ' 
        cmbProgram.BackColor = SystemColors.Info
        cmbProgram.Font = New Font("Garamond", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbProgram.ForeColor = Color.Red
        cmbProgram.FormattingEnabled = True
        cmbProgram.Items.AddRange(New Object() {"Bsc Information and Communication Technology", "BEd Mathematics", "BEd Physics", "BEd Biological Sciences"})
        cmbProgram.Location = New Point(15, 299)
        cmbProgram.Margin = New Padding(3, 4, 3, 4)
        cmbProgram.Name = "cmbProgram"
        cmbProgram.Size = New Size(582, 37)
        cmbProgram.TabIndex = 46
        cmbProgram.Text = "--Select Program--"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.MediumSeaGreen
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.Transparent
        btnRefresh.Location = New Point(15, 609)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(280, 64)
        btnRefresh.TabIndex = 45
        btnRefresh.Text = "Load Report"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' cmbStatus
        ' 
        cmbStatus.BackColor = SystemColors.Info
        cmbStatus.Font = New Font("Garamond", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbStatus.ForeColor = Color.Red
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"All", "Admitted", "Rejected"})
        cmbStatus.Location = New Point(21, 431)
        cmbStatus.Margin = New Padding(3, 4, 3, 4)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(582, 37)
        cmbStatus.TabIndex = 40
        cmbStatus.Text = "--Select Status--"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(15, 249)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 27)
        Label2.TabIndex = 39
        Label2.Text = "*Program Name"
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.BackColor = SystemColors.Info
        cmbDepartment.Font = New Font("Garamond", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbDepartment.ForeColor = Color.Red
        cmbDepartment.FormattingEnabled = True
        cmbDepartment.Items.AddRange(New Object() {"ICT (Infoctecs) Department ", "Mathematics (AMES) Department", "Physics Department", "Biology Department"})
        cmbDepartment.Location = New Point(15, 168)
        cmbDepartment.Margin = New Padding(3, 4, 3, 4)
        cmbDepartment.Name = "cmbDepartment"
        cmbDepartment.Size = New Size(582, 37)
        cmbDepartment.TabIndex = 38
        cmbDepartment.Text = "--Select Department--"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(15, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(499, 43)
        Label6.TabIndex = 36
        Label6.Text = "Admission Control Reports"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(3, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(216, 27)
        Label1.TabIndex = 37
        Label1.Text = "*Department Name"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Segoe UI", 12F)
        LinkLabel2.Location = New Point(471, 649)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(171, 28)
        LinkLabel2.TabIndex = 25
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "I have a Problem ?"
        ' 
        ' PanelRedDesign
        ' 
        PanelRedDesign.BackColor = Color.Red
        PanelRedDesign.Location = New Point(334, 96)
        PanelRedDesign.Margin = New Padding(3, 4, 3, 4)
        PanelRedDesign.Name = "PanelRedDesign"
        PanelRedDesign.Size = New Size(542, 687)
        PanelRedDesign.TabIndex = 3
        ' 
        ' PanelWithCrudButtons
        ' 
        PanelWithCrudButtons.BackColor = Color.Black
        PanelWithCrudButtons.Controls.Add(btnReportControl)
        PanelWithCrudButtons.Controls.Add(btnExportExcel)
        PanelWithCrudButtons.Dock = DockStyle.Top
        PanelWithCrudButtons.Location = New Point(0, 0)
        PanelWithCrudButtons.Margin = New Padding(3, 4, 3, 4)
        PanelWithCrudButtons.Name = "PanelWithCrudButtons"
        PanelWithCrudButtons.Size = New Size(1150, 61)
        PanelWithCrudButtons.TabIndex = 1
        ' 
        ' btnReportControl
        ' 
        btnReportControl.BackColor = Color.White
        btnReportControl.FlatAppearance.BorderSize = 0
        btnReportControl.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Bold)
        btnReportControl.ForeColor = Color.Black
        btnReportControl.Location = New Point(254, 7)
        btnReportControl.Margin = New Padding(3, 4, 3, 4)
        btnReportControl.Name = "btnReportControl"
        btnReportControl.Size = New Size(274, 48)
        btnReportControl.TabIndex = 14
        btnReportControl.Text = "Report Control"
        btnReportControl.UseVisualStyleBackColor = False
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.BackColor = Color.White
        btnExportExcel.FlatAppearance.BorderSize = 0
        btnExportExcel.Font = New Font("Arial Rounded MT Bold", 12F)
        btnExportExcel.ForeColor = Color.Black
        btnExportExcel.Location = New Point(622, 7)
        btnExportExcel.Margin = New Padding(3, 4, 3, 4)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(274, 48)
        btnExportExcel.TabIndex = 15
        btnExportExcel.Text = "Download reports"
        btnExportExcel.UseVisualStyleBackColor = False
        ' 
        ' UC_Reports
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "UC_Reports"
        Size = New Size(1150, 817)
        Panel1.ResumeLayout(False)
        PanelWithDgv.ResumeLayout(False)
        PanelWithSearch.ResumeLayout(False)
        PanelWithSearch.PerformLayout()
        CType(dgvLogs, ComponentModel.ISupportInitialize).EndInit()
        PanelInputBundle.ResumeLayout(False)
        PanelInputBundle.PerformLayout()
        PanelWithCrudButtons.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelWithDgv As Panel
    Friend WithEvents PanelWithSearch As Panel
    Friend WithEvents dgvLogs As DataGridView
    Friend WithEvents PanelInputBundle As Panel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents PanelRedDesign As Panel
    Friend WithEvents PanelWithCrudButtons As Panel
    Friend WithEvents btnReportControl As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbProgram As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lable4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalCount As Label
    Friend WithEvents labelC1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAdmittedCount As Label
    Friend WithEvents lblRejectedCount As Label

End Class
