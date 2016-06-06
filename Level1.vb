Public Class Level_1
    Dim gameStart As Boolean
    Dim min As Integer
    Dim sec As Integer
    Dim total As Integer
    Dim firstLoad As Boolean

    Private Sub Level_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        firstLoad = Data.first1.Text
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

    Private Sub Level_1_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
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
        Level_2.Show()

        'Daca este primul joc va salva timpul in formularul Data

        If firstLoad = True Then
            Data.time1.Text = total
            Data.first1.Text = "False"
        Else
            'daca nu este prima data va compara datele si va salva cel mai rapid timp
            Dim t As Integer
            If total < Int32.TryParse(Data.time1.Text, t) Then
                Data.time1.Text = total
            End If
        End If
        Data.complete1.Text = "True"
        Me.Close()

    End Sub
End Class