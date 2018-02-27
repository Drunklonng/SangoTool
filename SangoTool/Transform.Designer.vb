<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transform
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
        Me.ZoomTrue = New System.Windows.Forms.RadioButton()
        Me.ZoomFalse = New System.Windows.Forms.RadioButton()
        Me.FlipTrue = New System.Windows.Forms.RadioButton()
        Me.FlipFalse = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDownZoom = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.AntiAliasingFalse = New System.Windows.Forms.RadioButton()
        Me.AntiAliasingTrue = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.NumericUpDownZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'ZoomTrue
        '
        Me.ZoomTrue.AutoSize = True
        Me.ZoomTrue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ZoomTrue.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ZoomTrue.Location = New System.Drawing.Point(64, 4)
        Me.ZoomTrue.Name = "ZoomTrue"
        Me.ZoomTrue.Size = New System.Drawing.Size(43, 20)
        Me.ZoomTrue.TabIndex = 2
        Me.ZoomTrue.Text = "ON"
        Me.ZoomTrue.UseVisualStyleBackColor = True
        '
        'ZoomFalse
        '
        Me.ZoomFalse.AutoSize = True
        Me.ZoomFalse.Checked = True
        Me.ZoomFalse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ZoomFalse.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ZoomFalse.Location = New System.Drawing.Point(114, 4)
        Me.ZoomFalse.Name = "ZoomFalse"
        Me.ZoomFalse.Size = New System.Drawing.Size(44, 20)
        Me.ZoomFalse.TabIndex = 3
        Me.ZoomFalse.TabStop = True
        Me.ZoomFalse.Text = "OFF"
        Me.ZoomFalse.UseVisualStyleBackColor = True
        '
        'FlipTrue
        '
        Me.FlipTrue.AutoSize = True
        Me.FlipTrue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlipTrue.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FlipTrue.Location = New System.Drawing.Point(64, 4)
        Me.FlipTrue.Name = "FlipTrue"
        Me.FlipTrue.Size = New System.Drawing.Size(43, 20)
        Me.FlipTrue.TabIndex = 4
        Me.FlipTrue.Text = "ON"
        Me.FlipTrue.UseVisualStyleBackColor = True
        '
        'FlipFalse
        '
        Me.FlipFalse.AutoSize = True
        Me.FlipFalse.Checked = True
        Me.FlipFalse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlipFalse.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FlipFalse.Location = New System.Drawing.Point(114, 4)
        Me.FlipFalse.Name = "FlipFalse"
        Me.FlipFalse.Size = New System.Drawing.Size(44, 20)
        Me.FlipFalse.TabIndex = 5
        Me.FlipFalse.TabStop = True
        Me.FlipFalse.Text = "OFF"
        Me.FlipFalse.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlipTrue, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlipFalse, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 96)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(162, 28)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = " FLIP :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25!))
        Me.TableLayoutPanel2.Controls.Add(Me.ZoomTrue, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ZoomFalse, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 62)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(162, 28)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 26)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = " ZOOM :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = " Zoom Rate :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDownZoom
        '
        Me.NumericUpDownZoom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumericUpDownZoom.Location = New System.Drawing.Point(110, 4)
        Me.NumericUpDownZoom.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NumericUpDownZoom.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDownZoom.Name = "NumericUpDownZoom"
        Me.NumericUpDownZoom.Size = New System.Drawing.Size(67, 21)
        Me.NumericUpDownZoom.TabIndex = 9
        Me.NumericUpDownZoom.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(184, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "%"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 1
        Me.TrackBar1.Location = New System.Drawing.Point(4, 4)
        Me.TrackBar1.Maximum = 200
        Me.TrackBar1.Minimum = 50
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(374, 34)
        Me.TrackBar1.TabIndex = 8
        Me.TrackBar1.Value = 100
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TrackBar1, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(12, 14)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(382, 42)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(237, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 28)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(318, 130)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 28)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.AntiAliasingFalse, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.AntiAliasingTrue, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(180, 96)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(214, 28)
        Me.TableLayoutPanel4.TabIndex = 12
        '
        'AntiAliasingFalse
        '
        Me.AntiAliasingFalse.AutoSize = True
        Me.AntiAliasingFalse.Checked = True
        Me.AntiAliasingFalse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AntiAliasingFalse.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.AntiAliasingFalse.Location = New System.Drawing.Point(163, 4)
        Me.AntiAliasingFalse.Name = "AntiAliasingFalse"
        Me.AntiAliasingFalse.Size = New System.Drawing.Size(47, 20)
        Me.AntiAliasingFalse.TabIndex = 7
        Me.AntiAliasingFalse.TabStop = True
        Me.AntiAliasingFalse.Text = "OFF"
        Me.AntiAliasingFalse.UseVisualStyleBackColor = True
        '
        'AntiAliasingTrue
        '
        Me.AntiAliasingTrue.AutoSize = True
        Me.AntiAliasingTrue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AntiAliasingTrue.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.AntiAliasingTrue.Location = New System.Drawing.Point(110, 4)
        Me.AntiAliasingTrue.Name = "AntiAliasingTrue"
        Me.AntiAliasingTrue.Size = New System.Drawing.Size(46, 20)
        Me.AntiAliasingTrue.TabIndex = 6
        Me.AntiAliasingTrue.Text = "ON"
        Me.AntiAliasingTrue.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 26)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Anti Aliasing :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.NumericUpDownZoom, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(180, 62)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(214, 28)
        Me.TableLayoutPanel5.TabIndex = 13
        '
        'Transform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 168)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 350)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(200, 150)
        Me.Name = "Transform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transform"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.NumericUpDownZoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ZoomTrue As RadioButton
    Friend WithEvents ZoomFalse As RadioButton
    Friend WithEvents FlipTrue As RadioButton
    Friend WithEvents FlipFalse As RadioButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents NumericUpDownZoom As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents AntiAliasingFalse As RadioButton
    Friend WithEvents AntiAliasingTrue As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
End Class
