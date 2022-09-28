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
        Me.LengthTextBox = New System.Windows.Forms.TextBox()
        Me.WidthTextBox = New System.Windows.Forms.TextBox()
        Me.LengthLabel = New System.Windows.Forms.Label()
        Me.WidthLabel = New System.Windows.Forms.Label()
        Me.AreaLabel = New System.Windows.Forms.Label()
        Me.PerimeterLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.AreaTextBox = New System.Windows.Forms.Label()
        Me.PerimeterTextBox = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TriangleAreaButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LengthTextBox
        '
        Me.LengthTextBox.Location = New System.Drawing.Point(388, 133)
        Me.LengthTextBox.Name = "LengthTextBox"
        Me.LengthTextBox.Size = New System.Drawing.Size(100, 22)
        Me.LengthTextBox.TabIndex = 0
        '
        'WidthTextBox
        '
        Me.WidthTextBox.Location = New System.Drawing.Point(388, 161)
        Me.WidthTextBox.Name = "WidthTextBox"
        Me.WidthTextBox.Size = New System.Drawing.Size(100, 22)
        Me.WidthTextBox.TabIndex = 1
        '
        'LengthLabel
        '
        Me.LengthLabel.AutoSize = True
        Me.LengthLabel.Location = New System.Drawing.Point(314, 139)
        Me.LengthLabel.Name = "LengthLabel"
        Me.LengthLabel.Size = New System.Drawing.Size(50, 16)
        Me.LengthLabel.TabIndex = 4
        Me.LengthLabel.Text = "Length:"
        '
        'WidthLabel
        '
        Me.WidthLabel.AutoSize = True
        Me.WidthLabel.Location = New System.Drawing.Point(314, 167)
        Me.WidthLabel.Name = "WidthLabel"
        Me.WidthLabel.Size = New System.Drawing.Size(44, 16)
        Me.WidthLabel.TabIndex = 5
        Me.WidthLabel.Text = "Width:"
        '
        'AreaLabel
        '
        Me.AreaLabel.AutoSize = True
        Me.AreaLabel.Location = New System.Drawing.Point(314, 195)
        Me.AreaLabel.Name = "AreaLabel"
        Me.AreaLabel.Size = New System.Drawing.Size(39, 16)
        Me.AreaLabel.TabIndex = 6
        Me.AreaLabel.Text = "Area:"
        '
        'PerimeterLabel
        '
        Me.PerimeterLabel.AutoSize = True
        Me.PerimeterLabel.Location = New System.Drawing.Point(314, 223)
        Me.PerimeterLabel.Name = "PerimeterLabel"
        Me.PerimeterLabel.Size = New System.Drawing.Size(68, 16)
        Me.PerimeterLabel.TabIndex = 7
        Me.PerimeterLabel.Text = "Perimeter:"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(332, 275)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(413, 275)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 9
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'AreaTextBox
        '
        Me.AreaTextBox.AutoSize = True
        Me.AreaTextBox.Location = New System.Drawing.Point(385, 195)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.Size = New System.Drawing.Size(0, 16)
        Me.AreaTextBox.TabIndex = 10
        '
        'PerimeterTextBox
        '
        Me.PerimeterTextBox.AutoSize = True
        Me.PerimeterTextBox.Location = New System.Drawing.Point(388, 223)
        Me.PerimeterTextBox.Name = "PerimeterTextBox"
        Me.PerimeterTextBox.Size = New System.Drawing.Size(0, 16)
        Me.PerimeterTextBox.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(550, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(606, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Orange
        Me.Button3.Location = New System.Drawing.Point(550, 223)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 50)
        Me.Button3.TabIndex = 14
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Purple
        Me.Button4.Location = New System.Drawing.Point(606, 223)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 50)
        Me.Button4.TabIndex = 15
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TriangleAreaButton
        '
        Me.TriangleAreaButton.Location = New System.Drawing.Point(355, 304)
        Me.TriangleAreaButton.Name = "TriangleAreaButton"
        Me.TriangleAreaButton.Size = New System.Drawing.Size(103, 25)
        Me.TriangleAreaButton.TabIndex = 16
        Me.TriangleAreaButton.Text = "Triangle Area"
        Me.TriangleAreaButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TriangleAreaButton)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PerimeterTextBox)
        Me.Controls.Add(Me.AreaTextBox)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.PerimeterLabel)
        Me.Controls.Add(Me.AreaLabel)
        Me.Controls.Add(Me.WidthLabel)
        Me.Controls.Add(Me.LengthLabel)
        Me.Controls.Add(Me.WidthTextBox)
        Me.Controls.Add(Me.LengthTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LengthTextBox As TextBox
    Friend WithEvents WidthTextBox As TextBox
    Friend WithEvents LengthLabel As Label
    Friend WithEvents WidthLabel As Label
    Friend WithEvents AreaLabel As Label
    Friend WithEvents PerimeterLabel As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents CalculateButton As Button
    Friend WithEvents AreaTextBox As Label
    Friend WithEvents PerimeterTextBox As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TriangleAreaButton As Button
End Class
