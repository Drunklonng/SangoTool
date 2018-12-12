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
        Me.License = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ObjectTool = New System.Windows.Forms.TabPage()
        Me.SplitContainerFill = New System.Windows.Forms.SplitContainer()
        Me.SplitContainerLeft = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanelUP = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.ButtonShadow = New System.Windows.Forms.Button()
        Me.ButtonTransform = New System.Windows.Forms.Button()
        Me.ButtonOutput = New System.Windows.Forms.Button()
        Me.ButtonOffset = New System.Windows.Forms.Button()
        Me.SplitContainerPlay = New System.Windows.Forms.SplitContainer()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LastTo0ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Last10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBoxPlay = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanelPlay = New System.Windows.Forms.TableLayoutPanel()
        Me.Playback = New System.Windows.Forms.Label()
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
        Me.ImageTool = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.TreeViewImagePath = New System.Windows.Forms.TreeView()
        Me.TextBoxImagePath = New System.Windows.Forms.TextBox()
        Me.ProgressBarFormat = New System.Windows.Forms.ProgressBar()
        Me.LabelFormat = New System.Windows.Forms.Label()
        Me.ButtonImagePath = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PictureBoxImageView = New System.Windows.Forms.PictureBox()
        Me.ListViewImage = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetOffsetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenInExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FontTool = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel18 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonBitmapToFont = New System.Windows.Forms.Button()
        Me.ButtonFontToBitmap = New System.Windows.Forms.Button()
        Me.MapTool = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonSmallMap = New System.Windows.Forms.Button()
        Me.ScriptTool = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Readme = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel16 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTIM = New System.Windows.Forms.Label()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LabelGitHub = New System.Windows.Forms.Label()
        Me.LabelBaidu = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelDownload = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.PictureBoxWeChat = New System.Windows.Forms.PictureBox()
        Me.LabelWeChat = New System.Windows.Forms.Label()
        Me.TableLayoutPanel17 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonEN = New System.Windows.Forms.Button()
        Me.ButtonSC = New System.Windows.Forms.Button()
        Me.ButtonTC = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.SettingTool = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel19 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel20 = New System.Windows.Forms.TableLayoutPanel()
        Me.License.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.ObjectTool.SuspendLayout()
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
        Me.ContextMenuStrip1.SuspendLayout()
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
        Me.ImageTool.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PictureBoxImageView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.FontTool.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.TableLayoutPanel18.SuspendLayout()
        Me.MapTool.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.ScriptTool.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        Me.Readme.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel16.SuspendLayout()
        CType(Me.PictureBoxWeChat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel17.SuspendLayout()
        Me.SettingTool.SuspendLayout()
        Me.TableLayoutPanel19.SuspendLayout()
        Me.TableLayoutPanel20.SuspendLayout()
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
        'License
        '
        Me.License.Controls.Add(Me.TableLayoutPanel10)
        Me.License.Location = New System.Drawing.Point(4, 32)
        Me.License.Name = "License"
        Me.License.Padding = New System.Windows.Forms.Padding(3)
        Me.License.Size = New System.Drawing.Size(776, 525)
        Me.License.TabIndex = 1
        Me.License.Text = "License"
        Me.License.UseVisualStyleBackColor = True
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
        'ObjectTool
        '
        Me.ObjectTool.Controls.Add(Me.SplitContainerFill)
        Me.ObjectTool.Location = New System.Drawing.Point(4, 32)
        Me.ObjectTool.Name = "ObjectTool"
        Me.ObjectTool.Padding = New System.Windows.Forms.Padding(3)
        Me.ObjectTool.Size = New System.Drawing.Size(776, 525)
        Me.ObjectTool.TabIndex = 0
        Me.ObjectTool.Text = "ObjectTool"
        Me.ObjectTool.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanelUP.Controls.Add(Me.ButtonRead, 1, 0)
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
        'ButtonRead
        '
        Me.ButtonRead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonRead.Location = New System.Drawing.Point(88, 3)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(79, 37)
        Me.ButtonRead.TabIndex = 7
        Me.ButtonRead.Text = "Read"
        Me.ButtonRead.UseVisualStyleBackColor = True
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
        Me.SplitContainerPlay.Panel1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.SplitContainerPlay.Panel1.Controls.Add(Me.PictureBoxPlay)
        '
        'SplitContainerPlay.Panel2
        '
        Me.SplitContainerPlay.Panel2.Controls.Add(Me.TableLayoutPanelPlay)
        Me.SplitContainerPlay.Size = New System.Drawing.Size(600, 470)
        Me.SplitContainerPlay.SplitterDistance = 425
        Me.SplitContainerPlay.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.LastTo0ToolStripMenuItem, Me.Last10ToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.EndToolStripMenuItem})
        Me.ContextMenuStrip1.Margin = New System.Windows.Forms.Padding(100)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 136)
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.BackToolStripMenuItem.Text = "Begin"
        '
        'LastTo0ToolStripMenuItem
        '
        Me.LastTo0ToolStripMenuItem.Name = "LastTo0ToolStripMenuItem"
        Me.LastTo0ToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.LastTo0ToolStripMenuItem.Text = "-50"
        '
        'Last10ToolStripMenuItem
        '
        Me.Last10ToolStripMenuItem.Name = "Last10ToolStripMenuItem"
        Me.Last10ToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.Last10ToolStripMenuItem.Text = "-10"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(109, 22)
        Me.ToolStripMenuItem2.Text = "+10"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(109, 22)
        Me.ToolStripMenuItem3.Text = "+50"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.EndToolStripMenuItem.Text = "End"
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
        Me.TableLayoutPanelPlay.Controls.Add(Me.Playback, 6, 0)
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
        'Playback
        '
        Me.Playback.AutoSize = True
        Me.Playback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Playback.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Playback.Location = New System.Drawing.Point(513, 0)
        Me.Playback.Name = "Playback"
        Me.Playback.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Playback.Size = New System.Drawing.Size(82, 39)
        Me.Playback.TabIndex = 2
        Me.Playback.Text = "0/0"
        Me.Playback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.ButtonLast.ContextMenuStrip = Me.ContextMenuStrip1
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
        Me.TabControl1.Controls.Add(Me.ObjectTool)
        Me.TabControl1.Controls.Add(Me.ImageTool)
        Me.TabControl1.Controls.Add(Me.FontTool)
        Me.TabControl1.Controls.Add(Me.MapTool)
        Me.TabControl1.Controls.Add(Me.ScriptTool)
        Me.TabControl1.Controls.Add(Me.SettingTool)
        Me.TabControl1.Controls.Add(Me.License)
        Me.TabControl1.Controls.Add(Me.Readme)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(100, 28)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 561)
        Me.TabControl1.TabIndex = 0
        '
        'ImageTool
        '
        Me.ImageTool.Controls.Add(Me.SplitContainer1)
        Me.ImageTool.Location = New System.Drawing.Point(4, 32)
        Me.ImageTool.Name = "ImageTool"
        Me.ImageTool.Size = New System.Drawing.Size(776, 525)
        Me.ImageTool.TabIndex = 6
        Me.ImageTool.Text = "ImageTool"
        Me.ImageTool.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel12)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(776, 525)
        Me.SplitContainer1.SplitterDistance = 220
        Me.SplitContainer1.TabIndex = 4
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 3
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.TreeViewImagePath, 0, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.TextBoxImagePath, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.ProgressBarFormat, 0, 2)
        Me.TableLayoutPanel12.Controls.Add(Me.LabelFormat, 1, 2)
        Me.TableLayoutPanel12.Controls.Add(Me.ButtonImagePath, 2, 0)
        Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 3
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(220, 525)
        Me.TableLayoutPanel12.TabIndex = 0
        '
        'TreeViewImagePath
        '
        Me.TableLayoutPanel12.SetColumnSpan(Me.TreeViewImagePath, 3)
        Me.TreeViewImagePath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewImagePath.Location = New System.Drawing.Point(3, 31)
        Me.TreeViewImagePath.Name = "TreeViewImagePath"
        Me.TreeViewImagePath.Size = New System.Drawing.Size(214, 459)
        Me.TreeViewImagePath.TabIndex = 1
        '
        'TextBoxImagePath
        '
        Me.TableLayoutPanel12.SetColumnSpan(Me.TextBoxImagePath, 2)
        Me.TextBoxImagePath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxImagePath.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxImagePath.Name = "TextBoxImagePath"
        Me.TextBoxImagePath.ReadOnly = True
        Me.TextBoxImagePath.Size = New System.Drawing.Size(170, 21)
        Me.TextBoxImagePath.TabIndex = 3
        '
        'ProgressBarFormat
        '
        Me.ProgressBarFormat.Location = New System.Drawing.Point(3, 496)
        Me.ProgressBarFormat.MarqueeAnimationSpeed = 5
        Me.ProgressBarFormat.Name = "ProgressBarFormat"
        Me.ProgressBarFormat.Size = New System.Drawing.Size(126, 26)
        Me.ProgressBarFormat.TabIndex = 4
        '
        'LabelFormat
        '
        Me.LabelFormat.AutoSize = True
        Me.LabelFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel12.SetColumnSpan(Me.LabelFormat, 2)
        Me.LabelFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelFormat.Location = New System.Drawing.Point(135, 496)
        Me.LabelFormat.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelFormat.Name = "LabelFormat"
        Me.LabelFormat.Size = New System.Drawing.Size(82, 26)
        Me.LabelFormat.TabIndex = 5
        Me.LabelFormat.Text = "0/0"
        Me.LabelFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonImagePath
        '
        Me.ButtonImagePath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonImagePath.Location = New System.Drawing.Point(179, 3)
        Me.ButtonImagePath.Name = "ButtonImagePath"
        Me.ButtonImagePath.Size = New System.Drawing.Size(38, 22)
        Me.ButtonImagePath.TabIndex = 2
        Me.ButtonImagePath.Text = "Path"
        Me.ButtonImagePath.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBoxImageView)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ListViewImage)
        Me.SplitContainer2.Size = New System.Drawing.Size(552, 525)
        Me.SplitContainer2.SplitterDistance = 300
        Me.SplitContainer2.TabIndex = 0
        '
        'PictureBoxImageView
        '
        Me.PictureBoxImageView.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxImageView.Name = "PictureBoxImageView"
        Me.PictureBoxImageView.Size = New System.Drawing.Size(550, 298)
        Me.PictureBoxImageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxImageView.TabIndex = 0
        Me.PictureBoxImageView.TabStop = False
        '
        'ListViewImage
        '
        Me.ListViewImage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewImage.ContextMenuStrip = Me.ContextMenuStrip2
        Me.ListViewImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewImage.LargeImageList = Me.ImageList1
        Me.ListViewImage.Location = New System.Drawing.Point(0, 0)
        Me.ListViewImage.Name = "ListViewImage"
        Me.ListViewImage.Size = New System.Drawing.Size(550, 219)
        Me.ListViewImage.SmallImageList = Me.ImageList1
        Me.ListViewImage.TabIndex = 0
        Me.ListViewImage.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.FormatToToolStripMenuItem, Me.SetOffsetToolStripMenuItem, Me.OpenInExplorerToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(176, 114)
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ReloadToolStripMenuItem.Text = "Reload"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'FormatToToolStripMenuItem
        '
        Me.FormatToToolStripMenuItem.Name = "FormatToToolStripMenuItem"
        Me.FormatToToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.FormatToToolStripMenuItem.Text = "Format to"
        '
        'SetOffsetToolStripMenuItem
        '
        Me.SetOffsetToolStripMenuItem.Name = "SetOffsetToolStripMenuItem"
        Me.SetOffsetToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SetOffsetToolStripMenuItem.Text = "Set Offset"
        '
        'OpenInExplorerToolStripMenuItem
        '
        Me.OpenInExplorerToolStripMenuItem.Name = "OpenInExplorerToolStripMenuItem"
        Me.OpenInExplorerToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.OpenInExplorerToolStripMenuItem.Text = "Open in Explorer"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FontTool
        '
        Me.FontTool.Controls.Add(Me.TableLayoutPanel13)
        Me.FontTool.Location = New System.Drawing.Point(4, 32)
        Me.FontTool.Name = "FontTool"
        Me.FontTool.Size = New System.Drawing.Size(776, 525)
        Me.FontTool.TabIndex = 5
        Me.FontTool.Text = "FontTool"
        Me.FontTool.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 3
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.TableLayoutPanel18, 1, 1)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 3
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(776, 525)
        Me.TableLayoutPanel13.TabIndex = 3
        '
        'TableLayoutPanel18
        '
        Me.TableLayoutPanel18.ColumnCount = 1
        Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel18.Controls.Add(Me.ButtonBitmapToFont, 0, 1)
        Me.TableLayoutPanel18.Controls.Add(Me.ButtonFontToBitmap, 0, 0)
        Me.TableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel18.Location = New System.Drawing.Point(291, 115)
        Me.TableLayoutPanel18.Name = "TableLayoutPanel18"
        Me.TableLayoutPanel18.RowCount = 5
        Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel18.Size = New System.Drawing.Size(194, 294)
        Me.TableLayoutPanel18.TabIndex = 2
        '
        'ButtonBitmapToFont
        '
        Me.ButtonBitmapToFont.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonBitmapToFont.Location = New System.Drawing.Point(3, 61)
        Me.ButtonBitmapToFont.Name = "ButtonBitmapToFont"
        Me.ButtonBitmapToFont.Size = New System.Drawing.Size(188, 52)
        Me.ButtonBitmapToFont.TabIndex = 1
        Me.ButtonBitmapToFont.Text = "Bitmap To Font"
        Me.ButtonBitmapToFont.UseVisualStyleBackColor = True
        '
        'ButtonFontToBitmap
        '
        Me.ButtonFontToBitmap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonFontToBitmap.Location = New System.Drawing.Point(3, 3)
        Me.ButtonFontToBitmap.Name = "ButtonFontToBitmap"
        Me.ButtonFontToBitmap.Size = New System.Drawing.Size(188, 52)
        Me.ButtonFontToBitmap.TabIndex = 0
        Me.ButtonFontToBitmap.Text = "Font To Bitmap"
        Me.ButtonFontToBitmap.UseVisualStyleBackColor = True
        '
        'MapTool
        '
        Me.MapTool.Controls.Add(Me.TableLayoutPanel14)
        Me.MapTool.Location = New System.Drawing.Point(4, 32)
        Me.MapTool.Name = "MapTool"
        Me.MapTool.Size = New System.Drawing.Size(776, 525)
        Me.MapTool.TabIndex = 4
        Me.MapTool.Text = "MapTool"
        Me.MapTool.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.ColumnCount = 3
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.TableLayoutPanel20, 1, 1)
        Me.TableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 3
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(776, 525)
        Me.TableLayoutPanel14.TabIndex = 2
        '
        'ButtonSmallMap
        '
        Me.ButtonSmallMap.Location = New System.Drawing.Point(3, 3)
        Me.ButtonSmallMap.Name = "ButtonSmallMap"
        Me.ButtonSmallMap.Size = New System.Drawing.Size(188, 52)
        Me.ButtonSmallMap.TabIndex = 0
        Me.ButtonSmallMap.Text = "SmallMap"
        Me.ButtonSmallMap.UseVisualStyleBackColor = True
        '
        'ScriptTool
        '
        Me.ScriptTool.Controls.Add(Me.TableLayoutPanel15)
        Me.ScriptTool.Location = New System.Drawing.Point(4, 32)
        Me.ScriptTool.Name = "ScriptTool"
        Me.ScriptTool.Padding = New System.Windows.Forms.Padding(3)
        Me.ScriptTool.Size = New System.Drawing.Size(776, 525)
        Me.ScriptTool.TabIndex = 3
        Me.ScriptTool.Text = "ScriptTool"
        Me.ScriptTool.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.ColumnCount = 3
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.92982!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.14036!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.92982!))
        Me.TableLayoutPanel15.Controls.Add(Me.Label4, 1, 1)
        Me.TableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 3
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.87879!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.24242!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.87879!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(770, 519)
        Me.TableLayoutPanel15.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(171, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(426, 125)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "is developing"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Readme
        '
        Me.Readme.Controls.Add(Me.TableLayoutPanel11)
        Me.Readme.Location = New System.Drawing.Point(4, 32)
        Me.Readme.Name = "Readme"
        Me.Readme.Padding = New System.Windows.Forms.Padding(3)
        Me.Readme.Size = New System.Drawing.Size(776, 525)
        Me.Readme.TabIndex = 2
        Me.Readme.Text = "Readme"
        Me.Readme.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 3
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.TableLayoutPanel17, 1, 2)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 3
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(770, 519)
        Me.TableLayoutPanel11.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TableLayoutPanel16)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(188, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 394)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel16
        '
        Me.TableLayoutPanel16.ColumnCount = 2
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel16.Controls.Add(Me.LabelTIM, 0, 4)
        Me.TableLayoutPanel16.Controls.Add(Me.LinkLabel5, 1, 4)
        Me.TableLayoutPanel16.Controls.Add(Me.LinkLabel1, 1, 2)
        Me.TableLayoutPanel16.Controls.Add(Me.LinkLabel2, 1, 3)
        Me.TableLayoutPanel16.Controls.Add(Me.LinkLabel4, 1, 5)
        Me.TableLayoutPanel16.Controls.Add(Me.LabelGitHub, 0, 2)
        Me.TableLayoutPanel16.Controls.Add(Me.LabelBaidu, 0, 3)
        Me.TableLayoutPanel16.Controls.Add(Me.LabelEmail, 0, 5)
        Me.TableLayoutPanel16.Controls.Add(Me.LabelDownload, 0, 6)
        Me.TableLayoutPanel16.Controls.Add(Me.LinkLabel3, 1, 6)
        Me.TableLayoutPanel16.Controls.Add(Me.PictureBoxWeChat, 0, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.LabelWeChat, 0, 1)
        Me.TableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel16.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel16.Margin = New System.Windows.Forms.Padding(9)
        Me.TableLayoutPanel16.Name = "TableLayoutPanel16"
        Me.TableLayoutPanel16.Padding = New System.Windows.Forms.Padding(9)
        Me.TableLayoutPanel16.RowCount = 7
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel16.Size = New System.Drawing.Size(392, 392)
        Me.TableLayoutPanel16.TabIndex = 0
        '
        'LabelTIM
        '
        Me.LabelTIM.AutoSize = True
        Me.LabelTIM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelTIM.Location = New System.Drawing.Point(109, 315)
        Me.LabelTIM.Margin = New System.Windows.Forms.Padding(100, 0, 3, 0)
        Me.LabelTIM.Name = "LabelTIM"
        Me.LabelTIM.Size = New System.Drawing.Size(84, 23)
        Me.LabelTIM.TabIndex = 9
        Me.LabelTIM.Text = "TIM :"
        Me.LabelTIM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkLabel5.Location = New System.Drawing.Point(199, 315)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(181, 23)
        Me.LinkLabel5.TabIndex = 10
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "1097811376"
        Me.LinkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkLabel1.Location = New System.Drawing.Point(199, 269)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(181, 23)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Drunklonng"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkLabel2.LinkArea = New System.Windows.Forms.LinkArea(0, 10)
        Me.LinkLabel2.Location = New System.Drawing.Point(199, 292)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(181, 23)
        Me.LinkLabel2.TabIndex = 2
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "1097811376"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkLabel4.Location = New System.Drawing.Point(199, 338)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(181, 23)
        Me.LinkLabel4.TabIndex = 4
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "mail@sango.ink"
        Me.LinkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelGitHub
        '
        Me.LabelGitHub.AutoSize = True
        Me.LabelGitHub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelGitHub.Location = New System.Drawing.Point(109, 269)
        Me.LabelGitHub.Margin = New System.Windows.Forms.Padding(100, 0, 3, 0)
        Me.LabelGitHub.Name = "LabelGitHub"
        Me.LabelGitHub.Size = New System.Drawing.Size(84, 23)
        Me.LabelGitHub.TabIndex = 5
        Me.LabelGitHub.Text = "GitHub :"
        Me.LabelGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelBaidu
        '
        Me.LabelBaidu.AutoSize = True
        Me.LabelBaidu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelBaidu.Location = New System.Drawing.Point(109, 292)
        Me.LabelBaidu.Margin = New System.Windows.Forms.Padding(100, 0, 3, 0)
        Me.LabelBaidu.Name = "LabelBaidu"
        Me.LabelBaidu.Size = New System.Drawing.Size(84, 23)
        Me.LabelBaidu.TabIndex = 6
        Me.LabelBaidu.Text = "Baidu :"
        Me.LabelBaidu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelEmail.Location = New System.Drawing.Point(109, 338)
        Me.LabelEmail.Margin = New System.Windows.Forms.Padding(100, 0, 3, 0)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(84, 23)
        Me.LabelEmail.TabIndex = 8
        Me.LabelEmail.Text = "Email :"
        Me.LabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelDownload
        '
        Me.LabelDownload.AutoSize = True
        Me.LabelDownload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelDownload.Location = New System.Drawing.Point(109, 361)
        Me.LabelDownload.Margin = New System.Windows.Forms.Padding(100, 0, 3, 0)
        Me.LabelDownload.Name = "LabelDownload"
        Me.LabelDownload.Size = New System.Drawing.Size(84, 22)
        Me.LabelDownload.TabIndex = 7
        Me.LabelDownload.Text = "Download :"
        Me.LabelDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkLabel3.Location = New System.Drawing.Point(199, 361)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(181, 22)
        Me.LinkLabel3.TabIndex = 3
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "sango.ys168.com"
        Me.LinkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBoxWeChat
        '
        Me.PictureBoxWeChat.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel16.SetColumnSpan(Me.PictureBoxWeChat, 2)
        Me.PictureBoxWeChat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxWeChat.Image = Global.SangoTool.My.Resources.Resources.WeChat
        Me.PictureBoxWeChat.Location = New System.Drawing.Point(12, 12)
        Me.PictureBoxWeChat.Name = "PictureBoxWeChat"
        Me.PictureBoxWeChat.Size = New System.Drawing.Size(368, 214)
        Me.PictureBoxWeChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxWeChat.TabIndex = 0
        Me.PictureBoxWeChat.TabStop = False
        '
        'LabelWeChat
        '
        Me.LabelWeChat.AutoSize = True
        Me.TableLayoutPanel16.SetColumnSpan(Me.LabelWeChat, 2)
        Me.LabelWeChat.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelWeChat.Location = New System.Drawing.Point(149, 235)
        Me.LabelWeChat.Margin = New System.Windows.Forms.Padding(140, 6, 3, 3)
        Me.LabelWeChat.Name = "LabelWeChat"
        Me.LabelWeChat.Size = New System.Drawing.Size(112, 16)
        Me.LabelWeChat.TabIndex = 0
        Me.LabelWeChat.Text = "WeChat Reward"
        Me.LabelWeChat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel17
        '
        Me.TableLayoutPanel17.ColumnCount = 7
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel17.Controls.Add(Me.ButtonEN, 1, 1)
        Me.TableLayoutPanel17.Controls.Add(Me.ButtonSC, 3, 1)
        Me.TableLayoutPanel17.Controls.Add(Me.ButtonTC, 5, 1)
        Me.TableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel17.Location = New System.Drawing.Point(188, 462)
        Me.TableLayoutPanel17.Name = "TableLayoutPanel17"
        Me.TableLayoutPanel17.RowCount = 3
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel17.Size = New System.Drawing.Size(394, 54)
        Me.TableLayoutPanel17.TabIndex = 1
        '
        'ButtonEN
        '
        Me.ButtonEN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonEN.Location = New System.Drawing.Point(60, 13)
        Me.ButtonEN.Name = "ButtonEN"
        Me.ButtonEN.Size = New System.Drawing.Size(74, 24)
        Me.ButtonEN.TabIndex = 0
        Me.ButtonEN.Text = "English"
        Me.ButtonEN.UseVisualStyleBackColor = True
        '
        'ButtonSC
        '
        Me.ButtonSC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonSC.Location = New System.Drawing.Point(160, 13)
        Me.ButtonSC.Name = "ButtonSC"
        Me.ButtonSC.Size = New System.Drawing.Size(74, 24)
        Me.ButtonSC.TabIndex = 1
        Me.ButtonSC.Text = "简体中文"
        Me.ButtonSC.UseVisualStyleBackColor = True
        '
        'ButtonTC
        '
        Me.ButtonTC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonTC.Location = New System.Drawing.Point(260, 13)
        Me.ButtonTC.Name = "ButtonTC"
        Me.ButtonTC.Size = New System.Drawing.Size(74, 24)
        Me.ButtonTC.TabIndex = 2
        Me.ButtonTC.Text = "繁體中文"
        Me.ButtonTC.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.object"
        Me.OpenFileDialog1.Filter = "Object File|*.object"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "*.object"
        Me.SaveFileDialog1.Filter = "Object File|*.object"
        '
        'Timer3
        '
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.DefaultExt = "*.shp"
        Me.OpenFileDialog2.Filter = "Shadow File|*.shp"
        '
        'SettingTool
        '
        Me.SettingTool.Controls.Add(Me.TableLayoutPanel19)
        Me.SettingTool.Location = New System.Drawing.Point(4, 32)
        Me.SettingTool.Name = "SettingTool"
        Me.SettingTool.Padding = New System.Windows.Forms.Padding(3)
        Me.SettingTool.Size = New System.Drawing.Size(776, 525)
        Me.SettingTool.TabIndex = 7
        Me.SettingTool.Text = "SettingTool"
        Me.SettingTool.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel19
        '
        Me.TableLayoutPanel19.ColumnCount = 3
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.92982!))
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.14036!))
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.92982!))
        Me.TableLayoutPanel19.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel19.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel19.Name = "TableLayoutPanel19"
        Me.TableLayoutPanel19.RowCount = 3
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.87879!))
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.24242!))
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.87879!))
        Me.TableLayoutPanel19.Size = New System.Drawing.Size(770, 519)
        Me.TableLayoutPanel19.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 125)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "is developing"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel20
        '
        Me.TableLayoutPanel20.ColumnCount = 1
        Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel20.Controls.Add(Me.ButtonSmallMap, 0, 0)
        Me.TableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel20.Location = New System.Drawing.Point(291, 115)
        Me.TableLayoutPanel20.Name = "TableLayoutPanel20"
        Me.TableLayoutPanel20.RowCount = 5
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel20.Size = New System.Drawing.Size(194, 294)
        Me.TableLayoutPanel20.TabIndex = 1
        '
        'SangoTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "SangoTool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SangoTool"
        Me.License.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.ObjectTool.ResumeLayout(False)
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
        Me.ContextMenuStrip1.ResumeLayout(False)
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
        Me.ImageTool.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PictureBoxImageView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.FontTool.ResumeLayout(False)
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel18.ResumeLayout(False)
        Me.MapTool.ResumeLayout(False)
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.ScriptTool.ResumeLayout(False)
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.TableLayoutPanel15.PerformLayout()
        Me.Readme.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel16.ResumeLayout(False)
        Me.TableLayoutPanel16.PerformLayout()
        CType(Me.PictureBoxWeChat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel17.ResumeLayout(False)
        Me.SettingTool.ResumeLayout(False)
        Me.TableLayoutPanel19.ResumeLayout(False)
        Me.TableLayoutPanel19.PerformLayout()
        Me.TableLayoutPanel20.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorkerOut As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BackgroundWorkerPlay As System.ComponentModel.BackgroundWorker
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents License As TabPage
    Friend WithEvents ObjectTool As TabPage
    Friend WithEvents SplitContainerFill As SplitContainer
    Friend WithEvents SplitContainerLeft As SplitContainer
    Friend WithEvents TableLayoutPanelUP As TableLayoutPanel
    Friend WithEvents ButtonPlay As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonNew As Button
    Friend WithEvents ButtonRead As Button
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
    Friend WithEvents Playback As Label
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
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Last10ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LastTo0ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Readme As TabPage
    Friend WithEvents ScriptTool As TabPage
    Friend WithEvents ImageTool As TabPage
    Friend WithEvents FontTool As TabPage
    Friend WithEvents MapTool As TabPage
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel16 As TableLayoutPanel
    Friend WithEvents PictureBoxWeChat As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LabelGitHub As Label
    Friend WithEvents LabelBaidu As Label
    Friend WithEvents LabelDownload As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelTIM As Label
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents ButtonImagePath As Button
    Friend WithEvents TreeViewImagePath As TreeView
    Friend WithEvents TextBoxImagePath As TextBox
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents PictureBoxImageView As PictureBox
    Friend WithEvents ListViewImage As ListView
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ProgressBarFormat As ProgressBar
    Friend WithEvents LabelFormat As Label
    Friend WithEvents OpenInExplorerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetOffsetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonSmallMap As Button
    Friend WithEvents ButtonFontToBitmap As Button
    Friend WithEvents ButtonBitmapToFont As Button
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelWeChat As Label
    Friend WithEvents TableLayoutPanel17 As TableLayoutPanel
    Friend WithEvents ButtonEN As Button
    Friend WithEvents ButtonSC As Button
    Friend WithEvents ButtonTC As Button
    Friend WithEvents TableLayoutPanel18 As TableLayoutPanel
    Friend WithEvents SettingTool As TabPage
    Friend WithEvents TableLayoutPanel19 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel20 As TableLayoutPanel
End Class
