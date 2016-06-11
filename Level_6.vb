Public Class Level_6
    Dim gameStart As Boolean
    Dim min As Integer
    Dim sec As Integer
    Dim total As Integer
    Dim firstLoad As Boolean
    Dim count2 As Integer
    Dim count1 As Double
    Dim intSound As Integer = 0
    Dim snd As New sound
    Dim up As Boolean
    Dim count As Integer
    Private Sub Level_6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        lblNext.Visible = False
        firstLoad = Data.first6.Text
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

    Private Sub Level_6_MouseEnter(sender As Object, e As EventArgs)
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

        bridge3.Visible = True
        bridge1.Visible = True
        bridge2.Visible = False
        bridge4.Visible = False

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
        level_7.Show()

        'Daca este primul joc va salva timpul in formularul Data

        If firstLoad = True Then
            Data.time6.Text = total
            Data.first6.Text = "False"
        Else
            'daca nu este prima data va compara datele si va salva cel mai rapid timp
            Dim t As Integer
            If total < Int32.TryParse(Data.time6.Text, t) Then
                Data.time6.Text = total
            End If
        End If
        Data.complete6.Text = "True"
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
            If lblBlock1.visible = True Then
                lblBlock1.Visible = False
            Else
                lblBlock1.Visible = True
            End If
        End If
    End Sub

  
   
    Sub lose()
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

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If gameStart = True Then
            If up = True Then
                tPad.Left += 5
                count += 5
                If count >= 10 Then
                    up = False
                End If
            Else
                tPad.Left -= 5
                count -= 5
                If count <= -70 Then
                    up = True
                End If
            End If
        End If
    End Sub

  
    Private Sub Label30_MouseEnter(sender As Object, e As EventArgs) Handles Label30.MouseEnter
        If gameStart = True Then
            bridge1.Visible = False
            bridge3.Visible = False
            bridge2.Visible = True
            bridge4.Visible = True
        End If
    End Sub

    Private Sub Level_6_MouseEnter_1(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, lblBlock1.MouseEnter
        lose()
    End Sub

 

   
End Class