﻿Imports System.Data.Common

Public Class CreateVideo
    Dim movie_db_connection As Video_DB_Manager = New Video_DB_Manager()
    Dim currentUser As Employee = Form1.logUser
    Dim newMovie As Movie

    Dim newId As Integer
    Dim newTitle As String
    Dim newYear As String
    Dim newCountry As String
    Dim newLanguage As String
    Dim newLength As Integer
    Dim newResume As String
    Dim newGenre As String
    Dim newDirector As String
    Dim newActors As String
    Dim newPhoto As String
    Dim newStatus As Integer


    'When window load
    Private Sub CreateVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disabling the create movie menu button
        CreateToolStripMenuItem1.Enabled = False

        'Displaying the menu button depending on employee access level
        If (currentUser.Level = 1) Then
            'Removing the employee list button
            EmployeeToolStripMenuItem.Visible = False

            'Removing the edit and delete button for all section
            videoEditMenu.Visible = False
            videoDeleteMenu.Visible = False
            clientEditMenu.Visible = False
            clientDeleteMenu.Visible = False
        ElseIf (currentUser.Level = 2) Then
            'Removing the employee list button
            EmployeeToolStripMenuItem.Visible = False

            'Removing the delete button for all section
            videoDeleteMenu.Visible = False
            clientDeleteMenu.Visible = False
        End If
    End Sub

    'Change password Menu button
    Private Sub changePassMenu_Click(sender As Object, e As EventArgs) Handles changePassMenu.Click
        'Clearing the textbox in update password page
        UpdatePassword.passTextfield.Text = ""
        UpdatePassword.newPassTextfield.Text = ""
        UpdatePassword.confirmPassTextfield.Text = ""

        'Calling the update password page
        UpdatePassword.Show()
        Me.Close()
    End Sub

    'Logout Menu Button
    Private Sub logoutMenu_Click(sender As Object, e As EventArgs) Handles logoutMenu.Click
        MsgBox("Thank you have a great day!", MsgBoxStyle.Information, "Goodbye")

        'Clearing the textbox in login page
        Form1.usernameTextfield.Text = ""
        Form1.passTextfield.Text = ""

        'Calling the login page
        Form1.Show()
        Me.Close()
    End Sub

    'Exit Menu button
    Private Sub exitMenu_Click(sender As Object, e As EventArgs) Handles exitMenu.Click
        'Closing the application
        Me.Close()
    End Sub

    'Employee List Menu button
    Private Sub employeeListMenu_Click(sender As Object, e As EventArgs) Handles employeeListMenu.Click
        'Calling the list employee page
        ListEmployee.Show()
        Me.Close()
    End Sub

    'Employee Create Menu button
    Private Sub createEmployeeMenu_Click(sender As Object, e As EventArgs) Handles createEmployeeMenu.Click
        'Calling the create employee page
        CreateEmployee.Show()
        Me.Close()
    End Sub

    'Employee Edit Menu button
    Private Sub editEmployeeMenu_Click(sender As Object, e As EventArgs) Handles editEmployeeMenu.Click
        'Calling the edit employee page
        EditEmployee.Show()
        Me.Close()
    End Sub

    'Employee Delete Menu button
    Private Sub deleteEmployeeMenu_Click(sender As Object, e As EventArgs) Handles deleteEmployeeMenu.Click
        'Calling the delete employee page
        DeleteEmployee.Show()
        Me.Close()
    End Sub

    'Movie List Menu button
    Private Sub videoListMenu_Click(sender As Object, e As EventArgs) Handles videoListMenu.Click
        'Calling the movie list page
        ListVideo.Show()
        Me.Close()
    End Sub

    'Edit Movie Menu Button
    Private Sub videoEditMenu_Click(sender As Object, e As EventArgs) Handles videoEditMenu.Click
        'Calling the edit movie page
        EditVideo.Show()
        Me.Close()
    End Sub

    'Delete Video Menu button
    Private Sub videoDeleteMenu_Click(sender As Object, e As EventArgs) Handles videoDeleteMenu.Click
        'Calling the delete movie page
        DeleteVideo.Show()
        Me.Close()
    End Sub

    'Client List Menu Button
    Private Sub clientListMenu_Click(sender As Object, e As EventArgs) Handles clientListMenu.Click
        'Calling the List Client page
        ListClient.Show()
        Me.Close()
    End Sub

    'Create Client Menu button
    Private Sub clientCreateMenu_Click(sender As Object, e As EventArgs) Handles clientCreateMenu.Click
        'Calling the Create client page
        CreateClient.Show()
        Me.Close()
    End Sub

    'Edit Client Menu button
    Private Sub clientEditMenu_Click(sender As Object, e As EventArgs) Handles clientEditMenu.Click
        'Calling the Edit client page
        EditClient.Show()
        Me.Close()
    End Sub

    'Delete Client Menu button
    Private Sub clientDeleteMenu_Click(sender As Object, e As EventArgs) Handles clientDeleteMenu.Click
        'Calling the Delete client page
        DeleteClient.Show()
        Me.Close()
    End Sub

    'Quick Search Menu button
    Private Sub quickSearchMenu_Click(sender As Object, e As EventArgs) Handles quickSearchMenu.Click
        'Calling the quick search page
        QuickSearch.Show()
        Me.Close()
    End Sub

    'Advance Search Menu button
    Private Sub advanceSearchMenu_Click(sender As Object, e As EventArgs) Handles advanceSearchMenu.Click
        'Calling the advance search page
        AdvanceSearch.Show()
        Me.Close()
    End Sub

    'Rent Video Menu button
    Private Sub rentVideoMenu_Click(sender As Object, e As EventArgs) Handles rentVideoMenu.Click
        'Calling the rent video page
        RentMovie.Show()
        Me.Close()
    End Sub

    'Return Video Menu button
    Private Sub returnVideoMenu_Click(sender As Object, e As EventArgs) Handles returnVideoMenu.Click
        'Calling the return video page
        ReturnMovie.Show()
        Me.Close()
    End Sub

    'Textbox handling the url for the movie picture
    Private Sub imageTextfield_TextChanged(sender As Object, e As EventArgs) Handles imageTextfield.TextChanged
        LoadImageFromUrl(imageTextfield.Text, moviePicture)
    End Sub

    'Only Allow number in Year Textfield
    Private Sub yearTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles yearTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Only allow space, letters, hyphen and comma inside Country textfield
    Private Sub countryTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles countryTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or
                (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or
                (Asc(e.KeyChar) = 45) Or (Asc(e.KeyChar) = 44) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Only allow space, letters, hyphen and comma inside Genre textfield
    Private Sub genreTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles genreTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or
                (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or
                (Asc(e.KeyChar) = 45) Or (Asc(e.KeyChar) = 44) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Only allow space, letters and comma inside Language textfield
    Private Sub languageTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles languageTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or
                (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or
                (Asc(e.KeyChar) = 44) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Only allow space, letters, hyphen, apostrophe and comma inside Actors textfield
    Private Sub actorsTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles actorsTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or
                (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or
                (Asc(e.KeyChar) = 45) Or (Asc(e.KeyChar) = 44) Or
                (Asc(e.KeyChar) = 32) Or (Asc(e.KeyChar) = 39)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Only Allow number in Length Textfield
    Private Sub lengthTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lengthTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Only allow letters hyphen and apostrophe inside Director Textfield
    Private Sub directorTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles directorTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or
                (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or
                (Asc(e.KeyChar) = 45) Or (Asc(e.KeyChar) = 39) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Function to print the image from a url link
    Public Sub LoadImageFromUrl(ByRef url As String, ByVal pb As PictureBox)
        Dim request As Net.HttpWebRequest = DirectCast(Net.HttpWebRequest.Create(url), Net.HttpWebRequest)
        Dim response As Net.HttpWebResponse = DirectCast(request.GetResponse, Net.HttpWebResponse)
        Dim img As Image = Image.FromStream(response.GetResponseStream())
        response.Close()
        pb.SizeMode = PictureBoxSizeMode.StretchImage
        pb.Image = img
    End Sub

    'Save Button
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If (titleTextfield.Text = "" Or yearTextfield.Text = "" Or countryTextfield.Text = "" Or
            languageTextfield.Text = "" Or lengthTextfield.Text = "" Or genreTextfield.Text = "" Or
            directorTextfield.Text = "" Or actorsTextfield.Text = "" Or imageTextfield.Text = "" Or
            resumeTextfield.Text = "") Then
            MsgBox("Please fill all the missing fields", MsgBoxStyle.Critical, "Missing Fields")
        ElseIf (countryTextfield.Text.Length < 2) Then
            MsgBox("Country name should be at least 2 characters", MsgBoxStyle.Critical, "Invalid name")
        ElseIf (actorsTextfield.Text.Length < 6 Or directorTextfield.Text.Length < 6) Then
            MsgBox("Please enter a valid name", MsgBoxStyle.Critical, "Invalid name")
        ElseIf (yearTextfield.Text < 1888) Then
            MsgBox("Please enter a movie made after the year of 1888", MsgBoxStyle.Critical, "Invalid year")
        ElseIf (lengthTextfield.Text < 30) Then
            MsgBox("Please enter a length over 30 minutes", MsgBoxStyle.Critical, "Invalid length")
        Else
            'Holding the user entries inside variable
            newTitle = titleTextfield.Text
            newYear = yearTextfield.Text
            newCountry = countryTextfield.Text
            newLanguage = languageTextfield.Text
            newLength = lengthTextfield.Text
            newResume = resumeTextfield.Text
            newGenre = genreTextfield.Text
            newDirector = directorTextfield.Text
            newActors = actorsTextfield.Text
            newPhoto = imageTextfield.Text

            'Assigning all the values to the movie class
            newMovie = New Movie()
            'newMovie.Id = test.ToString()
            newMovie.Title = newTitle
            newMovie.Year = newYear
            newMovie.Country = newCountry
            newMovie.Language = newLanguage
            newMovie.Length = newLength
            newMovie.Genre = newGenre
            newMovie.Directors = newDirector
            newMovie.Actors = newActors
            newMovie.Resume = newResume
            newMovie.Photo = newPhoto
            newMovie.Status = 1

            'Confirmation Message
            Dim confirm = MsgBox("Confirm informations?" & vbCrLf &
                                 "Title: " & newMovie.Title & vbCrLf &
                                 "Year: " & newMovie.Year & vbCrLf &
                                 "Country: " & newMovie.Country & vbCrLf &
                                 "Language: " & newMovie.Language & vbCrLf &
                                 "Length in minutes: " & newMovie.Length & vbCrLf &
                                 "Genre: " & newMovie.Genre & vbCrLf &
                                 "Director: " & newMovie.Directors & vbCrLf &
                                 "Actors: " & newMovie.Actors & vbCrLf &
                                 "Resume: " & newMovie.Resume, MsgBoxStyle.YesNo, "Confirm information")

            If (confirm = 6) Then
                'Calling the create employee function
                movie_db_connection.CreateMovie(newMovie)

                MsgBox("The new movie has been created", MsgBoxStyle.Information, "New Employee")

                'Bringing back the user to the main page
                AdminMain.Show()
                Me.Close()
            End If
        End If
    End Sub

    'Cancel Button
    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Dim cancel = MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo, "Cancel")

        If (cancel = 6) Then
            'Bringing the admin back to the admin main
            AdminMain.Show()
            Me.Hide()
        End If
    End Sub

End Class