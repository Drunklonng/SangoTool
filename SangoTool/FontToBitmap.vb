Public Class FontTo
    Dim FontFile As String = "E:\cht36.fnt"
    Dim ImagePath As String = "E:\000\"
    Dim CodePage = 950

    Private Sub ButtonFontToBitmap_Click(sender As Object, e As EventArgs) Handles ButtonFontToBitmap.Click
        Dim FontData = GetFontData(FontFile)
        ProgressBarFontToBitmap.Maximum = FontData(1)
        ProgressBarFontToBitmap.Value = 0
        FontToDefault(FontFile, ImagePath, CodePage)
        For i = 0 To FontData(1) - 1
            Dim FontImage = FontToBitmap(FontFile, i, FontData)
            FontImage.Save(ImagePath + "\" + i.ToString + ".png")
            ProgressBarFontToBitmap.Value = i + 1
        Next
    End Sub

    Private Sub ButtonFontToBitmapFile_Click(sender As Object, e As EventArgs) Handles ButtonFontToBitmapFile.Click
        OpenFileDialog1.ShowDialog()
        FontFile = OpenFileDialog1.FileName
        TextBoxFontToBitmapFile.Text = FontFile
    End Sub

    Private Sub ButtonFontToBitmapPath_Click(sender As Object, e As EventArgs) Handles ButtonFontToBitmapPath.Click
        FolderBrowserDialog1.ShowDialog()
        ImagePath = FolderBrowserDialog1.SelectedPath
        TextBoxFontToBitmapPath.Text = ImagePath
    End Sub

    Private Sub CheckBoxFontToBitmapBig5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFontToBitmapBig5.CheckedChanged
        CheckBoxFontToBitmapGBK.Checked = Not CheckBoxFontToBitmapBig5.Checked
        If CheckBoxFontToBitmapGBK.Checked = True Then CodePage = 936
        If CheckBoxFontToBitmapBig5.Checked = True Then CodePage = 950
    End Sub

    Private Sub CheckBoxFontToBitmapGBK_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFontToBitmapGBK.CheckedChanged
        CheckBoxFontToBitmapBig5.Checked = Not CheckBoxFontToBitmapGBK.Checked
    End Sub
End Class