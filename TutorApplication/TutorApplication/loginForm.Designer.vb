<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.userIDTextBox = New System.Windows.Forms.TextBox()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.newUserButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'userIDTextBox
        '
        Me.userIDTextBox.Location = New System.Drawing.Point(181, 87)
        Me.userIDTextBox.Name = "userIDTextBox"
        Me.userIDTextBox.Size = New System.Drawing.Size(91, 20)
        Me.userIDTextBox.TabIndex = 0
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(181, 147)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(91, 20)
        Me.passwordTextBox.TabIndex = 1
        '
        'loginButton
        '
        Me.loginButton.Location = New System.Drawing.Point(84, 196)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(91, 23)
        Me.loginButton.TabIndex = 2
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'newUserButton
        '
        Me.newUserButton.Location = New System.Drawing.Point(181, 196)
        Me.newUserButton.Name = "newUserButton"
        Me.newUserButton.Size = New System.Drawing.Size(91, 23)
        Me.newUserButton.TabIndex = 3
        Me.newUserButton.Text = "New User"
        Me.newUserButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(278, 196)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(91, 23)
        Me.DeleteButton.TabIndex = 4
        Me.DeleteButton.Text = "Delete Account"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(178, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(178, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(-1, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(485, 26)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Virginia Tech BIT Tutoring System"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(348, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(464, 270)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.newUserButton)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.userIDTextBox)
        Me.Name = "LoginForm"
        Me.Text = "LogIn"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents userIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents passwordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents loginButton As System.Windows.Forms.Button
    Friend WithEvents newUserButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
