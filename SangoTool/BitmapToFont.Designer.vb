<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToFont
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToFont))
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonBitmapToFontPath = New System.Windows.Forms.Button()
        Me.ButtonBitmapToFontFile = New System.Windows.Forms.Button()
        Me.ButtonBitmapToFont = New System.Windows.Forms.Button()
        Me.TextBoxBitmapToFontPath = New System.Windows.Forms.TextBox()
        Me.TextBoxBitmapToFontFile = New System.Windows.Forms.TextBox()
        Me.CheckBoxBitmapToFontBig5 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBitmapToFontGBK = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBitmapToFontUTF16 = New System.Windows.Forms.CheckBox()
        Me.ProgressBarBitmapToFont = New System.Windows.Forms.ProgressBar()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
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
        Me.TableLayoutPanel13.Controls.Add(Me.ButtonBitmapToFontPath, 7, 1)
        Me.TableLayoutPanel13.Controls.Add(Me.ButtonBitmapToFontFile, 7, 3)
        Me.TableLayoutPanel13.Controls.Add(Me.ButtonBitmapToFont, 7, 5)
        Me.TableLayoutPanel13.Controls.Add(Me.TextBoxBitmapToFontPath, 1, 1)
        Me.TableLayoutPanel13.Controls.Add(Me.TextBoxBitmapToFontFile, 1, 3)
        Me.TableLayoutPanel13.Controls.Add(Me.CheckBoxBitmapToFontBig5, 1, 5)
        Me.TableLayoutPanel13.Controls.Add(Me.CheckBoxBitmapToFontGBK, 3, 5)
        Me.TableLayoutPanel13.Controls.Add(Me.CheckBoxBitmapToFontUTF16, 5, 5)
        Me.TableLayoutPanel13.Controls.Add(Me.ProgressBarBitmapToFont, 1, 7)
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
        Me.TableLayoutPanel13.TabIndex = 2
        '
        'ButtonBitmapToFontPath
        '
        Me.ButtonBitmapToFontPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonBitmapToFontPath.Location = New System.Drawing.Point(257, 13)
        Me.ButtonBitmapToFontPath.Name = "ButtonBitmapToFontPath"
        Me.ButtonBitmapToFontPath.Size = New System.Drawing.Size(54, 24)
        Me.ButtonBitmapToFontPath.TabIndex = 0
        Me.ButtonBitmapToFontPath.Text = "Path"
        Me.ButtonBitmapToFontPath.UseVisualStyleBackColor = True
        '
        'ButtonBitmapToFontFile
        '
        Me.ButtonBitmapToFontFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonBitmapToFontFile.Location = New System.Drawing.Point(257, 58)
        Me.ButtonBitmapToFontFile.Name = "ButtonBitmapToFontFile"
        Me.ButtonBitmapToFontFile.Size = New System.Drawing.Size(54, 24)
        Me.ButtonBitmapToFontFile.TabIndex = 1
        Me.ButtonBitmapToFontFile.Text = "File"
        Me.ButtonBitmapToFontFile.UseVisualStyleBackColor = True
        '
        'ButtonBitmapToFont
        '
        Me.ButtonBitmapToFont.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonBitmapToFont.Location = New System.Drawing.Point(257, 103)
        Me.ButtonBitmapToFont.Name = "ButtonBitmapToFont"
        Me.ButtonBitmapToFont.Size = New System.Drawing.Size(54, 24)
        Me.ButtonBitmapToFont.TabIndex = 2
        Me.ButtonBitmapToFont.Text = "Run"
        Me.ButtonBitmapToFont.UseVisualStyleBackColor = True
        '
        'TextBoxBitmapToFontPath
        '
        Me.TableLayoutPanel13.SetColumnSpan(Me.TextBoxBitmapToFontPath, 5)
        Me.TextBoxBitmapToFontPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxBitmapToFontPath.Location = New System.Drawing.Point(17, 13)
        Me.TextBoxBitmapToFontPath.Name = "TextBoxBitmapToFontPath"
        Me.TextBoxBitmapToFontPath.ReadOnly = True
        Me.TextBoxBitmapToFontPath.Size = New System.Drawing.Size(214, 21)
        Me.TextBoxBitmapToFontPath.TabIndex = 3
        '
        'TextBoxBitmapToFontFile
        '
        Me.TableLayoutPanel13.SetColumnSpan(Me.TextBoxBitmapToFontFile, 5)
        Me.TextBoxBitmapToFontFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxBitmapToFontFile.Location = New System.Drawing.Point(17, 58)
        Me.TextBoxBitmapToFontFile.Name = "TextBoxBitmapToFontFile"
        Me.TextBoxBitmapToFontFile.ReadOnly = True
        Me.TextBoxBitmapToFontFile.Size = New System.Drawing.Size(214, 21)
        Me.TextBoxBitmapToFontFile.TabIndex = 4
        '
        'CheckBoxBitmapToFontBig5
        '
        Me.CheckBoxBitmapToFontBig5.AutoSize = True
        Me.CheckBoxBitmapToFontBig5.Checked = True
        Me.CheckBoxBitmapToFontBig5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxBitmapToFontBig5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBoxBitmapToFontBig5.Location = New System.Drawing.Point(17, 103)
        Me.CheckBoxBitmapToFontBig5.Name = "CheckBoxBitmapToFontBig5"
        Me.CheckBoxBitmapToFontBig5.Size = New System.Drawing.Size(54, 24)
        Me.CheckBoxBitmapToFontBig5.TabIndex = 5
        Me.CheckBoxBitmapToFontBig5.Text = "BIG5"
        Me.CheckBoxBitmapToFontBig5.UseVisualStyleBackColor = True
        '
        'CheckBoxBitmapToFontGBK
        '
        Me.CheckBoxBitmapToFontGBK.AutoSize = True
        Me.CheckBoxBitmapToFontGBK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBoxBitmapToFontGBK.Location = New System.Drawing.Point(97, 103)
        Me.CheckBoxBitmapToFontGBK.Name = "CheckBoxBitmapToFontGBK"
        Me.CheckBoxBitmapToFontGBK.Size = New System.Drawing.Size(54, 24)
        Me.CheckBoxBitmapToFontGBK.TabIndex = 6
        Me.CheckBoxBitmapToFontGBK.Text = "GBK"
        Me.CheckBoxBitmapToFontGBK.UseVisualStyleBackColor = True
        '
        'CheckBoxBitmapToFontUTF16
        '
        Me.CheckBoxBitmapToFontUTF16.AutoSize = True
        Me.CheckBoxBitmapToFontUTF16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBoxBitmapToFontUTF16.Enabled = False
        Me.CheckBoxBitmapToFontUTF16.Location = New System.Drawing.Point(177, 103)
        Me.CheckBoxBitmapToFontUTF16.Name = "CheckBoxBitmapToFontUTF16"
        Me.CheckBoxBitmapToFontUTF16.Size = New System.Drawing.Size(54, 24)
        Me.CheckBoxBitmapToFontUTF16.TabIndex = 7
        Me.CheckBoxBitmapToFontUTF16.Text = "UTF16"
        Me.CheckBoxBitmapToFontUTF16.UseVisualStyleBackColor = True
        '
        'ProgressBarBitmapToFont
        '
        Me.TableLayoutPanel13.SetColumnSpan(Me.ProgressBarBitmapToFont, 7)
        Me.ProgressBarBitmapToFont.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBarBitmapToFont.Location = New System.Drawing.Point(17, 148)
        Me.ProgressBarBitmapToFont.Name = "ProgressBarBitmapToFont"
        Me.ProgressBarBitmapToFont.Size = New System.Drawing.Size(294, 24)
        Me.ProgressBarBitmapToFont.TabIndex = 8
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Font File|*.fnt"
        '
        'ToFont
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
        Me.Name = "ToFont"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BitmapToFont"
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel13.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents ButtonBitmapToFontPath As Button
    Friend WithEvents ButtonBitmapToFontFile As Button
    Friend WithEvents ButtonBitmapToFont As Button
    Friend WithEvents TextBoxBitmapToFontPath As TextBox
    Friend WithEvents TextBoxBitmapToFontFile As TextBox
    Friend WithEvents CheckBoxBitmapToFontBig5 As CheckBox
    Friend WithEvents CheckBoxBitmapToFontGBK As CheckBox
    Friend WithEvents CheckBoxBitmapToFontUTF16 As CheckBox
    Friend WithEvents ProgressBarBitmapToFont As ProgressBar
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
