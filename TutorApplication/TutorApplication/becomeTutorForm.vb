Imports System.Data.OleDb
Public Class becomeTutorForm
    Dim becomeTutorConnection As New OleDbConnection
    Dim becomeTutorCommand As OleDbCommand

    Private Sub submitButton_Click(sender As System.Object, e As System.EventArgs) Handles submitButton.Click
        Dim i As Integer
        Dim x As Integer = 0

        If classComboBox.Text = "" Or rateComboBox.Text = "" Then
            MsgBox("Please select both class and rate")
            Exit Sub
        End If

        becomeTutorConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
        becomeTutorConnection.Open()

        becomeTutorCommand = New OleDbCommand
        becomeTutorCommand.Connection = becomeTutorConnection

        For i = 1 To 5
            If i = 1 And hours1ComboBox.Text <> "" And day1ComboBox.Text <> "" Then
                becomeTutorCommand.CommandText = "insert into class(userID, tutorClass, tutorRate, hour1, day1) values" &
            "('" & LoginForm.userName & "', '" & classComboBox.Text & "', '" & rateComboBox.Text & "','" & hours1ComboBox.Text & "','" & day1ComboBox.Text & "')"
                Dim profileDataReader As String = becomeTutorCommand.ExecuteNonQuery
                x = x + 1
            ElseIf i = 2 And hours2ComboBox.Text <> "" And day2ComboBox.Text <> "" Then
                becomeTutorCommand.CommandText = "insert into class(userID, tutorClass, tutorRate, hour1, day1) values" &
           "('" & LoginForm.userName & "', '" & classComboBox.Text & "', '" & rateComboBox.Text & "','" & hours2ComboBox.Text & "','" & day2ComboBox.Text & "')"
                Dim profileDataReader As String = becomeTutorCommand.ExecuteNonQuery
                x = x + 1
            ElseIf i = 3 And hours3ComboBox.Text <> "" And day3ComboBox.Text <> "" Then
                becomeTutorCommand.CommandText = "insert into class(userID, tutorClass, tutorRate, hour1, day1) values" &
               "('" & LoginForm.userName & "', '" & classComboBox.Text & "', '" & rateComboBox.Text & "','" & hours3ComboBox.Text & "','" & day3ComboBox.Text & "')"
                Dim profileDataReader As String = becomeTutorCommand.ExecuteNonQuery
                x = x + 1
            ElseIf i = 4 And hours4ComboBox.Text <> "" And day4ComboBox.Text <> "" Then
                becomeTutorCommand.CommandText = "insert into class(userID, tutorClass, tutorRate, hour1, day1) values" &
               "('" & LoginForm.userName & "', '" & classComboBox.Text & "', '" & rateComboBox.Text & "','" & hours4ComboBox.Text & "','" & day4ComboBox.Text & "')"
                Dim profileDataReader As String = becomeTutorCommand.ExecuteNonQuery
                x = x + 1
            ElseIf i = 5 And hours5ComboBox.Text <> "" And day5ComboBox.Text <> "" Then
                becomeTutorCommand.CommandText = "insert into class(userID, tutorClass, tutorRate, hour1, day1) values" &
               "('" & LoginForm.userName & "', '" & classComboBox.Text & "', '" & rateComboBox.Text & "','" & hours5ComboBox.Text & "','" & day5ComboBox.Text & "')"
                Dim profileDataReader As String = becomeTutorCommand.ExecuteNonQuery
                x = x + 1
            End If

        Next i

        If x > 0 Then
            MsgBox("You have become a tutor!")
        Else
            MsgBox("You have not become a tutor. You must provide date and time.")
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Dim showProfile As New profileForm
        showProfile.ShowDialog()
    End Sub
End Class