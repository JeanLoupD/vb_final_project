Public Class Client
    Private _id As Integer
    Private _client_number As String
    Private _firstname As String
    Private _lastname As String
    Private _email As String
    Private _phone As String
    Private _dob As Date
    Private _address As String
    Private _city As String
    Private _province As String
    Private _postal_code As String
    Private _card_type As String
    Private _card_number As String
    Private _month As String
    Private _year As String
    Private _movie_rented As Integer
    Private _status As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
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

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Phone As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
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

    Public Property Status As Integer
        Get
            Return _status
        End Get
        Set(value As Integer)
            _status = value
        End Set
    End Property

    Public Property Card_type As String
        Get
            Return _card_type
        End Get
        Set(value As String)
            _card_type = value
        End Set
    End Property

    Public Property Card_number As String
        Get
            Return _card_number
        End Get
        Set(value As String)
            _card_number = value
        End Set
    End Property

    Public Property Month As String
        Get
            Return _month
        End Get
        Set(value As String)
            _month = value
        End Set
    End Property

    Public Property Year As String
        Get
            Return _year
        End Get
        Set(value As String)
            _year = value
        End Set
    End Property

    Public Property Movie_rented As Integer
        Get
            Return _movie_rented
        End Get
        Set(value As Integer)
            _movie_rented = value
        End Set
    End Property
End Class
