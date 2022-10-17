<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
<<<<<<< Updated upstream
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BulletPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox3 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Target = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BulletPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Target, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'BulletPictureBox2
        '
        Me.BulletPictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BulletPictureBox2.Image = Global.MyGame.My.Resources.Resources.donut_circle
        Me.BulletPictureBox2.Location = New System.Drawing.Point(737, 137)
        Me.BulletPictureBox2.Name = "BulletPictureBox2"
        Me.BulletPictureBox2.Size = New System.Drawing.Size(38, 34)
        Me.BulletPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BulletPictureBox2.TabIndex = 8
        Me.BulletPictureBox2.TabStop = False
        Me.BulletPictureBox2.Visible = False
        '
        'WallPictureBox3
        '
        Me.WallPictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox3.Location = New System.Drawing.Point(714, 113)
        Me.WallPictureBox3.Name = "WallPictureBox3"
        Me.WallPictureBox3.Size = New System.Drawing.Size(17, 184)
        Me.WallPictureBox3.TabIndex = 6
        Me.WallPictureBox3.TabStop = False
        '
        'WallPictureBox4
        '
        Me.WallPictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox4.Location = New System.Drawing.Point(164, 311)
        Me.WallPictureBox4.Name = "WallPictureBox4"
        Me.WallPictureBox4.Size = New System.Drawing.Size(388, 25)
        Me.WallPictureBox4.TabIndex = 5
        Me.WallPictureBox4.TabStop = False
        '
        'Target
        '
        Me.Target.Image = Global.MyGame.My.Resources.Resources.froyo_circle
        Me.Target.Location = New System.Drawing.Point(454, 86)
        Me.Target.Name = "Target"
        Me.Target.Size = New System.Drawing.Size(43, 50)
        Me.Target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Target.TabIndex = 1
        Me.Target.TabStop = False
        '
        'Player
        '
        Me.Player.Image = Global.MyGame.My.Resources.Resources.donut_circle
        Me.Player.Location = New System.Drawing.Point(137, 86)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(121, 72)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player.TabIndex = 0
        Me.Player.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BulletPictureBox2)
        Me.Controls.Add(Me.WallPictureBox3)
        Me.Controls.Add(Me.WallPictureBox4)
        Me.Controls.Add(Me.Target)
        Me.Controls.Add(Me.Player)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "MyGame"
        CType(Me.BulletPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Target, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Player As PictureBox
    Friend WithEvents Target As PictureBox
    Friend WithEvents WallPictureBox4 As PictureBox
    Friend WithEvents WallPictureBox3 As PictureBox
    Friend WithEvents BulletPictureBox2 As PictureBox
    Friend WithEvents Timer2 As Timer
=======
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.P2Score = New System.Windows.Forms.Label()
        Me.P1Score = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PlayBall = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.Player2 = New System.Windows.Forms.PictureBox()
        Me.TopBounceBall = New System.Windows.Forms.PictureBox()
        Me.BottomBounceBall = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PlayBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopBounceBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomBounceBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(475, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Player 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(342, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Player 1"
        '
        'P2Score
        '
        Me.P2Score.AutoSize = True
        Me.P2Score.BackColor = System.Drawing.Color.Transparent
        Me.P2Score.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2Score.ForeColor = System.Drawing.Color.White
        Me.P2Score.Location = New System.Drawing.Point(504, 32)
        Me.P2Score.Name = "P2Score"
        Me.P2Score.Size = New System.Drawing.Size(21, 23)
        Me.P2Score.TabIndex = 16
        Me.P2Score.Text = "0"
        '
        'P1Score
        '
        Me.P1Score.AutoSize = True
        Me.P1Score.BackColor = System.Drawing.Color.Transparent
        Me.P1Score.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P1Score.ForeColor = System.Drawing.Color.White
        Me.P1Score.Location = New System.Drawing.Point(371, 32)
        Me.P1Score.Name = "P1Score"
        Me.P1Score.Size = New System.Drawing.Size(21, 23)
        Me.P1Score.TabIndex = 15
        Me.P1Score.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PlayBall
        '
        Me.PlayBall.Image = Global.MyGame.My.Resources.Resources.NeonYellowPlayBall
        Me.PlayBall.Location = New System.Drawing.Point(432, 261)
        Me.PlayBall.Name = "PlayBall"
        Me.PlayBall.Size = New System.Drawing.Size(40, 40)
        Me.PlayBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PlayBall.TabIndex = 19
        Me.PlayBall.TabStop = False
        '
        'Player
        '
        Me.Player.Image = Global.MyGame.My.Resources.Resources.NeonBluePlay
        Me.Player.Location = New System.Drawing.Point(67, 246)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(28, 68)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Player.TabIndex = 12
        Me.Player.TabStop = False
        '
        'Player2
        '
        Me.Player2.Image = Global.MyGame.My.Resources.Resources.NeonredPlayer
        Me.Player2.Location = New System.Drawing.Point(835, 246)
        Me.Player2.Name = "Player2"
        Me.Player2.Size = New System.Drawing.Size(28, 68)
        Me.Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Player2.TabIndex = 11
        Me.Player2.TabStop = False
        '
        'TopBounceBall
        '
        Me.TopBounceBall.Image = Global.MyGame.My.Resources.Resources.NeonPurpleBall
        Me.TopBounceBall.Location = New System.Drawing.Point(414, 103)
        Me.TopBounceBall.Name = "TopBounceBall"
        Me.TopBounceBall.Size = New System.Drawing.Size(74, 72)
        Me.TopBounceBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.TopBounceBall.TabIndex = 14
        Me.TopBounceBall.TabStop = False
        '
        'BottomBounceBall
        '
        Me.BottomBounceBall.Image = Global.MyGame.My.Resources.Resources.NeonPurpleBall
        Me.BottomBounceBall.Location = New System.Drawing.Point(414, 390)
        Me.BottomBounceBall.Name = "BottomBounceBall"
        Me.BottomBounceBall.Size = New System.Drawing.Size(74, 72)
        Me.BottomBounceBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BottomBounceBall.TabIndex = 13
        Me.BottomBounceBall.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 562)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(929, 10)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(-2, -4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(929, 10)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(926, 566)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PlayBall)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.P2Score)
        Me.Controls.Add(Me.P1Score)
        Me.Controls.Add(Me.TopBounceBall)
        Me.Controls.Add(Me.BottomBounceBall)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.Player2)
        Me.Name = "Form1"
        CType(Me.PlayBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopBounceBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomBounceBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlayBall As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents P2Score As Label
    Friend WithEvents P1Score As Label
    Friend WithEvents Player As PictureBox
    Friend WithEvents Player2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TopBounceBall As PictureBox
    Friend WithEvents BottomBounceBall As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
>>>>>>> Stashed changes
End Class
