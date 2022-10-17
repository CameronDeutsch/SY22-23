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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ForLoop = New System.Windows.Forms.Label()
        Me.BadGuy1 = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        CType(Me.BadGuy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'ForLoop
        '
        Me.ForLoop.AutoSize = True
        Me.ForLoop.Location = New System.Drawing.Point(281, 128)
        Me.ForLoop.Name = "ForLoop"
        Me.ForLoop.Size = New System.Drawing.Size(61, 16)
        Me.ForLoop.TabIndex = 1
        Me.ForLoop.Text = "For Loop"
        '
        'BadGuy1
        '
        Me.BadGuy1.Image = Global.Looping.My.Resources.Resources.white_shark_carcharodon_carcharias
        Me.BadGuy1.Location = New System.Drawing.Point(92, 233)
        Me.BadGuy1.Name = "BadGuy1"
        Me.BadGuy1.Size = New System.Drawing.Size(100, 50)
        Me.BadGuy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BadGuy1.TabIndex = 2
        Me.BadGuy1.TabStop = False
        '
        'Player
        '
        Me.Player.Image = Global.Looping.My.Resources.Resources.MexicanFlag
        Me.Player.Location = New System.Drawing.Point(398, 190)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(99, 56)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player.TabIndex = 0
        Me.Player.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BadGuy1)
        Me.Controls.Add(Me.ForLoop)
        Me.Controls.Add(Me.Player)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BadGuy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Player As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ForLoop As Label
    Friend WithEvents BadGuy1 As PictureBox
End Class
