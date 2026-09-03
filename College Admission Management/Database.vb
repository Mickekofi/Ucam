Imports MySql.Data.MySqlClient
Imports System.Data

' Using a Module or Shared methods prevents you from needlessly instantiating the Database class
Public Module Database

    ' Connection string remains private. 
    ' Notice we explicitly enable pooling (though it is usually on by default)


    ' Change Connection Strings From Here(For Deployment Security Reasons Try to Keep it in an App Config File)

    Private ReadOnly connString As String = "server=127.0.0.1;user id=root;password=;database=ucam_db;Pooling=true;Min Pool Size=0;Max Pool Size=100;"

    ''' <summary>
    ''' Generates and opens a fresh connection from the ADO.NET connection pool.
    ''' The caller is strictly responsible for disposing of it via a Using block.
    ''' </summary>
    Public Function GetOpenConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            Return conn
        Catch ex As MySqlException
            ' Log this error to a file in a real system, don't just show a messagebox
            MessageBox.Show("CRITICAL: Database connection failed. " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw ' Rethrow so the calling method knows to abort the operation
        End Try
    End Function

End Module