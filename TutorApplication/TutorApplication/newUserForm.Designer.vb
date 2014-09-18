<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newUserForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.verifyPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.phoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.verifyUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.gradeComboBox = New System.Windows.Forms.ComboBox()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(56, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(56, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username Verification"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(56, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(56, 182)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password Verification"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(56, 214)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "First Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(56, 246)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Last Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(56, 278)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Grade Level"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(56, 310)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Phone Number(Optional)"
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Location = New System.Drawing.Point(228, 82)
        Me.usernameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(132, 22)
        Me.usernameTextBox.TabIndex = 1
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Location = New System.Drawing.Point(228, 210)
        Me.firstNameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(132, 22)
        Me.firstNameTextBox.TabIndex = 5
        '
        'verifyPasswordTextBox
        '
        Me.verifyPasswordTextBox.Location = New System.Drawing.Point(228, 178)
        Me.verifyPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.verifyPasswordTextBox.Name = "verifyPasswordTextBox"
        Me.verifyPasswordTextBox.Size = New System.Drawing.Size(132, 22)
        Me.verifyPasswordTextBox.TabIndex = 4
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Location = New System.Drawing.Point(228, 242)
        Me.lastNameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(132, 22)
        Me.lastNameTextBox.TabIndex = 6
        '
        'phoneNumberTextBox
        '
        Me.phoneNumberTextBox.Location = New System.Drawing.Point(228, 306)
        Me.phoneNumberTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.phoneNumberTextBox.Name = "phoneNumberTextBox"
        Me.phoneNumberTextBox.Size = New System.Drawing.Size(132, 22)
        Me.phoneNumberTextBox.TabIndex = 8
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(228, 146)
        Me.passwordTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(132, 22)
        Me.passwordTextBox.TabIndex = 3
        '
        'verifyUsernameTextBox
        '
        Me.verifyUsernameTextBox.Location = New System.Drawing.Point(228, 114)
        Me.verifyUsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.verifyUsernameTextBox.Name = "verifyUsernameTextBox"
        Me.verifyUsernameTextBox.Size = New System.Drawing.Size(132, 22)
        Me.verifyUsernameTextBox.TabIndex = 2
        '
        'gradeComboBox
        '
        Me.gradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gradeComboBox.FormattingEnabled = True
        Me.gradeComboBox.Items.AddRange(New Object() {"Freshman", "Sophomore", "Junior", "Senior", "5th Year Senior", "Graduate Student"})
        Me.gradeComboBox.Location = New System.Drawing.Point(228, 274)
        Me.gradeComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gradeComboBox.Name = "gradeComboBox"
        Me.gradeComboBox.Size = New System.Drawing.Size(132, 24)
        Me.gradeComboBox.TabIndex = 7
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(92, 353)
        Me.submitButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(100, 28)
        Me.submitButton.TabIndex = 9
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 15)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(645, 30)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "New User"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(241, 353)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'newUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(440, 421)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.gradeComboBox)
        Me.Controls.Add(Me.verifyUsernameTextBox)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.phoneNumberTextBox)
        Me.Controls.Add(Me.lastNameTextBox)
        Me.Controls.Add(Me.verifyPasswordTextBox)
        Me.Controls.Add(Me.firstNameTextBox)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "newUserForm"
        Me.Text = "New User "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents usernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents firstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents verifyPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents phoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents passwordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents verifyUsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents gradeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents submitButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
