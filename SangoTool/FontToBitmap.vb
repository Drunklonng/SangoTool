Public Class FontTo
    Dim Config As String = Application.StartupPath + "\SangoTool.ini"
    Dim FontFile As String = GetINI("FontTool", "FontToBitmapFile", "", Config)
    Dim ImagePath As String = GetINI("FontTool", "FontToBitmapPath", "", Config)
    Dim CodePage = 950

    Private Sub ButtonFontToBitmap_Click(sender As Object, e As EventArgs) Handles ButtonFontToBitmap.Click
        If IO.File.Exists(FontFile) And IO.Directory.Exists(ImagePath) Then
            Dim FontData = GetFontData(FontFile)
            ProgressBarFontToBitmap.Value = 0
            ProgressBarFontToBitmap.Maximum = FontData(1) \ 100
            For i = 0 To FontData(1) - 1
                If i Mod 100 = 0 Then
                    ProgressBarFontToBitmap.Value = i \ 100
                End If
                Dim FontImage = FontToBitmap(FontFile, i, FontData)
                FontImage.Save(ImagePath + "\" + i.ToString + ".png")
            Next
            ProgressBarFontToBitmap.Value = ProgressBarFontToBitmap.Maximum
            FontToDefault(FontFile, ImagePath, CodePage)
            ProgressBarFontToBitmap.Value = 0
        Else
            MsgBox(LanguageText.SetSelectPath.Text)
        End If
    End Sub

    Private Sub ButtonFontToBitmapFile_Click(sender As Object, e As EventArgs) Handles ButtonFontToBitmapFile.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            FontFile = OpenFileDialog1.FileName
            TextBoxFontToBitmapFile.Text = FontFile
            WriteINI("FontTool", "FontToBitmapFile", FontFile, Config)
        End If
    End Sub

    Private Sub ButtonFontToBitmapPath_Click(sender As Object, e As EventArgs) Handles ButtonFontToBitmapPath.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            ImagePath = FolderBrowserDialog1.SelectedPath
            TextBoxFontToBitmapPath.Text = ImagePath
            WriteINI("FontTool", "FontToBitmapPath", ImagePath, Config)
        End If
    End Sub

    Private Sub CheckBoxFontToBitmapBig5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFontToBitmapBig5.CheckedChanged
        CheckBoxFontToBitmapGBK.Checked = Not CheckBoxFontToBitmapBig5.Checked
        If CheckBoxFontToBitmapGBK.Checked = True Then CodePage = 936
        If CheckBoxFontToBitmapBig5.Checked = True Then CodePage = 950
    End Sub

    Private Sub CheckBoxFontToBitmapGBK_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFontToBitmapGBK.CheckedChanged
        CheckBoxFontToBitmapBig5.Checked = Not CheckBoxFontToBitmapGBK.Checked
    End Sub

    Private Sub FontTo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxFontToBitmapFile.Text = FontFile
        TextBoxFontToBitmapPath.Text = ImagePath
    End Sub
End Class