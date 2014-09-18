<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportsForm
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
        Me.requestsTextBox = New System.Windows.Forms.TextBox()
        Me.accountsTextBox = New System.Windows.Forms.TextBox()
        Me.timeTextBox = New System.Windows.Forms.TextBox()
        Me.requestListBox = New System.Windows.Forms.ListBox()
        Me.gradeLevelListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'requestsTextBox
        '
        Me.requestsTextBox.Location = New System.Drawing.Point(259, 84)
        Me.requestsTextBox.Name = "requestsTextBox"
        Me.requestsTextBox.ReadOnly = True
        Me.requestsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.requestsTextBox.TabIndex = 0
        '
        'accountsTextBox
        '
        Me.accountsTextBox.Location = New System.Drawing.Point(259, 248)
        Me.accountsTextBox.Name = "accountsTextBox"
        Me.accountsTextBox.ReadOnly = True
        Me.accountsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.accountsTextBox.TabIndex = 3
        '
        'timeTextBox
        '
        Me.timeTextBox.Location = New System.Drawing.Point(259, 110)
        Me.timeTextBox.Name = "timeTextBox"
        Me.timeTextBox.ReadOnly = True
        Me.timeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.timeTextBox.TabIndex = 1
        '
        'requestListBox
        '
        Me.requestListBox.FormattingEnabled = True
        Me.requestListBox.Location = New System.Drawing.Point(259, 141)
        Me.requestListBox.Name = "requestListBox"
        Me.requestListBox.Size = New System.Drawing.Size(100, 56)
        Me.requestListBox.TabIndex = 2
        '
        'gradeLevelListBox
        '
        Me.gradeLevelListBox.FormattingEnabled = True
        Me.gradeLevelListBox.Location = New System.Drawing.Point(259, 274)
        Me.gradeLevelListBox.Name = "gradeLevelListBox"
        Me.gradeLevelListBox.Size = New System.Drawing.Size(119, 82)
        Me.gradeLevelListBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Report on Requests"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(87, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Most common time requested"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(110, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total number of requests"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(112, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Number of request types"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(35, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Report on Accounts Created"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(101, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Total Number of Accounts"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(62, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Number of accounts by grade level"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(-1, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(485, 26)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "System Reports "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(140, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 28)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Done/Log Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'reportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(405, 412)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gradeLevelListBox)
        Me.Controls.Add(Me.requestListBox)
        Me.Controls.Add(Me.timeTextBox)
        Me.Controls.Add(Me.accountsTextBox)
        Me.Controls.Add(Me.requestsTextBox)
        Me.Name = "reportsForm"
        Me.Text = "reportsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents requestsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents accountsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents timeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents requestListBox As System.Windows.Forms.ListBox
    Friend WithEvents gradeLevelListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
