<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SangoTool
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SangoTool))
        Me.BackgroundWorkerOut = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BackgroundWorkerPlay = New System.ComponentModel.BackgroundWorker()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainerFill = New System.Windows.Forms.SplitContainer()
        Me.SplitContainerLeft = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanelUP = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.ButtonNRead = New System.Windows.Forms.Button()
        Me.ButtonShadow = New System.Windows.Forms.Button()
        Me.ButtonTransform = New System.Windows.Forms.Button()
        Me.ButtonOutput = New System.Windows.Forms.Button()
        Me.ButtonOffset = New System.Windows.Forms.Button()
        Me.SplitContainerPlay = New System.Windows.Forms.SplitContainer()
        Me.PictureBoxPlay = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanelPlay = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ButtonPlay = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonLast = New System.Windows.Forms.Button()
        Me.ButtonBorder = New System.Windows.Forms.Button()
        Me.ButtonAxis = New System.Windows.Forms.Button()
        Me.TableLayoutPanelMian = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel0 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.PictureBox0 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainerFill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerFill.Panel1.SuspendLayout()
        Me.SplitContainerFill.Panel2.SuspendLayout()
        Me.SplitContainerFill.SuspendLayout()
        CType(Me.SplitContainerLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerLeft.Panel1.SuspendLayout()
        Me.SplitContainerLeft.Panel2.SuspendLayout()
        Me.SplitContainerLeft.SuspendLayout()
        Me.TableLayoutPanelUP.SuspendLayout()
        CType(Me.SplitContainerPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerPlay.Panel1.SuspendLayout()
        Me.SplitContainerPlay.Panel2.SuspendLayout()
        Me.SplitContainerPlay.SuspendLayout()
        CType(Me.PictureBoxPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelPlay.SuspendLayout()
        Me.TableLayoutPanelMian.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel0.SuspendLayout()
        CType(Me.PictureBox0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackgroundWorkerOut
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 125
        '
        'BackgroundWorkerPlay
        '
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(776, 525)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "License"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel10.ColumnCount = 3
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 460.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(770, 519)
        Me.TableLayoutPanel10.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(158, 4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(454, 511)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainerFill)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(776, 525)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ObjectTool"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainerFill
        '
        Me.SplitContainerFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainerFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerFill.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainerFill.IsSplitterFixed = True
        Me.SplitContainerFill.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainerFill.Name = "SplitContainerFill"
        '
        'SplitContainerFill.Panel1
        '
        Me.SplitContainerFill.Panel1.AutoScroll = True
        Me.SplitContainerFill.Panel1.Controls.Add(Me.SplitContainerLeft)
        '
        'SplitContainerFill.Panel2
        '
        Me.SplitContainerFill.Panel2.Controls.Add(Me.TableLayoutPanelMian)
        Me.SplitContainerFill.Size = New System.Drawing.Size(770, 519)
        Me.SplitContainerFill.SplitterDistance = 600
        Me.SplitContainerFill.TabIndex = 0
        '
        'SplitContainerLeft
        '
        Me.SplitContainerLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainerLeft.IsSplitterFixed = True
        Me.SplitContainerLeft.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerLeft.Name = "SplitContainerLeft"
        Me.SplitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerLeft.Panel1
        '
        Me.SplitContainerLeft.Panel1.Controls.Add(Me.TableLayoutPanelUP)
        '
        'SplitContainerLeft.Panel2
        '
        Me.SplitContainerLeft.Panel2.Controls.Add(Me.SplitContainerPlay)
        Me.SplitContainerLeft.Size = New System.Drawing.Size(600, 519)
        Me.SplitContainerLeft.SplitterDistance = 45
        Me.SplitContainerLeft.TabIndex = 0
        '
        'TableLayoutPanelUP
        '
        Me.TableLayoutPanelUP.ColumnCount = 7
        Me.TableLayoutPanelUP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanelUP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanelUP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanelUP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanelUP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanelUP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanelUP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanelUP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelUP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelUP.Controls.Add(Me.ButtonSave, 2, 0)
        Me.TableLayoutPanelUP.Controls.Add(Me.ButtonNew, 0, 0)
        Me.TableLayoutPanelUP.Controls.Add(Me.ButtonNRead, 1, 0)
        Me.TableLayoutPanelUP.Controls.Add(Me.ButtonShadow, 5, 0)
        Me.TableLayoutPanelUP.Controls.Add(Me.ButtonTransform, 4, 0)
        Me.TableLayoutPanelUP.Controls.Add(Me.ButtonOutput, 3, 0)
        Me.TableLayoutPanelUP.Controls.Add(Me.ButtonOffset, 6, 0)
        Me.TableLayoutPanelUP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelUP.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelUP.Name = "TableLayoutPanelUP"
        Me.TableLayoutPanelUP.RowCount = 1
        Me.TableLayoutPanelUP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelUP.Size = New System.Drawing.Size(598, 43)
        Me.TableLayoutPanelUP.TabIndex = 0
        '
        'ButtonSave
        '
        Me.ButtonSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonSave.Location = New System.Drawing.Point(173, 3)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(79, 37)
        Me.ButtonSave.TabIndex = 5
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonNew
        '
        Me.ButtonNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonNew.Location = New System.Drawing.Point(3, 3)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(79, 37)
        Me.ButtonNew.TabIndex = 6
        Me.ButtonNew.Text = "New"
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'ButtonNRead
        '
        Me.ButtonNRead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonNRead.Location = New System.Drawing.Point(88, 3)
        Me.ButtonNRead.Name = "ButtonNRead"
        Me.ButtonNRead.Size = New System.Drawing.Size(79, 37)
        Me.ButtonNRead.TabIndex = 7
        Me.ButtonNRead.Text = "Read"
        Me.ButtonNRead.UseVisualStyleBackColor = True
        '
        'ButtonShadow
        '
        Me.ButtonShadow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonShadow.Location = New System.Drawing.Point(428, 3)
        Me.ButtonShadow.Name = "ButtonShadow"
        Me.ButtonShadow.Size = New System.Drawing.Size(79, 37)
        Me.ButtonShadow.TabIndex = 10
        Me.ButtonShadow.Text = "Shadow"
        Me.ButtonShadow.UseVisualStyleBackColor = True
        '
        'ButtonTransform
        '
        Me.ButtonTransform.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonTransform.Location = New System.Drawing.Point(343, 3)
        Me.ButtonTransform.Name = "ButtonTransform"
        Me.ButtonTransform.Size = New System.Drawing.Size(79, 37)
        Me.ButtonTransform.TabIndex = 9
        Me.ButtonTransform.Text = "Transform"
        Me.ButtonTransform.UseVisualStyleBackColor = True
        '
        'ButtonOutput
        '
        Me.ButtonOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonOutput.Location = New System.Drawing.Point(258, 3)
        Me.ButtonOutput.Name = "ButtonOutput"
        Me.ButtonOutput.Size = New System.Drawing.Size(79, 37)
        Me.ButtonOutput.TabIndex = 8
        Me.ButtonOutput.Text = "Output"
        Me.ButtonOutput.UseVisualStyleBackColor = True
        '
        'ButtonOffset
        '
        Me.ButtonOffset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonOffset.Location = New System.Drawing.Point(513, 3)
        Me.ButtonOffset.Name = "ButtonOffset"
        Me.ButtonOffset.Size = New System.Drawing.Size(82, 37)
        Me.ButtonOffset.TabIndex = 11
        Me.ButtonOffset.Text = "Offset"
        Me.ButtonOffset.UseVisualStyleBackColor = True
        '
        'SplitContainerPlay
        '
        Me.SplitContainerPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainerPlay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerPlay.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainerPlay.IsSplitterFixed = True
        Me.SplitContainerPlay.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerPlay.Name = "SplitContainerPlay"
        Me.SplitContainerPlay.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerPlay.Panel1
        '
        Me.SplitContainerPlay.Panel1.Controls.Add(Me.PictureBoxPlay)
        '
        'SplitContainerPlay.Panel2
        '
        Me.SplitContainerPlay.Panel2.Controls.Add(Me.TableLayoutPanelPlay)
        Me.SplitContainerPlay.Size = New System.Drawing.Size(600, 470)
        Me.SplitContainerPlay.SplitterDistance = 425
        Me.SplitContainerPlay.TabIndex = 4
        '
        'PictureBoxPlay
        '
        Me.PictureBoxPlay.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxPlay.Name = "PictureBoxPlay"
        Me.PictureBoxPlay.Size = New System.Drawing.Size(0, 0)
        Me.PictureBoxPlay.TabIndex = 1
        Me.PictureBoxPlay.TabStop = False
        '
        'TableLayoutPanelPlay
        '
        Me.TableLayoutPanelPlay.ColumnCount = 7
        Me.TableLayoutPanelPlay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanelPlay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanelPlay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanelPlay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanelPlay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanelPlay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanelPlay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanelPlay.Controls.Add(Me.Label1, 6, 0)
        Me.TableLayoutPanelPlay.Controls.Add(Me.ProgressBar1, 5, 0)
        Me.TableLayoutPanelPlay.Controls.Add(Me.ButtonPlay, 3, 0)
        Me.TableLayoutPanelPlay.Controls.Add(Me.ButtonNext, 4, 0)
        Me.TableLayoutPanelPlay.Controls.Add(Me.ButtonLast, 2, 0)
        Me.TableLayoutPanelPlay.Controls.Add(Me.ButtonBorder, 0, 0)
        Me.TableLayoutPanelPlay.Controls.Add(Me.ButtonAxis, 1, 0)
        Me.TableLayoutPanelPlay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelPlay.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelPlay.Name = "TableLayoutPanelPlay"
        Me.TableLayoutPanelPlay.RowCount = 1
        Me.TableLayoutPanelPlay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanelPlay.Size = New System.Drawing.Size(598, 39)
        Me.TableLayoutPanelPlay.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(513, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(82, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "0/0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(428, 3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(79, 33)
        Me.ProgressBar1.TabIndex = 3
        '
        'ButtonPlay
        '
        Me.ButtonPlay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPlay.Location = New System.Drawing.Point(258, 3)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(79, 33)
        Me.ButtonPlay.TabIndex = 0
        Me.ButtonPlay.Text = "Play"
        Me.ButtonPlay.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        Me.ButtonNext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonNext.Location = New System.Drawing.Point(343, 3)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(79, 33)
        Me.ButtonNext.TabIndex = 4
        Me.ButtonNext.Text = "Next"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonLast
        '
        Me.ButtonLast.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonLast.Location = New System.Drawing.Point(173, 3)
        Me.ButtonLast.Name = "ButtonLast"
        Me.ButtonLast.Size = New System.Drawing.Size(79, 33)
        Me.ButtonLast.TabIndex = 5
        Me.ButtonLast.Text = "Last"
        Me.ButtonLast.UseVisualStyleBackColor = True
        '
        'ButtonBorder
        '
        Me.ButtonBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonBorder.Location = New System.Drawing.Point(3, 3)
        Me.ButtonBorder.Name = "ButtonBorder"
        Me.ButtonBorder.Size = New System.Drawing.Size(79, 33)
        Me.ButtonBorder.TabIndex = 6
        Me.ButtonBorder.Text = "Border"
        Me.ButtonBorder.UseVisualStyleBackColor = True
        '
        'ButtonAxis
        '
        Me.ButtonAxis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAxis.Location = New System.Drawing.Point(88, 3)
        Me.ButtonAxis.Name = "ButtonAxis"
        Me.ButtonAxis.Size = New System.Drawing.Size(79, 33)
        Me.ButtonAxis.TabIndex = 7
        Me.ButtonAxis.Text = "Axis"
        Me.ButtonAxis.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelMian
        '
        Me.TableLayoutPanelMian.ColumnCount = 1
        Me.TableLayoutPanelMian.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMian.Controls.Add(Me.TableLayoutPanel9, 0, 0)
        Me.TableLayoutPanelMian.Controls.Add(Me.TableLayoutPanel8, 0, 1)
        Me.TableLayoutPanelMian.Controls.Add(Me.TableLayoutPanel7, 0, 2)
        Me.TableLayoutPanelMian.Controls.Add(Me.TableLayoutPanel6, 0, 3)
        Me.TableLayoutPanelMian.Controls.Add(Me.TableLayoutPanel5, 0, 4)
        Me.TableLayoutPanelMian.Controls.Add(Me.TableLayoutPanel3, 0, 6)
        Me.TableLayoutPanelMian.Controls.Add(Me.TableLayoutPanel2, 0, 7)
        Me.TableLayoutPanelMian.Controls.Add(Me.TableLayoutPanel1, 0, 8)
        Me.TableLayoutPanelMian.Controls.Add(Me.TableLayoutPanel0, 0, 9)
        Me.TableLayoutPanelMian.Controls.Add(Me.TableLayoutPanel4, 0, 5)
        Me.TableLayoutPanelMian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMian.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelMian.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelMian.Name = "TableLayoutPanelMian"
        Me.TableLayoutPanelMian.RowCount = 10
        Me.TableLayoutPanelMian.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMian.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMian.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMian.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMian.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMian.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMian.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMian.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMian.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMian.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMian.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMian.Size = New System.Drawing.Size(164, 517)
        Me.TableLayoutPanelMian.TabIndex = 1
        Me.TableLayoutPanelMian.Visible = False
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.Button9, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.PictureBox9, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(158, 45)
        Me.TableLayoutPanel9.TabIndex = 4
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(80, 2)
        Me.Button9.Margin = New System.Windows.Forms.Padding(1)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(76, 41)
        Me.Button9.TabIndex = 1
        Me.Button9.Text = "Layer9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox9.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(75, 41)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 0
        Me.PictureBox9.TabStop = False
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Button8, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.PictureBox8, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 54)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(158, 45)
        Me.TableLayoutPanel8.TabIndex = 4
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(80, 2)
        Me.Button8.Margin = New System.Windows.Forms.Padding(1)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(76, 41)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "Layer8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox8.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(75, 41)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 0
        Me.PictureBox8.TabStop = False
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Button7, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.PictureBox7, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 105)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(158, 45)
        Me.TableLayoutPanel7.TabIndex = 4
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(80, 2)
        Me.Button7.Margin = New System.Windows.Forms.Padding(1)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(76, 41)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Layer7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox7.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(75, 41)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Button6, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.PictureBox6, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 156)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(158, 45)
        Me.TableLayoutPanel6.TabIndex = 4
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(80, 2)
        Me.Button6.Margin = New System.Windows.Forms.Padding(1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(76, 41)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Layer6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox6.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(75, 41)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Button5, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.PictureBox5, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 207)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(158, 45)
        Me.TableLayoutPanel5.TabIndex = 4
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(80, 2)
        Me.Button5.Margin = New System.Windows.Forms.Padding(1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(76, 41)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Layer5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox5.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(75, 41)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Button3, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox3, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 309)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(158, 45)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(80, 2)
        Me.Button3.Margin = New System.Windows.Forms.Padding(1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 41)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Layer3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 41)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 360)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(158, 45)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(80, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 41)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Layer2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.87719!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.12281!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 411)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(158, 45)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(81, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Layer1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel0
        '
        Me.TableLayoutPanel0.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel0.ColumnCount = 2
        Me.TableLayoutPanel0.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel0.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel0.Controls.Add(Me.Button0, 1, 0)
        Me.TableLayoutPanel0.Controls.Add(Me.PictureBox0, 0, 0)
        Me.TableLayoutPanel0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel0.Location = New System.Drawing.Point(3, 462)
        Me.TableLayoutPanel0.Name = "TableLayoutPanel0"
        Me.TableLayoutPanel0.RowCount = 1
        Me.TableLayoutPanel0.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel0.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel0.Size = New System.Drawing.Size(158, 52)
        Me.TableLayoutPanel0.TabIndex = 0
        '
        'Button0
        '
        Me.Button0.BackColor = System.Drawing.Color.Transparent
        Me.Button0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button0.FlatAppearance.BorderSize = 0
        Me.Button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button0.Location = New System.Drawing.Point(80, 2)
        Me.Button0.Margin = New System.Windows.Forms.Padding(1)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(76, 48)
        Me.Button0.TabIndex = 1
        Me.Button0.Text = "Layer0"
        Me.Button0.UseVisualStyleBackColor = False
        '
        'PictureBox0
        '
        Me.PictureBox0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox0.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox0.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox0.Name = "PictureBox0"
        Me.PictureBox0.Size = New System.Drawing.Size(75, 48)
        Me.PictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox0.TabIndex = 0
        Me.PictureBox0.TabStop = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Button4, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.PictureBox4, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 258)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(158, 45)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(80, 2)
        Me.Button4.Margin = New System.Windows.Forms.Padding(1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 41)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Layer4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox4.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(75, 41)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(100, 28)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 561)
        Me.TabControl1.TabIndex = 0
        '
        'Timer2
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer3
        '
        '
        'SangoTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "SangoTool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SangoTool"
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainerFill.Panel1.ResumeLayout(False)
        Me.SplitContainerFill.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerFill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerFill.ResumeLayout(False)
        Me.SplitContainerLeft.Panel1.ResumeLayout(False)
        Me.SplitContainerLeft.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerLeft.ResumeLayout(False)
        Me.TableLayoutPanelUP.ResumeLayout(False)
        Me.SplitContainerPlay.Panel1.ResumeLayout(False)
        Me.SplitContainerPlay.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerPlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerPlay.ResumeLayout(False)
        CType(Me.PictureBoxPlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelPlay.ResumeLayout(False)
        Me.TableLayoutPanelPlay.PerformLayout()
        Me.TableLayoutPanelMian.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel8.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel0.ResumeLayout(False)
        CType(Me.PictureBox0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorkerOut As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BackgroundWorkerPlay As System.ComponentModel.BackgroundWorker
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents SplitContainerFill As SplitContainer
    Friend WithEvents SplitContainerLeft As SplitContainer
    Friend WithEvents TableLayoutPanelUP As TableLayoutPanel
    Friend WithEvents ButtonPlay As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonNew As Button
    Friend WithEvents ButtonNRead As Button
    Friend WithEvents ButtonOutput As Button
    Friend WithEvents ButtonTransform As Button
    Friend WithEvents ButtonShadow As Button
    Friend WithEvents TableLayoutPanelMian As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents Button9 As Button
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Button8 As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Button7 As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel0 As TableLayoutPanel
    Friend WithEvents Button0 As Button
    Friend WithEvents PictureBox0 As PictureBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents PictureBoxPlay As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanelPlay As TableLayoutPanel
    Friend WithEvents SplitContainerPlay As SplitContainer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonLast As Button
    Friend WithEvents ButtonBorder As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ButtonAxis As Button
    Friend WithEvents ButtonOffset As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer3 As Timer
End Class
