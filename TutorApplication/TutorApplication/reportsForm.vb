Imports System.Data.OleDb
Public Class reportsForm
    Dim profileConnection As OleDbConnection
    Dim findRequestCommand As OleDbCommand
    Dim findAcceptedCommand As OleDbCommand
    Dim findDeclinedCommand As OleDbCommand

    Private Sub reportsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pendingcount As Integer
        Dim acceptedcount As Integer
        Dim declinedcount As Integer
        Dim freshCount As Integer
        Dim sophcount As Integer
        Dim junCount As Integer
        Dim senCount As Integer
        Dim gradCount As Integer
        Dim fifthCount As Integer

        pendingcount = callReportsCommand("pending")
        acceptedcount = callReportsCommand("accepted")
        declinedcount = callReportsCommand("declined")

        requestListBox.Items.Add(pendingcount & " - " & "Pending")
        requestListBox.Items.Add(acceptedcount & " - " & "Accepted")
        requestListBox.Items.Add(declinedcount & " - " & "Declined")

        freshCount = AccountByGradeCommand("Freshman")
        sophcount = AccountByGradeCommand("Sophomore")
        junCount = AccountByGradeCommand("Junior")
        senCount = AccountByGradeCommand("Senior")
        fifthCount = AccountByGradeCommand("5th Year Senior")
        gradCount = AccountByGradeCommand("Graduate Student")

        gradeLevelListBox.Items.Add(freshCount & " - " & "Freshman")
        gradeLevelListBox.Items.Add(sophcount & " - " & "Sophomores")
        gradeLevelListBox.Items.Add(junCount & " - " & "Juniors")
        gradeLevelListBox.Items.Add(senCount & " - " & "Seniors")
        gradeLevelListBox.Items.Add(fifthCount & " - " & "5th Year Seniors")
        gradeLevelListBox.Items.Add(gradCount & " - " & "Graduate Students")

        profileConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
        profileConnection.Open()

        findRequestCommand = New OleDbCommand
        findRequestCommand.Connection = profileConnection
        findRequestCommand.CommandText = "select top 1 requesthour from request group by requesthour order by count(*) desc"

        Dim hoursdatareader As String = findRequestCommand.ExecuteScalar

        timeTextBox.Text = hoursdatareader.ToString()

        profileConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
        profileConnection.Open()

        findRequestCommand = New OleDbCommand
        findRequestCommand.Connection = profileConnection
        findRequestCommand.CommandText = "select count(requestID) from request"

        Dim reportsDatareader As String = findRequestCommand.ExecuteScalar

        requestsTextBox.Text = reportsDatareader.ToString()

        profileConnection.Close()

        profileConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
        profileConnection.Open()

        findRequestCommand = New OleDbCommand
        findRequestCommand.Connection = profileConnection
        findRequestCommand.CommandText = "select count(userid) from useraccount"

        Dim accountsDataReader As String = findRequestCommand.ExecuteScalar

        accountsTextBox.Text = accountsDataReader.ToString()

        profileConnection.Close()

    End Sub

    Function callReportsCommand(ByVal reqstat As String) As Integer
        Dim x As Integer

        profileConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
        profileConnection.Open()

        findRequestCommand = New OleDbCommand
        findRequestCommand.Connection = profileConnection
        findRequestCommand.CommandText = "select requestStatus from request where requestStatus='" & reqstat & "'"

        Dim requestDatareader As OleDbDataReader = findRequestCommand.ExecuteReader

        Do While requestDatareader.Read()
            x += 1
        Loop

        Return x
        requestDatareader.Close()
    End Function

    Function AccountByGradeCommand(ByVal GradePerAccount As String) As Integer
        Dim x As Integer

        profileConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
        profileConnection.Open()

        findRequestCommand = New OleDbCommand
        findRequestCommand.Connection = profileConnection
        findRequestCommand.CommandText = "select gradelevel from useraccount where gradelevel='" & GradePerAccount & "'"

        Dim requestDatareader As OleDbDataReader = findRequestCommand.ExecuteReader

        Do While requestDatareader.Read()
            x += 1
        Loop

        requestDatareader.Close()
        Return x

    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ' Me.Hide()
        'Dim showLogin As New LoginForm
        'showLogin.ShowDialog()
        Application.Restart()
    End Sub
End Class

