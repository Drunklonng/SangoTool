<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormatTo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormatTo))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PNGTOSHP = New System.Windows.Forms.RadioButton()
        Me.SHPTOPNG = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.CurrentDirectory = New System.Windows.Forms.RadioButton()
        Me.SelectDirectory = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.WithOffset = New System.Windows.Forms.RadioButton()
        Me.WithoutOffset = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(166, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Format"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PNGTOSHP, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SHPTOPNG, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 13)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(147, 50)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'PNGTOSHP
        '
        Me.PNGTOSHP.AutoSize = True
        Me.PNGTOSHP.Checked = True
        Me.PNGTOSHP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNGTOSHP.Location = New System.Drawing.Point(4, 4)
        Me.PNGTOSHP.Name = "PNGTOSHP"
        Me.PNGTOSHP.Size = New System.Drawing.Size(139, 17)
        Me.PNGTOSHP.TabIndex = 0
        Me.PNGTOSHP.TabStop = True
        Me.PNGTOSHP.Text = "PNG/BMP/JPG TO SHP"
        Me.PNGTOSHP.UseVisualStyleBackColor = True
        '
        'SHPTOPNG
        '
        Me.SHPTOPNG.AutoSize = True
        Me.SHPTOPNG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SHPTOPNG.Location = New System.Drawing.Point(4, 28)
        Me.SHPTOPNG.Name = "SHPTOPNG"
        Me.SHPTOPNG.Size = New System.Drawing.Size(139, 18)
        Me.SHPTOPNG.TabIndex = 1
        Me.SHPTOPNG.TabStop = True
        Me.SHPTOPNG.Text = "SHP TO PNG"
        Me.SHPTOPNG.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.CurrentDirectory, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.SelectDirectory, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(13, 69)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(147, 50)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'CurrentDirectory
        '
        Me.CurrentDirectory.AutoSize = True
        Me.CurrentDirectory.Checked = True
        Me.CurrentDirectory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurrentDirectory.Location = New System.Drawing.Point(4, 4)
        Me.CurrentDirectory.Name = "CurrentDirectory"
        Me.CurrentDirectory.Size = New System.Drawing.Size(139, 17)
        Me.CurrentDirectory.TabIndex = 0
        Me.CurrentDirectory.TabStop = True
        Me.CurrentDirectory.Text = "Current Directory"
        Me.CurrentDirectory.UseVisualStyleBackColor = True
        '
        'SelectDirectory
        '
        Me.SelectDirectory.AutoSize = True
        Me.SelectDirectory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelectDirectory.Location = New System.Drawing.Point(4, 28)
        Me.SelectDirectory.Name = "SelectDirectory"
        Me.SelectDirectory.Size = New System.Drawing.Size(139, 18)
        Me.SelectDirectory.TabIndex = 1
        Me.SelectDirectory.TabStop = True
        Me.SelectDirectory.Text = "Select Directory"
        Me.SelectDirectory.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.WithoutOffset, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.WithOffset, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(166, 13)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(121, 50)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'WithOffset
        '
        Me.WithOffset.AutoSize = True
        Me.WithOffset.Checked = True
        Me.WithOffset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WithOffset.Location = New System.Drawing.Point(4, 4)
        Me.WithOffset.Name = "WithOffset"
        Me.WithOffset.Size = New System.Drawing.Size(113, 17)
        Me.WithOffset.TabIndex = 0
        Me.WithOffset.TabStop = True
        Me.WithOffset.Text = "With Offset"
        Me.WithOffset.UseVisualStyleBackColor = True
        '
        'WithoutOffset
        '
        Me.WithoutOffset.AutoSize = True
        Me.WithoutOffset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WithoutOffset.Location = New System.Drawing.Point(4, 28)
        Me.WithoutOffset.Name = "WithoutOffset"
        Me.WithoutOffset.Size = New System.Drawing.Size(113, 18)
        Me.WithoutOffset.TabIndex = 1
        Me.WithoutOffset.TabStop = True
        Me.WithoutOffset.Text = "Without Offset"
        Me.WithoutOffset.UseVisualStyleBackColor = True
        '
        'FormatTo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 131)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(315, 170)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(315, 170)
        Me.Name = "FormatTo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormatTo"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PNGTOSHP As RadioButton
    Friend WithEvents SHPTOPNG As RadioButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents CurrentDirectory As RadioButton
    Friend WithEvents SelectDirectory As RadioButton
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents WithoutOffset As RadioButton
    Friend WithEvents WithOffset As RadioButton
End Class
