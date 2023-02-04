Imports System.Buffers
Imports System.Net
Imports System.Net.Mail
Imports System.Security.AccessControl
Imports System.Threading

Public Class EditClient
    Dim client_db_connection As Client_DB_Manager = New Client_DB_Manager()
    Dim currentUser As Employee = Form1.logUser
    Dim editClient As New Client
    Dim emailIsValid As Boolean
    Dim mailAddress As MailAddress
    Dim comboId As Integer
    Dim test As Integer
    Dim clientNumber As String

    'Primary information variables
    Dim editFirstname As String
    Dim editLastname As String
    Dim editDob As Date
    Dim editPhone As String
    Dim editEmail As String
    Dim editAddress As String
    Dim editProvince As String
    Dim editCity As String
    Dim editPostal As String

    'Credit information
    Dim editCardType As String
    Dim editCardNumber As String
    Dim editExpMonth As String
    Dim editExpYear As String

    'When Window load
    Private Sub EditClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Diabling the Edit Client menu button
        clientEditMenu.Enabled = False

        'Populatin the combo box
        client_db_connection.ShowAllClientEdit()

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

    'Only allow letter in firstname textbox
    Private Sub firstnameTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles firstnameTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or
                (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or
                (Asc(e.KeyChar) = 45)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Only allow letter in lastname textbox
    Private Sub lastnameTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lastnameTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or
                (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or
                (Asc(e.KeyChar) = 45)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Only allow numbers in cell phone textbox
    Private Sub phoneTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phoneTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or
                (Asc(e.KeyChar) = 45)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Only allow number and space inside the card number textfield
    Private Sub cardNumberTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cardNumberTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or
                    (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Timer for the drop down primary information panel
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If (primaryPanel.Size <> primaryPanel.MaximumSize) Then
            primaryPanel.Height += 10
            If (primaryPanel.Size = primaryPanel.MaximumSize) Then
                Timer3.Stop()
            End If
        End If
    End Sub

    'Timer for the drop down human ressources panel
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (hrPanel.Size <> hrPanel.MaximumSize) Then
            hrPanel.Height += 10
            If (hrPanel.Size = hrPanel.MaximumSize) Then
                Timer1.Stop()
            End If
        End If
    End Sub

    'Timer for the drop down system information panel
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (systemPanel.Size <> systemPanel.MaximumSize) Then
            systemPanel.Height += 10
            If (systemPanel.Size = systemPanel.MaximumSize) Then
                Timer2.Stop()
            End If
        End If
    End Sub

    'Select Button
    Private Sub selectBtn_Click(sender As Object, e As EventArgs) Handles selectBtn.Click
        'Holding the combo box to use it as id
        comboId = editClientCombobox.SelectedValue

        'Calling the function to retrieve all informations of the employee
        editClient = client_db_connection.ClientInformation(comboId)

        'Grabbing the client number
        clientNumber = editClient.Client_number

        'Filling all the textfields with the client informations
        firstnameTextfield.Text = editClient.Firstname
        lastnameTextfield.Text = editClient.Lastname
        dobTextfield.Text = editClient.Dob

        'For the age textfield
        Dim age As String
        age = Now.Year - dobTextfield.Value.ToString("yyyy")
        ageTextfield.Text = age

        'Filling the rest of the textfields
        phoneTextfield.Text = editClient.Phone
        emailTextfield.Text = editClient.Email
        addressTexfield.Text = editClient.Address
        provinceTextfield.SelectedItem = editClient.Province
        cityTextfield.Text = editClient.City
        postalTextfield.Text = editClient.Postal_code
        typeCardTextfield.SelectedItem = editClient.Card_type
        cardNumberTextfield.Text = editClient.Card_number
        monthCardTextfield.SelectedItem = editClient.Month
        yearCardTextfield.SelectedItem = editClient.Year
        clientNumberTextfield.Text = editClient.Client_number
        videoRentedTextfield.Text = editClient.Movie_rented

        Timer3.Start()
    End Sub

    'Continue button #1 connecting to the first timer
    Private Sub continue1Btn_Click(sender As Object, e As EventArgs) Handles continue1Btn.Click
        'Try and catch for email validation
        Try
            mailAddress = New MailAddress(emailTextfield.Text)
            emailIsValid = True
        Catch ex As Exception
            'MsgBox("Email not valid, please try again", MsgBoxStyle.Critical, "Invalid Email")
            emailIsValid = False
        End Try

        If (firstnameTextfield.Text = "" Or lastnameTextfield.Text = "" Or dobTextfield.Text = "" Or
           phoneTextfield.Text = "" Or addressTexfield.Text = "" Or emailTextfield.Text = "" Or
               provinceTextfield.Text = "" Or cityTextfield.Text = "" Or postalTextfield.Text = "") Then
            MsgBox("Please fill all the fields", MsgBoxStyle.Critical, "Empty fields")
        ElseIf (firstnameTextfield.Text.Length < 3 Or lastnameTextfield.Text.Length < 3) Then
            MsgBox("First name and Last name must be at least 3 characters", MsgBoxStyle.Critical, "Error")
        ElseIf (phoneTextfield.Text.Length < 12) Then
            MsgBox("Phone number must be 12 characters", MsgBoxStyle.Critical, "Error")
        ElseIf (postalTextfield.Text.Length < 7) Then
            MsgBox("Postal code must be 6 characters (### ###)", MsgBoxStyle.Critical, "Error")
        ElseIf (emailIsValid = False) Then
            MsgBox("Email not valid, please try again", MsgBoxStyle.Critical, "Invalid Email")
        Else
            Dim age As String
            age = Now.Year - dobTextfield.Value.ToString("yyyy")

            editFirstname = firstnameTextfield.Text
            editLastname = lastnameTextfield.Text
            editDob = dobTextfield.Value.ToString("yyyy-MM-dd")
            editPhone = phoneTextfield.Text
            editEmail = emailTextfield.Text
            editAddress = addressTexfield.Text
            editProvince = provinceTextfield.SelectedItem
            editCity = cityTextfield.Text
            editPostal = postalTextfield.Text

            'Setting the age in the textbox
            ageTextfield.Text = age

            Timer1.Start()
        End If
    End Sub

    'Continue button #2 connecting to the second timer
    Private Sub continue2Btn_Click(sender As Object, e As EventArgs) Handles continue2Btn.Click
        If (typeCardTextfield.Text = "" Or cardNumberTextfield.Text = "" Or
            monthCardTextfield.Text = "" Or yearCardTextfield.Text = "") Then
            MsgBox("Please fill all the fields", MsgBoxStyle.Critical, "Empty fields")
        ElseIf (cardNumberTextfield.Text.Length < 19) Then
            MsgBox("Card number must in this format (#### #### #### ####)", MsgBoxStyle.Critical, "Error")
        Else
            editCardType = typeCardTextfield.SelectedItem
            editCardNumber = cardNumberTextfield.Text
            editExpMonth = monthCardTextfield.SelectedItem
            editExpYear = yearCardTextfield.SelectedItem

            Timer2.Start()
        End If
    End Sub

    'Save Button
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        'Setting the status to 1 (active)
        Dim newStatus As Integer = 1

        'Passing all the values to the new client
        editClient = New Client()
        editClient.Client_number = test.ToString
        editClient.Firstname = editFirstname
        editClient.Lastname = editLastname
        editClient.Dob = editDob
        editClient.Phone = editPhone
        editClient.Email = editEmail
        editClient.Address = editAddress
        editClient.Province = editProvince
        editClient.City = editCity
        editClient.Postal_code = editPostal
        editClient.Card_type = editCardType
        editClient.Card_number = editCardNumber
        editClient.Month = editExpMonth
        editClient.Year = editExpYear
        editClient.Status = newStatus

        'Confirmation message
        Dim confirm = MsgBox("Confirm informations?" & vbCrLf &
                             "Full name: " & editClient.Firstname & " " & editClient.Lastname & vbCrLf &
                             "Birthdate: " & editClient.Dob & vbCrLf &
                             "Phone number: " & editClient.Phone & vbCrLf &
                             "Email: " & editClient.Email & vbCrLf &
                             "Address: " & editClient.Address & ", " & editClient.City & ", " & editClient.Province & ", " & editClient.Postal_code & vbCrLf &
                             "Card info: " & editClient.Card_type & ", " & editClient.Card_number & ", " & editClient.Month & "/" & editClient.Year,
                            MsgBoxStyle.YesNo, "Confirm informations")

        If (confirm = 6) Then
            'Calling the create client function
            client_db_connection.EditAClient(editClient, comboId)

            MsgBox("Client (#" & clientNumber & ") has been updated", MsgBoxStyle.Information, "Client Updated")

            'Bringing back the user to the main page
            AdminMain.Show()
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