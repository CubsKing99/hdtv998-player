Imports System.Xml.Serialization

Public Class FileInfo
  Private p_bSelected As Boolean
  Private p_sFileName As String
  Private p_iStartPercent As Integer
  Private p_iEndPercent As Integer

  Public Sub New()
    p_bSelected = False
    p_sFileName = ""
    p_iStartPercent = 0
    p_iEndPercent = 100
  End Sub

  Public Property Selected() As Boolean
    Get
      Return p_bSelected
    End Get
    Set(value As Boolean)
      p_bSelected = value
    End Set
  End Property

  Public Property FileName() As String
    Get
      Return p_sFileName
    End Get
    Set(value As String)
      p_sFileName = value
    End Set
  End Property

  Public Property StartPercent() As Integer
    Get
      Return p_iStartPercent
    End Get
    Set(value As Integer)
      p_iStartPercent = value
    End Set
  End Property

  Public Property EndPercent() As Integer
    Get
      Return p_iEndPercent
    End Get
    Set(value As Integer)
      p_iEndPercent = value
    End Set
  End Property

End Class
