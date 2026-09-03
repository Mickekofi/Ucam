Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Drawing.Drawing2D

Public Class UC_AutoAdmissions

    ' Grade mapping for WAEC computations
    Private ReadOnly gradeMap As New Dictionary(Of String, Integer)(StringComparer.OrdinalIgnoreCase) From {
        {"A1", 1}, {"B2", 2}, {"B3", 3}, {"C4", 4}, {"C5", 5}, {"C6", 6}, {"D7", 7}, {"E8", 8}, {"F9", 9}
    }

    Private buttonList As List(Of Button)
    Private activeButton As Button

    ' =========================================================================
    ' UI RENDERING & STYLING
    ' =========================================================================
    Public Sub RadiusButton(btn As Button, circleness As Single)
        If circleness <= 0 Then Exit Sub
        Dim radius As Integer
        Dim diameter As Integer = Math.Min(btn.Width, btn.Height)
        If circleness >= 1 Then
            radius = diameter \ 2
        Else
            radius = CInt((diameter \ 2) * circleness)
        End If
        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(0, 0, radius * 2, radius * 2, 180, 90)
        path.AddArc(btn.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90)
        path.AddArc(btn.Width - (radius * 2), btn.Height - (radius * 2), radius * 2, radius * 2, 0, 90)
        path.AddArc(0, btn.Height - (radius * 2), radius * 2, radius * 2, 90, 90)
        path.CloseFigure()
        btn.Region = New Region(path)
    End Sub

    Private Sub InitializeDashboard(activeBtn As Button)
        If buttonList Is Nothing Then
            ' Includes navigation tabs (line1, line2, line3) and action buttons
            buttonList = New List(Of Button) From {btnReject, btnAdmit, btnLoad, btnExport, line3, line1, line2}
            For Each btn In buttonList
                If btn IsNot Nothing Then
                    AddHandler btn.MouseEnter, AddressOf Button_MouseEnter
                    AddHandler btn.MouseLeave, AddressOf Button_MouseLeave
                    AddHandler btn.MouseDown, AddressOf Button_MouseDown
                    ' Wire dynamic click routing
                    AddHandler btn.Click, Sub(s, e) InitializeDashboard(CType(s, Button))
                End If
            Next
        End If

        activeButton = activeBtn

        ' Reset visual state
        For Each btn In buttonList
            If btn IsNot Nothing Then
                With btn
                    .BackColor = Color.White
                    .ForeColor = Color.Red
                    .FlatStyle = FlatStyle.Flat
                    .FlatAppearance.BorderSize = 0
                    .Cursor = Cursors.Hand
                End With
            End If
        Next

        ' Highlight active
        If activeButton IsNot Nothing Then
            With activeButton
                .BackColor = Color.Black
                .ForeColor = Color.White
                .FlatAppearance.BorderSize = 3
                .FlatAppearance.BorderColor = Color.White
            End With
        End If

        ' ==========================================================
        ' VIEW ROUTING (Restored Toggle Flow)
        ' ==========================================================
        If activeButton Is line3 Then
            ' Show Input Filters
            If PanelInputBundle IsNot Nothing Then PanelInputBundle.Visible = True
            If PanelRedDesign IsNot Nothing Then PanelRedDesign.Visible = True

            If PanelWithDgv IsNot Nothing Then
                PanelWithDgv.Dock = DockStyle.None
                PanelWithDgv.Visible = False
            End If
        Else
            ' Show Results Grid (triggered by Load, Admit, Reject, Export)
            If PanelInputBundle IsNot Nothing Then PanelInputBundle.Visible = False
            If PanelRedDesign IsNot Nothing Then PanelRedDesign.Visible = False

            If PanelWithDgv IsNot Nothing Then
                PanelWithDgv.Visible = True
                PanelWithDgv.Dock = DockStyle.Fill
            End If
        End If
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        Dim btn = CType(sender, Button)
        If btn IsNot activeButton Then
            btn.BackColor = Color.Black
            btn.ForeColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        Dim btn = CType(sender, Button)
        If btn IsNot activeButton Then
            btn.BackColor = Color.White
            btn.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs)
        Dim btn = CType(sender, Button)
        btn.BackColor = Color.Red
    End Sub

    ' =========================================================================
    ' ON LOAD & INITIALIZATION
    ' =========================================================================
    Private Sub UC_AutoAdmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Boot directly into the filter screen
        InitializeDashboard(line3)

        ' Ensure visual styling
        RadiusButton(btnLoad, 0.5F)
        RadiusButton(btnAdmit, 0.5F)
        RadiusButton(btnReject, 0.5F)
        RadiusButton(btnExport, 0.5F)

        ' Setup DataGridView
        With dgvApplicants
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ReadOnly = True
            .AllowUserToAddRows = False
            .RowTemplate.Height = 35
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        End With

        ' Pre-fill static filter options
        cmbFilterRank.Items.AddRange({"All", "1", "2", "3"})
        cmbFilterRank.SelectedIndex = 0

        cmbFilterStatus.Items.AddRange({"All", "Pending", "Admitted", "Rejected"})
        cmbFilterStatus.SelectedIndex = 1 ' Default to Pending to show actionable items

        LoadProgramsDropdown()
        UpdateDashboardStats()
    End Sub

    Private Sub LoadProgramsDropdown()
        Try
            Using conn = Database.GetOpenConnection()
                ' Pull only programs belonging to this admin's department
                Dim query As String = "SELECT program_id, name FROM programs WHERE department_id = @deptId AND active = 1 ORDER BY name ASC"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@deptId", SessionManager.CurrentDepartmentID.Value)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        dt.Columns.Add("program_id", GetType(Integer))
                        dt.Columns.Add("name", GetType(String))
                        dt.Rows.Add(0, "-- All Department Programs --")
                        adapter.Fill(dt)

                        cmbProgram.DataSource = dt
                        cmbProgram.DisplayMember = "name"
                        cmbProgram.ValueMember = "program_id"
                        cmbProgram.SelectedIndex = 0
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading programs: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================================================================
    ' THE INTELLIGENT ADMISSION ENGINE (Data Loading & Computation)
    ' =========================================================================
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ' We don't need to call InitializeDashboard here because the AddHandler in InitializeDashboard 
        ' already intercepts the click and routes it. But leaving it is safe for explicit execution.
        LoadApplicantsData()
    End Sub

    Private Sub LoadApplicantsData()
        Try
            Using conn = Database.GetOpenConnection()
                Dim query As String = "SELECT pc.choice_id, s.student_id, s.index_number AS 'Index', s.full_name AS 'Applicant Name', " &
                                      "p.name AS 'Program', pc.choice_rank AS 'Rank', pc.result AS 'Status', " &
                                      "s.waec_results_json, p.min_aggregate " &
                                      "FROM program_choices pc " &
                                      "JOIN students s ON pc.student_id = s.student_id " &
                                      "JOIN programs p ON pc.program_id = p.program_id " &
                                      "WHERE p.department_id = @deptId"

                ' Apply Filters
                If cmbProgram.SelectedIndex > 0 Then query &= " AND pc.program_id = " & cmbProgram.SelectedValue.ToString()
                If cmbFilterRank.SelectedIndex > 0 Then query &= " AND pc.choice_rank = " & cmbFilterRank.SelectedItem.ToString()
                If cmbFilterStatus.SelectedIndex > 0 Then query &= " AND pc.result = '" & cmbFilterStatus.SelectedItem.ToString() & "'"
                If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then query &= " AND (s.index_number LIKE @search OR s.full_name LIKE @search)"

                query &= " ORDER BY pc.choice_rank ASC, s.full_name ASC"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@deptId", SessionManager.CurrentDepartmentID.Value)
                    If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")

                    Dim dt As New DataTable()
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using

                    ' Inject computed columns for intelligent analysis
                    dt.Columns.Add("Computed Aggregate", GetType(Integer))
                    dt.Columns.Add("Sys Recommendation", GetType(String))

                    For Each row As DataRow In dt.Rows
                        Dim rawJson = row("waec_results_json").ToString()
                        Dim minAgg = Convert.ToInt32(row("min_aggregate"))

                        Dim aggregate = CalculateWAECAggregate(rawJson)
                        row("Computed Aggregate") = aggregate

                        If aggregate > 0 AndAlso aggregate <= minAgg Then
                            row("Sys Recommendation") = "ELIGIBLE"
                        Else
                            row("Sys Recommendation") = "NOT ELIGIBLE"
                        End If
                    Next

                    dgvApplicants.DataSource = dt

                    ' Hide technical columns
                    If dgvApplicants.Columns.Contains("choice_id") Then dgvApplicants.Columns("choice_id").Visible = False
                    If dgvApplicants.Columns.Contains("student_id") Then dgvApplicants.Columns("student_id").Visible = False
                    If dgvApplicants.Columns.Contains("waec_results_json") Then dgvApplicants.Columns("waec_results_json").Visible = False
                    If dgvApplicants.Columns.Contains("min_aggregate") Then dgvApplicants.Columns("min_aggregate").Visible = False
                End Using
            End Using

            UpdateDashboardStats()

        Catch ex As Exception
            MessageBox.Show("Error loading applicant engine: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Core Algorithm: Parses WAEC JSON, extracts 4 cores and best 2 electives, returns total aggregate.
    ''' </summary>
    Private Function CalculateWAECAggregate(jsonStr As String) As Integer
        Try
            If String.IsNullOrWhiteSpace(jsonStr) Then Return 99 ' Fail-safe high aggregate

            Dim results As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(jsonStr)
            Dim coreSubjects As New List(Of String)({"English", "Mathematics", "Integrated Science", "Social Studies"})

            Dim coreTotal As Integer = 0
            Dim electiveScores As New List(Of Integer)

            For Each kvp In results
                Dim gradeValue As Integer = If(gradeMap.ContainsKey(kvp.Value), gradeMap(kvp.Value), 9) ' F9 default

                If coreSubjects.Contains(kvp.Key, StringComparer.OrdinalIgnoreCase) Then
                    coreTotal += gradeValue
                Else
                    electiveScores.Add(gradeValue)
                End If
            Next

            ' Sort electives ascending (lowest score is best) and take the best 2
            electiveScores.Sort()
            Dim bestElectivesTotal As Integer = 0
            If electiveScores.Count > 0 Then bestElectivesTotal += electiveScores(0)
            If electiveScores.Count > 1 Then bestElectivesTotal += electiveScores(1)

            Return coreTotal + bestElectivesTotal

        Catch ex As Exception
            Return 99 ' Flag as invalid on parse failure
        End Try
    End Function

    ' =========================================================================
    ' DECISION EXECUTION (Admit / Reject)
    ' =========================================================================
    Private Sub btnAdmit_Click(sender As Object, e As EventArgs) Handles btnAdmit.Click
        ProcessDecision("Admitted")
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        ProcessDecision("Rejected")
    End Sub

    Private Sub ProcessDecision(decision As String)
        If dgvApplicants.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an applicant from the grid first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim row = dgvApplicants.SelectedRows(0)
        Dim choiceId = Convert.ToInt32(row.Cells("choice_id").Value)
        Dim studentId = Convert.ToInt32(row.Cells("student_id").Value)
        Dim applicantName = row.Cells("Applicant Name").Value.ToString()
        Dim currentStatus = row.Cells("Status").Value.ToString()

        If currentStatus = decision Then
            MessageBox.Show($"Applicant is already marked as {decision}.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show($"Are you sure you want to mark {applicantName} as {decision.ToUpper()}?", "Confirm Decision", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Using conn = Database.GetOpenConnection()
                    ' Update choice status
                    Dim query As String = "UPDATE program_choices SET result = @res WHERE choice_id = @cid"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@res", decision)
                        cmd.Parameters.AddWithValue("@cid", choiceId)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' If Admitted, optionally update master student status (Business Logic choice)
                    If decision = "Admitted" Then
                        Dim stuQuery As String = "UPDATE students SET status = 'Admitted' WHERE student_id = @sid AND status = 'Pending'"
                        Using cmd As New MySqlCommand(stuQuery, conn)
                            cmd.Parameters.AddWithValue("@sid", studentId)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                End Using

                LoadApplicantsData() ' Refresh Grid
            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' =========================================================================
    ' DASHBOARD STATISTICS UPDATER
    ' =========================================================================
    ' =========================================================================
    ' DASHBOARD STATISTICS UPDATER
    ' =========================================================================
    Private Sub UpdateDashboardStats()
        Try
            Using conn = Database.GetOpenConnection()
                Dim deptId = SessionManager.CurrentDepartmentID.Value

                ' 1. Fetch Department Name and Quota in a single optimized query
                Dim deptQuery As String = "SELECT name, quota FROM departments WHERE department_id = @deptId"
                Dim quota As Integer = 0
                Dim deptName As String = "Unknown Department"

                Using cmd As New MySqlCommand(deptQuery, conn)
                    cmd.Parameters.AddWithValue("@deptId", deptId)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            deptName = reader("name").ToString()
                            quota = Convert.ToInt32(reader("quota"))
                        End If
                    End Using
                End Using

                lblDepartmentQuota.Text = quota.ToString()
                ' Ensure label exists before assigning to avoid initialization crashes
                If lblDepartmentName IsNot Nothing Then lblDepartmentName.Text = deptName.ToUpper()

                ' 2. Fetch Status Counts for the ENTIRE Department
                Dim countsQuery As String = "SELECT pc.result, COUNT(*) AS count " &
                                            "FROM program_choices pc " &
                                            "JOIN programs p ON pc.program_id = p.program_id " &
                                            "WHERE p.department_id = @deptId " &
                                            "GROUP BY pc.result"

                Dim totalAll As Integer = 0
                Dim admittedCount As Integer = 0
                Dim rejectedCount As Integer = 0
                Dim pendingCount As Integer = 0

                Using cmd As New MySqlCommand(countsQuery, conn)
                    cmd.Parameters.AddWithValue("@deptId", deptId)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim status = reader("result").ToString()
                            Dim count = Convert.ToInt32(reader("count"))
                            totalAll += count

                            Select Case status
                                Case "Admitted"
                                    admittedCount = count
                                Case "Rejected"
                                    rejectedCount = count
                                Case "Pending"
                                    pendingCount = count
                            End Select
                        End While
                    End Using
                End Using

                ' Update Department Statistics Labels
                lblTotalAllDepartmentApplicantsCounts.Text = totalAll.ToString()
                lblTotalDepartmentApplicantsAdmittedCounts.Text = admittedCount.ToString()
                lblTotalDepartmentApplicantsRejectedCounts.Text = rejectedCount.ToString()
                lblTotaDepartmentApplicantsPendingCounts.Text = pendingCount.ToString()

                Dim slotsLeft = quota - admittedCount
                lblDepartmentSlotsLeftTotal.Text = If(slotsLeft < 0, "0 (OVER LIMIT)", slotsLeft.ToString())

                ' 3. Update active Program Name
                If lblProgramName IsNot Nothing Then
                    lblProgramName.Text = cmbProgram.Text.ToUpper()
                End If

                ' 4. If a specific program is selected, fetch Program-specific stats
                If cmbProgram.SelectedIndex > 0 Then
                    Dim progId = Convert.ToInt32(cmbProgram.SelectedValue)
                    Dim pQuery As String = "SELECT result, COUNT(*) AS count FROM program_choices WHERE program_id = @pid GROUP BY result"

                    Dim pTotal As Integer = 0, pAdmit As Integer = 0, pReject As Integer = 0, pPend As Integer = 0

                    Using cmd As New MySqlCommand(pQuery, conn)
                        cmd.Parameters.AddWithValue("@pid", progId)
                        Using reader = cmd.ExecuteReader()
                            While reader.Read()
                                Dim status = reader("result").ToString()
                                Dim count = Convert.ToInt32(reader("count"))
                                pTotal += count
                                Select Case status
                                    Case "Admitted" : pAdmit = count
                                    Case "Rejected" : pReject = count
                                    Case "Pending" : pPend = count
                                End Select
                            End While
                        End Using
                    End Using

                    lblProgramTotalApplicantsCounts.Text = pTotal.ToString()
                    lblProgramAdmittedCounts.Text = pAdmit.ToString()
                    lblProgramRejectedCounts.Text = pReject.ToString()
                    lblProgramPendingCounts.Text = pPend.ToString()
                Else
                    ' If "All Programs" is selected, clear out the specific program stats
                    lblProgramTotalApplicantsCounts.Text = "-"
                    lblProgramAdmittedCounts.Text = "-"
                    lblProgramRejectedCounts.Text = "-"
                    lblProgramPendingCounts.Text = "-"
                End If

            End Using
        Catch ex As Exception
            ' Silently fail stats to prevent crashing the main view
            Console.WriteLine("Stats Error: " & ex.Message)
        End Try
    End Sub

    ' =========================================================================
    ' EXPORT TO CSV
    ' =========================================================================
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If dgvApplicants.Rows.Count = 0 Then
            MessageBox.Show("No data available to export.", "Empty Grid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV File|*.csv"
        sfd.Title = "Export Admission List"
        sfd.FileName = $"AdmissionList_{DateTime.Now:yyyyMMdd}.csv"

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim sb As New StringBuilder()

                ' Write Headers
                Dim headers As New List(Of String)
                For Each col As DataGridViewColumn In dgvApplicants.Columns
                    If col.Visible Then headers.Add($"""{col.HeaderText}""")
                Next
                sb.AppendLine(String.Join(",", headers))

                ' Write Rows
                For Each row As DataGridViewRow In dgvApplicants.Rows
                    If Not row.IsNewRow Then
                        Dim cells As New List(Of String)
                        For Each col As DataGridViewColumn In dgvApplicants.Columns
                            If col.Visible Then
                                Dim val = If(row.Cells(col.Index).Value IsNot Nothing, row.Cells(col.Index).Value.ToString(), "")
                                cells.Add($"""{val}""")
                            End If
                        Next
                        sb.AppendLine(String.Join(",", cells))
                    End If
                Next

                File.WriteAllText(sfd.FileName, sb.ToString())
                MessageBox.Show("Data exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error writing to file: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgvApplicants_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvApplicants.CellContentClick

    End Sub

    Private Sub PanelWithDgv_Paint(sender As Object, e As PaintEventArgs) Handles PanelWithDgv.Paint

    End Sub
End Class