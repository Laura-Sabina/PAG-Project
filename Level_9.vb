Public Class Level_9
    Dim random As New Random
    Dim newLayout As Integer
    Dim lastLayout As Integer
    Dim gameStart As Boolean
    Dim min As Integer
    Dim sec As Integer
    Dim total As Integer
    Dim firstLoad As Boolean
    Dim intSound As Integer = 0
    Dim snd As New sound
    Dim up As Boolean
    Dim count As Integer


    Private Sub Level_9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        lblNext.Visible = False
        firstLoad = Data.first9.Text
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

    Private Sub Level_9_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If gameStart = True Then
            gameStart = False
            intSound += 1
            With snd
                .Name = "SOUND" & intSound
                .play(2, False)
            End With
            lastLayout = newLayout
            lblStart.Visible = True
            lblNext.Visible = False

            min = 0
            sec = 0
            total = 0
            lblTime1.Text = "00:00"
            MsgBox("Ai atins peretii!")

            Timer1.Enabled = False
            Timer2.Enabled = False
            lbl6.Location = New Point(405, 55)

        End If
    End Sub
    Private Sub lblStart_Click(sender As Object, e As EventArgs)
  


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
        'Level_9.Show()

        'Daca este primul joc va salva timpul in formularul Data

        If firstLoad = True Then
            Data.time9.Text = total
            Data.first9.Text = "False"
        Else
            'daca nu este prima data va compara datele si va salva cel mai rapid timp
            Dim t As Integer
            If total < Int32.TryParse(Data.time9.Text, t) Then
                Data.time9.Text = total
            End If
        End If
        Data.complete8.Text = "True"
        Me.Close()

    End Sub
    Private Sub lblNext_MouseEnter(sender As Object, e As EventArgs) Handles lblNext.MouseEnter
        lblNext.Top -= 5

    End Sub

    Private Sub lblStart_MouseEnter(sender As Object, e As EventArgs)
        lblStart.Top -= 5
    End Sub

    Private Sub lblNext_MouseLeave(sender As Object, e As EventArgs) Handles lblNext.MouseLeave
        lblNext.Top += 5
    End Sub

    Private Sub lblStart_MouseLeave(sender As Object, e As EventArgs)
        lblStart.Top += 5
    End Sub

    Private Sub pickNewLayout()
        newLayout = random.Next(1, 4)
        If newLayout = 1 Then
            If Not lastLayout = newLayout Then
                lbl1.Visible = True
                lbl2.Visible = True
                lbl3.Visible = True
                lbl4.Visible = True
                lbl5.Visible = True
                lbl6.Visible = True
                lbl7.Visible = True
                lbl8.Visible = True
                lbl9.Visible = True
                lbl10.Visible = True
                lbl11.Visible = True
                lbl12.Visible = True
                lbl13.Visible = True
                lbl14.Visible = True
                lbl15.Visible = True
                lbl16.Visible = True
                lbl17.Visible = True
                lbl18.Visible = True
                lbl18.Visible = True
                lbl19.Visible = True
                lbl20.Visible = True
                lbl21.Visible = True
                lbl22.Visible = True
                lblNext.BackColor = Color.Maroon
                lblStart.BackColor = Color.Maroon
                Label5.BackColor = Color.Maroon
                Label21.BackColor = Color.Maroon
                reset2()
                reset3()



            End If

        ElseIf newLayout = 2 Then
            If Not lastLayout = newLayout Then
                lbl23.Visible = True
                lbl24.Visible = True
                lbl25.Visible = True
                lbl26.Visible = True
                lbl27.Visible = True
                lbl28.Visible = True
                lbl29.Visible = True
                lbl30.Visible = True
                lbl31.Visible = True
                lbl32.Visible = True
                lbl33.Visible = True
                lbl34.Visible = True
                lbl35.Visible = True
                lbl36.Visible = True
                lbl37.Visible = True
                lbl38.Visible = True
                lbl39.Visible = True
                lbl40.Visible = True
                lbl41.Visible = True
                lbl42.Visible = True
                lblNext.BackColor = Color.Cyan
                lblStart.BackColor = Color.Cyan
                Label5.BackColor = Color.Cyan
                Label21.BackColor = Color.Cyan
                reset1()
                reset3()
            End If
        ElseIf newLayout = 3 Then
            If Not lastLayout = newLayout Then
                lbl43.Visible = True
                lbl44.Visible = True
                lbl45.Visible = True
                lbl46.Visible = True
                lbl47.Visible = True
                lbl48.Visible = True
                lbl49.Visible = True
                lbl50.Visible = True
                lbl51.Visible = True
                lbl52.Visible = True
                lbl53.Visible = True
                lbl54.Visible = True
                lbl55.Visible = True
                reset1()
                reset2()
                lblNext.BackColor = Color.Lime
                lblStart.BackColor = Color.Lime
                Label5.BackColor = Color.Lime
                Label21.BackColor = Color.Lime

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

    Private Sub lblStart_Click_1(sender As Object, e As EventArgs) Handles lblStart.Click
        pickNewLayout()
        While newLayout = lastLayout
            pickNewLayout()
        End While
        gameStart = True
        lblStart.Visible = False
        lblNext.Visible = True
        Timer1.Enabled = True
        Timer2.Enabled = True


    End Sub
    Private Sub reset1()
        lbl1.Visible = False
        lbl2.Visible = False
        lbl3.Visible = False
        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        lbl13.Visible = False
        lbl14.Visible = False
        lbl15.Visible = False
        lbl16.Visible = False
        lbl17.Visible = False
        lbl18.Visible = False
        lbl18.Visible = False
        lbl19.Visible = False
        lbl20.Visible = False
        lbl21.Visible = False
        lbl22.Visible = False
    End Sub
    Private Sub reset2()
        lbl23.Visible = False
        lbl24.Visible = False
        lbl25.Visible = False
        lbl26.Visible = False
        lbl27.Visible = False
        lbl28.Visible = False
        lbl29.Visible = False
        lbl30.Visible = False
        lbl31.Visible = False
        lbl32.Visible = False
        lbl33.Visible = False
        lbl34.Visible = False
        lbl35.Visible = False
        lbl36.Visible = False
        lbl37.Visible = False
        lbl38.Visible = False
        lbl39.Visible = False
        lbl40.Visible = False
        lbl41.Visible = False
        lbl42.Visible = False
    End Sub
    Private Sub reset3()
        lbl43.Visible = False
        lbl44.Visible = False
        lbl45.Visible = False
        lbl46.Visible = False
        lbl47.Visible = False
        lbl48.Visible = False
        lbl49.Visible = False
        lbl50.Visible = False
        lbl51.Visible = False
        lbl52.Visible = False
        lbl53.Visible = False
        lbl54.Visible = False
        lbl55.Visible = False

    End Sub

End Class