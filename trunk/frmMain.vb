'Imports api
Imports SRIM = System.Runtime.InteropServices.Marshal
Imports System.Xml.Serialization

Public Class frmMain
  Private piCard As Integer = -1
  Private piptrFilename As IntPtr
  Private pbStarted As Boolean = False
  Private piLastStartPercent As Integer
  Private Shared pdCurrentPercent As Decimal
  Private Shared peCurrentStatus As API.STATUS
  Private Shared pbPlayFinished As Boolean = False
  Private piptrProgressCallback As ProgressCallback 'Saved here to keep garbage collector from destroying the callback 
  Private piptrStatusCallback As StatusCallback 'Saved here to keep garbage collector from destroying the callback 

  Private Sub btnInitialize_Click(sender As Object, e As EventArgs) Handles btnInitialize.Click
    Dim eResult As API.STATUS

    'If a card is already initialized, unintialize it
    If (piCard >= 0) Then
      Uninitialize973(piCard)
    End If

    If (IsNumeric(nudCard.Value)) Then
      piCard = nudCard.Value
      eResult = API.Initialize973(piCard)
      If (eResult = STATUS.STATUS_FAILURE) Then
        txtStatus.Text = "STATUS_FAILURE"
        piCard = -1
      ElseIf (eResult = STATUS.STATUS_SUCCESS) Then
        txtStatus.Text = String.Format("Card {0} initialized", piCard)
        SetupCallbacks()
      Else
        txtStatus.Text = String.Format("Status = {0}", eResult)
        piCard = -1
      End If
    Else
      MessageBox.Show("You must enter a card number.", "Enter Card Number", MessageBoxButtons.OK)
    End If

  End Sub

  Private Sub SetupCallbacks()
    Dim eResult As API.STATUS

    'Set Progress callback
    If piptrProgressCallback Is Nothing Then
      piptrProgressCallback = AddressOf OnProgress973
    End If
    eResult = OnProgressSetup973(piCard, piptrProgressCallback)

    If (eResult = API.STATUS.STATUS_FAILURE) Then
      txtStatus.Text = String.Format("{0}{1}Progress Callback STATUS_FAILURE", txtStatus.Text, Environment.NewLine)
    ElseIf (eResult = API.STATUS.STATUS_SUCCESS) Then
      txtStatus.Text = String.Format("{0}{1}Progress Callback Set", txtStatus.Text, Environment.NewLine)
    Else
      txtStatus.Text = String.Format("{0}{1}Progress Callback Set Status = {2}", txtStatus.Text, Environment.NewLine, eResult)
    End If

    'Set Status callback
    If piptrStatusCallback Is Nothing Then
      piptrStatusCallback = AddressOf OnStatus973
    End If
    eResult = OnStatusSetup973(piCard, piptrStatusCallback)

    If (eResult = API.STATUS.STATUS_FAILURE) Then
      txtStatus.Text = String.Format("{0}{1}Status Callback STATUS_FAILURE", txtStatus.Text, Environment.NewLine)
    ElseIf (eResult = API.STATUS.STATUS_SUCCESS) Then
      txtStatus.Text = String.Format("{0}{1}Status Callback Set", txtStatus.Text, Environment.NewLine)
    Else
      txtStatus.Text = String.Format("{0}{1}Status Callback Set Status = {2}", txtStatus.Text, Environment.NewLine, eResult)
    End If
  End Sub

  Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    Dim eResult As DialogResult
    Dim sFilename As String
    Dim drFile As DataGridViewRow
    Dim tbcItem As DataGridViewTextBoxCell

    eResult = dlgOpenFiles.ShowDialog()

    If (eResult = Windows.Forms.DialogResult.OK) Then
      'Add the files to the ListView
      For Each sFilename In dlgOpenFiles.FileNames
        drFile = New DataGridViewRow
        drFile.Cells.Add(New DataGridViewCheckBoxCell)
        tbcItem = New DataGridViewTextBoxCell
        tbcItem.Value = sFilename
        drFile.Cells.Add(tbcItem)
        tbcItem = New DataGridViewTextBoxCell
        tbcItem.Value = 0
        drFile.Cells.Add(tbcItem)
        tbcItem = New DataGridViewTextBoxCell
        tbcItem.Value = 100
        drFile.Cells.Add(tbcItem)
        dgvFiles.Rows.Add(drFile)
      Next
    End If
  End Sub

  Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
    If (dgvFiles.SelectedRows.Count > 0) Then
      dgvFiles.Rows.RemoveAt(dgvFiles.SelectedRows(0).Index)
    Else
      MessageBox.Show("You must select a file.", "Select a File", MessageBoxButtons.OK)
    End If
  End Sub

  Private Sub btnMoveUp_Click(sender As Object, e As EventArgs) Handles btnMoveUp.Click
    'Dim lviRow As ListViewItem

    'If (lvwFiles.SelectedItems.Count > 0) Then
    '  lvwFiles.SelectedItems(0).
    '  lvwFiles.Items.RemoveAt(lvwFiles.SelectedItems(0).Index)
    'Else
    '  MessageBox.Show("You must select a file.", "Select a File", MessageBoxButtons.OK)
    'End If
  End Sub

  Private Sub btnMoveDown_Click(sender As Object, e As EventArgs) Handles btnMoveDown.Click

  End Sub

  Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
    If (dgvFiles.SelectedRows.Count > 0) Then
      If (piCard >= 0) Then
        StartPlayback(dgvFiles.SelectedRows(0).Cells(dgcFileName.Name).Value)
      Else
        MessageBox.Show("You must initialize a card.", "Initialize Card", MessageBoxButtons.OK)
      End If
    Else
      MessageBox.Show("You must select a file.", "Select a File", MessageBoxButtons.OK)
    End If
  End Sub

  Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
    Dim eResult As API.STATUS

    If (piCard >= 0) Then
      eResult = ExecutePause973(piCard)

      If (eResult = API.STATUS.STATUS_FAILURE) Then
        txtStatus.Text = "STATUS_FAILURE"
      ElseIf (eResult = API.STATUS.STATUS_SUCCESS) Then
        txtStatus.Text = "STATUS_SUCCESS"
        SetPauseCaption(btnPause.Text <> "Resume")
      Else
        txtStatus.Text = String.Format("Status = {0}", eResult)
      End If
    Else
      MessageBox.Show("You must initialize a card.", "Initialize Card", MessageBoxButtons.OK)
    End If
  End Sub

  Private Sub SetPauseCaption(ByVal bPaused As Boolean)
    If bPaused Then
      btnPause.Text = "Resume"
    Else
      btnPause.Text = "Pause"
    End If
  End Sub

  Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
    StopPlayback()
  End Sub

  Private Sub btnGetFilename_Click(sender As Object, e As EventArgs) Handles btnGetFilename.Click
    Dim eResult As API.STATUS
    Dim iptrFilename As IntPtr
    Dim sFilename As String

    If (piCard >= 0) Then
      iptrFilename = SRIM.AllocHGlobal(255)

      eResult = GetCurrentPlayingFile973(piCard, iptrFilename)

      If (eResult = API.STATUS.STATUS_FAILURE) Then
        txtStatus.Text = "STATUS_FAILURE"
      ElseIf (eResult = API.STATUS.STATUS_SUCCESS) Then
        sFilename = SRIM.PtrToStringAnsi(iptrFilename)
        txtStatus.Text = String.Format("Filename = {0}", sFilename)
        Try
          SRIM.FreeHGlobal(iptrFilename)
        Catch ex As Exception
        End Try
      Else
        txtStatus.Text = String.Format("Status = {0}", eResult)
      End If
    Else
      MessageBox.Show("You must initialize a card.", "Initialize Card", MessageBoxButtons.OK)
    End If
  End Sub

  Private Sub btnAssignChannel_Click(sender As Object, e As EventArgs) Handles btnAssignChannel.Click
    Dim iChannel As Integer
    Dim iSubChannel As Integer
    Dim eResult As API.STATUS

    iChannel = nudChannel.Value
    iSubChannel = nudSubChannel.Value

    If (piCard >= 0) Then
      eResult = Set8VSBAdjustChannel973(piCard, iChannel)

      If (eResult = API.STATUS.STATUS_FAILURE) Then
        txtStatus.Text = "Set Channel STATUS_FAILURE"
      ElseIf (eResult = API.STATUS.STATUS_SUCCESS) Then
        txtStatus.Text = String.Format("Channel {0} set", iChannel)

        eResult = Board973_SetTvct(piCard, iChannel, iSubChannel)

        If (eResult = API.STATUS.STATUS_FAILURE) Then
          txtStatus.Text = String.Format("{0}{1}Subchannel STATUS_FAILURE", txtStatus.Text, Environment.NewLine)
        ElseIf (eResult = API.STATUS.STATUS_SUCCESS) Then
          txtStatus.Text = String.Format("{0}{1}Subchannel {2} set", txtStatus.Text, Environment.NewLine, iSubChannel)
        Else
          txtStatus.Text = String.Format("{0}{1}Subchannel Status = {2}", txtStatus.Text, Environment.NewLine, eResult)
        End If
      Else
        txtStatus.Text = String.Format("Set Channel Status = {0}", eResult)
      End If
    Else
      MessageBox.Show("You must initialize a card.", "Initialize Card", MessageBoxButtons.OK)
    End If
  End Sub

  Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim dsGrid As New DataSet

    'Load the data grid
    If System.IO.File.Exists(My.Settings.XMLFileListPath) Then
      'dsGrid.ReadXml(My.Settings.XMLFileListPath)
      'Try
      '  With dgvFiles
      '    .DataSource = dsGrid
      '    .DataMember = "FileList"
      '  End With
      'Catch ex As Exception

      'End Try
    End If
  End Sub

  Private Sub frmMain_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
    'Save data from the grid
    'Try
    '  Dim dsGrid As New DataSet

    '  'Save the data grid
    '  dsGrid = dgvFiles.DataSource
    '  dsGrid.WriteXml(My.Settings.XMLFileListPath)
    'Catch ex As Exception
    'End Try

    Try
      If (piCard >= 0) Then
        Uninitialize973(piCard)
      End If
      SRIM.FreeHGlobal(piptrFilename)
    Catch ex As Exception
    End Try
  End Sub

  Public Sub OnProgress973(ByVal iDevice As Integer, ByVal iPercent As Integer)
    pdCurrentPercent = iPercent
    'Me.progPlayback.Value = iPercent
  End Sub

  Public Sub OnStatus973(ByVal iDevice As Integer, ByVal eStatus As API.STATUS)
    peCurrentStatus = eStatus
    If eStatus = API.STATUS.STATUS_PLAY_COMPLETE Then
      pbPlayFinished = True
    End If
    'Me.txtStatus.Text = eStatus.ToString
  End Sub

  Private Sub tmrProcessCallbackResults_Tick(sender As Object, e As EventArgs) Handles tmrProcessCallbackResults.Tick
    'Set the playback percent
    If pdCurrentPercent > 0 Then
      If Me.chkAbsolutePosition.Checked Then
        Me.progPlayback.Value = AbsoluteCurrentPosition()
      Else
        Me.progPlayback.Value = pdCurrentPercent
      End If
    Else
      Me.progPlayback.Value = 0
    End If

    'ToDo: Code this when moving to playlists
    'If the video finished, move to the next video in the list.
    If pbPlayFinished Then
      StartPlayback(txtFileName.Text, nudStartPercent.Value, nudEndPercent.Value)
    End If

    'Handle the status result
    If pbStarted Then
      '  Select (peCurrentStatus)
      '    Case API.STATUS.STATUS_FAILURE
      '      txtStatus.Text = "STATUS_FAILURE"
      '    Case API.STATUS.STATUS_SUCCESS
      '      txtStatus.Text = "STATUS_SUCCESS"
      '    Case API.STATUS.STATUS_VIDEO_STOPPED
      '      txtStatus.Text = "STATUS_VIDEO_STOPPED"
      '    Case API.STATUS.STATUS_END
      '      txtStatus.Text = "STATUS_END"
      '    Case API.STATUS.STATUS_PLAY_START 'Sent when video starts
      '      txtStatus.Text = "STATUS_PLAY_START"
      '    Case API.STATUS.STATUS_PLAY_COMPLETE 'Sent when video ends
      '      txtStatus.Text = "STATUS_PLAY_COMPLETE"
      '    Case API.STATUS.STATUS_PAUSE_PLAY
      '      txtStatus.Text = "STATUS_PAUSE_PLAY"
      '    Case API.STATUS.STATUS_VIDEO_PAUSE
      '      txtStatus.Text = "STATUS_VIDEO_PAUSE"
      '    Case API.STATUS.STATUS_VIDEO_STARTED
      '      txtStatus.Text = "STATUS_VIDEO_STARTED"
      '    Case Else
      txtStatus.Text = String.Format("Status = {0}", peCurrentStatus.ToString)
      '  End Select
    End If
  End Sub

  Private Sub btnSkipFwd_Click(sender As Object, e As EventArgs) Handles btnSkipFwd.Click
    StartPlayback(txtFileName.Text, AbsoluteCurrentPosition() + nudSkipPercent.Value, nudEndPercent.Value)
  End Sub

  Private Sub btnSkipBack_Click(sender As Object, e As EventArgs) Handles btnSkipBack.Click
    StartPlayback(txtFileName.Text, AbsoluteCurrentPosition() - nudSkipPercent.Value, nudEndPercent.Value)
  End Sub

  Private Sub btnFastFwd_Click(sender As Object, e As EventArgs) Handles btnFastFwd.Click
    StartPlayback(txtFileName.Text, AbsoluteCurrentPosition() + nudFFPercent.Value, nudEndPercent.Value)
  End Sub

  Private Sub btnRewind_Click(sender As Object, e As EventArgs) Handles btnRewind.Click
    StartPlayback(txtFileName.Text, AbsoluteCurrentPosition() - nudFFPercent.Value, nudEndPercent.Value)
  End Sub

  Private Function AbsoluteCurrentPosition() As Decimal
    Return piLastStartPercent + (pdCurrentPercent * ((100 - piLastStartPercent) / 100))
  End Function

  Private Sub StartPlayback(ByVal sFileName As String)
    StartPlayback(sFileName, nudStartPercent.Value, nudEndPercent.Value)
  End Sub

  Private Sub StartPlayback(ByVal sFileName As String, ByVal iStartPercent As Integer, ByVal iEndPercent As Integer)
    Dim eResult As API.STATUS

    'Don't let it get outside of the 0-99 range
    If iStartPercent >= 100 Then
      iStartPercent = 99
    ElseIf iStartPercent < 0 Then
      iStartPercent = 0
    End If
    piLastStartPercent = iStartPercent

    'If we're already playing, stop and restart.
    If Me.pbStarted Then
      StopPlayback()
    End If

    piptrFilename = SRIM.StringToHGlobalAnsi(sFileName)
    If (chkContinuousPlayback.Checked) Then
      eResult = ExecutePlaySeamless973(piCard, piptrFilename, 0)
    Else
      eResult = ExecutePlay973(piCard, piptrFilename, iStartPercent, iEndPercent, 0)
      Me.progPlayback.Value = nudStartPercent.Value
    End If

    If (eResult = API.STATUS.STATUS_FAILURE) Then
      txtStatus.Text = "STATUS_FAILURE"
    ElseIf (eResult = API.STATUS.STATUS_SUCCESS) Then
      txtStatus.Text = "STATUS_SUCCESS"
      Me.pbStarted = True
      Me.progPlayback.Visible = True
      pbPlayFinished = False
      Me.chkAbsolutePosition.Visible = True
    Else
      txtStatus.Text = String.Format("Status = {0}", eResult)
    End If
  End Sub

  Private Sub StopPlayback()
    Dim eResult As API.STATUS

    If (piCard >= 0) Then
      eResult = ExecuteStop973(piCard)

      If (eResult = API.STATUS.STATUS_FAILURE) Then
        txtStatus.Text = "STATUS_FAILURE"
      ElseIf (eResult = API.STATUS.STATUS_SUCCESS) Then
        txtStatus.Text = "STATUS_SUCCESS"
      Else
        txtStatus.Text = String.Format("Status = {0}", eResult)
      End If

      Me.pbStarted = False
      SetPauseCaption(False)
      Me.progPlayback.Visible = False
      Me.chkAbsolutePosition.Visible = False
    Else
      MessageBox.Show("You must initialize a card.", "Initialize Card", MessageBoxButtons.OK)
    End If
  End Sub

End Class
