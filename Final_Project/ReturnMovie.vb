Public Class ReturnMovie
    Dim rent_db_connection As Rent_DB_Manager = New Rent_DB_Manager()
    Dim currentUser As Employee = Form1.logUser
    Dim returnInfo As ReturnInfo
    Dim returntId As Integer
    Dim clientNum As String
    Dim movieNum As Integer

    'When window load
    Private Sub ReturnMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disable the return a movie menu button
        returnVideoMenu.Enabled = False

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

    'Rent Video Menu button
    Private Sub rentVideoMenu_Click(sender As Object, e As EventArgs) Handles rentVideoMenu.Click
        'Calling the rent video page
        RentMovie.Show()
        Me.Close()
    End Sub

    'Textbox handling the url for the movie picture
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

    'Select video id button
    Private Sub selectClientButton_Click(sender As Object, e As EventArgs) Handles selectClientButton.Click
        If (videoNumTextfield.Text = "") Then
            MsgBox("Please enter the video number reference you would like to return", MsgBoxStyle.Critical, "Empty Id")
        Else
            'Holding the video id inside a variable
            movieNum = videoNumTextfield.Text

            'Calling the function to fill all the textfields
            returnInfo = rent_db_connection.MovieClientInformation(movieNum)

            If (returnInfo IsNot Nothing) Then
                'Holding the return info id
                returntId = returnInfo.Id

                'Filling all the textfields with the informations
                titleTextfield.Text = returnInfo.Title
                pictureTextfield.Text = returnInfo.Photo
                clientNumTextfield.Text = returnInfo.Client_number
                nameTextfield.Text = returnInfo.Firstname & " " & returnInfo.Lastname
                rentTextfield.Text = returnInfo.Rent_date
            Else
                MsgBox("Movie number don't match any of our movies", MsgBoxStyle.Critical, "Invalid Movie")
            End If

        End If
    End Sub

    'Return video
    Private Sub returnBtn_Click(sender As Object, e As EventArgs) Handles returnBtn.Click
        If (videoNumTextfield.Text = "") Then
            MsgBox("Please enter the video number reference you would like to return", MsgBoxStyle.Critical, "Empty Id")
        Else
            'Calling the function to set the video status to 1
            rent_db_connection.MovieIsReturned(movieNum)

            MsgBox("Thank you for returning your movie", MsgBoxStyle.Information, "Thank you")

            'Bringing the admin back the main page
            AdminMain.Show()
            Me.Close()
        End If
    End Sub

    'Cancel button
    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Dim cancel = MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo, "Cancel")

        If (cancel = 6) Then
            'Bringing the admin back to the admin main
            AdminMain.Show()
            Me.Hide()
        End If
    End Sub
End Class