<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatePassword
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.confirmPassTextfield = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.confirmBtn = New System.Windows.Forms.Button()
        Me.newPassTextfield = New System.Windows.Forms.TextBox()
        Me.passTextfield = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label1.Location = New System.Drawing.Point(392, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(523, 81)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password Update"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Controls.Add(Me.cancelBtn)
        Me.Panel1.Controls.Add(Me.confirmPassTextfield)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.confirmBtn)
        Me.Panel1.Controls.Add(Me.newPassTextfield)
        Me.Panel1.Controls.Add(Me.passTextfield)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(287, 244)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(685, 360)
        Me.Panel1.TabIndex = 3
        '
        'confirmPassTextfield
        '
        Me.confirmPassTextfield.Font = New System.Drawing.Font("Ebrima", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.confirmPassTextfield.Location = New System.Drawing.Point(286, 204)
        Me.confirmPassTextfield.Name = "confirmPassTextfield"
        Me.confirmPassTextfield.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmPassTextfield.Size = New System.Drawing.Size(370, 44)
        Me.confirmPassTextfield.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(19, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 38)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Confirm Password:"
        '
        'confirmBtn
        '
        Me.confirmBtn.Font = New System.Drawing.Font("Ebrima", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.confirmBtn.Location = New System.Drawing.Point(241, 287)
        Me.confirmBtn.Name = "confirmBtn"
        Me.confirmBtn.Size = New System.Drawing.Size(251, 56)
        Me.confirmBtn.TabIndex = 7
        Me.confirmBtn.Text = "Confirm Change"
        Me.confirmBtn.UseVisualStyleBackColor = True
        '
        'newPassTextfield
        '
        Me.newPassTextfield.Font = New System.Drawing.Font("Ebrima", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.newPassTextfield.Location = New System.Drawing.Point(286, 134)
        Me.newPassTextfield.Name = "newPassTextfield"
        Me.newPassTextfield.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newPassTextfield.Size = New System.Drawing.Size(370, 44)
        Me.newPassTextfield.TabIndex = 6
        '
        'passTextfield
        '
        Me.passTextfield.Font = New System.Drawing.Font("Ebrima", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.passTextfield.Location = New System.Drawing.Point(286, 64)
        Me.passTextfield.Name = "passTextfield"
        Me.passTextfield.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passTextfield.Size = New System.Drawing.Size(370, 44)
        Me.passTextfield.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(62, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 38)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "New Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(25, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 38)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Current Password:"
        '
        'cancelBtn
        '
        Me.cancelBtn.Font = New System.Drawing.Font("Ebrima", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cancelBtn.Location = New System.Drawing.Point(520, 287)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(136, 56)
        Me.cancelBtn.TabIndex = 10
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'UpdatePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final_Project.My.Resources.Resources.wp4615534___Copy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 853)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdatePassword"
        Me.Text = "UpdatePassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents confirmBtn As Button
    Friend WithEvents newPassTextfield As TextBox
    Friend WithEvents passTextfield As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents confirmPassTextfield As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cancelBtn As Button
End Class
