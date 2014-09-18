<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profileForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(profileForm))
        Me.hourComboBox = New System.Windows.Forms.ComboBox()
        Me.dayComboBox = New System.Windows.Forms.ComboBox()
        Me.classComboBox = New System.Windows.Forms.ComboBox()
        Me.statusComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.declineButton = New System.Windows.Forms.Button()
        Me.acceptRequestButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.profileStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.profileToolStripProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.profileToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BecomeATutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestATutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BITHomepageLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FAQLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.BITvideoLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DSSflowLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.DSScheckLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OSMflowLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.OSMcheckLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ProfileListView = New System.Windows.Forms.ListView()
        Me.requestIDColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.userIDColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tutorColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.courseColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dayColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.timeColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rateColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.statusColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ShowAllCheckBox = New System.Windows.Forms.CheckBox()
        Me.backButton = New System.Windows.Forms.Button()
        Me.profileStatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'hourComboBox
        '
        Me.hourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hourComboBox.FormattingEnabled = True
        Me.hourComboBox.Items.AddRange(New Object() {"", "12am-1am", "1am-2am", "2am-3am", "3am-4am", "4am-5am", "5am-6am", "6am-7am", "7am-8am", "8am-9am", "9am-10am", "10am-11am", "11am-12pm", "12pm-1pm", "1pm-2pm", "2pm-3pm", "3pm-4pm", "4pm-5pm", "5pm-6pm", "6pm-7pm", "7pm-8pm", "8pm-9pm", "9pm-10pm", "10pm-11pm", "11pm-12pm"})
        Me.hourComboBox.Location = New System.Drawing.Point(460, 338)
        Me.hourComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.hourComboBox.Name = "hourComboBox"
        Me.hourComboBox.Size = New System.Drawing.Size(160, 24)
        Me.hourComboBox.TabIndex = 3
        '
        'dayComboBox
        '
        Me.dayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dayComboBox.FormattingEnabled = True
        Me.dayComboBox.Items.AddRange(New Object() {"", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.dayComboBox.Location = New System.Drawing.Point(460, 372)
        Me.dayComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.dayComboBox.Name = "dayComboBox"
        Me.dayComboBox.Size = New System.Drawing.Size(160, 24)
        Me.dayComboBox.TabIndex = 4
        '
        'classComboBox
        '
        Me.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.classComboBox.FormattingEnabled = True
        Me.classComboBox.Items.AddRange(New Object() {"", "BIT-3434", "BIT-3444", "BIT-4524", "BIT-4554"})
        Me.classComboBox.Location = New System.Drawing.Point(460, 271)
        Me.classComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.classComboBox.Name = "classComboBox"
        Me.classComboBox.Size = New System.Drawing.Size(160, 24)
        Me.classComboBox.TabIndex = 2
        '
        'statusComboBox
        '
        Me.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statusComboBox.FormattingEnabled = True
        Me.statusComboBox.Items.AddRange(New Object() {"", "Pending", "Accepted", "Declined "})
        Me.statusComboBox.Location = New System.Drawing.Point(459, 304)
        Me.statusComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.statusComboBox.Name = "statusComboBox"
        Me.statusComboBox.Size = New System.Drawing.Size(160, 24)
        Me.statusComboBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(341, 274)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Class"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(341, 342)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Hour"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(341, 375)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(340, 308)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Request Status "
        '
        'searchButton
        '
        Me.searchButton.ForeColor = System.Drawing.Color.Black
        Me.searchButton.Location = New System.Drawing.Point(660, 292)
        Me.searchButton.Margin = New System.Windows.Forms.Padding(4)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(144, 38)
        Me.searchButton.TabIndex = 6
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'declineButton
        '
        Me.declineButton.ForeColor = System.Drawing.Color.Black
        Me.declineButton.Location = New System.Drawing.Point(777, 690)
        Me.declineButton.Margin = New System.Windows.Forms.Padding(4)
        Me.declineButton.Name = "declineButton"
        Me.declineButton.Size = New System.Drawing.Size(144, 38)
        Me.declineButton.TabIndex = 9
        Me.declineButton.Text = "Decline "
        Me.declineButton.UseVisualStyleBackColor = True
        '
        'acceptRequestButton
        '
        Me.acceptRequestButton.ForeColor = System.Drawing.Color.Black
        Me.acceptRequestButton.Location = New System.Drawing.Point(593, 690)
        Me.acceptRequestButton.Margin = New System.Windows.Forms.Padding(4)
        Me.acceptRequestButton.Name = "acceptRequestButton"
        Me.acceptRequestButton.Size = New System.Drawing.Size(144, 38)
        Me.acceptRequestButton.TabIndex = 8
        Me.acceptRequestButton.Text = "Accept"
        Me.acceptRequestButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.ForeColor = System.Drawing.Color.Black
        Me.deleteButton.Location = New System.Drawing.Point(416, 690)
        Me.deleteButton.Margin = New System.Windows.Forms.Padding(4)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(144, 38)
        Me.deleteButton.TabIndex = 7
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'profileStatusStrip
        '
        Me.profileStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.profileToolStripProgressBar, Me.profileToolStripStatusLabel})
        Me.profileStatusStrip.Location = New System.Drawing.Point(0, 759)
        Me.profileStatusStrip.Name = "profileStatusStrip"
        Me.profileStatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.profileStatusStrip.Size = New System.Drawing.Size(1140, 26)
        Me.profileStatusStrip.TabIndex = 16
        Me.profileStatusStrip.Text = "StatusStrip1"
        Me.profileStatusStrip.UseWaitCursor = True
        '
        'profileToolStripProgressBar
        '
        Me.profileToolStripProgressBar.Name = "profileToolStripProgressBar"
        Me.profileToolStripProgressBar.Size = New System.Drawing.Size(133, 20)
        '
        'profileToolStripStatusLabel
        '
        Me.profileToolStripStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.profileToolStripStatusLabel.ForeColor = System.Drawing.Color.Black
        Me.profileToolStripStatusLabel.Name = "profileToolStripStatusLabel"
        Me.profileToolStripStatusLabel.Size = New System.Drawing.Size(72, 21)
        Me.profileToolStripStatusLabel.Text = "Loading..."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BecomeATutorToolStripMenuItem, Me.RequestATutorToolStripMenuItem, Me.AccountToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1140, 28)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BecomeATutorToolStripMenuItem
        '
        Me.BecomeATutorToolStripMenuItem.Name = "BecomeATutorToolStripMenuItem"
        Me.BecomeATutorToolStripMenuItem.Size = New System.Drawing.Size(128, 24)
        Me.BecomeATutorToolStripMenuItem.Text = "Become A Tutor"
        '
        'RequestATutorToolStripMenuItem
        '
        Me.RequestATutorToolStripMenuItem.Name = "RequestATutorToolStripMenuItem"
        Me.RequestATutorToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.RequestATutorToolStripMenuItem.Text = "Request A Tutor"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditAccountToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'EditAccountToolStripMenuItem
        '
        Me.EditAccountToolStripMenuItem.Name = "EditAccountToolStripMenuItem"
        Me.EditAccountToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.EditAccountToolStripMenuItem.Text = "Edit Account"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 44)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(1140, 30)
        Me.TextBox1.TabIndex = 18
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "User Profile"
        '
        'TextBox
        '
        Me.TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox.ForeColor = System.Drawing.Color.White
        Me.TextBox.Location = New System.Drawing.Point(291, 119)
        Me.TextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox.Multiline = True
        Me.TextBox.Name = "TextBox"
        Me.TextBox.ReadOnly = True
        Me.TextBox.Size = New System.Drawing.Size(553, 126)
        Me.TextBox.TabIndex = 19
        Me.TextBox.Text = resources.GetString("TextBox.Text")
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(221, -2)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(29, 761)
        Me.TextBox3.TabIndex = 20
        '
        'BITHomepageLinkLabel
        '
        Me.BITHomepageLinkLabel.AutoSize = True
        Me.BITHomepageLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BITHomepageLinkLabel.Location = New System.Drawing.Point(40, 43)
        Me.BITHomepageLinkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BITHomepageLinkLabel.Name = "BITHomepageLinkLabel"
        Me.BITHomepageLinkLabel.Size = New System.Drawing.Size(102, 17)
        Me.BITHomepageLinkLabel.TabIndex = 21
        Me.BITHomepageLinkLabel.TabStop = True
        Me.BITHomepageLinkLabel.Text = "BIT Homepage"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FAQLinkLabel)
        Me.GroupBox1.Controls.Add(Me.BITvideoLinkLabel)
        Me.GroupBox1.Controls.Add(Me.BITHomepageLinkLabel)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 102)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(191, 143)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Helpful Resources"
        '
        'FAQLinkLabel
        '
        Me.FAQLinkLabel.AutoSize = True
        Me.FAQLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FAQLinkLabel.Location = New System.Drawing.Point(72, 110)
        Me.FAQLinkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FAQLinkLabel.Name = "FAQLinkLabel"
        Me.FAQLinkLabel.Size = New System.Drawing.Size(36, 17)
        Me.FAQLinkLabel.TabIndex = 24
        Me.FAQLinkLabel.TabStop = True
        Me.FAQLinkLabel.Text = "FAQ"
        '
        'BITvideoLinkLabel
        '
        Me.BITvideoLinkLabel.AutoSize = True
        Me.BITvideoLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BITvideoLinkLabel.Location = New System.Drawing.Point(55, 76)
        Me.BITvideoLinkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BITvideoLinkLabel.Name = "BITvideoLinkLabel"
        Me.BITvideoLinkLabel.Size = New System.Drawing.Size(69, 17)
        Me.BITvideoLinkLabel.TabIndex = 23
        Me.BITvideoLinkLabel.TabStop = True
        Me.BITvideoLinkLabel.Text = "BIT Video"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DSSflowLinkLabel)
        Me.GroupBox2.Controls.Add(Me.DSScheckLinkLabel)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 274)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(191, 149)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Decision Support Systems (DSS)"
        '
        'DSSflowLinkLabel
        '
        Me.DSSflowLinkLabel.AutoSize = True
        Me.DSSflowLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DSSflowLinkLabel.Location = New System.Drawing.Point(41, 98)
        Me.DSSflowLinkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DSSflowLinkLabel.Name = "DSSflowLinkLabel"
        Me.DSSflowLinkLabel.Size = New System.Drawing.Size(100, 17)
        Me.DSSflowLinkLabel.TabIndex = 23
        Me.DSSflowLinkLabel.TabStop = True
        Me.DSSflowLinkLabel.Text = "DSS Flowchart"
        '
        'DSScheckLinkLabel
        '
        Me.DSScheckLinkLabel.AutoSize = True
        Me.DSScheckLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DSScheckLinkLabel.Location = New System.Drawing.Point(41, 64)
        Me.DSScheckLinkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DSScheckLinkLabel.Name = "DSScheckLinkLabel"
        Me.DSScheckLinkLabel.Size = New System.Drawing.Size(114, 17)
        Me.DSScheckLinkLabel.TabIndex = 21
        Me.DSScheckLinkLabel.TabStop = True
        Me.DSScheckLinkLabel.Text = "DSS Checksheet"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OSMflowLinkLabel)
        Me.GroupBox3.Controls.Add(Me.OSMcheckLinkLabel)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 462)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(191, 160)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operations and Supply Chain Mangaement (OSM)"
        '
        'OSMflowLinkLabel
        '
        Me.OSMflowLinkLabel.AutoSize = True
        Me.OSMflowLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.OSMflowLinkLabel.Location = New System.Drawing.Point(39, 106)
        Me.OSMflowLinkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OSMflowLinkLabel.Name = "OSMflowLinkLabel"
        Me.OSMflowLinkLabel.Size = New System.Drawing.Size(103, 17)
        Me.OSMflowLinkLabel.TabIndex = 23
        Me.OSMflowLinkLabel.TabStop = True
        Me.OSMflowLinkLabel.Text = "OSM Flowchart"
        '
        'OSMcheckLinkLabel
        '
        Me.OSMcheckLinkLabel.AutoSize = True
        Me.OSMcheckLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.OSMcheckLinkLabel.Location = New System.Drawing.Point(39, 70)
        Me.OSMcheckLinkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OSMcheckLinkLabel.Name = "OSMcheckLinkLabel"
        Me.OSMcheckLinkLabel.Size = New System.Drawing.Size(117, 17)
        Me.OSMcheckLinkLabel.TabIndex = 21
        Me.OSMcheckLinkLabel.TabStop = True
        Me.OSMcheckLinkLabel.Text = "OSM Checksheet"
        '
        'ProfileListView
        '
        Me.ProfileListView.CheckBoxes = True
        Me.ProfileListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.requestIDColumnHeader, Me.userIDColumnHeader, Me.tutorColumnHeader, Me.courseColumnHeader, Me.dayColumnHeader, Me.timeColumnHeader, Me.rateColumnHeader, Me.statusColumnHeader})
        Me.ProfileListView.Location = New System.Drawing.Point(258, 450)
        Me.ProfileListView.Margin = New System.Windows.Forms.Padding(4)
        Me.ProfileListView.MultiSelect = False
        Me.ProfileListView.Name = "ProfileListView"
        Me.ProfileListView.Size = New System.Drawing.Size(761, 211)
        Me.ProfileListView.TabIndex = 26
        Me.ProfileListView.UseCompatibleStateImageBehavior = False
        Me.ProfileListView.View = System.Windows.Forms.View.Details
        '
        'requestIDColumnHeader
        '
        Me.requestIDColumnHeader.Text = "requestID"
        Me.requestIDColumnHeader.Width = 81
        '
        'userIDColumnHeader
        '
        Me.userIDColumnHeader.Text = "userID"
        Me.userIDColumnHeader.Width = 127
        '
        'tutorColumnHeader
        '
        Me.tutorColumnHeader.Text = "TutorID"
        Me.tutorColumnHeader.Width = 91
        '
        'courseColumnHeader
        '
        Me.courseColumnHeader.Text = "Course"
        Me.courseColumnHeader.Width = 85
        '
        'dayColumnHeader
        '
        Me.dayColumnHeader.Text = "Day"
        Me.dayColumnHeader.Width = 96
        '
        'timeColumnHeader
        '
        Me.timeColumnHeader.Text = "Time"
        Me.timeColumnHeader.Width = 86
        '
        'rateColumnHeader
        '
        Me.rateColumnHeader.Text = "Rate"
        Me.rateColumnHeader.Width = 86
        '
        'statusColumnHeader
        '
        Me.statusColumnHeader.Text = "Status"
        Me.statusColumnHeader.Width = 97
        '
        'Timer1
        '
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(941, 188)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(4)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(27, 25)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(102, 123)
        Me.WebBrowser1.TabIndex = 27
        '
        'ShowAllCheckBox
        '
        Me.ShowAllCheckBox.AutoSize = True
        Me.ShowAllCheckBox.Location = New System.Drawing.Point(689, 354)
        Me.ShowAllCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ShowAllCheckBox.Name = "ShowAllCheckBox"
        Me.ShowAllCheckBox.Size = New System.Drawing.Size(83, 21)
        Me.ShowAllCheckBox.TabIndex = 28
        Me.ShowAllCheckBox.Text = "Show All"
        Me.ShowAllCheckBox.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.White
        Me.backButton.ForeColor = System.Drawing.Color.Black
        Me.backButton.Location = New System.Drawing.Point(416, 0)
        Me.backButton.Margin = New System.Windows.Forms.Padding(4)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(151, 28)
        Me.backButton.TabIndex = 29
        Me.backButton.Text = "Back to Profile"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'profileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1074, 587)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ProfileListView)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.profileStatusStrip)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.acceptRequestButton)
        Me.Controls.Add(Me.declineButton)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.statusComboBox)
        Me.Controls.Add(Me.classComboBox)
        Me.Controls.Add(Me.dayComboBox)
        Me.Controls.Add(Me.hourComboBox)
        Me.Controls.Add(Me.ShowAllCheckBox)
        Me.ForeColor = System.Drawing.Color.White
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "profileForm"
        Me.Text = "Profile"
        Me.profileStatusStrip.ResumeLayout(False)
        Me.profileStatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hourComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents dayComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents classComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents statusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents declineButton As System.Windows.Forms.Button
    Friend WithEvents acceptRequestButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents profileStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents profileToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents profileToolStripProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BecomeATutorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequestATutorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents BITHomepageLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FAQLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents BITvideoLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DSSflowLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents DSScheckLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OSMflowLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents OSMcheckLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents ProfileListView As System.Windows.Forms.ListView
    Friend WithEvents tutorColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents courseColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents dayColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents timeColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents rateColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents statusColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents requestIDColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents userIDColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents ShowAllCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents backButton As System.Windows.Forms.Button
End Class
