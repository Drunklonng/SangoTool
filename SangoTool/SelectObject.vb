Public Class SelectObject
    Dim PathList As String() = {"", "", "", "", "", "", "", "", "", ""}
    Dim SelectPath As String() = {"", "", "", "", "", "", "", "", "", ""}
    Dim Path0 As String() = {}
    Dim Path1 As String() = {}
    Dim Path2 As String() = {}
    Dim Path3 As String() = {}
    Dim Path4 As String() = {}
    Dim Path5 As String() = {}
    Dim Path6 As String() = {}
    Dim Path7 As String() = {}
    Dim Path8 As String() = {}
    Dim Path9 As String() = {}
    Dim Loading As Bitmap = CreateImage("Loading", 96, 96)
    Dim Null As Bitmap = New Bitmap(1, 1)
    Dim Config As String = Application.StartupPath + "\SangoTool.ini"

    Public Function GetFileName(Path As String) As String()
        Dim SubPath As String
        Dim SubFile As String = ""
        If IO.Directory.GetDirectories(Path).Count > 0 Then
            SubPath = IO.Directory.GetDirectories(Path)(0)
            If IO.Directory.GetFiles(SubPath, "*.shp").Count > 0 Then
                SubFile = IO.Directory.GetFiles(SubPath, "*.shp")(0)
            End If
        End If
        Dim File As String = ""
        If IO.Directory.GetFiles(Path, "*.shp").Count > 0 Then
            File = IO.Directory.GetFiles(Path, "*.shp")(0)
        End If
        Dim FileName As String() = {File, SubFile}
        GetFileName = FileName
    End Function

    Private Sub SelectBody_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ListView0.Items.Count = 0 Then
            ListView0.Items.Add("NULL")
            ImageList0.Images.Add("NULL", CreateImage("NULL", 96, 96))
            ListView0.Items.Item(0).ImageIndex = 0
            PictureBox0.Image = Null
        End If
        If ListView1.Items.Count = 0 Then
            ListView1.Items.Add("NULL")
            ImageList1.Images.Add("NULL", CreateImage("NULL", 96, 96))
            ListView1.Items.Item(0).ImageIndex = 0
            PictureBox1.Image = Null
        End If
        If ListView2.Items.Count = 0 Then
            ListView2.Items.Add("NULL")
            ImageList2.Images.Add("NULL", CreateImage("NULL", 96, 96))
            ListView2.Items.Item(0).ImageIndex = 0
            PictureBox2.Image = Null
        End If
        If ListView3.Items.Count = 0 Then
            ListView3.Items.Add("NULL")
            ImageList3.Images.Add("NULL", CreateImage("NULL", 96, 96))
            ListView3.Items.Item(0).ImageIndex = 0
            PictureBox3.Image = Null
        End If
        If ListView4.Items.Count = 0 Then
            ListView4.Items.Add("NULL")
            ImageList4.Images.Add("NULL", CreateImage("NULL", 96, 96))
            ListView4.Items.Item(0).ImageIndex = 0
            PictureBox4.Image = Null
        End If
        If ListView5.Items.Count = 0 Then
            ListView5.Items.Add("NULL")
            ImageList5.Images.Add("NULL", CreateImage("NULL", 96, 96))
            ListView5.Items.Item(0).ImageIndex = 0
            PictureBox5.Image = Null
        End If
        If ListView6.Items.Count = 0 Then
            ListView6.Items.Add("NULL")
            ImageList6.Images.Add("NULL", CreateImage("NULL", 96, 96))
            ListView6.Items.Item(0).ImageIndex = 0
            PictureBox6.Image = Null
        End If
        If ListView7.Items.Count = 0 Then
            ListView7.Items.Add("NULL")
            ImageList7.Images.Add("NULL", CreateImage("NULL", 96, 96))
            ListView7.Items.Item(0).ImageIndex = 0
            PictureBox7.Image = Null
        End If
        If ListView8.Items.Count = 0 Then
            ListView8.Items.Add("NULL")
            ImageList8.Images.Add("NULL", CreateImage("NULL", 96, 96))
            ListView8.Items.Item(0).ImageIndex = 0
            PictureBox8.Image = Null
        End If
        If ListView9.Items.Count = 0 Then
            ListView9.Items.Add("NULL")
            ImageList9.Images.Add("NULL", CreateImage("NULL", 96, 96))
            ListView9.Items.Item(0).ImageIndex = 0
            PictureBox9.Image = Null
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------
    '                                    Directory 0
    '-----------------------------------------------------------------------------------------------

    Private Sub BackgroundWorker0_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker0.DoWork
        Dim Index = 0
        For i = 0 To Path0.Count - 1
            ImageList0.Images(i + 1) = New Bitmap(ImageList0.ImageSize.Width, ImageList0.ImageSize.Height)
            ImageList0.Images(i + 1) = SHPToBitmap(GetFileName(PathList(Index) + Path0(i))(0), GetFileName(PathList(Index) + Path0(i))(1))
        Next
    End Sub

    Private Sub ListView0_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView0.SelectedIndexChanged
        Dim Index = 0
        Dim SelectedIndices = ListView0.SelectedIndices()
        If SelectedIndices.Count > 0 Then
            If SelectedIndices(0) = 0 Then
                PictureBox0.Image = Null
                SelectPath(Index) = ""
            Else
                Try
                    PictureBox0.Image = SHPToBitmap(GetFileName(PathList(Index) + Path0(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path0(SelectedIndices(0) - 1))(1))
                Catch
                    PictureBox0.Image = CreateImage("IsBusy", 96, 96, "#ffffff")
                End Try
                'PictureBox0.Image = SHPToBitmap(GetFileName(PathList(Index) + Path0(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path0(SelectedIndices(0) - 1))(1))
                SelectPath(Index) = Path0(SelectedIndices(0) - 1)
            End If
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If BackgroundWorker0.IsBusy Then Exit Sub
        Dim Index As Int16 = 0
        FolderBrowserDialog1.SelectedPath = GetINI("SelectObject", "Path" + Index.ToString, "", Config)
        FolderBrowserDialog1.ShowDialog()
        PathList(Index) = FolderBrowserDialog1.SelectedPath
        WriteINI("SelectObject", "Path" + Index.ToString, PathList(Index), Config)
        Dim TempPath = IO.Directory.GetDirectories(PathList(Index))
        Path0 = {}
        ListView0.Items.Clear()
        ImageList0.Images.Clear()
        ListView0.Items.Add("NULL")
        ImageList0.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView0.Items.Item(0).ImageIndex = 0
        PictureBox0.Image = Null
        SelectPath(Index) = ""
        For i = 0 To TempPath.Count - 1
            Dim str As String = ""
            Dim a = 0
            Do
                a = a + 1
                str = TempPath(i)(TempPath(i).Length - a) + str
            Loop Until TempPath(i)(TempPath(i).Length - a) = "\"
            If IO.Directory.Exists(TempPath(i) + "\F") Or IO.Directory.Exists(TempPath(i) + "\M") Then
                If IO.Directory.Exists(TempPath(i) + "\F") Then
                    ReDim Preserve Path0(Path0.Count)
                    Path0(Path0.Count - 1) = str + "\F"
                End If
                If IO.Directory.Exists(TempPath(i) + "\M") Then
                    ReDim Preserve Path0(Path0.Count)
                    Path0(Path0.Count - 1) = str + "\M"
                End If
            Else
                ReDim Preserve Path0(Path0.Count)
                Path0(Path0.Count - 1) = str
            End If
        Next
        For i = 0 To Path0.Count - 1
            ListView0.Items.Add(Path0(i))
            ImageList0.Images.Add(Path0(i), Loading)
            ListView0.Items.Item(i + 1).ImageIndex = i + 1
        Next
        BackgroundWorker0.RunWorkerAsync()
    End Sub

    Private Sub Button0_clear_Click(sender As Object, e As EventArgs) Handles Button0_clear.Click
        If BackgroundWorker0.IsBusy Then Exit Sub
        Dim Index = 0
        ListView0.Clear()
        ImageList0.Images.Clear()
        ListView0.Items.Add("NULL")
        ImageList0.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView0.Items.Item(0).ImageIndex = 0
        PictureBox0.Image = Null
        SelectPath(Index) = ""
    End Sub

    Private Sub Button0_ok_Click(sender As Object, e As EventArgs) Handles Button0_ok.Click
        Dim Index = 0
        If SelectPath(Index) = "" Then
            SangoTool.FolderBrowserDialog1.SelectedPath = ""
        Else
            SangoTool.FolderBrowserDialog1.SelectedPath = PathList(Index) + SelectPath(Index)
        End If
        Me.Close()
    End Sub

    '-----------------------------------------------------------------------------------------------
    '                                    Directory 1
    '-----------------------------------------------------------------------------------------------

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim Index = 1
        For i = 0 To Path1.Count - 1
            ImageList1.Images(i + 1) = New Bitmap(ImageList1.ImageSize.Width, ImageList1.ImageSize.Height)
            'ImageList1.Images(i + 1) = SHPToBitmap(GetFileName(PathList(Index) + Path1(0))(0), GetFileName(PathList(Index) + Path1(0))(1))
            ImageList1.Images(i + 1) = SHPToBitmap(GetFileName(PathList(Index) + Path1(i))(0), GetFileName(PathList(Index) + Path1(i))(1))
        Next
    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim Index = 1
        Dim SelectedIndices = ListView1.SelectedIndices()
        If SelectedIndices.Count > 0 Then
            If SelectedIndices(0) = 0 Then
                PictureBox1.Image = Null
                SelectPath(Index) = ""
            Else
                Try
                    PictureBox1.Image = SHPToBitmap(GetFileName(PathList(Index) + Path1(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path1(SelectedIndices(0) - 1))(1))
                Catch
                    PictureBox1.Image = CreateImage("IsBusy", 96, 96, "#ffffff")
                End Try
                SelectPath(Index) = Path1(SelectedIndices(0) - 1)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If BackgroundWorker1.IsBusy Then Exit Sub
        Dim Index As Int16 = 1
        FolderBrowserDialog1.SelectedPath = GetINI("SelectObject", "Path" + Index.ToString, "", Config)
        FolderBrowserDialog1.ShowDialog()
        PathList(Index) = FolderBrowserDialog1.SelectedPath
        WriteINI("SelectObject", "Path" + Index.ToString, PathList(Index), Config)
        Dim TempPath = IO.Directory.GetDirectories(PathList(Index))
        Path1 = {}
        ListView1.Items.Clear()
        ImageList1.Images.Clear()
        ListView1.Items.Add("NULL")
        ImageList1.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView1.Items.Item(0).ImageIndex = 0
        PictureBox1.Image = Null
        SelectPath(Index) = ""
        For i = 0 To TempPath.Count - 1
            Dim str As String = ""
            Dim a = 0
            Do
                a = a + 1
                str = TempPath(i)(TempPath(i).Length - a) + str
            Loop Until TempPath(i)(TempPath(i).Length - a) = "\"
            If IO.Directory.Exists(TempPath(i) + "\F") Or IO.Directory.Exists(TempPath(i) + "\M") Then
                If IO.Directory.Exists(TempPath(i) + "\F") Then
                    ReDim Preserve Path1(Path1.Count)
                    Path1(Path1.Count - 1) = str + "\F"
                End If
                If IO.Directory.Exists(TempPath(i) + "\M") Then
                    ReDim Preserve Path1(Path1.Count)
                    Path1(Path1.Count - 1) = str + "\M"
                End If
            Else
                ReDim Preserve Path1(Path1.Count)
                Path1(Path1.Count - 1) = str
            End If
        Next
        For i = 0 To Path1.Count - 1
            ListView1.Items.Add(Path1(i))
            ImageList1.Images.Add(Path1(i), Loading)
            ListView1.Items.Item(i + 1).ImageIndex = i + 1
        Next
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub Button1_clear_Click(sender As Object, e As EventArgs) Handles Button1_clear.Click
        If BackgroundWorker1.IsBusy Then Exit Sub
        Dim Index = 1
        ListView1.Clear()
        ImageList1.Images.Clear()
        ListView1.Items.Add("NULL")
        ImageList1.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView1.Items.Item(0).ImageIndex = 0
        PictureBox1.Image = Null
        SelectPath(Index) = ""
    End Sub

    Private Sub Button1_ok_Click(sender As Object, e As EventArgs) Handles Button1_ok.Click
        Dim Index = 1
        If SelectPath(Index) = "" Then
            SangoTool.FolderBrowserDialog1.SelectedPath = ""
        Else
            SangoTool.FolderBrowserDialog1.SelectedPath = PathList(Index) + SelectPath(Index)
        End If
        Me.Close()
    End Sub

    '-----------------------------------------------------------------------------------------------
    '                                    Directory 2
    '-----------------------------------------------------------------------------------------------

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Dim Index = 2
        For i = 0 To Path2.Count - 1
            ImageList2.Images(i + 1) = New Bitmap(ImageList2.ImageSize.Width, ImageList2.ImageSize.Height)
            ImageList2.Images(i + 1) = SHPToBitmap(GetFileName(PathList(Index) + Path2(i))(0), GetFileName(PathList(Index) + Path2(i))(1))
        Next
    End Sub

    Private Sub ListView2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        Dim Index = 2
        Dim SelectedIndices = ListView2.SelectedIndices()
        If SelectedIndices.Count > 0 Then
            If SelectedIndices(0) = 0 Then
                PictureBox2.Image = Null
                SelectPath(Index) = ""
            Else
                Try
                    PictureBox2.Image = SHPToBitmap(GetFileName(PathList(Index) + Path2(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path2(SelectedIndices(0) - 1))(1))
                Catch
                    PictureBox2.Image = CreateImage("IsBusy", 96, 96, "#ffffff")
                End Try
                'PictureBox2.Image = SHPToBitmap(GetFileName(PathList(Index) + Path2(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path2(SelectedIndices(0) - 1))(1))
                SelectPath(Index) = Path2(SelectedIndices(0) - 1)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If BackgroundWorker2.IsBusy Then Exit Sub
        Dim Index As Int16 = 2
        FolderBrowserDialog1.SelectedPath = GetINI("SelectObject", "Path" + Index.ToString, "", Config)
        FolderBrowserDialog1.ShowDialog()
        PathList(Index) = FolderBrowserDialog1.SelectedPath
        WriteINI("SelectObject", "Path" + Index.ToString, PathList(Index), Config)
        Dim TempPath = IO.Directory.GetDirectories(PathList(Index))
        Path2 = {}
        ListView2.Items.Clear()
        ImageList2.Images.Clear()
        ListView2.Items.Add("NULL")
        ImageList2.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView2.Items.Item(0).ImageIndex = 0
        PictureBox2.Image = Null
        SelectPath(Index) = ""
        For i = 0 To TempPath.Count - 1
            Dim str As String = ""
            Dim a = 0
            Do
                a = a + 1
                str = TempPath(i)(TempPath(i).Length - a) + str
            Loop Until TempPath(i)(TempPath(i).Length - a) = "\"
            If IO.Directory.Exists(TempPath(i) + "\F") Or IO.Directory.Exists(TempPath(i) + "\M") Then
                If IO.Directory.Exists(TempPath(i) + "\F") Then
                    ReDim Preserve Path2(Path2.Count)
                    Path2(Path2.Count - 1) = str + "\F"
                End If
                If IO.Directory.Exists(TempPath(i) + "\M") Then
                    ReDim Preserve Path2(Path2.Count)
                    Path2(Path2.Count - 1) = str + "\M"
                End If
            Else
                ReDim Preserve Path2(Path2.Count)
                Path2(Path2.Count - 1) = str
            End If
        Next
        For i = 0 To Path2.Count - 1
            ListView2.Items.Add(Path2(i))
            ImageList2.Images.Add(Path2(i), Loading)
            ListView2.Items.Item(i + 1).ImageIndex = i + 1
        Next
        BackgroundWorker2.RunWorkerAsync()
    End Sub

    Private Sub Button2_clear_Click(sender As Object, e As EventArgs) Handles Button2_clear.Click
        If BackgroundWorker2.IsBusy Then Exit Sub
        Dim Index = 2
        ListView2.Clear()
        ImageList2.Images.Clear()
        ListView2.Items.Add("NULL")
        ImageList2.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView2.Items.Item(0).ImageIndex = 0
        PictureBox2.Image = Null
        SelectPath(Index) = ""
    End Sub

    Private Sub Button2_ok_Click(sender As Object, e As EventArgs) Handles Button2_ok.Click
        Dim Index = 2
        If SelectPath(Index) = "" Then
            SangoTool.FolderBrowserDialog1.SelectedPath = ""
        Else
            SangoTool.FolderBrowserDialog1.SelectedPath = PathList(Index) + SelectPath(Index)
        End If
        Me.Close()
    End Sub

    '-----------------------------------------------------------------------------------------------
    '                                    Directory 3
    '-----------------------------------------------------------------------------------------------

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        Dim Index = 3
        For i = 0 To Path3.Count - 1
            ImageList3.Images(i + 1) = New Bitmap(ImageList3.ImageSize.Width, ImageList3.ImageSize.Height)
            ImageList3.Images(i + 1) = SHPToBitmap(GetFileName(PathList(Index) + Path3(i))(0), GetFileName(PathList(Index) + Path3(i))(1))
        Next
    End Sub

    Private Sub ListView3_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView3.SelectedIndexChanged
        Dim Index = 3
        Dim SelectedIndices = ListView3.SelectedIndices()
        If SelectedIndices.Count > 0 Then
            If SelectedIndices(0) = 0 Then
                PictureBox3.Image = Null
                SelectPath(Index) = ""
            Else
                Try
                    PictureBox3.Image = SHPToBitmap(GetFileName(PathList(Index) + Path3(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path3(SelectedIndices(0) - 1))(1))
                Catch
                    PictureBox3.Image = CreateImage("IsBusy", 96, 96, "#ffffff")
                End Try
                'PictureBox3.Image = SHPToBitmap(GetFileName(PathList(Index) + Path3(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path3(SelectedIndices(0) - 1))(1))
                SelectPath(Index) = Path3(SelectedIndices(0) - 1)
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If BackgroundWorker3.IsBusy Then Exit Sub
        Dim Index As Int16 = 3
        FolderBrowserDialog1.SelectedPath = GetINI("SelectObject", "Path" + Index.ToString, "", Config)
        FolderBrowserDialog1.ShowDialog()
        PathList(Index) = FolderBrowserDialog1.SelectedPath
        WriteINI("SelectObject", "Path" + Index.ToString, PathList(Index), Config)
        Dim TempPath = IO.Directory.GetDirectories(PathList(Index))
        Path3 = {}
        ListView3.Items.Clear()
        ImageList3.Images.Clear()
        ListView3.Items.Add("NULL")
        ImageList3.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView3.Items.Item(0).ImageIndex = 0
        PictureBox3.Image = Null
        SelectPath(Index) = ""
        For i = 0 To TempPath.Count - 1
            Dim str As String = ""
            Dim a = 0
            Do
                a = a + 1
                str = TempPath(i)(TempPath(i).Length - a) + str
            Loop Until TempPath(i)(TempPath(i).Length - a) = "\"
            If IO.Directory.Exists(TempPath(i) + "\F") Or IO.Directory.Exists(TempPath(i) + "\M") Then
                If IO.Directory.Exists(TempPath(i) + "\F") Then
                    ReDim Preserve Path3(Path3.Count)
                    Path3(Path3.Count - 1) = str + "\F"
                End If
                If IO.Directory.Exists(TempPath(i) + "\M") Then
                    ReDim Preserve Path3(Path3.Count)
                    Path3(Path3.Count - 1) = str + "\M"
                End If
            Else
                ReDim Preserve Path3(Path3.Count)
                Path3(Path3.Count - 1) = str
            End If
        Next
        For i = 0 To Path3.Count - 1
            ListView3.Items.Add(Path3(i))
            ImageList3.Images.Add(Path3(i), Loading)
            ListView3.Items.Item(i + 1).ImageIndex = i + 1
        Next
        BackgroundWorker3.RunWorkerAsync()
    End Sub

    Private Sub Button3_clear_Click(sender As Object, e As EventArgs) Handles Button3_clear.Click
        If BackgroundWorker3.IsBusy Then Exit Sub
        Dim Index = 3
        ListView3.Clear()
        ImageList3.Images.Clear()
        ListView3.Items.Add("NULL")
        ImageList3.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView3.Items.Item(0).ImageIndex = 0
        PictureBox3.Image = Null
        SelectPath(Index) = ""
    End Sub

    Private Sub Button3_ok_Click(sender As Object, e As EventArgs) Handles Button3_ok.Click
        Dim Index = 3
        If SelectPath(Index) = "" Then
            SangoTool.FolderBrowserDialog1.SelectedPath = ""
        Else
            SangoTool.FolderBrowserDialog1.SelectedPath = PathList(Index) + SelectPath(Index)
        End If
        Me.Close()
    End Sub

    '-----------------------------------------------------------------------------------------------
    '                                    Directory 4
    '-----------------------------------------------------------------------------------------------

    Private Sub BackgroundWorker4_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker4.DoWork
        Dim Index = 4
        For i = 0 To Path4.Count - 1
            ImageList4.Images(i + 1) = New Bitmap(ImageList4.ImageSize.Width, ImageList4.ImageSize.Height)
            ImageList4.Images(i + 1) = SHPToBitmap(GetFileName(PathList(Index) + Path4(i))(0), GetFileName(PathList(Index) + Path4(i))(1))
        Next
    End Sub

    Private Sub ListView4_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView4.SelectedIndexChanged
        Dim Index = 4
        Dim SelectedIndices = ListView4.SelectedIndices()
        If SelectedIndices.Count > 0 Then
            If SelectedIndices(0) = 0 Then
                PictureBox4.Image = Null
                SelectPath(Index) = ""
            Else
                Try
                    PictureBox4.Image = SHPToBitmap(GetFileName(PathList(Index) + Path4(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path4(SelectedIndices(0) - 1))(1))
                Catch
                    PictureBox4.Image = CreateImage("IsBusy", 96, 96, "#ffffff")
                End Try
                'PictureBox4.Image = SHPToBitmap(GetFileName(PathList(Index) + Path4(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path4(SelectedIndices(0) - 1))(1))
                SelectPath(Index) = Path4(SelectedIndices(0) - 1)
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If BackgroundWorker4.IsBusy Then Exit Sub
        Dim Index As Int16 = 4
        FolderBrowserDialog1.SelectedPath = GetINI("SelectObject", "Path" + Index.ToString, "", Config)
        FolderBrowserDialog1.ShowDialog()
        PathList(Index) = FolderBrowserDialog1.SelectedPath
        WriteINI("SelectObject", "Path" + Index.ToString, PathList(Index), Config)
        Dim TempPath = IO.Directory.GetDirectories(PathList(Index))
        Path4 = {}
        ListView4.Items.Clear()
        ImageList4.Images.Clear()
        ListView4.Items.Add("NULL")
        ImageList4.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView4.Items.Item(0).ImageIndex = 0
        PictureBox4.Image = Null
        SelectPath(Index) = ""
        For i = 0 To TempPath.Count - 1
            Dim str As String = ""
            Dim a = 0
            Do
                a = a + 1
                str = TempPath(i)(TempPath(i).Length - a) + str
            Loop Until TempPath(i)(TempPath(i).Length - a) = "\"
            If IO.Directory.Exists(TempPath(i) + "\F") Or IO.Directory.Exists(TempPath(i) + "\M") Then
                If IO.Directory.Exists(TempPath(i) + "\F") Then
                    ReDim Preserve Path4(Path4.Count)
                    Path4(Path4.Count - 1) = str + "\F"
                End If
                If IO.Directory.Exists(TempPath(i) + "\M") Then
                    ReDim Preserve Path4(Path4.Count)
                    Path4(Path4.Count - 1) = str + "\M"
                End If
            Else
                ReDim Preserve Path4(Path4.Count)
                Path4(Path4.Count - 1) = str
            End If
        Next
        For i = 0 To Path4.Count - 1
            ListView4.Items.Add(Path4(i))
            ImageList4.Images.Add(Path4(i), Loading)
            ListView4.Items.Item(i + 1).ImageIndex = i + 1
        Next
        BackgroundWorker4.RunWorkerAsync()
    End Sub

    Private Sub Button4_clear_Click(sender As Object, e As EventArgs) Handles Button4_clear.Click
        If BackgroundWorker4.IsBusy Then Exit Sub
        Dim Index = 4
        ListView4.Clear()
        ImageList4.Images.Clear()
        ListView4.Items.Add("NULL")
        ImageList4.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView4.Items.Item(0).ImageIndex = 0
        PictureBox4.Image = Null
        SelectPath(Index) = ""
    End Sub

    Private Sub Button4_ok_Click(sender As Object, e As EventArgs) Handles Button4_ok.Click
        Dim Index = 4
        If SelectPath(Index) = "" Then
            SangoTool.FolderBrowserDialog1.SelectedPath = ""
        Else
            SangoTool.FolderBrowserDialog1.SelectedPath = PathList(Index) + SelectPath(Index)
        End If
        Me.Close()
    End Sub

    '-----------------------------------------------------------------------------------------------
    '                                    Directory 5
    '-----------------------------------------------------------------------------------------------

    Private Sub BackgroundWorker5_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker5.DoWork
        Dim Index = 5
        For i = 0 To Path5.Count - 1
            ImageList5.Images(i + 1) = New Bitmap(ImageList5.ImageSize.Width, ImageList5.ImageSize.Height)
            ImageList5.Images(i + 1) = SHPToBitmap(GetFileName(PathList(Index) + Path5(i))(0), GetFileName(PathList(Index) + Path5(i))(1))
        Next
    End Sub

    Private Sub ListView5_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView5.SelectedIndexChanged
        Dim Index = 5
        Dim SelectedIndices = ListView5.SelectedIndices()
        If SelectedIndices.Count > 0 Then
            If SelectedIndices(0) = 0 Then
                PictureBox5.Image = Null
                SelectPath(Index) = ""
            Else
                Try
                    PictureBox5.Image = SHPToBitmap(GetFileName(PathList(Index) + Path5(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path5(SelectedIndices(0) - 1))(1))
                Catch
                    PictureBox5.Image = CreateImage("IsBusy", 96, 96, "#ffffff")
                End Try
                'PictureBox5.Image = SHPToBitmap(GetFileName(PathList(Index) + Path5(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path5(SelectedIndices(0) - 1))(1))
                SelectPath(Index) = Path5(SelectedIndices(0) - 1)
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If BackgroundWorker5.IsBusy Then Exit Sub
        Dim Index As Int16 = 5
        FolderBrowserDialog1.SelectedPath = GetINI("SelectObject", "Path" + Index.ToString, "", Config)
        FolderBrowserDialog1.ShowDialog()
        PathList(Index) = FolderBrowserDialog1.SelectedPath
        WriteINI("SelectObject", "Path" + Index.ToString, PathList(Index), Config)
        Dim TempPath = IO.Directory.GetDirectories(PathList(Index))
        Path5 = {}
        ListView5.Items.Clear()
        ImageList5.Images.Clear()
        ListView5.Items.Add("NULL")
        ImageList5.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView5.Items.Item(0).ImageIndex = 0
        PictureBox5.Image = Null
        SelectPath(Index) = ""
        For i = 0 To TempPath.Count - 1
            Dim str As String = ""
            Dim a = 0
            Do
                a = a + 1
                str = TempPath(i)(TempPath(i).Length - a) + str
            Loop Until TempPath(i)(TempPath(i).Length - a) = "\"
            If IO.Directory.Exists(TempPath(i) + "\F") Or IO.Directory.Exists(TempPath(i) + "\M") Then
                If IO.Directory.Exists(TempPath(i) + "\F") Then
                    ReDim Preserve Path5(Path5.Count)
                    Path5(Path5.Count - 1) = str + "\F"
                End If
                If IO.Directory.Exists(TempPath(i) + "\M") Then
                    ReDim Preserve Path5(Path5.Count)
                    Path5(Path5.Count - 1) = str + "\M"
                End If
            Else
                ReDim Preserve Path5(Path5.Count)
                Path5(Path5.Count - 1) = str
            End If
        Next
        For i = 0 To Path5.Count - 1
            ListView5.Items.Add(Path5(i))
            ImageList5.Images.Add(Path5(i), Loading)
            ListView5.Items.Item(i + 1).ImageIndex = i + 1
        Next
        BackgroundWorker5.RunWorkerAsync()
    End Sub

    Private Sub Button5_clear_Click(sender As Object, e As EventArgs) Handles Button5_clear.Click
        If BackgroundWorker5.IsBusy Then Exit Sub
        Dim Index = 5
        ListView5.Clear()
        ImageList5.Images.Clear()
        ListView5.Items.Add("NULL")
        ImageList5.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView5.Items.Item(0).ImageIndex = 0
        PictureBox5.Image = Null
        SelectPath(Index) = ""
    End Sub

    Private Sub Button5_ok_Click(sender As Object, e As EventArgs) Handles Button5_ok.Click
        Dim Index = 5
        If SelectPath(Index) = "" Then
            SangoTool.FolderBrowserDialog1.SelectedPath = ""
        Else
            SangoTool.FolderBrowserDialog1.SelectedPath = PathList(Index) + SelectPath(Index)
        End If
        Me.Close()
    End Sub

    '-----------------------------------------------------------------------------------------------
    '                                    Directory 6
    '-----------------------------------------------------------------------------------------------

    Private Sub BackgroundWorker6_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker6.DoWork
        Dim Index = 6
        For i = 0 To Path6.Count - 1
            ImageList6.Images(i + 1) = New Bitmap(ImageList6.ImageSize.Width, ImageList6.ImageSize.Height)
            ImageList6.Images(i + 1) = SHPToBitmap(GetFileName(PathList(Index) + Path6(i))(0), GetFileName(PathList(Index) + Path6(i))(1))
        Next
    End Sub

    Private Sub ListView6_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView6.SelectedIndexChanged
        Dim Index = 6
        Dim SelectedIndices = ListView6.SelectedIndices()
        If SelectedIndices.Count > 0 Then
            If SelectedIndices(0) = 0 Then
                PictureBox6.Image = Null
                SelectPath(Index) = ""
            Else
                Try
                    PictureBox6.Image = SHPToBitmap(GetFileName(PathList(Index) + Path6(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path6(SelectedIndices(0) - 1))(1))
                Catch
                    PictureBox6.Image = CreateImage("IsBusy", 96, 96, "#ffffff")
                End Try
                'PictureBox6.Image = SHPToBitmap(GetFileName(PathList(Index) + Path6(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path6(SelectedIndices(0) - 1))(1))
                SelectPath(Index) = Path6(SelectedIndices(0) - 1)
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If BackgroundWorker6.IsBusy Then Exit Sub
        Dim Index As Int16 = 6
        FolderBrowserDialog1.SelectedPath = GetINI("SelectObject", "Path" + Index.ToString, "", Config)
        FolderBrowserDialog1.ShowDialog()
        PathList(Index) = FolderBrowserDialog1.SelectedPath
        WriteINI("SelectObject", "Path" + Index.ToString, PathList(Index), Config)
        Dim TempPath = IO.Directory.GetDirectories(PathList(Index))
        Path6 = {}
        ListView6.Items.Clear()
        ImageList6.Images.Clear()
        ListView6.Items.Add("NULL")
        ImageList6.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView6.Items.Item(0).ImageIndex = 0
        PictureBox6.Image = Null
        SelectPath(Index) = ""
        For i = 0 To TempPath.Count - 1
            Dim str As String = ""
            Dim a = 0
            Do
                a = a + 1
                str = TempPath(i)(TempPath(i).Length - a) + str
            Loop Until TempPath(i)(TempPath(i).Length - a) = "\"
            If IO.Directory.Exists(TempPath(i) + "\F") Or IO.Directory.Exists(TempPath(i) + "\M") Then
                If IO.Directory.Exists(TempPath(i) + "\F") Then
                    ReDim Preserve Path6(Path6.Count)
                    Path6(Path6.Count - 1) = str + "\F"
                End If
                If IO.Directory.Exists(TempPath(i) + "\M") Then
                    ReDim Preserve Path6(Path6.Count)
                    Path6(Path6.Count - 1) = str + "\M"
                End If
            Else
                ReDim Preserve Path6(Path6.Count)
                Path6(Path6.Count - 1) = str
            End If
        Next
        For i = 0 To Path6.Count - 1
            ListView6.Items.Add(Path6(i))
            ImageList6.Images.Add(Path6(i), Loading)
            ListView6.Items.Item(i + 1).ImageIndex = i + 1
        Next
        BackgroundWorker6.RunWorkerAsync()
    End Sub

    Private Sub Button6_clear_Click(sender As Object, e As EventArgs) Handles Button6_clear.Click
        If BackgroundWorker6.IsBusy Then Exit Sub
        Dim Index = 6
        ListView6.Clear()
        ImageList6.Images.Clear()
        ListView6.Items.Add("NULL")
        ImageList6.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView6.Items.Item(0).ImageIndex = 0
        PictureBox6.Image = Null
        SelectPath(Index) = ""
    End Sub

    Private Sub Button6_ok_Click(sender As Object, e As EventArgs) Handles Button6_ok.Click
        Dim Index = 6
        If SelectPath(Index) = "" Then
            SangoTool.FolderBrowserDialog1.SelectedPath = ""
        Else
            SangoTool.FolderBrowserDialog1.SelectedPath = PathList(Index) + SelectPath(Index)
        End If
        Me.Close()
    End Sub

    '-----------------------------------------------------------------------------------------------
    '                                    Directory 7
    '-----------------------------------------------------------------------------------------------

    Private Sub BackgroundWorker7_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker7.DoWork
        Dim Index = 7
        For i = 0 To Path7.Count - 1
            ImageList7.Images(i + 1) = New Bitmap(ImageList7.ImageSize.Width, ImageList7.ImageSize.Height)
            ImageList7.Images(i + 1) = SHPToBitmap(GetFileName(PathList(Index) + Path7(i))(0), GetFileName(PathList(Index) + Path7(i))(1))
        Next
    End Sub

    Private Sub ListView7_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView7.SelectedIndexChanged
        Dim Index = 7
        Dim SelectedIndices = ListView7.SelectedIndices()
        If SelectedIndices.Count > 0 Then
            If SelectedIndices(0) = 0 Then
                PictureBox7.Image = Null
                SelectPath(Index) = ""
            Else
                Try
                    PictureBox7.Image = SHPToBitmap(GetFileName(PathList(Index) + Path7(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path7(SelectedIndices(0) - 1))(1))
                Catch
                    PictureBox7.Image = CreateImage("IsBusy", 96, 96, "#ffffff")
                End Try
                'PictureBox7.Image = SHPToBitmap(GetFileName(PathList(Index) + Path7(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path7(SelectedIndices(0) - 1))(1))
                SelectPath(Index) = Path7(SelectedIndices(0) - 1)
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If BackgroundWorker7.IsBusy Then Exit Sub
        Dim Index As Int16 = 7
        FolderBrowserDialog1.SelectedPath = GetINI("SelectObject", "Path" + Index.ToString, "", Config)
        FolderBrowserDialog1.ShowDialog()
        PathList(Index) = FolderBrowserDialog1.SelectedPath
        WriteINI("SelectObject", "Path" + Index.ToString, PathList(Index), Config)
        Dim TempPath = IO.Directory.GetDirectories(PathList(Index))
        Path7 = {}
        ListView7.Items.Clear()
        ImageList7.Images.Clear()
        ListView7.Items.Add("NULL")
        ImageList7.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView7.Items.Item(0).ImageIndex = 0
        PictureBox7.Image = Null
        SelectPath(Index) = ""
        For i = 0 To TempPath.Count - 1
            Dim str As String = ""
            Dim a = 0
            Do
                a = a + 1
                str = TempPath(i)(TempPath(i).Length - a) + str
            Loop Until TempPath(i)(TempPath(i).Length - a) = "\"
            If IO.Directory.Exists(TempPath(i) + "\F") Or IO.Directory.Exists(TempPath(i) + "\M") Then
                If IO.Directory.Exists(TempPath(i) + "\F") Then
                    ReDim Preserve Path7(Path7.Count)
                    Path7(Path7.Count - 1) = str + "\F"
                End If
                If IO.Directory.Exists(TempPath(i) + "\M") Then
                    ReDim Preserve Path7(Path7.Count)
                    Path7(Path7.Count - 1) = str + "\M"
                End If
            Else
                ReDim Preserve Path7(Path7.Count)
                Path7(Path7.Count - 1) = str
            End If
        Next
        For i = 0 To Path7.Count - 1
            ListView7.Items.Add(Path7(i))
            ImageList7.Images.Add(Path7(i), Loading)
            ListView7.Items.Item(i + 1).ImageIndex = i + 1
        Next
        BackgroundWorker7.RunWorkerAsync()
    End Sub

    Private Sub Button7_clear_Click(sender As Object, e As EventArgs) Handles Button7_clear.Click
        If BackgroundWorker7.IsBusy Then Exit Sub
        Dim Index = 7
        ListView7.Clear()
        ImageList7.Images.Clear()
        ListView7.Items.Add("NULL")
        ImageList7.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView7.Items.Item(0).ImageIndex = 0
        PictureBox7.Image = Null
        SelectPath(Index) = ""
    End Sub

    Private Sub Button7_ok_Click(sender As Object, e As EventArgs) Handles Button7_ok.Click
        Dim Index = 7
        If SelectPath(Index) = "" Then
            SangoTool.FolderBrowserDialog1.SelectedPath = ""
        Else
            SangoTool.FolderBrowserDialog1.SelectedPath = PathList(Index) + SelectPath(Index)
        End If
        Me.Close()
    End Sub

    '-----------------------------------------------------------------------------------------------
    '                                    Directory 8
    '-----------------------------------------------------------------------------------------------

    Private Sub BackgroundWorker8_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker8.DoWork
        Dim Index = 8
        For i = 0 To Path8.Count - 1
            ImageList8.Images(i + 1) = New Bitmap(ImageList8.ImageSize.Width, ImageList8.ImageSize.Height)
            ImageList8.Images(i + 1) = SHPToBitmap(GetFileName(PathList(Index) + Path8(i))(0), GetFileName(PathList(Index) + Path8(i))(1))
        Next
    End Sub

    Private Sub ListView8_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView8.SelectedIndexChanged
        Dim Index = 8
        Dim SelectedIndices = ListView8.SelectedIndices()
        If SelectedIndices.Count > 0 Then
            If SelectedIndices(0) = 0 Then
                PictureBox8.Image = Null
                SelectPath(Index) = ""
            Else
                Try
                    PictureBox8.Image = SHPToBitmap(GetFileName(PathList(Index) + Path8(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path8(SelectedIndices(0) - 1))(1))
                Catch
                    PictureBox8.Image = CreateImage("IsBusy", 96, 96, "#ffffff")
                End Try
                'PictureBox8.Image = SHPToBitmap(GetFileName(PathList(Index) + Path8(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path8(SelectedIndices(0) - 1))(1))
                SelectPath(Index) = Path8(SelectedIndices(0) - 1)
            End If
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If BackgroundWorker8.IsBusy Then Exit Sub
        Dim Index As Int16 = 8
        FolderBrowserDialog1.SelectedPath = GetINI("SelectObject", "Path" + Index.ToString, "", Config)
        FolderBrowserDialog1.ShowDialog()
        PathList(Index) = FolderBrowserDialog1.SelectedPath
        WriteINI("SelectObject", "Path" + Index.ToString, PathList(Index), Config)
        Dim TempPath = IO.Directory.GetDirectories(PathList(Index))
        Path8 = {}
        ListView8.Items.Clear()
        ImageList8.Images.Clear()
        ListView8.Items.Add("NULL")
        ImageList8.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView8.Items.Item(0).ImageIndex = 0
        PictureBox8.Image = Null
        SelectPath(Index) = ""
        For i = 0 To TempPath.Count - 1
            Dim str As String = ""
            Dim a = 0
            Do
                a = a + 1
                str = TempPath(i)(TempPath(i).Length - a) + str
            Loop Until TempPath(i)(TempPath(i).Length - a) = "\"
            If IO.Directory.Exists(TempPath(i) + "\F") Or IO.Directory.Exists(TempPath(i) + "\M") Then
                If IO.Directory.Exists(TempPath(i) + "\F") Then
                    ReDim Preserve Path8(Path8.Count)
                    Path8(Path8.Count - 1) = str + "\F"
                End If
                If IO.Directory.Exists(TempPath(i) + "\M") Then
                    ReDim Preserve Path8(Path8.Count)
                    Path8(Path8.Count - 1) = str + "\M"
                End If
            Else
                ReDim Preserve Path8(Path8.Count)
                Path8(Path8.Count - 1) = str
            End If
        Next
        For i = 0 To Path8.Count - 1
            ListView8.Items.Add(Path8(i))
            ImageList8.Images.Add(Path8(i), Loading)
            ListView8.Items.Item(i + 1).ImageIndex = i + 1
        Next
        BackgroundWorker8.RunWorkerAsync()
    End Sub

    Private Sub Button8_clear_Click(sender As Object, e As EventArgs) Handles Button8_clear.Click
        If BackgroundWorker8.IsBusy Then Exit Sub
        Dim Index = 8
        ListView8.Clear()
        ImageList8.Images.Clear()
        ListView8.Items.Add("NULL")
        ImageList8.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView8.Items.Item(0).ImageIndex = 0
        PictureBox8.Image = Null
        SelectPath(Index) = ""
    End Sub

    Private Sub Button8_ok_Click(sender As Object, e As EventArgs) Handles Button8_ok.Click
        Dim Index = 8
        If SelectPath(Index) = "" Then
            SangoTool.FolderBrowserDialog1.SelectedPath = ""
        Else
            SangoTool.FolderBrowserDialog1.SelectedPath = PathList(Index) + SelectPath(Index)
        End If
        Me.Close()
    End Sub

    '-----------------------------------------------------------------------------------------------
    '                                    Directory 9
    '-----------------------------------------------------------------------------------------------

    Private Sub BackgroundWorker9_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker9.DoWork
        Dim Index = 9
        For i = 0 To Path9.Count - 1
            ImageList9.Images(i + 1) = New Bitmap(ImageList9.ImageSize.Width, ImageList9.ImageSize.Height)
            ImageList9.Images(i + 1) = SHPToBitmap(GetFileName(PathList(Index) + Path9(i))(0), GetFileName(PathList(Index) + Path9(i))(1))
        Next
    End Sub

    Private Sub ListView9_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView9.SelectedIndexChanged
        Dim Index = 9
        Dim SelectedIndices = ListView9.SelectedIndices()
        If SelectedIndices.Count > 0 Then
            If SelectedIndices(0) = 0 Then
                PictureBox9.Image = Null
                SelectPath(Index) = ""
            Else
                Try
                    PictureBox9.Image = SHPToBitmap(GetFileName(PathList(Index) + Path9(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path9(SelectedIndices(0) - 1))(1))
                Catch
                    PictureBox9.Image = CreateImage("IsBusy", 96, 96, "#ffffff")
                End Try
                'PictureBox9.Image = SHPToBitmap(GetFileName(PathList(Index) + Path9(SelectedIndices(0) - 1))(0), GetFileName(PathList(Index) + Path9(SelectedIndices(0) - 1))(1))
                SelectPath(Index) = Path9(SelectedIndices(0) - 1)
            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If BackgroundWorker9.IsBusy Then Exit Sub
        Dim Index As Int16 = 9
        FolderBrowserDialog1.SelectedPath = GetINI("SelectObject", "Path" + Index.ToString, "", Config)
        FolderBrowserDialog1.ShowDialog()
        PathList(Index) = FolderBrowserDialog1.SelectedPath
        WriteINI("SelectObject", "Path" + Index.ToString, PathList(Index), Config)
        Dim TempPath = IO.Directory.GetDirectories(PathList(Index))
        Path9 = {}
        ListView9.Items.Clear()
        ImageList9.Images.Clear()
        ListView9.Items.Add("NULL")
        ImageList9.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView9.Items.Item(0).ImageIndex = 0
        PictureBox9.Image = Null
        SelectPath(Index) = ""
        For i = 0 To TempPath.Count - 1
            Dim str As String = ""
            Dim a = 0
            Do
                a = a + 1
                str = TempPath(i)(TempPath(i).Length - a) + str
            Loop Until TempPath(i)(TempPath(i).Length - a) = "\"
            If IO.Directory.Exists(TempPath(i) + "\F") Or IO.Directory.Exists(TempPath(i) + "\M") Then
                If IO.Directory.Exists(TempPath(i) + "\F") Then
                    ReDim Preserve Path9(Path9.Count)
                    Path9(Path9.Count - 1) = str + "\F"
                End If
                If IO.Directory.Exists(TempPath(i) + "\M") Then
                    ReDim Preserve Path9(Path9.Count)
                    Path9(Path9.Count - 1) = str + "\M"
                End If
            Else
                ReDim Preserve Path9(Path9.Count)
                Path9(Path9.Count - 1) = str
            End If
        Next
        For i = 0 To Path9.Count - 1
            ListView9.Items.Add(Path9(i))
            ImageList9.Images.Add(Path9(i), Loading)
            ListView9.Items.Item(i + 1).ImageIndex = i + 1
        Next
        BackgroundWorker9.RunWorkerAsync()
    End Sub

    Private Sub Button9_clear_Click(sender As Object, e As EventArgs) Handles Button9_clear.Click
        If BackgroundWorker9.IsBusy Then Exit Sub
        Dim Index = 9
        ListView9.Clear()
        ImageList9.Images.Clear()
        ListView9.Items.Add("NULL")
        ImageList9.Images.Add("NULL", CreateImage("NULL", 96, 96))
        ListView9.Items.Item(0).ImageIndex = 0
        PictureBox9.Image = Null
        SelectPath(Index) = ""
    End Sub

    Private Sub Button9_ok_Click(sender As Object, e As EventArgs) Handles Button9_ok.Click
        Dim Index = 9
        If SelectPath(Index) = "" Then
            SangoTool.FolderBrowserDialog1.SelectedPath = ""
        Else
            SangoTool.FolderBrowserDialog1.SelectedPath = PathList(Index) + SelectPath(Index)
        End If
        Me.Close()
    End Sub

End Class