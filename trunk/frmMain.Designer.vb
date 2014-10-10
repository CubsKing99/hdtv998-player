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
    Me.lblStatus = New System.Windows.Forms.Label()
    Me.txtStatus = New System.Windows.Forms.TextBox()
    Me.dlgOpenFiles = New System.Windows.Forms.OpenFileDialog()
    Me.btnPlay = New System.Windows.Forms.Button()
    Me.btnPause = New System.Windows.Forms.Button()
    Me.btnStop = New System.Windows.Forms.Button()
    Me.btnAdd = New System.Windows.Forms.Button()
    Me.btnRemove = New System.Windows.Forms.Button()
    Me.btnMoveUp = New System.Windows.Forms.Button()
    Me.btnMoveDown = New System.Windows.Forms.Button()
    Me.btnGetFilename = New System.Windows.Forms.Button()
    Me.lblChannel = New System.Windows.Forms.Label()
    Me.btnAssignChannel = New System.Windows.Forms.Button()
    Me.dgvFiles = New System.Windows.Forms.DataGridView()
    Me.dgcCheckbox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.dgcFileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.dgcStartPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.dgcEndPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.lblSkipPercent = New System.Windows.Forms.Label()
    Me.lblFFPercent = New System.Windows.Forms.Label()
    Me.btnSkipFwd = New System.Windows.Forms.Button()
    Me.btnFastFwd = New System.Windows.Forms.Button()
    Me.btnRewind = New System.Windows.Forms.Button()
    Me.btnSkipBack = New System.Windows.Forms.Button()
    Me.progPlayback = New System.Windows.Forms.ProgressBar()
    Me.tmrProcessCallbackResults = New System.Windows.Forms.Timer(Me.components)
    Me.chkRepeat = New System.Windows.Forms.CheckBox()
    Me.chkAbsolutePosition = New System.Windows.Forms.CheckBox()
    Me.nudSkipPercent = New System.Windows.Forms.NumericUpDown()
    Me.nudFFPercent = New System.Windows.Forms.NumericUpDown()
    Me.nudSubChannel = New System.Windows.Forms.NumericUpDown()
    Me.nudChannel = New System.Windows.Forms.NumericUpDown()
    Me.nudCard = New System.Windows.Forms.NumericUpDown()
    CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudSkipPercent, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudFFPercent, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudSubChannel, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudChannel, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudCard, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblCard
    '
    Me.lblCard.AutoSize = True
    Me.lblCard.Location = New System.Drawing.Point(12, 14)
    Me.lblCard.Name = "lblCard"
    Me.lblCard.Size = New System.Drawing.Size(29, 13)
    Me.lblCard.TabIndex = 0
    Me.lblCard.Text = "Card"
    '
    'btnInitialize
    '
    Me.btnInitialize.Location = New System.Drawing.Point(210, 9)
    Me.btnInitialize.Name = "btnInitialize"
    Me.btnInitialize.Size = New System.Drawing.Size(75, 23)
    Me.btnInitialize.TabIndex = 2
    Me.btnInitialize.Text = "Initialize"
    Me.btnInitialize.UseVisualStyleBackColor = True
    '
    'lblStatus
    '
    Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblStatus.AutoSize = True
    Me.lblStatus.Location = New System.Drawing.Point(15, 317)
    Me.lblStatus.Name = "lblStatus"
    Me.lblStatus.Size = New System.Drawing.Size(37, 13)
    Me.lblStatus.TabIndex = 24
    Me.lblStatus.Text = "Status"
    '
    'txtStatus
    '
    Me.txtStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtStatus.Location = New System.Drawing.Point(75, 317)
    Me.txtStatus.Multiline = True
    Me.txtStatus.Name = "txtStatus"
    Me.txtStatus.ReadOnly = True
    Me.txtStatus.Size = New System.Drawing.Size(272, 77)
    Me.txtStatus.TabIndex = 25
    '
    'dlgOpenFiles
    '
    Me.dlgOpenFiles.Multiselect = True
    Me.dlgOpenFiles.SupportMultiDottedExtensions = True
    Me.dlgOpenFiles.Title = "Select File(s) to Play"
    '
    'btnPlay
    '
    Me.btnPlay.Location = New System.Drawing.Point(15, 132)
    Me.btnPlay.Name = "btnPlay"
    Me.btnPlay.Size = New System.Drawing.Size(75, 23)
    Me.btnPlay.TabIndex = 15
    Me.btnPlay.Text = "Play"
    Me.btnPlay.UseVisualStyleBackColor = True
    '
    'btnPause
    '
    Me.btnPause.Location = New System.Drawing.Point(96, 132)
    Me.btnPause.Name = "btnPause"
    Me.btnPause.Size = New System.Drawing.Size(75, 23)
    Me.btnPause.TabIndex = 16
    Me.btnPause.Text = "Pause"
    Me.btnPause.UseVisualStyleBackColor = True
    '
    'btnStop
    '
    Me.btnStop.Location = New System.Drawing.Point(176, 132)
    Me.btnStop.Name = "btnStop"
    Me.btnStop.Size = New System.Drawing.Size(75, 23)
    Me.btnStop.TabIndex = 17
    Me.btnStop.Text = "Stop"
    Me.btnStop.UseVisualStyleBackColor = True
    '
    'btnAdd
    '
    Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAdd.Location = New System.Drawing.Point(12, 288)
    Me.btnAdd.Name = "btnAdd"
    Me.btnAdd.Size = New System.Drawing.Size(75, 23)
    Me.btnAdd.TabIndex = 20
    Me.btnAdd.Text = "Add"
    Me.btnAdd.UseVisualStyleBackColor = True
    '
    'btnRemove
    '
    Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnRemove.Location = New System.Drawing.Point(93, 288)
    Me.btnRemove.Name = "btnRemove"
    Me.btnRemove.Size = New System.Drawing.Size(75, 23)
    Me.btnRemove.TabIndex = 21
    Me.btnRemove.Text = "Remove"
    Me.btnRemove.UseVisualStyleBackColor = True
    '
    'btnMoveUp
    '
    Me.btnMoveUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnMoveUp.Location = New System.Drawing.Point(176, 288)
    Me.btnMoveUp.Name = "btnMoveUp"
    Me.btnMoveUp.Size = New System.Drawing.Size(75, 23)
    Me.btnMoveUp.TabIndex = 22
    Me.btnMoveUp.Text = "Move Up"
    Me.btnMoveUp.UseVisualStyleBackColor = True
    '
    'btnMoveDown
    '
    Me.btnMoveDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnMoveDown.Location = New System.Drawing.Point(257, 288)
    Me.btnMoveDown.Name = "btnMoveDown"
    Me.btnMoveDown.Size = New System.Drawing.Size(75, 23)
    Me.btnMoveDown.TabIndex = 23
    Me.btnMoveDown.Text = "Move Down"
    Me.btnMoveDown.UseVisualStyleBackColor = True
    '
    'btnGetFilename
    '
    Me.btnGetFilename.Location = New System.Drawing.Point(257, 132)
    Me.btnGetFilename.Name = "btnGetFilename"
    Me.btnGetFilename.Size = New System.Drawing.Size(90, 23)
    Me.btnGetFilename.TabIndex = 18
    Me.btnGetFilename.Text = "Get Filename"
    Me.btnGetFilename.UseVisualStyleBackColor = True
    '
    'lblChannel
    '
    Me.lblChannel.AutoSize = True
    Me.lblChannel.Location = New System.Drawing.Point(12, 49)
    Me.lblChannel.Name = "lblChannel"
    Me.lblChannel.Size = New System.Drawing.Size(46, 13)
    Me.lblChannel.TabIndex = 3
    Me.lblChannel.Text = "Channel"
    '
    'btnAssignChannel
    '
    Me.btnAssignChannel.Location = New System.Drawing.Point(210, 44)
    Me.btnAssignChannel.Name = "btnAssignChannel"
    Me.btnAssignChannel.Size = New System.Drawing.Size(75, 23)
    Me.btnAssignChannel.TabIndex = 6
    Me.btnAssignChannel.Text = "Assign"
    Me.btnAssignChannel.UseVisualStyleBackColor = True
    '
    'dgvFiles
    '
    Me.dgvFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvFiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgcCheckbox, Me.dgcFileName, Me.dgcStartPercent, Me.dgcEndPercent})
    Me.dgvFiles.Location = New System.Drawing.Point(15, 161)
    Me.dgvFiles.MultiSelect = False
    Me.dgvFiles.Name = "dgvFiles"
    Me.dgvFiles.RowHeadersVisible = False
    Me.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgvFiles.Size = New System.Drawing.Size(332, 121)
    Me.dgvFiles.TabIndex = 19
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
    Me.dgcFileName.Width = 190
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
    'lblSkipPercent
    '
    Me.lblSkipPercent.AutoSize = True
    Me.lblSkipPercent.Location = New System.Drawing.Point(188, 79)
    Me.lblSkipPercent.Name = "lblSkipPercent"
    Me.lblSkipPercent.Size = New System.Drawing.Size(39, 13)
    Me.lblSkipPercent.TabIndex = 9
    Me.lblSkipPercent.Text = "Skip %"
    '
    'lblFFPercent
    '
    Me.lblFFPercent.AutoSize = True
    Me.lblFFPercent.Location = New System.Drawing.Point(15, 77)
    Me.lblFFPercent.Name = "lblFFPercent"
    Me.lblFFPercent.Size = New System.Drawing.Size(57, 13)
    Me.lblFFPercent.TabIndex = 7
    Me.lblFFPercent.Text = "FF/Rew %"
    '
    'btnSkipFwd
    '
    Me.btnSkipFwd.Location = New System.Drawing.Point(257, 103)
    Me.btnSkipFwd.Name = "btnSkipFwd"
    Me.btnSkipFwd.Size = New System.Drawing.Size(75, 23)
    Me.btnSkipFwd.TabIndex = 14
    Me.btnSkipFwd.Text = "Skip Fwd"
    Me.btnSkipFwd.UseVisualStyleBackColor = True
    '
    'btnFastFwd
    '
    Me.btnFastFwd.Location = New System.Drawing.Point(176, 103)
    Me.btnFastFwd.Name = "btnFastFwd"
    Me.btnFastFwd.Size = New System.Drawing.Size(75, 23)
    Me.btnFastFwd.TabIndex = 13
    Me.btnFastFwd.Text = "Fast Fwd"
    Me.btnFastFwd.UseVisualStyleBackColor = True
    '
    'btnRewind
    '
    Me.btnRewind.Location = New System.Drawing.Point(96, 103)
    Me.btnRewind.Name = "btnRewind"
    Me.btnRewind.Size = New System.Drawing.Size(75, 23)
    Me.btnRewind.TabIndex = 12
    Me.btnRewind.Text = "Rewind"
    Me.btnRewind.UseVisualStyleBackColor = True
    '
    'btnSkipBack
    '
    Me.btnSkipBack.Location = New System.Drawing.Point(15, 103)
    Me.btnSkipBack.Name = "btnSkipBack"
    Me.btnSkipBack.Size = New System.Drawing.Size(75, 23)
    Me.btnSkipBack.TabIndex = 11
    Me.btnSkipBack.Text = "Skip Back"
    Me.btnSkipBack.UseVisualStyleBackColor = True
    '
    'progPlayback
    '
    Me.progPlayback.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.progPlayback.Location = New System.Drawing.Point(15, 421)
    Me.progPlayback.Name = "progPlayback"
    Me.progPlayback.Size = New System.Drawing.Size(366, 23)
    Me.progPlayback.Step = 1
    Me.progPlayback.TabIndex = 27
    Me.progPlayback.Visible = False
    '
    'tmrProcessCallbackResults
    '
    Me.tmrProcessCallbackResults.Enabled = True
    '
    'chkRepeat
    '
    Me.chkRepeat.AutoSize = True
    Me.chkRepeat.Checked = Global.Board_973.My.MySettings.Default.bRepeat
    Me.chkRepeat.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Board_973.My.MySettings.Default, "bRepeat", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.chkRepeat.Location = New System.Drawing.Point(251, 400)
    Me.chkRepeat.Name = "chkRepeat"
    Me.chkRepeat.Size = New System.Drawing.Size(96, 17)
    Me.chkRepeat.TabIndex = 28
    Me.chkRepeat.Text = "Repeat Playlist"
    Me.chkRepeat.UseVisualStyleBackColor = True
    '
    'chkAbsolutePosition
    '
    Me.chkAbsolutePosition.AutoSize = True
    Me.chkAbsolutePosition.Checked = Global.Board_973.My.MySettings.Default.bAbsolutePosition
    Me.chkAbsolutePosition.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Board_973.My.MySettings.Default, "bAbsolutePosition", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.chkAbsolutePosition.Location = New System.Drawing.Point(18, 400)
    Me.chkAbsolutePosition.Name = "chkAbsolutePosition"
    Me.chkAbsolutePosition.Size = New System.Drawing.Size(204, 17)
    Me.chkAbsolutePosition.TabIndex = 26
    Me.chkAbsolutePosition.Text = "Show Absolute Current Position in File"
    Me.chkAbsolutePosition.UseVisualStyleBackColor = True
    Me.chkAbsolutePosition.Visible = False
    '
    'nudSkipPercent
    '
    Me.nudSkipPercent.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Board_973.My.MySettings.Default, "dSkipPercent", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.nudSkipPercent.DecimalPlaces = 2
    Me.nudSkipPercent.Location = New System.Drawing.Point(257, 77)
    Me.nudSkipPercent.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
    Me.nudSkipPercent.Name = "nudSkipPercent"
    Me.nudSkipPercent.Size = New System.Drawing.Size(49, 20)
    Me.nudSkipPercent.TabIndex = 10
    Me.nudSkipPercent.Value = Global.Board_973.My.MySettings.Default.dSkipPercent
    '
    'nudFFPercent
    '
    Me.nudFFPercent.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Board_973.My.MySettings.Default, "dFFPercent", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.nudFFPercent.DecimalPlaces = 2
    Me.nudFFPercent.Location = New System.Drawing.Point(96, 77)
    Me.nudFFPercent.Maximum = New Decimal(New Integer() {999, 0, 0, 131072})
    Me.nudFFPercent.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
    Me.nudFFPercent.Name = "nudFFPercent"
    Me.nudFFPercent.Size = New System.Drawing.Size(49, 20)
    Me.nudFFPercent.TabIndex = 8
    Me.nudFFPercent.Value = Global.Board_973.My.MySettings.Default.dFFPercent
    '
    'nudSubChannel
    '
    Me.nudSubChannel.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Board_973.My.MySettings.Default, "dSubChannel", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.nudSubChannel.Location = New System.Drawing.Point(151, 47)
    Me.nudSubChannel.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
    Me.nudSubChannel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nudSubChannel.Name = "nudSubChannel"
    Me.nudSubChannel.Size = New System.Drawing.Size(51, 20)
    Me.nudSubChannel.TabIndex = 5
    Me.nudSubChannel.Value = Global.Board_973.My.MySettings.Default.dSubChannel
    '
    'nudChannel
    '
    Me.nudChannel.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Board_973.My.MySettings.Default, "dChannel", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.nudChannel.Location = New System.Drawing.Point(96, 47)
    Me.nudChannel.Maximum = New Decimal(New Integer() {21, 0, 0, 0})
    Me.nudChannel.Minimum = New Decimal(New Integer() {14, 0, 0, 0})
    Me.nudChannel.Name = "nudChannel"
    Me.nudChannel.Size = New System.Drawing.Size(51, 20)
    Me.nudChannel.TabIndex = 4
    Me.nudChannel.Value = Global.Board_973.My.MySettings.Default.dChannel
    '
    'nudCard
    '
    Me.nudCard.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Board_973.My.MySettings.Default, "dCard", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.nudCard.Location = New System.Drawing.Point(96, 14)
    Me.nudCard.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
    Me.nudCard.Name = "nudCard"
    Me.nudCard.Size = New System.Drawing.Size(51, 20)
    Me.nudCard.TabIndex = 1
    Me.nudCard.Value = Global.Board_973.My.MySettings.Default.dCard
    '
    'frmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(397, 449)
    Me.Controls.Add(Me.chkRepeat)
    Me.Controls.Add(Me.chkAbsolutePosition)
    Me.Controls.Add(Me.progPlayback)
    Me.Controls.Add(Me.btnSkipFwd)
    Me.Controls.Add(Me.btnFastFwd)
    Me.Controls.Add(Me.btnRewind)
    Me.Controls.Add(Me.btnSkipBack)
    Me.Controls.Add(Me.lblSkipPercent)
    Me.Controls.Add(Me.lblFFPercent)
    Me.Controls.Add(Me.nudSkipPercent)
    Me.Controls.Add(Me.nudFFPercent)
    Me.Controls.Add(Me.dgvFiles)
    Me.Controls.Add(Me.btnAssignChannel)
    Me.Controls.Add(Me.lblChannel)
    Me.Controls.Add(Me.nudSubChannel)
    Me.Controls.Add(Me.nudChannel)
    Me.Controls.Add(Me.btnGetFilename)
    Me.Controls.Add(Me.btnMoveDown)
    Me.Controls.Add(Me.btnMoveUp)
    Me.Controls.Add(Me.btnRemove)
    Me.Controls.Add(Me.btnAdd)
    Me.Controls.Add(Me.btnStop)
    Me.Controls.Add(Me.btnPause)
    Me.Controls.Add(Me.btnPlay)
    Me.Controls.Add(Me.txtStatus)
    Me.Controls.Add(Me.lblStatus)
    Me.Controls.Add(Me.btnInitialize)
    Me.Controls.Add(Me.lblCard)
    Me.Controls.Add(Me.nudCard)
    Me.Name = "frmMain"
    Me.Text = "HDTV998 Control App"
    CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudSkipPercent, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudFFPercent, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudSubChannel, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudChannel, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudCard, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents nudCard As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblCard As System.Windows.Forms.Label
  Friend WithEvents btnInitialize As System.Windows.Forms.Button
  Friend WithEvents lblStatus As System.Windows.Forms.Label
  Friend WithEvents txtStatus As System.Windows.Forms.TextBox
  Friend WithEvents dlgOpenFiles As System.Windows.Forms.OpenFileDialog
  Friend WithEvents btnPlay As System.Windows.Forms.Button
  Friend WithEvents btnPause As System.Windows.Forms.Button
  Friend WithEvents btnStop As System.Windows.Forms.Button
  Friend WithEvents btnAdd As System.Windows.Forms.Button
  Friend WithEvents btnRemove As System.Windows.Forms.Button
  Friend WithEvents btnMoveUp As System.Windows.Forms.Button
  Friend WithEvents btnMoveDown As System.Windows.Forms.Button
  Friend WithEvents btnGetFilename As System.Windows.Forms.Button
  Friend WithEvents nudChannel As System.Windows.Forms.NumericUpDown
  Friend WithEvents nudSubChannel As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblChannel As System.Windows.Forms.Label
  Friend WithEvents btnAssignChannel As System.Windows.Forms.Button
  Friend WithEvents dgvFiles As System.Windows.Forms.DataGridView
  Friend WithEvents dgcCheckbox As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents dgcFileName As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents dgcStartPercent As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents dgcEndPercent As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents lblSkipPercent As System.Windows.Forms.Label
  Friend WithEvents lblFFPercent As System.Windows.Forms.Label
  Friend WithEvents nudSkipPercent As System.Windows.Forms.NumericUpDown
  Friend WithEvents nudFFPercent As System.Windows.Forms.NumericUpDown
  Friend WithEvents btnSkipFwd As System.Windows.Forms.Button
  Friend WithEvents btnFastFwd As System.Windows.Forms.Button
  Friend WithEvents btnRewind As System.Windows.Forms.Button
  Friend WithEvents btnSkipBack As System.Windows.Forms.Button
  Friend WithEvents progPlayback As System.Windows.Forms.ProgressBar
  Friend WithEvents tmrProcessCallbackResults As System.Windows.Forms.Timer
  Friend WithEvents chkAbsolutePosition As System.Windows.Forms.CheckBox
  Friend WithEvents chkRepeat As System.Windows.Forms.CheckBox

End Class
