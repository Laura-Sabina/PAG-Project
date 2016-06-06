Public Class Level_3
    Dim gameStart As Boolean
    Dim min As Integer
    Dim sec As Integer
    Dim total As Integer
    Dim firstLoad As Boolean
    Dim blockUp As Boolean
    Dim blockCounter As Integer
    Private Sub Level_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        firstLoad = Data.first3.Text
    End Sub

    Private Sub lblMenu_MouseEnter(sender As Object, e As EventArgs) Handles lblMenu.MouseEnter
        lblMenu.Top -= 5
    End Sub

    Private Sub lblMenu_MouseLeave(sender As Object, e As EventArgs) Handles lblMenu.MouseLeave
        lblMenu.Top += 5
    End Sub
    Private Sub lblMenu_Click_1(sender As Object, e As EventArgs) Handles lblMenu.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Level_3_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If gameStart = True Then
            gameStart = False
            lblStart.Visible = True
            lblNext.Visible = False
            Timer1.Enabled = False
            min = 0
            sec = 0
            total = 0
            lblTime1.Text = "00:00"
            MsgBox("Ai atins peretii!")

        End If
    End Sub

    Private Sub lblStart_Click_1(sender As Object, e As EventArgs) Handles lblStart.Click
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
        Timer1.Enabled = False
        'Level_4.Show()

        'Daca este primul joc va salva timpul in formularul Data

        If firstLoad = True Then
            Data.time3.Text = total
            Data.first3.Text = "False"
        Else
            'daca nu este prima data va compara datele si va salva cel mai rapid timp
            Dim t As Integer
            If total < Int32.TryParse(Data.time3.Text, t) Then
                Data.time3.Text = total
            End If
        End If
        Data.complete3.Text = "True"
        Me.Close()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'controleaza miscarea blocurilor        
        If gameStart = True Then

            If blockUp = True Then
                lblBlock1.Top -= 15
                blockCounter -= 15
                If blockCounter <= 10 Then
                    blockUp = False
                End If
            Else
                lblBlock1.Top += 15
                blockCounter += 15
                If blockCounter >= 15 Then
                    blockUp = True
                End If
            End If

            If blockUp = True Then
                lblBlock2.Top += 6
                blockCounter += 6
                If blockCounter >= 36 Then
                    blockUp = False
                End If
            Else
                lblBlock2.Top -= 6
                blockCounter -= 6
                If blockCounter <= 0 Then
                    blockUp = True
                End If
            End If

            If blockUp = True Then
                lblBlock3.Top += 9
                blockCounter += 9
                If blockCounter >= 25 Then
                    blockUp = False
                End If
            Else
                lblBlock3.Top -= 9
                blockCounter -= 9
                If blockCounter <= 0 Then
                    blockUp = True
                End If
            End If

            If blockUp = True Then
                lblBlock4.Top += 15
                blockCounter += 15
                If blockCounter >= 25 Then
                    blockUp = False
                End If
            Else
                lblBlock4.Top -= 15
                blockCounter -= 15
                If blockCounter <= 0 Then
                    blockUp = True
                End If
            End If

            If blockUp = True Then
                lblBlock5.Top += 15
                blockCounter += 15
                If blockCounter >= 25 Then
                    blockUp = False
                End If
            Else
                lblBlock5.Top -= 15
                blockCounter -= 15
                If blockCounter <= 0 Then
                    blockUp = True
                End If
            End If

        End If
    End Sub
    Sub lose()
        If gameStart = True Then
            Timer2.Enabled = False
            Timer1.Enabled = False
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

    Private Sub lblBlock1_MouseEnter(sender As Object, e As EventArgs) Handles lblBlock1.MouseEnter
        lose()
    End Sub

    Private Sub lblBlock2_MouseEnter(sender As Object, e As EventArgs) Handles lblBlock2.MouseEnter
        lose()
    End Sub

    Private Sub lblBlock4_MouseEnter(sender As Object, e As EventArgs) Handles lblBlock4.MouseEnter
        lose()
    End Sub

    Private Sub lblBlock5_MouseEnter(sender As Object, e As EventArgs) Handles lblBlock5.MouseEnter
        lose()
    End Sub

    Private Sub lblBlock3_MouseEnter(sender As Object, e As EventArgs) Handles lblBlock3.MouseEnter
        lose()
    End Sub
End Class