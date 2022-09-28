Public Class Form1
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click

        Dim total As Decimal
        Decimal.TryParse(TotalTextBox.Text, total)

        Dim grandTotal As Decimal
        grandTotal = total * (1.15)

        GrandTotalLabel.Text = grandTotal.ToString("C2")

    End Sub
End Class
