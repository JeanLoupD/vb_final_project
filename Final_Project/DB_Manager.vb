Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Misc
Imports Org.BouncyCastle.Crypto.Engines

Public Class DB_Manager
    Private connect As New MySqlConnection
    Private connectionString = "server=localhost;user id=root;password=;database=vb_final;"

    '====================================== LOGIN SECTION ====================================
    Public Function LoginUser(ByVal user_name As String, ByVal pass_word As String)
        Dim logUser As Employee

        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT * FROM users WHERE username = @username AND password = @password"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("username", user_name)
            cmd.Parameters.AddWithValue("password", pass_word)

            Dim dataReader As MySqlDataReader
            dataReader = cmd.ExecuteReader()

            While dataReader.Read
                logUser = New Employee()
                logUser.Id = dataReader.GetInt32("user_id")
                logUser.Employee_number = dataReader.GetString("employee_number")
                logUser.Username = dataReader.GetString("username")
                logUser.Password = dataReader.GetString("password")
                logUser.Firstname = dataReader.GetString("fname")
                logUser.Lastname = dataReader.GetString("lname")
                logUser.Dob = dataReader.GetDateTime("dob")
                logUser.Address = dataReader.GetString("address")
                logUser.City = dataReader.GetString("city")
                logUser.Province = dataReader.GetString("province")
                logUser.Postal_code = dataReader.GetString("postal_code")
                logUser.Cell_phone = dataReader.GetString("cell_phone")
                logUser.Home_phone = dataReader.GetString("home_phone")
                logUser.Start_date = dataReader.GetDateTime("start_date")
                logUser.Nas = dataReader.GetString("sin")
                logUser.Salary = dataReader.GetDouble("hourly_pay")
                logUser.Education = dataReader.GetString("education")
                logUser.Level = dataReader.GetInt16("level")
                logUser.Status = dataReader.GetInt16("status")
            End While

            'Closing the reader to get accurate values
            dataReader.Close()
            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return logUser
    End Function

    '======================================= END LOGIN SECTION ======================================

    '===================================== UPDATE PASSWORD SECTION ==================================
    Public Function UpdatePassword(ByVal id As Integer, ByVal pass_word As String)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "UPDATE users SET password=@password WHERE user_id = @id"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@password", pass_word)

            cmd.ExecuteNonQuery()

            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return Nothing
    End Function

    '=================================== END UPDATE PASSWORD SECTION ================================

    '================================== LIST OF ALL EMPLOYEES SECTION ===============================
    Public Sub ShowAllEmployees(ByVal users As Employee)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT * FROM users ORDER BY user_id DESC"

            'Creating the data table
            Dim dataUser As New DataTable()

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            'Fill the table
            adapter.Fill(dataUser)

            With ListEmployee.allUsersList
                .DataSource = dataUser

                'Renaming the columns
                .Columns(0).HeaderText = "Id"
                .Columns(1).HeaderText = "Employee Number"
                .Columns(2).HeaderText = "Username"
                .Columns(3).HeaderText = "Password"
                .Columns(4).HeaderText = "First name"
                .Columns(5).HeaderText = "Last name"
                .Columns(6).HeaderText = "Date of birth"
                .Columns(7).HeaderText = "Address"
                .Columns(8).HeaderText = "City"
                .Columns(9).HeaderText = "Province"
                .Columns(10).HeaderText = "Postal code"
                .Columns(11).HeaderText = "Cell phone"
                .Columns(12).HeaderText = "Home phone"
                .Columns(13).HeaderText = "Start date"
                .Columns(14).HeaderText = "Nas"
                .Columns(15).HeaderText = "Hourly pay"
                .Columns(16).HeaderText = "Education"
                .Columns(17).HeaderText = "Level"
                .Columns(18).HeaderText = "Status"

                'Resizing the columns
                .Columns(0).Width = 30
                .Columns(10).Width = 80
                .Columns(15).Width = 55
                .Columns(16).Width = 70
                .Columns(17).Width = 50
                .Columns(18).Width = 50
            End With

            With DeleteEmployee.allUsersList
                .DataSource = dataUser

                'Renaming the columns
                .Columns(0).HeaderText = "Id"
                .Columns(1).HeaderText = "Employee Number"
                .Columns(2).HeaderText = "Username"
                .Columns(3).HeaderText = "Password"
                .Columns(4).HeaderText = "First name"
                .Columns(5).HeaderText = "Last name"
                .Columns(6).HeaderText = "Date of birth"
                .Columns(7).HeaderText = "Address"
                .Columns(8).HeaderText = "City"
                .Columns(9).HeaderText = "Province"
                .Columns(10).HeaderText = "Postal code"
                .Columns(11).HeaderText = "Cell phone"
                .Columns(12).HeaderText = "Home phone"
                .Columns(13).HeaderText = "Start date"
                .Columns(14).HeaderText = "Nas"
                .Columns(15).HeaderText = "Hourly pay"
                .Columns(16).HeaderText = "Education"
                .Columns(17).HeaderText = "Level"
                .Columns(18).HeaderText = "Status"

                'Resizing the columns
                .Columns(0).Width = 30
                .Columns(10).Width = 80
                .Columns(15).Width = 55
                .Columns(16).Width = 70
                .Columns(17).Width = 50
                .Columns(18).Width = 50
            End With

            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    '================================= END LIST ALL EMPLOYEES SECTION ===============================

    '=================================== CREATE NEW EMPLOYEE SECTION ================================
    Public Function CreateEmployee(ByVal new_employee As Employee)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "INSERT INTO users 
                                        (employee_number, username, password, fname, lname, dob, address, city, 
                                        province, postal_code, cell_phone, home_phone, start_date, sin, hourly_pay, 
                                        education, level, status) 
                                            VALUES 
                                        (@employee_number, @username, @password, @fname, @lname, @dob, @address, 
                                         @city, @province, @postal_code, @cell_phone, @home_phone, @start_date, 
                                         @sin, @hourly_pay, @education, @level, @status)"
            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@employee_number", new_employee.Employee_number)
            cmd.Parameters.AddWithValue("@username", new_employee.Username)
            cmd.Parameters.AddWithValue("@password", new_employee.Password)
            cmd.Parameters.AddWithValue("@fname", new_employee.Firstname)
            cmd.Parameters.AddWithValue("@lname", new_employee.Lastname)
            cmd.Parameters.AddWithValue("@dob", new_employee.Dob)
            cmd.Parameters.AddWithValue("@address", new_employee.Address)
            cmd.Parameters.AddWithValue("@city", new_employee.City)
            cmd.Parameters.AddWithValue("@province", new_employee.Province)
            cmd.Parameters.AddWithValue("@postal_code", new_employee.Postal_code)
            cmd.Parameters.AddWithValue("@cell_phone", new_employee.Cell_phone)
            cmd.Parameters.AddWithValue("@home_phone", new_employee.Home_phone)
            cmd.Parameters.AddWithValue("@start_date", new_employee.Start_date)
            cmd.Parameters.AddWithValue("@sin", new_employee.Nas)
            cmd.Parameters.AddWithValue("@hourly_pay", new_employee.Salary)
            cmd.Parameters.AddWithValue("@education", new_employee.Education)
            cmd.Parameters.AddWithValue("@level", new_employee.Level)
            cmd.Parameters.AddWithValue("@status", new_employee.Status)

            cmd.ExecuteNonQuery()

            'Closing the connection
            Me.connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return result
        Return Nothing
    End Function
    '================================= END CREATE NEW EMPLOYEE SECTION ==============================

    '====================================== EDIT EMPLOYEE SECTION ===================================
    Public Sub ShowAllEmployeeEdit()

        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT * FROM users"

            'Creating the datatable
            Dim dataTable As New DataTable()

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Creating the adapter
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataTable)

            'Creating a temporary column to display information in the combox box
            dataTable.Columns.Add("fullname", Type.GetType("System.String"), "employee_number + ': ' + fname + ' ' + lname")

            With EditEmployee.ComboBox2
                EditEmployee.ComboBox2.DataSource = dataTable
                EditEmployee.ComboBox2.DisplayMember = "fullname"
                EditEmployee.ComboBox2.ValueMember = "user_id"
            End With

            With DeleteEmployee.ComboBox2
                DeleteEmployee.ComboBox2.DataSource = dataTable
                DeleteEmployee.ComboBox2.DisplayMember = "fullname"
                DeleteEmployee.ComboBox2.ValueMember = "user_id"
            End With

            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    Public Function EmployeeInformation(ByVal id As Integer)
        Dim editUser As Employee

        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT * FROM users WHERE user_id = @id"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@id", id)

            Dim dataReader As MySqlDataReader
            dataReader = cmd.ExecuteReader()

            While dataReader.Read
                editUser = New Employee()
                editUser.Id = dataReader.GetInt32("user_id")
                editUser.Employee_number = dataReader.GetString("employee_number")
                editUser.Username = dataReader.GetString("username")
                editUser.Password = dataReader.GetString("password")
                editUser.Firstname = dataReader.GetString("fname")
                editUser.Lastname = dataReader.GetString("lname")
                editUser.Dob = dataReader.GetDateTime("dob")
                editUser.Address = dataReader.GetString("address")
                editUser.City = dataReader.GetString("city")
                editUser.Province = dataReader.GetString("province")
                editUser.Postal_code = dataReader.GetString("postal_code")
                editUser.Cell_phone = dataReader.GetString("cell_phone")
                editUser.Home_phone = dataReader.GetString("home_phone")
                editUser.Start_date = dataReader.GetDateTime("start_date")
                editUser.Nas = dataReader.GetString("sin")
                editUser.Salary = dataReader.GetDouble("hourly_pay")
                editUser.Education = dataReader.GetString("education")
                editUser.Level = dataReader.GetInt16("level")
                editUser.Status = dataReader.GetInt16("status")
            End While

            'Closing the reader to get accurate values
            dataReader.Close()
            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return editUser
    End Function

    Public Function EditAnEmployee(ByVal edit_employee As Employee, ByVal id As Integer)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "UPDATE users SET
                                         username=@username, password=@password, fname=@fname, lname=@lname, 
                                         dob=@dob, address=@address, city=@city, province=@province, 
                                         postal_code=@postal_code, cell_phone=@cell_phone, home_phone=@home_phone,
                                         start_date=@start_date, sin=@sin, hourly_pay=@hourly_pay, 
                                         education=@education, level=@level, status=@status
                                   WHERE user_id=@id"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@username", edit_employee.Username)
            cmd.Parameters.AddWithValue("@password", edit_employee.Password)
            cmd.Parameters.AddWithValue("@fname", edit_employee.Firstname)
            cmd.Parameters.AddWithValue("@lname", edit_employee.Lastname)
            cmd.Parameters.AddWithValue("@dob", edit_employee.Dob)
            cmd.Parameters.AddWithValue("@address", edit_employee.Address)
            cmd.Parameters.AddWithValue("@city", edit_employee.City)
            cmd.Parameters.AddWithValue("@province", edit_employee.Province)
            cmd.Parameters.AddWithValue("@postal_code", edit_employee.Postal_code)
            cmd.Parameters.AddWithValue("@cell_phone", edit_employee.Cell_phone)
            cmd.Parameters.AddWithValue("@home_phone", edit_employee.Home_phone)
            cmd.Parameters.AddWithValue("@start_date", edit_employee.Start_date)
            cmd.Parameters.AddWithValue("@sin", edit_employee.Nas)
            cmd.Parameters.AddWithValue("@hourly_pay", edit_employee.Salary)
            cmd.Parameters.AddWithValue("@education", edit_employee.Education)
            cmd.Parameters.AddWithValue("@level", edit_employee.Level)
            cmd.Parameters.AddWithValue("@status", edit_employee.Status)

            cmd.ExecuteNonQuery()

            'Closing the connection
            Me.connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return result
        Return Nothing
    End Function
    '===================================== END EDIT EMPLOYEE SECTION ================================

    '====================================== DELETE EMPLOYEE SECTION =================================
    Public Function DeleteAnEmployee(ByVal id As Integer)
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "UPDATE users SET status = 0 WHERE user_id=@id"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Add variable value to database column
            cmd.Parameters.AddWithValue("@id", id)

            cmd.ExecuteNonQuery()

            'Closing the connection
            Me.connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return result
        Return Nothing
    End Function
    '==================================== END DELETE EMPLOYEE SECTION ===============================

    '==================================== DUPLICATE USERNAME SECTION ================================
    Public Function UsernameExist()
        Dim userDataSet As New DataSet
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT username FROM users"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Creating the adapter
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(userDataSet, "usersNames")
            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return userDataSet.Tables("usersNames").Rows
    End Function
    '================================== END DUPLICATE USERNAME SECTION ==============================

    '=================================== DUPLICATE EMAIL SECTION ================================
    Public Function NasExist()
        Dim userDataSet As New DataSet
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT sin FROM users"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Creating the adapter
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(userDataSet, "usersNas")
            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return userDataSet.Tables("usersNas").Rows
    End Function
    '================================== END DUPLICATE EMAIL SECTION ==============================

    '================================== CELL PHONE DUPLICATE SECTION =================================
    Public Function CellPhoneExist()
        Dim userDataSet As New DataSet
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT cell_phone FROM users"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Creating the adapter
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(userDataSet, "usersPhone")
            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return userDataSet.Tables("usersPhone").Rows
    End Function
    '=============================== END CELL PHONE DUPLICATE SECTION ===============================

    '================================= CELL PHONE DUPLICATE SECTION =================================
    Public Function HomePhoneExist()
        Dim userDataSet As New DataSet
        Try
            'Connecting to the database
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            'Initializing the query
            Dim query As String = "SELECT home_phone FROM users"

            'Execute the query
            Dim cmd As New MySqlCommand(query, Me.connect)

            'Creating the adapter
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(userDataSet, "usersHomePhone")
            'Closing the connection
            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return userDataSet.Tables("usersHomePhone").Rows
    End Function
    '=============================== END CELL PHONE DUPLICATE SECTION ===============================
End Class
