<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewBitmap
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewBitmap))
        Me.ButtonRun = New System.Windows.Forms.Button()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonNewBitmapPath = New System.Windows.Forms.Button()
        Me.ButtonFont = New System.Windows.Forms.Button()
        Me.CheckBoxASCII = New System.Windows.Forms.CheckBox()
        Me.TextBoxNewBitmapPath = New System.Windows.Forms.TextBox()
        Me.CheckBoxPixel = New System.Windows.Forms.CheckBox()
        Me.CheckBoxNewBitmapBig5 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBold = New System.Windows.Forms.CheckBox()
        Me.CheckBoxNewBitmapGBK = New System.Windows.Forms.CheckBox()
        Me.CheckBoxNewBitmapUTF16 = New System.Windows.Forms.CheckBox()
        Me.ProgressBarNewBitmap = New System.Windows.Forms.ProgressBar()
        Me.NumericOffsetY = New System.Windows.Forms.NumericUpDown()
        Me.NumericOffsetX = New System.Windows.Forms.NumericUpDown()
        Me.NumericFontSizePt = New System.Windows.Forms.NumericUpDown()
        Me.NumericFontSizePx = New System.Windows.Forms.NumericUpDown()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ComboBoxConvert = New System.Windows.Forms.ComboBox()
        Me.CheckBoxConvert = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel13.SuspendLayout()
        CType(Me.NumericOffsetY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericOffsetX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericFontSizePt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericFontSizePx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonRun
        '
        Me.ButtonRun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonRun.Location = New System.Drawing.Point(333, 213)
        Me.ButtonRun.Name = "ButtonRun"
        Me.ButtonRun.Size = New System.Drawing.Size(54, 24)
        Me.ButtonRun.TabIndex = 0
        Me.ButtonRun.Text = "Run"
        Me.ButtonRun.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 12
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.TextBoxNewBitmapPath, 1, 9)
        Me.TableLayoutPanel13.Controls.Add(Me.CheckBoxPixel, 3, 7)
        Me.TableLayoutPanel13.Controls.Add(Me.CheckBoxNewBitmapBig5, 1, 11)
        Me.TableLayoutPanel13.Controls.Add(Me.CheckBoxBold, 1, 7)
        Me.TableLayoutPanel13.Controls.Add(Me.CheckBoxNewBitmapGBK, 3, 11)
        Me.TableLayoutPanel13.Controls.Add(Me.CheckBoxNewBitmapUTF16, 5, 11)
        Me.TableLayoutPanel13.Controls.Add(Me.ProgressBarNewBitmap, 1, 13)
        Me.TableLayoutPanel13.Controls.Add(Me.PictureBox1, 1, 1)
        Me.TableLayoutPanel13.Controls.Add(Me.NumericOffsetY, 7, 5)
        Me.TableLayoutPanel13.Controls.Add(Me.NumericOffsetX, 5, 5)
        Me.TableLayoutPanel13.Controls.Add(Me.NumericFontSizePt, 3, 5)
        Me.TableLayoutPanel13.Controls.Add(Me.NumericFontSizePx, 1, 5)
        Me.TableLayoutPanel13.Controls.Add(Me.ButtonFont, 10, 5)
        Me.TableLayoutPanel13.Controls.Add(Me.ButtonNewBitmapPath, 10, 9)
        Me.TableLayoutPanel13.Controls.Add(Me.ButtonRun, 10, 11)
        Me.TableLayoutPanel13.Controls.Add(Me.CheckBoxASCII, 7, 11)
        Me.TableLayoutPanel13.Controls.Add(Me.CheckBoxConvert, 5, 7)
        Me.TableLayoutPanel13.Controls.Add(Me.ComboBoxConvert, 8, 7)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 15
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(404, 291)
        Me.TableLayoutPanel13.TabIndex = 2
        '
        'ButtonNewBitmapPath
        '
        Me.ButtonNewBitmapPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonNewBitmapPath.Location = New System.Drawing.Point(333, 173)
        Me.ButtonNewBitmapPath.Name = "ButtonNewBitmapPath"
        Me.ButtonNewBitmapPath.Size = New System.Drawing.Size(54, 24)
        Me.ButtonNewBitmapPath.TabIndex = 1
        Me.ButtonNewBitmapPath.Text = "Path"
        Me.ButtonNewBitmapPath.UseVisualStyleBackColor = True
        '
        'ButtonFont
        '
        Me.ButtonFont.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonFont.Location = New System.Drawing.Point(333, 93)
        Me.ButtonFont.Name = "ButtonFont"
        Me.ButtonFont.Size = New System.Drawing.Size(54, 24)
        Me.ButtonFont.TabIndex = 9
        Me.ButtonFont.Text = "Font"
        Me.ButtonFont.UseVisualStyleBackColor = True
        '
        'CheckBoxASCII
        '
        Me.CheckBoxASCII.AutoSize = True
        Me.TableLayoutPanel13.SetColumnSpan(Me.CheckBoxASCII, 2)
        Me.CheckBoxASCII.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBoxASCII.Enabled = False
        Me.CheckBoxASCII.Location = New System.Drawing.Point(254, 213)
        Me.CheckBoxASCII.Name = "CheckBoxASCII"
        Me.CheckBoxASCII.Size = New System.Drawing.Size(54, 24)
        Me.CheckBoxASCII.TabIndex = 10
        Me.CheckBoxASCII.Text = "ASCII"
        Me.CheckBoxASCII.UseVisualStyleBackColor = True
        '
        'TextBoxNewBitmapPath
        '
        Me.TableLayoutPanel13.SetColumnSpan(Me.TextBoxNewBitmapPath, 8)
        Me.TextBoxNewBitmapPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxNewBitmapPath.Location = New System.Drawing.Point(17, 173)
        Me.TextBoxNewBitmapPath.Name = "TextBoxNewBitmapPath"
        Me.TextBoxNewBitmapPath.ReadOnly = True
        Me.TextBoxNewBitmapPath.Size = New System.Drawing.Size(291, 21)
        Me.TextBoxNewBitmapPath.TabIndex = 4
        '
        'CheckBoxPixel
        '
        Me.CheckBoxPixel.AutoSize = True
        Me.CheckBoxPixel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBoxPixel.Location = New System.Drawing.Point(96, 133)
        Me.CheckBoxPixel.Name = "CheckBoxPixel"
        Me.CheckBoxPixel.Size = New System.Drawing.Size(54, 24)
        Me.CheckBoxPixel.TabIndex = 16
        Me.CheckBoxPixel.Text = "Pixel"
        Me.CheckBoxPixel.UseVisualStyleBackColor = True
        '
        'CheckBoxNewBitmapBig5
        '
        Me.CheckBoxNewBitmapBig5.AutoSize = True
        Me.CheckBoxNewBitmapBig5.Checked = True
        Me.CheckBoxNewBitmapBig5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxNewBitmapBig5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBoxNewBitmapBig5.Location = New System.Drawing.Point(17, 213)
        Me.CheckBoxNewBitmapBig5.Name = "CheckBoxNewBitmapBig5"
        Me.CheckBoxNewBitmapBig5.Size = New System.Drawing.Size(54, 24)
        Me.CheckBoxNewBitmapBig5.TabIndex = 5
        Me.CheckBoxNewBitmapBig5.Text = "BIG5"
        Me.CheckBoxNewBitmapBig5.UseVisualStyleBackColor = True
        '
        'CheckBoxBold
        '
        Me.CheckBoxBold.AutoSize = True
        Me.CheckBoxBold.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBoxBold.Location = New System.Drawing.Point(17, 133)
        Me.CheckBoxBold.Name = "CheckBoxBold"
        Me.CheckBoxBold.Size = New System.Drawing.Size(54, 24)
        Me.CheckBoxBold.TabIndex = 15
        Me.CheckBoxBold.Text = "Bold"
        Me.CheckBoxBold.UseVisualStyleBackColor = True
        '
        'CheckBoxNewBitmapGBK
        '
        Me.CheckBoxNewBitmapGBK.AutoSize = True
        Me.CheckBoxNewBitmapGBK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBoxNewBitmapGBK.Location = New System.Drawing.Point(96, 213)
        Me.CheckBoxNewBitmapGBK.Name = "CheckBoxNewBitmapGBK"
        Me.CheckBoxNewBitmapGBK.Size = New System.Drawing.Size(54, 24)
        Me.CheckBoxNewBitmapGBK.TabIndex = 6
        Me.CheckBoxNewBitmapGBK.Text = "GBK"
        Me.CheckBoxNewBitmapGBK.UseVisualStyleBackColor = True
        '
        'CheckBoxNewBitmapUTF16
        '
        Me.CheckBoxNewBitmapUTF16.AutoSize = True
        Me.CheckBoxNewBitmapUTF16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBoxNewBitmapUTF16.Enabled = False
        Me.CheckBoxNewBitmapUTF16.Location = New System.Drawing.Point(175, 213)
        Me.CheckBoxNewBitmapUTF16.Name = "CheckBoxNewBitmapUTF16"
        Me.CheckBoxNewBitmapUTF16.Size = New System.Drawing.Size(54, 24)
        Me.CheckBoxNewBitmapUTF16.TabIndex = 7
        Me.CheckBoxNewBitmapUTF16.Text = "UTF16"
        Me.CheckBoxNewBitmapUTF16.UseVisualStyleBackColor = True
        '
        'ProgressBarNewBitmap
        '
        Me.TableLayoutPanel13.SetColumnSpan(Me.ProgressBarNewBitmap, 10)
        Me.ProgressBarNewBitmap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBarNewBitmap.Location = New System.Drawing.Point(17, 253)
        Me.ProgressBarNewBitmap.Name = "ProgressBarNewBitmap"
        Me.ProgressBarNewBitmap.Size = New System.Drawing.Size(370, 24)
        Me.ProgressBarNewBitmap.TabIndex = 8
        '
        'NumericOffsetY
        '
        Me.TableLayoutPanel13.SetColumnSpan(Me.NumericOffsetY, 2)
        Me.NumericOffsetY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumericOffsetY.Location = New System.Drawing.Point(254, 93)
        Me.NumericOffsetY.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericOffsetY.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.NumericOffsetY.Name = "NumericOffsetY"
        Me.NumericOffsetY.Size = New System.Drawing.Size(54, 21)
        Me.NumericOffsetY.TabIndex = 11
        '
        'NumericOffsetX
        '
        Me.NumericOffsetX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumericOffsetX.Location = New System.Drawing.Point(175, 93)
        Me.NumericOffsetX.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericOffsetX.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.NumericOffsetX.Name = "NumericOffsetX"
        Me.NumericOffsetX.Size = New System.Drawing.Size(54, 21)
        Me.NumericOffsetX.TabIndex = 12
        '
        'NumericFontSizePt
        '
        Me.NumericFontSizePt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumericFontSizePt.Location = New System.Drawing.Point(96, 93)
        Me.NumericFontSizePt.Name = "NumericFontSizePt"
        Me.NumericFontSizePt.Size = New System.Drawing.Size(54, 21)
        Me.NumericFontSizePt.TabIndex = 14
        Me.NumericFontSizePt.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'NumericFontSizePx
        '
        Me.NumericFontSizePx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumericFontSizePx.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NumericFontSizePx.Location = New System.Drawing.Point(17, 93)
        Me.NumericFontSizePx.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumericFontSizePx.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumericFontSizePx.Name = "NumericFontSizePx"
        Me.NumericFontSizePx.Size = New System.Drawing.Size(54, 21)
        Me.NumericFontSizePx.TabIndex = 13
        Me.NumericFontSizePx.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'ComboBoxConvert
        '
        Me.TableLayoutPanel13.SetColumnSpan(Me.ComboBoxConvert, 3)
        Me.ComboBoxConvert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxConvert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxConvert.Enabled = False
        Me.ComboBoxConvert.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboBoxConvert.FormattingEnabled = True
        Me.ComboBoxConvert.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ComboBoxConvert.ItemHeight = 12
        Me.ComboBoxConvert.Items.AddRange(New Object() {"Simplified Font", "Traditional Font"})
        Me.ComboBoxConvert.Location = New System.Drawing.Point(267, 135)
        Me.ComboBoxConvert.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBoxConvert.MaxDropDownItems = 2
        Me.ComboBoxConvert.Name = "ComboBoxConvert"
        Me.ComboBoxConvert.Size = New System.Drawing.Size(118, 20)
        Me.ComboBoxConvert.TabIndex = 17
        '
        'CheckBoxConvert
        '
        Me.CheckBoxConvert.AutoSize = True
        Me.TableLayoutPanel13.SetColumnSpan(Me.CheckBoxConvert, 3)
        Me.CheckBoxConvert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBoxConvert.Location = New System.Drawing.Point(175, 133)
        Me.CheckBoxConvert.Name = "CheckBoxConvert"
        Me.CheckBoxConvert.Size = New System.Drawing.Size(84, 24)
        Me.CheckBoxConvert.TabIndex = 18
        Me.CheckBoxConvert.Text = "Convert to"
        Me.CheckBoxConvert.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel13.SetColumnSpan(Me.PictureBox1, 10)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(17, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.TableLayoutPanel13.SetRowSpan(Me.PictureBox1, 3)
        Me.PictureBox1.Size = New System.Drawing.Size(370, 64)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'NewBitmap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 291)
        Me.Controls.Add(Me.TableLayoutPanel13)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(420, 330)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(420, 330)
        Me.Name = "NewBitmap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "NewBitmap"
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel13.PerformLayout()
        CType(Me.NumericOffsetY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericOffsetX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericFontSizePt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericFontSizePx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonRun As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents ButtonNewBitmapPath As Button
    Friend WithEvents TextBoxNewBitmapPath As TextBox
    Friend WithEvents CheckBoxNewBitmapBig5 As CheckBox
    Friend WithEvents CheckBoxNewBitmapGBK As CheckBox
    Friend WithEvents CheckBoxNewBitmapUTF16 As CheckBox
    Friend WithEvents ProgressBarNewBitmap As ProgressBar
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ButtonFont As Button
    Friend WithEvents CheckBoxASCII As CheckBox
    Friend WithEvents NumericOffsetY As NumericUpDown
    Friend WithEvents NumericOffsetX As NumericUpDown
    Friend WithEvents NumericFontSizePx As NumericUpDown
    Friend WithEvents NumericFontSizePt As NumericUpDown
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents CheckBoxBold As CheckBox
    Friend WithEvents CheckBoxPixel As CheckBox
    Friend WithEvents ComboBoxConvert As ComboBox
    Friend WithEvents CheckBoxConvert As CheckBox
End Class
