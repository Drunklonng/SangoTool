Public Class SangoTool
    Dim StopPlay As Boolean = False
    Dim ClassOK As Boolean = False
    Dim SelectTab As Int16() = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Dim TempColor As Color() = {}
    Dim TempBitmap As Bitmap() = {}
    Dim PointList As Object() = {}
    Dim TempPath As String() = {}
    Dim TempChannel As Object() = {}
    Dim SingleShadow As Boolean = False
    Dim SingleShadowFile As String() = {"", ""}
    Dim ShadowPath As String = ""
    Dim SubPath As String() = {""}
    Dim FileList As String() = {""}
    Dim DeathShadow As Boolean() = {False}
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
        Reload()
        ClassOK = True
    End Sub

    Private Sub SangoTool_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If ClassOK Then
            If Timer1.Enabled = False Then
                UpDataPicture(Point, PictureBoxPlay, Bitmap)
            End If
        End If
    End Sub

    Private Sub Reload()
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
            TempColor(i) = Color.White
            TempChannel(i) = {0, 1, 2}
        Next
        ShadowPath = ""
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
                If DeathShadow(0) = True Then
                    TempPoint(i, 0) = TempPoint(i, 0) + OffsetList(21, 0)
                    TempPoint(i, 1) = TempPoint(i, 1) + OffsetList(21, 1)
                End If
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
                If Point(0) < Bitmap.Width AndAlso Point(0) >= 0 AndAlso Bitmap.GetPixel(Point(0), y).A = 0 Then
                    Bitmap.SetPixel(Point(0), y, Color.Red)
                End If
            Next
            For x = 0 To Bitmap.Width - 1
                If Point(1) < Bitmap.Height AndAlso Point(1) >= 0 AndAlso Bitmap.GetPixel(x, Point(1)).A = 0 Then
                    Bitmap.SetPixel(x, Point(1), Color.Red)
                End If
            Next
        End If
        UpDataPicture(Point, PictureBoxPlay, Bitmap)
        Playback.Text = "0/" + PlayFrame(1).ToString
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
            If StopPlay Then
                Exit Sub
            End If
            If PlayRendering = True Then
                PlayLoadFrame = 0
                p = 0
                PlayRendering = False
            End If
            If BackgroundWorkerOut.IsBusy Then
                If p = OutProgress + 1 Then p = OutProgress
            End If
            If SingleShadow Then
                Dim shpfile As String = ""
                If DeathShadow(p) = False Then
                    shpfile = SingleShadowFile(0)
                End If
                PlayTempBitmap(PlayTempBitmap.Count - 1).Dispose()
                PlayTempBitmap(PlayTempBitmap.Count - 1) = SHPToBitmap(shpfile)
                PlayTempPoint(PlayTempBitmap.Count - 1) = GetCenterPoint(shpfile)
            Else
                Dim PlayShadowPath = ShadowPath
                Dim shpfiles As String = PlayShadowPath + SubPath(p) + "\s" + FileList(p)
                Dim shpfiles2 As String = PlayShadowPath + "\shadow" + FileList(p)
                PlayTempBitmap(PlayTempBitmap.Count - 1).Dispose()
                PlayTempBitmap(PlayTempBitmap.Count - 1) = SHPToBitmap(shpfiles, shpfiles2)
                PlayTempPoint(PlayTempBitmap.Count - 1) = GetCenterPoint(shpfiles, shpfiles2)
            End If
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
                If DeathShadow(p) = True Then
                    PlayTempPoint(i * 2)(0) = PlayTempPoint(i * 2)(0) + OffsetList(21, 0)
                    PlayTempPoint(i * 2 + 1)(0) = PlayTempPoint(i * 2 + 1)(0) + OffsetList(21, 0)
                    PlayTempPoint(i * 2)(1) = PlayTempPoint(i * 2)(1) + OffsetList(21, 1)
                    PlayTempPoint(i * 2 + 1)(1) = PlayTempPoint(i * 2 + 1)(1) + OffsetList(21, 1)
                End If
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
                    If PlayPoint(p)(0) < PlayBitmap(p).Width AndAlso PlayPoint(p)(0) >= 0 AndAlso PlayBitmap(p).GetPixel(PlayPoint(p)(0), y).A = 0 Then
                        PlayBitmap(p).SetPixel(PlayPoint(p)(0), y, Color.Red)
                    End If
                Next
                For x = 0 To PlayBitmap(p).Width - 1
                    If PlayPoint(p)(1) < PlayBitmap(p).Height AndAlso PlayPoint(p)(1) >= 0 AndAlso PlayBitmap(p).GetPixel(x, PlayPoint(p)(1)).A = 0 Then
                        PlayBitmap(p).SetPixel(x, PlayPoint(p)(1), Color.Red)
                    End If
                Next
            End If
            PlayLoadFrame = p
        Next
        For i = 0 To PlayTempBitmap.Count - 1
            PlayTempBitmap(i).Dispose()
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
            OutBitmap(p) = New Bitmap(1, 1)
            If SingleShadow Then
                Dim shpfile As String
                If DeathShadow(p) = True Then
                    shpfile = SingleShadowFile(1)
                Else
                    shpfile = SingleShadowFile(0)
                End If
                OutTempBitmap(OutTempBitmap.Count - 1).Dispose()
                OutTempBitmap(OutTempBitmap.Count - 1) = SHPToBitmap(shpfile)
                OutTempPoint(OutTempBitmap.Count - 1) = GetCenterPoint(shpfile)
            Else
                Dim shpfiles As String = OutShadowPath + SubPath(p) + "\s" + FileList(p)
                Dim shpfiles2 As String = OutShadowPath + "\shadow" + FileList(p)
                OutTempBitmap(OutTempBitmap.Count - 1).Dispose()
                OutTempBitmap(OutTempBitmap.Count - 1) = SHPToBitmap(shpfiles, shpfiles2)
                OutTempPoint(OutTempBitmap.Count - 1) = GetCenterPoint(shpfiles, shpfiles2)
            End If
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
                If DeathShadow(p) = True Then
                    OutTempPoint(i * 2)(0) = OutTempPoint(i * 2)(0) + OutOffsetList(21, 0)
                    OutTempPoint(i * 2 + 1)(0) = OutTempPoint(i * 2 + 1)(0) + OutOffsetList(21, 0)
                    OutTempPoint(i * 2)(1) = OutTempPoint(i * 2)(1) + OutOffsetList(21, 1)
                    OutTempPoint(i * 2 + 1)(1) = OutTempPoint(i * 2 + 1)(1) + OutOffsetList(21, 1)
                End If
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
                If DeathShadow(p) = False Then
                    For y = 0 To OutTempBitmap(OutTempBitmap.Count - 1).Height - 1
                        For x = 0 To OutTempBitmap(OutTempBitmap.Count - 1).Width - 1
                            Dim Color As Color = OutTempBitmap(OutTempBitmap.Count - 1).GetPixel(x, y)
                            If Color.A > 0 Then
                                OutBitmap(p).SetPixel(x - OutTempPoint(OutTempBitmap.Count - 1)(0) + OutPoint(p)(0), y - OutTempPoint(OutTempBitmap.Count - 1)(1) + OutPoint(p)(1), Color.Black)
                            End If
                        Next
                    Next
                End If
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
                                    If TempColor((i - 1) / 2).A > 0 Then
                                        CoverBitmap.SetPixel(x - OutTempPoint(i)(0) + CoverPoint(0), y - OutTempPoint(i)(1) + CoverPoint(1), Color)
                                    End If
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
                ' CoverBitmap.Save(OutputPath + "\cover" + FileList(p) + ".png")
                BitmapToSHP(CoverBitmap, OutputPath + "\cover" + FileList(p), CoverPoint(0), CoverPoint(1))
            End If
            If MergeShadows = False Then
                IO.Directory.CreateDirectory(OutputPath + "\shadow")
                OutTempBitmap(OutTempBitmap.Count - 1) = BitmapTransform(OutTempBitmap(OutTempBitmap.Count - 1), OutFlip, OutZoom, OutAntiAliasing, OutZoomRate)
                ShadowsPoint = PointTransform(ShadowsPoint, OutFlip, OutZoom, OutAntiAliasing, OutZoomRate)
                'OutTempBitmap(OutTempBitmap.Count - 1).Save(OutputPath + "\shadow" + FileList(p) + ".png")
                BitmapToSHP(OutTempBitmap(OutTempBitmap.Count - 1), OutputPath + "\shadow" + FileList(p), ShadowsPoint(0), ShadowsPoint(1))
            End If
            CoverBitmap.Dispose()
            OutProgress = p
        Next
        For i = 0 To OutTempBitmap.Count - 1
            OutTempBitmap(i).Dispose()
        Next
        For i = 0 To OutBitmap.Count - 1
            OutBitmap(i).Dispose()
        Next
        PlaySound("SystemHand", 0, SND_ALIAS Or SND_SYNC)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PlayFrame(1) = 0 Then Exit Sub
        If PlayFrame(0) > PlayFrame(1) Then
            PlayFrame(0) = 0
        End If
        If PlayFrame(0) > PlayLoadFrame Then
            PlayFrame(0) = 0
        End If
        Playback.Text = PlayFrame(0).ToString + "/" + PlayFrame(1).ToString
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
        GoToFrame(-1)
    End Sub

    Private Sub ButtonPlay_Click(sender As Object, e As EventArgs) Handles ButtonPlay.Click
        Timer1.Enabled = Not Timer1.Enabled
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        GoToFrame(1)
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        If BackgroundWorkerOut.IsBusy Then
            OutObject.ShowDialog()
        Else
            Do
                If BackgroundWorkerPlay.IsBusy Then
                    StopPlay = True
                Else
                    StopPlay = False
                    Exit Do
                End If
                Windows.Forms.Application.DoEvents()
            Loop
            Dim ImportPath As String = ""
            NewObject.ButtonOK.Enabled = False
            NewObject.ShowDialog()
            If NewObject.ButtonOK.Enabled = True Then
                Reload()
                If NewObject.RadioButton1.Checked Then
                    FileList = {"\a0001.shp", "\a0002.shp", "\a0003.shp", "\a0004.shp", "\a0005.shp", "\a0006.shp", "\a0007.shp",
                        "\a0008.shp", "\a0009.shp", "\a0010.shp", "\a0011.shp", "\a0012.shp", "\a0013.shp", "\a0014.shp", "\a0015.shp",
                        "\a0016.shp", "\a0017.shp", "\a0018.shp", "\a0019.shp", "\a0020.shp", "\a0021.shp", "\a0022.shp", "\a0023.shp",
                        "\a0024.shp", "\a0025.shp", "\a0026.shp", "\a0027.shp", "\a0028.shp", "\a0029.shp", "\a0030.shp", "\a0031.shp",
                        "\a0032.shp", "\a0033.shp", "\a0034.shp", "\a0035.shp", "\a0036.shp", "\a0037.shp", "\a0038.shp", "\a0039.shp",
                        "\a0040.shp", "\a0041.shp", "\a0042.shp", "\a0043.shp", "\a0044.shp", "\a0045.shp", "\a0046.shp", "\a0047.shp",
                        "\a0048.shp", "\a0049.shp", "\a0050.shp", "\a0051.shp", "\a0052.shp", "\a0053.shp", "\a0054.shp", "\a0055.shp",
                        "\a0056.shp", "\a0057.shp", "\a0058.shp", "\a0059.shp", "\a0060.shp", "\a0061.shp", "\a0062.shp", "\a0063.shp",
                        "\a0064.shp", "\a0065.shp", "\a0066.shp", "\a0067.shp", "\a0068.shp", "\a0069.shp", "\a0070.shp", "\a0071.shp",
                        "\a0072.shp", "\a0073.shp", "\a0074.shp", "\a0075.shp", "\a0076.shp", "\a0077.shp", "\a0078.shp", "\a0079.shp",
                        "\a0080.shp", "\a0081.shp", "\a0082.shp", "\a0083.shp", "\a0084.shp", "\a0085.shp", "\a0086.shp", "\a0087.shp",
                        "\a0088.shp", "\a0089.shp", "\a0090.shp", "\a0091.shp", "\a0092.shp", "\a0093.shp", "\a0094.shp", "\a0095.shp",
                        "\a0096.shp", "\a0097.shp", "\a0098.shp", "\a0099.shp", "\a0100.shp", "\a0101.shp", "\a0102.shp", "\a0103.shp",
                        "\a0104.shp", "\a0105.shp", "\a0106.shp", "\a0107.shp", "\a0108.shp", "\a0109.shp", "\a0110.shp", "\a0111.shp",
                        "\a0112.shp", "\a0113.shp", "\a0114.shp", "\a0115.shp", "\a0116.shp", "\a0117.shp", "\a0118.shp", "\a0119.shp",
                        "\a0120.shp", "\a0121.shp", "\a0122.shp", "\a0123.shp", "\a0124.shp", "\a0125.shp", "\a0126.shp", "\a0127.shp",
                        "\w0017.shp", "\w0018.shp", "\w0019.shp", "\w0020.shp",
                        "\f0001.shp", "\f0002.shp", "\f0003.shp", "\f0004.shp", "\f0005.shp",
                        "\f0006.shp", "\f0007.shp", "\f0008.shp", "\f0009.shp", "\f0010.shp",
                        "\w0021.shp", "\w0022.shp",
                        "\a0128.shp", "\a0129.shp", "\a0130.shp", "\a0131.shp", "\a0132.shp", "\a0133.shp", "\a0134.shp", "\a0135.shp",
                        "\a0136.shp", "\a0137.shp", "\a0138.shp", "\a0139.shp", "\a0140.shp", "\a0141.shp", "\a0142.shp", "\a0143.shp", "\a0144.shp",
                        "\r10001.shp", "\r10002.shp", "\r10003.shp", "\r10004.shp", "\r10005.shp", "\r10006.shp", "\r10007.shp", "\r10008.shp", "\r10009.shp", "\r10010.shp",
                        "\r20001.shp", "\r20002.shp", "\r20003.shp", "\r20004.shp", "\r20005.shp", "\r20006.shp", "\r20007.shp", "\r20008.shp",
                        "\w0001.shp", "\w0002.shp", "\w0003.shp", "\w0004.shp",
                        "\w0005.shp", "\w0006.shp", "\w0007.shp", "\w0008.shp",
                        "\w0009.shp", "\w0010.shp", "\w0011.shp", "\w0012.shp",
                        "\w0013.shp", "\w0014.shp", "\w0015.shp", "\w0016.shp"}
                    SubPath = {"\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A02", "\A02", "\A02", "\A02", "\A02", "\A02", "\A02", "\A02",
                        "\A03", "\A03", "\A03", "\A03", "\A03", "\A03", "\A03", "\A03", "\A04", "\A04", "\A04", "\A04", "\A04", "\A04", "\A04", "\A04",
                        "\A05", "\A05", "\A05", "\A05", "\A05", "\A05", "\A05", "\A05", "\A06", "\A06", "\A06", "\A06", "\A06", "\A06", "\A06", "\A06",
                        "\A07", "\A07", "\A07", "\A07", "\A07", "\A07", "\A07", "\A07", "\A08", "\A08", "\A08", "\A08", "\A08", "\A08", "\A08", "\A08",
                        "\A09", "\A09", "\A09", "\A09", "\A09", "\A09", "\A09", "\A09", "\B01", "\B01", "\B01", "\B01", "\B01", "\B01", "\B01", "\B01",
                        "\B02", "\B02", "\B02", "\B02", "\B02", "\B02", "\B02", "\B02", "\B03", "\B03", "\B03", "\B03", "\B03", "\B03", "\B03", "\B03",
                        "\B04", "\B04", "\B04", "\B04", "\B04", "\B04", "\B04", "\B04", "\B05", "\B05", "\B05", "\B05", "\B05", "\B05", "\B05", "\B05",
                        "\B06", "\B06", "\B06", "\B06", "\B06", "\B06", "\B06", "\B06", "\B07", "\B07", "\B07", "\B07", "\B07", "\B07", "\B07", "\B07",
                        "\D01", "\D01", "\D02", "\D02", "\F01", "\F01", "\F01", "\F01", "\F01", "\F02", "\F02", "\F02", "\F02", "\F02", "\H01", "\H01",
                        "\L01", "\L01", "\L01", "\L01", "\L01", "\L01", "\L01", "\L01", "\L02", "\L02", "\L02", "\L02", "\L02", "\L02", "\L02", "\L02", "\L02",
                        "\R01", "\R01", "\R01", "\R01", "\R01", "\R01", "\R01", "\R01", "\R01", "\R01", "\R02", "\R02", "\R02", "\R02", "\R02", "\R02", "\R02", "\R02",
                        "\W01", "\W01", "\W01", "\W01", "\W02", "\W02", "\W02", "\W02", "\W03", "\W03", "\W03", "\W03", "\W04", "\W04", "\W04", "\W04"}
                    ReDim DeathShadow(FileList.Count - 1)
                    For i = 0 To FileList.Count - 1
                        DeathShadow(i) = False
                    Next
                    For i = 131 To 140
                        DeathShadow(i) = True
                    Next
                End If
                If NewObject.RadioButton2.Checked Then
                    FileList = {"\w0017.shp", "\w0018.shp", "\w0019.shp", "\w0020.shp", "\w0021.shp", "\w0022.shp", "\w0023.shp", "\w0024.shp", "\w0025.shp", "\w0026.shp", "\w0027.shp", "\w0028.shp", "\w0029.shp", "\w0030.shp", "\w0031.shp", "\w0032.shp", "\w0033.shp", "\w0034.shp", "\w0035.shp", "\w0036.shp", "\w0037.shp", "\w0038.shp", "\w0039.shp", "\w0040.shp", "\w0041.shp", "\w0042.shp", "\w0043.shp", "\w0044.shp", "\w0045.shp", "\w0046.shp", "\w0047.shp", "\w0048.shp",
                        "\w0049.shp", "\w0050.shp", "\w0051.shp", "\w0052.shp", "\w0053.shp", "\w0054.shp", "\w0055.shp", "\w0056.shp",
                        "\w0081.shp", "\w0082.shp", "\w0106.shp", "\w0107.shp", "\w0108.shp", "\w0109.shp", "\w0110.shp",
                        "\w0083.shp", "\w0084.shp",
                        "\w0085.shp", "\w0086.shp", "\w0087.shp", "\w0088.shp", "\w0089.shp", "\w0090.shp", "\w0091.shp", "\w0092.shp", "\w0093.shp", "\w0094.shp",
                        "\w0001.shp", "\w0002.shp", "\w0003.shp", "\w0004.shp", "\w0005.shp", "\w0006.shp", "\w0007.shp", "\w0008.shp", "\w0009.shp", "\w0010.shp", "\w0011.shp", "\w0012.shp", "\w0013.shp", "\w0014.shp", "\w0015.shp", "\w0016.shp",
                        "\w0095.shp", "\w0096.shp", "\w0097.shp", "\w0098.shp", "\w0099.shp", "\w0100.shp", "\w0101.shp", "\w0102.shp",
                        "\w0103.shp", "\w0104.shp", "\w0105.shp"}
                    SubPath = {"\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01", "\A01",
                        "\A02", "\A02", "\A02", "\A02", "\A02", "\A02", "\A02", "\A02",
                        "\D01", "\D01", "\F01", "\F01", "\F01", "\F01", "\F01", "\H01", "\H01",
                        "\R01", "\R01", "\R01", "\R01", "\R01", "\R01", "\R01", "\R01", "\R01", "\R01",
                        "\W01", "\W01", "\W01", "\W01", "\W01", "\W01", "\W01", "\W01", "\W01", "\W01", "\W01", "\W01", "\W01", "\W01", "\W01", "\W01",
                        "\X02", "\X02", "\X02", "\X02", "\X02", "\X02", "\X02", "\X02", "\X03", "\X03", "\X03"}
                    ReDim DeathShadow(FileList.Count - 1)
                    For i = 0 To FileList.Count - 1
                        DeathShadow(i) = False
                    Next
                    For i = 42 To 46
                        DeathShadow(i) = True
                    Next
                End If
                If NewObject.RadioButton3.Checked Then
                    FolderBrowserDialog1.SelectedPath = GetINI("ImportObject", "ImportPath", "", Application.StartupPath + "\SangoTool.ini")
                    FolderBrowserDialog1.ShowDialog()
                    WriteINI("ImportObject", "ImportPath", FolderBrowserDialog1.SelectedPath, Application.StartupPath + "\SangoTool.ini")
                    ImportPath = FolderBrowserDialog1.SelectedPath
                    Dim strlist As String() = {"A", "B", "D", "F", "H", "R", "W"}
                    Dim IncludeSubPath As Boolean = False
                    For i = 0 To strlist.Count - 1
                        If IO.Directory.Exists(ImportPath + "\" + strlist(i) + "01") Then
                            IncludeSubPath = True
                        End If
                    Next
                    If IncludeSubPath Then
                        FileList = GetFileList(ImportPath)
                        SubPath = GetSubPath(ImportPath)
                    Else
                        Dim TempFileList As String() = IO.Directory.GetFiles(ImportPath, "*.shp")
                        ReDim FileList(TempFileList.Count - 1)
                        For i = 0 To TempFileList.Count - 1
                            Dim str As String = ""
                            Dim a As Int16 = 1
                            Do
                                str = TempFileList(i)(TempFileList(i).Length - a) + str
                                a = a + 1
                            Loop Until TempFileList(i)(TempFileList(i).Length - a) = "\"
                            FileList(i) = "\" + str
                        Next
                        ReDim SubPath(FileList.Count - 1)
                        For i = 0 To SubPath.Count - 1
                            SubPath(i) = ""
                        Next
                    End If
                    ReDim DeathShadow(FileList.Count - 1)
                    For i = 0 To FileList.Count - 1
                        DeathShadow(i) = False
                    Next
                    For i = 0 To FileList.Count - 1
                        Dim str = Strings.StrConv(SubPath(i), VbStrConv.Uppercase)
                        If str = "\F01" OrElse str = "\F02" Then
                            DeathShadow(i) = True
                        End If
                        If str = "" Then
                            Dim str2 = Strings.StrConv(FileList(i), VbStrConv.Uppercase)
                            For a = 1 To 4
                                For b = 1 To 5
                                    If str2 = "\F0" + a.ToString + "000" + b.ToString + ".SHP" Then
                                        DeathShadow(i) = True
                                    End If
                                Next
                            Next
                        End If
                    Next
                End If
                Flip = False
                Zoom = False
                ZoomRate = 1
                AntiAliasing = False
                OffsetList = {{0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0},
                      {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}}
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
                If NewObject.RadioButton3.Checked Then
                    Dim ImportIndex = 4
                    TempPath(ImportIndex) = ImportPath
                    Dim shpfile As String = ImportPath + SubPath(0) + FileList(0)
                    Dim shpfile2 As String = ImportPath + FileList(0)
                    Dim covfile As String = ImportPath + SubPath(0) + "\_cov" + FileList(0)
                    Dim covfile2 As String = ImportPath + "\cover" + FileList(0)
                    TempBitmap(ImportIndex * 2).Dispose()
                    TempBitmap(ImportIndex * 2) = SHPToBitmap(shpfile, shpfile2, TempChannel(ImportIndex)(0), TempChannel(ImportIndex)(1), TempChannel(ImportIndex)(2))
                    PointList(ImportIndex * 2) = GetCenterPoint(shpfile, shpfile2)
                    TempBitmap(ImportIndex * 2 + 1).Dispose()
                    TempBitmap(ImportIndex * 2 + 1) = SHPToBitmap(covfile, covfile2)
                    PointList(ImportIndex * 2 + 1) = GetCenterPoint(covfile, covfile2)
                    PictureBox4.Image = TempBitmap(ImportIndex * 2)
                End If
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
                TableLayoutPanelMian.Visible = True
                Refreshing()
            End If
        End If
    End Sub

    Private Sub ButtonNRead_Click(sender As Object, e As EventArgs) Handles ButtonNRead.Click
        OpenFileDialog1.InitialDirectory = GetINI("OpenObject", "OpenPath", "", Application.StartupPath + "\SangoTool.ini")
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            WriteINI("OpenObject", "OpenPath", IO.Path.GetDirectoryName(OpenFileDialog1.FileName), Application.StartupPath + "\SangoTool.ini")
            If IO.File.Exists(OpenFileDialog1.FileName) Then
                Dim FileNumber As Int16 = GetINI("File", "FileNumber", -1, OpenFileDialog1.FileName)
                PlayFrame(1) = FileNumber
                ProgressBar1.Maximum = FileNumber - 1
                ReDim SubPath(FileNumber)
                ReDim FileList(FileNumber)
                ReDim DeathShadow(FileNumber)
                For i = 0 To FileNumber
                    SubPath(i) = GetINI("File", "SubPath" + i.ToString, "", OpenFileDialog1.FileName)
                    FileList(i) = GetINI("File", "FileName" + i.ToString, "", OpenFileDialog1.FileName)
                    DeathShadow(i) = GetINI("File", "DeathShadow" + i.ToString, "", OpenFileDialog1.FileName)
                Next
                For i = 0 To TempColor.Count - 1
                    Dim argb As Int32 = Val(GetINI("Color", "Color" + i.ToString, "16777215", OpenFileDialog1.FileName))
                    TempColor(i) = Color.FromArgb(argb)
                Next
                Flip = GetINI("Transform", "FLIP", False, OpenFileDialog1.FileName)
                Zoom = GetINI("Transform", "ZOOM", False, OpenFileDialog1.FileName)
                ZoomRate = GetINI("Transform", "ZoomRate", 1, OpenFileDialog1.FileName)
                AntiAliasing = GetINI("Transform", "AntiAliasing", False, OpenFileDialog1.FileName)
                OffsetList(20, 0) = GetINI("Offset", "OffsetAllX", 0, OpenFileDialog1.FileName)
                OffsetList(20, 1) = GetINI("Offset", "OffsetAllY", 0, OpenFileDialog1.FileName)
                For i = 0 To 19
                    OffsetList(i, 0) = GetINI("Offset", "OffsetX" + i.ToString, 0, OpenFileDialog1.FileName)
                    OffsetList(i, 1) = GetINI("Offset", "OffsetY" + i.ToString, 0, OpenFileDialog1.FileName)
                Next
                OffsetList(21, 0) = GetINI(" Offset", "OffsetDeathX", 0, OpenFileDialog1.FileName)
                OffsetList(21, 1) = GetINI(" Offset", "OffsetDeathY", 0, OpenFileDialog1.FileName)
                For i = 0 To TempPath.Count - 1
                    TempPath(i) = GetINI("ObjectPath", "Path" + i.ToString, "", OpenFileDialog1.FileName)
                Next
                SingleShadow = GetINI("ObjectPath", "SingleShadow ", False, OpenFileDialog1.FileName)
                For i = 0 To 1
                    SingleShadowFile(i) = GetINI("ObjectPath", "ShadowFile" + i.ToString, "", OpenFileDialog1.FileName)
                Next
                ShadowPath = GetINI("ObjectPath", "ShadowPath ", "", OpenFileDialog1.FileName)
                For i = 0 To TempChannel.Count - 1
                    TempChannel(i)(0) = GetINI("Channel", "ChannelRed" + i.ToString, 0, OpenFileDialog1.FileName)
                    TempChannel(i)(1) = GetINI("Channel", "ChannelGreen" + i.ToString, 1, OpenFileDialog1.FileName)
                    TempChannel(i)(2) = GetINI("Channel", "ChannelBlue" + i.ToString, 2, OpenFileDialog1.FileName)
                Next
                If ZoomRate < 0.5 Then ZoomRate = 0.5
                If ZoomRate > 2 Then ZoomRate = 2
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
                For i = 0 To TempPath.Count - 1
                    Dim shpfile As String = TempPath(i) + SubPath(0) + FileList(0)
                    Dim shpfile2 As String = TempPath(i) + FileList(0)
                    Dim covfile As String = TempPath(i) + SubPath(0) + "\_cov" + FileList(0)
                    Dim covfile2 As String = TempPath(i) + "\cover" + FileList(0)
                    TempBitmap(i * 2).Dispose()
                    TempBitmap(i * 2) = SHPToBitmap(shpfile, shpfile2, TempChannel(i)(0), TempChannel(i)(1), TempChannel(i)(2))
                    PointList(i * 2) = GetCenterPoint(shpfile, shpfile2)
                    TempBitmap(i * 2 + 1).Dispose()
                    TempBitmap(i * 2 + 1) = SHPToBitmap(covfile, covfile2)
                    PointList(i * 2 + 1) = GetCenterPoint(covfile, covfile2)
                Next
                If TempPath(0) = "" Then
                    PictureBox0.Image = CreateImage("Empty", 80, 40, "#ffffff")
                Else
                    PictureBox0.Image = TempBitmap(0)
                End If
                If TempPath(1) = "" Then
                    PictureBox1.Image = CreateImage("Empty", 80, 40, "#ffffff")
                Else
                    PictureBox1.Image = TempBitmap(2)
                End If
                If TempPath(2) = "" Then
                    PictureBox2.Image = CreateImage("Empty", 80, 40, "#ffffff")
                Else
                    PictureBox2.Image = TempBitmap(4)
                End If
                If TempPath(3) = "" Then
                    PictureBox3.Image = CreateImage("Empty", 80, 40, "#ffffff")
                Else
                    PictureBox3.Image = TempBitmap(6)
                End If
                If TempPath(4) = "" Then
                    PictureBox4.Image = CreateImage("Empty", 80, 40, "#ffffff")
                Else
                    PictureBox4.Image = TempBitmap(8)
                End If
                If TempPath(5) = "" Then
                    PictureBox5.Image = CreateImage("Empty", 80, 40, "#ffffff")
                Else
                    PictureBox5.Image = TempBitmap(10)
                End If
                If TempPath(6) = "" Then
                    PictureBox6.Image = CreateImage("Empty", 80, 40, "#ffffff")
                Else
                    PictureBox6.Image = TempBitmap(12)
                End If
                If TempPath(7) = "" Then
                    PictureBox7.Image = CreateImage("Empty", 80, 40, "#ffffff")
                Else
                    PictureBox7.Image = TempBitmap(14)
                End If
                If TempPath(8) = "" Then
                    PictureBox8.Image = CreateImage("Empty", 80, 40, "#ffffff")
                Else
                    PictureBox8.Image = TempBitmap(16)
                End If
                If TempPath(9) = "" Then
                    PictureBox9.Image = CreateImage("Empty", 80, 40, "#ffffff")
                Else
                    PictureBox9.Image = TempBitmap(18)
                End If
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
                TableLayoutPanelMian.Visible = True
                Refreshing()
            End If
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        SaveFileDialog1.InitialDirectory = GetINI("SaveObject", "SavePath", "", Application.StartupPath + "\SangoTool.ini")
        SaveFileDialog1.FileName = ""
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            WriteINI("SaveObject", "SavePath", IO.Path.GetDirectoryName(SaveFileDialog1.FileName), Application.StartupPath + "\SangoTool.ini")
            WriteINI("File", "FileNumber", FileList.Count - 1, SaveFileDialog1.FileName)
            For i = 0 To FileList.Count - 1
                WriteINI("File", "SubPath" + i.ToString, SubPath(i), SaveFileDialog1.FileName)
                WriteINI("File", "FileName" + i.ToString, FileList(i), SaveFileDialog1.FileName)
                WriteINI("File", "DeathShadow" + i.ToString, DeathShadow(i), SaveFileDialog1.FileName)
            Next
            WriteINI("Transform", "FLIP", Flip, SaveFileDialog1.FileName)
            WriteINI("Transform", "ZOOM", Zoom, SaveFileDialog1.FileName)
            WriteINI("Transform", "AntiAliasing", AntiAliasing, SaveFileDialog1.FileName)
            WriteINI("Transform", "ZoomRate", ZoomRate, SaveFileDialog1.FileName)
            For i = 0 To TempColor.Count - 1
                WriteINI("Color", "Color" + i.ToString, TempColor(i).ToArgb, SaveFileDialog1.FileName)
            Next
            WriteINI("Offset", "OffsetAllX", OffsetList(20, 0), SaveFileDialog1.FileName)
            WriteINI("Offset", "OffsetAllY", OffsetList(20, 1), SaveFileDialog1.FileName)
            For i = 0 To 19
                WriteINI("Offset", "OffsetX" + i.ToString, OffsetList(i, 0), SaveFileDialog1.FileName)
                WriteINI("Offset", "OffsetY" + i.ToString, OffsetList(i, 1), SaveFileDialog1.FileName)
            Next
            WriteINI(" Offset", "OffsetDeathX", OffsetList(21, 0), SaveFileDialog1.FileName)
            WriteINI(" Offset", "OffsetDeathY", OffsetList(21, 1), SaveFileDialog1.FileName)
            For i = 0 To TempPath.Count - 1
                WriteINI("ObjectPath", "Path" + i.ToString, TempPath(i), SaveFileDialog1.FileName)
            Next
            WriteINI("ObjectPath", "SingleShadow ", SingleShadow, SaveFileDialog1.FileName)
            For i = 0 To 1
                WriteINI("ObjectPath", "ShadowFile" + i.ToString, SingleShadowFile(i), SaveFileDialog1.FileName)
            Next
            WriteINI("ObjectPath", "ShadowPath", ShadowPath, SaveFileDialog1.FileName)
            For i = 0 To TempChannel.Count - 1
                WriteINI("Channel", "ChannelRed" + i.ToString, TempChannel(i)(0), SaveFileDialog1.FileName)
                WriteINI("Channel", "ChannelGreen" + i.ToString, TempChannel(i)(1), SaveFileDialog1.FileName)
                WriteINI("Channel", "ChannelBlue" + i.ToString, TempChannel(i)(2), SaveFileDialog1.FileName)
            Next
        End If
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
        Dim Updata As Boolean = False
        Transform.FlipTrue.Checked = Flip
        Transform.ZoomTrue.Checked = Zoom
        Transform.AntiAliasingTrue.Checked = AntiAliasing
        Transform.FlipFalse.Checked = Not Flip
        Transform.ZoomFalse.Checked = Not Zoom
        Transform.AntiAliasingFalse.Checked = Not AntiAliasing
        Transform.NumericUpDownZoom.Value = ZoomRate * 100
        Transform.ShowDialog()
        If Flip <> Transform.FlipTrue.Checked Then
            Flip = Transform.FlipTrue.Checked
            Updata = True
        End If
        If Zoom <> Transform.ZoomTrue.Checked Then
            Zoom = Transform.ZoomTrue.Checked
            Updata = True
        End If
        If AntiAliasing <> Transform.AntiAliasingTrue.Checked Then
            AntiAliasing = Transform.AntiAliasingTrue.Checked
            Updata = True
        End If
        If ZoomRate <> Transform.NumericUpDownZoom.Value / 100 Then
            ZoomRate = Transform.NumericUpDownZoom.Value / 100
            Updata = True
        End If
        If Updata Then
            Refreshing()
        End If
    End Sub

    Private Sub ButtonShadow_Click(sender As Object, e As EventArgs) Handles ButtonShadow.Click
        Dim ShowDialogResult = Shadow.ShowDialog()
        If ShowDialogResult = DialogResult.Yes Then
            Dim ShadowDialog As Boolean() = {False, False}
            Dim ShadowDialogFile As String() = {"", ""}
            For i = 0 To 1
                OpenFileDialog2.InitialDirectory = GetINI("SelectShadow", "SingleShadowPath" + i.ToString, "", Application.StartupPath + "\SangoTool.ini")
                OpenFileDialog2.FileName = ""
                If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
                    ShadowDialogFile(i) = OpenFileDialog2.FileName
                    ShadowDialog(i) = True
                End If
            Next
            If ShadowDialog(0) = True OrElse ShadowDialog(1) = True Then
                SingleShadow = True
                For i = 0 To 1
                    SingleShadowFile(i) = ShadowDialogFile(i)
                    WriteINI("SelectShadow", "SingleShadowPath" + i.ToString, IO.Path.GetDirectoryName(SingleShadowFile(i)), Application.StartupPath + "\SangoTool.ini")
                Next
                Dim shpfile As String
                If DeathShadow(0) = True Then
                    shpfile = SingleShadowFile(1)
                Else
                    shpfile = SingleShadowFile(0)
                End If
                TempBitmap(TempBitmap.Count - 1).Dispose()
                TempBitmap(TempBitmap.Count - 1) = SHPToBitmap(shpfile)
                PointList(PointList.Count - 1) = GetCenterPoint(shpfile)
                Refreshing()
            End If
        ElseIf ShowDialogResult = DialogResult.No Then
            If ShadowPath = "" Then
                FolderBrowserDialog1.SelectedPath = GetINI("SelectShadow", "ShadowPath", "", Application.StartupPath + "\SangoTool.ini")
            Else
                FolderBrowserDialog1.SelectedPath = ShadowPath
            End If
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                SingleShadow = False
                ShadowPath = FolderBrowserDialog1.SelectedPath
                WriteINI("SelectShadow", "ShadowPath", ShadowPath, Application.StartupPath + "\SangoTool.ini")
                Dim shpfile As String = ShadowPath + SubPath(0) + "\s" + FileList(0)
                Dim shpfile2 As String = ShadowPath + "\shadow" + FileList(0)
                TempBitmap(TempBitmap.Count - 1).Dispose()
                TempBitmap(TempBitmap.Count - 1) = SHPToBitmap(shpfile, shpfile2)
                PointList(PointList.Count - 1) = GetCenterPoint(shpfile, shpfile2)
                Refreshing()
            End If
        ElseIf ShowDialogResult = DialogResult.Retry Then
            If SingleShadow Then
                SingleShadowFile = {"", ""}
                TempBitmap(TempBitmap.Count - 1).Dispose()
                If DeathShadow(0) = True Then
                    TempBitmap(TempBitmap.Count - 1) = SHPToBitmap(SingleShadowFile(1))
                    PointList(PointList.Count - 1) = GetCenterPoint(SingleShadowFile(1))
                Else
                    TempBitmap(TempBitmap.Count - 1) = SHPToBitmap(SingleShadowFile(0))
                    PointList(PointList.Count - 1) = GetCenterPoint(SingleShadowFile(0))
                End If
                Refreshing()
            Else
                ShadowPath = ""
                Dim shpfile As String = ShadowPath + SubPath(0) + "\s" + FileList(0)
                Dim shpfile2 As String = ShadowPath + "\shadow" + FileList(0)
                TempBitmap(TempBitmap.Count - 1).Dispose()
                TempBitmap(TempBitmap.Count - 1) = SHPToBitmap(shpfile, shpfile2)
                PointList(PointList.Count - 1) = GetCenterPoint(shpfile, shpfile2)
            End If
        End If
    End Sub

    Private Sub ButtonOffset_Click(sender As Object, e As EventArgs) Handles ButtonOffset.Click
        Dim OffsetTempList = {{0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0},
                          {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}, {0, 0}}
        Dim Updata As Boolean = False
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
        OffsetTempList(21, 0) = Offset.NumericUpDownDeathX.Value
        OffsetTempList(21, 1) = Offset.NumericUpDownDeathY.Value
        OffsetTempList(20, 0) = Offset.NumericUpDownXALL.Value
        OffsetTempList(20, 1) = Offset.NumericUpDownYALL.Value
        For i = 0 To 1
            OffsetTempList(0 + i, 0) = Offset.NumericUpDownX0.Value
            OffsetTempList(0 + i, 1) = Offset.NumericUpDownY0.Value
            OffsetTempList(2 + i, 0) = Offset.NumericUpDownX1.Value
            OffsetTempList(2 + i, 1) = Offset.NumericUpDownY1.Value
            OffsetTempList(4 + i, 0) = Offset.NumericUpDownX2.Value
            OffsetTempList(4 + i, 1) = Offset.NumericUpDownY2.Value
            OffsetTempList(6 + i, 0) = Offset.NumericUpDownX3.Value
            OffsetTempList(6 + i, 1) = Offset.NumericUpDownY3.Value
            OffsetTempList(8 + i, 0) = Offset.NumericUpDownX4.Value
            OffsetTempList(8 + i, 1) = Offset.NumericUpDownY4.Value
            OffsetTempList(10 + i, 0) = Offset.NumericUpDownX5.Value
            OffsetTempList(10 + i, 1) = Offset.NumericUpDownY5.Value
            OffsetTempList(12 + i, 0) = Offset.NumericUpDownX6.Value
            OffsetTempList(12 + i, 1) = Offset.NumericUpDownY6.Value
            OffsetTempList(14 + i, 0) = Offset.NumericUpDownX7.Value
            OffsetTempList(14 + i, 1) = Offset.NumericUpDownY7.Value
            OffsetTempList(16 + i, 0) = Offset.NumericUpDownX8.Value
            OffsetTempList(16 + i, 1) = Offset.NumericUpDownY8.Value
            OffsetTempList(18 + i, 0) = Offset.NumericUpDownX9.Value
            OffsetTempList(18 + i, 1) = Offset.NumericUpDownY9.Value
        Next
        For i = 0 To 21
            For o = 0 To 1
                If OffsetList(i, o) <> OffsetTempList(i, o) Then
                    OffsetList(i, o) = OffsetTempList(i, o)
                    Updata = True
                End If
            Next
        Next
        If Updata Then
            Refreshing()
        End If
    End Sub

    Public Function SetObjectColor(SelectBodyIndex As Int16) As Boolean
        SetObjectColor = False
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
            If TempColor(SelectBodyIndex).ToArgb <> Color.Transparent.ToArgb Then
                TempColor(SelectBodyIndex) = Color.Transparent
                SetObjectColor = True
            End If
        Else
            If TempColor(SelectBodyIndex) <> ObjectColor.PictureBox1.BackColor Then
                TempColor(SelectBodyIndex) = ObjectColor.PictureBox1.BackColor
                SetObjectColor = True
            End If
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
        If TempChannel(SelectBodyIndex)(0) <> R OrElse TempChannel(SelectBodyIndex)(1) <> G OrElse TempChannel(SelectBodyIndex)(2) <> B Then
            'If TempChannel(SelectBodyIndex) IsNot {R, G, B} Then
            TempChannel(SelectBodyIndex) = {R, G, B}
            Dim shpfile As String = TempPath(SelectBodyIndex) + SubPath(0) + FileList(0)
            Dim shpfile2 As String = TempPath(SelectBodyIndex) + FileList(0)
            TempBitmap(SelectBodyIndex * 2).Dispose()
            TempBitmap(SelectBodyIndex * 2) = SHPToBitmap(shpfile, shpfile2, TempChannel(SelectBodyIndex)(0), TempChannel(SelectBodyIndex)(1), TempChannel(SelectBodyIndex)(2))
            SetObjectColor = True
        End If
    End Function

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

    Public Function SetObjectBitmap(SelectBodyIndex As Int16) As Boolean
        FolderBrowserDialog1.SelectedPath = TempPath(SelectBodyIndex)
        SelectObject.TabControl1.SelectedIndex = SelectTab(SelectBodyIndex)
        SelectObject.ShowDialog()
        SelectTab(SelectBodyIndex) = SelectObject.TabControl1.SelectedIndex
        If TempPath(SelectBodyIndex) <> FolderBrowserDialog1.SelectedPath Then
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
            SetObjectBitmap = True
        Else
            SetObjectBitmap = False
        End If
    End Function

    Private Sub PictureBox0_Click(sender As Object, e As EventArgs) Handles PictureBox0.Click
        Dim SelectBodyIndex As Int16 = 0
        If SetObjectBitmap(SelectBodyIndex) Then
            PictureBox0.Image = TempBitmap(SelectBodyIndex * 2)
            If TempPath(SelectBodyIndex) = "" Then
                PictureBox0.Image = CreateImage("Empty", 80, 40, "#ffffff")
            End If
            Refreshing()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim SelectBodyIndex As Int16 = 1
        If SetObjectBitmap(SelectBodyIndex) Then
            PictureBox1.Image = TempBitmap(SelectBodyIndex * 2)
            If TempPath(SelectBodyIndex) = "" Then
                PictureBox1.Image = CreateImage("Empty", 80, 40, "#ffffff")
            End If
            Refreshing()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim SelectBodyIndex As Int16 = 2
        If SetObjectBitmap(SelectBodyIndex) Then
            PictureBox2.Image = TempBitmap(SelectBodyIndex * 2)
            If TempPath(SelectBodyIndex) = "" Then
                PictureBox2.Image = CreateImage("Empty", 80, 40, "#ffffff")
            End If
            Refreshing()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim SelectBodyIndex As Int16 = 3
        If SetObjectBitmap(SelectBodyIndex) Then
            PictureBox3.Image = TempBitmap(SelectBodyIndex * 2)
            If TempPath(SelectBodyIndex) = "" Then
                PictureBox3.Image = CreateImage("Empty", 80, 40, "#ffffff")
            End If
            Refreshing()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim SelectBodyIndex As Int16 = 4
        If SetObjectBitmap(SelectBodyIndex) Then
            PictureBox4.Image = TempBitmap(SelectBodyIndex * 2)
            If TempPath(SelectBodyIndex) = "" Then
                PictureBox4.Image = CreateImage("Empty", 80, 40, "#ffffff")
            End If
            Refreshing()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim SelectBodyIndex As Int16 = 5
        If SetObjectBitmap(SelectBodyIndex) Then
            PictureBox5.Image = TempBitmap(SelectBodyIndex * 2)
            If TempPath(SelectBodyIndex) = "" Then
                PictureBox5.Image = CreateImage("Empty", 80, 40, "#ffffff")
            End If
            Refreshing()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim SelectBodyIndex As Int16 = 6
        If SetObjectBitmap(SelectBodyIndex) Then
            PictureBox6.Image = TempBitmap(SelectBodyIndex * 2)
            If TempPath(SelectBodyIndex) = "" Then
                PictureBox6.Image = CreateImage("Empty", 80, 40, "#ffffff")
            End If
            Refreshing()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim SelectBodyIndex As Int16 = 7
        If SetObjectBitmap(SelectBodyIndex) Then
            PictureBox7.Image = TempBitmap(SelectBodyIndex * 2)
            If TempPath(SelectBodyIndex) = "" Then
                PictureBox7.Image = CreateImage("Empty", 80, 40, "#ffffff")
            End If
            Refreshing()
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim SelectBodyIndex As Int16 = 8
        If SetObjectBitmap(SelectBodyIndex) Then
            PictureBox8.Image = TempBitmap(SelectBodyIndex * 2)
            If TempPath(SelectBodyIndex) = "" Then
                PictureBox8.Image = CreateImage("Empty", 80, 40, "#ffffff")
            End If
            Refreshing()
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim SelectBodyIndex As Int16 = 9
        If SetObjectBitmap(SelectBodyIndex) Then
            PictureBox9.Image = TempBitmap(SelectBodyIndex * 2)
            If TempPath(SelectBodyIndex) = "" Then
                PictureBox9.Image = CreateImage("Empty", 80, 40, "#ffffff")
            End If
            Refreshing()
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        Dim SelectBodyIndex As Int16 = 0
        If SetObjectColor(SelectBodyIndex) Then
            Button0.BackColor = TempColor(SelectBodyIndex)
            If TempPath(SelectBodyIndex) <> "" Then PictureBox0.Image = TempBitmap(SelectBodyIndex * 2)
            Refreshing()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SelectBodyIndex As Int16 = 1
        If SetObjectColor(SelectBodyIndex) Then
            Button1.BackColor = TempColor(SelectBodyIndex)
            If TempPath(SelectBodyIndex) <> "" Then PictureBox1.Image = TempBitmap(SelectBodyIndex * 2)
            Refreshing()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SelectBodyIndex As Int16 = 2
        If SetObjectColor(SelectBodyIndex) Then
            Button2.BackColor = TempColor(SelectBodyIndex)
            If TempPath(SelectBodyIndex) <> "" Then PictureBox2.Image = TempBitmap(SelectBodyIndex * 2)
            Refreshing()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SelectBodyIndex As Int16 = 3
        If SetObjectColor(SelectBodyIndex) Then
            Button3.BackColor = TempColor(SelectBodyIndex)
            If TempPath(SelectBodyIndex) <> "" Then PictureBox3.Image = TempBitmap(SelectBodyIndex * 2)
            Refreshing()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim SelectBodyIndex As Int16 = 4
        If SetObjectColor(SelectBodyIndex) Then
            Button4.BackColor = TempColor(SelectBodyIndex)
            If TempPath(SelectBodyIndex) <> "" Then PictureBox4.Image = TempBitmap(SelectBodyIndex * 2)
            Refreshing()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim SelectBodyIndex As Int16 = 5
        If SetObjectColor(SelectBodyIndex) Then
            Button5.BackColor = TempColor(SelectBodyIndex)
            If TempPath(SelectBodyIndex) <> "" Then PictureBox5.Image = TempBitmap(SelectBodyIndex * 2)
            Refreshing()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim SelectBodyIndex As Int16 = 6
        If SetObjectColor(SelectBodyIndex) Then
            Button6.BackColor = TempColor(SelectBodyIndex)
            If TempPath(SelectBodyIndex) <> "" Then PictureBox6.Image = TempBitmap(SelectBodyIndex * 2)
            Refreshing()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim SelectBodyIndex As Int16 = 7
        If SetObjectColor(SelectBodyIndex) Then
            Button7.BackColor = TempColor(SelectBodyIndex)
            If TempPath(SelectBodyIndex) <> "" Then PictureBox7.Image = TempBitmap(SelectBodyIndex * 2)
            Refreshing()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim SelectBodyIndex As Int16 = 8
        If SetObjectColor(SelectBodyIndex) Then
            Button8.BackColor = TempColor(SelectBodyIndex)
            If TempPath(SelectBodyIndex) <> "" Then PictureBox8.Image = TempBitmap(SelectBodyIndex * 2)
            Refreshing()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim SelectBodyIndex As Int16 = 9
        If SetObjectColor(SelectBodyIndex) Then
            Button9.BackColor = TempColor(SelectBodyIndex)
            If TempPath(SelectBodyIndex) <> "" Then PictureBox9.Image = TempBitmap(SelectBodyIndex * 2)
            Refreshing()
        End If
    End Sub

    Private Sub GoToFrame(i As Int16)
        Timer1.Enabled = False
        PlayFrame(0) = PlayFrame(0) + i
        If PlayFrame(0) < 0 Then
            PlayFrame(0) = 0
        End If
        If PlayFrame(0) > PlayFrame(1) Then
            PlayFrame(0) = PlayFrame(1)
        End If
        If PlayFrame(0) > PlayLoadFrame Then
            PlayFrame(0) = PlayLoadFrame
        End If
        Playback.Text = PlayFrame(0).ToString + "/" + PlayFrame(1).ToString
        If PlayLoadFrame = 0 Then
            PictureBoxPlay.Image = CreateImage("Loading", 64, 64, "#ffffff")
        Else
            UpDataPicture({PlayPoint(PlayFrame(0))(0), PlayPoint(PlayFrame(0))(1)}, PictureBoxPlay, PlayBitmap(PlayFrame(0)))
        End If
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        GoToFrame(-PlayFrame(1))
    End Sub

    Private Sub LastTo0ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LastTo0ToolStripMenuItem.Click
        GoToFrame(-50)
    End Sub

    Private Sub Last10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Last10ToolStripMenuItem.Click
        GoToFrame(-10)
    End Sub

    Private Sub ToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        GoToFrame(10)
    End Sub

    Private Sub ToolStripMenuItem3_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        GoToFrame(50)
    End Sub

    Private Sub EndToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        GoToFrame(PlayFrame(1))
    End Sub


    '--------------------------------------------------------------------------------------------------------------------
    '                                                 Readme
    '--------------------------------------------------------------------------------------------------------------------

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://tieba.baidu.com/f?ie=utf-8&kw=%E4%B8%89%E5%9B%BD%E7%BE%A4%E8%8B%B1%E4%BC%A0")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start("http://sango.ys168.com")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        System.Diagnostics.Process.Start("mailto://mail@sango.ink")
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        System.Diagnostics.Process.Start("https://shang.qq.com/wpa/qunwpa?idkey=5ba0549bc99074274cd153e3df087e9d870cdfb7d1cb15324cbb62c93a4b88ea")
    End Sub
End Class
