Public Class Level_2
    Dim gameStart As Boolean
    Dim min As Integer
    Dim sec As Integer
    Dim total As Integer
    Dim firstLoad As Boolean
    Dim intSound As Integer = 0
    Dim snd As New sound
    Private Sub Level_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        lblNext.Visible = False
        firstLoad = Data.first2.Text
    End Sub

    Private Sub lblMenu_Click(sender As Object, e As EventArgs) Handles lblMenu.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub lblMenu_MouseEnter(sender As Object, e As EventArgs) Handles lblMenu.MouseEnter
        lblMenu.Top -= 5
    End Sub

    Private Sub lblMenu_MouseLeave(sender As Object, e As EventArgs) Handles lblMenu.MouseLeave
        lblMenu.Top += 5
    End Sub

    Private Sub Level_2_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If gameStart = True Then
            gameStart = False
            lblStart.Visible = True
            lblNext.Visible = False
            Timer1.Enabled = False
            Timer2.Enabled = False
            intSound += 1
            With snd
                .Name = "SOUND" & intSound
                .play(2, False)
            End With
            min = 0
            sec = 0
            total = 0
            lblTime1.Text = "00:00"
            MsgBox("Ai atins peretii!")

        End If
    End Sub

    Private Sub lblStart_Click(sender As Object, e As EventArgs) Handles lblStart.Click
        gameStart = True
        lblStart.Visible = False
        lblNext.Visible = True
        Timer1.Enabled = True
        Timer2.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1000

        sec = sec + 1
        If sec = 60 Then
            min = min + 1
            sec = 0
        End If

        lblTime1.Text = min & ":" & sec
    End Sub

    Private Sub lblNext_Click(sender As Object, e As EventArgs) Handles lblNext.Click
        intSound += 1
        With snd
            .Name = "SOUND" & intSound
            .play(3, False, 300)
        End With
        Timer1.Enabled = False
        total = 60 * min + sec
        Level_3.Show()

        'Daca este primul joc va salva timpul in formularul Data

        If firstLoad = True Then
            Data.time2.Text = total
            Data.first2.Text = "False"
        Else
            'daca nu este prima data va compara datele si va salva cel mai rapid timp
            Dim t As Integer
            If total < Int32.TryParse(Data.time2.Text, t) Then
                Data.time2.Text = total
            End If
        End If
        Data.complete2.Text = "True"
        Me.Close()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If lblBlock.Visible = True Then
            lblBlock.Visible = False
        Else
            lblBlock.Visible = True
        End If
    End Sub


  
    Private Sub lblBlock_MouseEnter(sender As Object, e As EventArgs) Handles lblBlock.MouseEnter
        If gameStart = True Then
            gameStart = False
            lblStart.Visible = True
            lblNext.Visible = False
            Timer1.Enabled = False
            Timer2.Enabled = False
            intSound += 1
            With snd
                .Name = "SOUND" & intSound
                .play(2, False)
            End With
            min = 0
            sec = 0
            total = 0
            lblTime1.Text = "00:00"
            MsgBox("Ai atins peretii!")

        End If
    End Sub
    Private Sub lblNext_MouseEnter(sender As Object, e As EventArgs) Handles lblNext.MouseEnter
        lblNext.Top -= 5

    End Sub

    Private Sub lblStart_MouseEnter(sender As Object, e As EventArgs) Handles lblStart.MouseEnter
        lblStart.Top -= 5
    End Sub

    Private Sub lblNext_MouseLeave(sender As Object, e As EventArgs) Handles lblNext.MouseLeave
        lblNext.Top += 5
    End Sub

    Private Sub lblStart_MouseLeave(sender As Object, e As EventArgs) Handles lblStart.MouseLeave
        lblStart.Top += 5
    End Sub
End Class