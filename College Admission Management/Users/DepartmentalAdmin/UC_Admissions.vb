Imports ClosedXML.Excel
Imports System.IO

Public Class UC_Admissions

    ' ==== In-Memory Demo Data ====
    Private demoProgramsTable As DataTable
    Private demoApplicantsTable As DataTable

    Private Sub InitializeDemoData()
        ' Setup Demo Programs
        demoProgramsTable = New DataTable()
        demoProgramsTable.Columns.Add("program_id", GetType(Integer))
        demoProgramsTable.Columns.Add("name", GetType(String))

        demoProgramsTable.Rows.Add(1, "BSc Information Technology")
        demoProgramsTable.Rows.Add(2, "BSc Computer Science")
        demoProgramsTable.Rows.Add(3, "BSc Engineering")

        ' Setup Demo Applicants
        demoApplicantsTable = New DataTable()
        demoApplicantsTable.Columns.Add("student_id", GetType(Integer))
        demoApplicantsTable.Columns.Add("choice_id", GetType(Integer))
        demoApplicantsTable.Columns.Add("index_number", GetType(String))
        demoApplicantsTable.Columns.Add("full_name", GetType(String))
        demoApplicantsTable.Columns.Add("choice_rank", GetType(Integer))
        demoApplicantsTable.Columns.Add("program_id", GetType(Integer))
        demoApplicantsTable.Columns.Add("program_name", GetType(String))
        demoApplicantsTable.Columns.Add("result", GetType(String))
        demoApplicantsTable.Columns.Add("passport_photo_path", GetType(String))

        ' Populate with some mock records
        demoApplicantsTable.Rows.Add(101, 1, "IDX-001", "John Doe", 1, 1, "BSc Information Technology", "Pending", "")
        demoApplicantsTable.Rows.Add(102, 2, "IDX-002", "Jane Smith", 2, 1, "BSc Information Technology", "Pending", "")
        demoApplicantsTable.Rows.Add(103, 3, "IDX-003", "Alice Johnson", 1, 2, "BSc Computer Science", "Admitted", "")
        demoApplicantsTable.Rows.Add(104, 4, "IDX-004", "Bob Williams", 3, 3, "BSc Engineering", "Rejected", "")
        demoApplicantsTable.Rows.Add(105, 5, "IDX-005", "Charlie Brown", 1, 1, "BSc Information Technology", "Pending", "")
    End Sub
    ' =============================

    'Function For Radius Button (Control[Name], size)
    Public Sub RadiusButton(btn As Button, circleness As Single)
        If circleness <= 0 Then Exit Sub
        Dim radius As Integer
        Dim diameter As Integer = Math.Min(btn.Width, btn.Height)
        ' Calculate rounding
        If circleness >= 1 Then
            radius = diameter \ 2
        Else
            radius = CInt((diameter \ 2) * circleness)
        End If
        ' Create rounded region
        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(0, 0, radius * 2, radius * 2, 180, 90)
        path.AddArc(btn.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90)
        path.AddArc(btn.Width - (radius * 2), btn.Height - (radius * 2), radius * 2, radius * 2, 0, 90)
        path.AddArc(0, btn.Height - (radius * 2), radius * 2, radius * 2, 90, 90)
        path.CloseFigure()
        btn.Region = New Region(path)
    End Sub

    'Ended the Radius Function.........................................................................


    'One Unified Function to Initialize Dashboard with Button Clicks and Hover Effects
    Private buttonList As List(Of Button)
    Private activeButton As Button

    Private Sub InitializeDashboard(activeBtn As Button)
        ' Lazy-load the button list and wire events only once
        If buttonList Is Nothing Then
            buttonList = New List(Of Button) From {btnReject, btnAdmit, btnLoad, line3, line1, line2, btnExport}
            For Each btn In buttonList
                AddHandler btn.Click, Sub(s, e)
                                          InitializeDashboard(CType(s, Button))
                                      End Sub
                AddHandler btn.MouseEnter, AddressOf Button_MouseEnter
                AddHandler btn.MouseLeave, AddressOf Button_MouseLeave
                AddHandler btn.MouseDown, AddressOf Button_MouseDown
            Next
        End If

        ' Set active button
        activeButton = activeBtn

        ' Style reset for all buttons
        For Each btn In buttonList
            With btn
                .BackColor = Color.White
                .ForeColor = Color.Red
                .FlatStyle = FlatStyle.Flat
                .FlatAppearance.BorderSize = 0
                .Cursor = Cursors.Hand
            End With
        Next

        ' Highlight selected
        With activeButton
            .BackColor = Color.Black
            .ForeColor = Color.White
            .FlatAppearance.BorderSize = 3
            .FlatAppearance.BorderColor = Color.White
        End With

        ' Design Panels LayOut Manupulation Section
        ' Show/hide panels(INPUT & DVG) based on active button.................................
        If activeButton Is line3 Then
            PanelInputBundle.Visible = True
            PanelRedDesign.Visible = True

            PanelWithDgv.Dock = DockStyle.None
            PanelWithDgv.Visible = False
        Else
            PanelInputBundle.Visible = False
            PanelRedDesign.Visible = False

            PanelWithDgv.Visible = True
        End If
    End Sub

    ' Hover effect
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        Dim btn = CType(sender, Button)
        If btn IsNot activeButton Then
            btn.BackColor = Color.Black
            btn.ForeColor = Color.WhiteSmoke
        End If
    End Sub

    '' Hover leave
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        Dim btn = CType(sender, Button)
        If btn IsNot activeButton Then
            btn.BackColor = Color.White
            btn.ForeColor = Color.Black
        End If
    End Sub

    ' Press visual
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs)
        Dim btn = CType(sender, Button)
        btn.BackColor = Color.Indigo
    End Sub

    ' =========================
    ' On Load
    ' =========================
    Private Sub UC_Admissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            InitializeDemoData()



            ' Round button edges
            RadiusButton(btnReject, 0.5F)
            RadiusButton(btnAdmit, 0.5F)
            RadiusButton(btnLoad, 0.5F)

            ' Setup filter dropdowns
            cmbFilterRank.Items.AddRange(New String() {"All", "1", "2", "3"})
            cmbFilterStatus.Items.AddRange(New String() {"All", "Pending", "Admitted", "Rejected"})
            cmbFilterRank.SelectedIndex = 0
            cmbFilterStatus.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Error initializing admissions dashboard: " & ex.Message)
        End Try
    End Sub



    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            ' Load applicants into DataGridView
            dgvApplicants.DataSource = demoApplicantsTable
            ' Apply filters if any



        Catch ex As Exception
            MessageBox.Show("Error loading applicants: " & ex.Message)
        End Try
    End Sub




    Private Sub PanelWithSearch_Paint(sender As Object, e As PaintEventArgs) Handles PanelWithSearch.Paint

    End Sub

    Private Sub dgvApplicants_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvApplicants.CellContentClick

    End Sub

    Private Sub PanelWithCrudButtons_Paint(sender As Object, e As PaintEventArgs) Handles PanelWithCrudButtons.Paint

    End Sub

    Private Sub btnAdmit_Click(sender As Object, e As EventArgs) Handles btnAdmit.Click
        Try
            'Initialixe this button
            InitializeDashboard(btnAdmit)

            If dgvApplicants.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select an applicant to admit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            For Each row As DataGridViewRow In dgvApplicants.SelectedRows
                Dim studentId As Integer = CInt(row.Cells("student_id").Value)
                Dim applicantRow As DataRow = demoApplicantsTable.Select("student_id=" & studentId).FirstOrDefault()
                If applicantRow IsNot Nothing Then
                    applicantRow("result") = "Admitted"
                End If
            Next

            dgvApplicants.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error admitting applicant: " & ex.Message)
        End Try
    End Sub



    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        Try

            'Initialize
            InitializeDashboard(btnReject)

            If dgvApplicants.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select an applicant to reject.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            For Each row As DataGridViewRow In dgvApplicants.SelectedRows
                Dim studentId As Integer = CInt(row.Cells("student_id").Value)
                Dim applicantRow As DataRow = demoApplicantsTable.Select("student_id=" & studentId).FirstOrDefault()
                If applicantRow IsNot Nothing Then
                    applicantRow("result") = "Rejected"
                End If
            Next

            dgvApplicants.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error rejecting applicant: " & ex.Message)
        End Try
    End Sub




    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        InitializeDashboard(btnExport)
    End Sub
End Class