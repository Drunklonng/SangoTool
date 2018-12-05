<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FontTo
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FontTo))
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonFontToBitmapFile = New System.Windows.Forms.Button()
        Me.ButtonFontToBitmapPath = New System.Windows.Forms.Button()
        Me.ButtonFontToBitmap = New System.Windows.Forms.Button()
        Me.TextBoxFontToBitmapFile = New System.Windows.Forms.TextBox()
        Me.TextBoxFontToBitmapPath = New System.Windows.Forms.TextBox()
        Me.CheckBoxFontToBitmapBig5 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFontToBitmapGBK = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.ProgressBarFontToBitmap = New System.Windows.Forms.ProgressBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 9
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.ButtonFontToBitmapFile, 7, 1)
        Me.TableLayoutPanel13.Controls.Add(Me.ButtonFontToBitmapPath, 7, 3)
        Me.TableLayoutPanel13.Controls.Add(Me.ButtonFontToBitmap, 7, 5)
        Me.TableLayoutPanel13.Controls.Add(Me.TextBoxFontToBitmapFile, 1, 1)
        Me.TableLayoutPanel13.Controls.Add(Me.TextBoxFontToBitmapPath, 1, 3)
        Me.TableLayoutPanel13.Controls.Add(Me.CheckBoxFontToBitmapBig5, 1, 5)
        Me.TableLayoutPanel13.Controls.Add(Me.CheckBoxFontToBitmapGBK, 3, 5)
        Me.TableLayoutPanel13.Controls.Add(Me.CheckBox3, 5, 5)
        Me.TableLayoutPanel13.Controls.Add(Me.ProgressBarFontToBitmap, 1, 7)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 9
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(329, 186)
        Me.TableLayoutPanel13.TabIndex = 1
        '
        'ButtonFontToBitmapFile
        '
        Me.ButtonFontToBitmapFile.Location = New System.Drawing.Point(257, 13)
        Me.ButtonFontToBitmapFile.Name = "ButtonFontToBitmapFile"
        Me.ButtonFontToBitmapFile.Size = New System.Drawing.Size(54, 23)
        Me.ButtonFontToBitmapFile.TabIndex = 0
        Me.ButtonFontToBitmapFile.Text = "File"
        Me.ButtonFontToBitmapFile.UseVisualStyleBackColor = True
        '
        'ButtonFontToBitmapPath
        '
        Me.ButtonFontToBitmapPath.Location = New System.Drawing.Point(257, 58)
        Me.ButtonFontToBitmapPath.Name = "ButtonFontToBitmapPath"
        Me.ButtonFontToBitmapPath.Size = New System.Drawing.Size(54, 23)
        Me.ButtonFontToBitmapPath.TabIndex = 1
        Me.ButtonFontToBitmapPath.Text = "Path"
        Me.ButtonFontToBitmapPath.UseVisualStyleBackColor = True
        '
        'ButtonFontToBitmap
        '
        Me.ButtonFontToBitmap.Location = New System.Drawing.Point(257, 103)
        Me.ButtonFontToBitmap.Name = "ButtonFontToBitmap"
        Me.ButtonFontToBitmap.Size = New System.Drawing.Size(54, 23)
        Me.ButtonFontToBitmap.TabIndex = 2
        Me.ButtonFontToBitmap.Text = "Run"
        Me.ButtonFontToBitmap.UseVisualStyleBackColor = True
        '
        'TextBoxFontToBitmapFile
        '
        Me.TableLayoutPanel13.SetColumnSpan(Me.TextBoxFontToBitmapFile, 5)
        Me.TextBoxFontToBitmapFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxFontToBitmapFile.Location = New System.Drawing.Point(17, 13)
        Me.TextBoxFontToBitmapFile.Name = "TextBoxFontToBitmapFile"
        Me.TextBoxFontToBitmapFile.ReadOnly = True
        Me.TextBoxFontToBitmapFile.Size = New System.Drawing.Size(214, 21)
        Me.TextBoxFontToBitmapFile.TabIndex = 3
        '
        'TextBoxFontToBitmapPath
        '
        Me.TableLayoutPanel13.SetColumnSpan(Me.TextBoxFontToBitmapPath, 5)
        Me.TextBoxFontToBitmapPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxFontToBitmapPath.Location = New System.Drawing.Point(17, 58)
        Me.TextBoxFontToBitmapPath.Name = "TextBoxFontToBitmapPath"
        Me.TextBoxFontToBitmapPath.ReadOnly = True
        Me.TextBoxFontToBitmapPath.Size = New System.Drawing.Size(214, 21)
        Me.TextBoxFontToBitmapPath.TabIndex = 4
        '
        'CheckBoxFontToBitmapBig5
        '
        Me.CheckBoxFontToBitmapBig5.AutoSize = True
        Me.CheckBoxFontToBitmapBig5.Checked = True
        Me.CheckBoxFontToBitmapBig5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxFontToBitmapBig5.Location = New System.Drawing.Point(17, 103)
        Me.CheckBoxFontToBitmapBig5.Name = "CheckBoxFontToBitmapBig5"
        Me.CheckBoxFontToBitmapBig5.Size = New System.Drawing.Size(48, 16)
        Me.CheckBoxFontToBitmapBig5.TabIndex = 5
        Me.CheckBoxFontToBitmapBig5.Text = "BIG5"
        Me.CheckBoxFontToBitmapBig5.UseVisualStyleBackColor = True
        '
        'CheckBoxFontToBitmapGBK
        '
        Me.CheckBoxFontToBitmapGBK.AutoSize = True
        Me.CheckBoxFontToBitmapGBK.Location = New System.Drawing.Point(97, 103)
        Me.CheckBoxFontToBitmapGBK.Name = "CheckBoxFontToBitmapGBK"
        Me.CheckBoxFontToBitmapGBK.Size = New System.Drawing.Size(42, 16)
        Me.CheckBoxFontToBitmapGBK.TabIndex = 6
        Me.CheckBoxFontToBitmapGBK.Text = "GBK"
        Me.CheckBoxFontToBitmapGBK.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Location = New System.Drawing.Point(177, 103)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(54, 16)
        Me.CheckBox3.TabIndex = 7
        Me.CheckBox3.Text = "UTF16"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'ProgressBarFontToBitmap
        '
        Me.TableLayoutPanel13.SetColumnSpan(Me.ProgressBarFontToBitmap, 7)
        Me.ProgressBarFontToBitmap.Location = New System.Drawing.Point(17, 148)
        Me.ProgressBarFontToBitmap.Name = "ProgressBarFontToBitmap"
        Me.ProgressBarFontToBitmap.Size = New System.Drawing.Size(294, 23)
        Me.ProgressBarFontToBitmap.TabIndex = 8
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FontTo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 186)
        Me.Controls.Add(Me.TableLayoutPanel13)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(345, 225)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(345, 225)
        Me.Name = "FontTo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FontToBitmap"
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel13.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents ButtonFontToBitmapFile As Button
    Friend WithEvents ButtonFontToBitmapPath As Button
    Friend WithEvents ButtonFontToBitmap As Button
    Friend WithEvents TextBoxFontToBitmapFile As TextBox
    Friend WithEvents TextBoxFontToBitmapPath As TextBox
    Friend WithEvents CheckBoxFontToBitmapBig5 As CheckBox
    Friend WithEvents CheckBoxFontToBitmapGBK As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ProgressBarFontToBitmap As ProgressBar
End Class
