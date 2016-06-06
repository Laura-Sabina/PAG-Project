Public Class Level_4
    Dim gameStart As Boolean
    Dim min As Integer
    Dim sec As Integer
    Dim total As Integer
    Dim firstLoad As Boolean
    Dim start1 As Boolean
    Dim start2, tleft, tright As Boolean
    Dim count1, count2 As Integer
   
    Private Sub Level_4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        'firstLoad = Data.first4.Text
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

    Private Sub Level_4_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If gameStart = True Then
            gameStart = False
            lblStart.Visible = True
            lblNext.Visible = False
            min = 0
            sec = 0
            total = 0
            lblTime1.Text = "00:00"
            MsgBox("Ai atins peretii!")
            Timer1.Enabled = False
            Timer2.Enabled = False
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
        Timer1.Enabled = False
        ' Level_3.Show()

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

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If gameStart = True Then
            If start2 = True Then
                If tleft = True Then

                    lbl2.Left += 15
                    count1 += 15
                    If count1 >= 165 Then
                        tleft = False
                    End If
                Else
                    lbl2.Left -= 15
                    count1 -= 15
                    If count1 <= 0 Then
                        tleft = True
                    End If
                End If
            End If
            If start1 = True Then
                If tright = True Then

                    lbl1.Left -= 15
                    count2 -= 15
                    If count2 <= 0 Then
                        tright = False
                    End If
                Else
                    lbl1.Left += 15
                    count2 += 15
                    If count2 >= 165 Then
                        tright = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub lblStart1_Click(sender As Object, e As EventArgs) Handles lblStart1.Click
        start1 = True
    End Sub

    Private Sub lblStart2_Click(sender As Object, e As EventArgs) Handles lblStart2.Click
        start2 = True
        Timer2.Enabled = True
    End Sub
End Class