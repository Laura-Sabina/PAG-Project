Public Class Form1
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub
    Private Sub lblStart_Click(sender As Object, e As EventArgs) Handles lblStart.Click

    End Sub

    Private Sub lblStart_MouseEnter(sender As Object, e As EventArgs) Handles lblStart.MouseEnter
        lblStart.Top -= 5
    End Sub

    Private Sub lblStart_MouseLeave(sender As Object, e As EventArgs) Handles lblStart.MouseLeave
        lblStart.Top += 5
    End Sub


    Private Sub lblInstructiuni_MouseEnter(sender As Object, e As EventArgs) Handles lblInstructiuni.MouseEnter
        lblInstructiuni.Top -= 5
    End Sub

    Private Sub lblInstructiuni_MouseLeave(sender As Object, e As EventArgs) Handles lblInstructiuni.MouseLeave
        lblInstructiuni.Top += 5
    End Sub

    Private Sub lblReset_MouseEnter(sender As Object, e As EventArgs) Handles lblReset.MouseEnter
        lblReset.Top -= 5
    End Sub

    Private Sub lblReset_MouseLeave(sender As Object, e As EventArgs) Handles lblReset.MouseLeave
        lblReset.Top += 5
    End Sub

    Private Sub lblExit_MouseEnter(sender As Object, e As EventArgs) Handles lblExit.MouseEnter
        lblExit.Top -= 5
    End Sub

    Private Sub lblExit_MouseLeave(sender As Object, e As EventArgs) Handles lblExit.MouseLeave
        lblExit.Top += 5
    End Sub

    Private Sub lblSelectare_MouseEnter(sender As Object, e As EventArgs) Handles lblSelectare.MouseEnter
        lblSelectare.Top -= 5
    End Sub

    Private Sub lblSelectare_MouseLeave(sender As Object, e As EventArgs) Handles lblSelectare.MouseLeave
        lblSelectare.Top += 5
    End Sub

    Private Sub lblInstructiuni_Click(sender As Object, e As EventArgs) Handles lblInstructiuni.Click
        'Afiseaza instructiunile si schimba textul etichetei
        If lblInstructiuni.Text = "Instructions" Then
            lblInstructiuni2.BringToFront()
            Dim size As Single = lblInstructiuni.Font.Size
            size = 10
            lblInstructiuni.Font = New Font(lblInstructiuni.Font.Name, size, lblInstructiuni.Font.Style, lblInstructiuni.Font.Unit)
            lblInstructiuni.Text = "Close Instructions"
        Else
            lblInstructiuni2.SendToBack()
            lblInstructiuni.Text = "Instructions"
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInstructiuni2.Visible = True
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
    End Sub
End Class
