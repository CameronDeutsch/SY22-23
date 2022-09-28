Public Class Form1
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles ConvertButton.Click

        Dim Dollars As Decimal
        Decimal.TryParse(JapaneseTextBox.Text, Dollars)
        Dim Yen As Decimal
        Yen = Dollars * 136.5
        JapaneseTextBox.Text = Yen.ToString("n2")

        Dim Pesos As Decimal
        Pesos = Dollars * 19.93
        MexicanTextBox.Text = Pesos.ToString("n2")

        Dim Dollar As Decimal
        Dollar = Dollars * 1.43
        AustralianTextBox.Text = Pesos.ToString("n2")

        Dim Euro As Decimal
        Euro = Dollars * 1
        GermanTextBox.Text = Euro.ToString("n2")

        Dim Yuan As Decimal
        Yuan = Dollars * 6.85
        ChineseTextBox.Text = Yuan.ToString("n2")

        Dim Pound As Decimal
        Pound = Dollars * 0.84
        EnglishTextBox.Text = Pound.ToString("n2")

    End Sub
End Class
