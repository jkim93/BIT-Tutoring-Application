<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class requestTutorForm
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
        Me.hoursComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dayComboBox = New System.Windows.Forms.ComboBox()
        Me.TutorListView = New System.Windows.Forms.ListView()
        Me.tutorColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.courseColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dayColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.timeColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rateColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.showAllCheckBox = New System.Windows.Forms.CheckBox()
        Me.doneButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'classComboBox
        '
        Me.classComboBox.BackColor = System.Drawing.SystemColors.Window
        Me.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.classComboBox.FormattingEnabled = True
        Me.classComboBox.Items.AddRange(New Object() {"", "BIT-3434", "BIT-3444", "BIT-4524", "BIT-4554"})
        Me.classComboBox.Location = New System.Drawing.Point(97, 86)
        Me.classComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.classComboBox.Name = "classComboBox"
        Me.classComboBox.Size = New System.Drawing.Size(160, 24)
        Me.classComboBox.TabIndex = 0
        '
        'rateComboBox
        '
        Me.rateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rateComboBox.FormattingEnabled = True
        Me.rateComboBox.Items.AddRange(New Object() {"", "FREE", "$1.00 / hr", "$2.00 / hr", "$3.00 / hr", "$4.00 / hr", "$5.00 / hr", "$6.00 / hr", "$7.00 / hr", "$8.00 / hr", "$9.00 / hr", "$10.00 / hr", "$11.00 / hr", "$12.00 / hr", "$13.00 / hr", "$14.00 / hr", "$15.00 / hr", "$16.00 / hr", "$17.00 / hr", "$18.00 / hr", "$19.00 / hr", "$20.00 / hr", "$21.00 / hr", "$22.00 / hr", "$23.00 / hr", "$24.00 / hr", "$25.00 / hr"})
        Me.rateComboBox.Location = New System.Drawing.Point(412, 134)
        Me.rateComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rateComboBox.Name = "rateComboBox"
        Me.rateComboBox.Size = New System.Drawing.Size(160, 24)
        Me.rateComboBox.TabIndex = 3
        '
        'hoursComboBox
        '
        Me.hoursComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hoursComboBox.FormattingEnabled = True
        Me.hoursComboBox.Items.AddRange(New Object() {"", "12am-1am", "1am-2am", "2am-3am", "3am-4am", "4am-5am", "5am-6am", "6am-7am", "7am-8am", "8am-9am", "9am-10am", "10am-11am", "11am-12pm", "12pm-1pm", "1pm-2pm", "2pm-3pm", "3pm-4pm", "4pm-5pm", "5pm-6pm", "6pm-7pm", "7pm-8pm", "8pm-9pm", "9pm-10pm", "10pm-11pm", "11pm-12pm"})
        Me.hoursComboBox.Location = New System.Drawing.Point(97, 134)
        Me.hoursComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.hoursComboBox.Name = "hoursComboBox"
        Me.hoursComboBox.Size = New System.Drawing.Size(160, 24)
        Me.hoursComboBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Class"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hours"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(352, 138)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Rate"
        '
        'searchButton
        '
        Me.searchButton.ForeColor = System.Drawing.Color.Black
        Me.searchButton.Location = New System.Drawing.Point(167, 197)
        Me.searchButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(116, 32)
        Me.searchButton.TabIndex = 4
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'submitButton
        '
        Me.submitButton.ForeColor = System.Drawing.Color.Black
        Me.submitButton.Location = New System.Drawing.Point(155, 495)
        Me.submitButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(116, 32)
        Me.submitButton.TabIndex = 5
        Me.submitButton.Text = "Submit "
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1, 15)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(844, 30)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Request A Tutor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(352, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Day"
        '
        'dayComboBox
        '
        Me.dayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dayComboBox.FormattingEnabled = True
        Me.dayComboBox.Items.AddRange(New Object() {"", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.dayComboBox.Location = New System.Drawing.Point(412, 86)
        Me.dayComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dayComboBox.Name = "dayComboBox"
        Me.dayComboBox.Size = New System.Drawing.Size(160, 24)
        Me.dayComboBox.TabIndex = 13
        '
        'TutorListView
        '
        Me.TutorListView.CheckBoxes = True
        Me.TutorListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.tutorColumnHeader, Me.courseColumnHeader, Me.dayColumnHeader, Me.timeColumnHeader, Me.rateColumnHeader})
        Me.TutorListView.Location = New System.Drawing.Point(41, 250)
        Me.TutorListView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TutorListView.MultiSelect = False
        Me.TutorListView.Name = "TutorListView"
        Me.TutorListView.Size = New System.Drawing.Size(531, 214)
        Me.TutorListView.TabIndex = 27
        Me.TutorListView.UseCompatibleStateImageBehavior = False
        Me.TutorListView.View = System.Windows.Forms.View.Details
        '
        'tutorColumnHeader
        '
        Me.tutorColumnHeader.Text = "TutorID"
        Me.tutorColumnHeader.Width = 124
        '
        'courseColumnHeader
        '
        Me.courseColumnHeader.Text = "Course"
        Me.courseColumnHeader.Width = 100
        '
        'dayColumnHeader
        '
        Me.dayColumnHeader.Text = "Day"
        Me.dayColumnHeader.Width = 103
        '
        'timeColumnHeader
        '
        Me.timeColumnHeader.Text = "Time"
        Me.timeColumnHeader.Width = 93
        '
        'rateColumnHeader
        '
        Me.rateColumnHeader.Text = "Rate"
        Me.rateColumnHeader.Width = 95
        '
        'showAllCheckBox
        '
        Me.showAllCheckBox.AutoSize = True
        Me.showAllCheckBox.Location = New System.Drawing.Point(356, 204)
        Me.showAllCheckBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.showAllCheckBox.Name = "showAllCheckBox"
        Me.showAllCheckBox.Size = New System.Drawing.Size(128, 21)
        Me.showAllCheckBox.TabIndex = 28
        Me.showAllCheckBox.Text = "Show All Tutors"
        Me.showAllCheckBox.UseVisualStyleBackColor = True
        '
        'doneButton
        '
        Me.doneButton.ForeColor = System.Drawing.Color.Black
        Me.doneButton.Location = New System.Drawing.Point(348, 495)
        Me.doneButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.doneButton.Name = "doneButton"
        Me.doneButton.Size = New System.Drawing.Size(116, 32)
        Me.doneButton.TabIndex = 29
        Me.doneButton.Text = "Back"
        Me.doneButton.UseVisualStyleBackColor = True
        '
        'requestTutorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(623, 542)
        Me.Controls.Add(Me.doneButton)
        Me.Controls.Add(Me.showAllCheckBox)
        Me.Controls.Add(Me.TutorListView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dayComboBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.hoursComboBox)
        Me.Controls.Add(Me.rateComboBox)
        Me.Controls.Add(Me.classComboBox)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "requestTutorForm"
        Me.Text = "Request"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents classComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents rateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents hoursComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents submitButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dayComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TutorListView As System.Windows.Forms.ListView
    Friend WithEvents tutorColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents courseColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents dayColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents timeColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents rateColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents showAllCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents doneButton As System.Windows.Forms.Button
End Class
