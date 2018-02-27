Public Class SangoTool
    Dim ClassOK As Boolean = False
    Dim TempColor As Color() = {}
    Dim TempBitmap As Bitmap() = {}
    'Dim TempPoint As Object() = {}
    Dim PointList As Object() = {}
    Dim TempPath As Object() = {}
    Dim TempChannel As Object() = {}
    Dim ShadowPath As String = ""
    Dim SubPath As String() = {""}
    Dim FileList As String() = {""}
    Dim Bitmap As Bitmap = New Bitmap(1, 1)
    Dim Point As Int16() = {0, 0, 1, 1}
    Dim Play As Boolean = False
    Dim Flip As Boolean = False
    Dim Zoom As Boolean = False
    Dim Axes As Boolean = False
    Dim AntiAliasing As Boolean = False
    Dim ZoomRate As Double = 1
    Dim PlayBitmap As Bitmap() = {}
    Dim PlayFrame As Int16() = {0, 0}
    Dim PlayTempBitmap As Bitmap() = {}
    Dim PlayTempPoint As Object() = {}
    Dim PlayPoint As Object() = {}
    Dim PlayLoadFrame As Int16 = 0
    Dim PlayRendering As Boolean = False
    Dim OffsetList = {{0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0},
                      {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}}

    Private Sub Form_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If ClassOK Then
            'Refreshing(PictureBoxMian)
            If Timer1.Enabled = False Then
                'Dim SizeX As Int16 = SplitContainerPlay.Panel1.Width / 2 - Point(0)
                'Dim SizeY As Int16 = SplitContainerPlay.Panel1.Height - 64 - Point(1)
                ''PictureBoxPlay.Image = PlayBitmap(PlayFrame(0))
                'PictureBoxPlay.Image = Bitmap
                'PictureBoxPlay.Size = Bitmap.Size
                'PictureBoxPlay.Location = New Point(SizeX, SizeY)
                UpDataPicture(Point, PictureBoxPlay, Bitmap)
                'Axis()
            End If
        End If
    End Sub

    Private Sub Axis()
        Dim a As Point = New Point(SplitContainerPlay.Panel1.Width / 2, 0)
        Dim b As Point = New Point(SplitContainerPlay.Panel1.Width / 2, SplitContainerPlay.Panel1.Height)
        Dim c As Point = New Point(0, SplitContainerPlay.Panel1.Height - 64)
        Dim d As Point = New Point(SplitContainerPlay.Panel1.Width, SplitContainerPlay.Panel1.Height - 64)
        Dim PenColor As Color
        If Axes Then
            PenColor = Color.Red
        Else
            PenColor = Color.White
        End If
        SplitContainerPlay.Panel1.CreateGraphics.DrawLine(New Pen(PenColor), a, b)
        SplitContainerPlay.Panel1.CreateGraphics.DrawLine(New Pen(PenColor), c, d)
    End Sub

    Private Sub Refreshing(Optional BackgroundWorker As Boolean = True)
        Timer1.Enabled = False
        Point = {0, 0, 1, 1}
        'Dim TempPoint As Object()
        'ReDim TempPoint(PointList.Count - 1)
        'For i = 0 To TempPoint.Count - 1
        '    TempPoint(i) = PointList(i)
        'Next
        Dim TempPoint(PointList.Count - 1, 3) As Int16
        For i = 0 To PointList.Count - 1
            For o = 0 To 3
                TempPoint(i, o) = PointList(i)(o)
            Next
        Next
        For i = 0 To PointList.Count - 1 'TempPoint.Count - 1
            'Dim TempPoint As Int16() = {PointList(i)(0), PointList(i)(1), PointList(i)(2), PointList(i)(3)}
            If i <> PointList.Count - 1 Then
                TempPoint(i, 0) = TempPoint(i, 0) + OffsetList(20, 0) + OffsetList(i, 0)
                TempPoint(i, 1) = TempPoint(i, 1) + OffsetList(20, 1) + OffsetList(i, 1)
            End If
            If TempPoint(i, 2) = 1 And TempPoint(i, 3) = 1 And TempBitmap(i).GetPixel(0, 0).A = 0 Then
            Else
                If Point(2) = 1 And Point(3) = 1 And Bitmap.GetPixel(0, 0).A = 0 Then
                    Point = {TempPoint(i, 0), TempPoint(i, 1), 1, 1}
                End If
                If TempPoint(i, 2) - TempPoint(i, 0) > Point(2) - Point(0) Then
                    Dim increment As Int16 = (TempPoint(i, 2) - TempPoint(i, 0)) - (Point(2) - Point(0))
                    Point(2) = Point(2) + increment
                End If
                If TempPoint(i, 3) - TempPoint(i, 1) > Point(3) - Point(1) Then
                    Dim increment As Int16 = (TempPoint(i, 3) - TempPoint(i, 1)) - (Point(3) - Point(1))
                    Point(3) = Point(3) + increment
                End If
                If TempPoint(i, 0) > Point(0) Then
                    Point(2) = Point(2) + (TempPoint(i, 0) - Point(0))
                    Point(0) = Point(0) + (TempPoint(i, 0) - Point(0))
                End If
                If TempPoint(i, 1) > Point(1) Then
                    Point(3) = Point(3) + (TempPoint(i, 1) - Point(1))
                    Point(1) = Point(1) + (TempPoint(i, 1) - Point(1))
                End If
            End If
        Next
        Bitmap.Dispose()
        Bitmap = New Bitmap(Point(2), Point(3))

        For y = 0 To TempBitmap(TempBitmap.Count - 1).Height - 1
            For x = 0 To TempBitmap(TempBitmap.Count - 1).Width - 1
                Dim Color As Color = TempBitmap(TempBitmap.Count - 1).GetPixel(x, y)
                If Color.A > 0 Then
                    Bitmap.SetPixel(x - TempPoint(TempBitmap.Count - 1, 0) + Point(0), y - TempPoint(TempBitmap.Count - 1, 1) + Point(1), Color.Black)
                End If
            Next
        Next
        For i = 0 To TempBitmap.Count - 2
            For y = 0 To TempBitmap(i).Height - 1
                For x = 0 To TempBitmap(i).Width - 1
                    Dim Color As Color = TempBitmap(i).GetPixel(x, y)
                    If Color.A > 0 Then
                        If i Mod 2 = 1 Then
                            Dim c As Int16 = (i - 1) / 2
                            If TempColor(c).A > 0 Then
                                Dim R1 As Int16 = TempBitmap(i).GetPixel(x, y).R
                                Dim G1 As Int16 = TempBitmap(i).GetPixel(x, y).G
                                Dim B1 As Int16 = TempBitmap(i).GetPixel(x, y).B
                                Dim R2 As Int16 = TempColor(c).R
                                Dim G2 As Int16 = TempColor(c).G
                                Dim B2 As Int16 = TempColor(c).B
                                Dim R As Int32 = R2 / 255 * R1
                                Dim G As Int32 = G2 / 255 * G1
                                Dim B As Int32 = B2 / 255 * B1
                                Color = Color.FromArgb(R, G, B)
                                Bitmap.SetPixel(x - TempPoint(i, 0) + Point(0), y - TempPoint(i, 1) + Point(1), Color)
                            End If
                        Else
                            Bitmap.SetPixel(x - TempPoint(i, 0) + Point(0), y - TempPoint(i, 1) + Point(1), Color)
                        End If
                    End If
                Next
            Next
        Next
        If Flip Then
            If AntiAliasing Then
                Bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX)
            Else
                Dim FlipBitmap As Bitmap = New Bitmap(Bitmap.Width, Bitmap.Height)
                For y = 0 To FlipBitmap.Height - 1
                    For x = 0 To FlipBitmap.Width - 1
                        FlipBitmap.SetPixel(FlipBitmap.Width - 1 - x, y, Bitmap.GetPixel(x, y))
                    Next
                Next
                Bitmap = FlipBitmap
            End If
            Point(0) = Point(2) - Point(0)
        End If
        If Zoom Then
            Dim ZoomBitmapSize As New Size(Convert.ToInt16(Bitmap.Width * ZoomRate), Convert.ToInt16(Bitmap.Height * ZoomRate))
            If AntiAliasing = True Then
                Bitmap = New Bitmap(Bitmap, ZoomBitmapSize)
            Else
                Dim ZoomBitmap As Bitmap = New Bitmap(ZoomBitmapSize.Width, ZoomBitmapSize.Height)
                For y = 1 To ZoomBitmap.Height
                    For x = 1 To ZoomBitmap.Width
                        Dim x2 As Int16 = x / ZoomBitmap.Width * Bitmap.Width - 1
                        Dim y2 As Int16 = y / ZoomBitmap.Height * Bitmap.Height - 1
                        ZoomBitmap.SetPixel(x - 1, y - 1, Bitmap.GetPixel(x2, y2)）
                    Next
                Next
                Bitmap = ZoomBitmap
            End If
            'For i = 0 To 3
            '    Point(i) = Point(i) * ZoomRate
            'Next
            For i = 0 To 1
                Point(i) = Convert.ToInt16(（Point(i) + 1） * ZoomRate - 1)
                Point(i + 2) = Convert.ToInt16(Point(i + 2) * ZoomRate)
            Next
        End If
        If Axes Then
            For y = 0 To Bitmap.Height - 1
                If Point(0) < Bitmap.Width AndAlso Bitmap.GetPixel(Point(0), y).A = 0 Then
                    Bitmap.SetPixel(Point(0), y, Color.Red)
                End If
            Next
            For x = 0 To Bitmap.Width - 1
                If Point(1) < Bitmap.Height AndAlso Bitmap.GetPixel(x, Point(1)).A = 0 Then
                    Bitmap.SetPixel(x, Point(1), Color.Red)
                End If
            Next
        End If
        UpDataPicture(Point, PictureBoxPlay, Bitmap)
        If Not BackgroundWorkerPlay.IsBusy Then
            BackgroundWorkerPlay.RunWorkerAsync()
            Timer2.Enabled = True
        Else
            PlayRendering = True
        End If
    End Sub

    Private Sub SangoTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim max As Int16 = 10
        ReDim TempColor(max - 1)
        ReDim TempBitmap(max * 2)
        ReDim PointList(max * 2)
        ReDim TempPath(max - 1)
        ReDim TempChannel(max - 1)
        ReDim PlayTempBitmap(max * 2)
        ReDim PlayTempPoint(max * 2)
        For i = 0 To max * 2
            TempBitmap(i) = New Bitmap(1, 1)
            PointList(i) = {0, 0, 1, 1}
            PlayTempBitmap(i) = New Bitmap(1, 1)
            PlayTempPoint(i) = {0, 0, 1, 1}
        Next
        For i = 0 To max - 1
            TempPath(i) = ""
            TempColor(i) = Color.Transparent
            TempChannel(i) = {0, 1, 2}
        Next
        ClassOK = True
    End Sub

    Private Sub BackgroundWorkerPlay_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerPlay.DoWork
        'ReDim PlayPoint(PlayBitmap.Count - 1)
        PlayLoadFrame = 0
        For p = 0 To PlayBitmap.Count - 1
            If PlayRendering = True Then
                PlayLoadFrame = 0
                p = 0
                PlayRendering = False
            End If
            Dim PlayShadowPath = ShadowPath
            Dim shpfiles As String = PlayShadowPath + SubPath(p) + "\s" + FileList(p)
            Dim shpfiles2 As String = PlayShadowPath + "\shadow" + FileList(p)
            PlayTempBitmap(PlayTempBitmap.Count - 1).Dispose()
            PlayTempBitmap(PlayTempBitmap.Count - 1) = SHPToBitmap(shpfiles, shpfiles2)
            PlayTempPoint(PlayTempBitmap.Count - 1) = GetCenterPoint(shpfiles, shpfiles2)
            For i = 0 To 10 - 1
                Dim PlayTempPath = TempPath(i)
                Dim shpfile As String = PlayTempPath + SubPath(p) + FileList(p)
                Dim shpfile2 As String = PlayTempPath + FileList(p)
                Dim covfile As String = PlayTempPath + SubPath(p) + "\_cov" + FileList(p)
                Dim covfile2 As String = PlayTempPath + "\cover" + FileList(p)
                PlayTempBitmap(i * 2).Dispose()
                PlayTempBitmap(i * 2) = SHPToBitmap(shpfile, shpfile2, TempChannel(i)(0), TempChannel(i)(1), TempChannel(i)(2))
                PlayTempPoint(i * 2) = GetCenterPoint(shpfile, shpfile2)
                PlayTempBitmap(i * 2 + 1).Dispose()
                PlayTempBitmap(i * 2 + 1) = SHPToBitmap(covfile, covfile2)
                PlayTempPoint(i * 2 + 1) = GetCenterPoint(covfile, covfile2)

                PlayTempPoint(i * 2)(0) = PlayTempPoint(i * 2)(0) + OffsetList(20, 0) + OffsetList(i, 0)
                PlayTempPoint(i * 2 + 1)(0) = PlayTempPoint(i * 2 + 1)(0) + OffsetList(20, 0) + OffsetList(i, 0)
                PlayTempPoint(i * 2)(1) = PlayTempPoint(i * 2)(1) + OffsetList(20, 1) + OffsetList(i, 1)
                PlayTempPoint(i * 2 + 1)(1) = PlayTempPoint(i * 2 + 1)(1) + OffsetList(20, 1) + OffsetList(i, 1)
            Next
            PlayPoint(p) = {0, 0, 1, 1}
            For i = 0 To PlayTempPoint.Count - 1
                If PlayTempPoint(i)(2) = 1 And PlayTempPoint(i)(3) = 1 And PlayTempBitmap(i).GetPixel(0, 0).A = 0 Then
                Else
                    If PlayPoint(p)(2) = 1 And PlayPoint(p)(3) = 1 And PlayBitmap(p).GetPixel(0, 0).A = 0 Then
                        PlayPoint(p) = {PlayTempPoint(i)(0), PlayTempPoint(i)(1), 1, 1}
                    End If
                    If PlayTempPoint(i)(2) - PlayTempPoint(i)(0) > PlayPoint(p)(2) - PlayPoint(p)(0) Then
                        Dim increment As Int16 = (PlayTempPoint(i)(2) - PlayTempPoint(i)(0)) - (PlayPoint(p)(2) - PlayPoint(p)(0))
                        PlayPoint(p)(2) = PlayPoint(p)(2) + increment
                    End If
                    If PlayTempPoint(i)(3) - PlayTempPoint(i)(1) > PlayPoint(p)(3) - PlayPoint(p)(1) Then
                        Dim increment As Int16 = (PlayTempPoint(i)(3) - PlayTempPoint(i)(1)) - (PlayPoint(p)(3) - PlayPoint(p)(1))
                        PlayPoint(p)(3) = PlayPoint(p)(3) + increment
                    End If
                    If PlayTempPoint(i)(0) > PlayPoint(p)(0) Then
                        PlayPoint(p)(2) = PlayPoint(p)(2) + (PlayTempPoint(i)(0) - PlayPoint(p)(0))
                        PlayPoint(p)(0) = PlayPoint(p)(0) + (PlayTempPoint(i)(0) - PlayPoint(p)(0))
                    End If
                    If PlayTempPoint(i)(1) > PlayPoint(p)(1) Then
                        PlayPoint(p)(3) = PlayPoint(p)(3) + (PlayTempPoint(i)(1) - PlayPoint(p)(1))
                        PlayPoint(p)(1) = PlayPoint(p)(1) + (PlayTempPoint(i)(1) - PlayPoint(p)(1))
                    End If
                End If
            Next
            PlayBitmap(p).Dispose()
            PlayBitmap(p) = New Bitmap(Convert.ToInt32(PlayPoint(p)(2)), Convert.ToInt32(PlayPoint(p)(3)))

            'For y = 0 To PlayBitmap(p).Height - 1
            '    If PlayPoint(p)(0) < PlayBitmap(p).Width Then
            '        PlayBitmap(p).SetPixel(PlayPoint(p)(0), y, Color.Red)
            '    End If
            'Next
            'For x = 0 To PlayBitmap(p).Width - 1
            '    If PlayPoint(p)(1) < PlayBitmap(p).Height Then
            '        PlayBitmap(p).SetPixel(x, PlayPoint(p)(1), Color.Red)
            '    End If
            'Next

            For y = 0 To PlayTempBitmap(PlayTempBitmap.Count - 1).Height - 1
                For x = 0 To PlayTempBitmap(PlayTempBitmap.Count - 1).Width - 1
                    Dim Color As Color = PlayTempBitmap(PlayTempBitmap.Count - 1).GetPixel(x, y)
                    If Color.A > 0 Then
                        PlayBitmap(p).SetPixel(x - PlayTempPoint(PlayTempBitmap.Count - 1)(0) + PlayPoint(p)(0), y - PlayTempPoint(PlayTempBitmap.Count - 1)(1) + PlayPoint(p)(1), Color.Black)
                    End If
                Next
            Next
            For i = 0 To PlayTempBitmap.Count - 2
                For y = 0 To PlayTempBitmap(i).Height - 1
                    For x = 0 To PlayTempBitmap(i).Width - 1
                        Dim Color As Color = PlayTempBitmap(i).GetPixel(x, y)
                        If Color.A > 0 Then
                            If i Mod 2 = 1 Then
                                Dim c As Int16 = (i - 1) / 2
                                If TempColor(c).A > 0 Then
                                    Dim R1 As Int16 = PlayTempBitmap(i).GetPixel(x, y).R
                                    Dim G1 As Int16 = PlayTempBitmap(i).GetPixel(x, y).G
                                    Dim B1 As Int16 = PlayTempBitmap(i).GetPixel(x, y).B
                                    Dim R2 As Int16 = TempColor(c).R
                                    Dim G2 As Int16 = TempColor(c).G
                                    Dim B2 As Int16 = TempColor(c).B
                                    Dim R As Int32 = R2 / 255 * R1
                                    Dim G As Int32 = G2 / 255 * G1
                                    Dim B As Int32 = B2 / 255 * B1
                                    Color = Color.FromArgb(R, G, B)
                                    PlayBitmap(p).SetPixel(x - PlayTempPoint(i)(0) + PlayPoint(p)(0), y - PlayTempPoint(i)(1) + PlayPoint(p)(1), Color)
                                End If
                            Else
                                PlayBitmap(p).SetPixel(x - PlayTempPoint(i)(0) + PlayPoint(p)(0), y - PlayTempPoint(i)(1) + PlayPoint(p)(1), Color)
                            End If
                        End If
                    Next
                Next
            Next
            If Flip Then
                If AntiAliasing = True Then
                    PlayBitmap(p).RotateFlip(RotateFlipType.RotateNoneFlipX)
                Else
                    Dim FlipBitmap As Bitmap = New Bitmap(PlayBitmap(p).Width, PlayBitmap(p).Height)
                    For y = 0 To FlipBitmap.Height - 1
                        For x = 0 To FlipBitmap.Width - 1
                            FlipBitmap.SetPixel(FlipBitmap.Width - 1 - x, y, PlayBitmap(p).GetPixel(x, y))
                        Next
                    Next
                    PlayBitmap(p) = FlipBitmap
                End If
                PlayPoint(p)(0) = PlayPoint(p)(2) - PlayPoint(p)(0)
            End If
            If Zoom Then
                Dim ZoomBitmapSize As New Size(Convert.ToInt16(PlayBitmap(p).Width * ZoomRate), Convert.ToInt16(PlayBitmap(p).Height * ZoomRate))
                If AntiAliasing = True Then
                    PlayBitmap(p) = New Bitmap(PlayBitmap(p), ZoomBitmapSize)
                Else
                    Dim ZoomBitmap As Bitmap = New Bitmap(ZoomBitmapSize.Width, ZoomBitmapSize.Height)
                    For y = 1 To ZoomBitmap.Height
                        For x = 1 To ZoomBitmap.Width
                            Dim x2 As Int16 = x / ZoomBitmap.Width * PlayBitmap(p).Width - 1
                            Dim y2 As Int16 = y / ZoomBitmap.Height * PlayBitmap(p).Height - 1
                            ZoomBitmap.SetPixel(x - 1, y - 1, PlayBitmap(p).GetPixel(x2, y2)）
                        Next
                    Next
                    PlayBitmap(p) = ZoomBitmap
                    'ZoomBitmap.Dispose()
                End If
                For i = 0 To 1
                    PlayPoint(p)(i) = Convert.ToInt16(（PlayPoint(p)(i) + 1） * ZoomRate - 1)
                    PlayPoint(p)(i + 2) = Convert.ToInt16(PlayPoint(p)(i + 2) * ZoomRate)
                Next
            End If
            If Axes Then
                For y = 0 To PlayBitmap(p).Height - 1
                    If PlayPoint(p)(0) < PlayBitmap(p).Width AndAlso PlayBitmap(p).GetPixel(PlayPoint(p)(0), y).A = 0 Then
                        PlayBitmap(p).SetPixel(PlayPoint(p)(0), y, Color.Red)
                    End If
                Next
                For x = 0 To PlayBitmap(p).Width - 1
                    If PlayPoint(p)(1) < PlayBitmap(p).Height AndAlso PlayBitmap(p).GetPixel(x, PlayPoint(p)(1)).A = 0 Then
                        PlayBitmap(p).SetPixel(x, PlayPoint(p)(1), Color.Red)
                    End If
                Next
            End If

            PlayLoadFrame = p
            'If PlayRendering = True Then
            '    PlayLoadFrame = 0
            '    p = 0
            '    PlayRendering = False
            'End If
        Next
    End Sub

    Private Sub BackgroundWorkerOut_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerOut.DoWork
        MsgBox(FileList(0))
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If BackgroundWorkerPlay.IsBusy Then
            ProgressBar1.Value = PlayLoadFrame
        Else
            ProgressBar1.Value = ProgressBar1.Maximum
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If SplitContainerPlay.Visible = False Then
        '    SplitContainerPlay.Visible = True
        'End If
        If PlayFrame(1) = 0 Then Exit Sub
        If PlayFrame(0) > PlayFrame(1) Then
            PlayFrame(0) = 0
        End If
        If PlayFrame(0) > PlayLoadFrame Then
            PlayFrame(0) = 0 'PlayLoadFrame
        End If
        'If BackgroundWorkerPlay.IsBusy Then
        '    ProgressBar1.Value = PlayLoadFrame
        'ElseIf ProgressBar1.Value <> ProgressBar1.Maximum Then
        '    ProgressBar1.Value = ProgressBar1.Maximum
        'End If
        Label1.Text = PlayFrame(0).ToString + "/" + PlayFrame(1).ToString
        If PlayLoadFrame = 0 Then
            PictureBoxPlay.Image = CreateImage("Loading", 64, 64, "#ffffff")
        Else
            'Dim x As Int16 = SplitContainerPlay.Panel1.Width / 2 - PlayPoint(PlayFrame(0))(0)
            'Dim y As Int16 = SplitContainerPlay.Panel1.Height - 64 - PlayPoint(PlayFrame(0))(1)
            'PictureBoxPlay.Image = PlayBitmap(PlayFrame(0))
            'PictureBoxPlay.Size = PlayBitmap(PlayFrame(0)).Size
            'If PictureBoxPlay.BorderStyle = BorderStyle.None Then
            '    PictureBoxPlay.Location = New Point(x, y)
            'Else
            '    PictureBoxPlay.Location = New Point(x - 1, y - 1)
            'End If
            UpDataPicture({PlayPoint(PlayFrame(0))(0), PlayPoint(PlayFrame(0))(1)}, PictureBoxPlay, PlayBitmap(PlayFrame(0)))
            'Axis()
            PlayFrame(0) = PlayFrame(0) + 1
        End If
    End Sub

    Private Sub UpDataPicture(Point As Int16(), PictureBox As PictureBox, PictureBitmap As Bitmap)
        Dim x As Int16 = SplitContainerPlay.Panel1.Width / 2 - Point(0)
        Dim y As Int16 = SplitContainerPlay.Panel1.Height - 64 - Point(1)
        PictureBox.Image = PictureBitmap
        PictureBox.Size = PictureBitmap.Size
        If PictureBox.BorderStyle = BorderStyle.None Then
            PictureBox.Location = New Point(x, y)
        Else
            PictureBox.Location = New Point(x - 1, y - 1)
        End If
        Axis()
    End Sub

    Private Sub SetObjectBitmap(SelectBodyIndex As Int16)
        FolderBrowserDialog1.SelectedPath = TempPath(SelectBodyIndex)
        SelectObject.ShowDialog()
        TempPath(SelectBodyIndex) = FolderBrowserDialog1.SelectedPath
        Dim shpfile As String = TempPath(SelectBodyIndex) + SubPath(0) + FileList(0)
        Dim shpfile2 As String = TempPath(SelectBodyIndex) + FileList(0)
        Dim covfile As String = TempPath(SelectBodyIndex) + SubPath(0) + "\_cov" + FileList(0)
        Dim covfile2 As String = TempPath(SelectBodyIndex) + "\cover" + FileList(0)
        TempBitmap(SelectBodyIndex * 2).Dispose()
        TempBitmap(SelectBodyIndex * 2) = SHPToBitmap(shpfile, shpfile2, TempChannel(SelectBodyIndex)(0), TempChannel(SelectBodyIndex)(1), TempChannel(SelectBodyIndex)(2))
        PointList(SelectBodyIndex * 2) = GetCenterPoint(shpfile, shpfile2)
        TempBitmap(SelectBodyIndex * 2 + 1).Dispose()
        TempBitmap(SelectBodyIndex * 2 + 1) = SHPToBitmap(covfile, covfile2)
        PointList(SelectBodyIndex * 2 + 1) = GetCenterPoint(covfile, covfile2)
    End Sub

    Private Sub PictureBox0_Click(sender As Object, e As EventArgs) Handles PictureBox0.Click
        Dim SelectBodyIndex As Int16 = 0
        SetObjectBitmap(SelectBodyIndex)
        PictureBox0.Image = TempBitmap(SelectBodyIndex * 2)
        If TempPath(SelectBodyIndex) = "" Then
            PictureBox0.Image = CreateImage("Empty", 80, 40, "#ffffff")
        End If
        Refreshing()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim SelectBodyIndex As Int16 = 1
        SetObjectBitmap(SelectBodyIndex)
        PictureBox1.Image = TempBitmap(SelectBodyIndex * 2)
        If TempPath(SelectBodyIndex) = "" Then
            PictureBox1.Image = CreateImage("Empty", 80, 40, "#ffffff")
        End If
        Refreshing()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim SelectBodyIndex As Int16 = 2
        SetObjectBitmap(SelectBodyIndex)
        PictureBox2.Image = TempBitmap(SelectBodyIndex * 2)
        If TempPath(SelectBodyIndex) = "" Then
            PictureBox2.Image = CreateImage("Empty", 80, 40, "#ffffff")
        End If
        Refreshing()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim SelectBodyIndex As Int16 = 3
        SetObjectBitmap(SelectBodyIndex)
        PictureBox3.Image = TempBitmap(SelectBodyIndex * 2)
        If TempPath(SelectBodyIndex) = "" Then
            PictureBox3.Image = CreateImage("Empty", 80, 40, "#ffffff")
        End If
        Refreshing()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim SelectBodyIndex As Int16 = 4
        SetObjectBitmap(SelectBodyIndex)
        PictureBox4.Image = TempBitmap(SelectBodyIndex * 2)
        If TempPath(SelectBodyIndex) = "" Then
            PictureBox4.Image = CreateImage("Empty", 80, 40, "#ffffff")
        End If
        Refreshing()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim SelectBodyIndex As Int16 = 5
        SetObjectBitmap(SelectBodyIndex)
        PictureBox5.Image = TempBitmap(SelectBodyIndex * 2)
        If TempPath(SelectBodyIndex) = "" Then
            PictureBox5.Image = CreateImage("Empty", 80, 40, "#ffffff")
        End If
        Refreshing()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim SelectBodyIndex As Int16 = 6
        SetObjectBitmap(SelectBodyIndex)
        PictureBox6.Image = TempBitmap(SelectBodyIndex * 2)
        If TempPath(SelectBodyIndex) = "" Then
            PictureBox6.Image = CreateImage("Empty", 80, 40, "#ffffff")
        End If
        Refreshing()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim SelectBodyIndex As Int16 = 7
        SetObjectBitmap(SelectBodyIndex)
        PictureBox7.Image = TempBitmap(SelectBodyIndex * 2)
        If TempPath(SelectBodyIndex) = "" Then
            PictureBox7.Image = CreateImage("Empty", 80, 40, "#ffffff")
        End If
        Refreshing()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim SelectBodyIndex As Int16 = 8
        SetObjectBitmap(SelectBodyIndex)
        PictureBox8.Image = TempBitmap(SelectBodyIndex * 2)
        If TempPath(SelectBodyIndex) = "" Then
            PictureBox8.Image = CreateImage("Empty", 80, 40, "#ffffff")
        End If
        Refreshing()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim SelectBodyIndex As Int16 = 9
        SetObjectBitmap(SelectBodyIndex)
        PictureBox9.Image = TempBitmap(SelectBodyIndex * 2)
        If TempPath(SelectBodyIndex) = "" Then
            PictureBox9.Image = CreateImage("Empty", 80, 40, "#ffffff")
        End If
        Refreshing()
    End Sub

    Private Sub SetObjectColor(SelectBodyIndex As Int16)
        'ColorDialog1.ShowDialog()
        'TempColor(SelectBodyIndex) = ColorDialog1.Color
        'ObjectColor.PictureBox1.BackColor = TempColor(SelectBodyIndex)

        Dim R As Int32 = TempChannel(SelectBodyIndex)(0)
        Dim G As Int32 = TempChannel(SelectBodyIndex)(1)
        Dim B As Int32 = TempChannel(SelectBodyIndex)(2)

        Select Case TempChannel(SelectBodyIndex)(0)
            Case 0
                ObjectColor.RedFromRed.Checked = True
            Case 1
                ObjectColor.RedFromGreen.Checked = True
            Case 2
                ObjectColor.RedFromBlue.Checked = True
            Case Else
                ObjectColor.RedFromRed.Checked = True
        End Select
        Select Case TempChannel(SelectBodyIndex)(1)
            Case 0
                ObjectColor.GreenFromRed.Checked = True
            Case 1
                ObjectColor.GreenFromGreen.Checked = True
            Case 2
                ObjectColor.GreenFromBlue.Checked = True
            Case Else
                ObjectColor.GreenFromGreen.Checked = True
        End Select
        Select Case TempChannel(SelectBodyIndex)(2)
            Case 0
                ObjectColor.BlueFromRed.Checked = True
            Case 1
                ObjectColor.BlueFromGreen.Checked = True
            Case 2
                ObjectColor.BlueFromBlue.Checked = True
            Case Else
                ObjectColor.BlueFromBlue.Checked = True
        End Select

        ObjectColor.NumericUpDownR.Value = TempColor(SelectBodyIndex).R
        ObjectColor.NumericUpDownG.Value = TempColor(SelectBodyIndex).G
        ObjectColor.NumericUpDownB.Value = TempColor(SelectBodyIndex).B
        If TempColor(SelectBodyIndex).A = 0 Then
            ObjectColor.TransparentON.Checked = True
        Else
            ObjectColor.TransparentOFF.Checked = True
        End If
        ObjectColor.ShowDialog()
        If ObjectColor.TransparentON.Checked = True Then
            TempColor(SelectBodyIndex) = Color.Transparent
        Else
            TempColor(SelectBodyIndex) = ObjectColor.PictureBox1.BackColor
        End If

        If ObjectColor.RedFromRed.Checked Then R = 0
        If ObjectColor.RedFromGreen.Checked Then R = 1
        If ObjectColor.RedFromBlue.Checked Then R = 2
        If ObjectColor.GreenFromRed.Checked Then G = 0
        If ObjectColor.GreenFromGreen.Checked Then G = 1
        If ObjectColor.GreenFromBlue.Checked Then G = 2
        If ObjectColor.BlueFromRed.Checked Then B = 0
        If ObjectColor.BlueFromGreen.Checked Then B = 1
        If ObjectColor.BlueFromBlue.Checked Then B = 2

        TempChannel(SelectBodyIndex) = {R, G, B}

        Dim shpfile As String = TempPath(SelectBodyIndex) + SubPath(0) + FileList(0)
        Dim shpfile2 As String = TempPath(SelectBodyIndex) + FileList(0)
        TempBitmap(SelectBodyIndex * 2).Dispose()
        TempBitmap(SelectBodyIndex * 2) = SHPToBitmap(shpfile, shpfile2, TempChannel(SelectBodyIndex)(0), TempChannel(SelectBodyIndex)(1), TempChannel(SelectBodyIndex)(2))
        '
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        Dim SelectBodyIndex As Int16 = 0
        SetObjectColor(SelectBodyIndex)
        Button0.BackColor = TempColor(SelectBodyIndex)
        If TempPath(SelectBodyIndex) <> "" Then PictureBox0.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SelectBodyIndex As Int16 = 1
        SetObjectColor(SelectBodyIndex)
        Button1.BackColor = TempColor(SelectBodyIndex)
        If TempPath(SelectBodyIndex) <> "" Then PictureBox1.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SelectBodyIndex As Int16 = 2
        SetObjectColor(SelectBodyIndex)
        Button2.BackColor = TempColor(SelectBodyIndex)
        If TempPath(SelectBodyIndex) <> "" Then PictureBox2.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SelectBodyIndex As Int16 = 3
        SetObjectColor(SelectBodyIndex)
        Button3.BackColor = TempColor(SelectBodyIndex)
        If TempPath(SelectBodyIndex) <> "" Then PictureBox3.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim SelectBodyIndex As Int16 = 4
        SetObjectColor(SelectBodyIndex)
        Button4.BackColor = TempColor(SelectBodyIndex)
        If TempPath(SelectBodyIndex) <> "" Then PictureBox4.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim SelectBodyIndex As Int16 = 5
        SetObjectColor(SelectBodyIndex)
        Button5.BackColor = TempColor(SelectBodyIndex)
        If TempPath(SelectBodyIndex) <> "" Then PictureBox5.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim SelectBodyIndex As Int16 = 6
        SetObjectColor(SelectBodyIndex)
        Button6.BackColor = TempColor(SelectBodyIndex)
        If TempPath(SelectBodyIndex) <> "" Then PictureBox6.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim SelectBodyIndex As Int16 = 7
        SetObjectColor(SelectBodyIndex)
        Button7.BackColor = TempColor(SelectBodyIndex)
        If TempPath(SelectBodyIndex) <> "" Then PictureBox7.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim SelectBodyIndex As Int16 = 8
        SetObjectColor(SelectBodyIndex)
        Button8.BackColor = TempColor(SelectBodyIndex)
        If TempPath(SelectBodyIndex) <> "" Then PictureBox8.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim SelectBodyIndex As Int16 = 9
        SetObjectColor(SelectBodyIndex)
        Button9.BackColor = TempColor(SelectBodyIndex)
        If TempPath(SelectBodyIndex) <> "" Then PictureBox9.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing()
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        FolderBrowserDialog1.SelectedPath = "H:\三国群英传ol_全集\GenNude\F"
        FileList = GetFileList(FolderBrowserDialog1.SelectedPath)
        SubPath = GetSubPath(FolderBrowserDialog1.SelectedPath)

        ReDim PlayBitmap(FileList.Count - 1)
        ReDim PlayPoint(FileList.Count - 1)
        For i = 0 To PlayBitmap.Count - 1
            PlayBitmap(i) = New Bitmap(1, 1)
        Next
        For i = 0 To PlayPoint.Count - 1
            PlayPoint(i) = {0, 0, 1, 1}
        Next
        PlayFrame(1) = PlayBitmap.Count - 1
        ProgressBar1.Maximum = PlayBitmap.Count - 1
        TableLayoutPanelMian.Visible = True

        PictureBox0.Image = CreateImage("Empty", 80, 40, "#ffffff")
        PictureBox1.Image = CreateImage("Empty", 80, 40, "#ffffff")
        PictureBox2.Image = CreateImage("Empty", 80, 40, "#ffffff")
        PictureBox3.Image = CreateImage("Empty", 80, 40, "#ffffff")
        PictureBox4.Image = CreateImage("Empty", 80, 40, "#ffffff")
        PictureBox5.Image = CreateImage("Empty", 80, 40, "#ffffff")
        PictureBox6.Image = CreateImage("Empty", 80, 40, "#ffffff")
        PictureBox7.Image = CreateImage("Empty", 80, 40, "#ffffff")
        PictureBox8.Image = CreateImage("Empty", 80, 40, "#ffffff")
        PictureBox9.Image = CreateImage("Empty", 80, 40, "#ffffff")
    End Sub

    Private Sub ButtonNRead_Click(sender As Object, e As EventArgs) Handles ButtonNRead.Click
        OpenFileDialog1.ShowDialog()
        For i = 0 To TempColor.Count - 1
            Dim argb As Int32 = Val(GetINI("Color", "Color" + i.ToString, "16777215", OpenFileDialog1.FileName))
            TempColor(i) = Color.FromArgb(argb)
        Next
        Button0.BackColor = TempColor(0)
        Button1.BackColor = TempColor(1)
        Button2.BackColor = TempColor(2)
        Button3.BackColor = TempColor(3)
        Button4.BackColor = TempColor(4)
        Button5.BackColor = TempColor(5)
        Button6.BackColor = TempColor(6)
        Button7.BackColor = TempColor(7)
        Button8.BackColor = TempColor(8)
        Button9.BackColor = TempColor(9)
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        SaveFileDialog1.ShowDialog()
        WriteINI("Transform", "FLIP", Flip, SaveFileDialog1.FileName)
        WriteINI("Transform", "ZOOM", Zoom, SaveFileDialog1.FileName)
        WriteINI("Transform", "ZoomRate", ZoomRate, SaveFileDialog1.FileName)
        WriteINI("Transform", "AntiAliasing", AntiAliasing, SaveFileDialog1.FileName)
        For i = 0 To TempColor.Count - 1
            WriteINI("Color", "Color" + i.ToString, TempColor(i).ToArgb, SaveFileDialog1.FileName)
        Next
    End Sub

    Private Sub ButtonPlay_Click(sender As Object, e As EventArgs) Handles ButtonPlay.Click
        Timer1.Enabled = Not Timer1.Enabled
    End Sub

    Private Sub ButtonBorder_Click(sender As Object, e As EventArgs) Handles ButtonBorder.Click
        If PictureBoxPlay.BorderStyle = BorderStyle.None Then
            PictureBoxPlay.BorderStyle = BorderStyle.FixedSingle
        Else
            PictureBoxPlay.BorderStyle = BorderStyle.None
        End If
        If Timer1.Enabled = False Then
            UpDataPicture(Point, PictureBoxPlay, Bitmap)
        End If
    End Sub

    Private Sub ButtonAxis_Click(sender As Object, e As EventArgs) Handles ButtonAxis.Click
        Axes = Not Axes
        Refreshing()
    End Sub

    Private Sub ButtonLast_Click(sender As Object, e As EventArgs) Handles ButtonLast.Click
        Timer1.Enabled = False
        PlayFrame(0) = PlayFrame(0) - 1
        If PlayFrame(0) < 0 Then
            PlayFrame(0) = 0
            Exit Sub
        End If
        If PlayFrame(0) > PlayLoadFrame Then
            PlayFrame(0) = PlayLoadFrame
            Exit Sub
        End If
        'If PlayFrame(1) = 0 Then Exit Sub
        Label1.Text = PlayFrame(0).ToString + "/" + PlayFrame(1).ToString
        If PlayLoadFrame = 0 Then
            PictureBoxPlay.Image = CreateImage("Loading", 64, 64, "#ffffff")
        Else
            'Dim x As Int16 = SplitContainerPlay.Panel1.Width / 2 - PlayPoint(PlayFrame(0))(0)
            'Dim y As Int16 = SplitContainerPlay.Panel1.Height - 64 - PlayPoint(PlayFrame(0))(1)
            'PictureBoxPlay.Image = PlayBitmap(PlayFrame(0))
            'PictureBoxPlay.Size = PlayBitmap(PlayFrame(0)).Size
            'PictureBoxPlay.Location = New Point(x, y)
            UpDataPicture({PlayPoint(PlayFrame(0))(0), PlayPoint(PlayFrame(0))(1)}, PictureBoxPlay, PlayBitmap(PlayFrame(0)))
        End If
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        Timer1.Enabled = False
        'If PlayFrame(1) = 0 Then Exit Sub
        PlayFrame(0) = PlayFrame(0) + 1
        If PlayFrame(0) > PlayFrame(1) Then
            PlayFrame(0) = PlayFrame(1)
        End If
        If PlayFrame(0) > PlayLoadFrame Then
            PlayFrame(0) = PlayLoadFrame
        End If
        Label1.Text = PlayFrame(0).ToString + "/" + PlayFrame(1).ToString
        If PlayLoadFrame = 0 Then
            PictureBoxPlay.Image = CreateImage("Loading", 64, 64, "#ffffff")
        Else
            'Dim x As Int16 = SplitContainerPlay.Panel1.Width / 2 - PlayPoint(PlayFrame(0))(0)
            'Dim y As Int16 = SplitContainerPlay.Panel1.Height - 64 - PlayPoint(PlayFrame(0))(1)
            'PictureBoxPlay.Image = PlayBitmap(PlayFrame(0))
            'PictureBoxPlay.Size = PlayBitmap(PlayFrame(0)).Size
            'PictureBoxPlay.Location = New Point(x, y)
            UpDataPicture({PlayPoint(PlayFrame(0))(0), PlayPoint(PlayFrame(0))(1)}, PictureBoxPlay, PlayBitmap(PlayFrame(0)))
        End If
    End Sub

    Private Sub ButtonOutput_Click(sender As Object, e As EventArgs) Handles ButtonOutput.Click
        OutObject.ShowDialog()
    End Sub

    Private Sub ButtonTransform_Click(sender As Object, e As EventArgs) Handles ButtonTransform.Click
        Transform.ShowDialog()
        Flip = Transform.FlipTrue.Checked
        Zoom = Transform.ZoomTrue.Checked
        AntiAliasing = Transform.AntiAliasingTrue.Checked
        ZoomRate = Transform.NumericUpDownZoom.Value / 100
        Refreshing()
    End Sub

    Private Sub ButtonShadow_Click(sender As Object, e As EventArgs) Handles ButtonShadow.Click
        FolderBrowserDialog1.SelectedPath = GetINI("SelectShadow", "ShadowPath", "", Application.StartupPath + "\SangoTool.ini")
        FolderBrowserDialog1.ShowDialog()
        ShadowPath = FolderBrowserDialog1.SelectedPath
        WriteINI("SelectShadow", "ShadowPath", ShadowPath, Application.StartupPath + "\SangoTool.ini")
        Dim shpfile As String = ShadowPath + SubPath(0) + "\s" + FileList(0)
        Dim shpfile2 As String = ShadowPath + "\shadow" + FileList(0)
        TempBitmap(TempBitmap.Count - 1).Dispose()
        TempBitmap(TempBitmap.Count - 1) = SHPToBitmap(shpfile, shpfile2)
        PointList(PointList.Count - 1) = GetCenterPoint(shpfile, shpfile2)
        'PointList(20) = GetCenterPoint(shpfile, shpfile2)
        Refreshing()
    End Sub

    'Private Sub ToolStripMenuItem0_Click(sender As Object, e As EventArgs)
    '    TempColor(0) = Color.Transparent
    '    Button0.BackColor = TempColor(0)
    '    Refreshing()
    'End Sub
    'Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
    '    TempColor(1) = Color.Transparent
    '    Button1.BackColor = TempColor(1)
    '    Refreshing()
    'End Sub
    'Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
    '    TempColor(2) = Color.Transparent
    '    Button2.BackColor = TempColor(2)
    '    Refreshing()
    'End Sub
    'Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
    '    TempColor(3) = Color.Transparent
    '    Button3.BackColor = TempColor(3)
    '    Refreshing()
    'End Sub
    'Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)
    '    TempColor(4) = Color.Transparent
    '    Button4.BackColor = TempColor(4)
    '    Refreshing()
    'End Sub
    'Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs)
    '    TempColor(5) = Color.Transparent
    '    Button5.BackColor = TempColor(5)
    '    Refreshing()
    'End Sub
    'Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs)
    '    TempColor(6) = Color.Transparent
    '    Button6.BackColor = TempColor(6)
    '    Refreshing()
    'End Sub
    'Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs)
    '    TempColor(7) = Color.Transparent
    '    Button7.BackColor = TempColor(7)
    '    Refreshing()
    'End Sub
    'Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs)
    '    TempColor(8) = Color.Transparent
    '    Button8.BackColor = TempColor(8)
    '    Refreshing()
    'End Sub
    'Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs)
    '    TempColor(9) = Color.Transparent
    '    Button9.BackColor = TempColor(9)
    '    Refreshing()
    'End Sub

    Private Sub ButtonOffset_Click(sender As Object, e As EventArgs) Handles ButtonOffset.Click
        Offset.NumericUpDownDeathX.Value = OffsetList(21, 0)
        Offset.NumericUpDownDeathY.Value = OffsetList(21, 1)
        Offset.NumericUpDownXALL.Value = OffsetList(20, 0)
        Offset.NumericUpDownYALL.Value = OffsetList(20, 1)
        Offset.NumericUpDownX0.Value = OffsetList(0, 0)
        Offset.NumericUpDownY0.Value = OffsetList(0, 1)
        Offset.NumericUpDownX1.Value = OffsetList(2, 0)
        Offset.NumericUpDownY1.Value = OffsetList(2, 1)
        Offset.NumericUpDownX2.Value = OffsetList(4, 0)
        Offset.NumericUpDownY2.Value = OffsetList(4, 1)
        Offset.NumericUpDownX3.Value = OffsetList(6, 0)
        Offset.NumericUpDownY3.Value = OffsetList(6, 1)
        Offset.NumericUpDownX4.Value = OffsetList(8, 0)
        Offset.NumericUpDownY4.Value = OffsetList(8, 1)
        Offset.NumericUpDownX5.Value = OffsetList(10, 0)
        Offset.NumericUpDownY5.Value = OffsetList(10, 1)
        Offset.NumericUpDownX6.Value = OffsetList(12, 0)
        Offset.NumericUpDownY6.Value = OffsetList(12, 1)
        Offset.NumericUpDownX7.Value = OffsetList(14, 0)
        Offset.NumericUpDownY7.Value = OffsetList(14, 1)
        Offset.NumericUpDownX8.Value = OffsetList(16, 0)
        Offset.NumericUpDownY8.Value = OffsetList(16, 1)
        Offset.NumericUpDownX9.Value = OffsetList(18, 0)
        Offset.NumericUpDownY9.Value = OffsetList(18, 1)
        Offset.ShowDialog()
        OffsetList(21, 0) = Offset.NumericUpDownDeathX.Value
        OffsetList(21, 1) = Offset.NumericUpDownDeathY.Value
        OffsetList(20, 0) = Offset.NumericUpDownXALL.Value
        OffsetList(20, 1) = Offset.NumericUpDownYALL.Value
        For i = 0 To 1
            OffsetList(0 + i, 0) = Offset.NumericUpDownX0.Value
            OffsetList(0 + i, 1) = Offset.NumericUpDownY0.Value
            OffsetList(2 + i, 0) = Offset.NumericUpDownX1.Value
            OffsetList(2 + i, 1) = Offset.NumericUpDownY1.Value
            OffsetList(4 + i, 0) = Offset.NumericUpDownX2.Value
            OffsetList(4 + i, 1) = Offset.NumericUpDownY2.Value
            OffsetList(6 + i, 0) = Offset.NumericUpDownX3.Value
            OffsetList(6 + i, 1) = Offset.NumericUpDownY3.Value
            OffsetList(8 + i, 0) = Offset.NumericUpDownX4.Value
            OffsetList(8 + i, 1) = Offset.NumericUpDownY4.Value
            OffsetList(10 + i, 0) = Offset.NumericUpDownX5.Value
            OffsetList(10 + i, 1) = Offset.NumericUpDownY5.Value
            OffsetList(12 + i, 0) = Offset.NumericUpDownX6.Value
            OffsetList(12 + i, 1) = Offset.NumericUpDownY6.Value
            OffsetList(14 + i, 0) = Offset.NumericUpDownX7.Value
            OffsetList(14 + i, 1) = Offset.NumericUpDownY7.Value
            OffsetList(16 + i, 0) = Offset.NumericUpDownX8.Value
            OffsetList(16 + i, 1) = Offset.NumericUpDownY8.Value
            OffsetList(18 + i, 0) = Offset.NumericUpDownX9.Value
            OffsetList(18 + i, 1) = Offset.NumericUpDownY9.Value
        Next
        'MsgBox(OffsetList(0, 0))
        'MsgBox(Offset.NumericUpDownX0.Value)
        'Refreshing()
    End Sub
End Class
