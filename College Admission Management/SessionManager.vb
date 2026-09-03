Public Module SessionManager
    ' Private backing fields - impenetrable from outside the module
    Private _userId As Integer = -1
    Private _username As String = String.Empty
    Private _role As String = String.Empty
    Private _departmentId As Nullable(Of Integer) = Nothing
    Private _loginTime As DateTime

    ' Read-only properties - UI can read these, but cannot overwrite them
    Public ReadOnly Property CurrentUserID As Integer
        Get
            Return _userId
        End Get
    End Property

    Public ReadOnly Property CurrentUsername As String
        Get
            Return _username
        End Get
    End Property

    Public ReadOnly Property CurrentRole As String
        Get
            Return _role
        End Get
    End Property

    Public ReadOnly Property CurrentDepartmentID As Nullable(Of Integer)
        Get
            Return _departmentId
        End Get
    End Property

    ' Check if someone is actually logged in
    Public ReadOnly Property IsActive As Boolean
        Get
            Return _userId <> -1
        End Get
    End Property

    ' =========================================================================
    ' INITIALIZATION (Call this ONLY from your Login form after verifying password)
    ' =========================================================================
    Public Sub StartSession(id As Integer, name As String, role As String, deptId As Nullable(Of Integer))
        _userId = id
        _username = name
        _role = role
        _departmentId = deptId
        _loginTime = DateTime.Now
    End Sub

    ' =========================================================================
    ' TERMINATION (Call this on Logout)
    ' =========================================================================
    Public Sub EndSession()
        _userId = -1
        _username = String.Empty
        _role = String.Empty
        _departmentId = Nothing
    End Sub

    ' =========================================================================
    ' AUTHORIZATION CHECKS (Use these to show/hide UI elements)
    ' =========================================================================
    Public Function IsSuperAdmin() As Boolean
        Return _role = "super_admin"
    End Function

    Public Function IsDepartmentAdmin() As Boolean
        ' A department admin MUST have a valid department_id assigned
        Return _role = "department_admin" AndAlso _departmentId.HasValue
    End Function

    ' Global verification to throw out malicious actors instantly
    Public Sub EnforceSuperAdminAccess()
        If Not IsSuperAdmin() Then
            Throw New UnauthorizedAccessException("Critical Violation: User attempted to access a SuperAdmin resource.")
        End If
    End Sub
End Module