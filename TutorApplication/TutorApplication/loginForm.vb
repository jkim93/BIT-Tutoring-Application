Imports System.Data.OleDb
Public Class LoginForm
    Public userName As String
    Public tutorDataAdapter As OleDbDataAdapter
    Public tutorDataSet As DataSet
    Dim findUserIDcommand As OleDbCommand
    Dim findPwdcommand As OleDbCommand
    Dim tutorConnection As OleDbConnection

    Private Sub newUserButton_Click(sender As System.Object, e As System.EventArgs) Handles newUserButton.Click
        Me.Hide()
        Dim showNewUserForm As New newUserForm
        showNewUserForm.ShowDialog()
    End Sub

    Private Sub loginButton_Click(sender As System.Object, e As System.EventArgs) Handles loginButton.Click
        userName = userIDTextBox.Text

        If userName = "" Or passwordTextBox.Text = "" Then
            MsgBox("Please enter your username and password")
            Exit Sub
        End If

        'validate username/password
        If userIDTextBox.Text = "admin123@vt.edu" And passwordTextBox.Text = "RJC" Then
            Me.Hide()
            Dim showReportsForm As New reportsForm
            showReportsForm.ShowDialog()
        Else
            If validateUsernameAndPassword() = True Then
                Me.Hide()
                Dim showprofile As New profileForm
                showprofile.ShowDialog()
            End If
        End If

    End Sub

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sqlStatement As String = "select * from userAccount"
        Dim tutorConnection As String = "provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb"

        tutorDataAdapter = New OleDbDataAdapter(sqlStatement, tutorConnection)

        tutorDataSet = New DataSet()

        tutorDataAdapter.Fill(tutorDataSet, "userAccount")

    End Sub

    Private Sub DeleteButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteButton.Click

        userName = userIDTextBox.Text

        If validateUsernameAndPassword() = True And userIDTextBox.Text <> "" And passwordTextBox.Text <> "" Then
            Dim response = MsgBox("Are you sure you want to delete your account?", MsgBoxStyle.YesNo)

            If response = vbYes Then
                tutorConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
                tutorConnection.Open()

                findPwdcommand = New OleDbCommand
                findPwdcommand.Connection = tutorConnection
                findPwdcommand.CommandText = "delete from request where userID='" & userName & "'"

                Dim pwdDoCommand As Integer = findPwdcommand.ExecuteNonQuery

                findPwdcommand = New OleDbCommand
                findPwdcommand.Connection = tutorConnection
                findPwdcommand.CommandText = "delete from request where tutorUserID='" & userName & "'"

                pwdDoCommand = findPwdcommand.ExecuteNonQuery

                findPwdcommand = New OleDbCommand
                findPwdcommand.Connection = tutorConnection
                findPwdcommand.CommandText = "delete from class where userID='" & userName & "'"

                pwdDoCommand = findPwdcommand.ExecuteNonQuery

                findPwdcommand = New OleDbCommand
                findPwdcommand.Connection = tutorConnection
                findPwdcommand.CommandText = "delete from userAccount where userID='" & userName & "'"

                pwdDoCommand = findPwdcommand.ExecuteNonQuery
                MsgBox("Account successfully deleted")

                userIDTextBox.Clear()
                passwordTextBox.Clear()
            Else
                MsgBox("Account not deleted")
            End If
        Else
            MsgBox("Account not deleted")
        End If


    End Sub

    Function validateUsernameAndPassword() As Boolean
        Dim matchPass As String = ""

        tutorConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
        tutorConnection.Open()

        findPwdcommand = New OleDbCommand
        findPwdcommand.Connection = tutorConnection
        findPwdcommand.CommandText = "select pwd from userAccount where userID='" & userName & "'"

        Dim pwdDataReader As OleDbDataReader = findPwdcommand.ExecuteReader()

        Do While pwdDataReader.Read()
            matchPass = pwdDataReader.GetString(0)
        Loop

        If passwordTextBox.Text = matchPass Then
            validateUsernameAndPassword = True
        Else
            validateUsernameAndPassword = False
            MsgBox("Username and password do not match.  Username and password are case sensitive.")
        End If

        pwdDataReader.Close()
    End Function
End Class
