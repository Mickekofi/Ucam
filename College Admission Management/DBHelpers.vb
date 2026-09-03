Imports MySql.Data.MySqlClient

Module DBHelpers
    ' You should declare a connection variable. 
    ' For demonstration, let's assume a public connection property in this module.
    Public Property conn As MySqlConnection

    ''' <summary>
    ''' Returns a MySqlCommand that automatically appends a department filter
    ''' (WHERE or AND ...) when the current user is a department_admin.
    ''' Provide the column to filter (e.g. "p.department_id" or "programs.department_id").
    ''' </summary>
    Public Function GetDeptScopedCommand(baseSql As String, deptColumn As String) As MySqlCommand
        Dim sql As String = baseSql

        If LoggedInUser.Role = "department_admin" Then
            If baseSql.IndexOf(" WHERE ", StringComparison.OrdinalIgnoreCase) >= 0 Then
                sql &= " AND " & deptColumn & " = @deptId"
            Else
                sql &= " WHERE " & deptColumn & " = @deptId"
            End If
        End If

        Dim cmd As New MySqlCommand(sql, conn)
        If LoggedInUser.Role = "department_admin" Then
            cmd.Parameters.AddWithValue("@deptId", LoggedInUser.DepartmentId)
        End If
        Return cmd
    End Function
End Module






