Public Class Form1
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        clear()
        Highlight(Color.LightBlue)
    End Sub
    Sub clear()
        LengthTextBox.Clear()
        WidthTextBox.Clear()
        AreaTextBox.Text = ""
        PerimeterTextBox.Text = ""
    End Sub
    Sub Highlight(C As Color)
        LengthTextBox.BackColor = C
        WidthTextBox.BackColor = C
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim Length As Integer
        Dim Width As Integer
        Integer.TryParse(LengthTextBox.Text, Length)
        Integer.TryParse(WidthTextBox.Text, Width)
        AreaTextBox.Text = Area(Length, Width)
        PerimeterTextBox.Text = Perimeter(Length, Width)
    End Sub
    Function Area(L As Integer, W As Integer) As Integer
        Return L * W
    End Function
    Function Perimeter(L As Integer, W As Integer) As Integer
        Return 2 * (L + W)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Highlight(sender.BackColor)
    End Sub
    Public Function TriangleArea(Base As Integer, Height As Integer) As Decimal
        Return Base * Height / 2
    End Function

    Private Sub TriangleAreaButton_Click(sender As Object, e As EventArgs) Handles TriangleAreaButton.Click
        Dim Base As Integer
        Dim Height As Integer

        Integer.TryParse(LengthTextBox.Text, Base)
        Integer.TryParse(WidthTextBox.Text, Height)
        AreaTextBox.Text = TriangleArea(Base, Height)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Highlight(sender.BackColor)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Highlight(sender.BackColor)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Highlight(sender.BackColor)
    End Sub
End Class
