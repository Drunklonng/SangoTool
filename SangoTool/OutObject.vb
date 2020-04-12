Public Class OutObject
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IO.Directory.Exists(FolderBrowserDialog1.SelectedPath) Then
            SplitContainer1.Panel1Collapsed = True
            SplitContainer1.Panel2Collapsed = False
            Me.Close()
        Else
            MsgBox(LanguageText.SetSelectPath.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class