Public Class SangoTool
    Dim ClassOK As Boolean = False
    Dim TempColor As Color() = {}
    Dim TempBitmap As Bitmap() = {}
    Dim PointList As Object() = {}
    Dim TempPath As String() = {}
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
    Dim OutTempBitmap As Bitmap() = {}
    Dim OutTempPoint As Object() = {}
    Dim OutPoint As Object() = {}
    Dim OutBitmap As Bitmap() = {}
    Dim OutProgress As Int32 = 0
    Dim OutputPath As String = ""
    Dim PlayBitmap As Bitmap() = {}
    Dim PlayFrame As Int16() = {0, 0}
    Dim PlayTempBitmap As Bitmap() = {}
    Dim PlayTempPoint As Object() = {}
    Dim PlayPoint As Object() = {}
    Dim PlayLoadFrame As Int16 = 0
    Dim PlayRendering As Boolean = False
    Dim MergeShadows As Boolean = False
    Dim MergeCover As Boolean = False
    Dim OffsetList = {{0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0},
                      {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}}
    Private Declare Auto Function PlaySound Lib "winmm.dll" (ByVal lpszSoundName As String, ByVal hModule As Integer, ByVal dwFlags As Integer) As Integer
    Const SND_FILENAME As Integer = &H20000
    Const SND_ALIAS As Integer = &H10000
    Const SND_SYNC As Integer = &H0

    Private Sub SangoTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim max As Int16 = 10
        ReDim TempColor(max - 1)
        ReDim TempBitmap(max * 2)
        ReDim PointList(max * 2)
        ReDim TempPath(max - 1)
        ReDim TempChannel(max - 1)
        ReDim PlayTempBitmap(max * 2)
        ReDim PlayTempPoint(max * 2)
        ReDim OutTempBitmap(max * 2)
        ReDim OutTempPoint(max * 2)
        For i = 0 To max * 2
            TempBitmap(i) = New Bitmap(1, 1)
            PointList(i) = {0, 0, 1, 1}
            PlayTempBitmap(i) = New Bitmap(1, 1)
            PlayTempPoint(i) = {0, 0, 1, 1}
            OutTempBitmap(i) = New Bitmap(1, 1)
            OutTempPoint(i) = {0, 0, 1, 1}
        Next
        For i = 0 To max - 1
            TempPath(i) = ""
            TempColor(i) = Color.Transparent
            TempChannel(i) = {0, 1, 2}
        Next
        ClassOK = True
    End Sub

    Private Sub SangoTool_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If ClassOK Then
            If Timer1.Enabled = False Then
                UpDataPicture(Point, PictureBoxPlay, Bitmap)
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
        Dim Point32 As Int32() = {0, 0, 1, 1}
        Dim TempPoint(PointList.Count - 1, 3) As Int16
        For i = 0 To PointList.Count - 1
            For o = 0 To 3
                TempPoint(i, o) = PointList(i)(o)
            Next
        Next
        For i = 0 To PointList.Count - 1
            If i <> PointList.Count - 1 Then
                TempPoint(i, 0) = TempPoint(i, 0) + OffsetList(20, 0) + OffsetList(i, 0)
                TempPoint(i, 1) = TempPoint(i, 1) + OffsetList(20, 1) + OffsetList(i, 1)
            End If
            Point32 = {Point(0), Point(1), Point(2), Point(3)}
            Point32 = Calculator(Point32, {TempPoint(i, 0), TempPoint(i, 1), TempPoint(i, 2), TempPoint(i, 3)}, Bitmap.GetPixel(0, 0).A, TempBitmap(i).GetPixel(0, 0).A)
            Point = {Point32(0), Point32(1), Point32(2), Point32(3)}
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
        Point32 = {Point(0), Point(1), Point(2), Point(3)}
        Bitmap = BitmapTransform(Bitmap, Flip, Zoom, AntiAliasing, ZoomRate)
        Point32 = PointTransform(Point32, Flip, Zoom, AntiAliasing, ZoomRate)
        Point = {Point32(0), Point32(1), Point32(2), Point32(3)}
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

    Private Sub BackgroundWorkerPlay_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerPlay.DoWork
        PlayLoadFrame = 0
        For p = 0 To PlayBitmap.Count - 1
            If PlayRendering = True Then
                PlayLoadFrame = 0
                p = 0
                PlayRendering = False
            End If
            If BackgroundWorkerOut.IsBusy Then
                If p = OutProgress + 1 Then p = OutProgress
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

                PlayTempPoint(i * 2)(0) = PlayTempPoint(i * 2)(0) + OffsetList(20, 0) + OffsetList(i * 2, 0)
                PlayTempPoint(i * 2 + 1)(0) = PlayTempPoint(i * 2 + 1)(0) + OffsetList(20, 0) + OffsetList(i * 2 + 1, 0)
                PlayTempPoint(i * 2)(1) = PlayTempPoint(i * 2)(1) + OffsetList(20, 1) + OffsetList(i * 2, 1)
                PlayTempPoint(i * 2 + 1)(1) = PlayTempPoint(i * 2 + 1)(1) + OffsetList(20, 1) + OffsetList(i * 2 + 1, 1)
            Next
            PlayPoint(p) = {0, 0, 1, 1}
            For i = 0 To PlayTempPoint.Count - 1
                PlayPoint(p) = Calculator(PlayPoint(p), PlayTempPoint(i), PlayBitmap(p).GetPixel(0, 0).A, PlayTempBitmap(i).GetPixel(0, 0).A)
            Next
            PlayBitmap(p).Dispose()
            PlayBitmap(p) = New Bitmap(Convert.ToInt32(PlayPoint(p)(2)), Convert.ToInt32(PlayPoint(p)(3)))
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
            PlayBitmap(p) = BitmapTransform(PlayBitmap(p), Flip, Zoom, AntiAliasing, ZoomRate)
            PlayPoint(p) = PointTransform(PlayPoint(p), Flip, Zoom, AntiAliasing, ZoomRate)
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
        Next
    End Sub

    Private Sub BackgroundWorkerOut_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerOut.DoWork
        OutProgress = 0
        Dim OutShadowPath = ShadowPath
        Dim OutPath As String()
        Dim OutTempColor As Color() = {}
        Dim OutTempChannel As Object() = {}
        Dim OutFlip As Boolean = Flip
        Dim OutZoom As Boolean = Zoom
        Dim OutAntiAliasing As Boolean = AntiAliasing
        Dim OutZoomRate As Double = ZoomRate
        Dim OutOffsetList = {{0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0},
                             {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}}
        ReDim OutPath(TempPath.Count - 1)
        For i = 0 To OutPath.Count - 1
            OutPath(i) = TempPath(i)
        Next
        ReDim OutTempColor(TempColor.Count - 1)
        For i = 0 To OutTempColor.Count - 1
            OutTempColor(i) = TempColor(i)
        Next
        ReDim OutTempChannel(TempChannel.Count - 1)
        For i = 0 To OutTempChannel.Count - 1
            OutTempChannel(i) = {0, 1, 2}
            For o = 0 To 2
                OutTempChannel(i)(o) = TempChannel(i)(o)
            Next
        Next
        For i = 0 To 21
            For o = 0 To 1
                OutOffsetList(i, o) = OffsetList(i, o)
            Next
        Next
        For p = 0 To OutBitmap.Count - 1
            If BackgroundWorkerPlay.IsBusy Then
                If p = PlayFrame(0) + 1 Then p = PlayFrame(0)
            End If
            Dim CoverBitmap = New Bitmap(1, 1)
            Dim CoverPoint = {0, 0, 1, 1}
            Dim ShadowsPoint = {0, 0, 1, 1}
            Dim shpfiles As String = OutShadowPath + SubPath(p) + "\s" + FileList(p)
            Dim shpfiles2 As String = OutShadowPath + "\shadow" + FileList(p)
            OutTempBitmap(OutTempBitmap.Count - 1).Dispose()
            OutTempBitmap(OutTempBitmap.Count - 1) = SHPToBitmap(shpfiles, shpfiles2)
            OutTempPoint(OutTempBitmap.Count - 1) = GetCenterPoint(shpfiles, shpfiles2)
            For i = 0 To 10 - 1
                Dim shpfile As String = OutPath(i) + SubPath(p) + FileList(p)
                Dim shpfile2 As String = OutPath(i) + FileList(p)
                Dim covfile As String = OutPath(i) + SubPath(p) + "\_cov" + FileList(p)
                Dim covfile2 As String = OutPath(i) + "\cover" + FileList(p)
                OutTempBitmap(i * 2).Dispose()
                OutTempBitmap(i * 2) = SHPToBitmap(shpfile, shpfile2, OutTempChannel(i)(0), OutTempChannel(i)(1), OutTempChannel(i)(2))
                OutTempPoint(i * 2) = GetCenterPoint(shpfile, shpfile2)
                OutTempBitmap(i * 2 + 1).Dispose()
                OutTempBitmap(i * 2 + 1) = SHPToBitmap(covfile, covfile2)
                OutTempPoint(i * 2 + 1) = GetCenterPoint(covfile, covfile2)
                OutTempPoint(i * 2)(0) = OutTempPoint(i * 2)(0) + OutOffsetList(20, 0) + OutOffsetList(i * 2, 0)
                OutTempPoint(i * 2 + 1)(0) = OutTempPoint(i * 2 + 1)(0) + OutOffsetList(20, 0) + OutOffsetList(i * 2 + 1, 0)
                OutTempPoint(i * 2)(1) = OutTempPoint(i * 2)(1) + OutOffsetList(20, 1) + OutOffsetList(i * 2, 1)
                OutTempPoint(i * 2 + 1)(1) = OutTempPoint(i * 2 + 1)(1) + OutOffsetList(20, 1) + OutOffsetList(i * 2 + 1, 1)
            Next
            OutPoint(p) = {0, 0, 1, 1}
            Dim PointCount As Int16
            If MergeShadows Then
                PointCount = OutTempPoint.Count - 1
            Else
                PointCount = OutTempPoint.Count - 2
                ShadowsPoint = Calculator(ShadowsPoint, OutTempPoint(OutTempPoint.Count - 1), CoverBitmap.GetPixel(0, 0).A, OutTempBitmap(OutTempPoint.Count - 1).GetPixel(0, 0).A)
            End If
            For i = 0 To PointCount
                If MergeCover Then
                    OutPoint(p) = Calculator(OutPoint(p), OutTempPoint(i), OutBitmap(p).GetPixel(0, 0).A, OutTempBitmap(i).GetPixel(0, 0).A)
                Else
                    If i Mod 2 = 0 Then
                        OutPoint(p) = Calculator(OutPoint(p), OutTempPoint(i), OutBitmap(p).GetPixel(0, 0).A, OutTempBitmap(i).GetPixel(0, 0).A)
                    Else
                        CoverPoint = Calculator(CoverPoint, OutTempPoint(i), CoverBitmap.GetPixel(0, 0).A, OutTempBitmap(i).GetPixel(0, 0).A)
                    End If
                End If
            Next
            OutBitmap(p).Dispose()
            OutBitmap(p) = New Bitmap(Convert.ToInt32(OutPoint(p)(2)), Convert.ToInt32(OutPoint(p)(3)))
            If MergeShadows Then
                For y = 0 To OutTempBitmap(OutTempBitmap.Count - 1).Height - 1
                    For x = 0 To OutTempBitmap(OutTempBitmap.Count - 1).Width - 1
                        Dim Color As Color = OutTempBitmap(OutTempBitmap.Count - 1).GetPixel(x, y)
                        If Color.A > 0 Then
                            OutBitmap(p).SetPixel(x - OutTempPoint(OutTempBitmap.Count - 1)(0) + OutPoint(p)(0), y - OutTempPoint(OutTempBitmap.Count - 1)(1) + OutPoint(p)(1), Color.Black)
                        End If
                    Next
                Next
            End If
            For i = 0 To OutTempBitmap.Count - 2
                For y = 0 To OutTempBitmap(i).Height - 1
                    For x = 0 To OutTempBitmap(i).Width - 1
                        Dim Color As Color = OutTempBitmap(i).GetPixel(x, y)
                        If Color.A > 0 Then
                            If i Mod 2 = 1 Then
                                If MergeCover Then
                                    Dim c As Int16 = (i - 1) / 2
                                    If OutTempColor(c).A > 0 Then
                                        Dim R1 As Int16 = OutTempBitmap(i).GetPixel(x, y).R
                                        Dim G1 As Int16 = OutTempBitmap(i).GetPixel(x, y).G
                                        Dim B1 As Int16 = OutTempBitmap(i).GetPixel(x, y).B
                                        Dim R2 As Int16 = OutTempColor(c).R
                                        Dim G2 As Int16 = OutTempColor(c).G
                                        Dim B2 As Int16 = OutTempColor(c).B
                                        Dim R As Int32 = R2 / 255 * R1
                                        Dim G As Int32 = G2 / 255 * G1
                                        Dim B As Int32 = B2 / 255 * B1
                                        Color = Color.FromArgb(R, G, B)
                                        OutBitmap(p).SetPixel(x - OutTempPoint(i)(0) + OutPoint(p)(0), y - OutTempPoint(i)(1) + OutPoint(p)(1), Color)
                                    End If
                                End If
                            Else
                                OutBitmap(p).SetPixel(x - OutTempPoint(i)(0) + OutPoint(p)(0), y - OutTempPoint(i)(1) + OutPoint(p)(1), Color)
                            End If
                        End If
                    Next
                Next
            Next
            If MergeCover = False Then
                CoverBitmap = New Bitmap(CoverPoint(2), CoverPoint(3))
                For i = 0 To OutTempBitmap.Count - 2
                    For y = 0 To OutTempBitmap(i).Height - 1
                        For x = 0 To OutTempBitmap(i).Width - 1
                            Dim Color As Color = OutTempBitmap(i).GetPixel(x, y)
                            If Color.A > 0 Then
                                If i Mod 2 = 1 Then
                                    CoverBitmap.SetPixel(x - OutTempPoint(i)(0) + CoverPoint(0), y - OutTempPoint(i)(1) + CoverPoint(1), Color)
                                Else
                                    Dim x2 = x - OutTempPoint(i)(0) + CoverPoint(0)
                                    Dim y2 = y - OutTempPoint(i)(1) + CoverPoint(1)
                                    If x2 >= 0 And x2 < CoverBitmap.Width And y2 >= 0 And y2 < CoverBitmap.Height Then
                                        CoverBitmap.SetPixel(x2, y2, Color.Transparent)
                                    End If
                                End If
                            End If
                        Next
                    Next
                Next
            End If
            OutBitmap(p) = BitmapTransform(OutBitmap(p), OutFlip, OutZoom, OutAntiAliasing, OutZoomRate)
            OutPoint(p) = PointTransform(OutPoint(p), OutFlip, OutZoom, OutAntiAliasing, OutZoomRate)
            'OutBitmap(p).Save(OutputPath + FileList(p) + ".png")
            BitmapToSHP(OutBitmap(p), OutputPath + FileList(p), OutPoint(p)(0), OutPoint(p)(1))
            If MergeCover = False Then
                IO.Directory.CreateDirectory(OutputPath + "\cover")
                CoverBitmap = BitmapTransform(CoverBitmap, OutFlip, OutZoom, OutAntiAliasing, OutZoomRate)
                CoverPoint = PointTransform(CoverPoint, OutFlip, OutZoom, OutAntiAliasing, OutZoomRate)
                'CoverBitmap.Save(OutputPath + "\cover" + FileList(p) + ".png")
                BitmapToSHP(CoverBitmap, OutputPath + "\cover" + FileList(p), CoverPoint(0), CoverPoint(1))
            End If
            If MergeShadows = False Then
                IO.Directory.CreateDirectory(OutputPath + "\shadow")
                OutTempBitmap(OutTempBitmap.Count - 1) = BitmapTransform(OutTempBitmap(OutTempBitmap.Count - 1), OutFlip, OutZoom, OutAntiAliasing, OutZoomRate)
                ShadowsPoint = PointTransform(ShadowsPoint, OutFlip, OutZoom, OutAntiAliasing, OutZoomRate)
                'OutTempBitmap(OutTempBitmap.Count - 1).Save(OutputPath + "\shadow" + FileList(p) + ".png")
                BitmapToSHP(OutTempBitmap(OutTempBitmap.Count - 1), OutputPath + "\shadow" + FileList(p), ShadowsPoint(0), ShadowsPoint(1))
            End If
            OutProgress = p
        Next
        PlaySound("SystemHand", 0, SND_ALIAS Or SND_SYNC)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PlayFrame(1) = 0 Then Exit Sub
        If PlayFrame(0) > PlayFrame(1) Then
            PlayFrame(0) = 0
        End If
        If PlayFrame(0) > PlayLoadFrame Then
            PlayFrame(0) = 0 'PlayLoadFrame
        End If
        Label1.Text = PlayFrame(0).ToString + "/" + PlayFrame(1).ToString
        If PlayLoadFrame = 0 Then
            PictureBoxPlay.Image = CreateImage("Loading", 64, 64, "#ffffff")
        Else
            UpDataPicture({PlayPoint(PlayFrame(0))(0), PlayPoint(PlayFrame(0))(1)}, PictureBoxPlay, PlayBitmap(PlayFrame(0)))
            PlayFrame(0) = PlayFrame(0) + 1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If BackgroundWorkerPlay.IsBusy Then
            ProgressBar1.Value = PlayLoadFrame
        Else
            ProgressBar1.Value = ProgressBar1.Maximum
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If BackgroundWorkerOut.IsBusy Then
            OutObject.ProgressBar1.Value = OutProgress
            OutObject.Label3.Text = Convert.ToInt32((OutProgress + 1) / OutBitmap.Count * 100).ToString + "%"
        Else
            OutObject.SplitContainer1.Panel1Collapsed = False
            OutObject.SplitContainer1.Panel2Collapsed = True
            Timer3.Enabled = False
        End If
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
        Label1.Text = PlayFrame(0).ToString + "/" + PlayFrame(1).ToString
        If PlayLoadFrame = 0 Then
            PictureBoxPlay.Image = CreateImage("Loading", 64, 64, "#ffffff")
        Else
            UpDataPicture({PlayPoint(PlayFrame(0))(0), PlayPoint(PlayFrame(0))(1)}, PictureBoxPlay, PlayBitmap(PlayFrame(0)))
        End If
    End Sub

    Private Sub ButtonPlay_Click(sender As Object, e As EventArgs) Handles ButtonPlay.Click
        Timer1.Enabled = Not Timer1.Enabled
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        Timer1.Enabled = False
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
            UpDataPicture({PlayPoint(PlayFrame(0))(0), PlayPoint(PlayFrame(0))(1)}, PictureBoxPlay, PlayBitmap(PlayFrame(0)))
        End If
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        FolderBrowserDialog1.SelectedPath = "H:\三国群英传ol_全集\GenNude\F"
        FileList = GetFileList(FolderBrowserDialog1.SelectedPath)
        SubPath = GetSubPath(FolderBrowserDialog1.SelectedPath)

        ReDim PlayBitmap(FileList.Count - 1)
        ReDim PlayPoint(FileList.Count - 1)
        ReDim OutBitmap(FileList.Count - 1)
        ReDim OutPoint(FileList.Count - 1)
        For i = 0 To PlayBitmap.Count - 1
            PlayBitmap(i) = New Bitmap(1, 1)
            OutBitmap(i) = New Bitmap(1, 1)
        Next
        For i = 0 To PlayPoint.Count - 1
            PlayPoint(i) = {0, 0, 1, 1}
            OutPoint(i) = {0, 0, 1, 1}
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

    Private Sub ButtonOutput_Click(sender As Object, e As EventArgs) Handles ButtonOutput.Click
        OutObject.ShowDialog()
        If OutObject.SplitContainer1.Panel1Collapsed Then
            If Not BackgroundWorkerOut.IsBusy Then
                MergeShadows = OutObject.MergeShadowsTrue.Checked
                MergeCover = OutObject.MergeCoverTrue.Checked
                OutputPath = OutObject.FolderBrowserDialog1.SelectedPath
                OutObject.ProgressBar1.Maximum = OutBitmap.Count - 1
                BackgroundWorkerOut.RunWorkerAsync()
                Timer3.Enabled = True
            End If
        End If
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
        Refreshing()
    End Sub

    Private Sub SetObjectColor(SelectBodyIndex As Int16)
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

End Class
