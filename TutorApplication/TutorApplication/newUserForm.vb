Imports System.Data.OleDb
Public Class newUserForm

    Dim findUserIDcommand As OleDbCommand
    Dim tutorConnection As OleDbConnection

    Private Sub submitButton_Click(sender As System.Object, e As System.EventArgs) Handles submitButton.Click
        'checking to see if username is already taken, the tempVar 
        Dim tempVar As String = ""

        tutorConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
        tutorConnection.Open()

        findUserIDcommand = New OleDbCommand
        findUserIDcommand.Connection = tutorConnection
        findUserIDcommand.CommandText = "select userID from userAccount where userID='" & usernameTextBox.Text & "'"

        Dim userIDDataReader As OleDbDataReader = findUserIDcommand.ExecuteReader()

        Do While userIDDataReader.Read()
            tempVar = userIDDataReader.GetString(0)
        Loop
        userIDDataReader.Close()

        'validating all entries 
        If usernameTextBox.Text.EndsWith("@vt.edu") Then
            If usernameTextBox.Text = verifyUsernameTextBox.Text Then
                If Not passwordTextBox.Text = "" Then
                    If passwordTextBox.Text = verifyPasswordTextBox.Text Then
                        If Not firstNameTextBox.Text = "" Then
                            If Not lastNameTextBox.Text = "" Then
                                If Not gradeComboBox.Text = "" Then
                                    If Not tempVar = usernameTextBox.Text Then

                                        Dim aNewUser As DataRow = LoginForm.tutorDataSet.Tables(0).NewRow

                                        aNewUser.BeginEdit()
                                        aNewUser("userID") = usernameTextBox.Text
                                        aNewUser("pwd") = passwordTextBox.Text
                                        aNewUser("firstName") = firstNameTextBox.Text
                                        aNewUser("lastName") = lastNameTextBox.Text
                                        aNewUser("gradeLevel") = gradeComboBox.Text
                                        aNewUser("phoneNumber") = phoneNumberTextBox.Text
                                        aNewUser("dateCreated") = Today
                                        aNewUser.EndEdit()

                                        LoginForm.tutorDataSet.Tables(0).Rows.Add(aNewUser)

                                        Dim newUserCommandBuilder As New OleDbCommandBuilder(LoginForm.tutorDataAdapter)
                                        LoginForm.tutorDataAdapter.InsertCommand = newUserCommandBuilder.GetInsertCommand()
                                        LoginForm.tutorDataAdapter.DeleteCommand = newUserCommandBuilder.GetDeleteCommand()
                                        LoginForm.tutorDataAdapter.UpdateCommand = newUserCommandBuilder.GetUpdateCommand()

                                        Dim numOfRecords As Integer = LoginForm.tutorDataAdapter.Update(LoginForm.tutorDataSet, "userAccount")
                                        MsgBox("User account successfully created!")

                                        LoginForm.tutorDataSet.Tables("userAccount").Rows.Clear()
                                        LoginForm.tutorDataAdapter.Fill(LoginForm.tutorDataSet, "userAccount")

                                        Application.Restart()
                                        ' Me.Hide()
                                        ' Dim showLoginForm As New LoginForm
                                        ' showLoginForm.ShowDialog()

                                    Else
                                        MsgBox("Username is already in use")
                                        Exit Sub
                                    End If
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
            Else
                MsgBox("You usernames do not match")
                Exit Sub
            End If
        Else
            MsgBox("You must use your VT email address which ends with @vt.edu")
            Exit Sub
        End If


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Dim showLoginForm As New LoginForm
        showLoginForm.ShowDialog()
    End Sub

  
End Class