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
        Me.P1Score = New System.Windows.Forms.Label()
        Me.P2Score = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PlayBall = New System.Windows.Forms.PictureBox()
        Me.TopBounceBall = New System.Windows.Forms.PictureBox()
        Me.BottomBounceBall = New System.Windows.Forms.PictureBox()
        Me.P1 = New System.Windows.Forms.PictureBox()
        Me.P2 = New System.Windows.Forms.PictureBox()
        CType(Me.PlayBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopBounceBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomBounceBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P1Score
        '
        Me.P1Score.AutoSize = True
        Me.P1Score.BackColor = System.Drawing.Color.Transparent
        Me.P1Score.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P1Score.ForeColor = System.Drawing.Color.White
        Me.P1Score.Location = New System.Drawing.Point(369, 32)
        Me.P1Score.Name = "P1Score"
        Me.P1Score.Size = New System.Drawing.Size(21, 23)
        Me.P1Score.TabIndex = 6
        Me.P1Score.Text = "0"
        '
        'P2Score
        '
        Me.P2Score.AutoSize = True
        Me.P2Score.BackColor = System.Drawing.Color.Transparent
        Me.P2Score.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2Score.ForeColor = System.Drawing.Color.White
        Me.P2Score.Location = New System.Drawing.Point(502, 32)
        Me.P2Score.Name = "P2Score"
        Me.P2Score.Size = New System.Drawing.Size(21, 23)
        Me.P2Score.TabIndex = 7
        Me.P2Score.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(340, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Player 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(473, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Player 2"
        '
        'PlayBall
        '
        Me.PlayBall.Image = Global.Bounce_Pong.My.Resources.Resources.NeonYellowPlayBall1
        Me.PlayBall.Location = New System.Drawing.Point(430, 261)
        Me.PlayBall.Name = "PlayBall"
        Me.PlayBall.Size = New System.Drawing.Size(40, 40)
        Me.PlayBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PlayBall.TabIndex = 10
        Me.PlayBall.TabStop = False
        '
        'TopBounceBall
        '
        Me.TopBounceBall.Image = Global.Bounce_Pong.My.Resources.Resources.NeonPurpleBall
        Me.TopBounceBall.Location = New System.Drawing.Point(412, 103)
        Me.TopBounceBall.Name = "TopBounceBall"
        Me.TopBounceBall.Size = New System.Drawing.Size(74, 72)
        Me.TopBounceBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.TopBounceBall.TabIndex = 5
        Me.TopBounceBall.TabStop = False
        '
        'BottomBounceBall
        '
        Me.BottomBounceBall.Image = Global.Bounce_Pong.My.Resources.Resources.NeonPurpleBall
        Me.BottomBounceBall.Location = New System.Drawing.Point(412, 390)
        Me.BottomBounceBall.Name = "BottomBounceBall"
        Me.BottomBounceBall.Size = New System.Drawing.Size(74, 72)
        Me.BottomBounceBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BottomBounceBall.TabIndex = 4
        Me.BottomBounceBall.TabStop = False
        '
        'P1
        '
        Me.P1.Image = Global.Bounce_Pong.My.Resources.Resources.NeonBluePlay
        Me.P1.Location = New System.Drawing.Point(65, 246)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(28, 68)
        Me.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.P1.TabIndex = 1
        Me.P1.TabStop = False
        '
        'P2
        '
        Me.P2.Image = Global.Bounce_Pong.My.Resources.Resources.NeonredPlayer3
        Me.P2.Location = New System.Drawing.Point(833, 246)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(28, 68)
        Me.P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.P2.TabIndex = 0
        Me.P2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(926, 566)
        Me.Controls.Add(Me.PlayBall)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.P2Score)
        Me.Controls.Add(Me.P1Score)
        Me.Controls.Add(Me.TopBounceBall)
        Me.Controls.Add(Me.BottomBounceBall)
        Me.Controls.Add(Me.P1)
        Me.Controls.Add(Me.P2)
        Me.Name = "Form1"
        Me.Text = "Bounce Pong"
        CType(Me.PlayBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopBounceBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomBounceBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents P2 As PictureBox
    Friend WithEvents P1 As PictureBox
    Friend WithEvents BottomBounceBall As PictureBox
    Friend WithEvents TopBounceBall As PictureBox
    Friend WithEvents P1Score As Label
    Friend WithEvents P2Score As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PlayBall As PictureBox
End Class
