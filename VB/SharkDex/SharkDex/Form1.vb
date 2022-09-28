Public Class Form1
    Private Sub HammerheadButton_Click(sender As Object, e As EventArgs) Handles HammerheadButton.Click
        DisplayPictureBox.Image = HammerheadPictureBox.Image
        NameLabel.Text = "Scalloped Hammerhead Shark"
        GillsLabel.Text = "5"
        FinsLabel.Text = "8"
        LengthLabel.Text = "12ft"
        WeightLabel.Text = "180lbs"
    End Sub

    Private Sub SalmonSharkButton_Click(sender As Object, e As EventArgs) Handles SalmonSharkButton.Click
        DisplayPictureBox.Image = SalmonSharkPictureBox.Image
        NameLabel.Text = "Salmon Shark"
        GillsLabel.Text = "5"
        FinsLabel.Text = "3"
        LengthLabel.Text = "6ft"
        WeightLabel.Text = "210lb"
    End Sub

    Private Sub WhiteSharkButton_Click(sender As Object, e As EventArgs) Handles WhiteSharkButton.Click
        DisplayPictureBox.Image = WhiteSharkPictureBox.Image
        NameLabel.Text = "White Shark"
        GillsLabel.Text = "5"
        FinsLabel.Text = "8"
        LengthLabel.Text = "15ft"
        WeightLabel.Text = "4,200lb"
    End Sub

    Private Sub WhaleSharkButton_Click(sender As Object, e As EventArgs) Handles WhaleSharkButton.Click
        DisplayPictureBox.Image = WhaleSharkPictureBox.Image
        NameLabel.Text = "Whale Shark"
        GillsLabel.Text = "5"
        FinsLabel.Text = "6"
        LengthLabel.Text = "39ft"
        WeightLabel.Text = "41,000bl"
    End Sub

    Private Sub NurseSharkButton_Click(sender As Object, e As EventArgs) Handles NurseSharkButton.Click
        DisplayPictureBox.Image = NurseSharkPictureBox.Image
        NameLabel.Text = "Nurse Shark"
        GillsLabel.Text = "4"
        FinsLabel.Text = "9"
        LengthLabel.Text = "7ft"
        WeightLabel.Text = "130bl"
    End Sub
End Class