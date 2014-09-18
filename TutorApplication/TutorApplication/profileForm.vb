Imports System.Data.OleDb
Public Class profileForm
    Dim profileConnection As OleDbConnection
    Dim findRequestCommand As OleDbCommand

    Private Sub profileForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        backButton.Hide()

        TextBox1.Width = Me.Width

        WebBrowser1.Hide()
        profileToolStripStatusLabel.Text = "Ready to Load website..."
        Timer1.Stop()

        populateProfile("userID")
        populateProfile("tutorUserID")

    End Sub
    Private Sub acceptRequestButton_Click(sender As System.Object, e As System.EventArgs) Handles acceptRequestButton.Click

        If ProfileListView.CheckedItems.Count > 0 And ProfileListView.CheckedItems.Count < 2 Then
            If ProfileListView.Items(ProfileListView.CheckedIndices(0)).SubItems(2).Text = LoginForm.userName Then
                Dim selectedRequest As Integer = ProfileListView.CheckedItems(0).Text
                profileConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
                profileConnection.Open()

                findRequestCommand = New OleDbCommand
                findRequestCommand.Connection = profileConnection
                findRequestCommand.CommandText = "update request SET requestStatus='Accepted' where requestID=" & selectedRequest & ""

                Dim profileDataReader As String = findRequestCommand.ExecuteNonQuery()

                MsgBox("Request Accepted!")

                ProfileListView.Items.Clear()
                populateProfile("userID")
                populateProfile("tutorUserID")

            Else
                MsgBox("You can only accept a request if you are the tutor.")
            End If

        Else
            MsgBox("Please select one meeting.")
        End If
    End Sub
    Private Sub declineButton_Click(sender As System.Object, e As System.EventArgs) Handles declineButton.Click
        If ProfileListView.CheckedItems.Count > 0 And ProfileListView.CheckedItems.Count < 2 Then
            If ProfileListView.Items(ProfileListView.CheckedIndices(0)).SubItems(2).Text = LoginForm.userName Then
                Dim selectedRequest As Integer = ProfileListView.CheckedItems(0).Text
                profileConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
                profileConnection.Open()

                findRequestCommand = New OleDbCommand
                findRequestCommand.Connection = profileConnection
                findRequestCommand.CommandText = "update request SET requestStatus='Declined' where requestID=" & selectedRequest & ""

                Dim profileDataReader As String = findRequestCommand.ExecuteNonQuery()

                MsgBox("Request Declined")

                ProfileListView.Items.Clear()
                populateProfile("userID")
                populateProfile("tutorUserID")

                'refresh page 
            Else
                MsgBox("You can only decline a request if you are the tutor.")
            End If
        Else
            MsgBox("Please select one meeting.")
        End If

    End Sub


    Private Sub BecomeATutorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BecomeATutorToolStripMenuItem.Click
        Me.Hide()
        Dim showBecomeTutor As New becomeTutorForm
        showBecomeTutor.ShowDialog()
    End Sub

    Private Sub RequestATutorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RequestATutorToolStripMenuItem.Click
        Me.Hide()
        Dim showRequestTutorForm As New requestTutorForm
        showRequestTutorForm.ShowDialog()
    End Sub

    Private Sub EditAccountToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditAccountToolStripMenuItem.Click
        Me.Hide()
        Dim showEditForm As New EditForm
        showEditForm.ShowDialog()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        ' Me.Hide()
        'Dim showLoginForm As New LoginForm
        'showLoginForm.ShowDialog()
        'LoginForm.userName = ""
        Application.Restart()
    End Sub

    Private Sub BITHomepageLinkLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles BITHomepageLinkLabel.LinkClicked
        backButton.Show()
        WebBrowser1.Show()
        WebBrowser1.Dock = DockStyle.Fill
        WebBrowser1.Navigate("www.bit.vt.edu")
        profileToolStripProgressBar.Value = 0
        Timer1.Start()
    End Sub

    Private Sub BITvideoLinkLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles BITvideoLinkLabel.LinkClicked
        backButton.Show()
        WebBrowser1.Show()
        WebBrowser1.Dock = DockStyle.Fill
        WebBrowser1.Navigate("www.youtube.com/watch?v=SDAP7Q2BM0Q")
        profileToolStripProgressBar.Value = 0
        Timer1.Start()
    End Sub

    Private Sub FAQLinkLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles FAQLinkLabel.LinkClicked
        backButton.Show()
        WebBrowser1.Show()
        WebBrowser1.Dock = DockStyle.Fill
        WebBrowser1.Navigate("www.bit.vt.edu/FAQ")
        profileToolStripProgressBar.Value = 0
        Timer1.Start()
    End Sub

    Private Sub DSScheckLinkLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DSScheckLinkLabel.LinkClicked
        backButton.Show()
        WebBrowser1.Show()
        WebBrowser1.Dock = DockStyle.Fill
        WebBrowser1.Navigate("www.bit.vt.edu/academics/check_flow.html")
        profileToolStripProgressBar.Value = 0
        Timer1.Start()
    End Sub

    Private Sub DSSflowLinkLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DSSflowLinkLabel.LinkClicked
        backButton.Show()
        WebBrowser1.Show()
        WebBrowser1.Dock = DockStyle.Fill
        WebBrowser1.Navigate("www.bit.vt.edu/academics/check_flow.html")
        profileToolStripProgressBar.Value = 0
        Timer1.Start()
    End Sub

    Private Sub OSMcheckLinkLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles OSMcheckLinkLabel.LinkClicked
        backButton.Show()
        WebBrowser1.Show()
        WebBrowser1.Dock = DockStyle.Fill
        WebBrowser1.Navigate("www.bit.vt.edu/academics/check_flow.html")
        profileToolStripProgressBar.Value = 0
        Timer1.Start()
    End Sub

    Private Sub OSMflowLinkLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles OSMflowLinkLabel.LinkClicked
        backButton.Show()
        WebBrowser1.Show()
        WebBrowser1.Dock = DockStyle.Fill
        WebBrowser1.Navigate("www.bit.vt.edu/academics/check_flow.html")
        profileToolStripProgressBar.Value = 0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        profileToolStripProgressBar.Value = profileToolStripProgressBar.Value + 10
        profileToolStripStatusLabel.Text = "Loading..."

        If profileToolStripProgressBar.Value = 100 Then
            profileToolStripStatusLabel.Text = "Done"
            Timer1.Stop()
        End If

    End Sub

    Private Sub populateProfile(ByVal populateBy As String)
        profileConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
        profileConnection.Open()

        findRequestCommand = New OleDbCommand
        findRequestCommand.Connection = profileConnection
        findRequestCommand.CommandText = "select * from request where " & populateBy & "='" & LoginForm.userName & "'"

        Dim profileDoCommand As OleDbDataReader = findRequestCommand.ExecuteReader

        Do While profileDoCommand.Read()
            Dim item1 As New ListViewItem(profileDoCommand.GetValue(0).ToString)
            item1.SubItems.Add(profileDoCommand.GetValue(1))
            item1.SubItems.Add(profileDoCommand.GetValue(2))
            item1.SubItems.Add(profileDoCommand.GetValue(3))
            item1.SubItems.Add(profileDoCommand.GetValue(4))
            item1.SubItems.Add(profileDoCommand.GetValue(5))
            item1.SubItems.Add(profileDoCommand.GetValue(7))
            item1.SubItems.Add(profileDoCommand.GetValue(6))
            ProfileListView.Items.AddRange(New ListViewItem() {item1})
        Loop
        profileDoCommand.Close()
    End Sub

    Private Sub deleteButton_Click(sender As System.Object, e As System.EventArgs) Handles deleteButton.Click
        If ProfileListView.CheckedItems.Count > 0 And ProfileListView.CheckedItems.Count < 2 Then
            If ProfileListView.Items(ProfileListView.CheckedIndices(0)).SubItems(1).Text = LoginForm.userName Then
                Dim x As Integer = ProfileListView.CheckedItems(0).Text

                profileConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
                profileConnection.Open()

                findRequestCommand = New OleDbCommand
                findRequestCommand.Connection = profileConnection
                findRequestCommand.CommandText = "delete from request where requestID=" & x & ""

                Dim pwdDoCommand As Integer = findRequestCommand.ExecuteNonQuery

                MsgBox("Request successfully deleted")

                ProfileListView.Items.Clear()
                populateProfile("userID")
                populateProfile("tutorUserID")
            Else
                MsgBox("You can only delete requests if you are the student.")
            End If
        Else
            MsgBox("Please select one meeting.")
        End If


    End Sub

    Private Sub searchButton_Click(sender As System.Object, e As System.EventArgs) Handles searchButton.Click
        ProfileListView.Items.Clear()

        If ShowAllCheckBox.Checked = True Then
            populateProfile("userID")
            populateProfile("tutorUserID")
            Exit Sub
        End If

        Dim selectedRequestStatus As String = "" 'requestStatus
        Dim selectedClass As String = "" 'requestClass
        Dim selectedHours As String = "" 'requestHour
        Dim selectedDay As String = "" 'requestday

        If classComboBox.Text = "" And statusComboBox.Text = "" And hourComboBox.Text = "" And dayComboBox.Text = "" Then
            MsgBox("Please select criteria to search.")
            Exit Sub
        Else
            If Not classComboBox.Text = "" Then
                selectedClass = ("requestClass='" & classComboBox.Text & "'")
            End If

            If Not statusComboBox.Text = "" Then
                If classComboBox.Text = "" Then
                    selectedRequestStatus = ("requestStatus='" & statusComboBox.Text & "'")
                Else
                    selectedRequestStatus = (" and requestStatus='" & statusComboBox.Text & "'")
                End If
            End If

            If Not hourComboBox.Text = "" Then
                If classComboBox.Text = "" And statusComboBox.Text = "" Then
                    selectedHours = ("requestHour='" & hourComboBox.Text & "'")
                Else
                    selectedHours = (" and requestHour='" & hourComboBox.Text & "'")
                End If

            End If

            If Not dayComboBox.Text = "" Then
                If classComboBox.Text = "" And statusComboBox.Text = "" And hourComboBox.Text = "" Then
                    selectedDay = ("requestDay='" & dayComboBox.Text & "'")
                Else
                    selectedDay = (" and requestDay='" & dayComboBox.Text & "'")
                End If

            End If
        End If

        searchable("userID", selectedRequestStatus, selectedClass, selectedHours, selectedDay)
        searchable("tutorUserID", selectedRequestStatus, selectedClass, selectedHours, selectedDay)
    End Sub
    Private Sub searchable(ByVal populateby As String, ByVal selectedRequestStatus As String, ByVal selectedClass As String, ByVal selectedHours As String, ByVal selectedDay As String)
        profileConnection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & Application.StartupPath & "/tutorDatabase.accdb")
        profileConnection.Open()

        findRequestCommand = New OleDbCommand
        findRequestCommand.Connection = profileConnection
        findRequestCommand.CommandText = "select * from request where(" & selectedClass & selectedRequestStatus & selectedHours & selectedDay & " AND " & populateby & "='" & LoginForm.userName & "')"

        Dim profileDoCommand As OleDbDataReader = findRequestCommand.ExecuteReader

        Do While profileDoCommand.Read()
            Dim item1 As New ListViewItem(profileDoCommand.GetValue(0).ToString)
            item1.SubItems.Add(profileDoCommand.GetValue(1))
            item1.SubItems.Add(profileDoCommand.GetValue(2))
            item1.SubItems.Add(profileDoCommand.GetValue(3))
            item1.SubItems.Add(profileDoCommand.GetValue(4))
            item1.SubItems.Add(profileDoCommand.GetValue(5))
            item1.SubItems.Add(profileDoCommand.GetValue(7))
            item1.SubItems.Add(profileDoCommand.GetValue(6))
            ProfileListView.Items.AddRange(New ListViewItem() {item1})
        Loop
        profileDoCommand.Close()
    End Sub

    Private Sub backButton_Click(sender As System.Object, e As System.EventArgs) Handles backButton.Click
        WebBrowser1.Hide()
        backButton.Hide()
    End Sub


End Class

