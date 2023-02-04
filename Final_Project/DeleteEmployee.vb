Public Class DeleteEmployee
    Dim db_connection As DB_Manager = New DB_Manager()
    Dim employee As Employee

    'When window load
    Private Sub DeleteEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disabling the Delete Employee Menu button
        deleteEmployeeMenu.Enabled = False

        'Calling the function to populate the data grid view
        db_connection.ShowAllEmployees(employee)

        'Populating the combox box with all the employees
        db_connection.ShowAllEmployeeEdit()
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

    'Return Video Menu button
    Private Sub returnVideoMenu_Click(sender As Object, e As EventArgs) Handles returnVideoMenu.Click
        'Calling the return video page
        ReturnMovie.Show()
        Me.Close()
    End Sub

    'Delete button
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        'Holding the info from the combobox in a variable
        Dim name As String = ComboBox2.Text.ToString()

        'Holding the index from the combobox
        Dim comboIndex = ComboBox2.SelectedValue

        Dim deleteEmployee = MsgBox("Are you sure you want to delete " & name & " ?", MsgBoxStyle.YesNo, "Delete Profile")

        If (deleteEmployee = 6) Then
            'Calling the function to delete employee from database
            db_connection.DeleteAnEmployee(comboIndex)

            MsgBox("This employee has ben deleted successfully", MsgBoxStyle.Information, "Delete Profile")

            'Refresh the page
            db_connection.ShowAllEmployees(employee)
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