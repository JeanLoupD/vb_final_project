Public Class RentMovie
    Dim rent_db_connection As Rent_DB_Manager = New Rent_DB_Manager()
    Dim currentUser As Employee = Form1.logUser
    Dim client As Client
    Dim movie As Movie
    Dim clientId As Integer
    Dim clientNum As String
    Dim movieNum As Integer
    Dim movieId As Integer

    'When window load
    Private Sub RentMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disabling the rent movie menu button
        rentVideoMenu.Enabled = False

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

    'Advance Search Menu button
    Private Sub advanceSearchMenu_Click(sender As Object, e As EventArgs) Handles advanceSearchMenu.Click
        'Calling the advance search page
        AdvanceSearch.Show()
        Me.Close()
    End Sub

    'Return Video Menu button
    Private Sub returnVideoMenu_Click(sender As Object, e As EventArgs) Handles returnVideoMenu.Click
        'Calling the return video page
        ReturnMovie.Show()
        Me.Close()
    End Sub

    'Allow only number in client Id textfield
    Private Sub clientNumTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles clientNumTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Allow only number in video Id textfield
    Private Sub videoNumTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles videoNumTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Timer for the drop down human ressources panel
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (moviePanel.Size <> moviePanel.MaximumSize) Then
            moviePanel.Height += 10
            If (moviePanel.Size = moviePanel.MaximumSize) Then
                Timer1.Stop()
            End If
        End If
    End Sub


    Private Sub pictureTextfield_TextChanged(sender As Object, e As EventArgs) Handles pictureTextfield.TextChanged
        LoadImageFromUrl(pictureTextfield.Text, PictureBox1)
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

    'Select Client Button
    Private Sub selectButton_Click(sender As Object, e As EventArgs) Handles selectClientButton.Click

        If (clientNumTextfield.Text = "") Then
            MsgBox("Please enter the customer Id", MsgBoxStyle.Critical, "Empty Field")
        Else
            clientNum = clientNumTextfield.Text

            'Calling the client informations function
            client = rent_db_connection.ClientInformations(clientNum)

            If (client IsNot Nothing) Then
                'Holding the client id inside the variable
                clientId = client.Id

                fullnameTextfield.Text = client.Firstname & " " & client.Lastname
                addressTextfield.Text = client.Address & ", " & client.City & " " & client.Province & " " & client.Postal_code
                phoneTextfield.Text = client.Phone

                Timer1.Start()

            Else
                MsgBox("Client number don't match any of our clients", MsgBoxStyle.Critical, "Invalid Client")
            End If
        End If
    End Sub

    'Select Movie Button
    Private Sub startMovieButton_Click(sender As Object, e As EventArgs) Handles startMovieButton.Click
        If (videoNumTextfield.Text = "") Then
            MsgBox("Please enter the video Id", MsgBoxStyle.Critical, "Empty Field")
        Else
            movieNum = videoNumTextfield.Text

            'Calling the video information function
            movie = rent_db_connection.VideoInformation(movieNum)

            If (movie IsNot Nothing) Then
                movieId = movie.Id

                titleTextfield.Text = movie.Title
                yearTextfield.Text = movie.Year
                directorTextfield.Text = movie.Directors
                languageTextfield.Text = movie.Language
                resumeTextfield.Text = movie.Resume
                pictureTextfield.Text = movie.Photo
            Else
                MsgBox("Movie number don't match any of our movies", MsgBoxStyle.Critical, "Invalid Movie")
            End If
        End If

    End Sub

    'Rent Button
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click

        If (videoNumTextfield.Text = "") Then
            MsgBox("Please enter the id of the movie you want to rent", MsgBoxStyle.Critical, "Empty inputs")
        ElseIf (movie.Status = 0) Then
            MsgBox("This movie is already rented, please choose another one", MsgBoxStyle.Information, "Movie Unavailable")
        ElseIf (clientNumTextfield.Text = "") Then
            MsgBox("Please select a customer to continue", MsgBoxStyle.Critical, "No customer")
        ElseIf (client.Status = 0) Then
            MsgBox("Sorry this client no longer exist", MsgBoxStyle.Critical, "Deleted Client")
        Else
            Dim confirm = MsgBox("Are you sure you want to rent this movie?", MsgBoxStyle.YesNo, "Confimation")

            If (confirm = 6) Then
                MsgBox("Thank you for renting " & movie.Title & " you have 7 days before returning it", MsgBoxStyle.Information, "Video Rented")
                'Calling the rent movie function
                rent_db_connection.RentAMovie(clientId, movieNum)

                'Set the status of the movie to 0
                rent_db_connection.MovieIsRent(movieNum)

                'Getting the numbers of movie attached to the current user
                Dim totalMovies = rent_db_connection.MovieCount(clientId)

                'Inserting the movies inside the clients table
                rent_db_connection.InsertMovieCount(totalMovies, clientId)

                'Bring back the user to the main page
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