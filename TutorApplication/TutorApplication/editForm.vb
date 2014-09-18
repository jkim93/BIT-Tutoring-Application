Imports System.Data.OleDb
Public Class EditForm
    Dim findUserIDcommand As OleDbCommand
    Dim tutorConnection As OleDbConnection
    Private Sub EditForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tutorConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
        tutorConnection.Open()

        findUserIDcommand = New OleDbCommand
        findUserIDcommand.Connection = tutorConnection
        findUserIDcommand.CommandText = "select * from userAccount where userID='" & LoginForm.userName & "'"

        Dim userIDDataReader As OleDbDataReader = findUserIDcommand.ExecuteReader()

        Do While userIDDataReader.Read()
            usernameTextBox.Text = userIDDataReader.GetString(0)
            firstNameTextBox.Text = userIDDataReader.GetString(2)
            lastNameTextBox.Text = userIDDataReader.GetString(3)
            gradeComboBox.Text = userIDDataReader.GetString(4)
            phoneNumberTextBox.Text = userIDDataReader.GetString(5)
        Loop
        userIDDataReader.Close()

    End Sub

    Private Sub submitButton_Click(sender As System.Object, e As System.EventArgs) Handles submitButton.Click

        If Not passwordTextBox.Text = "" Then
            If passwordTextBox.Text = verifyPasswordTextBox.Text Then
                If Not firstNameTextBox.Text = "" Then
                    If Not lastNameTextBox.Text = "" Then
                        If Not gradeComboBox.Text = "" Then

                            tutorConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
                            tutorConnection.Open()

                            findUserIDcommand = New OleDbCommand
                            findUserIDcommand.Connection = tutorConnection
                            findUserIDcommand.CommandText = "update userAccount SET pwd='" & passwordTextBox.Text & "', firstname='" & firstNameTextBox.Text &
                                "', lastname='" & lastNameTextBox.Text & "', gradelevel='" & gradeComboBox.Text & "', phonenumber='" & phoneNumberTextBox.Text & "' where userID='" & LoginForm.userName & "'"

                            Dim profileDataReader As String = findUserIDcommand.ExecuteNonQuery()
                            MsgBox("Profile Updated")
                            Me.Hide()
                            Dim showProfile As New profileForm
                            showProfile.ShowDialog()

                        Else
                            MsgBox("You must select your grade")
                            Exit Sub
                        End If
                    Else
                        MsgBox("You must enter your last name")
                        Exit Sub
                    End If
                Else
                    MsgBox("Your must enter your first name")
                    Exit Sub
                End If
            Else
                MsgBox("Your passwords do not match")
                Exit Sub
            End If
        Else
            MsgBox("You must enter a password")
            Exit Sub
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Dim showProfile As New profileForm
        showProfile.ShowDialog()
    End Sub
End Class