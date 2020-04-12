<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LanguageText
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
        Me.SetSelectPath = New System.Windows.Forms.Label()
        Me.SetAllString2 = New System.Windows.Forms.Label()
        Me.SetAllString1 = New System.Windows.Forms.Label()
        Me.FileLarge = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SetSelectPath
        '
        Me.SetSelectPath.AutoSize = True
        Me.SetSelectPath.Location = New System.Drawing.Point(12, 21)
        Me.SetSelectPath.Name = "SetSelectPath"
        Me.SetSelectPath.Size = New System.Drawing.Size(191, 12)
        Me.SetSelectPath.TabIndex = 0
        Me.SetSelectPath.Text = "Please choose the correct path!"
        '
        'SetAllString2
        '
        Me.SetAllString2.AutoSize = True
        Me.SetAllString2.Location = New System.Drawing.Point(71, 9)
        Me.SetAllString2.Name = "SetAllString2"
        Me.SetAllString2.Size = New System.Drawing.Size(53, 12)
        Me.SetAllString2.TabIndex = 1
        Me.SetAllString2.Text = " files ?"
        '
        'SetAllString1
        '
        Me.SetAllString1.AutoSize = True
        Me.SetAllString1.Location = New System.Drawing.Point(12, 9)
        Me.SetAllString1.Name = "SetAllString1"
        Me.SetAllString1.Size = New System.Drawing.Size(53, 12)
        Me.SetAllString1.TabIndex = 2
        Me.SetAllString1.Text = "Set all "
        '
        'FileLarge
        '
        Me.FileLarge.AutoSize = True
        Me.FileLarge.Location = New System.Drawing.Point(12, 33)
        Me.FileLarge.Name = "FileLarge"
        Me.FileLarge.Size = New System.Drawing.Size(113, 12)
        Me.FileLarge.TabIndex = 3
        Me.FileLarge.Text = "File is too large!"
        '
        'LanguageText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 450)
        Me.Controls.Add(Me.FileLarge)
        Me.Controls.Add(Me.SetAllString1)
        Me.Controls.Add(Me.SetAllString2)
        Me.Controls.Add(Me.SetSelectPath)
        Me.Name = "LanguageText"
        Me.Text = "LanguageText"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SetSelectPath As Label
    Friend WithEvents SetAllString2 As Label
    Friend WithEvents SetAllString1 As Label
    Friend WithEvents FileLarge As Label
End Class
