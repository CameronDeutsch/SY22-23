Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age As Integer
        Integer.TryParse(Textbox1.text, age)
        Label1.Text = age
        If age > 17 Then
            Label1.Text = "You Can Vote"
            Me.BackColor = Color.Green

        Else
            Label1.Text = "You Cant Vote"
            Me.BackColor = Color.Red
        End If

        If RadioButton1.Checked Then
            Me.BackColor = Color.Aquamarine
        End If

        If RadioButton2.Checked Then
            Me.BackColor = Color.Maroon
        End If

        If RadioButton3.Checked Then
            Me.BackColor = Color.MediumPurple
        End If


    End Sub
End Class
