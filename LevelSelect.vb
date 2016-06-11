Public Class LevelSelect
    'variabila timp reprezinta timpul total in care ai trecut cu succes nivelul
    Dim timp As Integer
    'min reprezinta minutele, sec secundele, middle reprezinta : in cazul in care sunt 10 secunde sau mai mult
    'si :0 in cazul in care se inregistreaza mai putin de 10 secunde
    Dim min As Integer
    Dim sec As Integer
    Dim middle As String
    Dim intSound As Integer = 0
    Dim snd As New sound

    Private Sub LevelSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        'aceste serii de If-uri verfica etichetele din formularul Data
        'si daca afiseaza "True" pentru nivelul respectiv atunci 
        'deblocheaza nivelul
        If Data.complete1.Text = "True" Then
            lblLevel1.Visible = False
            lblLevel2.Visible = False
        End If
        If Data.complete2.Text = "True" Then
            lblLevel3.Visible = False
        End If
        If Data.complete3.Text = "True" Then
            lblLevel4.Visible = False
        End If
        If Data.complete4.Text = "True" Then
            lblLevel5.Visible = False
        End If
        If Data.complete5.Text = "True" Then
            lblLevel6.Visible = False
        End If
        If Data.complete6.Text = "True" Then
            lblLevel7.Visible = False
        End If
        If Data.complete7.Text = "True" Then
            lblLevel8.Visible = False
        End If
        If Data.complete8.Text = "True" Then
            lblLevel9.Visible = False
        End If
        'If Data.complete9.Text = "True" Then
        '  lblLevel10.Visible = False
        'End If
        'If Data.complete10.Text = "True" Then
        'lblLevel10.Visible = False
        'End If
        'Functia convertToTime va prelua timpul (numarul total de secunde)
        'din forumlarul Data si il va converti in formatul timp
        'timp = Convert.ToInt32(Data.time1.Text)
        Int32.TryParse(Data.time1.Text, timp)
        convertToTime()
        lbltime1.Text = min & middle & sec

        Int32.TryParse(Data.time2.Text, timp)
        convertToTime()
        lbltime2.Text = min & middle & sec

        Int32.TryParse(Data.time3.Text, timp)
        convertToTime()
        lbltime3.Text = min & middle & sec

        Int32.TryParse(Data.time4.Text, timp)
        convertToTime()
        lbltime4.Text = min & middle & sec

        Int32.TryParse(Data.time5.Text, timp)
        convertToTime()
        lbltime5.Text = min & middle & sec

        Int32.TryParse(Data.time6.Text, timp)
        convertToTime()
        lbltime6.Text = min & middle & sec

        Int32.TryParse(Data.time7.Text, timp)
        convertToTime()
        lbltime7.Text = min & middle & sec

        Int32.TryParse(Data.time8.Text, timp)
        convertToTime()
        lbltime8.Text = min & middle & sec

        Int32.TryParse(Data.time9.Text, timp)
        convertToTime()
        lbltime9.Text = min & middle & sec

        'Int32.TryParse(Data.time10.Text, timp)
        'convertToTime()
        'lbltime10.Text = min & middle & sec

    End Sub

    Private Sub lblBackToMenu_Click(sender As Object, e As EventArgs) Handles lblBackToMenu.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub lblBackToMenu_MouseEnter(sender As Object, e As EventArgs) Handles lblBackToMenu.MouseEnter

        intSound += 1
        With snd
            .Name = "SOUND" & intSound
            .play(1, False, 300)
        End With
        lblBackToMenu.Top -= 5
    End Sub

    Private Sub lblBackToMenu_MouseLeave(sender As Object, e As EventArgs) Handles lblBackToMenu.MouseLeave
        lblBackToMenu.Top += 5
    End Sub
    Private Sub convertToTime()
        sec = timp Mod 60 'imparte la 60 si setaza secundele
        min = (timp / 60) 'seteaza minutele ca valoare intreaga
        If (sec >= 30) And (min > 0) Then
            min -= 1
        End If
        'daca sunt mai putin de 10 secunde middle va fi :0 altfel va fi :
        If sec < 10 Then
            middle = ":0"
        Else
            middle = ":"
        End If
    End Sub

    Private Sub Level1_Click(sender As Object, e As EventArgs) Handles Level1.Click
        Level_1.Show()
        Me.Close()

    End Sub

    Private Sub Level2_Click(sender As Object, e As EventArgs) Handles Level2.Click
        Level_2.Show()
        Me.Close()
    End Sub

    Private Sub Level3_Click(sender As Object, e As EventArgs) Handles Level3.Click
        Level_3.Show()
        Me.Close()
    End Sub

    Private Sub Level4_Click(sender As Object, e As EventArgs) Handles Level4.Click
        Level_4.Show()
        Me.Close()
    End Sub

    Private Sub Level5_Click(sender As Object, e As EventArgs) Handles Level5.Click
        level_5.Show()
        Me.Close()
    End Sub

    Private Sub Level6_Click(sender As Object, e As EventArgs) Handles Level6.Click
        Level_6.Show()
        Me.Close()
    End Sub

    Private Sub Level7_Click(sender As Object, e As EventArgs) Handles Level7.Click
        level_7.Show()
        Me.Close()
    End Sub

    Private Sub Level8_Click(sender As Object, e As EventArgs) Handles Level8.Click
        Level_8.Show()
        Me.Close()
    End Sub

    Private Sub Level9_Click(sender As Object, e As EventArgs) Handles Level9.Click
        Level_9.Show()
        Me.Close()
    End Sub


    Private Sub lblLevel1_MouseEnter(sender As Object, e As EventArgs)
        intSound += 1
        With snd
            .Name = "SOUND" & intSound
            .play(1, False, 300)
        End With
    End Sub
End Class