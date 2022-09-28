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
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.GrandTotalLabel = New System.Windows.Forms.Label()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(309, 190)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TotalTextBox.TabIndex = 0
        '
        'GrandTotalLabel
        '
        Me.GrandTotalLabel.AutoSize = True
        Me.GrandTotalLabel.Location = New System.Drawing.Point(306, 224)
        Me.GrandTotalLabel.Name = "GrandTotalLabel"
        Me.GrandTotalLabel.Size = New System.Drawing.Size(0, 16)
        Me.GrandTotalLabel.TabIndex = 1
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(309, 161)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 23)
        Me.CalcButton.TabIndex = 2
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.GrandTotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents GrandTotalLabel As Label
    Friend WithEvents CalcButton As Button
End Class
