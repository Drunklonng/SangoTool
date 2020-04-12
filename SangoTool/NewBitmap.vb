Public Class NewBitmap
    Dim FontName As String = ""
    Dim IsBold As Boolean = False
    Dim IsPixel As Boolean = False
    Dim FontSizePx As Int16 = 16
    Dim FontSizePt As Int16 = 12
    Dim BitmapWidth As Int16 = 16
    Dim BitmapHeight As Int16 = 16
    Dim OffsetX As Int16 = 0
    Dim OffsetY As Int16 = 0
    Dim CodePage As Int32 = 950
    Private Sub ButtonRun_Click(sender As Object, e As EventArgs) Handles ButtonRun.Click
        If IO.Directory.Exists(TextBoxNewBitmapPath.Text) Then
            ProgressBarNewBitmap.Value = 0
            Select Case CodePage
                Case 936
                    ProgressBarNewBitmap.Maximum = 255 - 129
                    For big = 129 To 254
                        ProgressBarNewBitmap.Value = big - 129
                        For little1 = 64 To 126
                            Dim BitmapIndex As UInt16 = (big - 129) * 190 + (little1 - 64)
                            Dim FontString = System.Text.Encoding.GetEncoding(936).GetString({big, little1})
                            If CheckBoxConvert.Checked Then
                                If ComboBoxConvert.Text = "Simplified Font" Then
                                    FontString = Strings.StrConv(FontString, VbStrConv.SimplifiedChinese)
                                Else
                                    FontString = Strings.StrConv(FontString, VbStrConv.TraditionalChinese)
                                End If
                            End If
                            Dim FontImage = CreateFontBitmap(FontString, FontName, FontSizePt, BitmapWidth, BitmapHeight, OffsetX, OffsetY, IsBold, IsPixel)
                            FontImage.Save(TextBoxNewBitmapPath.Text + "\" + BitmapIndex.ToString + ".png")
                        Next
                        For little2 = 128 To 254
                            Dim BitmapIndex As UInt16 = (big - 129) * 190 + 63 + (little2 - 128)
                            Dim FontString = System.Text.Encoding.GetEncoding(936).GetString({big, little2})
                            If CheckBoxConvert.Checked Then
                                If ComboBoxConvert.Text = "Simplified Font" Then
                                    FontString = Strings.StrConv(FontString, VbStrConv.SimplifiedChinese)
                                Else
                                    FontString = Strings.StrConv(FontString, VbStrConv.TraditionalChinese)
                                End If
                            End If
                            Dim FontImage = CreateFontBitmap(FontString, FontName, FontSizePt, BitmapWidth, BitmapHeight, OffsetX, OffsetY, IsBold, IsPixel)
                            FontImage.Save(TextBoxNewBitmapPath.Text + "\" + BitmapIndex.ToString + ".png")
                        Next
                    Next
                Case 950
                    ProgressBarNewBitmap.Maximum = 249 - 161
                    For big = 161 To 249
                        ProgressBarNewBitmap.Value = big - 161
                        For little1 = 64 To 126
                            Dim BitmapIndex As UInt16 = (big - 161) * 157 + (little1 - 64)
                            Dim FontString = System.Text.Encoding.GetEncoding(950).GetString({big, little1})
                            If CheckBoxConvert.Checked Then
                                If ComboBoxConvert.Text = "Simplified Font" Then
                                    FontString = Strings.StrConv(FontString, VbStrConv.SimplifiedChinese)
                                Else
                                    FontString = Strings.StrConv(FontString, VbStrConv.TraditionalChinese)
                                End If
                            End If
                            Dim FontImage = CreateFontBitmap(FontString, FontName, FontSizePt, BitmapWidth, BitmapHeight, OffsetX, OffsetY, IsBold, IsPixel)
                            FontImage.Save(TextBoxNewBitmapPath.Text + "\" + BitmapIndex.ToString + ".png")
                        Next
                        For little2 = 161 To 254
                            Dim BitmapIndex As UInt16 = (big - 161) * 157 + 63 + (little2 - 161)
                            Dim FontString = System.Text.Encoding.GetEncoding(950).GetString({big, little2})
                            If CheckBoxConvert.Checked Then
                                If ComboBoxConvert.Text = "Simplified Font" Then
                                    FontString = Strings.StrConv(FontString, VbStrConv.SimplifiedChinese)
                                Else
                                    FontString = Strings.StrConv(FontString, VbStrConv.TraditionalChinese)
                                End If
                            End If
                            Dim FontImage = CreateFontBitmap(FontString, FontName, FontSizePt, BitmapWidth, BitmapHeight, OffsetX, OffsetY, IsBold, IsPixel)
                            FontImage.Save(TextBoxNewBitmapPath.Text + "\" + BitmapIndex.ToString + ".png")
                        Next
                    Next
                Case Else
                    Dim BitmapIndex As UInt16 = 0
                    Dim FontString = System.Text.Encoding.GetEncoding(950).GetString({165, 64})
                    Dim FontImage = CreateFontBitmap(FontString, FontName, FontSizePt, BitmapWidth, BitmapHeight, OffsetX, OffsetY, IsBold, IsPixel)
                    FontImage.Save(TextBoxNewBitmapPath.Text + "\" + BitmapIndex.ToString + ".png")
            End Select
            ProgressBarNewBitmap.Value = ProgressBarNewBitmap.Maximum
            NewFontDefault(FontSizePx, TextBoxNewBitmapPath.Text, CodePage)
            ProgressBarNewBitmap.Value = 0
        Else
            MsgBox(LanguageText.SetSelectPath.Text)
        End If
    End Sub

    Private Sub ButtonFont_Click(sender As Object, e As EventArgs) Handles ButtonFont.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            FontName = FontDialog1.Font.Name
            IsBold = FontDialog1.Font.Bold
            CheckBoxBold.Checked = IsBold
            UpDataPicture()
        End If
    End Sub

    Private Sub NumericFontSizePx_ValueChanged(sender As Object, e As EventArgs) Handles NumericFontSizePx.ValueChanged
        FontSizePx = NumericFontSizePx.Value
        BitmapWidth = FontSizePx
        BitmapHeight = FontSizePx
        NumericFontSizePt.Value = NumericFontSizePx.Value * 0.75
    End Sub
    Private Sub NumericFontSizePt_ValueChanged(sender As Object, e As EventArgs) Handles NumericFontSizePt.ValueChanged
        FontSizePt = NumericFontSizePt.Value
        UpDataPicture()
    End Sub
    Private Sub ButtonNewBitmapPath_Click(sender As Object, e As EventArgs) Handles ButtonNewBitmapPath.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            WriteINI("NewBitmap", "ImagePath", FolderBrowserDialog1.SelectedPath, Application.StartupPath + "\SangoTool.ini")
            TextBoxNewBitmapPath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub NewBitmap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FolderBrowserDialog1.SelectedPath = GetINI("NewBitmap", "ImagePath", "", Application.StartupPath + "\SangoTool.ini")
        TextBoxNewBitmapPath.Text = FolderBrowserDialog1.SelectedPath
    End Sub
    Private Sub UpDataPicture()
        Dim FontString As String()
        Select Case CodePage
            Case 936
                FontString = {"三", "国", "群", "英", "传", "Ⅷ"}
            Case 950
                FontString = {"三", "國", "群", "英", "傳", "Ⅷ"}
            Case Else
                FontString = {"S", "a", "n", "g", "o", "8"}
        End Select
        Dim FullFont = New Bitmap(BitmapWidth * FontString.Length + FontString.Length + 1, BitmapHeight + 2)
        For i = 0 To FontString.Length - 1
            Dim SingleString As String
            If CheckBoxConvert.Checked Then
                If ComboBoxConvert.Text = "Simplified Font" Then
                    SingleString = Strings.StrConv(FontString(i), VbStrConv.SimplifiedChinese)
                Else
                    SingleString = Strings.StrConv(FontString(i), VbStrConv.TraditionalChinese)
                End If
            Else
                SingleString = FontString(i)
            End If
            Dim SingleFont = CreateFontBitmap(SingleString, FontName, FontSizePt, BitmapWidth, BitmapHeight, OffsetX, OffsetY, IsBold, IsPixel, True)
            For x = 0 To BitmapWidth - 1
                For y = 0 To BitmapHeight - 1
                    FullFont.SetPixel(x + BitmapWidth * i + i + 1, y + 1, SingleFont.GetPixel(x, y))
                Next
            Next
        Next
        PictureBox1.Image = FullFont
    End Sub

    Private Sub NumericOffsetX_ValueChanged(sender As Object, e As EventArgs) Handles NumericOffsetX.ValueChanged
        OffsetX = NumericOffsetX.Value
        UpDataPicture()
    End Sub

    Private Sub NumericOffsetY_ValueChanged(sender As Object, e As EventArgs) Handles NumericOffsetY.ValueChanged
        OffsetY = NumericOffsetY.Value
        UpDataPicture()
    End Sub

    Private Sub CheckBoxNewBitmapBig5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxNewBitmapBig5.CheckedChanged
        If CheckBoxNewBitmapBig5.Checked Then
            CodePage = 950
        End If
        CheckBoxNewBitmapGBK.Checked = Not CheckBoxNewBitmapBig5.Checked
    End Sub

    Private Sub CheckBoxNewBitmapGBK_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxNewBitmapGBK.CheckedChanged
        If CheckBoxNewBitmapGBK.Checked Then
            CodePage = 936
        End If
        CheckBoxNewBitmapBig5.Checked = Not CheckBoxNewBitmapGBK.Checked
        UpDataPicture()
    End Sub

    Private Sub CheckBoxBold_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBold.CheckedChanged
        If IsBold = Not CheckBoxBold.Checked Then
            IsBold = CheckBoxBold.Checked
            UpDataPicture()
        End If
    End Sub

    Private Sub CheckBoxPixel_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPixel.CheckedChanged
        IsPixel = CheckBoxPixel.Checked
        UpDataPicture()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If PictureBox1.SizeMode = PictureBoxSizeMode.Zoom Then
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub CheckBoxConvert_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxConvert.CheckedChanged
        If ComboBoxConvert.Text = "" Then
            ComboBoxConvert.Text = "Simplified Font"
        End If
        ComboBoxConvert.Enabled = CheckBoxConvert.Checked
        UpDataPicture()
    End Sub

    Private Sub ComboBoxConvert_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxConvert.SelectedIndexChanged
        UpDataPicture()
    End Sub
End Class