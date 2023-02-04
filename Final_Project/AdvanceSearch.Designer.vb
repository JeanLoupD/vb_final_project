<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvanceSearch
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.resumeTextfield = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lengthTextfield = New System.Windows.Forms.TextBox()
        Me.actorTextfield = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.yearTextfield = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.directorTextfield = New System.Windows.Forms.TextBox()
        Me.genreTextfield = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.languageTextfield = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.countryTextfield = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.titleTextfield = New System.Windows.Forms.TextBox()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.advanceSearchList = New System.Windows.Forms.DataGridView()
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
        Me.rentMovieBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.advanceSearchList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1238, 95)
        Me.Panel1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label1.Location = New System.Drawing.Point(478, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 50)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Advanced Search"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.resumeTextfield)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lengthTextfield)
        Me.Panel2.Controls.Add(Me.actorTextfield)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.yearTextfield)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.directorTextfield)
        Me.Panel2.Controls.Add(Me.genreTextfield)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.languageTextfield)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.countryTextfield)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.titleTextfield)
        Me.Panel2.Controls.Add(Me.searchBtn)
        Me.Panel2.Location = New System.Drawing.Point(12, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1238, 212)
        Me.Panel2.TabIndex = 15
        '
        'resumeTextfield
        '
        Me.resumeTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.resumeTextfield.Location = New System.Drawing.Point(495, 157)
        Me.resumeTextfield.Name = "resumeTextfield"
        Me.resumeTextfield.Size = New System.Drawing.Size(540, 35)
        Me.resumeTextfield.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(403, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 28)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Resume:"
        '
        'lengthTextfield
        '
        Me.lengthTextfield.Enabled = False
        Me.lengthTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lengthTextfield.Location = New System.Drawing.Point(275, 157)
        Me.lengthTextfield.MaxLength = 3
        Me.lengthTextfield.Name = "lengthTextfield"
        Me.lengthTextfield.Size = New System.Drawing.Size(83, 35)
        Me.lengthTextfield.TabIndex = 35
        '
        'actorTextfield
        '
        Me.actorTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.actorTextfield.Location = New System.Drawing.Point(929, 92)
        Me.actorTextfield.Name = "actorTextfield"
        Me.actorTextfield.Size = New System.Drawing.Size(285, 35)
        Me.actorTextfield.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(851, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 28)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Actors:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(403, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 28)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Director:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(822, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 28)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Language:"
        '
        'yearTextfield
        '
        Me.yearTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.yearTextfield.Location = New System.Drawing.Point(73, 157)
        Me.yearTextfield.MaxLength = 4
        Me.yearTextfield.Name = "yearTextfield"
        Me.yearTextfield.Size = New System.Drawing.Size(83, 35)
        Me.yearTextfield.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(13, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 28)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Year:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(193, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 28)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Length:"
        '
        'directorTextfield
        '
        Me.directorTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.directorTextfield.Location = New System.Drawing.Point(495, 92)
        Me.directorTextfield.Name = "directorTextfield"
        Me.directorTextfield.Size = New System.Drawing.Size(285, 35)
        Me.directorTextfield.TabIndex = 26
        '
        'genreTextfield
        '
        Me.genreTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.genreTextfield.Location = New System.Drawing.Point(73, 92)
        Me.genreTextfield.Name = "genreTextfield"
        Me.genreTextfield.Size = New System.Drawing.Size(285, 35)
        Me.genreTextfield.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(403, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 28)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Country:"
        '
        'languageTextfield
        '
        Me.languageTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.languageTextfield.Location = New System.Drawing.Point(929, 26)
        Me.languageTextfield.Name = "languageTextfield"
        Me.languageTextfield.Size = New System.Drawing.Size(285, 35)
        Me.languageTextfield.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 28)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Genre:"
        '
        'countryTextfield
        '
        Me.countryTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.countryTextfield.Location = New System.Drawing.Point(495, 26)
        Me.countryTextfield.Name = "countryTextfield"
        Me.countryTextfield.Size = New System.Drawing.Size(285, 35)
        Me.countryTextfield.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 28)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Title:"
        '
        'titleTextfield
        '
        Me.titleTextfield.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.titleTextfield.Location = New System.Drawing.Point(73, 26)
        Me.titleTextfield.Name = "titleTextfield"
        Me.titleTextfield.Size = New System.Drawing.Size(285, 35)
        Me.titleTextfield.TabIndex = 19
        '
        'searchBtn
        '
        Me.searchBtn.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.searchBtn.Location = New System.Drawing.Point(1054, 160)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(171, 49)
        Me.searchBtn.TabIndex = 17
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cancelBtn.Location = New System.Drawing.Point(1079, 778)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(171, 63)
        Me.cancelBtn.TabIndex = 16
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'advanceSearchList
        '
        Me.advanceSearchList.BackgroundColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.advanceSearchList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.advanceSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.advanceSearchList.DefaultCellStyle = DataGridViewCellStyle6
        Me.advanceSearchList.Location = New System.Drawing.Point(12, 350)
        Me.advanceSearchList.Name = "advanceSearchList"
        Me.advanceSearchList.RowHeadersWidth = 51
        Me.advanceSearchList.RowTemplate.Height = 29
        Me.advanceSearchList.Size = New System.Drawing.Size(1238, 419)
        Me.advanceSearchList.TabIndex = 17
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.VideoToolStripMenuItem, Me.ClientToolStripMenuItem, Me.SearchToolStripMenuItem, Me.RentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1262, 28)
        Me.MenuStrip1.TabIndex = 18
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
        'rentMovieBtn
        '
        Me.rentMovieBtn.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rentMovieBtn.Location = New System.Drawing.Point(876, 778)
        Me.rentMovieBtn.Name = "rentMovieBtn"
        Me.rentMovieBtn.Size = New System.Drawing.Size(171, 63)
        Me.rentMovieBtn.TabIndex = 19
        Me.rentMovieBtn.Text = "Rent Movie"
        Me.rentMovieBtn.UseVisualStyleBackColor = True
        '
        'AdvanceSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final_Project.My.Resources.Resources.wp4615534___Copy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 853)
        Me.Controls.Add(Me.rentMovieBtn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.advanceSearchList)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdvanceSearch"
        Me.Text = "AdvanceSearch"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.advanceSearchList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents searchBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents advanceSearchList As DataGridView
    Friend WithEvents titleTextfield As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents resumeTextfield As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lengthTextfield As TextBox
    Friend WithEvents actorTextfield As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents yearTextfield As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents directorTextfield As TextBox
    Friend WithEvents genreTextfield As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents languageTextfield As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents countryTextfield As TextBox
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
    Friend WithEvents rentMovieBtn As Button
End Class
