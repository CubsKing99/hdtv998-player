'Imports api
Imports SRIM = System.Runtime.InteropServices.Marshal
Imports System.Xml.Serialization

Public Class frmMain

#Region "Private Variables"
  Private p_iCard As Integer = -1
  Private p_iptrFilename As IntPtr
  Private p_iLastStartPercent As Integer
  Private Shared p_dCurrentPercent As Decimal
  Private Shared p_eCurrentStatus As API.STATUS
  Private Shared p_bPlayFinished As Boolean = False
  Private p_iptrProgressCallback As ProgressCallback 'Saved here to keep garbage collector from destroying the callback 
  Private p_iptrStatusCallback As StatusCallback 'Saved here to keep garbage collector from destroying the callback 
  Private p_iCurrentlyPlayingFile As Integer = -1
#End Region

#Region "Card Setup"

  Private Sub btnInitialize_Click(sender As Object, e As EventArgs) Handles btnInitialize.Click
    Dim eResult As API.STATUS

    'If a card is already initialized, unintialize it
    If (p_iCard >= 0) Then
      Uninitialize973(p_iCard)
    End If

    If (IsNumeric(nudCard.Value)) Then
      p_iCard = nudCard.Value
      eResult = API.Initialize973(p_iCard)
      If (eResult = STATUS.STATUS_FAILURE) Then
        txtStatus.Text = "STATUS_FAILURE"
        p_iCard = -1
      ElseIf (eResult = STATUS.STATUS_SUCCESS) Then
        txtStatus.Text = String.Format("Card {0} initialized", p_iCard)
        SetupCallbacks()
      Else
        txtStatus.Text = String.Format("Status = {0}", eResult)
        p_iCard = -1
      End If
    Else
      MessageBox.Show("You must enter a card number.", "Enter Card Number", MessageBoxButtons.OK)
    End If

  End Sub

  Private Sub SetupCallbacks()
    Dim eResult As API.STATUS

    'Set Progress callback
    If p_iptrProgressCallback Is Nothing Then
      p_iptrProgressCallback = AddressOf OnProgress973
    End If
    eResult = OnProgressSetup973(p_iCard, p_iptrProgressCallback)

    If (eResult = API.STATUS.STATUS_FAILURE) Then
      txtStatus.Text = String.Format("{0}{1}Progress Callback STATUS_FAILURE", txtStatus.Text, Environment.NewLine)
    ElseIf (eResult = API.STATUS.STATUS_SUCCESS) Then
      txtStatus.Text = String.Format("{0}{1}Progress Callback Set", txtStatus.Text, Environment.NewLine)
    Else
      txtStatus.Text = String.Format("{0}{1}Progress Callback Set Status = {2}", txtStatus.Text, Environment.NewLine, eResult)
    End If

    'Set Status callback
    If p_iptrStatusCallback Is Nothing Then
      p_iptrStatusCallback = AddressOf OnStatus973
    End If
    eResult = OnStatusSetup973(p_iCard, p_iptrStatusCallback)

    If (eResult = API.STATUS.STATUS_FAILURE) Then
      txtStatus.Text = String.Format("{0}{1}Status Callback STATUS_FAILURE", txtStatus.Text, Environment.NewLine)
    ElseIf (eResult = API.STATUS.STATUS_SUCCESS) Then
      txtStatus.Text = String.Format("{0}{1}Status Callback Set", txtStatus.Text, Environment.NewLine)
    Else
      txtStatus.Text = String.Format("{0}{1}Status Callback Set Status = {2}", txtStatus.Text, Environment.NewLine, eResult)
    End If
  End Sub

  Private Sub btnAssignChannel_Click(sender As Object, e As EventArgs) Handles btnAssignChannel.Click
    Dim iChannel As Integer
    Dim iSubChannel As Integer
    Dim eResult As API.STATUS

    iChannel = nudChannel.Value
    iSubChannel = nudSubChannel.Value

    If (p_iCard >= 0) Then
      eResult = Set8VSBAdjustChannel973(p_iCard, iChannel)

      If (eResult = API.STATUS.STATUS_FAILURE) Then
        txtStatus.Text = "Set Channel STATUS_FAILURE"
      ElseIf (eResult = API.STATUS.STATUS_SUCCESS) Then
        txtStatus.Text = String.Format("Channel {0} set", iChannel)

        eResult = Board973_SetTvct(p_iCard, iChannel, iSubChannel)

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

#End Region

#Region "Playback"

#Region "Event Handlers"

  Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
    Dim dgrItem As DataGridViewRow

    If (p_iCard >= 0) Then
      For Each dgrItem In dgvFiles.Rows
        If (dgrItem.Cells(dgcCheckbox.Index).Value) Then
          StartPlayback(dgrItem.Index)
          Exit Sub
        End If
      Next

      'If we got here, we didn't find a checked file.
      MessageBox.Show("You must select a file for playback.", "Select a File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    Else
      MessageBox.Show("You must initialize a card.", "Initialize Card", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
    Dim eResult As API.STATUS

    If (p_iCard >= 0) Then
      eResult = ExecutePause973(p_iCard)

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

  Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
    StopPlayback()
  End Sub

  Private Sub btnGetFilename_Click(sender As Object, e As EventArgs) Handles btnGetFilename.Click
    Dim eResult As API.STATUS
    Dim iptrFilename As IntPtr
    Dim sFilename As String

    If (p_iCard >= 0) Then
      iptrFilename = SRIM.AllocHGlobal(255)

      eResult = GetCurrentPlayingFile973(p_iCard, iptrFilename)

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

  Private Sub btnSkipFwd_Click(sender As Object, e As EventArgs) Handles btnSkipFwd.Click
    Dim dgrItem As DataGridViewRow = dgvFiles.Rows(p_iCurrentlyPlayingFile)
    StartPlayback(p_iCurrentlyPlayingFile, dgvFiles.Rows(p_iCurrentlyPlayingFile).Cells(dgcFileName.Index).Value, AbsoluteCurrentPosition() + nudSkipPercent.Value, dgvFiles.Rows(p_iCurrentlyPlayingFile).Cells(dgcEndPercent.Index).Value)
  End Sub

  Private Sub btnSkipBack_Click(sender As Object, e As EventArgs) Handles btnSkipBack.Click
    Dim dgrItem As DataGridViewRow = dgvFiles.Rows(p_iCurrentlyPlayingFile)
    StartPlayback(p_iCurrentlyPlayingFile, dgvFiles.Rows(p_iCurrentlyPlayingFile).Cells(dgcFileName.Index).Value, AbsoluteCurrentPosition() - nudSkipPercent.Value, dgvFiles.Rows(p_iCurrentlyPlayingFile).Cells(dgcEndPercent.Index).Value)
  End Sub

  Private Sub btnFastFwd_Click(sender As Object, e As EventArgs) Handles btnFastFwd.Click
    Dim dgrItem As DataGridViewRow = dgvFiles.Rows(p_iCurrentlyPlayingFile)
    StartPlayback(p_iCurrentlyPlayingFile, dgvFiles.Rows(p_iCurrentlyPlayingFile).Cells(dgcFileName.Index).Value, AbsoluteCurrentPosition() + nudFFPercent.Value, dgvFiles.Rows(p_iCurrentlyPlayingFile).Cells(dgcEndPercent.Index).Value)
  End Sub

  Private Sub btnRewind_Click(sender As Object, e As EventArgs) Handles btnRewind.Click
    Dim dgrItem As DataGridViewRow = dgvFiles.Rows(p_iCurrentlyPlayingFile)
    StartPlayback(p_iCurrentlyPlayingFile, dgvFiles.Rows(p_iCurrentlyPlayingFile).Cells(dgcFileName.Index).Value, AbsoluteCurrentPosition() - nudFFPercent.Value, dgvFiles.Rows(p_iCurrentlyPlayingFile).Cells(dgcEndPercent.Index).Value)
  End Sub

#End Region

#Region "Methods"

  Private Sub SetPauseCaption(ByVal bPaused As Boolean)
    If bPaused Then
      btnPause.Text = "Resume"
    Else
      btnPause.Text = "Pause"
    End If
  End Sub

  Private Sub StartPlayback(ByVal iFileIndex As Integer)
    StartPlayback(iFileIndex, dgvFiles.Rows(iFileIndex).Cells(dgcFileName.Index).Value, dgvFiles.Rows(iFileIndex).Cells(dgcStartPercent.Index).Value, dgvFiles.Rows(iFileIndex).Cells(dgcEndPercent.Index).Value)
  End Sub

  Private Sub StartPlayback(ByVal iFileIndex As Integer, ByVal sFileName As String, ByVal iStartPercent As Integer, ByVal iEndPercent As Integer)
    Dim eResult As API.STATUS

    'Don't let it get outside of the 0-99 range
    If iStartPercent >= 100 Then
      iStartPercent = 99
    ElseIf iStartPercent < 0 Then
      iStartPercent = 0
    End If
    p_iLastStartPercent = iStartPercent

    'If we're already playing something, stop playback.
    If Me.p_iCurrentlyPlayingFile >= 0 Then
      StopPlayback()
    End If

    p_iptrFilename = SRIM.StringToHGlobalAnsi(sFileName)
    eResult = ExecutePlay973(p_iCard, p_iptrFilename, iStartPercent, iEndPercent, 0)

    If (eResult = API.STATUS.STATUS_FAILURE) Then
      txtStatus.Text = "STATUS_FAILURE"
    ElseIf (eResult = API.STATUS.STATUS_SUCCESS) Then
      txtStatus.Text = "STATUS_SUCCESS"
      Me.p_iCurrentlyPlayingFile = iFileIndex
      Me.progPlayback.Visible = True
      Me.progPlayback.Value = iStartPercent
      p_bPlayFinished = False
      Me.chkAbsolutePosition.Visible = True
    Else
      txtStatus.Text = String.Format("Status = {0}", eResult)
    End If
  End Sub

  Private Sub StopPlayback()
    Dim eResult As API.STATUS

    If (p_iCard >= 0) Then
      eResult = ExecuteStop973(p_iCard)

      If (eResult = API.STATUS.STATUS_FAILURE) Then
        txtStatus.Text = "STATUS_FAILURE"
      ElseIf (eResult = API.STATUS.STATUS_SUCCESS) Then
        txtStatus.Text = "STATUS_SUCCESS"
      Else
        txtStatus.Text = String.Format("Status = {0}", eResult)
      End If

      Me.p_iCurrentlyPlayingFile = -1
      SetPauseCaption(False)
      Me.progPlayback.Visible = False
      Me.chkAbsolutePosition.Visible = False
    Else
      MessageBox.Show("You must initialize a card.", "Initialize Card", MessageBoxButtons.OK)
    End If
  End Sub

#End Region

#End Region

#Region "Callback and Related Processing"

  Public Sub OnProgress973(ByVal iDevice As Integer, ByVal iPercent As Integer)
    p_dCurrentPercent = iPercent
    'Me.progPlayback.Value = iPercent
  End Sub

  Public Sub OnStatus973(ByVal iDevice As Integer, ByVal eStatus As API.STATUS)
    p_eCurrentStatus = eStatus
    If eStatus = API.STATUS.STATUS_PLAY_COMPLETE Then
      p_bPlayFinished = True
    End If
    'Me.txtStatus.Text = eStatus.ToString
  End Sub

  Private Sub tmrProcessCallbackResults_Tick(sender As Object, e As EventArgs) Handles tmrProcessCallbackResults.Tick
    Dim dgrItem As DataGridViewRow
    Dim bFoundAnother As Boolean
    Dim iIndex As Integer

    'Set the playback percent
    If p_dCurrentPercent > 0 Then
      If Me.chkAbsolutePosition.Checked Then
        Me.progPlayback.Value = AbsoluteCurrentPosition()
      Else
        Me.progPlayback.Value = p_dCurrentPercent
      End If
    Else
      Me.progPlayback.Value = 0
    End If

    'If the video finished, move to the next video in the list.
    If p_bPlayFinished Then
      bFoundAnother = False

      If p_iCurrentlyPlayingFile < dgvFiles.Rows.Count - 1 Then
        For iIndex = p_iCurrentlyPlayingFile + 1 To dgvFiles.Rows.Count - 1
          dgrItem = dgvFiles.Rows(iIndex)
          If (Not bFoundAnother) AndAlso (dgrItem.Cells(dgcCheckbox.Index).Value) Then
            bFoundAnother = True
            StartPlayback(dgrItem.Index)
          End If
        Next
      End If

      If (Not bFoundAnother) AndAlso Me.chkRepeat.Checked Then
        For iIndex = 0 To dgvFiles.Rows.Count - 1
          dgrItem = dgvFiles.Rows(iIndex)
          If (Not bFoundAnother) AndAlso (dgrItem.Cells(dgcCheckbox.Index).Value) Then
            bFoundAnother = True
            StartPlayback(dgrItem.Index)
          End If
        Next
      End If
    End If

    'Handle the status result
    If p_iCurrentlyPlayingFile >= 0 Then
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
      txtStatus.Text = String.Format("Status = {0}", p_eCurrentStatus.ToString)
      '  End Select
    End If
  End Sub

#End Region

#Region "Playlist Manipulation"

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
    Dim iSelectedIndex As Integer

    If (dgvFiles.SelectedRows.Count > 0) Then
      iSelectedIndex = dgvFiles.SelectedRows(0).Index
      If p_iCurrentlyPlayingFile = iSelectedIndex Then
        MessageBox.Show("You cannot remove the currently playing file.  Please stop playback first.", "Stop Playback First", MessageBoxButtons.OK, MessageBoxIcon.Error)
      ElseIf p_iCurrentlyPlayingFile > iSelectedIndex Then
        p_iCurrentlyPlayingFile -= 1
        dgvFiles.Rows.RemoveAt(iSelectedIndex)
      Else
        dgvFiles.Rows.RemoveAt(iSelectedIndex)
      End If
    End If
  End Sub

  Private Sub btnMoveUp_Click(sender As Object, e As EventArgs) Handles btnMoveUp.Click
    Dim iSelectedRow As Integer
    Dim iSelectedCell As Integer
    Dim dgrSelected As DataGridViewRow

    If (dgvFiles.SelectedRows.Count > 0) Then
      iSelectedRow = dgvFiles.SelectedCells(0).OwningRow.Index
      If (iSelectedRow = 0) Then
        MessageBox.Show("You can't move the first row up!", "Not Gonna Do It", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
        iSelectedCell = dgvFiles.SelectedCells(0).OwningColumn.Index
        dgrSelected = dgvFiles.Rows(iSelectedRow)
        dgvFiles.Rows.RemoveAt(iSelectedRow)
        dgvFiles.Rows.Insert(iSelectedRow - 1, dgrSelected)
        dgvFiles.ClearSelection()
        dgvFiles.Rows(iSelectedRow - 1).Cells(iSelectedCell).Selected = True
      End If
    Else
      MessageBox.Show("You must select a file.", "Select a File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Sub btnMoveDown_Click(sender As Object, e As EventArgs) Handles btnMoveDown.Click
    Dim iSelectedRow As Integer
    Dim iSelectedCell As Integer
    Dim dgrSelected As DataGridViewRow

    If (dgvFiles.SelectedRows.Count > 0) Then
      iSelectedRow = dgvFiles.SelectedCells(0).OwningRow.Index
      If (iSelectedRow = dgvFiles.Rows.Count) Then
        MessageBox.Show("You can't move the last row down!", "Not Gonna Do It", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
        iSelectedCell = dgvFiles.SelectedCells(0).OwningColumn.Index
        dgrSelected = dgvFiles.Rows(iSelectedRow)
        dgvFiles.Rows.RemoveAt(iSelectedRow)
        dgvFiles.Rows.Insert(iSelectedRow + 1, dgrSelected)
        dgvFiles.ClearSelection()
        dgvFiles.Rows(iSelectedRow + 1).Cells(iSelectedCell).Selected = True
      End If
    Else
      MessageBox.Show("You must select a file.", "Select a File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If

  End Sub

#End Region

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
      If (p_iCard >= 0) Then
        Uninitialize973(p_iCard)
      End If
      SRIM.FreeHGlobal(p_iptrFilename)
    Catch ex As Exception
    End Try
  End Sub

  Private Function AbsoluteCurrentPosition() As Decimal
    Return p_iLastStartPercent + (p_dCurrentPercent * ((100 - p_iLastStartPercent) / 100))
  End Function

End Class
