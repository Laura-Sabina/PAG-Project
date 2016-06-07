Public Class level_7

    Dim gameStart As Boolean
    Dim min As Integer
    Dim sec As Integer
    Dim total As Integer
    Dim firstLoad As Boolean
    Dim count2 As Integer
    Dim count1 As Double
    Dim intSound As Integer = 0
    Dim snd As New sound
    Dim l1up, l2up, l3up, l4up, l5up As Boolean
    Dim l1count, l2count, l3count, l4count, l5count As Integer

    Private Sub level_7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        lblNext.Visible = False
        firstLoad = Data.first7.Text
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

    Private Sub level_7_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If gameStart = True Then
            gameStart = False
            lblStart.Visible = True
            lblNext.Visible = False
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
            ' tPad.Location = New Point(120, 125)
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False

        End If
    End Sub
    Private Sub lblStart_Click(sender As Object, e As EventArgs) Handles lblStart.Click
        gameStart = True
        lblStart.Visible = False
        lblNext.Visible = True
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
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
        ' Level_8.Show()

        'Daca este primul joc va salva timpul in formularul Data

        If firstLoad = True Then
            Data.time7.Text = total
            Data.first7.Text = "False"
        Else
            'daca nu este prima data va compara datele si va salva cel mai rapid timp
            Dim t As Integer
            If total < Int32.TryParse(Data.time7.Text, t) Then
                Data.time7.Text = total
            End If
        End If
        Data.complete7.Text = "True"
        Me.Close()

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

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If gameStart = True Then
            If l1up = True Then
                lbl1.Top += 5
                l1count += 5
                If l1count >= 60 Then
                    l1up = False
                End If
            Else
                lbl1.Top -= 5
                l1count -= 5
                If l1count <= 0 Then
                    l1up = True
                End If
            End If
        End If

        If gameStart = True Then
            If l4up = True Then
                lbl4.Top += 5
                l4count += 5
                If l4count >= 180 Then
                    l4up = False
                End If
            Else
                lbl4.Top -= 5
                l4count -= 5
                If l4count <= 0 Then
                    l4up = True
                End If
            End If
        End If
        If gameStart = True Then
            If l5up = True Then
                lbl5.Top += 5
                l5count += 5
                If l5count >= 140 Then
                    l5up = False
                End If
            Else
                lbl5.Top -= 5
                l5count -= 5
                If l5count <= 0 Then
                    l5up = True
                End If
            End If
        End If

        If gameStart = True Then
            If l3up = True Then
                lbl3.Top += 5
                l3count += 5
                If l3count >= 40 Then
                    l3up = False
                End If
            Else
                lbl3.Top -= 5
                l3count -= 5
                If l3count <= -70 Then
                    l3up = True
                End If
            End If
        End If

        If gameStart = True Then
            If l2up = True Then
                lbl2.Top += 5
                l2count += 5
                If l2count >= 20 Then
                    l2up = False
                End If
            Else
                lbl2.Top -= 5
                l2count -= 5
                If l2count <= -130 Then
                    l2up = True
                End If
            End If
        End If
    End Sub
End Class