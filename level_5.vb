Public Class level_5
    Dim gameStart As Boolean
    Dim min As Integer
    Dim sec As Integer
    Dim total As Integer
    Dim firstLoad As Boolean
    Dim Up3 As Boolean
    Dim Up1, Up2 As Boolean
    Dim count2 As Integer
    Dim count1, count3 As Double
    Dim intSound As Integer = 0
    Dim snd As New sound
    Private Sub level_5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        lblNext.Visible = False
        firstLoad = Data.first5.Text
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
        ' Level_6.Show()

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
        Data.complete1.Text = "True"
        Me.Close()

    End Sub

    Private Sub level_5_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
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
            Timer1.Enabled = False
            Timer2.Enabled = False
          


        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If gameStart = True Then
            If Up1 = True Then
                Block1.Top += 5
                Block2.Top += 5
                count1 += 5
                If count1 >= 33 Then
                    Up1 = False
                End If
            Else
                Block1.Top -= 5
                Block2.Top -= 5
                count1 -= 5
                If count1 <= 0 Then
                    Up1 = True
                End If
            End If
        End If
        If gameStart = True Then
            If Up2 = True Then
                Block3.Top += 2
                Block4.Top += 2
                count2 += 2
                If count2 >= 33 Then
                    Up2 = False
                End If
            Else
                Block3.Top -= 2
                Block4.Top -= 2
                count2 -= 2
                If count2 <= 0 Then
                    Up2 = True
                End If
            End If
        End If

        If gameStart = True Then
            If Up3 = True Then
                Block5.Left += 3
                Block6.Left += 3
                count3 += 3
                If count3 >= 170 Then
                    Up3 = False
                End If
            Else
                Block5.Left -= 3
                Block6.Left -= 3
                count3 -= 3
                If count3 <= 0 Then
                    Up3 = True
                End If
            End If
        End If
      
    End Sub
    Sub lose()
        If gameStart = True Then
            Timer2.Enabled = False
            Timer1.Enabled = False
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
            lblNext.Visible = False
            lblStart.Visible = True
            gameStart = False

        End If
    End Sub

    Private Sub Block1_MouseEnter(sender As Object, e As EventArgs) Handles Block1.MouseEnter
        lose()
    End Sub

    Private Sub Block2_MouseEnter(sender As Object, e As EventArgs) Handles Block2.MouseEnter
        lose()
    End Sub

    Private Sub Block3_MouseEnter(sender As Object, e As EventArgs) Handles Block3.MouseEnter
        lose()
    End Sub

    Private Sub Block4_MouseEnter(sender As Object, e As EventArgs) Handles Block4.MouseEnter
        lose()
    End Sub

    Private Sub Block5_MouseEnter(sender As Object, e As EventArgs) Handles Block5.MouseEnter
        lose()
    End Sub

    Private Sub Block6_MouseEnter(sender As Object, e As EventArgs) Handles Block6.MouseEnter
        lose()
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