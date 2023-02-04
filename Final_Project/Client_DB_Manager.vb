Imports System.DirectoryServices.ActiveDirectory
Imports System.Drawing.Design
Imports System.Runtime.Versioning
Imports System.Windows.Forms.Design
Imports MySql.Data.MySqlClient

Public Class Client_DB_Manager
    Private connect As New MySqlConnection
    Private connectionString = "server=localhost;user id=root;password=;database=vb_final;"

    '================================= CLIENT LIST SECTION ===================================
    Public Sub ShowAllClients(ByVal clients As Client)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT * FROM clients2 ORDER BY client_id DESC"

            'Creating the data table
            Dim dataClients As New DataTable()

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            'Fill the table
            adapter.Fill(dataClients)

            With ListClient.allClientsList
                .DataSource = dataClients

                'Renaming the columns
                .Columns(0).HeaderText = "Id"
                .Columns(1).HeaderText = "Client Number"
                .Columns(2).HeaderText = "First name"
                .Columns(3).HeaderText = "Last name"
                .Columns(4).HeaderText = "Email"
                .Columns(5).HeaderText = "Telephone"
                .Columns(6).HeaderText = "Date of birth"
                .Columns(7).HeaderText = "Address"
                .Columns(8).HeaderText = "City"
                .Columns(9).HeaderText = "Province"
                .Columns(10).HeaderText = "Postal code"
                .Columns(11).HeaderText = "Card type"
                .Columns(12).HeaderText = "Card number"
                .Columns(13).HeaderText = "Card exp month"
                .Columns(14).HeaderText = "Card exp year"
                .Columns(15).HeaderText = "Movie Rented"
                .Columns(16).HeaderText = "Status"

                'Resizing the columns
                .Columns(0).Width = 30
                .Columns(1).Width = 70
                .Columns(2).Width = 80
                .Columns(3).Width = 80
                .Columns(6).Width = 80
                .Columns(10).Width = 70
                .Columns(13).Width = 50
                .Columns(14).Width = 50
                .Columns(16).Width = 50
            End With

            With DeleteClient.allClientsDeleteList
                .DataSource = dataClients

                'Renaming the columns
                .Columns(0).HeaderText = "Id"
                .Columns(1).HeaderText = "Client Number"
                .Columns(2).HeaderText = "First name"
                .Columns(3).HeaderText = "Last name"
                .Columns(4).HeaderText = "Email"
                .Columns(5).HeaderText = "Telephone"
                .Columns(6).HeaderText = "Date of birth"
                .Columns(7).HeaderText = "Address"
                .Columns(8).HeaderText = "City"
                .Columns(9).HeaderText = "Province"
                .Columns(10).HeaderText = "Postal code"
                .Columns(11).HeaderText = "Card type"
                .Columns(12).HeaderText = "Card number"
                .Columns(13).HeaderText = "Card exp month"
                .Columns(14).HeaderText = "Card exp year"
                .Columns(15).HeaderText = "Status"

                'Resizing the columns
                .Columns(0).Width = 30
                .Columns(1).Width = 70
                .Columns(2).Width = 80
                .Columns(3).Width = 80
                .Columns(6).Width = 80
                .Columns(10).Width = 70
                .Columns(13).Width = 50
                .Columns(14).Width = 50
                .Columns(15).Width = 50
            End With

            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub
    '=============================== END CLIENT LIST SECTION ===================================

    '================================ CREATE CLIENT SECTION ====================================
    Public Function CreateClient(ByVal new_client As Client)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "INSERT INTO clients2
                                        (client_number, fname, lname, email, phone, dob, address, city, 
                                        province, postal_code, card_type, card_number, month, year, status) 
                                            VALUES 
                                        (@client_number, @fname, @lname, @email, @phone, @dob, @address, 
                                         @city, @province, @postal_code, @card_type, @card_number, @month, 
                                         @year, @status)"
            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@client_number", new_client.Client_number)
            cmd.Parameters.AddWithValue("@fname", new_client.Firstname)
            cmd.Parameters.AddWithValue("@lname", new_client.Lastname)
            cmd.Parameters.AddWithValue("@email", new_client.Email)
            cmd.Parameters.AddWithValue("@phone", new_client.Phone)
            cmd.Parameters.AddWithValue("@dob", new_client.Dob)
            cmd.Parameters.AddWithValue("@address", new_client.Address)
            cmd.Parameters.AddWithValue("@city", new_client.City)
            cmd.Parameters.AddWithValue("@province", new_client.Province)
            cmd.Parameters.AddWithValue("@postal_code", new_client.Postal_code)
            cmd.Parameters.AddWithValue("@card_type", new_client.Card_type)
            cmd.Parameters.AddWithValue("@card_number", new_client.Card_number)
            cmd.Parameters.AddWithValue("@month", new_client.Month)
            cmd.Parameters.AddWithValue("@year", new_client.Year)
            cmd.Parameters.AddWithValue("@status", new_client.Status)

            cmd.ExecuteNonQuery()

            'Closing the connection
            Me.connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return result
        Return Nothing
    End Function
    '================================ END CREATE CLIENT SECTION ================================

    '=================================== EDIT CLIENT SECTION ===================================
    Public Sub ShowAllClientEdit()
        'Creating a Data Table
        'Dim movieDataSet As New DataSet

        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT client_id, client_number, fname, lname FROM clients2"
            Dim dataTable As New DataTable()

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Creating the adapter
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataTable)

            'Creating a temporary column to display information in the combox box
            dataTable.Columns.Add("fullname", Type.GetType("System.String"), "client_number + ': ' + fname + ' ' + lname")

            With EditClient.editClientCombobox
                EditClient.editClientCombobox.DataSource = dataTable
                EditClient.editClientCombobox.DisplayMember = "fullname"
                EditClient.editClientCombobox.ValueMember = "client_id"
            End With

            With DeleteClient.deleteClientCombobox
                DeleteClient.deleteClientCombobox.DataSource = dataTable
                DeleteClient.deleteClientCombobox.DisplayMember = "fullname"
                DeleteClient.deleteClientCombobox.ValueMember = "client_id"
            End With

            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    Public Function ClientInformation(ByVal id As Integer)
        Dim editClient As Client

        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT * FROM clients2 WHERE client_id = @id"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@id", id)

            Dim dataReader As MySqlDataReader
            dataReader = cmd.ExecuteReader()

            While dataReader.Read
                editClient = New Client()
                editClient.Id = dataReader.GetInt32("client_id")
                editClient.Client_number = dataReader.GetString("client_number")
                editClient.Firstname = dataReader.GetString("fname")
                editClient.Lastname = dataReader.GetString("lname")
                editClient.Email = dataReader.GetString("email")
                editClient.Phone = dataReader.GetString("phone")
                editClient.Dob = dataReader.GetDateTime("dob")
                editClient.Address = dataReader.GetString("address")
                editClient.City = dataReader.GetString("city")
                editClient.Province = dataReader.GetString("province")
                editClient.Postal_code = dataReader.GetString("postal_code")
                editClient.Card_type = dataReader.GetString("card_type")
                editClient.Card_number = dataReader.GetString("card_number")
                editClient.Month = dataReader.GetString("month")
                editClient.Year = dataReader.GetString("year")
                editClient.Movie_rented = dataReader.GetInt32("movie_rented")
                editClient.Status = dataReader.GetInt16("status")
            End While

            'Closing the reader to get accurate values
            dataReader.Close()
            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return editClient
    End Function

    Public Function EditAClient(ByVal edit_client As Client, ByVal id As Integer)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "UPDATE clients2 SET
                                         fname=@fname, lname=@lname, email=@email, phone=@phone, dob=@dob, 
                                         address=@address, city=@city, province=@province, postal_code=@postal_code,
                                         card_type=@card_type, card_number=@card_number, month=@month, year=@year, 
                                         status=@status
                                   WHERE client_id=@id"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@fname", edit_client.Firstname)
            cmd.Parameters.AddWithValue("@lname", edit_client.Lastname)
            cmd.Parameters.AddWithValue("@email", edit_client.Email)
            cmd.Parameters.AddWithValue("@phone", edit_client.Phone)
            cmd.Parameters.AddWithValue("@dob", edit_client.Dob)
            cmd.Parameters.AddWithValue("@address", edit_client.Address)
            cmd.Parameters.AddWithValue("@city", edit_client.City)
            cmd.Parameters.AddWithValue("@province", edit_client.Province)
            cmd.Parameters.AddWithValue("@postal_code", edit_client.Postal_code)
            cmd.Parameters.AddWithValue("@card_type", edit_client.Card_type)
            cmd.Parameters.AddWithValue("@card_number", edit_client.Card_number)
            cmd.Parameters.AddWithValue("@month", edit_client.Month)
            cmd.Parameters.AddWithValue("@year", edit_client.Year)
            cmd.Parameters.AddWithValue("@status", edit_client.Status)

            cmd.ExecuteNonQuery()

            'Closing the connection
            Me.connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return result
        Return Nothing
    End Function
    '=================================== END EDIT CLIENT SECTION ===================================

    '================================== DELETE CLIENT SECTION ==================================
    Public Function DeleteAClient(ByVal client_id As Integer)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "UPDATE clients2 SET status = 0 WHERE client_id=@id"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@id", client_id)

            cmd.ExecuteNonQuery()

            'Closing the connection
            Me.connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return result
        Return Nothing
    End Function
    '================================ END DELETE CLIENT SECTION ================================

    '=================================== EMAIL EXIST SECTION ===================================
    Public Function EmailExist()
        Dim userDataSet As New DataSet
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT email FROM clients2"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Creating the adapter
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(userDataSet, "clientEmail")
            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return userDataSet.Tables("clientEmail").Rows
    End Function
    '================================= END EMAIL EXIST SECTION =================================


    '================================== CELL PHONE DUPLICATE SECTION =================================
    Public Function PhoneExist()
        Dim userDataSet As New DataSet
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT phone FROM clients2"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Creating the adapter
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(userDataSet, "usersPhone")
            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return userDataSet.Tables("usersPhone").Rows
    End Function
End Class
