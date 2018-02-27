Public Class ObjectColor
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ColorDialog1.Color = PictureBox1.BackColor
        ColorDialog1.ShowDialog()
        NumericUpDownR.Value = ColorDialog1.Color.R
        NumericUpDownG.Value = ColorDialog1.Color.G
        NumericUpDownB.Value = ColorDialog1.Color.B
        'PictureBox1.BackColor = ColorDialog1.Color
    End Sub

    Private Sub NumericUpDownR_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownR.ValueChanged
        PictureBox1.BackColor = Color.FromArgb(NumericUpDownR.Value, NumericUpDownG.Value, NumericUpDownB.Value)
    End Sub

    Private Sub NumericUpDownG_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownG.ValueChanged
        PictureBox1.BackColor = Color.FromArgb(NumericUpDownR.Value, NumericUpDownG.Value, NumericUpDownB.Value)
    End Sub

    Private Sub NumericUpDownB_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownB.ValueChanged
        PictureBox1.BackColor = Color.FromArgb(NumericUpDownR.Value, NumericUpDownG.Value, NumericUpDownB.Value)
    End Sub

    Private Sub TransparentON_CheckedChanged(sender As Object, e As EventArgs) Handles TransparentON.CheckedChanged
        PictureBox1.Enabled = False
        NumericUpDownR.Enabled = False
        NumericUpDownG.Enabled = False
        NumericUpDownB.Enabled = False
    End Sub

    Private Sub TransparentOFF_CheckedChanged(sender As Object, e As EventArgs) Handles TransparentOFF.CheckedChanged
        PictureBox1.Enabled = True
        NumericUpDownR.Enabled = True
        NumericUpDownG.Enabled = True
        NumericUpDownB.Enabled = True
    End Sub
End Class