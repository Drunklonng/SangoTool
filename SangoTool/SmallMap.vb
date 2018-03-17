Public Class SmallMap
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.FileName = GetINI("SmallMap", "ImagePath", "", Application.StartupPath + "\SangoTool.ini")
        OpenFileDialog1.FilterIndex = GetINI("SmallMap", "FilterIndex", 1, Application.StartupPath + "\SangoTool.ini")
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            WriteINI("SmallMap", "ImagePath", OpenFileDialog1.FileName, Application.StartupPath + "\SangoTool.ini")
            If OpenFileDialog1.FilterIndex = 1 Then
                WriteINI("SmallMap", "FilterIndex", 1, Application.StartupPath + "\SangoTool.ini")
                PictureBox1.Image = New Bitmap(Image.FromFile(OpenFileDialog1.FileName), 382, 270)
            ElseIf OpenFileDialog1.FilterIndex = 2 Then
                WriteINI("SmallMap", "FilterIndex", 2, Application.StartupPath + "\SangoTool.ini")
                PictureBox1.Image = New Bitmap(SHPToBitmap(OpenFileDialog1.FileName), 382, 270)
            ElseIf OpenFileDialog1.FilterIndex = 3 Then
                WriteINI("SmallMap", "FilterIndex", 3, Application.StartupPath + "\SangoTool.ini")
                PictureBox1.Image = New Bitmap(SmallMapToBitmap(OpenFileDialog1.FileName), 382, 270)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.SelectedPath = GetINI("SmallMap", "SmallMapPath", "", Application.StartupPath + "\SangoTool.ini")
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            WriteINI("SmallMap", "SmallMapPath", FolderBrowserDialog1.SelectedPath, Application.StartupPath + "\SangoTool.ini")
            BitmapToSmallMap(PictureBox1.Image, FolderBrowserDialog1.SelectedPath + "\smallmap.shp.raw")
        End If
    End Sub
End Class