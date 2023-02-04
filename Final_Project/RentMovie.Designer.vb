<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentMovie
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.phoneTextfield = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.addressTextfield = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fullnameTextfield = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.selectClientButton = New System.Windows.Forms.Button()
        Me.clientNumTextfield = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.moviePanel = New System.Windows.Forms.Panel()
        Me.pictureTextfield = New System.Windows.Forms.TextBox()
        Me.resumeTextfield = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.languageTextfield = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.directorTextfield = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.yearTextfield = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.titleTextfield = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.startMovieButton = New System.Windows.Forms.Button()
        Me.videoNumTextfield = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.changePassMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.logoutMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.employeeListMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.createEmployeeMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.editEmployeeMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.deleteEmployeeMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.videoListMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.videoEditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.videoDeleteMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clientListMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.clientCreateMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.clientEditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.clientDeleteMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.quickSearchMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.advanceSearchMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rentVideoMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.returnVideoMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.moviePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1238, 95)
        Me.Panel1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label1.Location = New System.Drawing.Point(502, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 50)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Rent a Movie"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.phoneTextfield)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.addressTextfield)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.fullnameTextfield)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.selectClientButton)
        Me.Panel2.Controls.Add(Me.clientNumTextfield)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(12, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1238, 275)
        Me.Panel2.TabIndex = 16
        '
        'phoneTextfield
        '
        Me.phoneTextfield.Enabled = False
        Me.phoneTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.phoneTextfield.Location = New System.Drawing.Point(779, 125)
        Me.phoneTextfield.Name = "phoneTextfield"
        Me.phoneTextfield.Size = New System.Drawing.Size(352, 35)
        Me.phoneTextfield.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(593, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 28)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Telephone number:"
        '
        'addressTextfield
        '
        Me.addressTextfield.Enabled = False
        Me.addressTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.addressTextfield.Location = New System.Drawing.Point(182, 194)
        Me.addressTextfield.Name = "addressTextfield"
        Me.addressTextfield.Size = New System.Drawing.Size(949, 35)
        Me.addressTextfield.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(90, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 28)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Address:"
        '
        'fullnameTextfield
        '
        Me.fullnameTextfield.Enabled = False
        Me.fullnameTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.fullnameTextfield.Location = New System.Drawing.Point(182, 125)
        Me.fullnameTextfield.Name = "fullnameTextfield"
        Me.fullnameTextfield.Size = New System.Drawing.Size(352, 35)
        Me.fullnameTextfield.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(76, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 28)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Full name:"
        '
        'selectClientButton
        '
        Me.selectClientButton.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.selectClientButton.Location = New System.Drawing.Point(779, 48)
        Me.selectClientButton.Name = "selectClientButton"
        Me.selectClientButton.Size = New System.Drawing.Size(105, 35)
        Me.selectClientButton.TabIndex = 14
        Me.selectClientButton.Text = "Select"
        Me.selectClientButton.UseVisualStyleBackColor = True
        '
        'clientNumTextfield
        '
        Me.clientNumTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.clientNumTextfield.Location = New System.Drawing.Point(477, 48)
        Me.clientNumTextfield.Name = "clientNumTextfield"
        Me.clientNumTextfield.Size = New System.Drawing.Size(296, 35)
        Me.clientNumTextfield.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(332, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Client number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label4.Location = New System.Drawing.Point(3, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 38)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Client Information"
        '
        'moviePanel
        '
        Me.moviePanel.BackColor = System.Drawing.Color.Transparent
        Me.moviePanel.Controls.Add(Me.pictureTextfield)
        Me.moviePanel.Controls.Add(Me.resumeTextfield)
        Me.moviePanel.Controls.Add(Me.Label13)
        Me.moviePanel.Controls.Add(Me.languageTextfield)
        Me.moviePanel.Controls.Add(Me.Label12)
        Me.moviePanel.Controls.Add(Me.directorTextfield)
        Me.moviePanel.Controls.Add(Me.Label11)
        Me.moviePanel.Controls.Add(Me.yearTextfield)
        Me.moviePanel.Controls.Add(Me.Label10)
        Me.moviePanel.Controls.Add(Me.titleTextfield)
        Me.moviePanel.Controls.Add(Me.Label9)
        Me.moviePanel.Controls.Add(Me.PictureBox1)
        Me.moviePanel.Controls.Add(Me.startMovieButton)
        Me.moviePanel.Controls.Add(Me.videoNumTextfield)
        Me.moviePanel.Controls.Add(Me.Label8)
        Me.moviePanel.Controls.Add(Me.Label7)
        Me.moviePanel.Location = New System.Drawing.Point(12, 413)
        Me.moviePanel.MaximumSize = New System.Drawing.Size(1238, 362)
        Me.moviePanel.MinimumSize = New System.Drawing.Size(1238, 56)
        Me.moviePanel.Name = "moviePanel"
        Me.moviePanel.Size = New System.Drawing.Size(1238, 362)
        Me.moviePanel.TabIndex = 17
        '
        'pictureTextfield
        '
        Me.pictureTextfield.Location = New System.Drawing.Point(996, 58)
        Me.pictureTextfield.Name = "pictureTextfield"
        Me.pictureTextfield.Size = New System.Drawing.Size(125, 27)
        Me.pictureTextfield.TabIndex = 27
        Me.pictureTextfield.Visible = False
        '
        'resumeTextfield
        '
        Me.resumeTextfield.Enabled = False
        Me.resumeTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.resumeTextfield.Location = New System.Drawing.Point(119, 255)
        Me.resumeTextfield.Name = "resumeTextfield"
        Me.resumeTextfield.Size = New System.Drawing.Size(710, 90)
        Me.resumeTextfield.TabIndex = 26
        Me.resumeTextfield.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(26, 255)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 28)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Resume:"
        '
        'languageTextfield
        '
        Me.languageTextfield.Enabled = False
        Me.languageTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.languageTextfield.Location = New System.Drawing.Point(593, 187)
        Me.languageTextfield.Name = "languageTextfield"
        Me.languageTextfield.Size = New System.Drawing.Size(236, 35)
        Me.languageTextfield.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(486, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 28)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Language:"
        '
        'directorTextfield
        '
        Me.directorTextfield.Enabled = False
        Me.directorTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.directorTextfield.Location = New System.Drawing.Point(119, 187)
        Me.directorTextfield.Name = "directorTextfield"
        Me.directorTextfield.Size = New System.Drawing.Size(352, 35)
        Me.directorTextfield.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(26, 190)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 28)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Director:"
        '
        'yearTextfield
        '
        Me.yearTextfield.Enabled = False
        Me.yearTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.yearTextfield.Location = New System.Drawing.Point(593, 122)
        Me.yearTextfield.Name = "yearTextfield"
        Me.yearTextfield.Size = New System.Drawing.Size(107, 35)
        Me.yearTextfield.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(533, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 28)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Year:"
        '
        'titleTextfield
        '
        Me.titleTextfield.Enabled = False
        Me.titleTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.titleTextfield.Location = New System.Drawing.Point(119, 122)
        Me.titleTextfield.Name = "titleTextfield"
        Me.titleTextfield.Size = New System.Drawing.Size(352, 35)
        Me.titleTextfield.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(60, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 28)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Title:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PaleGreen
        Me.PictureBox1.Location = New System.Drawing.Point(898, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(319, 250)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'startMovieButton
        '
        Me.startMovieButton.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.startMovieButton.Location = New System.Drawing.Point(779, 58)
        Me.startMovieButton.Name = "startMovieButton"
        Me.startMovieButton.Size = New System.Drawing.Size(105, 35)
        Me.startMovieButton.TabIndex = 15
        Me.startMovieButton.Text = "Select"
        Me.startMovieButton.UseVisualStyleBackColor = True
        '
        'videoNumTextfield
        '
        Me.videoNumTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.videoNumTextfield.Location = New System.Drawing.Point(477, 58)
        Me.videoNumTextfield.Name = "videoNumTextfield"
        Me.videoNumTextfield.Size = New System.Drawing.Size(296, 35)
        Me.videoNumTextfield.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(382, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 28)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Video Id:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label7.Location = New System.Drawing.Point(3, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(266, 38)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Movie Information"
        '
        'cancelBtn
        '
        Me.cancelBtn.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cancelBtn.Location = New System.Drawing.Point(1090, 781)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(160, 60)
        Me.cancelBtn.TabIndex = 18
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.saveBtn.Location = New System.Drawing.Point(910, 781)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(160, 60)
        Me.saveBtn.TabIndex = 19
        Me.saveBtn.Text = "Rent"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.VideoToolStripMenuItem, Me.ClientToolStripMenuItem, Me.SearchToolStripMenuItem, Me.RentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1262, 28)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.changePassMenu, Me.logoutMenu, Me.exitMenu})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'changePassMenu
        '
        Me.changePassMenu.Name = "changePassMenu"
        Me.changePassMenu.Size = New System.Drawing.Size(208, 26)
        Me.changePassMenu.Text = "Change Password"
        '
        'logoutMenu
        '
        Me.logoutMenu.Name = "logoutMenu"
        Me.logoutMenu.Size = New System.Drawing.Size(208, 26)
        Me.logoutMenu.Text = "Logout"
        '
        'exitMenu
        '
        Me.exitMenu.Name = "exitMenu"
        Me.exitMenu.Size = New System.Drawing.Size(208, 26)
        Me.exitMenu.Text = "Exit"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.employeeListMenu, Me.createEmployeeMenu, Me.editEmployeeMenu, Me.deleteEmployeeMenu})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'employeeListMenu
        '
        Me.employeeListMenu.Name = "employeeListMenu"
        Me.employeeListMenu.Size = New System.Drawing.Size(136, 26)
        Me.employeeListMenu.Text = "List"
        '
        'createEmployeeMenu
        '
        Me.createEmployeeMenu.Name = "createEmployeeMenu"
        Me.createEmployeeMenu.Size = New System.Drawing.Size(136, 26)
        Me.createEmployeeMenu.Text = "Create"
        '
        'editEmployeeMenu
        '
        Me.editEmployeeMenu.Name = "editEmployeeMenu"
        Me.editEmployeeMenu.Size = New System.Drawing.Size(136, 26)
        Me.editEmployeeMenu.Text = "Edit"
        '
        'deleteEmployeeMenu
        '
        Me.deleteEmployeeMenu.Name = "deleteEmployeeMenu"
        Me.deleteEmployeeMenu.Size = New System.Drawing.Size(136, 26)
        Me.deleteEmployeeMenu.Text = "Delete"
        '
        'VideoToolStripMenuItem
        '
        Me.VideoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.videoListMenu, Me.CreateToolStripMenuItem1, Me.videoEditMenu, Me.videoDeleteMenu})
        Me.VideoToolStripMenuItem.Name = "VideoToolStripMenuItem"
        Me.VideoToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.VideoToolStripMenuItem.Text = "Video"
        '
        'videoListMenu
        '
        Me.videoListMenu.Name = "videoListMenu"
        Me.videoListMenu.Size = New System.Drawing.Size(136, 26)
        Me.videoListMenu.Text = "List"
        '
        'CreateToolStripMenuItem1
        '
        Me.CreateToolStripMenuItem1.Name = "CreateToolStripMenuItem1"
        Me.CreateToolStripMenuItem1.Size = New System.Drawing.Size(136, 26)
        Me.CreateToolStripMenuItem1.Text = "Create"
        '
        'videoEditMenu
        '
        Me.videoEditMenu.Name = "videoEditMenu"
        Me.videoEditMenu.Size = New System.Drawing.Size(136, 26)
        Me.videoEditMenu.Text = "Edit"
        '
        'videoDeleteMenu
        '
        Me.videoDeleteMenu.Name = "videoDeleteMenu"
        Me.videoDeleteMenu.Size = New System.Drawing.Size(136, 26)
        Me.videoDeleteMenu.Text = "Delete"
        '
        'ClientToolStripMenuItem
        '
        Me.ClientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.clientListMenu, Me.clientCreateMenu, Me.clientEditMenu, Me.clientDeleteMenu})
        Me.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        Me.ClientToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.ClientToolStripMenuItem.Text = "Client"
        '
        'clientListMenu
        '
        Me.clientListMenu.Name = "clientListMenu"
        Me.clientListMenu.Size = New System.Drawing.Size(136, 26)
        Me.clientListMenu.Text = "List"
        '
        'clientCreateMenu
        '
        Me.clientCreateMenu.Name = "clientCreateMenu"
        Me.clientCreateMenu.Size = New System.Drawing.Size(136, 26)
        Me.clientCreateMenu.Text = "Create"
        '
        'clientEditMenu
        '
        Me.clientEditMenu.Name = "clientEditMenu"
        Me.clientEditMenu.Size = New System.Drawing.Size(136, 26)
        Me.clientEditMenu.Text = "Edit"
        '
        'clientDeleteMenu
        '
        Me.clientDeleteMenu.Name = "clientDeleteMenu"
        Me.clientDeleteMenu.Size = New System.Drawing.Size(136, 26)
        Me.clientDeleteMenu.Text = "Delete"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.quickSearchMenu, Me.advanceSearchMenu})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'quickSearchMenu
        '
        Me.quickSearchMenu.Name = "quickSearchMenu"
        Me.quickSearchMenu.Size = New System.Drawing.Size(197, 26)
        Me.quickSearchMenu.Text = "Quick Search"
        '
        'advanceSearchMenu
        '
        Me.advanceSearchMenu.Name = "advanceSearchMenu"
        Me.advanceSearchMenu.Size = New System.Drawing.Size(197, 26)
        Me.advanceSearchMenu.Text = "Advance Search"
        '
        'RentToolStripMenuItem
        '
        Me.RentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rentVideoMenu, Me.returnVideoMenu})
        Me.RentToolStripMenuItem.Name = "RentToolStripMenuItem"
        Me.RentToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.RentToolStripMenuItem.Text = "Rent"
        '
        'rentVideoMenu
        '
        Me.rentVideoMenu.Name = "rentVideoMenu"
        Me.rentVideoMenu.Size = New System.Drawing.Size(178, 26)
        Me.rentVideoMenu.Text = "Rent Video"
        '
        'returnVideoMenu
        '
        Me.returnVideoMenu.Name = "returnVideoMenu"
        Me.returnVideoMenu.Size = New System.Drawing.Size(178, 26)
        Me.returnVideoMenu.Text = "Return Video"
        '
        'RentMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final_Project.My.Resources.Resources.wp4615534___Copy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 853)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.moviePanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RentMovie"
        Me.Text = "RentMovie"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.moviePanel.ResumeLayout(False)
        Me.moviePanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents selectClientButton As Button
    Friend WithEvents clientNumTextfield As TextBox
    Friend WithEvents phoneTextfield As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents addressTextfield As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents fullnameTextfield As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents moviePanel As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents cancelBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents yearTextfield As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents titleTextfield As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents startMovieButton As Button
    Friend WithEvents videoNumTextfield As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents languageTextfield As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents directorTextfield As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents resumeTextfield As RichTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pictureTextfield As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents changePassMenu As ToolStripMenuItem
    Friend WithEvents logoutMenu As ToolStripMenuItem
    Friend WithEvents exitMenu As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents employeeListMenu As ToolStripMenuItem
    Friend WithEvents createEmployeeMenu As ToolStripMenuItem
    Friend WithEvents editEmployeeMenu As ToolStripMenuItem
    Friend WithEvents deleteEmployeeMenu As ToolStripMenuItem
    Friend WithEvents VideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents videoListMenu As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents videoEditMenu As ToolStripMenuItem
    Friend WithEvents videoDeleteMenu As ToolStripMenuItem
    Friend WithEvents ClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents clientListMenu As ToolStripMenuItem
    Friend WithEvents clientCreateMenu As ToolStripMenuItem
    Friend WithEvents clientEditMenu As ToolStripMenuItem
    Friend WithEvents clientDeleteMenu As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents quickSearchMenu As ToolStripMenuItem
    Friend WithEvents advanceSearchMenu As ToolStripMenuItem
    Friend WithEvents RentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rentVideoMenu As ToolStripMenuItem
    Friend WithEvents returnVideoMenu As ToolStripMenuItem
End Class
