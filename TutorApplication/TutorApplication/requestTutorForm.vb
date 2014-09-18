Imports System.Data.OleDb
Public Class requestTutorForm
    Dim profileConnection As OleDbConnection
    Dim findRequestCommand As OleDbCommand

    Private Sub searchButton_Click(sender As System.Object, e As System.EventArgs) Handles searchButton.Click
        Dim selectedClass As String = ""
        Dim selectedDay As String = ""
        Dim selectedHours As String = ""
        Dim selectedRate As String = ""

        If classComboBox.Text = "" And showAllCheckBox.Checked = False Then
            MsgBox("Please select a class or select show all tutors.")
            Exit Sub
        Else
            If Not classComboBox.Text = "" Then
                selectedClass = ("tutorclass='" & classComboBox.Text & "'")
            End If

            If Not dayComboBox.Text = "" Then
                selectedDay = (" and day1='" & dayComboBox.Text & "'")
            End If

            If Not rateComboBox.Text = "" Then
                selectedRate = (" and tutorRate='" & rateComboBox.Text & "'")
            End If

            If Not hoursComboBox.Text = "" Then
                selectedHours = (" and hour1='" & hoursComboBox.Text & "'")
            End If
        End If


        TutorListView.Items.Clear()

        profileConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
        profileConnection.Open()

        findRequestCommand = New OleDbCommand
        findRequestCommand.Connection = profileConnection

        If showAllCheckBox.Checked = True Then
            findRequestCommand.CommandText = "select * from class where userID<>'" & LoginForm.userName & "'"
        Else
            findRequestCommand.CommandText = "select * from class where(" & selectedClass & selectedDay & selectedRate & selectedHours & " and userID<>'" & LoginForm.userName & "')"
        End If

        Dim profileDataReader As OleDbDataReader = findRequestCommand.ExecuteReader

        Do While profileDataReader.Read()
            Dim item1 As New ListViewItem(profileDataReader.GetValue(1).ToString)
            item1.SubItems.Add(profileDataReader.GetValue(2))
            item1.SubItems.Add(profileDataReader.GetValue(5))
            item1.SubItems.Add(profileDataReader.GetValue(4))
            item1.SubItems.Add(profileDataReader.GetValue(3))

            TutorListView.Items.AddRange(New ListViewItem() {item1})
        Loop
        profileDataReader.Close()
    End Sub

    Private Sub submitButton_Click(sender As System.Object, e As System.EventArgs) Handles submitButton.Click
        Dim tempTutorUserID As String = ""
        Dim tempUserID As String = ""
        Dim tempClass As String = ""
        Dim tempHour As String = ""
        Dim tempDay As String = ""
        Dim tempRate As String = ""
        Dim x As String = ""
        Dim y As String = ""
        Dim z As String = ""

        If TutorListView.CheckedItems.Count > 0 And TutorListView.CheckedItems.Count < 2 Then
            profileConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
            profileConnection.Open()


            tempTutorUserID = TutorListView.Items(TutorListView.CheckedIndices(0)).Text
            tempDay = TutorListView.Items(TutorListView.CheckedIndices(0)).SubItems(2).Text
            tempHour = TutorListView.Items(TutorListView.CheckedIndices(0)).SubItems(3).Text

            findRequestCommand = New OleDbCommand
            findRequestCommand.Connection = profileConnection
            findRequestCommand.CommandText = "select userID, tutorUserID, requestHour, requestDay from request where userID='" & LoginForm.userName & "' and tutorUserID='" & tempTutorUserID & "' and requestHour='" & tempHour & "' and requestDay='" & tempDay & "'"

            Dim userIDDataReader As OleDbDataReader = findRequestCommand.ExecuteReader()

            Do While userIDDataReader.Read()
                tempUserID = userIDDataReader.GetString(0)
                x = userIDDataReader.GetString(1)
                y = userIDDataReader.GetString(2)
                z = userIDDataReader.GetString(3)
            Loop
            userIDDataReader.Close()

            If x.Equals(tempTutorUserID) And y.Equals(tempHour) And z.Equals(tempDay) Then
                MsgBox("You already have an appointment request with this tutor for this day and time.")
                Exit Sub
            End If


            Try
                tempTutorUserID = TutorListView.Items(TutorListView.CheckedIndices(0)).Text
                tempClass = TutorListView.Items(TutorListView.CheckedIndices(0)).SubItems(1).Text
                tempDay = TutorListView.Items(TutorListView.CheckedIndices(0)).SubItems(2).Text
                tempHour = TutorListView.Items(TutorListView.CheckedIndices(0)).SubItems(3).Text
                tempRate = TutorListView.Items(TutorListView.CheckedIndices(0)).SubItems(4).Text
                MsgBox("You have requested a tutor!")
            Catch ex As Exception
                MsgBox("Please select a tutor.")
            End Try

            profileConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
            profileConnection.Open()

            findRequestCommand = New OleDbCommand
            findRequestCommand.Connection = profileConnection
            findRequestCommand.CommandText = "insert into request(userID, tutorUserID, requestClass, requestHour, requestDay, tutorRate) values" &
            "('" & LoginForm.userName & "', '" & tempTutorUserID & "', '" & tempClass & _
            "','" & tempHour & "','" & tempDay & "','" & tempRate & "')"
            Dim profileDoCommand As String = findRequestCommand.ExecuteNonQuery
        Else
            MsgBox("Select one tutor.")
        End If

    End Sub

 
    Private Sub doneButton_Click(sender As System.Object, e As System.EventArgs) Handles doneButton.Click
        Me.Hide()
        Dim showProfileForm As New profileForm
        showProfileForm.ShowDialog()
    End Sub
End Class