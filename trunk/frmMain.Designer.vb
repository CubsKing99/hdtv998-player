<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
    Me.lblCard = New System.Windows.Forms.Label()
    Me.btnInitialize = New System.Windows.Forms.Button()
    Me.dlgOpenFiles = New System.Windows.Forms.OpenFileDialog()
    Me.btnGetFilename = New System.Windows.Forms.Button()
    Me.lblChannel = New System.Windows.Forms.Label()
    Me.btnAssignChannel = New System.Windows.Forms.Button()
    Me.lblSkipPercent = New System.Windows.Forms.Label()
    Me.lblFFPercent = New System.Windows.Forms.Label()
    Me.btnSkipFwd = New System.Windows.Forms.Button()
    Me.btnFastFwd = New System.Windows.Forms.Button()
    Me.btnRewind = New System.Windows.Forms.Button()
    Me.btnSkipBack = New System.Windows.Forms.Button()
    Me.tmrProcessCallbackResults = New System.Windows.Forms.Timer(Me.components)
    Me.gbInitialization = New System.Windows.Forms.GroupBox()
    Me.nudCard = New System.Windows.Forms.NumericUpDown()
    Me.nudChannel = New System.Windows.Forms.NumericUpDown()
    Me.nudSubChannel = New System.Windows.Forms.NumericUpDown()
    Me.gbPlayback = New System.Windows.Forms.GroupBox()
    Me.btnPlay = New System.Windows.Forms.Button()
    Me.btnNextFile = New System.Windows.Forms.Button()
    Me.btnPause = New System.Windows.Forms.Button()
    Me.btnPreviousFile = New System.Windows.Forms.Button()
    Me.btnStop = New System.Windows.Forms.Button()
    Me.nudFFPercent = New System.Windows.Forms.NumericUpDown()
    Me.nudSkipPercent = New System.Windows.Forms.NumericUpDown()
    Me.gbPlaylist = New System.Windows.Forms.GroupBox()
    Me.chkRepeat = New System.Windows.Forms.CheckBox()
    Me.dgvFiles = New System.Windows.Forms.DataGridView()
    Me.dgcCheckbox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.dgcFileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.dgcStartPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.dgcEndPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnMoveDown = New System.Windows.Forms.Button()
    Me.btnMoveUp = New System.Windows.Forms.Button()
    Me.btnRemove = New System.Windows.Forms.Button()
    Me.btnAdd = New System.Windows.Forms.Button()
    Me.gbStatus = New System.Windows.Forms.GroupBox()
    Me.chkAbsolutePosition = New System.Windows.Forms.CheckBox()
    Me.progPlayback = New System.Windows.Forms.ProgressBar()
    Me.txtStatus = New System.Windows.Forms.TextBox()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.gbInitialization.SuspendLayout()
    CType(Me.nudCard, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudChannel, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudSubChannel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbPlayback.SuspendLayout()
    CType(Me.nudFFPercent, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudSkipPercent, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbPlaylist.SuspendLayout()
    CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbStatus.SuspendLayout()
    Me.SuspendLayout()
    '
    'lblCard
    '
    Me.lblCard.AutoSize = True
    Me.lblCard.Location = New System.Drawing.Point(9, 19)
    Me.lblCard.Name = "lblCard"
    Me.lblCard.Size = New System.Drawing.Size(29, 13)
    Me.lblCard.TabIndex = 0
    Me.lblCard.Text = "Card"
    '
    'btnInitialize
    '
    Me.btnInitialize.Location = New System.Drawing.Point(207, 14)
    Me.btnInitialize.Name = "btnInitialize"
    Me.btnInitialize.Size = New System.Drawing.Size(75, 23)
    Me.btnInitialize.TabIndex = 2
    Me.btnInitialize.Text = "Initialize"
    Me.btnInitialize.UseVisualStyleBackColor = True
    '
    'dlgOpenFiles
    '
    Me.dlgOpenFiles.Multiselect = True
    Me.dlgOpenFiles.SupportMultiDottedExtensions = True
    Me.dlgOpenFiles.Title = "Select File(s) to Play"
    '
    'btnGetFilename
    '
    Me.btnGetFilename.Location = New System.Drawing.Point(330, 83)
    Me.btnGetFilename.Name = "btnGetFilename"
    Me.btnGetFilename.Size = New System.Drawing.Size(90, 23)
    Me.btnGetFilename.TabIndex = 13
    Me.btnGetFilename.Text = "Curr. File Name"
    Me.btnGetFilename.UseVisualStyleBackColor = True
    '
    'lblChannel
    '
    Me.lblChannel.AutoSize = True
    Me.lblChannel.Location = New System.Drawing.Point(9, 48)
    Me.lblChannel.Name = "lblChannel"
    Me.lblChannel.Size = New System.Drawing.Size(46, 13)
    Me.lblChannel.TabIndex = 3
    Me.lblChannel.Text = "Channel"
    '
    'btnAssignChannel
    '
    Me.btnAssignChannel.Location = New System.Drawing.Point(207, 43)
    Me.btnAssignChannel.Name = "btnAssignChannel"
    Me.btnAssignChannel.Size = New System.Drawing.Size(75, 23)
    Me.btnAssignChannel.TabIndex = 6
    Me.btnAssignChannel.Text = "Assign"
    Me.btnAssignChannel.UseVisualStyleBackColor = True
    '
    'lblSkipPercent
    '
    Me.lblSkipPercent.AutoSize = True
    Me.lblSkipPercent.Location = New System.Drawing.Point(179, 59)
    Me.lblSkipPercent.Name = "lblSkipPercent"
    Me.lblSkipPercent.Size = New System.Drawing.Size(39, 13)
    Me.lblSkipPercent.TabIndex = 7
    Me.lblSkipPercent.Text = "Skip %"
    '
    'lblFFPercent
    '
    Me.lblFFPercent.AutoSize = True
    Me.lblFFPercent.Location = New System.Drawing.Point(6, 57)
    Me.lblFFPercent.Name = "lblFFPercent"
    Me.lblFFPercent.Size = New System.Drawing.Size(57, 13)
    Me.lblFFPercent.TabIndex = 5
    Me.lblFFPercent.Text = "FF/Rew %"
    '
    'btnSkipFwd
    '
    Me.btnSkipFwd.Location = New System.Drawing.Point(249, 83)
    Me.btnSkipFwd.Name = "btnSkipFwd"
    Me.btnSkipFwd.Size = New System.Drawing.Size(75, 23)
    Me.btnSkipFwd.TabIndex = 12
    Me.btnSkipFwd.Text = "Skip Fwd"
    Me.btnSkipFwd.UseVisualStyleBackColor = True
    '
    'btnFastFwd
    '
    Me.btnFastFwd.Location = New System.Drawing.Point(168, 83)
    Me.btnFastFwd.Name = "btnFastFwd"
    Me.btnFastFwd.Size = New System.Drawing.Size(75, 23)
    Me.btnFastFwd.TabIndex = 11
    Me.btnFastFwd.Text = "Fast Fwd"
    Me.btnFastFwd.UseVisualStyleBackColor = True
    '
    'btnRewind
    '
    Me.btnRewind.Location = New System.Drawing.Point(87, 83)
    Me.btnRewind.Name = "btnRewind"
    Me.btnRewind.Size = New System.Drawing.Size(75, 23)
    Me.btnRewind.TabIndex = 10
    Me.btnRewind.Text = "Rewind"
    Me.btnRewind.UseVisualStyleBackColor = True
    '
    'btnSkipBack
    '
    Me.btnSkipBack.Location = New System.Drawing.Point(6, 83)
    Me.btnSkipBack.Name = "btnSkipBack"
    Me.btnSkipBack.Size = New System.Drawing.Size(75, 23)
    Me.btnSkipBack.TabIndex = 9
    Me.btnSkipBack.Text = "Skip Back"
    Me.btnSkipBack.UseVisualStyleBackColor = True
    '
    'tmrProcessCallbackResults
    '
    Me.tmrProcessCallbackResults.Enabled = True
    '
    'gbInitialization
    '
    Me.gbInitialization.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbInitialization.Controls.Add(Me.btnInitialize)
    Me.gbInitialization.Controls.Add(Me.nudCard)
    Me.gbInitialization.Controls.Add(Me.lblCard)
    Me.gbInitialization.Controls.Add(Me.lblChannel)
    Me.gbInitialization.Controls.Add(Me.nudChannel)
    Me.gbInitialization.Controls.Add(Me.nudSubChannel)
    Me.gbInitialization.Controls.Add(Me.btnAssignChannel)
    Me.gbInitialization.Location = New System.Drawing.Point(12, 12)
    Me.gbInitialization.Name = "gbInitialization"
    Me.gbInitialization.Size = New System.Drawing.Size(459, 78)
    Me.gbInitialization.TabIndex = 0
    Me.gbInitialization.TabStop = False
    Me.gbInitialization.Text = "Initialization"
    '
    'nudCard
    '
    Me.nudCard.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Board_973.My.MySettings.Default, "dCard", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.nudCard.Location = New System.Drawing.Point(93, 19)
    Me.nudCard.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
    Me.nudCard.Name = "nudCard"
    Me.nudCard.Size = New System.Drawing.Size(51, 20)
    Me.nudCard.TabIndex = 1
    Me.nudCard.Value = Global.Board_973.My.MySettings.Default.dCard
    '
    'nudChannel
    '
    Me.nudChannel.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Board_973.My.MySettings.Default, "dChannel", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.nudChannel.Location = New System.Drawing.Point(93, 46)
    Me.nudChannel.Maximum = New Decimal(New Integer() {21, 0, 0, 0})
    Me.nudChannel.Minimum = New Decimal(New Integer() {14, 0, 0, 0})
    Me.nudChannel.Name = "nudChannel"
    Me.nudChannel.Size = New System.Drawing.Size(51, 20)
    Me.nudChannel.TabIndex = 4
    Me.nudChannel.Value = Global.Board_973.My.MySettings.Default.dChannel
    '
    'nudSubChannel
    '
    Me.nudSubChannel.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Board_973.My.MySettings.Default, "dSubChannel", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.nudSubChannel.Location = New System.Drawing.Point(148, 46)
    Me.nudSubChannel.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
    Me.nudSubChannel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nudSubChannel.Name = "nudSubChannel"
    Me.nudSubChannel.Size = New System.Drawing.Size(51, 20)
    Me.nudSubChannel.TabIndex = 5
    Me.nudSubChannel.Value = Global.Board_973.My.MySettings.Default.dSubChannel
    '
    'gbPlayback
    '
    Me.gbPlayback.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbPlayback.Controls.Add(Me.btnPlay)
    Me.gbPlayback.Controls.Add(Me.btnNextFile)
    Me.gbPlayback.Controls.Add(Me.btnPause)
    Me.gbPlayback.Controls.Add(Me.btnPreviousFile)
    Me.gbPlayback.Controls.Add(Me.btnStop)
    Me.gbPlayback.Controls.Add(Me.lblFFPercent)
    Me.gbPlayback.Controls.Add(Me.btnGetFilename)
    Me.gbPlayback.Controls.Add(Me.nudFFPercent)
    Me.gbPlayback.Controls.Add(Me.nudSkipPercent)
    Me.gbPlayback.Controls.Add(Me.btnSkipFwd)
    Me.gbPlayback.Controls.Add(Me.lblSkipPercent)
    Me.gbPlayback.Controls.Add(Me.btnFastFwd)
    Me.gbPlayback.Controls.Add(Me.btnSkipBack)
    Me.gbPlayback.Controls.Add(Me.btnRewind)
    Me.gbPlayback.Enabled = False
    Me.gbPlayback.Location = New System.Drawing.Point(12, 96)
    Me.gbPlayback.Name = "gbPlayback"
    Me.gbPlayback.Size = New System.Drawing.Size(459, 112)
    Me.gbPlayback.TabIndex = 1
    Me.gbPlayback.TabStop = False
    Me.gbPlayback.Text = "Playback Controls"
    '
    'btnPlay
    '
    Me.btnPlay.Location = New System.Drawing.Point(87, 19)
    Me.btnPlay.Name = "btnPlay"
    Me.btnPlay.Size = New System.Drawing.Size(75, 23)
    Me.btnPlay.TabIndex = 1
    Me.btnPlay.Text = "Play"
    Me.btnPlay.UseVisualStyleBackColor = True
    '
    'btnNextFile
    '
    Me.btnNextFile.Location = New System.Drawing.Point(330, 19)
    Me.btnNextFile.Name = "btnNextFile"
    Me.btnNextFile.Size = New System.Drawing.Size(69, 23)
    Me.btnNextFile.TabIndex = 4
    Me.btnNextFile.Text = "Next"
    Me.btnNextFile.UseVisualStyleBackColor = True
    '
    'btnPause
    '
    Me.btnPause.Location = New System.Drawing.Point(168, 19)
    Me.btnPause.Name = "btnPause"
    Me.btnPause.Size = New System.Drawing.Size(75, 23)
    Me.btnPause.TabIndex = 2
    Me.btnPause.Text = "Pause"
    Me.btnPause.UseVisualStyleBackColor = True
    '
    'btnPreviousFile
    '
    Me.btnPreviousFile.Location = New System.Drawing.Point(6, 19)
    Me.btnPreviousFile.Name = "btnPreviousFile"
    Me.btnPreviousFile.Size = New System.Drawing.Size(75, 23)
    Me.btnPreviousFile.TabIndex = 0
    Me.btnPreviousFile.Text = "Prev"
    Me.btnPreviousFile.UseVisualStyleBackColor = True
    '
    'btnStop
    '
    Me.btnStop.Location = New System.Drawing.Point(249, 19)
    Me.btnStop.Name = "btnStop"
    Me.btnStop.Size = New System.Drawing.Size(75, 23)
    Me.btnStop.TabIndex = 3
    Me.btnStop.Text = "Stop"
    Me.btnStop.UseVisualStyleBackColor = True
    '
    'nudFFPercent
    '
    Me.nudFFPercent.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Board_973.My.MySettings.Default, "dFFPercent", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.nudFFPercent.DecimalPlaces = 2
    Me.nudFFPercent.Location = New System.Drawing.Point(87, 57)
    Me.nudFFPercent.Maximum = New Decimal(New Integer() {999, 0, 0, 131072})
    Me.nudFFPercent.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
    Me.nudFFPercent.Name = "nudFFPercent"
    Me.nudFFPercent.Size = New System.Drawing.Size(49, 20)
    Me.nudFFPercent.TabIndex = 6
    Me.nudFFPercent.Value = Global.Board_973.My.MySettings.Default.dFFPercent
    '
    'nudSkipPercent
    '
    Me.nudSkipPercent.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Board_973.My.MySettings.Default, "dSkipPercent", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.nudSkipPercent.DecimalPlaces = 2
    Me.nudSkipPercent.Location = New System.Drawing.Point(248, 57)
    Me.nudSkipPercent.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
    Me.nudSkipPercent.Name = "nudSkipPercent"
    Me.nudSkipPercent.Size = New System.Drawing.Size(49, 20)
    Me.nudSkipPercent.TabIndex = 8
    Me.nudSkipPercent.Value = Global.Board_973.My.MySettings.Default.dSkipPercent
    '
    'gbPlaylist
    '
    Me.gbPlaylist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbPlaylist.Controls.Add(Me.chkRepeat)
    Me.gbPlaylist.Controls.Add(Me.dgvFiles)
    Me.gbPlaylist.Controls.Add(Me.btnMoveDown)
    Me.gbPlaylist.Controls.Add(Me.btnMoveUp)
    Me.gbPlaylist.Controls.Add(Me.btnRemove)
    Me.gbPlaylist.Controls.Add(Me.btnAdd)
    Me.gbPlaylist.Location = New System.Drawing.Point(12, 214)
    Me.gbPlaylist.Name = "gbPlaylist"
    Me.gbPlaylist.Size = New System.Drawing.Size(459, 173)
    Me.gbPlaylist.TabIndex = 2
    Me.gbPlaylist.TabStop = False
    Me.gbPlaylist.Text = "Playlist"
    '
    'chkRepeat
    '
    Me.chkRepeat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.chkRepeat.AutoSize = True
    Me.chkRepeat.Checked = Global.Board_973.My.MySettings.Default.bRepeat
    Me.chkRepeat.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Board_973.My.MySettings.Default, "bRepeat", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.chkRepeat.Location = New System.Drawing.Point(330, 148)
    Me.chkRepeat.Name = "chkRepeat"
    Me.chkRepeat.Size = New System.Drawing.Size(96, 17)
    Me.chkRepeat.TabIndex = 5
    Me.chkRepeat.Text = "Repeat Playlist"
    Me.chkRepeat.UseVisualStyleBackColor = True
    '
    'dgvFiles
    '
    Me.dgvFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvFiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgcCheckbox, Me.dgcFileName, Me.dgcStartPercent, Me.dgcEndPercent})
    Me.dgvFiles.Location = New System.Drawing.Point(9, 19)
    Me.dgvFiles.MultiSelect = False
    Me.dgvFiles.Name = "dgvFiles"
    Me.dgvFiles.RowHeadersVisible = False
    Me.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgvFiles.Size = New System.Drawing.Size(444, 119)
    Me.dgvFiles.TabIndex = 0
    '
    'dgcCheckbox
    '
    Me.dgcCheckbox.HeaderText = ""
    Me.dgcCheckbox.Name = "dgcCheckbox"
    Me.dgcCheckbox.Width = 20
    '
    'dgcFileName
    '
    Me.dgcFileName.HeaderText = "File Name"
    Me.dgcFileName.Name = "dgcFileName"
    Me.dgcFileName.ReadOnly = True
    Me.dgcFileName.Width = Global.Board_973.My.MySettings.Default.iFileNameColWidth
    '
    'dgcStartPercent
    '
    Me.dgcStartPercent.HeaderText = "Start %"
    Me.dgcStartPercent.MaxInputLength = 3
    Me.dgcStartPercent.Name = "dgcStartPercent"
    Me.dgcStartPercent.Width = 50
    '
    'dgcEndPercent
    '
    Me.dgcEndPercent.HeaderText = "End %"
    Me.dgcEndPercent.Name = "dgcEndPercent"
    Me.dgcEndPercent.Width = 50
    '
    'btnMoveDown
    '
    Me.btnMoveDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnMoveDown.Location = New System.Drawing.Point(249, 144)
    Me.btnMoveDown.Name = "btnMoveDown"
    Me.btnMoveDown.Size = New System.Drawing.Size(75, 23)
    Me.btnMoveDown.TabIndex = 4
    Me.btnMoveDown.Text = "Move Down"
    Me.btnMoveDown.UseVisualStyleBackColor = True
    '
    'btnMoveUp
    '
    Me.btnMoveUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnMoveUp.Location = New System.Drawing.Point(168, 144)
    Me.btnMoveUp.Name = "btnMoveUp"
    Me.btnMoveUp.Size = New System.Drawing.Size(75, 23)
    Me.btnMoveUp.TabIndex = 3
    Me.btnMoveUp.Text = "Move Up"
    Me.btnMoveUp.UseVisualStyleBackColor = True
    '
    'btnRemove
    '
    Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnRemove.Location = New System.Drawing.Point(87, 144)
    Me.btnRemove.Name = "btnRemove"
    Me.btnRemove.Size = New System.Drawing.Size(75, 23)
    Me.btnRemove.TabIndex = 2
    Me.btnRemove.Text = "Remove"
    Me.btnRemove.UseVisualStyleBackColor = True
    '
    'btnAdd
    '
    Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAdd.Location = New System.Drawing.Point(6, 144)
    Me.btnAdd.Name = "btnAdd"
    Me.btnAdd.Size = New System.Drawing.Size(75, 23)
    Me.btnAdd.TabIndex = 1
    Me.btnAdd.Text = "Add"
    Me.btnAdd.UseVisualStyleBackColor = True
    '
    'gbStatus
    '
    Me.gbStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbStatus.Controls.Add(Me.chkAbsolutePosition)
    Me.gbStatus.Controls.Add(Me.progPlayback)
    Me.gbStatus.Controls.Add(Me.txtStatus)
    Me.gbStatus.Location = New System.Drawing.Point(12, 393)
    Me.gbStatus.Name = "gbStatus"
    Me.gbStatus.Size = New System.Drawing.Size(459, 130)
    Me.gbStatus.TabIndex = 3
    Me.gbStatus.TabStop = False
    Me.gbStatus.Text = "Status"
    '
    'chkAbsolutePosition
    '
    Me.chkAbsolutePosition.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.chkAbsolutePosition.AutoSize = True
    Me.chkAbsolutePosition.Checked = Global.Board_973.My.MySettings.Default.bAbsolutePosition
    Me.chkAbsolutePosition.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Board_973.My.MySettings.Default, "bAbsolutePosition", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.chkAbsolutePosition.Location = New System.Drawing.Point(6, 83)
    Me.chkAbsolutePosition.Name = "chkAbsolutePosition"
    Me.chkAbsolutePosition.Size = New System.Drawing.Size(204, 17)
    Me.chkAbsolutePosition.TabIndex = 1
    Me.chkAbsolutePosition.Text = "Show Absolute Current Position in File"
    Me.chkAbsolutePosition.UseVisualStyleBackColor = True
    Me.chkAbsolutePosition.Visible = False
    '
    'progPlayback
    '
    Me.progPlayback.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.progPlayback.Location = New System.Drawing.Point(3, 106)
    Me.progPlayback.Name = "progPlayback"
    Me.progPlayback.Size = New System.Drawing.Size(452, 23)
    Me.progPlayback.Step = 1
    Me.progPlayback.TabIndex = 2
    Me.progPlayback.Visible = False
    '
    'txtStatus
    '
    Me.txtStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtStatus.Location = New System.Drawing.Point(9, 19)
    Me.txtStatus.Multiline = True
    Me.txtStatus.Name = "txtStatus"
    Me.txtStatus.ReadOnly = True
    Me.txtStatus.Size = New System.Drawing.Size(444, 60)
    Me.txtStatus.TabIndex = 0
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "File Name"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewTextBoxColumn1.Width = Global.Board_973.My.MySettings.Default.iFileNameColWidth
    '
    'frmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(483, 535)
    Me.Controls.Add(Me.gbStatus)
    Me.Controls.Add(Me.gbPlaylist)
    Me.Controls.Add(Me.gbPlayback)
    Me.Controls.Add(Me.gbInitialization)
    Me.Name = "frmMain"
    Me.Text = "HDTV998 Control App"
    Me.gbInitialization.ResumeLayout(False)
    Me.gbInitialization.PerformLayout()
    CType(Me.nudCard, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudChannel, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudSubChannel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbPlayback.ResumeLayout(False)
    Me.gbPlayback.PerformLayout()
    CType(Me.nudFFPercent, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudSkipPercent, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbPlaylist.ResumeLayout(False)
    Me.gbPlaylist.PerformLayout()
    CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbStatus.ResumeLayout(False)
    Me.gbStatus.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents nudCard As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblCard As System.Windows.Forms.Label
  Friend WithEvents btnInitialize As System.Windows.Forms.Button
  Friend WithEvents dlgOpenFiles As System.Windows.Forms.OpenFileDialog
  Friend WithEvents btnGetFilename As System.Windows.Forms.Button
  Friend WithEvents nudChannel As System.Windows.Forms.NumericUpDown
  Friend WithEvents nudSubChannel As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblChannel As System.Windows.Forms.Label
  Friend WithEvents btnAssignChannel As System.Windows.Forms.Button
  Friend WithEvents lblSkipPercent As System.Windows.Forms.Label
  Friend WithEvents lblFFPercent As System.Windows.Forms.Label
  Friend WithEvents nudSkipPercent As System.Windows.Forms.NumericUpDown
  Friend WithEvents nudFFPercent As System.Windows.Forms.NumericUpDown
  Friend WithEvents btnSkipFwd As System.Windows.Forms.Button
  Friend WithEvents btnFastFwd As System.Windows.Forms.Button
  Friend WithEvents btnRewind As System.Windows.Forms.Button
  Friend WithEvents btnSkipBack As System.Windows.Forms.Button
  Friend WithEvents tmrProcessCallbackResults As System.Windows.Forms.Timer
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents gbInitialization As System.Windows.Forms.GroupBox
  Friend WithEvents gbPlayback As System.Windows.Forms.GroupBox
  Friend WithEvents gbPlaylist As System.Windows.Forms.GroupBox
  Friend WithEvents dgvFiles As System.Windows.Forms.DataGridView
  Friend WithEvents dgcCheckbox As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents dgcFileName As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents dgcStartPercent As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents dgcEndPercent As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnMoveDown As System.Windows.Forms.Button
  Friend WithEvents btnMoveUp As System.Windows.Forms.Button
  Friend WithEvents btnRemove As System.Windows.Forms.Button
  Friend WithEvents btnAdd As System.Windows.Forms.Button
  Friend WithEvents gbStatus As System.Windows.Forms.GroupBox
  Friend WithEvents chkRepeat As System.Windows.Forms.CheckBox
  Friend WithEvents chkAbsolutePosition As System.Windows.Forms.CheckBox
  Friend WithEvents progPlayback As System.Windows.Forms.ProgressBar
  Friend WithEvents txtStatus As System.Windows.Forms.TextBox
  Friend WithEvents btnPlay As System.Windows.Forms.Button
  Friend WithEvents btnNextFile As System.Windows.Forms.Button
  Friend WithEvents btnPause As System.Windows.Forms.Button
  Friend WithEvents btnPreviousFile As System.Windows.Forms.Button
  Friend WithEvents btnStop As System.Windows.Forms.Button

End Class
