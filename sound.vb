Public Class sound
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Private oName As String = Nothing
    Public Property Name As String
        Set(value As String)
            oName = value
        End Set
        Get
            Return oName
        End Get
    End Property

    Public Sub play(ByVal id As Integer, ByVal repeat As Boolean, Optional vol As Integer = 1000)
        If repeat = True Then

            mciSendString("Open " & Getfile(id) & " alias " & oName, CStr(0), 0, 0)
            mciSendString("play " & oName & " repeat ", CStr(0), 0, 0)

        Else
            mciSendString("Open " & Getfile(id) & " alias " & oName, CStr(0), 0, 0)
            mciSendString("play " & oName, CStr(0), 0, 0)
        End If
        mciSendString("setaudio " & oName & " volume to " & vol, CStr(0), 0, 0)

    End Sub
    Public Sub kill(ByVal song As String)
        mciSendString("close" & song, CStr(0), 0, 0)
        oName = Nothing
    End Sub

    Private Function Getfile(ByVal id As Integer) As String

        Dim path As String = ""
        Select Case id
            Case 0
                path = "music.wav"
            Case 1
                path = "Finger-snap.wav"
            Case 2
                path = "gameover.wav"
            Case 3
                path = "win.wav"
        End Select
        path = Chr(34) & path & Chr(34)

        Return path
    End Function
    Public Sub StartFrom(ByVal Milliseconds As Integer)
        '------------------------------------------------------------------------------------------------------------------
        ' Purpose: Play audio file from (n) mS position 
        '------------------------------------------------------------------------------------------------------------------

        mciSendString("myaudio " & Milliseconds.ToString, "", 0, 0)

    End Sub

End Class
