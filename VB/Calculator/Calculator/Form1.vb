Public Class Form1

    Dim First As Decimal
    Dim Second As Decimal
    Dim Oper As String
    Dim Mem As Decimal
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click, Button0.Click
        DisplayTextBox.Text += sender.text
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        DisplayTextBox.Clear()
    End Sub

    Private Sub ButtonPlus_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click
        Decimal.TryParse(DisplayTextBox.Text, First)
        DisplayTextBox.Clear()
        Oper = sender.Text
    End Sub

    Private Sub ButtonEquals_Click(sender As Object, e As EventArgs) Handles ButtonEquals.Click
        Decimal.TryParse(DisplayTextBox.Text, Second)
        If Oper = "+" Then
            DisplayTextBox.Text = First + Second
        End If

        If Oper = "-" Then
            DisplayTextBox.Text = First - Second
        End If

        If Oper = "x" Then
            DisplayTextBox.Text = First * Second
        End If

        If Oper = "÷" Then
            DisplayTextBox.Text = First / Second
        End If

    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        Decimal.TryParse(DisplayTextBox.Text, First)
        DisplayTextBox.Clear()
        Oper = sender.Text
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        Decimal.TryParse(DisplayTextBox.Text, First)
        DisplayTextBox.Clear()
        Oper = sender.Text
    End Sub

    Private Sub ButtonMinus_Click(sender As Object, e As EventArgs) Handles ButtonMinus.Click
        Decimal.TryParse(DisplayTextBox.Text, First)
        DisplayTextBox.Clear()
        Oper = sender.Text
    End Sub

    Private Sub ButtonPi_Click(sender As Object, e As EventArgs) Handles ButtonPi.Click
        DisplayTextBox.Text = Math.PI
    End Sub

    Private Sub ButtonSquareRoot_Click_1(sender As Object, e As EventArgs) Handles ButtonSquareRoot.Click
        Decimal.TryParse(DisplayTextBox.Text, First)
        DisplayTextBox.Text = Math.Sqrt(First)
    End Sub

    Private Sub ButtonSIN_Click(sender As Object, e As EventArgs) Handles ButtonSIN.Click
        Decimal.TryParse(DisplayTextBox.Text, First)
        DisplayTextBox.Text = Math.Sin(First)
    End Sub

    Private Sub ButtonCOS_Click(sender As Object, e As EventArgs) Handles ButtonCOS.Click
        Decimal.TryParse(DisplayTextBox.Text, First)
        DisplayTextBox.Text = Math.Cos(First)
    End Sub

    Private Sub ButtonTAN_Click(sender As Object, e As EventArgs) Handles ButtonTAN.Click
        Decimal.TryParse(DisplayTextBox.Text, First)
        DisplayTextBox.Text = Math.Tan(First)
    End Sub
End Class
