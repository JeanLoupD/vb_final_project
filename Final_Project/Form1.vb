Public Class Form1
    'Getting my classes
    Dim db_connection As DB_Manager = New DB_Manager()
    Public logUser As Employee

    'When window load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clearing the two textfields when window load
        usernameTextfield.Text = ""
        passTextfield.Text = ""
    End Sub

    'Don't allow space in username textbox
    Private Sub usernameTextfield_KeyDown(sender As Object, e As KeyEventArgs) Handles usernameTextfield.KeyDown
        If (e.KeyCode = Keys.Space) Then
            e.SuppressKeyPress = True
        End If
    End Sub

    'Don't allow space in password textbox
    Private Sub passTextfield_KeyDown(sender As Object, e As KeyEventArgs) Handles passTextfield.KeyDown
        If (e.KeyCode = Keys.Space) Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim username As String = usernameTextfield.Text
        Dim password As String = passTextfield.Text

        logUser = db_connection.LoginUser(username, password)

        If (username = "" Or password = "") Then
            MsgBox("Please enter your username or password",
                    MsgBoxStyle.Critical, "Login Error")
        Else
            If (logUser IsNot Nothing) Then
                If (logUser.Status = 0) Then
                    MsgBox("This account doesn't exist anymore, please register to login",
                           MsgBoxStyle.Critical, "Deleted Account")
                Else
                    If (password = "hello_world") Then
                        MsgBox("Welcome " & logUser.Firstname & " " & logUser.Lastname & "!" &
                               vbCrLf & "Update your password to complete your account",
                            MsgBoxStyle.Information, "Welcome")

                        'Bringing the user to the update password page
                        UpdatePassword.Show()
                        Me.Hide()
                    ElseIf (logUser.Level = 3) Then
                        MsgBox("Welcome " & logUser.Firstname & " " & logUser.Lastname & "!" &
                               vbCrLf & "Employee level 3",
                            MsgBoxStyle.Information, "Welcome")

                        'Bringing the user to the admin page
                        AdminMain.Show()
                        Me.Hide()
                    ElseIf (logUser.Level = 2) Then
                        MsgBox("Welcome " & logUser.Firstname & " " & logUser.Lastname & "!" &
                              vbCrLf & "Employee level 2",
                           MsgBoxStyle.Information, "Welcome")

                        'Bringing the user to the employee page
                        AdminMain.Show()
                        Me.Hide()
                    ElseIf (logUser.Level = 1) Then
                        MsgBox("Welcome " & logUser.Firstname & " " & logUser.Lastname & "!" &
                            vbCrLf & "Employee level 1",
                         MsgBoxStyle.Information, "Welcome")

                        'Bringing the user to the employee page
                        AdminMain.Show()
                        Me.Hide()
                    End If
                End If
            Else
                MsgBox("Username and password don't match, please try again",
                       MsgBoxStyle.Critical, "Login Error")
            End If
        End If
    End Sub

End Class
