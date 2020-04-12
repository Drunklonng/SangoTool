Imports System.IO
Imports System.Text

Module SangoCore
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32

    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As String
        Dim Str As String = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), FileName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function

    Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As Long
        WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, FileName)
    End Function

    Public Function RGB16To24(R5G6B5 As UInt16, Optional R As Int16 = 0, Optional G As Int16 = 1, Optional B As Int16 = 2) As Color
        Dim str As String = Convert.ToString(R5G6B5, 2)
        Do Until str.Length >= 16
            str = "0" + str
        Loop
        Dim R5 As String = Mid(str, 1, 5)
        Dim G6 As String = Mid(str, 6, 6)
        Dim B5 As String = Mid(str, 12, 5)
        Dim RGB As Int32() = {Convert.ToInt32(R5 + "000", 2), Convert.ToInt32(G6 + "00", 2), Convert.ToInt32(B5 + "000", 2)}
        If R > 2 Then R = 2
        If R < 0 Then R = 0
        If G > 2 Then G = 2
        If G < 0 Then G = 0
        If B > 2 Then B = 2
        If B < 0 Then B = 0
        RGB16To24 = Color.FromArgb(RGB(R), RGB(G), RGB(B))
    End Function

    Public Function RGB24To16(Color As Color) As UInt16
        Dim R As String = Convert.ToString(Color.R, 2)
        Dim G As String = Convert.ToString(Color.G, 2)
        Dim B As String = Convert.ToString(Color.B, 2)
        Do Until R.Length >= 8
            R = "0" + R
        Loop
        Do Until G.Length >= 8
            G = "0" + G
        Loop
        Do Until B.Length >= 8
            B = "0" + B
        Loop
        Dim R5 As String = Mid(R, 1, 5)
        Dim G6 As String = Mid(G, 1, 6)
        Dim B5 As String = Mid(B, 1, 5)
        RGB24To16 = Convert.ToInt32(R5 + G6 + B5, 2)
    End Function

    Public Function CreateImage(Text As String, Width As Int16, Height As Int16, Optional ColorHtml As String = "#f0f0f0") As Bitmap
        CreateImage = Nothing
        Dim font As Font
        font = New Font("Arial", 11, FontStyle.Bold)
        Dim brush As SolidBrush
        brush = New SolidBrush(Color.Black)
        CreateImage = New Bitmap(Width, Height)
        Dim g As Graphics
        g = Graphics.FromImage(CreateImage)
        g.Clear(ColorTranslator.FromHtml(ColorHtml))
        Dim rect As RectangleF
        rect = New RectangleF((Width - Text.Length * 9) / 2, Height / 2 - 9, Width, Height)
        g.DrawString(Text, font, brush, rect)
        g.Dispose()
    End Function

    Public Function SetCenterPoint(shpfile As String, POSX As Int32, POSY As Int32) As Boolean
        If IO.File.Exists(shpfile) Then
            Dim Readfailed As Boolean = False
            Dim fs As FileStream = Nothing
            Do
                Try
                    fs = New FileStream(shpfile, FileMode.Open, FileAccess.Read)
                    Readfailed = False
                Catch ' ex As Exception
                    Readfailed = True
                End Try
                Windows.Forms.Application.DoEvents()
            Loop While Readfailed = True
            Dim bw As New BinaryWriter(fs)
            fs.Seek(28, SeekOrigin.Begin)
            bw.Write(POSX)
            bw.Write(POSY)
            bw.Close()
            fs.Close()
        End If
        SetCenterPoint = True
    End Function

    Public Function GetCenterPoint(shpfile As String, Optional shpfile2 As String = "") As Int16()
        Dim CenterPoint As Int16() = {0, 0, 1, 1}
        If Not IO.File.Exists(shpfile) Then shpfile = shpfile2
        If IO.File.Exists(shpfile) Then
            Dim Readfailed As Boolean = False
            Dim fs As FileStream = Nothing
            Do
                Try
                    fs = New FileStream(shpfile, FileMode.Open, FileAccess.Read)
                    Readfailed = False
                Catch ' ex As Exception
                    Readfailed = True
                End Try
                Windows.Forms.Application.DoEvents()
            Loop While Readfailed = True
            Dim br As New BinaryReader(fs)
            fs.Seek(20, SeekOrigin.Begin)
            CenterPoint(2) = br.ReadInt32
            CenterPoint(3) = br.ReadInt32
            CenterPoint(0) = br.ReadInt32
            CenterPoint(1) = br.ReadInt32
            br.Close()
            fs.Close()
        End If
        GetCenterPoint = CenterPoint
    End Function

    Public Function GetFileList(Path As String) As String()
        Dim SubPath As String() = IO.Directory.GetDirectories(Path)
        Dim FileList As String() = {}
        For i = 0 To SubPath.Count - 1
            Dim SubFileList As String() = IO.Directory.GetFiles(SubPath(i), "*.shp")
            For o = 0 To SubFileList.Count - 1
                ReDim Preserve FileList(FileList.Count)
                Dim str As String = ""
                Dim a As Int16 = 1
                Do
                    str = SubFileList(o)(SubFileList(o).Length - a) + str
                    a = a + 1
                Loop Until SubFileList(o)(SubFileList(o).Length - a) = "\"
                FileList(FileList.Count - 1) = "\" + str
            Next
        Next
        GetFileList = FileList
    End Function

    Public Function GetSubPath(Path As String) As String()
        Dim SubPath As String() = IO.Directory.GetDirectories(Path)
        Dim SubPathList As String() = {}
        For i = 0 To SubPath.Count - 1
            Dim str As String = ""
            Dim a As Int16 = 1
            Do
                str = SubPath(i)(SubPath(i).Length - a) + str
                a = a + 1
            Loop Until SubPath(i)(SubPath(i).Length - a) = "\"
            Dim SubFileList As String() = IO.Directory.GetFiles(SubPath(i), "*.shp")
            For o = 0 To SubFileList.Count - 1
                ReDim Preserve SubPathList(SubPathList.Count)
                SubPathList(SubPathList.Count - 1) = "\" + str
            Next
        Next
        GetSubPath = SubPathList
    End Function

    Public Function Calculator(PointA As Int32(), PointB As Int16(), AlphaA As Int32, AlphaB As Int32) As Int32()
        If PointB(2) = 1 And PointB(3) = 1 And AlphaB = 0 Then
        Else
            If PointA(2) = 1 And PointA(3) = 1 And AlphaA = 0 Then
                PointA = {PointB(0), PointB(1), 1, 1}
            End If
            If PointB(2) - PointB(0) > PointA(2) - PointA(0) Then
                Dim increment As Int16 = (PointB(2) - PointB(0)) - (PointA(2) - PointA(0))
                PointA(2) = PointA(2) + increment
            End If
            If PointB(3) - PointB(1) > PointA(3) - PointA(1) Then
                Dim increment As Int16 = (PointB(3) - PointB(1)) - (PointA(3) - PointA(1))
                PointA(3) = PointA(3) + increment
            End If
            If PointB(0) > PointA(0) Then
                PointA(2) = PointA(2) + (PointB(0) - PointA(0))
                PointA(0) = PointA(0) + (PointB(0) - PointA(0))
            End If
            If PointB(1) > PointA(1) Then
                PointA(3) = PointA(3) + (PointB(1) - PointA(1))
                PointA(1) = PointA(1) + (PointB(1) - PointA(1))
            End If
        End If
        Calculator = PointA
    End Function

    Public Function BitmapTransform(OriginalBitmap As Bitmap, Flip As Boolean, Zoom As Boolean, AntiAliasing As Boolean, ZoomRate As Double) As Bitmap
        If Flip Then
            If AntiAliasing = True Then
                OriginalBitmap.RotateFlip(RotateFlipType.RotateNoneFlipX)
            Else
                Dim FlipBitmap As Bitmap = New Bitmap(OriginalBitmap.Width, OriginalBitmap.Height)
                For y = 0 To FlipBitmap.Height - 1
                    For x = 0 To FlipBitmap.Width - 1
                        FlipBitmap.SetPixel(FlipBitmap.Width - 1 - x, y, OriginalBitmap.GetPixel(x, y))
                    Next
                Next
                OriginalBitmap = FlipBitmap
            End If
        End If
        If Zoom Then
            Dim ZoomBitmapSize As New Size(Convert.ToInt16(OriginalBitmap.Width * ZoomRate), Convert.ToInt16(OriginalBitmap.Height * ZoomRate))
            If AntiAliasing = True Then
                OriginalBitmap = New Bitmap(OriginalBitmap, ZoomBitmapSize)
            Else
                Dim ZoomBitmap As Bitmap = New Bitmap(ZoomBitmapSize.Width, ZoomBitmapSize.Height)
                For y = 1 To ZoomBitmap.Height
                    For x = 1 To ZoomBitmap.Width
                        Dim x2 As Int16 = x / ZoomBitmap.Width * OriginalBitmap.Width - 1
                        Dim y2 As Int16 = y / ZoomBitmap.Height * OriginalBitmap.Height - 1
                        ZoomBitmap.SetPixel(x - 1, y - 1, OriginalBitmap.GetPixel(x2, y2)）
                    Next
                Next
                OriginalBitmap = ZoomBitmap
            End If
            For i = 0 To 1
            Next
        End If
        BitmapTransform = OriginalBitmap
    End Function

    Public Function PointTransform(OriginalPoint As Int32(), Flip As Boolean, Zoom As Boolean, AntiAliasing As Boolean, ZoomRate As Double) As Int32()
        If Flip Then
            OriginalPoint(0) = OriginalPoint(2) - OriginalPoint(0)
        End If
        If Zoom Then
            For i = 0 To 1
                OriginalPoint(i) = Convert.ToInt16((OriginalPoint(i) + 1） * ZoomRate - 1)
                OriginalPoint(i + 2) = Convert.ToInt16(OriginalPoint(i + 2) * ZoomRate)
            Next
        End If
        PointTransform = OriginalPoint
    End Function

    Public Function SHPToBitmap(shpfile As String, Optional shpfile2 As String = "", Optional R As Int32 = 0, Optional G As Int32 = 1, Optional B As Int32 = 2) As Bitmap
        If Not IO.File.Exists(shpfile) Then shpfile = shpfile2
        If IO.File.Exists(shpfile) Then
            Dim Readfailed As Boolean = False
            Dim fs As FileStream = Nothing
            Do
                Try
                    fs = New FileStream(shpfile, FileMode.Open, FileAccess.Read)
                    Readfailed = False
                Catch ' ex As Exception
                    Readfailed = True
                End Try
                Windows.Forms.Application.DoEvents()
            Loop While Readfailed = True
            Dim br As New BinaryReader(fs)
            Dim Width As Int32
            Dim Height As Int32
            Dim POSX As Int32
            Dim POSY As Int32
            Dim Line As Int32()
            Dim Index As Boolean
            Dim Head As Byte()
            If fs.Length > 36 Then
                Head = br.ReadBytes(4) '{84, 76, 72, 83}
            Else
                Head = {0, 0, 0, 0}
            End If
            If Head(0) = 84 AndAlso Head(1) = 76 AndAlso Head(2) = 72 AndAlso Head(3) = 83 Then
                fs.Seek(13, SeekOrigin.Begin)
                Index = br.ReadBoolean
                fs.Seek(20, SeekOrigin.Begin)
                Width = br.ReadInt32
                Height = br.ReadInt32
                POSX = br.ReadInt32
                POSY = br.ReadInt32
                If Index = True Then fs.Seek(80, SeekOrigin.Begin)
                ReDim Line(Height - 1)
                For L = 0 To Line.Count - 1
                    Line(L) = br.ReadInt32
                Next
                SHPToBitmap = New Bitmap(Width, Height)
                For L = 0 To Line.Count - 1
                    If Index = True Then
                        Dim Position As Int32
                        fs.Seek(Line(L), SeekOrigin.Begin)
                        fs.Seek(2, SeekOrigin.Current)
                        Do Until br.ReadUInt16 = 65535
                            fs.Seek(-4, SeekOrigin.Current)
                            Dim lenght As Int16 = br.ReadInt16
                            Dim begin As Int16 = br.ReadInt16
                            Dim Data As Int32 = br.ReadInt32
                            Position = fs.Position
                            fs.Seek(Data, SeekOrigin.Begin)
                            For I = begin To begin + lenght - 1
                                Dim R5G6B5 As UInt16 = br.ReadUInt16
                                SHPToBitmap.SetPixel(I, L, RGB16To24(R5G6B5, R, G, B))
                            Next
                            fs.Seek(Position, SeekOrigin.Begin)
                            fs.Seek(2, SeekOrigin.Current)
                        Loop
                    Else
                        fs.Seek(Line(L), SeekOrigin.Begin)
                        Do Until br.ReadUInt16 = 65535
                            fs.Seek(-2, SeekOrigin.Current)
                            Dim begin As Int16 = br.ReadInt16
                            Dim lenght As Int16 = br.ReadInt16
                            For I = begin To begin + lenght - 1
                                Dim R5G6B5 As UInt16 = br.ReadUInt16
                                SHPToBitmap.SetPixel(I, L, RGB16To24(R5G6B5, R, G, B))
                            Next
                        Loop
                    End If
                Next
            Else
                SHPToBitmap = New Bitmap(1, 1)
            End If
            br.Close()
            fs.Close()
        Else
            SHPToBitmap = New Bitmap(1, 1)
        End If
    End Function

    Public Function BitmapToSHP(bitmap As Bitmap, shpfile As String, Optional POSX As Int32 = 0, Optional POSY As Int32 = 0) As Boolean
        If bitmap Is Nothing Then bitmap = New Bitmap(1, 1)
        Dim fs As New FileStream(shpfile, FileMode.Create)
        Dim bw As New BinaryWriter(fs)
        Dim Width As Int32 = bitmap.Width
        Dim Height As Int32 = bitmap.Height
        Dim Line As Int32()
        'Dim Salute As Byte() = Salutelist(8)
        Dim Header As Byte() = {84, 76, 72, 83, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        bw.Write(Header)
        bw.Write(Width)
        bw.Write(Height)
        bw.Write(POSX)
        bw.Write(POSY)
        ReDim Line(Height - 1)
        For L = 0 To Line.Count - 1
            bw.Write({0, 0, 0, 0})
        Next
        bw.Write({115, 97, 110, 103, 111, 46, 121, 115, 49, 54, 56, 46, 99, 111, 109, 0})
        For L = 0 To Line.Count - 1
            Line(L) = fs.Position
            Dim begin As Int16() = {}
            Dim lenght As Int16() = {}
            Dim Position As Int32() = {}
            Dim Segment As Int16 = 0
            Dim Write As Boolean = False
            For I = 0 To bitmap.Width - 1
                If bitmap.GetPixel(I, L).A > 0 Then
                    If Write = False Then
                        Segment = Segment + 1
                        ReDim Preserve begin(Segment - 1)
                        ReDim Preserve lenght(Segment - 1)
                        ReDim Preserve Position(Segment - 1)
                        begin(Segment - 1) = I
                        lenght(Segment - 1) = 0
                        bw.Write(begin(Segment - 1))
                        Position(Segment - 1) = fs.Position
                        bw.Write(lenght(Segment - 1))
                        Write = True
                    End If
                    Dim R5G6B5 As UInt16 = RGB24To16(bitmap.GetPixel(I, L))
                    bw.Write(R5G6B5)
                    lenght(Segment - 1) = lenght(Segment - 1) + 1
                Else
                    If Write = True Then
                        Write = False
                    End If
                End If
            Next
            For p = 0 To Segment - 1
                fs.Seek(Position(p), SeekOrigin.Begin)
                bw.Write(lenght(p))
            Next
            fs.Seek(L * 4 + 36, SeekOrigin.Begin)
            bw.Write(Line(L))
            fs.Seek(0, SeekOrigin.End)
            bw.Write({255, 255})
        Next
        bw.Close()
        fs.Close()
        BitmapToSHP = True
    End Function

    Public Function BitmapToSmallMap(bitmap As Bitmap, shpfile As String) As Boolean
        If bitmap Is Nothing Then
            bitmap = New Bitmap(382, 270)
        ElseIf bitmap.Height <> 270 OrElse bitmap.Width <> 382 Then
            bitmap = New Bitmap(bitmap, 382, 270)
        End If
        Dim fs As New FileStream(shpfile, FileMode.Create)
        Dim bw As New BinaryWriter(fs)
        For L = 0 To bitmap.Height - 1
            For I = 0 To bitmap.Width - 1
                Dim R5G6B5 As UInt16 = RGB24To16(bitmap.GetPixel(I, L))
                bw.Write(R5G6B5)
            Next
        Next
        bw.Close()
        fs.Close()
        BitmapToSmallMap = True
    End Function

    Public Function SmallMapToBitmap(shpfile As String) As Bitmap
        SmallMapToBitmap = New Bitmap(382, 270)
        If IO.File.Exists(shpfile) Then
            Dim Readfailed As Boolean = False
            Dim fs As FileStream = Nothing
            Do
                Try
                    fs = New FileStream(shpfile, FileMode.Open, FileAccess.Read)
                    Readfailed = False
                Catch ' ex As Exception
                    Readfailed = True
                End Try
                Windows.Forms.Application.DoEvents()
            Loop While Readfailed = True
            Dim br As New BinaryReader(fs)
            Dim y = 0
            Do
                Dim x = 0
                Do
                    Dim R5G6B5 As UInt16 = br.ReadUInt16
                    SmallMapToBitmap.SetPixel(x, y, RGB16To24(R5G6B5))
                    x = x + 1
                Loop Until x >= 382
                y = y + 1
            Loop Until y >= 270
            br.Close()
            fs.Close()
        End If
    End Function

    Public Function GetFontData(fontfile As String) As Int32()
        If IO.File.Exists(fontfile) Then
            Dim fs As FileStream = Nothing
            fs = New FileStream(fontfile, FileMode.Open, FileAccess.Read)
            Dim br As New BinaryReader(fs)
            fs.Seek(52, SeekOrigin.Begin)
            Dim FontSize = br.ReadUInt32
            Dim BitmapSum = br.ReadUInt32
            Dim BitmapLength = br.ReadInt32
            Dim BitmapWidth = br.ReadInt32
            Dim BitmapHeight = br.ReadInt32
            Dim DefaultBegin = br.ReadInt32
            Dim DefaultEnd = br.ReadInt32
            GetFontData = {FontSize, BitmapSum, BitmapLength, BitmapWidth, BitmapHeight, DefaultBegin, DefaultEnd}
            br.Close()
            fs.Close()
        Else
            GetFontData = {0, 0, 0, 0, 0, 0, 0}
        End If
    End Function

    Public Function GetFontIndex(fontfile As String, index As UInt16) As UInt16
        Dim fs As FileStream = Nothing
        fs = New FileStream(fontfile, FileMode.Open, FileAccess.Read)
        Dim br As New BinaryReader(fs)
        fs.Seek(80 + index * 2, SeekOrigin.Begin)
        GetFontIndex = br.ReadUInt16
        br.Close()
        fs.Close()
    End Function

    Public Function FontToBitmap(fontfile As String, index As Int32, fontdata As Int32()) As Bitmap
        FontToBitmap = Nothing
        If IO.File.Exists(fontfile) Then
            Dim fs As FileStream = New FileStream(fontfile, FileMode.Open, FileAccess.Read)
            Dim br As New BinaryReader(fs)
            Dim BitmapPx(fontdata(3), fontdata(4)) As Int32
            FontToBitmap = New Bitmap(fontdata(3), fontdata(4))
            fs.Seek(fontdata(6) + index * fontdata(2) * fontdata(4), SeekOrigin.Begin)
            For y = 0 To fontdata(4) - 1
                For x = 0 To fontdata(2) - 1
                    Dim Pxbyte = br.ReadByte
                    Dim PxHight = Pxbyte \ 16
                    Dim PxLow = Pxbyte Mod 16
                    BitmapPx(x * 2, y) = PxHight
                    BitmapPx(x * 2 + 1, y) = PxLow
                Next
            Next
            For x = 0 To fontdata(3) - 1
                For y = 0 To fontdata(4) - 1
                    Dim FontColor = Color.FromArgb(BitmapPx(x, y) * 16, 0, 0, 0)
                    FontToBitmap.SetPixel(x, y, FontColor)
                Next
            Next
            br.Close()
            fs.Close()
        End If
    End Function

    Public Function FontToDefault(FontFile As String, ImagePath As String, CodePage As Int32) As Boolean
        Dim fs As New System.IO.FileStream(ImagePath + "\Default.idx", System.IO.FileMode.Create)
        Dim bw As New System.IO.BinaryWriter(fs)
        Dim FontData = GetFontData(FontFile)
        bw.Write({255, 254, 0, 0})
        For i = 0 To FontData.Count - 1
            bw.Write(FontData(i))
        Next
        bw.Write({115, 97, 110, 103, 111, 46, 121, 115, 49, 54, 56, 46, 99, 111, 109, 0})
        For i = 0 To 65535
            bw.Write({0, 0})
        Next
        Select Case CodePage
            Case 936
                For big = 129 To 254
                    For little1 = 64 To 126
                        Dim FontString = System.Text.Encoding.GetEncoding(936).GetString({big, little1})
                        Dim FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                        Dim FontIndex As UInt16 = GetFontIndex(FontFile, (big * 256 + little1) - 32768)
                        fs.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                        bw.Write(FontIndex)
                    Next
                    For little2 = 128 To 254
                        Dim FontString = System.Text.Encoding.GetEncoding(936).GetString({big, little2})
                        Dim FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                        Dim FontIndex As UInt16 = GetFontIndex(FontFile, (big * 256 + little2) - 32768)
                        fs.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                        bw.Write(FontIndex)
                    Next
                Next
            Case 950
                For big = 161 To 249
                    For little1 = 64 To 126
                        Dim FontString = System.Text.Encoding.GetEncoding(950).GetString({big, little1})
                        Dim FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                        Dim FontIndex As UInt16 = GetFontIndex(FontFile, (big * 256 + little1) - 32768)
                        fs.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                        bw.Write(FontIndex)
                    Next
                    For little2 = 161 To 254
                        Dim FontString = System.Text.Encoding.GetEncoding(950).GetString({big, little2})
                        Dim FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                        Dim FontIndex As UInt16 = GetFontIndex(FontFile, (big * 256 + little2) - 32768)
                        fs.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                        bw.Write(FontIndex)
                    Next
                Next
            Case Else
                Dim FontString = System.Text.Encoding.GetEncoding(950).GetString({165, 64})
                Dim FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                Dim FontIndex As UInt16 = GetFontIndex(FontFile, (165 * 256 + 64) - 32768)
                fs.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                bw.Write(FontIndex)
        End Select
        bw.Close()
        fs.Close()
        FontToDefault = True
    End Function

    Public Function BitmapToFont(ImagePath As String, FontFile As String, CodePage As Int32, ProgressBar As ProgressBar) As Boolean
        Dim fsx As FileStream = New FileStream(ImagePath + "\Default.idx", FileMode.Open, FileAccess.Read)
        Dim fs As New System.IO.FileStream(FontFile, System.IO.FileMode.Create)
        Dim bw As New System.IO.BinaryWriter(fs)
        Dim br As New BinaryReader(fsx)
        bw.Write({79, 68, 73, 78, 70, 79, 78, 84})
        ProgressBar.Value = 0
        For i = 0 To 10 - 1
            bw.Write(0)
        Next
        bw.Write(136)
        fsx.Seek(4, SeekOrigin.Begin)
        Dim FontData As UInt32() = {0, 0, 0, 0, 0, 0, 0}
        For i = 0 To 7 - 1
            FontData(i) = br.ReadUInt32
            bw.Write(FontData(i))
        Next
        ProgressBar.Maximum = FontData(1) \ 100
        For i = 0 To (FontData(6) - FontData(5)) / 2 - 1
            bw.Write({0, 0})
        Next
        For i = 0 To FontData(1) - 1
            If i Mod 100 = 0 Then
                ProgressBar.Value = i \ 100
            End If
            Dim BitmapBeginPos = i * FontData(2) * FontData(4) + FontData(6)
            fs.Seek(BitmapBeginPos, SeekOrigin.Begin)
            Dim FontBitmap = New Bitmap(ImagePath + "\" + i.ToString + ".png")
            For y = 0 To FontData(4) - 1
                Dim BitmapPx(FontData(3)) As Int32
                For x = 0 To FontData(3) - 1
                    BitmapPx(x) = FontBitmap.GetPixel(x, y).A \ 16
                Next
                For x = 0 To FontData(2) - 1
                    Dim BitmapByte As Byte = BitmapPx(x * 2) * 16 + BitmapPx(x * 2 + 1)
                    bw.Write(BitmapByte)
                Next
            Next
        Next
        ProgressBar.Value = ProgressBar.Maximum
        fsx.Seek(48, SeekOrigin.Begin)
        Select Case CodePage
            Case 950
                For big = 161 To 249
                    For little1 = 64 To 126
                        Dim FontString = System.Text.Encoding.GetEncoding(950).GetString({big, little1})
                        Dim FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                        fsx.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                        Dim FontIndex As UInt16 = br.ReadUInt16
                        If FontIndex = 0 Then
                            FontString = Strings.StrConv(FontString, VbStrConv.SimplifiedChinese)
                            FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                            fsx.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                            FontIndex = br.ReadUInt16
                        End If
                        Dim FontEncodePos = 80 + (big * 256 + little1 - 32768) * 2
                        fs.Seek(FontEncodePos, SeekOrigin.Begin)
                        bw.Write(FontIndex)
                    Next
                    For little2 = 161 To 254
                        Dim FontString = System.Text.Encoding.GetEncoding(950).GetString({big, little2})
                        Dim FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)

                        fsx.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                        Dim FontIndex As UInt16 = br.ReadUInt16
                        If FontIndex = 0 Then
                            FontString = Strings.StrConv(FontString, VbStrConv.SimplifiedChinese)
                            FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                            fsx.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                            FontIndex = br.ReadUInt16
                        End If
                        Dim FontEncodePos = 80 + (big * 256 + little2 - 32768) * 2
                        fs.Seek(FontEncodePos, SeekOrigin.Begin)
                        bw.Write(FontIndex)
                    Next
                Next
            Case 936
                For big = 129 To 254
                    For little1 = 64 To 126
                        Dim FontString = System.Text.Encoding.GetEncoding(936).GetString({big, little1})
                        Dim FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                        fsx.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                        Dim FontIndex As UInt16 = br.ReadUInt16
                        If FontIndex = 0 Then
                            FontString = Strings.StrConv(FontString, VbStrConv.TraditionalChinese)
                            FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                            fsx.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                            FontIndex = br.ReadUInt16
                        End If
                        Dim FontEncodePos = 80 + (big * 256 + little1 - 32768) * 2
                        fs.Seek(FontEncodePos, SeekOrigin.Begin)
                        bw.Write(FontIndex)
                    Next
                    For little2 = 128 To 254
                        Dim FontString = System.Text.Encoding.GetEncoding(936).GetString({big, little2})
                        Dim FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                        fsx.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                        Dim FontIndex As UInt16 = br.ReadUInt16
                        If FontIndex = 0 Then
                            FontString = Strings.StrConv(FontString, VbStrConv.TraditionalChinese)
                            FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                            fsx.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                            FontIndex = br.ReadUInt16
                        End If
                        Dim FontEncodePos = 80 + (big * 256 + little2 - 32768) * 2
                        fs.Seek(FontEncodePos, SeekOrigin.Begin)
                        bw.Write(FontIndex)
                    Next
                Next
            Case Else
                Do While fsx.Position < fsx.Length
                    Dim FontUTF16Big As Byte = br.ReadByte
                    Dim FontUTF16Little As Byte = br.ReadByte
                    Dim BitmapIndex = br.ReadUInt16
                    Dim FontString = System.Text.Encoding.Unicode.GetString({FontUTF16Big, FontUTF16Little})
                    Dim FontEncodeByte = System.Text.Encoding.GetEncoding(CodePage).GetBytes(FontString)
                    If FontEncodeByte.Count < 2 Then
                    Else
                        Dim FontEncodePos = 80 + (FontEncodeByte(0) * 256 + FontEncodeByte(1) - 32768) * 2
                        fs.Seek(FontEncodePos, SeekOrigin.Begin)
                        bw.Write(BitmapIndex)
                    End If
                Loop
        End Select
        bw.Close()
        fs.Close()
        br.Close()
        fsx.Close()
        ProgressBar.Value = 0
        BitmapToFont = True
    End Function
    Public Function CreateFontBitmap(Text As String, FontName As String, FontSize As Int16, Width As Int16, Height As Int16, Optional OffsetX As Int16 = 0, Optional OffsetY As Int16 = 0, Optional IsBold As Boolean = False, Optional IsPixel As Boolean = False, Optional IsDemo As Boolean = False) As Bitmap
        CreateFontBitmap = Nothing
        Dim font As Font
        If IsBold Then
            font = New Font(FontName, FontSize, FontStyle.Bold)
        Else
            font = New Font(FontName, FontSize, FontStyle.Regular)
        End If
        Dim brush As SolidBrush
        brush = New SolidBrush(Color.Black)
        CreateFontBitmap = New Bitmap(Width, Height)
        If IsDemo = True Then
            For x = 0 To Width - 1
                CreateFontBitmap.SetPixel(x, 0, Color.Red)
                CreateFontBitmap.SetPixel(x, Height - 1, Color.Red)
            Next
            For y = 0 To Height - 1
                CreateFontBitmap.SetPixel(0, y, Color.Red)
                CreateFontBitmap.SetPixel(Width - 1, y, Color.Red)
            Next
        End If
        Dim g As Graphics
        g = Graphics.FromImage(CreateFontBitmap)
        Dim rect As RectangleF
        rect = New RectangleF(0 - FontSize * 0.2 + OffsetX, OffsetY, Width * 1.2 + {0, OffsetX}.Max, Height - {0, OffsetY}.Min)
        If IsPixel Then
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.SingleBitPerPixel
        Else
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        End If
        g.DrawString(Text, font, brush, rect)
        g.Dispose()
    End Function

    Public Function NewFontDefault(FontSize As Int32, ImagePath As String, CodePage As Int32, Optional IsASCII As Boolean = False) As Boolean
        Dim fs As New System.IO.FileStream(ImagePath + "\Default.idx", System.IO.FileMode.Create)
        Dim bw As New System.IO.BinaryWriter(fs)
        Dim BitmapSum As Int32
        Dim BitmapLength As Int32 = FontSize / 2
        Dim BitmapWidth As Int32 = FontSize
        Dim BitmapHeight As Int32 = FontSize
        Dim DefaultBegin As Int32 = 80
        Dim DefaultEnd As Int32 = 65616
        bw.Write({255, 254, 0, 0})
        Select Case CodePage
            Case 936
                BitmapSum = ((127 - 64) + (255 - 128)) * (255 - 129)
            Case 950
                BitmapSum = ((127 - 64) + (255 - 161)) * (250 - 161)
            Case Else
                BitmapSum = 1
        End Select
        Dim FontData = {FontSize, BitmapSum, BitmapLength, BitmapWidth, BitmapHeight, DefaultBegin, DefaultEnd}
        For i = 0 To FontData.Count - 1
            bw.Write(FontData(i))
        Next
        bw.Write({115, 97, 110, 103, 111, 46, 121, 115, 49, 54, 56, 46, 99, 111, 109, 0})
        For i = 0 To 65535
            bw.Write({0, 0})
        Next
        Select Case CodePage
            Case 936
                For big = 129 To 254
                    For little1 = 64 To 126
                        Dim BitmapIndex As UInt16 = (big - 129) * 190 + (little1 - 64)
                        Dim FontString = System.Text.Encoding.GetEncoding(936).GetString({big, little1})
                        Dim FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                        fs.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                        bw.Write(BitmapIndex)
                    Next
                    For little2 = 128 To 254
                        Dim BitmapIndex As UInt16 = (big - 129) * 190 + 63 + (little2 - 128)
                        Dim FontString = System.Text.Encoding.GetEncoding(936).GetString({big, little2})
                        Dim FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                        fs.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                        bw.Write(BitmapIndex)
                    Next
                Next
            Case 950
                For big = 161 To 249
                    For little1 = 64 To 126
                        Dim BitmapIndex As UInt16 = (big - 161) * 157 + (little1 - 64)
                        Dim FontString = System.Text.Encoding.GetEncoding(950).GetString({big, little1})
                        Dim FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                        fs.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                        bw.Write(BitmapIndex)
                    Next
                    For little2 = 161 To 254
                        Dim BitmapIndex As UInt16 = (big - 161) * 157 + 63 + (little2 - 161)
                        Dim FontString = System.Text.Encoding.GetEncoding(950).GetString({big, little2})
                        Dim FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                        fs.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                        bw.Write(BitmapIndex)
                    Next
                Next
            Case Else
                Dim BitmapIndex As UInt16 = 0
                Dim FontString = System.Text.Encoding.GetEncoding(950).GetString({165, 64})
                Dim FontByteUnicode = System.Text.Encoding.Unicode.GetBytes(FontString)
                fs.Seek(48 + (FontByteUnicode(1) * 256 + FontByteUnicode(0)) * 2, SeekOrigin.Begin)
                bw.Write(BitmapIndex)
        End Select
        bw.Close()
        fs.Close()
        NewFontDefault = True
    End Function
End Module
