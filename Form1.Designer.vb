<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblInstructiuni2 = New System.Windows.Forms.Label()
        Me.lblReset = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblSelectare = New System.Windows.Forms.Label()
        Me.lblInstructiuni = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.MazeGame.My.Resources.Resources.Maze
        Me.PictureBox1.Location = New System.Drawing.Point(122, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(502, 389)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'lblInstructiuni2
        '
        Me.lblInstructiuni2.BackColor = System.Drawing.Color.Black
        Me.lblInstructiuni2.ForeColor = System.Drawing.Color.Maroon
        Me.lblInstructiuni2.Location = New System.Drawing.Point(105, 9)
        Me.lblInstructiuni2.Name = "lblInstructiuni2"
        Me.lblInstructiuni2.Size = New System.Drawing.Size(539, 433)
        Me.lblInstructiuni2.TabIndex = 13
        Me.lblInstructiuni2.Text = "Instructiuni"
        Me.lblInstructiuni2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblInstructiuni2.Visible = False
        '
        'lblReset
        '
        Me.lblReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReset.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReset.ForeColor = System.Drawing.Color.Magenta
        Me.lblReset.Location = New System.Drawing.Point(286, 633)
        Me.lblReset.Name = "lblReset"
        Me.lblReset.Size = New System.Drawing.Size(197, 50)
        Me.lblReset.TabIndex = 12
        Me.lblReset.Text = "Reset Level "
        Me.lblReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExit
        '
        Me.lblExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblExit.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.Color.Yellow
        Me.lblExit.Location = New System.Drawing.Point(427, 549)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(197, 50)
        Me.lblExit.TabIndex = 11
        Me.lblExit.Text = "Exit Game"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSelectare
        '
        Me.lblSelectare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSelectare.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectare.ForeColor = System.Drawing.Color.Lime
        Me.lblSelectare.Location = New System.Drawing.Point(122, 549)
        Me.lblSelectare.Name = "lblSelectare"
        Me.lblSelectare.Size = New System.Drawing.Size(197, 50)
        Me.lblSelectare.TabIndex = 10
        Me.lblSelectare.Text = "Level Select"
        Me.lblSelectare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInstructiuni
        '
        Me.lblInstructiuni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInstructiuni.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructiuni.ForeColor = System.Drawing.Color.Blue
        Me.lblInstructiuni.Location = New System.Drawing.Point(427, 473)
        Me.lblInstructiuni.Name = "lblInstructiuni"
        Me.lblInstructiuni.Size = New System.Drawing.Size(197, 50)
        Me.lblInstructiuni.TabIndex = 9
        Me.lblInstructiuni.Text = "Instructions"
        Me.lblInstructiuni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStart
        '
        Me.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStart.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.Color.Red
        Me.lblStart.Location = New System.Drawing.Point(122, 473)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(197, 50)
        Me.lblStart.TabIndex = 8
        Me.lblStart.Text = "Start Game"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(759, 812)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblInstructiuni2)
        Me.Controls.Add(Me.lblReset)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblSelectare)
        Me.Controls.Add(Me.lblInstructiuni)
        Me.Controls.Add(Me.lblStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblInstructiuni2 As System.Windows.Forms.Label
    Friend WithEvents lblReset As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents lblSelectare As System.Windows.Forms.Label
    Friend WithEvents lblInstructiuni As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label

End Class
