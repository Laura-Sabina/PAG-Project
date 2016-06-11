Public Class Level_8

    Dim gameStart As Boolean
    Dim min As Integer
    Dim sec As Integer
    Dim total As Integer
    Dim firstLoad As Boolean
    Dim intSound As Integer = 0
    Dim snd As New sound
    Dim up As Boolean
    Dim count As Integer

    Private Sub Level_8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        lblNext.Visible = False
        firstLoad = Data.first8.Text
   
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

    Private Sub Level_8_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If gameStart = True Then
            gameStart = False
            intSound += 1
            With snd
                .Name = "SOUND" & intSound
                .play(2, False)
            End With
            lblStart.Visible = True
            lblNext.Visible = False

            min = 0
            sec = 0
            total = 0
            lblTime1.Text = "00:00"
            MsgBox("Ai atins peretii!")
            ' tPad.Location = New Point(120, 125)
            Timer1.Enabled = False
            Timer2.Enabled = False
            reset()
           
        End If

    End Sub
    Private Sub lblStart_Click(sender As Object, e As EventArgs) Handles lblStart.Click
        gameStart = True
        lblStart.Visible = False
        lblNext.Visible = True
        Timer1.Enabled = True


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
        Level_9.Show()

        'Daca este primul joc va salva timpul in formularul Data

        If firstLoad = True Then
            Data.time8.Text = total
            Data.first8.Text = "False"
        Else
            'daca nu este prima data va compara datele si va salva cel mai rapid timp
            Dim t As Integer
            If total < Int32.TryParse(Data.time8.Text, t) Then
                Data.time8.Text = total
            End If
        End If
        Data.complete8.Text = "True"
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

    Private Sub Label28_MouseEnter(sender As Object, e As EventArgs) Handles Label28.MouseEnter
        If gameStart = True Then


            lbl2.Visible = False
            lbl3.Visible = True
            lbl4.Visible = True
        End If
    End Sub

    Private Sub Label24_MouseEnter(sender As Object, e As EventArgs) Handles Label24.MouseEnter
        If gameStart Then
            lbl2.Visible = True
            lbl3.Visible = False
            lbl4.Visible = False
            lbl1.Visible = True
            lbl7.Visible = False

        End If

    End Sub

  

    Private Sub Label34_MouseEnter(sender As Object, e As EventArgs) Handles Label34.MouseEnter
        If gameStart = True Then
            lbl2.Visible = False
            lbl3.Visible = False
            lbl4.Visible = False
            lbl1.Visible = False
            lbl5.Visible = True
            Timer2.Enabled = True

        End If
    End Sub

    Private Sub reset()
        If gameStart = False Then
            If lbl2.Visible = False Then
                lbl2.Visible = True
                lbl3.Visible = False
                lbl4.Visible = False
                lbl1.Visible = False
                lbl5.Visible = False
                lbl7.Visible = False
                lbl6.Location = New Point(405, 55)
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If gameStart = True Then
            If up = True Then
                lbl6.Left += 5
                count += 5
                If count >= 10 Then
                    up = False
                End If
            Else
                lbl6.Left -= 5
                count -= 5
                If count <= -175 Then
                    up = True
                End If
            End If
        End If
    End Sub

    Private Sub Label35_MouseEnter(sender As Object, e As EventArgs) Handles lbl7.MouseEnter

    End Sub

    Private Sub Label15_MouseEnter(sender As Object, e As EventArgs) Handles Label15.MouseEnter
        lbl7.Visible = True
    End Sub
End Class