<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditForm
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
        Me.submitButton = New System.Windows.Forms.Button()
        Me.gradeComboBox = New System.Windows.Forms.ComboBox()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.phoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.verifyPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(43, 272)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(75, 23)
        Me.submitButton.TabIndex = 9
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'gradeComboBox
        '
        Me.gradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gradeComboBox.FormattingEnabled = True
        Me.gradeComboBox.Items.AddRange(New Object() {"Freshman", "Sophomore", "Junior", "Senior", "5th Year Senior", "Graduate Student"})
        Me.gradeComboBox.Location = New System.Drawing.Point(149, 194)
        Me.gradeComboBox.Name = "gradeComboBox"
        Me.gradeComboBox.Size = New System.Drawing.Size(100, 21)
        Me.gradeComboBox.TabIndex = 7
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(149, 90)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.passwordTextBox.TabIndex = 3
        '
        'phoneNumberTextBox
        '
        Me.phoneNumberTextBox.Location = New System.Drawing.Point(149, 220)
        Me.phoneNumberTextBox.Name = "phoneNumberTextBox"
        Me.phoneNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.phoneNumberTextBox.TabIndex = 8
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Location = New System.Drawing.Point(149, 168)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.lastNameTextBox.TabIndex = 6
        '
        'verifyPasswordTextBox
        '
        Me.verifyPasswordTextBox.Location = New System.Drawing.Point(149, 116)
        Me.verifyPasswordTextBox.Name = "verifyPasswordTextBox"
        Me.verifyPasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.verifyPasswordTextBox.TabIndex = 4
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Location = New System.Drawing.Point(149, 142)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.firstNameTextBox.TabIndex = 5
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Location = New System.Drawing.Point(149, 64)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.ReadOnly = True
        Me.usernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.usernameTextBox.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(20, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Phone Number(Optional)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(20, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Grade Level"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(20, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(20, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(20, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Password Verification"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Username"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(-1, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(485, 26)
        Me.TextBox1.TabIndex = 38
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Edit User Information"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(159, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(285, 338)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.gradeComboBox)
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
        Me.Controls.Add(Me.Label2)
        Me.Name = "EditForm"
        Me.Text = "Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents submitButton As System.Windows.Forms.Button
    Friend WithEvents gradeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents passwordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents phoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents verifyPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents firstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents usernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
