Public Class Transform
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        NumericUpDownZoom.Value = TrackBar1.Value
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownZoom.ValueChanged
        TrackBar1.Value = NumericUpDownZoom.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ZoomFalse.Checked = True
        FlipFalse.Checked = True
        NumericUpDownZoom.Value = 100
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class