
Public Class UpdatePassword
    Dim db_connection As DB_Manager = New DB_Manager()
    Dim updateUser As Employee

    'When window load
    Private Sub UpdatePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passTextfield.Text = ""
        newPassTextfield.Text = ""
        confirmPassTextfield.Text = ""
    End Sub

    'Don't allow space in textbox
    Private Sub passTextfield_KeyDown(sender As Object, e As KeyEventArgs) Handles passTextfield.KeyDown
        If (e.KeyCode = Keys.Space) Then
            e.SuppressKeyPress = True
        End If
    End Sub

    'Don't allow space in textbox
    Private Sub newPassTextfield_KeyDown(sender As Object, e As KeyEventArgs) Handles newPassTextfield.KeyDown
        If (e.KeyCode = Keys.Space) Then
            e.SuppressKeyPress = True
        End If
    End Sub

    'Don't allow space in textbox
    Private Sub confirmPassTextfield_KeyDown(sender As Object, e As KeyEventArgs) Handles confirmPassTextfield.KeyDown
        If (e.KeyCode = Keys.Space) Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub confirmBtn_Click(sender As Object, e As EventArgs) Handles confirmBtn.Click
        Dim userId = Form1.logUser.Id
        Dim currentPassword = passTextfield.Text
        Dim newPassword As String = newPassTextfield.Text
        Dim confirmNewPassword As String = confirmPassTextfield.Text

        If (currentPassword <> Form1.logUser.Password) Then
            MsgBox("Current password textfield don't match the default password, please try again",
                    MsgBoxStyle.Critical, "Invalid Password")
        ElseIf (newPassword = "" Or confirmNewPassword = "") Then
            MsgBox("Please enter or confirm your new password", MsgBoxStyle.Critical, "Empty fields")
        ElseIf (newPassword.Length < 5 Or confirmNewPassword.Length < 5) Then
            MsgBox("New password must be at least 5 characters, please try again",
                    MsgBoxStyle.Critical, "Invalid Password")
        ElseIf (newPassword <> confirmNewPassword) Then
            MsgBox("Password don't match, please try again",
                    MsgBoxStyle.Critical, "Invalid Password")
        Else
            db_connection.UpdatePassword(userId, newPassword)

            If (Form1.logUser.Level = 3) Then
                MsgBox("Your password has been successfully updated", MsgBoxStyle.Information, "Password Updated")

                'Clearing the two textfields in the login page
                Form1.usernameTextfield.Text = ""
                Form1.passTextfield.Text = ""

                'Bringing the user to the admin page
                Form1.Show()
                Me.Hide()
            Else
                MsgBox("Your password has been successfully updated", MsgBoxStyle.Information, "Password Updated")

                'Clearing the two textfields in the login page
                Form1.usernameTextfield.Text = ""
                Form1.passTextfield.Text = ""

                'Bringing the user to the admin page
                Form1.Show()
                Me.Hide()
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