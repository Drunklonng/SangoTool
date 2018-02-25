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

    Public Function Salutelist(Length As Int16) As Byte()
        Dim str As String() = {"梦去无痕", "拓跋飞雪", "龙潭醉鬼"}
        Dim Rand = New System.Random()
        Dim name As String = Strings.StrConv(str(Rand.Next(str.Length)), VbStrConv.TraditionalChinese)
        Dim bytes = Encoding.GetEncoding(950).GetBytes(name)
        Dim Salute As Byte()
        ReDim Salute(Length - 1)
        For i = 0 To Salute.Length - 1
            If i < bytes.Length Then
                Salute(i) = bytes(i)
            End If
        Next
        Salutelist = Salute
    End Function

    Public Function RGB16To24(R5G6B5 As UInt16) As Color
        Dim str As String = Convert.ToString(R5G6B5, 2)
        Do Until str.Length >= 16
            str = "0" + str
        Loop
        Dim R5 As String = Mid(str, 1, 5)
        Dim G6 As String = Mid(str, 6, 6)
        Dim B5 As String = Mid(str, 12, 5)
        Dim R = Convert.ToInt32(R5 + "000", 2)
        Dim G = Convert.ToInt32(G6 + "00", 2)
        Dim B = Convert.ToInt32(B5 + "000", 2)
        RGB16To24 = Color.FromArgb(R, G, B)
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

    Public Function GetCenterPoint(shpfile As String, Optional shpfile2 As String = "") As Int16()
        Dim CenterPoint As Int16() = {0, 0, 1, 1}
        If Not IO.File.Exists(shpfile) Then shpfile = shpfile2
        If IO.File.Exists(shpfile) Then
            Dim fs As New FileStream(shpfile, FileMode.Open)
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
            Dim SubFileList As String() = IO.Directory.GetFiles(SubPath(i))
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
            Dim SubFileList As String() = IO.Directory.GetFiles(SubPath(i))
            For o = 0 To SubFileList.Count - 1
                ReDim Preserve SubPathList(SubPathList.Count)
                SubPathList(SubPathList.Count - 1) = "\" + str
            Next
        Next
        GetSubPath = SubPathList
    End Function

    Public Function SHPToBitmap(shpfile As String, Optional shpfile2 As String = "") As Bitmap
        If Not IO.File.Exists(shpfile) Then shpfile = shpfile2
        If IO.File.Exists(shpfile) Then
            Dim fs As New FileStream(shpfile, FileMode.Open)
            Dim br As New BinaryReader(fs)
            Dim Width As Int32
            Dim Height As Int32
            Dim POSX As Int32
            Dim POSY As Int32
            Dim Line As Int32()
            Dim Index As Boolean
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
                            SHPToBitmap.SetPixel(I, L, RGB16To24(R5G6B5))
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
                            SHPToBitmap.SetPixel(I, L, RGB16To24(R5G6B5))
                        Next
                    Loop
                End If
            Next
            br.Close()
            fs.Close()
        Else
            SHPToBitmap = New Bitmap(1, 1)
        End If
    End Function

    Public Function BitmapToSHP(bitmap As Bitmap, shpfile As String) As Boolean
        If bitmap Is Nothing Then bitmap = New Bitmap(1, 1)
        Dim fs As New FileStream(shpfile, FileMode.Create)
        Dim bw As New BinaryWriter(fs)
        Dim Width As Int32 = bitmap.Width
        Dim Height As Int32 = bitmap.Height
        Dim POSX As Int32 = 0
        Dim POSY As Int32 = 0
        Dim Line As Int32()
        Dim Salute As Byte() = Salutelist(8)
        Dim Header As Byte() = {84, 76, 72, 83, Salute(0), Salute(1), Salute(2), Salute(3), Salute(4), Salute(5), Salute(6), Salute(7), 0, 0, 0, 0, 173, 80, 183, 113}
        bw.Write(Header)
        bw.Write(Width)
        bw.Write(Height)
        bw.Write(POSX)
        bw.Write(POSY)
        ReDim Line(Height - 1)
        For L = 0 To Line.Count - 1
            bw.Write({0, 0, 0, 0})
        Next
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

End Module
