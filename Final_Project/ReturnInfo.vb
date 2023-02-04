Public Class ReturnInfo
    Private _id As Integer
    Private _title As String
    Private _photo As String
    Private _client_number As String
    Private _firstname As String
    Private _lastname As String
    Private _rent_date As Date

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Property Photo As String
        Get
            Return _photo
        End Get
        Set(value As String)
            _photo = value
        End Set
    End Property

    Public Property Client_number As String
        Get
            Return _client_number
        End Get
        Set(value As String)
            _client_number = value
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

    Public Property Rent_date As Date
        Get
            Return _rent_date
        End Get
        Set(value As Date)
            _rent_date = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
End Class
