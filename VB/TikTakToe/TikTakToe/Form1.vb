Public Class Form1
    Dim Turn As String = "X"
    Dim Score1 As Integer
    Dim Score2 As Integer
    Sub reset()
        Me.BackColor = Color.Black
        B1.Text = ""
        B2.Text = ""
        B3.Text = ""
        B4.Text = ""
        B5.Text = ""
        B6.Text = ""
        B7.Text = ""
        B8.Text = ""
        B9.Text = ""
        Player1PointLabel.Text = Score1
        Player2PointLabel.Text = Score2
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs)

    End Sub
    Sub Pick(B As Button)
        B.Text = Turn
        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If
        Player1PointLabel.Text = Score1
        Player2PointLabel.Text = Score2
        MsgBox("Winner")
        reset()
        B1.Visible = False
        B2.Visible = False
        B3.Visible = False
        B4.Visible = False
        B5.Visible = False
        B6.Visible = False
        B7.Visible = False
        B8.Visible = False
        B9.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles B9.Click, B8.Click, B7.Click, B6.Click, B5.Click, B4.Click, B3.Click, B2.Click, B1.Click
        Pick(sender)
        If isWinner() Then
            Me.BackColor = Color.Green
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        reset()
    End Sub
    Function isWinner() As Boolean
        If B1.Text = B2.Text And B2.Text = B3.Text And B1.Text <> "" Then Return True
        If B1.Text = B4.Text And B4.Text = B7.Text And B1.Text <> "" Then Return True
        If B1.Text = B5.Text And B5.Text = B9.Text And B1.Text <> "" Then Return True
        If B2.Text = B5.Text And B5.Text = B8.Text And B2.Text <> "" Then Return True
        If B3.Text = B6.Text And B6.Text = B9.Text And B3.Text <> "" Then Return True
        If B3.Text = B5.Text And B5.Text = B7.Text And B3.Text <> "" Then Return True
        If B4.Text = B5.Text And B5.Text = B6.Text And B4.Text <> "" Then Return True
        If B7.Text = B8.Text And B8.Text = B9.Text And B7.Text <> "" Then Return True
        Return False
    End Function
End Class
