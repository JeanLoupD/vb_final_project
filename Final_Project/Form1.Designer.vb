<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.usernameTextfield = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.passTextfield = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Controls.Add(Me.usernameTextfield)
        Me.Panel1.Controls.Add(Me.loginBtn)
        Me.Panel1.Controls.Add(Me.passTextfield)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(320, 272)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 360)
        Me.Panel1.TabIndex = 0
        '
        'usernameTextfield
        '
        Me.usernameTextfield.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.usernameTextfield.Location = New System.Drawing.Point(224, 88)
        Me.usernameTextfield.Name = "usernameTextfield"
        Me.usernameTextfield.Size = New System.Drawing.Size(340, 48)
        Me.usernameTextfield.TabIndex = 5
        '
        'loginBtn
        '
        Me.loginBtn.Font = New System.Drawing.Font("Ebrima", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.loginBtn.Location = New System.Drawing.Point(392, 251)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(172, 56)
        Me.loginBtn.TabIndex = 7
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'passTextfield
        '
        Me.passTextfield.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.passTextfield.Location = New System.Drawing.Point(224, 161)
        Me.passTextfield.Name = "passTextfield"
        Me.passTextfield.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passTextfield.Size = New System.Drawing.Size(340, 48)
        Me.passTextfield.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(59, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 41)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(67, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 41)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label1.Location = New System.Drawing.Point(396, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(522, 81)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Super Club Video"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label2.Location = New System.Drawing.Point(557, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 54)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "- Login -"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final_Project.My.Resources.Resources.wp4615534___Copy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 853)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents loginBtn As Button
    Friend WithEvents passTextfield As TextBox
    Friend WithEvents usernameTextfield As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
