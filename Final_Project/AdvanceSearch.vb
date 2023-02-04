Public Class AdvanceSearch
    Dim search_db_connection As Search_DB_Manager = New Search_DB_Manager()
    Dim currentUser As Employee = Form1.logUser
    Dim movie As Movie

    Dim title As String
    Dim country As String
    Dim language As String
    Dim genre As String
    Dim director As String
    Dim actor As String
    Dim year As String
    Dim length As Integer
    Dim res As String

    Public selectedCell As String

    'When window load
    Private Sub AdvanceSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disabling the advance search menu button
        advanceSearchMenu.Enabled = False

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

    'Create Movie Menu button
    Private Sub CreateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem1.Click
        'Calling the create movie page
        CreateVideo.Show()
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

    'Only allow numbers in year textfield
    Private Sub yearTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles yearTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Only allow numbers in length textfield
    Private Sub lengthTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lengthTextfield.KeyPress
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

    'Only allow space, letters, hyphen, apostrophe and comma inside Actors textfield
    Private Sub actorTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles actorTextfield.KeyPress
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

    'Cell mouse press listener
    Private Sub advanceSearchList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles advanceSearchList.CellClick
        If (e.RowIndex >= 0 And e.ColumnIndex = advanceSearchList.Columns("video_id").Index) Then
            selectedCell = advanceSearchList.Rows(e.RowIndex).Cells("video_id").Value
        End If
    End Sub

    'Search button
    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        If (titleTextfield.Text = "" And countryTextfield.Text = "" And languageTextfield.Text = "" And
            genreTextfield.Text = "" And directorTextfield.Text = "" And actorTextfield.Text = "" And
            yearTextfield.Text = "" And lengthTextfield.Text = "" And resumeTextfield.Text = "") Then
            MsgBox("Please fill at least one text field to execute the search", MsgBoxStyle.Critical, "Error")
        Else
            title = titleTextfield.Text
            country = countryTextfield.Text
            language = languageTextfield.Text
            genre = genreTextfield.Text
            director = directorTextfield.Text
            actor = actorTextfield.Text
            year = yearTextfield.Text
            'length = lengthTextfield.Text
            res = resumeTextfield.Text

            'Calling the advance search function
            search_db_connection.AdvancedSearch(movie, title, country, language, genre, director, actor, year, res)

        End If
    End Sub

    'Rent movie Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles rentMovieBtn.Click

        If (selectedCell = "") Then
            MsgBox("No video was selected, please try again", MsgBoxStyle.Critical, "No movie selected")
        Else
            'Bringing the id to the rent page video id text field
            RentMovie.videoNumTextfield.Text = selectedCell

            'Bringing the user to the rent movie page
            RentMovie.Show()
            Me.Close()
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