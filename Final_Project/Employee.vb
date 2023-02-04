Public Class Employee
    Private _id As Integer
    Private _employee_number As String
    Private _username As String
    Private _password As String
    Private _firstname As String
    Private _lastname As String
    Private _dob As Date
    Private _email As String
    Private _address As String
    Private _city As String
    Private _province As String
    Private _postal_code As String
    Private _home_phone As String
    Private _cell_phone As String
    Private _start_date As Date
    Private _nas As String
    Private _salary As Double
    Private _education As String
    Private _level As Integer
    Private _status As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Employee_number As String
        Get
            Return _employee_number
        End Get
        Set(value As String)
            _employee_number = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Firstname As String
        Get
            Return _firstname
        End Get
        Set(value As String)
            _firstname = value
        End Set
    End Property

    Public Property Lastname As String
        Get
            Return _lastname
        End Get
        Set(value As String)
            _lastname = value
        End Set
    End Property

    Public Property Dob As Date
        Get
            Return _dob
        End Get
        Set(value As Date)
            _dob = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property

    Public Property City As String
        Get
            Return _city
        End Get
        Set(value As String)
            _city = value
        End Set
    End Property

    Public Property Province As String
        Get
            Return _province
        End Get
        Set(value As String)
            _province = value
        End Set
    End Property

    Public Property Postal_code As String
        Get
            Return _postal_code
        End Get
        Set(value As String)
            _postal_code = value
        End Set
    End Property

    Public Property Cell_phone As String
        Get
            Return _cell_phone
        End Get
        Set(value As String)
            _cell_phone = value
        End Set
    End Property

    Public Property Start_date As Date
        Get
            Return _start_date
        End Get
        Set(value As Date)
            _start_date = value
        End Set
    End Property

    Public Property Nas As String
        Get
            Return _nas
        End Get
        Set(value As String)
            _nas = value
        End Set
    End Property

    Public Property Salary As Double
        Get
            Return _salary
        End Get
        Set(value As Double)
            _salary = value
        End Set
    End Property

    Public Property Education As String
        Get
            Return _education
        End Get
        Set(value As String)
            _education = value
        End Set
    End Property

    Public Property Level As Integer
        Get
            Return _level
        End Get
        Set(value As Integer)
            _level = value
        End Set
    End Property

    Public Property Status As Integer
        Get
            Return _status
        End Get
        Set(value As Integer)
            _status = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Home_phone As String
        Get
            Return _home_phone
        End Get
        Set(value As String)
            _home_phone = value
        End Set
    End Property
End Class
