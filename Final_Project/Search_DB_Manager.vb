Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Imports Org.BouncyCastle.Crypto

Public Class Search_DB_Manager
    Private connect As New MySqlConnection
    Private connectionString = "server=localhost;user id=root;password=;database=vb_final;"

    '====================================== QUICK SEARCH SECTION =================================
    Public Function SearchByTitle(ByVal movies As Movie, ByVal movie_title As String)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT * FROM videos WHERE title = @title"

            'Creating the data table
            Dim dataUser As New DataTable()

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            cmd.Parameters.AddWithValue("@title", movie_title)

            'Fill the table
            adapter.Fill(dataUser)

            With QuickSearch.quickSearchList
                If (dataUser.Rows.Count = 0) Then
                    MsgBox("No Movie was found, please try again", MsgBoxStyle.Information, "No result")
                Else
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
                    .Columns(0).Width = 50
                    .Columns(3).Width = 50
                    .Columns(6).Width = 60
                    .Columns(7).Width = 120
                    .Columns(11).Width = 60
                End If
            End With

            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return Nothing
    End Function

    Public Function SearchById(ByVal movies As Movie, ByVal movie_id As Integer)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT * FROM videos WHERE video_id = @id"

            'Creating the data table
            Dim dataUser As New DataTable()

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            cmd.Parameters.AddWithValue("@id", movie_id)

            'Fill the table
            adapter.Fill(dataUser)

            With QuickSearch.quickSearchList
                If (dataUser.Rows.Count = 0) Then
                    MsgBox("No Movie was found, please try again", MsgBoxStyle.Information, "No result")
                Else
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
                    .Columns(0).Width = 50
                    .Columns(3).Width = 50
                    .Columns(6).Width = 60
                    .Columns(7).Width = 120
                    .Columns(11).Width = 60
                End If
            End With

            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return Nothing
    End Function

    Public Function SearchByTitleAndId(ByVal movies As Movie, ByVal movie_title As String, ByVal movie_id As Integer)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT * FROM videos WHERE video_id = @id AND title = @title"

            'Creating the data table
            Dim dataUser As New DataTable()

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            cmd.Parameters.AddWithValue("@id", movie_id)
            cmd.Parameters.AddWithValue("@title", movie_title)

            'Fill the table
            adapter.Fill(dataUser)

            With QuickSearch.quickSearchList
                If (dataUser.Rows.Count = 0) Then
                    MsgBox("No Movie was found, please try again", MsgBoxStyle.Information, "No result")
                Else
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
                    .Columns(0).Width = 50
                    .Columns(3).Width = 50
                    .Columns(6).Width = 60
                    .Columns(7).Width = 120
                    .Columns(11).Width = 60
                End If
            End With

            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return Nothing
    End Function
    '==================================== END QUICK SEARCH SECTION ===============================

    '==================================== ADVANCED SEARCH SECTION ================================
    Public Function AdvancedSearch(ByVal movies As Movie, ByVal movTitle As String, ByVal movCountry As String,
                                   ByVal movLanguage As String, ByVal movGenre As String, ByVal movDirector As String,
                                   ByVal movActors As String, ByVal movYear As String,
                                   ByVal movResume As String)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Creating the data table
            Dim dataUser As New DataTable()

            'To add AND
            Dim needAnd As Boolean = False

            'Initializing the query
            Dim query As String = "SELECT * FROM videos WHERE "

            If (AdvanceSearch.titleTextfield.Text <> "") Then
                query += "title LIKE @title "
                needAnd = True
            End If

            If (AdvanceSearch.countryTextfield.Text <> "") Then
                If (needAnd = True) Then
                    query += "AND "
                End If
                query += "country LIKE @country "
                needAnd = True
            End If

            If (AdvanceSearch.languageTextfield.Text <> "") Then
                If (needAnd = True) Then
                    query += "AND "
                End If
                query += "language LIKE @language "
                needAnd = True
            End If

            If (AdvanceSearch.genreTextfield.Text <> "") Then
                If (needAnd = True) Then
                    query += "AND "
                End If
                query += "genre LIKE @genre "
                needAnd = True
            End If

            If (AdvanceSearch.directorTextfield.Text <> "") Then
                If (needAnd = True) Then
                    query += "AND "
                End If
                query += "director = @director "
                needAnd = True
            End If

            If (AdvanceSearch.actorTextfield.Text <> "") Then
                If (needAnd = True) Then
                    query += "AND "
                End If
                query += "actors LIKE @actors "
                needAnd = True
            End If

            If (AdvanceSearch.yearTextfield.Text <> "") Then
                If (needAnd = True) Then
                    query += "AND "
                End If
                query += "year = @year "
                needAnd = True
            End If

            'If (AdvanceSearch.lengthTextfield.Text <> "") Then
            '    If (needAnd = True) Then
            '        query += "AND "
            '    End If
            '    query += "length = @length "

            '    needAnd = True
            'End If

            If (AdvanceSearch.resumeTextfield.Text <> "") Then
                If (needAnd = True) Then
                    query += "AND "
                End If
                query += "resume LIKE @resume "
                needAnd = True
            End If

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            cmd.Parameters.AddWithValue("@title", "%" & movTitle & "%")
            cmd.Parameters.AddWithValue("@country", "%" & movCountry & "%")
            cmd.Parameters.AddWithValue("@language", "%" & movLanguage & "%")
            cmd.Parameters.AddWithValue("@genre", "%" & movGenre & "%")
            cmd.Parameters.AddWithValue("@director", movDirector)
            cmd.Parameters.AddWithValue("@actors", "%" & movActors & "%")
            cmd.Parameters.AddWithValue("@year", movYear)
            'cmd.Parameters.AddWithValue("@length", movLength)
            cmd.Parameters.AddWithValue("@resume", "%" & movResume & "%")

            'Fill the table
            adapter.Fill(dataUser)

            With AdvanceSearch.advanceSearchList
                If (dataUser.Rows.Count = 0) Then
                    MsgBox("No Movie was found, please try again", MsgBoxStyle.Information, "No result")
                Else
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
                    .Columns(0).Width = 50
                    .Columns(3).Width = 50
                    .Columns(6).Width = 60
                    .Columns(7).Width = 120
                    .Columns(11).Width = 60

                End If
            End With

            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return Nothing
    End Function

    '================================== END ADVANCED SEARCH SECTION ==============================
End Class
