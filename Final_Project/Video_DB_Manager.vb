Imports MySql.Data.MySqlClient
Public Class Video_DB_Manager
    Private connect As New MySqlConnection
    Private connectionString = "server=localhost;user id=root;password=;database=vb_final;"

    '================================= MOVIES LIST SECTION ===================================
    Public Sub ShowAllMovies(ByVal movies As Movie)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT * FROM videos ORDER BY video_id DESC"

            'Creating the data table
            Dim dataUser As New DataTable()

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            'Fill the table
            adapter.Fill(dataUser)

            With ListVideo.allMoviesList
                .DataSource = dataUser

                'Renaming the columns
                .Columns(0).HeaderText = "Id"
                .Columns(1).HeaderText = "Photo"
                .Columns(2).HeaderText = "Title"
                .Columns(3).HeaderText = "Year"
                .Columns(4).HeaderText = "Country"
                .Columns(5).HeaderText = "Language"
                .Columns(6).HeaderText = "Length"
                .Columns(7).HeaderText = "Resume"
                .Columns(8).HeaderText = "Genre"
                .Columns(9).HeaderText = "Actors"
                .Columns(10).HeaderText = "Directors"
                .Columns(11).HeaderText = "Status"

                'Resizing the columns
                '.Columns(0).Width = 30
                '.Columns(10).Width = 80
                '.Columns(15).Width = 55
                '.Columns(16).Width = 70
                '.Columns(17).Width = 50
                '.Columns(18).Width = 50
            End With

            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub
    '=============================== END MOVIES LIST SECTION =================================

    '================================= CREATE MOVIE SECTION ==================================
    Public Function CreateMovie(ByVal new_movie As Movie)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "INSERT INTO videos
                                        (video_id, photo, title, year, country, language, length, resume, 
                                        genre, actors, director, status) 
                                            VALUES 
                                        (@video_id, @photo, @title, @year, @country, @language, @length, 
                                         @resume, @genre, @actors, @director, @status)"
            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@video_id", new_movie.Id)
            cmd.Parameters.AddWithValue("@photo", new_movie.Photo)
            cmd.Parameters.AddWithValue("@title", new_movie.Title)
            cmd.Parameters.AddWithValue("@year", new_movie.Year)
            cmd.Parameters.AddWithValue("@country", new_movie.Country)
            cmd.Parameters.AddWithValue("@language", new_movie.Language)
            cmd.Parameters.AddWithValue("@length", new_movie.Length)
            cmd.Parameters.AddWithValue("@resume", new_movie.Resume)
            cmd.Parameters.AddWithValue("@genre", new_movie.Genre)
            cmd.Parameters.AddWithValue("@actors", new_movie.Actors)
            cmd.Parameters.AddWithValue("@director", new_movie.Directors)
            cmd.Parameters.AddWithValue("@status", new_movie.Status)

            cmd.ExecuteNonQuery()

            'Closing the connection
            Me.connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return result
        Return Nothing
    End Function
    '=============================== END CREATE MOVIE SECTION ================================

    '================================== EDIT MOVIE SECTION ===================================
    Public Sub ShowAllMovieEdit()
        'Creating a Data Table
        'Dim movieDataSet As New DataSet

        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT video_id, title FROM videos ORDER BY title ASC"

            'Creating the datatable
            Dim dataTable As New DataTable()

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Creating the adapter
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataTable)

            With EditVideo.movieComboBox
                EditVideo.movieComboBox.DataSource = dataTable
                EditVideo.movieComboBox.DisplayMember = "title"
                EditVideo.movieComboBox.ValueMember = "video_id"
            End With

            With DeleteVideo.movieComboBox
                DeleteVideo.movieComboBox.DataSource = dataTable
                DeleteVideo.movieComboBox.DisplayMember = "title"
                DeleteVideo.movieComboBox.ValueMember = "video_id"
            End With

            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return movieDataSet.Tables("testing").Rows
    End Sub

    Public Function MovieInformation(ByVal movie_title As String)
        Dim editMovie As Movie

        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT * FROM videos WHERE title = @title"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@title", movie_title)

            Dim dataReader As MySqlDataReader
            dataReader = cmd.ExecuteReader()

            While dataReader.Read
                editMovie = New Movie()
                editMovie.Id = dataReader.GetInt32("video_id")
                editMovie.Photo = dataReader.GetString("photo")
                editMovie.Title = dataReader.GetString("title")
                editMovie.Year = dataReader.GetString("year")
                editMovie.Country = dataReader.GetString("country")
                editMovie.Language = dataReader.GetString("language")
                editMovie.Length = dataReader.GetInt16("length")
                editMovie.Resume = dataReader.GetString("resume")
                editMovie.Genre = dataReader.GetString("genre")
                editMovie.Actors = dataReader.GetString("actors")
                editMovie.Directors = dataReader.GetString("director")
                editMovie.Status = dataReader.GetInt16("status")
            End While

            'Closing the reader to get accurate values
            dataReader.Close()
            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return editMovie
    End Function

    Public Function EditMovie(ByVal edit_movie As Movie, ByVal movie_id As Integer)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "UPDATE videos SET
                                         photo=@photo, title=@title, year=@year, country=@country, 
                                         language=@language, length=@length, resume=@resume, genre=@genre, 
                                         actors=@actors, director=@director
                                   WHERE video_id=@id"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@id", movie_id)
            cmd.Parameters.AddWithValue("@photo", edit_movie.Photo)
            cmd.Parameters.AddWithValue("@title", edit_movie.Title)
            cmd.Parameters.AddWithValue("@year", edit_movie.Year)
            cmd.Parameters.AddWithValue("@country", edit_movie.Country)
            cmd.Parameters.AddWithValue("@language", edit_movie.Language)
            cmd.Parameters.AddWithValue("@length", edit_movie.Length)
            cmd.Parameters.AddWithValue("@resume", edit_movie.Resume)
            cmd.Parameters.AddWithValue("@genre", edit_movie.Genre)
            cmd.Parameters.AddWithValue("@actors", edit_movie.Actors)
            cmd.Parameters.AddWithValue("@director", edit_movie.Directors)

            cmd.ExecuteNonQuery()

            'Closing the connection
            Me.connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return result
        Return Nothing
    End Function
    '================================ END EDIT MOVIE SECTION =================================

    '================================= DELETE MOVIE SECTION ==================================
    Public Function DeleteAMovie(ByVal movie_id As Integer)
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

    'To show all movies inside the data grid view in the delete movie page
    Public Sub ShowAllMoviesToDelete(ByVal movies As Movie)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT * FROM videos ORDER BY video_id DESC"

            'Creating the data table
            Dim dataMovie As New DataTable()

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            'Fill the table
            adapter.Fill(dataMovie)

            With DeleteVideo.allMoviesList
                .DataSource = dataMovie

                'Renaming the columns
                .Columns(0).HeaderText = "Id"
                .Columns(1).HeaderText = "Photo"
                .Columns(2).HeaderText = "Title"
                .Columns(3).HeaderText = "Year"
                .Columns(4).HeaderText = "Country"
                .Columns(5).HeaderText = "Language"
                .Columns(6).HeaderText = "Length"
                .Columns(7).HeaderText = "Resume"
                .Columns(8).HeaderText = "Genre"
                .Columns(9).HeaderText = "Actors"
                .Columns(10).HeaderText = "Directors"
                .Columns(11).HeaderText = "Status"

                'Resizing the columns
                .Columns(0).Width = 50
                .Columns(2).Width = 110
                .Columns(3).Width = 50
                .Columns(6).Width = 55
                .Columns(11).Width = 50

            End With

            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub
    '=============================== END DELETE MOVIE SECTION ================================
End Class
