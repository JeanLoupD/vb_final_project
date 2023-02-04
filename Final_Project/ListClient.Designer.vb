<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListClient
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.allClientsList = New System.Windows.Forms.DataGridView()
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
        CType(Me.allClientsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label2.Location = New System.Drawing.Point(468, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(374, 50)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "List of all the Clients"
        '
        'allClientsList
        '
        Me.allClientsList.BackgroundColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.allClientsList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.allClientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.allClientsList.DefaultCellStyle = DataGridViewCellStyle2
        Me.allClientsList.Location = New System.Drawing.Point(12, 150)
        Me.allClientsList.Name = "allClientsList"
        Me.allClientsList.RowHeadersWidth = 51
        Me.allClientsList.RowTemplate.Height = 29
        Me.allClientsList.Size = New System.Drawing.Size(1238, 691)
        Me.allClientsList.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.VideoToolStripMenuItem, Me.ClientToolStripMenuItem, Me.SearchToolStripMenuItem, Me.RentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1262, 28)
        Me.MenuStrip1.TabIndex = 9
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
        'ListClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final_Project.My.Resources.Resources.wp4615534___Copy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 853)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.allClientsList)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ListClient"
        Me.Text = "ListClient"
        CType(Me.allClientsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents allClientsList As DataGridView
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
