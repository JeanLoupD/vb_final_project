
Public Class EditEmployee
    Dim db_connection As DB_Manager = New DB_Manager()
    Dim updateEmployee As Employee

    'Select the combo index that will match the user id
    Dim comboIndex As Integer
    Dim employeeNumber As String

    'Primary information variables
    Dim editFirstname As String
    Dim editLastname As String
    Dim editDob As Date
    Dim editPhone As String
    Dim editHomePhone As String
    Dim editAddress As String
    Dim editProvince As String
    Dim editCity As String
    Dim editPostal As String

    'Human resources variable
    Dim editNas As String
    Dim editSalary As Double
    Dim editSchool As String
    Dim editStartDate As DateTime

    'System Information
    Dim editUsername As String
    Dim editPassword As String
    Dim editLevel As Integer
    Dim editStatus As Integer

    'When window load
    Private Sub EditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disabling the edit employee menu button
        editEmployeeMenu.Enabled = False

        'Populating the combox box with all the employees with status = 1
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

    'Only allow numbers and hyphen in home phone textbox
    Private Sub homephoneTextfield_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles homephoneTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or
                (Asc(e.KeyChar) = 45)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Only allow number sin nas textbox
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

    'Only allow letters, hypen and apostrophe in city textbox
    Private Sub cityTextfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cityTextfield.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or
                (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or
                (Asc(e.KeyChar) = 45) Or (Asc(e.KeyChar) = 39)) Then
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
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (hrPanel.Size <> hrPanel.MaximumSize) Then
            hrPanel.Height += 10
            If (hrPanel.Size = hrPanel.MaximumSize) Then
                Timer1.Stop()
            End If
        End If
    End Sub

    'Timer for the drop down system information panel
    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
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
        comboIndex = ComboBox2.SelectedValue

        'Calling the function to retrieve all informations of the employee
        updateEmployee = db_connection.EmployeeInformation(comboIndex)

        'Holding the employee number
        employeeNumber = updateEmployee.Employee_number

        'Filling all the textfields with employee informations
        firstnameTextfield.Text = updateEmployee.Firstname
        lastnameTextfield.Text = updateEmployee.Lastname
        dobTextfield.Value = updateEmployee.Dob

        'For the age textfield
        Dim age As String
        age = Now.Year - dobTextfield.Value.ToString("yyyy")
        ageTextfield.Text = age

        'Filling the rest of the textfields
        phoneTextfield.Text = updateEmployee.Cell_phone
        homephoneTextfield.Text = updateEmployee.Home_phone
        addressTexfield.Text = updateEmployee.Address
        provinceTextfield.SelectedItem = updateEmployee.Province
        cityTextfield.Text = updateEmployee.City
        postalTextfield.Text = updateEmployee.Postal_code
        nasTextfield.Text = updateEmployee.Nas
        salaryTextfield.Text = updateEmployee.Salary
        schoolTextfield.Text = updateEmployee.Education
        startTextfield.Value = updateEmployee.Start_date
        usernameTextfield.Text = updateEmployee.Username
        passTextfield.Text = updateEmployee.Password
        accessTextfield.Text = updateEmployee.Level

        If (updateEmployee.Status = 1) Then
            activeCheckbox.Checked = True
            inactiveCheckbox.Checked = False
        Else
            inactiveCheckbox.Checked = True
            activeCheckbox.Checked = False
        End If

        'Starting the timer
        Timer3.Start()
    End Sub

    'Continue 1 Button
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles continue1Btn.Click
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
        Else
            Dim age As String
            age = Now.Year - dobTextfield.Value.ToString("yyyy")

            editFirstname = firstnameTextfield.Text
            editLastname = lastnameTextfield.Text
            editDob = dobTextfield.Value.ToString("yyyy-MM-dd")
            editPhone = phoneTextfield.Text
            editHomePhone = homephoneTextfield.Text
            editAddress = addressTexfield.Text
            editProvince = provinceTextfield.SelectedItem
            editCity = cityTextfield.Text
            editPostal = postalTextfield.Text

            'Setting the age in the textbox
            ageTextfield.Text = age

            Timer1.Start()
        End If
    End Sub

    'Continue 2 Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles continue2Btn.Click
        If (nasTextfield.Text = "" Or salaryTextfield.Text = "" Or startTextfield.Text = "" Or
            schoolTextfield.Text = "") Then
            MsgBox("Please fill all the fields", MsgBoxStyle.Critical, "Empty fields")
        ElseIf (nasTextfield.Text.Length < 11) Then
            MsgBox("Social Insurance Number must be in this format ### ### ###", MsgBoxStyle.Critical, "Error")
        Else
            editNas = nasTextfield.Text
            editSalary = salaryTextfield.Text
            editSchool = schoolTextfield.Text
            editStartDate = startTextfield.Value.ToString("yyyy-MM-dd")

            Timer2.Start()
        End If
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        'Holding the combo box to use it as id
        comboIndex = ComboBox2.SelectedValue

        If (usernameTextfield.Text = "" Or passTextfield.Text = "" Or accessTextfield.Text = "") Then
            MsgBox("Please fill all the missing fields", MsgBoxStyle.Critical, "Empty fields")
        ElseIf (usernameTextfield.Text.Length < 3) Then
            MsgBox("Username must be at least 3 characters", MsgBoxStyle.Critical, "Error")
        ElseIf (passTextfield.Text.Length < 5) Then
            MsgBox("Password must be at least 5 characters", MsgBoxStyle.Critical, "Error")
        ElseIf (accessTextfield.Text < "1" Or accessTextfield.Text > "3") Then
            MsgBox("Access Level must be between 1 and 3", MsgBoxStyle.Critical, "Error")
        ElseIf (activeCheckbox.Checked And inactiveCheckbox.Checked) Then
            MsgBox("Please select only one of the checkbox options for the status", MsgBoxStyle.Critical, "Error")
        Else
            'Getting the check box value
            If (activeCheckbox.Checked) Then
                editStatus = 1
            Else
                editStatus = 0
            End If

            editUsername = usernameTextfield.Text
            editPassword = passTextfield.Text
            editLevel = accessTextfield.Text

            'Passing all the values to my new employee
            updateEmployee = New Employee()

            updateEmployee.Firstname = editFirstname
            updateEmployee.Lastname = editLastname
            updateEmployee.Dob = editDob
            updateEmployee.Cell_phone = editPhone
            updateEmployee.Home_phone = editHomePhone
            updateEmployee.Address = editAddress
            updateEmployee.Province = editProvince
            updateEmployee.City = editCity
            updateEmployee.Postal_code = editPostal
            updateEmployee.Nas = editNas
            updateEmployee.Salary = editSalary
            updateEmployee.Education = editSchool
            updateEmployee.Start_date = editStartDate
            updateEmployee.Username = editUsername
            updateEmployee.Password = editPassword
            updateEmployee.Level = editLevel
            updateEmployee.Status = editStatus

            'Confirmation Message
            Dim confirm = MsgBox("Confirm informations?" & vbCrLf &
                                 "Full name: " & updateEmployee.Firstname & " " & updateEmployee.Lastname & vbCrLf &
                                 "Birthdate: " & updateEmployee.Dob & vbCrLf &
                                 "Cell phone: " & updateEmployee.Cell_phone & " Home phone: " & updateEmployee.Home_phone & vbCrLf &
                                 "Address: " & updateEmployee.Address & ", " & updateEmployee.City & ", " & updateEmployee.Province & " " & updateEmployee.Postal_code & vbCrLf &
                                 "Nas: " & updateEmployee.Nas & vbCrLf &
                                 "Salary: " & updateEmployee.Salary & "/Hour" & vbCrLf &
                                 "School: " & updateEmployee.Education & vbCrLf &
                                 "Start Date: " & updateEmployee.Start_date & vbCrLf &
                                 "Username: " & updateEmployee.Username & " Password: " & updateEmployee.Password & vbCrLf &
                                 "Level: " & updateEmployee.Level & " Status: " & updateEmployee.Status,
                                  MsgBoxStyle.YesNo, "Confirm informations")

            If (confirm = 6) Then
                'Calling the edit employee function
                db_connection.EditAnEmployee(updateEmployee, comboIndex)

                MsgBox("Employee (#" & employeeNumber & ") information has been updated", MsgBoxStyle.Information, "Employee Updated")

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