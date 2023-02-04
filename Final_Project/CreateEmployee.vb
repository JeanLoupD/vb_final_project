
Imports System.IO

Public Class CreateEmployee
    Dim db_connection As DB_Manager = New DB_Manager()
    Dim newEmployee As New Employee

    'Primary information variables
    Dim newFirstname As String
    Dim newLastname As String
    Dim newDob As Date
    Dim newPhone As String
    Dim newHomePhone As String
    Dim newAddress As String
    Dim newProvince As String
    Dim newCity As String
    Dim newPostal As String

    'Human resources variable
    Dim newNas As String
    Dim newSalary As Double
    Dim newSchool As String
    Dim newStartDate As DateTime

    'System Information
    Dim newUsername As String
    Dim newPassword As String
    Dim newLevel As Integer
    Dim newStatus As Integer

    'When window load
    Private Sub CreateEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disabling the create profile menu button
        createEmployeeMenu.Enabled = False

        'Putting the default password inside the password textfield
        passTextfield.Text = "hello_world"
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


    'Only allow numbers in home phone textbox
    Private Sub homephoneTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles homephoneTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or
                (Asc(e.KeyChar) = 45)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Only allow numbesr in nas textbox
    Private Sub nasTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nasTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or
                (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Only allow numbers and dot in salary textbox
    Private Sub salaryTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles salaryTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or
                (Asc(e.KeyChar) = 46)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Only allow numbers in level textbox
    Private Sub accessTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles accessTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
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
                Timer1.Stop()
            End If
        End If
    End Sub

    'Button connected to timer 1
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles continue1Btn.Click
        'Creating arraylist to hold all the database cell phone to check if new cell phone already exists
        Dim allCellPhone As New ArrayList()

        For Each cellPhoneRow As DataRow In db_connection.CellPhoneExist()
            allCellPhone.Add(cellPhoneRow("cell_phone"))
        Next

        'Creating arraylist to hold all the database home phone to check if new home phone already exists
        Dim allHomePhone As New ArrayList()

        For Each homePhoneRow As DataRow In db_connection.HomePhoneExist()
            allHomePhone.Add(homePhoneRow("home_phone"))
        Next

        If (firstnameTextfield.Text = "" Or lastnameTextfield.Text = "" Or dobTextfield.Text = "" Or
            phoneTextfield.Text = "" Or homephoneTextfield.Text = "" Or addressTexfield.Text = "" Or
                provinceTextfield.Text = "" Or cityTextfield.Text = "" Or postalTextfield.Text = "") Then
            MsgBox("Please fill all the fields", MsgBoxStyle.Critical, "Empty fields")
        ElseIf (firstnameTextfield.Text.Length < 3 Or lastnameTextfield.Text.Length < 3) Then
            MsgBox("First name and Last name must be at least 3 characters", MsgBoxStyle.Critical, "Error")
        ElseIf (phoneTextfield.Text.Length < 12 Or homephoneTextfield.Text.Length < 12) Then
            MsgBox("Phone number must be 12 characters", MsgBoxStyle.Critical, "Error")
        ElseIf (postalTextfield.Text.Length < 7) Then
            MsgBox("Postal code must be 6 characters (### ###)", MsgBoxStyle.Critical, "Error")
        ElseIf (allCellPhone.Contains(phoneTextfield.Text)) Then
            MsgBox("This Cell phone number already exists, please try again", MsgBoxStyle.Critical, "Cell number exist")
            'ElseIf (allHomePhone.Contains(homephoneTextfield.Text)) Then
            '    MsgBox("This Home phone number already exists, please try again", MsgBoxStyle.Critical, "Home number exist")
        Else
            Dim age As String
            age = Now.Year - dobTextfield.Value.ToString("yyyy")

            newFirstname = firstnameTextfield.Text
            newLastname = lastnameTextfield.Text
            newDob = dobTextfield.Value.ToString("yyyy-MM-dd")
            newPhone = phoneTextfield.Text
            newHomePhone = homephoneTextfield.Text
            newAddress = addressTexfield.Text
            newProvince = provinceTextfield.SelectedItem
            newCity = cityTextfield.Text
            newPostal = postalTextfield.Text

            'Setting the age in the textbox
            ageTextfield.Text = age

            Timer1.Start()
        End If
    End Sub

    'Button connected to timer 2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles continue2Btn.Click
        'Creating arraylist to hold all the database sin number to check if new sin already exists
        Dim allNas As New ArrayList()

        For Each nasRow As DataRow In db_connection.NasExist()
            allNas.Add(nasRow("sin"))
        Next

        If (nasTextfield.Text = "" Or salaryTextfield.Text = "" Or startTextfield.Text = "" Or
            schoolTextfield.Text = "") Then
            MsgBox("Please fill all the fields", MsgBoxStyle.Critical, "Empty fields")
        ElseIf (nasTextfield.Text.Length < 11) Then
            MsgBox("Social Insurance Number must be in this format ### ### ###", MsgBoxStyle.Critical, "Error")
        ElseIf (allNas.Contains(nasTextfield.Text)) Then
            MsgBox("This sin number already exists, please try again", MsgBoxStyle.Critical, "Sin number exist")
        Else
            newNas = nasTextfield.Text
            newSalary = salaryTextfield.Text
            newSchool = schoolTextfield.Text
            newStartDate = startTextfield.Value.ToString("yyyy-MM-dd")

            Timer2.Start()
        End If
    End Sub

    'Save Button
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        'Creating arraylist to hold all the database username to check if new username already exists
        Dim allUsername As New ArrayList()

        For Each usernameRow As DataRow In db_connection.UsernameExist()
            allUsername.Add(usernameRow("username"))
        Next

        If (usernameTextfield.Text = "" Or passTextfield.Text = "" Or accessTextfield.Text = "") Then
            MsgBox("Please fill all the missing fields", MsgBoxStyle.Critical, "Empty fields")
        ElseIf (usernameTextfield.Text.Length < 3) Then
            MsgBox("Username must be at least 3 characters", MsgBoxStyle.Critical, "Error")
        ElseIf (allUsername.Contains(usernameTextfield.Text)) Then
            MsgBox("This username already exists, please try again", MsgBoxStyle.Critical, "Username exist")
        ElseIf (passTextfield.Text.Length < 5) Then
            MsgBox("Password must be at least 5 characters", MsgBoxStyle.Critical, "Error")
        ElseIf (accessTextfield.Text < "1" Or accessTextfield.Text > "3") Then
            MsgBox("Access Level must be between 1 and 3", MsgBoxStyle.Critical, "Error")
        ElseIf (activeCheckbox.Checked And inactiveCheckbox.Checked) Then
            MsgBox("Please select only one of the checkbox options for the status", MsgBoxStyle.Critical, "Error")
        Else
            'Getting the check box value
            If (activeCheckbox.Checked) Then
                newStatus = 1
            Else
                newStatus = 0
            End If

            newUsername = usernameTextfield.Text
            newPassword = passTextfield.Text
            newLevel = accessTextfield.Text

            ''Setting the employee number to be randomize
            Dim randNumber As New Random
            Dim test As Integer = randNumber.Next(100000000, 2147483647)

            'Passing all the values to my new employee
            newEmployee = New Employee()
            newEmployee.Employee_number = test.ToString
            newEmployee.Firstname = newFirstname
            newEmployee.Lastname = newLastname
            newEmployee.Dob = newDob
            newEmployee.Cell_phone = newPhone
            newEmployee.Home_phone = newHomePhone
            newEmployee.Address = newAddress
            newEmployee.Province = newProvince
            newEmployee.City = newCity
            newEmployee.Postal_code = newPostal
            newEmployee.Nas = newNas
            newEmployee.Salary = newSalary
            newEmployee.Education = newSchool
            newEmployee.Start_date = newStartDate
            newEmployee.Username = newUsername
            newEmployee.Password = newPassword
            newEmployee.Level = newLevel
            newEmployee.Status = newStatus

            'Confirmation Message
            Dim confirm = MsgBox("Confirm informations?" & vbCrLf &
                                 "Full name: " & newEmployee.Firstname & " " & newEmployee.Lastname & vbCrLf &
                                 "Birthdate: " & newEmployee.Dob & vbCrLf &
                                 "Cell phone: " & newEmployee.Cell_phone & " Home phone: " & newEmployee.Home_phone & vbCrLf &
                                 "Address: " & newEmployee.Address & " " & newEmployee.City & " " & newEmployee.Province & " " & newEmployee.Postal_code & vbCrLf &
                                 "Nas: " & newEmployee.Nas & vbCrLf &
                                 "Salary: " & newEmployee.Salary & "/Hour" & vbCrLf &
                                 "Education: " & newEmployee.Education & vbCrLf &
                                 "Start date: " & newEmployee.Start_date & vbCrLf &
                                 "Level: " & newEmployee.Level & " Status: " & newEmployee.Status,
                                    MsgBoxStyle.YesNo, "Confirm information")

            If (confirm = 6) Then
                'Calling the create employee function
                db_connection.CreateEmployee(newEmployee)

                MsgBox("The new employee (#" & newEmployee.Employee_number & ") has been created", MsgBoxStyle.Information, "New Employee")

                'Bringing back the user to the main page
                AdminMain.Show()
                Me.Close()
            End If
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