
Public Class SangoTool
    Dim TempColor As Color() = {}
    Dim TempBitmap As Bitmap() = {}
    Dim TempPoint As Object() = {}
    Dim TempPath As Object() = {}
    Dim ShadowPath As String = ""
    Dim SubPath As String() = {""}
    Dim FileList As String() = {""}
    Dim Bitmap As Bitmap = New Bitmap(1, 1)
    Dim Point As Int16() = {0, 0, 1, 1}
    Dim SelectBodyIndex As Int16 = 0
    Dim Play As Boolean = False
    Dim Flip As Boolean = False
    Dim Zoom As Boolean = False
    Dim ZoomRate As Double = 1
    Dim PlayBitmap As Bitmap() = {}
    Dim PlayFrame As Int16() = {0, 0}
    Dim PlayTempBitmap As Bitmap() = {}
    Dim PlayTempPoint As Object() = {}
    Dim PlayPoint As Int16() = {0, 0, 1, 1}
    Dim PlayLoadFrame As Int16 = 0
    Dim PlayTempPath As Object() = {}
    Dim PlayRendering As Boolean = False

    Private Sub Refreshing(PictureBox As PictureBox)
        If Not BackgroundWorker2.IsBusy Then
            BackgroundWorker2.RunWorkerAsync()
        Else
            PlayRendering = True
        End If
        Point = {0, 0, 1, 1}
        For i = 0 To TempPoint.Count - 1
            If TempPoint(i)(2) - TempPoint(i)(0) > Point(2) - Point(0) Then
                Dim increment As Int16 = (TempPoint(i)(2) - TempPoint(i)(0)) - (Point(2) - Point(0))
                Point(2) = Point(2) + increment
            End If
            If TempPoint(i)(3) - TempPoint(i)(1) > Point(3) - Point(1) Then
                Dim increment As Int16 = (TempPoint(i)(3) - TempPoint(i)(1)) - (Point(3) - Point(1))
                Point(3) = Point(3) + increment
            End If
            If TempPoint(i)(0) > Point(0) Then
                Point(2) = Point(2) + (TempPoint(i)(0) - Point(0))
                Point(0) = Point(0) + (TempPoint(i)(0) - Point(0))
            End If
            If TempPoint(i)(1) > Point(1) Then
                Point(3) = Point(3) + (TempPoint(i)(1) - Point(1))
                Point(1) = Point(1) + (TempPoint(i)(1) - Point(1))
            End If
        Next
        Bitmap = New Bitmap(Point(2), Point(3))
        For y = 0 To TempBitmap(TempBitmap.Count - 1).Height - 1
            For x = 0 To TempBitmap(TempBitmap.Count - 1).Width - 1
                Dim Color As Color = TempBitmap(TempBitmap.Count - 1).GetPixel(x, y)
                If Color.A > 0 Then
                    Bitmap.SetPixel(x - TempPoint(TempBitmap.Count - 1)(0) + Point(0), y - TempPoint(TempBitmap.Count - 1)(1) + Point(1), Color.Black)
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
                                Bitmap.SetPixel(x - TempPoint(i)(0) + Point(0), y - TempPoint(i)(1) + Point(1), Color)
                            End If
                        Else
                            Bitmap.SetPixel(x - TempPoint(i)(0) + Point(0), y - TempPoint(i)(1) + Point(1), Color)
                        End If
                    End If
                Next
            Next
        Next
        If Flip Then
            Dim FlipBitmap As Bitmap = New Bitmap(Bitmap.Width, Bitmap.Height)
            For y = 0 To FlipBitmap.Height - 1
                For x = 0 To FlipBitmap.Width - 1
                    FlipBitmap.SetPixel(FlipBitmap.Width - 1 - x, y, Bitmap.GetPixel(x, y))
                Next
            Next
            Bitmap = FlipBitmap
        End If
        If Zoom Then
            Dim ZoomBitmap As Bitmap = New Bitmap(Convert.ToInt16(Bitmap.Width * ZoomRate), Convert.ToInt16(Bitmap.Height * ZoomRate))
            Dim ZH = ZoomBitmap.Height - 1
            Dim ZW = ZoomBitmap.Width - 1
            Dim OH = Bitmap.Height - 1
            Dim OW = Bitmap.Width - 1
            For y = 0 To ZoomBitmap.Height - 1
                For x = 0 To ZoomBitmap.Width - 1
                    ZoomBitmap.SetPixel(x, y, Bitmap.GetPixel(x / ZW * OW, y / ZH * OH))
                Next
            Next
            Bitmap = ZoomBitmap
        End If
        PictureBox.Image = Bitmap
    End Sub

    Private Sub SangoTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim max As Int16 = 10
        ReDim TempColor(max - 1)
        ReDim TempBitmap(max * 2)
        ReDim TempPoint(max * 2)
        ReDim TempPath(max - 1)
        ReDim PlayTempBitmap(max * 2)
        ReDim PlayTempPoint(max * 2)
        ReDim PlayTempPath(max - 1)
        For i = 0 To max * 2
            TempBitmap(i) = New Bitmap(1, 1)
            TempPoint(i) = {0, 0, 1, 1}
            PlayTempBitmap(i) = New Bitmap(1, 1)
            PlayTempPoint(i) = {0, 0, 1, 1}
        Next
        For i = 0 To max - 1
            TempPath(i) = ""
            PlayTempPath(i) = ""
            TempColor(i) = Color.Transparent
        Next
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        PlayLoadFrame = 0
        For p = 0 To PlayBitmap.Count - 1
            For i = 0 To 10 - 1
                PlayTempPath(i) = TempPath(i)
                Dim shpfile As String = PlayTempPath(i) + SubPath(p) + FileList(p)
                Dim shpfile2 As String = PlayTempPath(i) + FileList(p)
                Dim covfile As String = PlayTempPath(i) + SubPath(p) + "\_cov" + FileList(p)
                Dim covfile2 As String = PlayTempPath(i) + "\cover" + FileList(p)
                PlayTempBitmap(i * 2) = SHPToBitmap(shpfile, shpfile2)
                PlayTempPoint(i * 2) = GetCenterPoint(shpfile, shpfile2)
                PlayTempBitmap(i * 2 + 1) = SHPToBitmap(covfile, covfile2)
                PlayTempPoint(i * 2 + 1) = GetCenterPoint(covfile, covfile2)
            Next
            'PlayPoint = {0, 0, 1, 1}
            PlayPoint = {300, 300, 600, 400}
            For i = 0 To PlayTempPoint.Count - 1
                If PlayTempPoint(i)(2) - PlayTempPoint(i)(0) > PlayPoint(2) - PlayPoint(0) Then
                    Dim increment As Int16 = (PlayTempPoint(i)(2) - PlayTempPoint(i)(0)) - (PlayPoint(2) - PlayPoint(0))
                    PlayPoint(2) = PlayPoint(2) + increment
                End If
                If PlayTempPoint(i)(3) - PlayTempPoint(i)(1) > PlayPoint(3) - PlayPoint(1) Then
                    Dim increment As Int16 = (PlayTempPoint(i)(3) - PlayTempPoint(i)(1)) - (PlayPoint(3) - PlayPoint(1))
                    PlayPoint(3) = PlayPoint(3) + increment
                End If
                If PlayTempPoint(i)(0) > PlayPoint(0) Then
                    PlayPoint(2) = PlayPoint(2) + (PlayTempPoint(i)(0) - PlayPoint(0))
                    PlayPoint(0) = PlayPoint(0) + (PlayTempPoint(i)(0) - PlayPoint(0))
                End If
                If PlayTempPoint(i)(1) > PlayPoint(1) Then
                    PlayPoint(3) = PlayPoint(3) + (PlayTempPoint(i)(1) - PlayPoint(1))
                    PlayPoint(1) = PlayPoint(1) + (PlayTempPoint(i)(1) - PlayPoint(1))
                End If
            Next
            PlayBitmap(p) = New Bitmap(PlayPoint(2), PlayPoint(3))
            For y = 0 To PlayTempBitmap(PlayTempBitmap.Count - 1).Height - 1
                For x = 0 To PlayTempBitmap(PlayTempBitmap.Count - 1).Width - 1
                    Dim Color As Color = PlayTempBitmap(PlayTempBitmap.Count - 1).GetPixel(x, y)
                    If Color.A > 0 Then
                        PlayBitmap(p).SetPixel(x - TempPoint(PlayTempBitmap.Count - 1)(0) + PlayPoint(0), y - PlayTempPoint(PlayTempBitmap.Count - 1)(1) + PlayPoint(1), Color.Black)
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
                                    PlayBitmap(p).SetPixel(x - PlayTempPoint(i)(0) + PlayPoint(0), y - PlayTempPoint(i)(1) + PlayPoint(1), Color)
                                End If
                            Else
                                PlayBitmap(p).SetPixel(x - PlayTempPoint(i)(0) + PlayPoint(0), y - PlayTempPoint(i)(1) + PlayPoint(1), Color)
                            End If
                        End If
                    Next
                Next
            Next
            PlayLoadFrame = p
        Next
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PlayFrame(1) = 0 Then Exit Sub
        If Not BackgroundWorker2.IsBusy Then
            If PlayRendering = True Then
                PlayRendering = False
                BackgroundWorker2.RunWorkerAsync()
            End If
        End If
        If PlayFrame(0) > PlayFrame(1) Then
            PlayFrame(0) = 0
        End If
        If PlayFrame(0) > PlayLoadFrame Then
            PlayFrame(0) = 0 'PlayLoadFrame
        End If
        If BackgroundWorker2.IsBusy Then
            ProgressBar1.Value = PlayLoadFrame
        ElseIf ProgressBar1.Value <> ProgressBar1.Maximum Then
            ProgressBar1.Value = ProgressBar1.Maximum
        End If
        Label1.Text = PlayFrame(0).ToString + "/" + PlayFrame(1).ToString
        If PlayLoadFrame = 0 Then
            PictureBoxPlay.Image = CreateImage("Loading", 64, 64, "#ffffff")
        Else
            PictureBoxPlay.Image = PlayBitmap(PlayFrame(0))
            PlayFrame(0) = PlayFrame(0) + 1
        End If
    End Sub

    Private Sub PictureBox0_Click(sender As Object, e As EventArgs) Handles PictureBox0.Click
        SelectBodyIndex = 0
        FolderBrowserDialog1.SelectedPath = TempPath(SelectBodyIndex)
        SelectObject.ShowDialog()
        TempPath(SelectBodyIndex) = FolderBrowserDialog1.SelectedPath
        Dim shpfile As String = TempPath(SelectBodyIndex) + SubPath(0) + FileList(0)
        Dim shpfile2 As String = TempPath(SelectBodyIndex) + FileList(0)
        Dim covfile As String = TempPath(SelectBodyIndex) + SubPath(0) + "\_cov" + FileList(0)
        Dim covfile2 As String = TempPath(SelectBodyIndex) + "\cover" + FileList(0)
        TempBitmap(SelectBodyIndex * 2) = SHPToBitmap(shpfile, shpfile2)
        TempPoint(SelectBodyIndex * 2) = GetCenterPoint(shpfile, shpfile2)
        TempBitmap(SelectBodyIndex * 2 + 1) = SHPToBitmap(covfile, covfile2)
        TempPoint(SelectBodyIndex * 2 + 1) = GetCenterPoint(covfile, covfile2)
        PictureBox0.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SelectBodyIndex = 1
        FolderBrowserDialog1.SelectedPath = TempPath(SelectBodyIndex)
        SelectObject.ShowDialog()
        TempPath(SelectBodyIndex) = FolderBrowserDialog1.SelectedPath
        Dim shpfile As String = TempPath(SelectBodyIndex) + SubPath(0) + FileList(0)
        Dim shpfile2 As String = TempPath(SelectBodyIndex) + FileList(0)
        Dim covfile As String = TempPath(SelectBodyIndex) + SubPath(0) + "\_cov" + FileList(0)
        Dim covfile2 As String = TempPath(SelectBodyIndex) + "\cover" + FileList(0)
        TempBitmap(SelectBodyIndex * 2) = SHPToBitmap(shpfile, shpfile2)
        TempPoint(SelectBodyIndex * 2) = GetCenterPoint(shpfile, shpfile2)
        TempBitmap(SelectBodyIndex * 2 + 1) = SHPToBitmap(covfile, covfile2)
        TempPoint(SelectBodyIndex * 2 + 1) = GetCenterPoint(covfile, covfile2)
        PictureBox1.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SelectBodyIndex = 2
        FolderBrowserDialog1.SelectedPath = TempPath(SelectBodyIndex)
        SelectObject.ShowDialog()
        TempPath(SelectBodyIndex) = FolderBrowserDialog1.SelectedPath
        Dim shpfile As String = TempPath(SelectBodyIndex) + SubPath(0) + FileList(0)
        Dim shpfile2 As String = TempPath(SelectBodyIndex) + FileList(0)
        Dim covfile As String = TempPath(SelectBodyIndex) + SubPath(0) + "\_cov" + FileList(0)
        Dim covfile2 As String = TempPath(SelectBodyIndex) + "\cover" + FileList(0)
        TempBitmap(SelectBodyIndex * 2) = SHPToBitmap(shpfile, shpfile2)
        TempPoint(SelectBodyIndex * 2) = GetCenterPoint(shpfile, shpfile2)
        TempBitmap(SelectBodyIndex * 2 + 1) = SHPToBitmap(covfile, covfile2)
        TempPoint(SelectBodyIndex * 2 + 1) = GetCenterPoint(covfile, covfile2)
        PictureBox2.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        SelectBodyIndex = 3
        FolderBrowserDialog1.SelectedPath = TempPath(SelectBodyIndex)
        SelectObject.ShowDialog()
        TempPath(SelectBodyIndex) = FolderBrowserDialog1.SelectedPath
        Dim shpfile As String = TempPath(SelectBodyIndex) + SubPath(0) + FileList(0)
        Dim shpfile2 As String = TempPath(SelectBodyIndex) + FileList(0)
        Dim covfile As String = TempPath(SelectBodyIndex) + SubPath(0) + "\_cov" + FileList(0)
        Dim covfile2 As String = TempPath(SelectBodyIndex) + "\cover" + FileList(0)
        TempBitmap(SelectBodyIndex * 2) = SHPToBitmap(shpfile, shpfile2)
        TempPoint(SelectBodyIndex * 2) = GetCenterPoint(shpfile, shpfile2)
        TempBitmap(SelectBodyIndex * 2 + 1) = SHPToBitmap(covfile, covfile2)
        TempPoint(SelectBodyIndex * 2 + 1) = GetCenterPoint(covfile, covfile2)
        PictureBox3.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        SelectBodyIndex = 4
        FolderBrowserDialog1.SelectedPath = TempPath(SelectBodyIndex)
        SelectObject.ShowDialog()
        TempPath(SelectBodyIndex) = FolderBrowserDialog1.SelectedPath
        Dim shpfile As String = TempPath(SelectBodyIndex) + SubPath(0) + FileList(0)
        Dim shpfile2 As String = TempPath(SelectBodyIndex) + FileList(0)
        Dim covfile As String = TempPath(SelectBodyIndex) + SubPath(0) + "\_cov" + FileList(0)
        Dim covfile2 As String = TempPath(SelectBodyIndex) + "\cover" + FileList(0)
        TempBitmap(SelectBodyIndex * 2) = SHPToBitmap(shpfile, shpfile2)
        TempPoint(SelectBodyIndex * 2) = GetCenterPoint(shpfile, shpfile2)
        TempBitmap(SelectBodyIndex * 2 + 1) = SHPToBitmap(covfile, covfile2)
        TempPoint(SelectBodyIndex * 2 + 1) = GetCenterPoint(covfile, covfile2)
        PictureBox4.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        SelectBodyIndex = 5
        FolderBrowserDialog1.SelectedPath = TempPath(SelectBodyIndex)
        SelectObject.ShowDialog()
        TempPath(SelectBodyIndex) = FolderBrowserDialog1.SelectedPath
        Dim shpfile As String = TempPath(SelectBodyIndex) + SubPath(0) + FileList(0)
        Dim shpfile2 As String = TempPath(SelectBodyIndex) + FileList(0)
        Dim covfile As String = TempPath(SelectBodyIndex) + SubPath(0) + "\_cov" + FileList(0)
        Dim covfile2 As String = TempPath(SelectBodyIndex) + "\cover" + FileList(0)
        TempBitmap(SelectBodyIndex * 2) = SHPToBitmap(shpfile, shpfile2)
        TempPoint(SelectBodyIndex * 2) = GetCenterPoint(shpfile, shpfile2)
        TempBitmap(SelectBodyIndex * 2 + 1) = SHPToBitmap(covfile, covfile2)
        TempPoint(SelectBodyIndex * 2 + 1) = GetCenterPoint(covfile, covfile2)
        PictureBox5.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        SelectBodyIndex = 6
        FolderBrowserDialog1.SelectedPath = TempPath(SelectBodyIndex)
        SelectObject.ShowDialog()
        TempPath(SelectBodyIndex) = FolderBrowserDialog1.SelectedPath
        Dim shpfile As String = TempPath(SelectBodyIndex) + SubPath(0) + FileList(0)
        Dim shpfile2 As String = TempPath(SelectBodyIndex) + FileList(0)
        Dim covfile As String = TempPath(SelectBodyIndex) + SubPath(0) + "\_cov" + FileList(0)
        Dim covfile2 As String = TempPath(SelectBodyIndex) + "\cover" + FileList(0)
        TempBitmap(SelectBodyIndex * 2) = SHPToBitmap(shpfile, shpfile2)
        TempPoint(SelectBodyIndex * 2) = GetCenterPoint(shpfile, shpfile2)
        TempBitmap(SelectBodyIndex * 2 + 1) = SHPToBitmap(covfile, covfile2)
        TempPoint(SelectBodyIndex * 2 + 1) = GetCenterPoint(covfile, covfile2)
        PictureBox6.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        SelectBodyIndex = 7
        FolderBrowserDialog1.SelectedPath = TempPath(SelectBodyIndex)
        SelectObject.ShowDialog()
        TempPath(SelectBodyIndex) = FolderBrowserDialog1.SelectedPath
        Dim shpfile As String = TempPath(SelectBodyIndex) + SubPath(0) + FileList(0)
        Dim shpfile2 As String = TempPath(SelectBodyIndex) + FileList(0)
        Dim covfile As String = TempPath(SelectBodyIndex) + SubPath(0) + "\_cov" + FileList(0)
        Dim covfile2 As String = TempPath(SelectBodyIndex) + "\cover" + FileList(0)
        TempBitmap(SelectBodyIndex * 2) = SHPToBitmap(shpfile, shpfile2)
        TempPoint(SelectBodyIndex * 2) = GetCenterPoint(shpfile, shpfile2)
        TempBitmap(SelectBodyIndex * 2 + 1) = SHPToBitmap(covfile, covfile2)
        TempPoint(SelectBodyIndex * 2 + 1) = GetCenterPoint(covfile, covfile2)
        PictureBox7.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        SelectBodyIndex = 8
        FolderBrowserDialog1.SelectedPath = TempPath(SelectBodyIndex)
        SelectObject.ShowDialog()
        TempPath(SelectBodyIndex) = FolderBrowserDialog1.SelectedPath
        Dim shpfile As String = TempPath(SelectBodyIndex) + SubPath(0) + FileList(0)
        Dim shpfile2 As String = TempPath(SelectBodyIndex) + FileList(0)
        Dim covfile As String = TempPath(SelectBodyIndex) + SubPath(0) + "\_cov" + FileList(0)
        Dim covfile2 As String = TempPath(SelectBodyIndex) + "\cover" + FileList(0)
        TempBitmap(SelectBodyIndex * 2) = SHPToBitmap(shpfile, shpfile2)
        TempPoint(SelectBodyIndex * 2) = GetCenterPoint(shpfile, shpfile2)
        TempBitmap(SelectBodyIndex * 2 + 1) = SHPToBitmap(covfile, covfile2)
        TempPoint(SelectBodyIndex * 2 + 1) = GetCenterPoint(covfile, covfile2)
        PictureBox8.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        SelectBodyIndex = 9
        FolderBrowserDialog1.SelectedPath = TempPath(SelectBodyIndex)
        SelectObject.ShowDialog()
        TempPath(SelectBodyIndex) = FolderBrowserDialog1.SelectedPath
        Dim shpfile As String = TempPath(SelectBodyIndex) + SubPath(0) + FileList(0)
        Dim shpfile2 As String = TempPath(SelectBodyIndex) + FileList(0)
        Dim covfile As String = TempPath(SelectBodyIndex) + SubPath(0) + "\_cov" + FileList(0)
        Dim covfile2 As String = TempPath(SelectBodyIndex) + "\cover" + FileList(0)
        TempBitmap(SelectBodyIndex * 2) = SHPToBitmap(shpfile, shpfile2)
        TempPoint(SelectBodyIndex * 2) = GetCenterPoint(shpfile, shpfile2)
        TempBitmap(SelectBodyIndex * 2 + 1) = SHPToBitmap(covfile, covfile2)
        TempPoint(SelectBodyIndex * 2 + 1) = GetCenterPoint(covfile, covfile2)
        PictureBox9.Image = TempBitmap(SelectBodyIndex * 2)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        SelectBodyIndex = 0
        ColorDialog1.ShowDialog()
        TempColor(SelectBodyIndex) = ColorDialog1.Color
        Button0.BackColor = TempColor(SelectBodyIndex)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SelectBodyIndex = 1
        ColorDialog1.ShowDialog()
        TempColor(SelectBodyIndex) = ColorDialog1.Color
        Button1.BackColor = TempColor(SelectBodyIndex)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SelectBodyIndex = 2
        ColorDialog1.ShowDialog()
        TempColor(SelectBodyIndex) = ColorDialog1.Color
        Button2.BackColor = TempColor(SelectBodyIndex)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SelectBodyIndex = 3
        ColorDialog1.ShowDialog()
        TempColor(SelectBodyIndex) = ColorDialog1.Color
        Button3.BackColor = TempColor(SelectBodyIndex)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SelectBodyIndex = 4
        ColorDialog1.ShowDialog()
        TempColor(SelectBodyIndex) = ColorDialog1.Color
        Button4.BackColor = TempColor(SelectBodyIndex)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SelectBodyIndex = 5
        ColorDialog1.ShowDialog()
        TempColor(SelectBodyIndex) = ColorDialog1.Color
        Button5.BackColor = TempColor(SelectBodyIndex)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SelectBodyIndex = 6
        ColorDialog1.ShowDialog()
        TempColor(SelectBodyIndex) = ColorDialog1.Color
        Button6.BackColor = TempColor(SelectBodyIndex)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SelectBodyIndex = 7
        ColorDialog1.ShowDialog()
        TempColor(SelectBodyIndex) = ColorDialog1.Color
        Button7.BackColor = TempColor(SelectBodyIndex)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SelectBodyIndex = 8
        ColorDialog1.ShowDialog()
        TempColor(SelectBodyIndex) = ColorDialog1.Color
        Button8.BackColor = TempColor(SelectBodyIndex)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        SelectBodyIndex = 9
        ColorDialog1.ShowDialog()
        TempColor(SelectBodyIndex) = ColorDialog1.Color
        Button9.BackColor = TempColor(SelectBodyIndex)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        FolderBrowserDialog1.SelectedPath = "H:\三国群英传ol_全集\GenNude\F"
        FileList = GetFileList(FolderBrowserDialog1.SelectedPath)
        SubPath = GetSubPath(FolderBrowserDialog1.SelectedPath)

        ReDim PlayBitmap(FileList.Count - 1)
        For i = 0 To PlayBitmap.Count - 1
            PlayBitmap(i) = CreateImage(i, 32, 32)
        Next
        PlayFrame(1) = PlayBitmap.Count - 1
        ProgressBar1.Maximum = PlayBitmap.Count - 1
        TableLayoutPanelMian.Visible = True
    End Sub

    Private Sub ButtonNRead_Click(sender As Object, e As EventArgs) Handles ButtonNRead.Click

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

    End Sub

    Private Sub ButtonPlay_Click(sender As Object, e As EventArgs) Handles ButtonPlay.Click
        Timer1.Enabled = Not Timer1.Enabled
        If Timer1.Enabled Then
            TableLayoutPanelPlay.Visible = True
        Else
            TableLayoutPanelPlay.Visible = False
        End If
    End Sub

    Private Sub ButtonFlip_Click(sender As Object, e As EventArgs) Handles ButtonFlip.Click
        Flip = Not Flip
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub ButtonZoom_Click(sender As Object, e As EventArgs) Handles ButtonZoom.Click
        Zoom = Not Zoom
        Dim Rand = New Random
        ZoomRate = Rand.Next(1, 200) / 100
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub ButtonShadow_Click(sender As Object, e As EventArgs) Handles ButtonShadow.Click
        FolderBrowserDialog1.ShowDialog()
        ShadowPath = FolderBrowserDialog1.SelectedPath
        Dim shpfile As String = ShadowPath + SubPath(0) + "\s" + FileList(0)
        Dim shpfile2 As String = ShadowPath + "\shadow" + FileList(0)
        TempBitmap(20) = SHPToBitmap(shpfile, shpfile2)
        TempPoint(20) = GetCenterPoint(shpfile, shpfile2)
        Refreshing(PictureBoxMian)
    End Sub

    Private Sub ToolStripMenuItem0_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem0.Click
        TempColor(0) = Color.Transparent
        Button0.BackColor = TempColor(0)
        Refreshing(PictureBoxMian)
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        TempColor(1) = Color.Transparent
        Button1.BackColor = TempColor(1)
        Refreshing(PictureBoxMian)
    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        TempColor(2) = Color.Transparent
        Button2.BackColor = TempColor(2)
        Refreshing(PictureBoxMian)
    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        TempColor(3) = Color.Transparent
        Button3.BackColor = TempColor(3)
        Refreshing(PictureBoxMian)
    End Sub
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        TempColor(4) = Color.Transparent
        Button4.BackColor = TempColor(4)
        Refreshing(PictureBoxMian)
    End Sub
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        TempColor(5) = Color.Transparent
        Button5.BackColor = TempColor(5)
        Refreshing(PictureBoxMian)
    End Sub
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        TempColor(6) = Color.Transparent
        Button6.BackColor = TempColor(6)
        Refreshing(PictureBoxMian)
    End Sub
    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        TempColor(7) = Color.Transparent
        Button7.BackColor = TempColor(7)
        Refreshing(PictureBoxMian)
    End Sub
    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        TempColor(8) = Color.Transparent
        Button8.BackColor = TempColor(8)
        Refreshing(PictureBoxMian)
    End Sub
    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        TempColor(9) = Color.Transparent
        Button9.BackColor = TempColor(9)
        Refreshing(PictureBoxMian)
    End Sub
End Class
