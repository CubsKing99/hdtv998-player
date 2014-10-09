Imports System.Runtime.InteropServices

''VA: 40603C
'Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)
''VA: 405FFC
'Private Declare Sub FileLength64 Lib "FileLength_64.dll" ()
''VA: 405F9C
'Private Declare Auto Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpString As Any, ByVal lpFileName As String) As Integer
''VA: 405F48
'Private Declare Auto Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
''VA: 405EE4
'Private Declare Sub OnStatusSetup973 Lib "Board973.dll" ()
''VA: 405EA0
'Private Declare Sub OnProgressSetup973 Lib "Board973.dll" ()
''VA: 405E54
'Private Declare Sub IndirectMemoryRead973 Lib "Board973.dll" ()
''VA: 405E04
'Private Declare Sub IndirectMemoryWrite973 Lib "Board973.dll" ()
''VA: 405DB4
'Private Declare Sub DirectMemoryRead973 Lib "Board973.dll" ()
''VA: 405D68
'Private Declare Sub DirectMemoryWrite973 Lib "Board973.dll" ()
''VA: 405D18
'Private Declare Sub DirectMemoryWriteBit973 Lib "Board973.dll" ()
''VA: 405CA4
'Private Declare Sub RestampStream973 Lib "Board973.dll" ()
''VA: 405C58
'Private Declare Sub SetNullPacketCount973 Lib "Board973.dll" ()
''VA: 405C08
'Private Declare Sub GetCurrentPlayingFile973 Lib "Board973.dll" ()
''VA: 405BB4
'Private Declare Sub GetDisplayInfo973 Lib "Board973.dll" ()
''VA: 405B68
'Private Declare Sub SetupTextGraphics973 Lib "Board973.dll" ()
''VA: 405B04
'Private Declare Sub GetRevisionXilinx973 Lib "Board973.dll" ()
''VA: 405AB4
'Private Declare Sub SetFastPlayCount973 Lib "Board973.dll" ()
''VA: 405A68
'Private Declare Sub SetAspectRatio973 Lib "Board973.dll" ()
''VA: 405A1C
'Private Declare Sub EnableStreamMonitor973 Lib "Board973.dll" ()
''VA: 4059CC
'Private Declare Sub SetNTSCAdjustChannel973 Lib "Board973.dll" ()
''VA: 40597C
'Private Declare Sub Set8VSBAdjustChannel973 Lib "Board973.dll" ()
''VA: 405928
'Private Declare Sub SetProgram973 Lib "Board973.dll" ()
''VA: 4058E0
'Private Declare Sub GetProgramCountFile973 Lib "Board973.dll" ()
''VA: 405890
'Private Declare Sub GetProgramCount973 Lib "Board973.dll" ()
''VA: 405844
'Private Declare Sub ExecutePlaySeamless973 Lib "Board973.dll" ()
''VA: 4057F4
'Private Declare Sub ExecutePlay973 Lib "Board973.dll" ()
''VA: 4057AC
'Private Declare Sub ExecutePause973 Lib "Board973.dll" ()
''VA: 405754
'Private Declare Sub ExecuteStop973 Lib "Board973.dll" ()
''VA: 40570C
'Private Declare Sub GetRevisions973 Lib "Board973.dll" ()
''VA: 4056C4
'Private Declare Sub Uninitialize973 Lib "Board973.dll" ()
''VA: 40567C
'Private Declare Sub Initialize973 Lib "Board973.dll" ()
''VA: 405634
'Private Declare Sub Board973_GetStatus Lib "Board973.dll" ()
''VA: 4055E8
'Private Declare Sub Board973_GetId Lib "Board973.dll" ()
''VA: 40559C
'Private Declare Sub Board973_GetCardCount Lib "Board973.dll" ()
''VA: 40554C
'Private Declare Sub Board973_SetupOnProgress Lib "Board973.dll" ()
''VA: 4054F8
'Private Declare Sub Board973_SetupOnStatus Lib "Board973.dll" ()
''VA: 4054A8
'Private Declare Sub Board973_Stop Lib "Board973.dll" ()
''VA: 405460
'Private Declare Sub Board973_Play Lib "Board973.dll" ()
''VA: 405418
'Private Declare Sub Board973_PlaySeamless Lib "Board973.dll" ()
''VA: 4053C4
'Private Declare Sub Board973_Initialize Lib "Board973.dll" ()
'

Public Module API
  Declare Auto Function Initialize973 Lib "Board973.dll" (ByVal iDevice As Integer) As Integer
  Declare Auto Function Uninitialize973 Lib "Board973.dll" (ByVal iDevice As Integer) As Integer
  Declare Auto Function GetRevisions973 Lib "Board973.dll" (ByVal iDevice As Integer, ByRef piRev973Board As Integer, ByRef pdblRevDLL As Double, ByRef pdblRevDriver As Double) As Integer
  Declare Auto Function ExecuteStop973 Lib "Board973.dll" (ByVal iDevice As Integer) As Integer
  Declare Auto Function ExecutePause973 Lib "Board973.dll" (ByVal iDevice As Integer) As Integer
  Declare Auto Function ExecutePlay973 Lib "Board973.dll" (ByVal iDevice As Integer, ByVal iptrStrFilename As IntPtr, ByVal iPercentStart As Integer, ByVal iPercentEnd As Integer, ByVal iProgram As Integer) As Integer
  Declare Auto Function ExecutePlaySeamless973 Lib "Board973.dll" (ByVal iDevice As Integer, ByVal iptrStrFilename As IntPtr, ByVal iNullPackets As Integer) As Integer
  Declare Auto Function GetProgramCount973 Lib "Board973.dll" (ByVal iDevice As Integer, ByRef piProgramInfo As Integer) As Integer
  Declare Auto Function GetProgramCountFile973 Lib "Board973.dll" (ByVal iDevice As Integer, ByVal iptrStrFilename As IntPtr, ByRef piProgramInfo As Integer) As Integer
  Declare Auto Function SetProgram973 Lib "Board973.dll" (ByVal iDevice As Integer, ByVal iProgramIndex As Integer) As Integer
  Declare Auto Function Set8VSBAdjustChannel973 Lib "Board973.dll" (ByVal iDevice As Integer, ByVal iChannel As Integer) As Integer
  Declare Auto Function SetNTSCAdjustChannel973 Lib "Board973.dll" (ByVal iDevice As Integer, ByVal iChannel As Integer) As Integer
  Declare Auto Function EnableStreamMonitor973 Lib "Board973.dll" (ByVal iDevice As Integer, ByVal iEnable As Integer) As Integer
  Declare Auto Function SetAspectRatio973 Lib "Board973.dll" (ByVal iDevice As Integer, ByVal iAspectRatio As Integer) As Integer
  Declare Auto Function SetFastPlayCount973 Lib "Board973.dll" (ByVal iDevice As Integer, ByVal iFastPlayCount As Integer) As Integer
  Declare Auto Function GetRevisionXilinx973 Lib "Board973.dll" (ByVal iDevice As Integer, ByRef pdblRevXilinx As Double, ByRef piBoardType As Integer) As Integer
  Declare Auto Function SetupTextGraphics973 Lib "Board973.dll" (ByVal iDevice As Integer, ByVal iptrStrText As IntPtr, ByVal intEnabled As Short, ByVal intMove As Short) As Integer
  Declare Auto Function GetDisplayInfo973 Lib "Board973.dll" (ByVal iDevice As Integer, ByRef pintSrcWidth As Short, ByRef pintSrcHeight As Short, ByRef pblnSrcInterlaced As Short, ByRef pshtSrcFrameRateCode As Short, ByRef pshtSrcAspectRatioCode As Short) As Integer
  Declare Auto Function GetCurrentPlayingFile973 Lib "Board973.dll" (ByVal iDevice As Integer, ByVal iptrStrFilename As IntPtr) As Integer
  Declare Auto Function SetNullPacketCount973 Lib "Board973.dll" (ByVal iDevice As Integer, ByVal iNullPacketCount As Integer) As Integer
  Declare Auto Function RestampStream973 Lib "Board973.dll" (ByVal iDevice As Integer, ByVal lMode As Integer) As Integer

  Declare Auto Function Board973_SetTvct Lib "Board973.dll" (ByVal iDevice As Integer, ByVal iMajor As Short, ByVal iMinor As Short) As Integer

  Declare Auto Function OnProgressSetup973 Lib "Board973.dll" (ByVal iDevice As Integer, ByVal lpWndProc As ProgressCallback) As Integer
  Declare Auto Function OnStatusSetup973 Lib "Board973.dll" (ByVal iDevice As Integer, ByVal lpWndProc As StatusCallback) As Integer

  Public Delegate Sub ProgressCallback(ByVal iDevice As Integer, ByVal iPercent As Integer)
  Public Delegate Sub StatusCallback(ByVal iDevice As Integer, ByVal iPercent As Integer)

  Public Enum STATUS_BASE As Integer
    STATUS_BASE_8VSB = &H10001000
    STATUS_BASE_DLL = &H10002000
    STATUS_BASE_MAIN = &H10003000
  End Enum

  Public Enum STATUS As Integer
    STATUS_FAILURE = -1
    STATUS_SUCCESS

    '// Initialization process fail
    STATUS_INITIALIZE_ERROR_DLL = STATUS_BASE.STATUS_BASE_DLL
    '// If Start >= End
    STATUS_PLAY_RANGE_INVALID

    STATUS_BANK0_READY = STATUS_BASE.STATUS_BASE_MAIN
    STATUS_BANK1_READY '// Reserved
    STATUS_RECORD_COMPLETE '// Reserved
    ERROR_BANK_CONFLICT '// Reserved
    ERROR_FILE_NOT_OPEN '// Reserved
    ERROR_FILE_TOO_SMALL '// Reserved
    ERROR_FILE_READ_NO '// Reserved
    ERROR_FILE_WRITE_NO '// Reserved
    ERROR_INTERRUPT '// Reserved
    ERROR_MEMORY_ALLOCATION '// Reserved
    ERROR_FILE_PLAY_LIMIT '// Reserved

    '// STATUS - Indicates a file has starting loading into system memory
    STATUS_PLAY_START = &H1000300B

    STATUS_OCX_STOP_VIDEO '// Reserved
    STATUS_PAUSE_PLAY '// Reserved
    ERROR_INVALID_ASPECT_RATIO '// Reserved
    STATUS_VIDEO_PAUSE '// Reserved
    ERROR_PTS_NOT_FOUND '// Reserved
    ERROR_PCR_NOT_FOUND '// Reserved

    '// STATUS - Indicates a file had ended loading into system memory
    STATUS_PLAY_COMPLETE = &H10003012

    '// STATUS - Indicates that 'Video Locked Interrupt' has occurred
    '// (New Mpeg Data arrival)
    STATUS_PROGRAM_UPDATE = &H10003013

    STATUS_RESTART_QPSK '// Reserved
    STATUS_STREAM_UPDATE '// Reserved
    STATUS_NO_SIGNAL '// Reserved
    STATUS_STARTUP_VIDEO '// Reserved
    STATUS_MONITOR_RESTART '// Reserved
    STATUS_STREAM_START '// Reserved
    STATUS_STREAM_STARTED '// Reserved
    STATUS_STREAM_PSIP '// Reserved
    STATUS_STREAM_STOPPED '// Reserved
    STATUS_VIDEO_STARTED '// Reserved
    STATUS_VIDEO_STOPPED '// Reserved

    '// same as STATUS_PROGRAM_UPDATE
    STATUS_VIDEO_LOCKED = &H1000301F

    '// Non-seamless data monitoring indicating a video or audio change
    STATUS_NEW_PSIP = &H10003020

    STATUS_SYNC_READY = &H10003021 '// Reserved
    ERROR_VIDEO_START = &H10003022 '// Reserved
    ERROR_STREAM_CHANNEL = &H10003023 '// Reserved

    '// Socket setup and ready to connect
    STATUS_SOCKET_LISTEN = &H10003024

    STATUS_SOCKET_WAIT = &H10003025 '// Reserved

    '// A data underflow has happened pausing playback on the card
    '// but allowing the system buffers to fill again.
    STATUS_BUFFER_EMPTY_PAUSED = &H10003026

    '// System buffers are full continuing playback
    STATUS_BUFFER_FULL_PLAYING = &H10003027

    '// No programs found in "File Program Information Search"
    ERROR_NO_PROGRAMS = &H10003028

    '// Starting playback error trying to open or add file to queue
    ERROR_SEAMLESS_MODULE = &H10003029

    '// No PIDs found in "File Program Information Search"
    ERROR_NO_PIDS = &H1000302A

    '// Not getting proper amount of data from "Seamless" module
    ERROR_TRANSFER_SIZE = &H1000302B

    '// Couldn't find the program information
    ERROR_PROGRAM_SEARCH = &H1000302C

    '// Invalid 19392658 bitrate
    ERROR_INVALID_ATSC_BITRATE = &H1000302D

    '// After switching to the LVDS port Broadcom could not start the decode
    ERROR_NO_LVDS_DECODE = &H1000302E

    STATUS_END
  End Enum

  Public Enum ASPECT As Integer
    ASPECT_AUTO
    ASPECT_FULL
    ASPECT_4X3
    ASPECT_CROP
    ASPECT_LETTERBOX
    ASPECT_RESERVED_1
  End Enum

  Public Enum Board_TYPE As Integer
    Board_TYPE_300_A
    Board_TYPE_300_B
    Board_TYPE_400_A
  End Enum

End Module
