Imports System
Imports System.IO
Imports System.Text
Public Class Form1
    Dim intSound As Integer = 0
    Dim snd As New sound
    Dim firstTime As Boolean


    Private Sub Hsound()
        For x = 0 To intSound
            snd.kill("SOUND" & x)
        Next
    End Sub



    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click


        My.Computer.FileSystem.WriteAllText("MazeGameTiming.txt", Data.complete1.Text & ControlChars.NewLine & _
                                                    Data.first1.Text & ControlChars.NewLine & _
                                                    Data.time1.Text & ControlChars.NewLine & _
                                                    Data.complete2.Text & ControlChars.NewLine & _
                                                    Data.first2.Text & ControlChars.NewLine & _
                                                    Data.time2.Text & ControlChars.NewLine & _
                                                    Data.complete3.Text & ControlChars.NewLine & _
                                                    Data.first3.Text & ControlChars.NewLine & _
                                                    Data.time3.Text & ControlChars.NewLine & _
                                                    Data.complete4.Text & ControlChars.NewLine & _
                                                    Data.first4.Text & ControlChars.NewLine & _
                                                    Data.time4.Text & ControlChars.NewLine & _
                                                    Data.complete5.Text & ControlChars.NewLine & _
                                                    Data.first5.Text & ControlChars.NewLine & _
                                                    Data.time5.Text & ControlChars.NewLine & _
                                                    Data.complete6.Text & ControlChars.NewLine & _
                                                    Data.first6.Text & ControlChars.NewLine & _
                                                    Data.time6.Text & ControlChars.NewLine & _
                                                    Data.complete7.Text & ControlChars.NewLine & _
                                                    Data.first7.Text & ControlChars.NewLine & _
                                                    Data.time7.Text & ControlChars.NewLine & _
                                                    Data.complete8.Text & ControlChars.NewLine & _
                                                    Data.first8.Text & ControlChars.NewLine & _
                                                    Data.time8.Text & ControlChars.NewLine & _
                                                    Data.complete9.Text & ControlChars.NewLine & _
                                                    Data.first9.Text & ControlChars.NewLine & _
                                                    Data.time9.Text & ControlChars.NewLine & _
                                                    Data.complete10.Text & ControlChars.NewLine & _
                                                    Data.first10.Text & ControlChars.NewLine & _
                                                    Data.time10.Text & ControlChars.NewLine, False)

        Me.Close()

    End Sub
    Private Sub lblStart_Click(sender As Object, e As EventArgs) Handles lblStart.Click
        Level_1.Show()
        Level_1.lblNext.Visible = False
        Me.Close()
    End Sub

    Private Sub lblStart_MouseEnter(sender As Object, e As EventArgs) Handles lblStart.MouseEnter

        'My.Computer.Audio.Play(My.Resources.Finger_snap, _
        'AudioPlayMode.Background)
        intSound += 1
        With snd
            .Name = "SOUND" & intSound
            .play(1, False, 300)
        End With
        lblStart.Top -= 5
    End Sub

    Private Sub lblStart_MouseLeave(sender As Object, e As EventArgs) Handles lblStart.MouseLeave
        lblStart.Top += 5
    End Sub


    Private Sub lblInstructiuni_MouseEnter(sender As Object, e As EventArgs) Handles lblInstructiuni.MouseEnter

        'My.Computer.Audio.Play(My.Resources.Finger_snap, _
        'AudioPlayMode.Background)
        intSound += 1
        With snd
            .Name = "SOUND" & intSound
            .play(1, False, 300)
        End With
        lblInstructiuni.Top -= 5
    End Sub

    Private Sub lblInstructiuni_MouseLeave(sender As Object, e As EventArgs) Handles lblInstructiuni.MouseLeave
        lblInstructiuni.Top += 5
    End Sub

    Private Sub lblReset_MouseEnter(sender As Object, e As EventArgs) Handles lblReset.MouseEnter

        'My.Computer.Audio.Play(My.Resources.Finger_snap, _
        ' AudioPlayMode.Background)
        intSound += 1
        With snd
            .Name = "SOUND" & intSound
            .play(1, False, 300)
        End With
        lblReset.Top -= 5
    End Sub

    Private Sub lblReset_MouseLeave(sender As Object, e As EventArgs) Handles lblReset.MouseLeave
        lblReset.Top += 5
    End Sub

    Private Sub lblExit_MouseEnter(sender As Object, e As EventArgs) Handles lblExit.MouseEnter

        'My.Computer.Audio.Play(My.Resources.Finger_snap, _
        ' AudioPlayMode.Background)
        intSound += 1
        With snd
            .Name = "SOUND" & intSound
            .play(1, False, 300)
        End With
        lblExit.Top -= 5
    End Sub

    Private Sub lblExit_MouseLeave(sender As Object, e As EventArgs) Handles lblExit.MouseLeave
        lblExit.Top += 5
    End Sub

    Private Sub lblSelectare_MouseEnter(sender As Object, e As EventArgs) Handles lblSelectare.MouseEnter

        intSound += 1
        With snd
            .Name = "SOUND" & intSound
            .play(1, False, 300)
        End With
        'My.Computer.Audio.Play(My.Resources.Finger_snap, _
        ' AudioPlayMode.Background)
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

    'Sub PlayBackgroundSoundResource()
    '     My.Computer.Audio.Play(My.Resources.music, _
    '         AudioPlayMode.BackgroundLoop)
    '  End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        My.Computer.Audio.Play(My.Resources.music, AudioPlayMode.BackgroundLoop)

        lblInstructiuni2.Visible = True
        lblInstructiuni2.Text = vbCrLf & vbCrLf & vbCrLf & vbCrLf & "Acest joc iti testeaza coordonarea ochi-mana si capacitatea ta de concentrare. Ghideaza cursorul prin labirint pentru a termina fiecare nivel. Nu atinge peretii! Daca o vei face, jocul se va restarta si va trebui sa o iei de la capat! "
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)

        firstTime = Data.startFirst.Text

        If firstTime = True Then
            If My.Computer.FileSystem.FileExists("MazeGameTiming.txt") Then
                Dim reader As New System.IO.StreamReader("MazeGameTiming.txt")
                Data.complete1.Text = reader.ReadLine
                Data.first1.Text = reader.ReadLine
                Data.time1.Text = reader.ReadLine

                Data.complete2.Text = reader.ReadLine
                Data.first2.Text = reader.ReadLine
                Data.time2.Text = reader.ReadLine

                Data.complete3.Text = reader.ReadLine
                Data.first3.Text = reader.ReadLine
                Data.time3.Text = reader.ReadLine

                Data.complete4.Text = reader.ReadLine
                Data.first4.Text = reader.ReadLine
                Data.time4.Text = reader.ReadLine

                Data.complete5.Text = reader.ReadLine
                Data.first5.Text = reader.ReadLine
                Data.time5.Text = reader.ReadLine

                Data.complete6.Text = reader.ReadLine
                Data.first6.Text = reader.ReadLine
                Data.time6.Text = reader.ReadLine

                Data.complete7.Text = reader.ReadLine
                Data.first7.Text = reader.ReadLine
                Data.time7.Text = reader.ReadLine

                Data.complete8.Text = reader.ReadLine
                Data.first8.Text = reader.ReadLine
                Data.time8.Text = reader.ReadLine

                Data.complete9.Text = reader.ReadLine
                Data.first9.Text = reader.ReadLine
                Data.time9.Text = reader.ReadLine

                Data.complete10.Text = reader.ReadLine
                Data.first10.Text = reader.ReadLine
                Data.time10.Text = reader.ReadLine
                reader.Close()
            Else
                My.Computer.FileSystem.WriteAllText("MazeGameTiming.txt", Data.complete1.Text & ControlChars.NewLine & _
                                                    Data.first1.Text & ControlChars.NewLine & _
                                                    Data.time1.Text & ControlChars.NewLine & _
                                                    Data.complete2.Text & ControlChars.NewLine & _
                                                    Data.first2.Text & ControlChars.NewLine & _
                                                    Data.time2.Text & ControlChars.NewLine & _
                                                    Data.complete3.Text & ControlChars.NewLine & _
                                                    Data.first3.Text & ControlChars.NewLine & _
                                                    Data.time3.Text & ControlChars.NewLine & _
                                                    Data.complete4.Text & ControlChars.NewLine & _
                                                    Data.first4.Text & ControlChars.NewLine & _
                                                    Data.time4.Text & ControlChars.NewLine & _
                                                    Data.complete5.Text & ControlChars.NewLine & _
                                                    Data.first5.Text & ControlChars.NewLine & _
                                                    Data.time5.Text & ControlChars.NewLine & _
                                                    Data.complete6.Text & ControlChars.NewLine & _
                                                    Data.first6.Text & ControlChars.NewLine & _
                                                    Data.time6.Text & ControlChars.NewLine & _
                                                    Data.complete7.Text & ControlChars.NewLine & _
                                                    Data.first7.Text & ControlChars.NewLine & _
                                                    Data.time7.Text & ControlChars.NewLine & _
                                                    Data.complete8.Text & ControlChars.NewLine & _
                                                    Data.first8.Text & ControlChars.NewLine & _
                                                    Data.time8.Text & ControlChars.NewLine & _
                                                    Data.complete9.Text & ControlChars.NewLine & _
                                                    Data.first9.Text & ControlChars.NewLine & _
                                                    Data.time9.Text & ControlChars.NewLine & _
                                                    Data.complete10.Text & ControlChars.NewLine & _
                                                    Data.first10.Text & ControlChars.NewLine & _
                                                    Data.time10.Text & ControlChars.NewLine, False)

            End If
            Data.startFirst.Text = "False"
        End If


    End Sub

    Private Sub lblSelectare_Click(sender As Object, e As EventArgs) Handles lblSelectare.Click
        LevelSelect.Show()
        Me.Close()


    End Sub

    Private Sub lblReset_Click(sender As Object, e As EventArgs) Handles lblReset.Click
        If MessageBox.Show("Aceasta comanda va reseta toate datele si va trebui sa o iei de la capat! Esti sigur ca vrei sa faci asta? ", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Data.complete1.Text = False
            Data.complete2.Text = False
            Data.complete3.Text = False
            Data.complete4.Text = False
            Data.complete5.Text = False
            Data.complete6.Text = False
            Data.complete7.Text = False
            Data.complete8.Text = False
            Data.complete9.Text = False
            Data.complete10.Text = False
            Data.first1.Text = True
            Data.first2.Text = True
            Data.first3.Text = True
            Data.first4.Text = True
            Data.first5.Text = True
            Data.first6.Text = True
            Data.first7.Text = True
            Data.first8.Text = True
            Data.first9.Text = True
            Data.first10.Text = True
            Data.time1.Text = 0
            Data.time2.Text = 0
            Data.time3.Text = 0
            Data.time4.Text = 0
            Data.time5.Text = 0
            Data.time6.Text = 0
            Data.time7.Text = 0
            Data.time8.Text = 0
            Data.time9.Text = 0
            Data.time10.Text = 0
            MsgBox("Resetarea s-a realizat cu succes!")
        End If
    End Sub


End Class
