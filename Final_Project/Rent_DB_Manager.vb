Imports System.DirectoryServices.ActiveDirectory
Imports System.Windows.Forms.Design
Imports MySql.Data.MySqlClient
Public Class Rent_DB_Manager
    Private connect As New MySqlConnection
    Private connectionString = "server=localhost;user id=root;password=;database=vb_final;"

    'Function to get all the informations of the client
    Public Function ClientInformations(ByVal client_num As String)
        Dim client As Client

        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT * FROM clients2 WHERE client_number = @client_number"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@client_number", client_num)

            Dim dataReader As MySqlDataReader
            dataReader = cmd.ExecuteReader()

            While dataReader.Read
                client = New Client()
                client.Id = dataReader.GetInt32("client_id")
                client.Firstname = dataReader.GetString("fname")
                client.Lastname = dataReader.GetString("lname")
                client.Phone = dataReader.GetString("phone")
                client.Address = dataReader.GetString("address")
                client.City = dataReader.GetString("city")
                client.Province = dataReader.GetString("province")
                client.Postal_code = dataReader.GetString("postal_code")
                client.Card_type = dataReader.GetString("card_type")
                client.Card_number = dataReader.GetString("card_number")
                client.Month = dataReader.GetString("month")
                client.Year = dataReader.GetString("year")
                client.Status = dataReader.GetInt16("status")
            End While

            'Closing the reader to get accurate values
            dataReader.Close()
            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return client
    End Function

    'Function to get all the informations of the movie
    Public Function VideoInformation(ByVal movie_id As Integer)
        Dim movie As Movie

        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT * FROM videos WHERE video_id = @video_id"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@video_id", movie_id)

            Dim dataReader As MySqlDataReader
            dataReader = cmd.ExecuteReader()

            While dataReader.Read
                movie = New Movie()
                movie.Id = dataReader.GetInt32("video_id")
                movie.Photo = dataReader.GetString("photo")
                movie.Title = dataReader.GetString("title")
                movie.Year = dataReader.GetString("year")
                movie.Country = dataReader.GetString("country")
                movie.Language = dataReader.GetString("language")
                movie.Length = dataReader.GetInt16("length")
                movie.Resume = dataReader.GetString("resume")
                movie.Genre = dataReader.GetString("genre")
                movie.Actors = dataReader.GetString("actors")
                movie.Directors = dataReader.GetString("director")
                movie.Status = dataReader.GetInt16("status")
            End While

            'Closing the reader to get accurate values
            dataReader.Close()
            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return movie
    End Function

    'Function to rent the movie and add it with the user in the rent table
    Public Function RentAMovie(ByVal client_number As String, ByVal video_number As Integer)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "INSERT INTO rents
                                        (client_fk, video_fk) 
                                            VALUES 
                                        (@client_fk, @video_fk)"
            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@client_fk", client_number)
            cmd.Parameters.AddWithValue("@video_fk", video_number)

            cmd.ExecuteNonQuery()

            'Closing the connection
            Me.connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return result
        Return Nothing
    End Function

    'Function to change the status of the movie to 0 (rented)
    Public Function MovieIsRent(ByVal movie_id As Integer)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "UPDATE videos SET status = 0 WHERE video_id=@id"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@id", movie_id)

            cmd.ExecuteNonQuery()

            'Closing the connection
            Me.connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return result
        Return Nothing
    End Function

    'Function to change the status of the movie to 1 (returned)
    Public Function MovieIsReturned(ByVal movie_id As Integer)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "UPDATE videos SET status = 1 WHERE video_id=@id"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@id", movie_id)

            cmd.ExecuteNonQuery()

            'Closing the connection
            Me.connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return result
        Return Nothing
    End Function

    'Function to see how many movies a client rented
    Public Function MovieCount(ByVal client_id As Integer)
        Dim result As Integer
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT COUNT(*) FROM rents WHERE client_fk=@id"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@id", client_id)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                result = reader(0)
            End If

            'Closing the reader
            reader.Close()
            'Closing the connection
            Me.connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return result
        Return result
    End Function

    'Function to insert the number of movies inside the movie_rented in clients table
    Public Function InsertMovieCount(ByVal movie_count As Integer, ByVal id As Integer)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "UPDATE clients2 SET movie_rented = @count WHERE client_id=@id"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@count", movie_count)
            cmd.Parameters.AddWithValue("@id", id)

            cmd.ExecuteNonQuery()

            'Closing the connection
            Me.connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return result
        Return Nothing
    End Function

    'Functions to retrieve all the informations of the video and user when returning a movie
    Public Function MovieClientInformation(ByVal movie_id As Integer)
        Dim returnInfo As ReturnInfo

        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT r.rent_id, v.title, c.client_number, c.fname, c.lname, r.rent_date, v.photo 
                                        FROM rents AS r
                                        INNER JOIN clients2 AS c
                                        ON r.client_fk = c.client_id
                                        INNER JOIN videos AS v
                                        ON r.video_fk = v.video_id
                                    WHERE r.video_fk = @video_id"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@video_id", movie_id)

            Dim dataReader As MySqlDataReader
            dataReader = cmd.ExecuteReader()

            While dataReader.Read
                returnInfo = New ReturnInfo()
                returnInfo.Id = dataReader.GetInt32("rent_id")
                returnInfo.Photo = dataReader.GetString("photo")
                returnInfo.Title = dataReader.GetString("title")
                returnInfo.Client_number = dataReader.GetString("client_number")
                returnInfo.Firstname = dataReader.GetString("fname")
                returnInfo.Lastname = dataReader.GetString("lname")
                returnInfo.Rent_date = dataReader.GetDateTime("rent_date")
            End While

            'Closing the reader to get accurate values
            dataReader.Close()
            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return returnInfo
    End Function


    'Function to increment the video_rented column in the clients table
    'Public Function NumberOfMovieRented(ByVal client_id As Integer)
    '    Try
    '        'Connecting to the database
    '        Me.connect = New MySqlConnection(connectionString)
    '        Me.connect.Open()

    '        'Initializing the query
    '        Dim query As String = "UPDATE clients2 SET status = 0 WHERE video_id=@id"

    '        'Execute the query
    '        Dim cmd As New MySqlCommand(query, Me.connect)

    '        'Add variable value to database column
    '        cmd.Parameters.AddWithValue("@id", client_id)

    '        cmd.ExecuteNonQuery()

    '        'Closing the connection
    '        Me.connect.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
    '    End Try

    '    'Return result
    '    Return Nothing
    'End Function
End Class
