<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class becomeTutorForm
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
        Me.classComboBox = New System.Windows.Forms.ComboBox()
        Me.rateComboBox = New System.Windows.Forms.ComboBox()
        Me.day2ComboBox = New System.Windows.Forms.ComboBox()
        Me.hours2ComboBox = New System.Windows.Forms.ComboBox()
        Me.day1ComboBox = New System.Windows.Forms.ComboBox()
        Me.hours1ComboBox = New System.Windows.Forms.ComboBox()
        Me.day5ComboBox = New System.Windows.Forms.ComboBox()
        Me.hours5ComboBox = New System.Windows.Forms.ComboBox()
        Me.day4ComboBox = New System.Windows.Forms.ComboBox()
        Me.hours4ComboBox = New System.Windows.Forms.ComboBox()
        Me.day3ComboBox = New System.Windows.Forms.ComboBox()
        Me.hours3ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'classComboBox
        '
        Me.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.classComboBox.FormattingEnabled = True
        Me.classComboBox.Items.AddRange(New Object() {"", "BIT-3434", "BIT-3444", "BIT-4524", "BIT-4554"})
        Me.classComboBox.Location = New System.Drawing.Point(151, 92)
        Me.classComboBox.Name = "classComboBox"
        Me.classComboBox.Size = New System.Drawing.Size(121, 21)
        Me.classComboBox.TabIndex = 0
        '
        'rateComboBox
        '
        Me.rateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rateComboBox.FormattingEnabled = True
        Me.rateComboBox.Items.AddRange(New Object() {"", "FREE", "$1.00 / hr", "$2.00 / hr", "$3.00 / hr", "$4.00 / hr", "$5.00 / hr", "$6.00 / hr", "$7.00 / hr", "$8.00 / hr", "$9.00 / hr", "$10.00 / hr", "$11.00 / hr", "$12.00 / hr", "$13.00 / hr", "$14.00 / hr", "$15.00 / hr", "$16.00 / hr", "$17.00 / hr", "$18.00 / hr", "$19.00 / hr", "$20.00 / hr", "$21.00 / hr", "$22.00 / hr", "$23.00 / hr", "$24.00 / hr", "$25.00 / hr"})
        Me.rateComboBox.Location = New System.Drawing.Point(151, 119)
        Me.rateComboBox.Name = "rateComboBox"
        Me.rateComboBox.Size = New System.Drawing.Size(121, 21)
        Me.rateComboBox.TabIndex = 1
        '
        'day2ComboBox
        '
        Me.day2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.day2ComboBox.FormattingEnabled = True
        Me.day2ComboBox.Items.AddRange(New Object() {"", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.day2ComboBox.Location = New System.Drawing.Point(250, 216)
        Me.day2ComboBox.Name = "day2ComboBox"
        Me.day2ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.day2ComboBox.TabIndex = 5
        '
        'hours2ComboBox
        '
        Me.hours2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hours2ComboBox.FormattingEnabled = True
        Me.hours2ComboBox.Items.AddRange(New Object() {"", "12am-1am", "1am-2am", "2am-3am", "3am-4am", "4am-5am", "5am-6am", "6am-7am", "7am-8am", "8am-9am", "9am-10am", "10am-11am", "11am-12pm", "12pm-1pm", "1pm-2pm", "2pm-3pm", "3pm-4pm", "4pm-5pm", "5pm-6pm", "6pm-7pm", "7pm-8pm", "8pm-9pm", "9pm-10pm", "10pm-11pm", "11pm-12pm"})
        Me.hours2ComboBox.Location = New System.Drawing.Point(37, 216)
        Me.hours2ComboBox.Name = "hours2ComboBox"
        Me.hours2ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.hours2ComboBox.TabIndex = 4
        '
        'day1ComboBox
        '
        Me.day1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.day1ComboBox.FormattingEnabled = True
        Me.day1ComboBox.Items.AddRange(New Object() {"", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.day1ComboBox.Location = New System.Drawing.Point(250, 189)
        Me.day1ComboBox.Name = "day1ComboBox"
        Me.day1ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.day1ComboBox.TabIndex = 3
        '
        'hours1ComboBox
        '
        Me.hours1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hours1ComboBox.FormattingEnabled = True
        Me.hours1ComboBox.Items.AddRange(New Object() {"", "12am-1am", "1am-2am", "2am-3am", "3am-4am", "4am-5am", "5am-6am", "6am-7am", "7am-8am", "8am-9am", "9am-10am", "10am-11am", "11am-12pm", "12pm-1pm", "1pm-2pm", "2pm-3pm", "3pm-4pm", "4pm-5pm", "5pm-6pm", "6pm-7pm", "7pm-8pm", "8pm-9pm", "9pm-10pm", "10pm-11pm", "11pm-12pm"})
        Me.hours1ComboBox.Location = New System.Drawing.Point(37, 189)
        Me.hours1ComboBox.Name = "hours1ComboBox"
        Me.hours1ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.hours1ComboBox.TabIndex = 2
        '
        'day5ComboBox
        '
        Me.day5ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.day5ComboBox.FormattingEnabled = True
        Me.day5ComboBox.Items.AddRange(New Object() {"", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.day5ComboBox.Location = New System.Drawing.Point(250, 297)
        Me.day5ComboBox.Name = "day5ComboBox"
        Me.day5ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.day5ComboBox.TabIndex = 11
        '
        'hours5ComboBox
        '
        Me.hours5ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hours5ComboBox.FormattingEnabled = True
        Me.hours5ComboBox.Items.AddRange(New Object() {"", "12am-1am", "1am-2am", "2am-3am", "3am-4am", "4am-5am", "5am-6am", "6am-7am", "7am-8am", "8am-9am", "9am-10am", "10am-11am", "11am-12pm", "12pm-1pm", "1pm-2pm", "2pm-3pm", "3pm-4pm", "4pm-5pm", "5pm-6pm", "6pm-7pm", "7pm-8pm", "8pm-9pm", "9pm-10pm", "10pm-11pm", "11pm-12pm"})
        Me.hours5ComboBox.Location = New System.Drawing.Point(37, 297)
        Me.hours5ComboBox.Name = "hours5ComboBox"
        Me.hours5ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.hours5ComboBox.TabIndex = 10
        '
        'day4ComboBox
        '
        Me.day4ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.day4ComboBox.FormattingEnabled = True
        Me.day4ComboBox.Items.AddRange(New Object() {"", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.day4ComboBox.Location = New System.Drawing.Point(250, 270)
        Me.day4ComboBox.Name = "day4ComboBox"
        Me.day4ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.day4ComboBox.TabIndex = 9
        '
        'hours4ComboBox
        '
        Me.hours4ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hours4ComboBox.FormattingEnabled = True
        Me.hours4ComboBox.Items.AddRange(New Object() {"", "12am-1am", "1am-2am", "2am-3am", "3am-4am", "4am-5am", "5am-6am", "6am-7am", "7am-8am", "8am-9am", "9am-10am", "10am-11am", "11am-12pm", "12pm-1pm", "1pm-2pm", "2pm-3pm", "3pm-4pm", "4pm-5pm", "5pm-6pm", "6pm-7pm", "7pm-8pm", "8pm-9pm", "9pm-10pm", "10pm-11pm", "11pm-12pm"})
        Me.hours4ComboBox.Location = New System.Drawing.Point(37, 270)
        Me.hours4ComboBox.Name = "hours4ComboBox"
        Me.hours4ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.hours4ComboBox.TabIndex = 8
        '
        'day3ComboBox
        '
        Me.day3ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.day3ComboBox.FormattingEnabled = True
        Me.day3ComboBox.Items.AddRange(New Object() {"", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.day3ComboBox.Location = New System.Drawing.Point(250, 243)
        Me.day3ComboBox.Name = "day3ComboBox"
        Me.day3ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.day3ComboBox.TabIndex = 7
        '
        'hours3ComboBox
        '
        Me.hours3ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hours3ComboBox.FormattingEnabled = True
        Me.hours3ComboBox.Items.AddRange(New Object() {"", "12am-1am", "1am-2am", "2am-3am", "3am-4am", "4am-5am", "5am-6am", "6am-7am", "7am-8am", "8am-9am", "9am-10am", "10am-11am", "11am-12pm", "12pm-1pm", "1pm-2pm", "2pm-3pm", "3pm-4pm", "4pm-5pm", "5pm-6pm", "6pm-7pm", "7pm-8pm", "8pm-9pm", "9pm-10pm", "10pm-11pm", "11pm-12pm"})
        Me.hours3ComboBox.Location = New System.Drawing.Point(37, 243)
        Me.hours3ComboBox.Name = "hours3ComboBox"
        Me.hours3ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.hours3ComboBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(81, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Class"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(59, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Rate per Hour"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(193, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "On"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(193, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "On"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(193, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "On"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(193, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "On"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(193, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "On"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(83, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Time"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(298, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Day"
        '
        'submitButton
        '
        Me.submitButton.ForeColor = System.Drawing.Color.Black
        Me.submitButton.Location = New System.Drawing.Point(84, 339)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(101, 30)
        Me.submitButton.TabIndex = 12
        Me.submitButton.Text = "Submit "
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(485, 26)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Become A Tutor"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(223, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 30)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox
        '
        Me.TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox.ForeColor = System.Drawing.Color.White
        Me.TextBox.Location = New System.Drawing.Point(50, 45)
        Me.TextBox.Multiline = True
        Me.TextBox.Name = "TextBox"
        Me.TextBox.ReadOnly = True
        Me.TextBox.Size = New System.Drawing.Size(312, 41)
        Me.TextBox.TabIndex = 25
        Me.TextBox.Text = "Select class, rate, time and day.  Each time corresponds to a single accompanying" & _
    " day."
        Me.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'becomeTutorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(405, 395)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hours3ComboBox)
        Me.Controls.Add(Me.day3ComboBox)
        Me.Controls.Add(Me.hours4ComboBox)
        Me.Controls.Add(Me.day4ComboBox)
        Me.Controls.Add(Me.hours5ComboBox)
        Me.Controls.Add(Me.day5ComboBox)
        Me.Controls.Add(Me.hours1ComboBox)
        Me.Controls.Add(Me.day1ComboBox)
        Me.Controls.Add(Me.hours2ComboBox)
        Me.Controls.Add(Me.day2ComboBox)
        Me.Controls.Add(Me.rateComboBox)
        Me.Controls.Add(Me.classComboBox)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "becomeTutorForm"
        Me.Text = "Become A Tutor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents classComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents rateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents day2ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents hours2ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents day1ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents hours1ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents day5ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents hours5ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents day4ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents hours4ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents day3ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents hours3ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents submitButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox As System.Windows.Forms.TextBox
End Class
