Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D

Public Class AdmissionLists

    ' =========================================================================
    ' UI RENDERING & STYLING
    ' =========================================================================
    Private Sub RoundControl(ctrl As Control, radius As Integer, Optional borderColor As Color = Nothing, Optional borderWidth As Integer = 3)
        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(New RectangleF(0, 0, radius, radius), 180, 90)
        path.AddArc(New RectangleF(ctrl.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New RectangleF(ctrl.Width - radius, ctrl.Height - radius, radius, radius), 0, 90)
        path.AddArc(New RectangleF(0, ctrl.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()
        ctrl.Region = New Region(path)

        RemoveHandler ctrl.Paint, AddressOf RoundedBorderPaint
        AddHandler ctrl.Paint, AddressOf RoundedBorderPaint

        ctrl.Tag = New Tuple(Of Integer, Color, Integer)(radius, If(borderColor = Nothing, Color.DarkSeaGreen, borderColor), borderWidth)
    End Sub

    Private Sub RoundedBorderPaint(sender As Object, e As PaintEventArgs)
        Dim ctrl = DirectCast(sender, Control)
        If ctrl.Tag IsNot Nothing AndAlso TypeOf ctrl.Tag Is Tuple(Of Integer, Color, Integer) Then
            Dim style = DirectCast(ctrl.Tag, Tuple(Of Integer, Color, Integer))
            Dim radius = style.Item1
            Dim borderColor = style.Item2
            Dim borderWidth = style.Item3

            Dim rect As New Rectangle(0, 0, ctrl.Width - 1, ctrl.Height - 1)
            Using path As New Drawing2D.GraphicsPath()
                path.StartFigure()
                path.AddArc(New RectangleF(rect.Left, rect.Top, radius, radius), 180, 90)
                path.AddArc(New RectangleF(rect.Right - radius, rect.Top, radius, radius), 270, 90)
                path.AddArc(New RectangleF(rect.Right - radius, rect.Bottom - radius, radius, radius), 0, 90)
                path.AddArc(New RectangleF(rect.Left, rect.Bottom - radius, radius, radius), 90, 90)
                path.CloseFigure()
                Using pen As New Pen(borderColor, borderWidth)
                    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                    e.Graphics.DrawPath(pen, path)
                End Using
            End Using
        End If
    End Sub

    ' =========================================================================
    ' ON LOAD
    ' =========================================================================
    Private Sub AdmissionLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        ' Style Controls
        RoundControl(btnHome, 20, Color.MediumSeaGreen, 3)
        RoundControl(cmbProgramShow, 10, Color.Gray, 1)
        RoundControl(txtIndexNumberSearch, 10, Color.Gray, 1)

        ' Configure DataGridView for a clean, read-only experience
        With dgvApplicants
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen
            .DefaultCellStyle.SelectionForeColor = Color.White
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AllowUserToAddRows = False
            .RowTemplate.Height = 40
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        End With

        LoadProgramsDropdown()
        LoadApplicantData() ' Initial load of all data
    End Sub

    ' =========================================================================
    ' DATA BINDING & DATABASE LOGIC
    ' =========================================================================
    Private Sub LoadProgramsDropdown()
        Try
            Using conn = Database.GetOpenConnection()
                Dim query As String = "SELECT program_id, name FROM programs WHERE active = 1 ORDER BY name ASC"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()

                        ' Inject an "All Programs" default row at the top
                        dt.Columns.Add("program_id", GetType(Integer))
                        dt.Columns.Add("name", GetType(String))
                        dt.Rows.Add(0, "-- All Programs --")

                        adapter.Fill(dt)

                        ' Detach event temporarily to prevent premature firing during binding
                        RemoveHandler cmbProgramShow.SelectedIndexChanged, AddressOf cmbProgramShow_SelectedIndexChanged

                        cmbProgramShow.DataSource = dt
                        cmbProgramShow.DisplayMember = "name"
                        cmbProgramShow.ValueMember = "program_id"
                        cmbProgramShow.SelectedIndex = 0

                        AddHandler cmbProgramShow.SelectedIndexChanged, AddressOf cmbProgramShow_SelectedIndexChanged
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading programs: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Loads applicants based on the selected program and live search text.
    ''' STRICT PRIVACY: Only pulls Index Number, Program Name, and Final Result.
    ''' </summary>
    Private Sub LoadApplicantData()
        Try
            Using conn = Database.GetOpenConnection()
                ' We join students, program_choices, and programs.
                ' We prioritize the choice_rank so they see the status of their respective choices.
                Dim query As String = "SELECT s.index_number AS 'Index Number', " &
                                      "p.name AS 'Program Choice', " &
                                      "pc.choice_rank AS 'Choice Rank', " &
                                      "pc.result AS 'Admission Status' " &
                                      "FROM students s " &
                                      "JOIN program_choices pc ON s.student_id = pc.student_id " &
                                      "JOIN programs p ON pc.program_id = p.program_id " &
                                      "WHERE 1=1"

                ' Filter by Program Dropdown (if not "All Programs")
                If cmbProgramShow.SelectedValue IsNot Nothing AndAlso Convert.ToInt32(cmbProgramShow.SelectedValue) > 0 Then
                    query &= " AND pc.program_id = @programId"
                End If

                ' Filter by Live Search (Index Number)
                If Not String.IsNullOrWhiteSpace(txtIndexNumberSearch.Text) Then
                    query &= " AND s.index_number LIKE @searchText"
                End If

                query &= " ORDER BY s.index_number ASC, pc.choice_rank ASC"

                Using cmd As New MySqlCommand(query, conn)
                    If cmbProgramShow.SelectedValue IsNot Nothing AndAlso Convert.ToInt32(cmbProgramShow.SelectedValue) > 0 Then
                        cmd.Parameters.AddWithValue("@programId", Convert.ToInt32(cmbProgramShow.SelectedValue))
                    End If

                    If Not String.IsNullOrWhiteSpace(txtIndexNumberSearch.Text) Then
                        cmd.Parameters.AddWithValue("@searchText", "%" & txtIndexNumberSearch.Text.Trim() & "%")
                    End If

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        dgvApplicants.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading applicant list: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================================================================
    ' EVENT HANDLERS (LIVE SEARCH & FILTERING)
    ' =========================================================================
    Private Sub cmbProgramShow_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoadApplicantData()
    End Sub

    Private Sub txtIndexNumberSearch_TextChanged(sender As Object, e As EventArgs) Handles txtIndexNumberSearch.TextChanged
        ' Live search triggers the DB query. 
        ' Because it uses a parameterized LIKE query, it safely filters as the user types.
        LoadApplicantData()
    End Sub

    ' =========================================================================
    ' NAVIGATION
    ' =========================================================================
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form1.Show()
        Me.Hide()
    End Sub

    ' Protect against orphaned processes if the user hits the red 'X' to close the form
    Private Sub AdmissionLists_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class