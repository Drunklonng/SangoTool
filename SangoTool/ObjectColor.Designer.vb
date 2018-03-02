<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectColor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ObjectColor))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RedFromRed = New System.Windows.Forms.RadioButton()
        Me.RedFromGreen = New System.Windows.Forms.RadioButton()
        Me.RedFromBlue = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GreenFromRed = New System.Windows.Forms.RadioButton()
        Me.GreenFromGreen = New System.Windows.Forms.RadioButton()
        Me.GreenFromBlue = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BlueFromRed = New System.Windows.Forms.RadioButton()
        Me.BlueFromGreen = New System.Windows.Forms.RadioButton()
        Me.BlueFromBlue = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TransparentON = New System.Windows.Forms.RadioButton()
        Me.TransparentOFF = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumericUpDownR = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownG = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownB = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.NumericUpDownR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RedFromRed, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RedFromGreen, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RedFromBlue, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 121)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(369, 27)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Red Channel :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RedFromRed
        '
        Me.RedFromRed.AutoSize = True
        Me.RedFromRed.Checked = True
        Me.RedFromRed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RedFromRed.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RedFromRed.Location = New System.Drawing.Point(150, 4)
        Me.RedFromRed.Name = "RedFromRed"
        Me.RedFromRed.Size = New System.Drawing.Size(66, 19)
        Me.RedFromRed.TabIndex = 1
        Me.RedFromRed.TabStop = True
        Me.RedFromRed.Text = "Red"
        Me.RedFromRed.UseVisualStyleBackColor = True
        '
        'RedFromGreen
        '
        Me.RedFromGreen.AutoSize = True
        Me.RedFromGreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RedFromGreen.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RedFromGreen.Location = New System.Drawing.Point(223, 4)
        Me.RedFromGreen.Name = "RedFromGreen"
        Me.RedFromGreen.Size = New System.Drawing.Size(66, 19)
        Me.RedFromGreen.TabIndex = 2
        Me.RedFromGreen.Text = "Green"
        Me.RedFromGreen.UseVisualStyleBackColor = True
        '
        'RedFromBlue
        '
        Me.RedFromBlue.AutoSize = True
        Me.RedFromBlue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RedFromBlue.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RedFromBlue.Location = New System.Drawing.Point(296, 4)
        Me.RedFromBlue.Name = "RedFromBlue"
        Me.RedFromBlue.Size = New System.Drawing.Size(69, 19)
        Me.RedFromBlue.TabIndex = 3
        Me.RedFromBlue.Text = "Blue"
        Me.RedFromBlue.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GreenFromRed, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GreenFromGreen, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GreenFromBlue, 3, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 154)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(369, 27)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Green Channel :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GreenFromRed
        '
        Me.GreenFromRed.AutoSize = True
        Me.GreenFromRed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GreenFromRed.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GreenFromRed.Location = New System.Drawing.Point(150, 4)
        Me.GreenFromRed.Name = "GreenFromRed"
        Me.GreenFromRed.Size = New System.Drawing.Size(66, 19)
        Me.GreenFromRed.TabIndex = 1
        Me.GreenFromRed.Text = "Red"
        Me.GreenFromRed.UseVisualStyleBackColor = True
        '
        'GreenFromGreen
        '
        Me.GreenFromGreen.AutoSize = True
        Me.GreenFromGreen.Checked = True
        Me.GreenFromGreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GreenFromGreen.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GreenFromGreen.Location = New System.Drawing.Point(223, 4)
        Me.GreenFromGreen.Name = "GreenFromGreen"
        Me.GreenFromGreen.Size = New System.Drawing.Size(66, 19)
        Me.GreenFromGreen.TabIndex = 2
        Me.GreenFromGreen.TabStop = True
        Me.GreenFromGreen.Text = "Green"
        Me.GreenFromGreen.UseVisualStyleBackColor = True
        '
        'GreenFromBlue
        '
        Me.GreenFromBlue.AutoSize = True
        Me.GreenFromBlue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GreenFromBlue.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GreenFromBlue.Location = New System.Drawing.Point(296, 4)
        Me.GreenFromBlue.Name = "GreenFromBlue"
        Me.GreenFromBlue.Size = New System.Drawing.Size(69, 19)
        Me.GreenFromBlue.TabIndex = 3
        Me.GreenFromBlue.Text = "Blue"
        Me.GreenFromBlue.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BlueFromRed, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BlueFromGreen, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BlueFromBlue, 3, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(12, 187)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(369, 27)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Blue Channel :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BlueFromRed
        '
        Me.BlueFromRed.AutoSize = True
        Me.BlueFromRed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlueFromRed.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BlueFromRed.Location = New System.Drawing.Point(150, 4)
        Me.BlueFromRed.Name = "BlueFromRed"
        Me.BlueFromRed.Size = New System.Drawing.Size(66, 19)
        Me.BlueFromRed.TabIndex = 1
        Me.BlueFromRed.Text = "Red"
        Me.BlueFromRed.UseVisualStyleBackColor = True
        '
        'BlueFromGreen
        '
        Me.BlueFromGreen.AutoSize = True
        Me.BlueFromGreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlueFromGreen.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BlueFromGreen.Location = New System.Drawing.Point(223, 4)
        Me.BlueFromGreen.Name = "BlueFromGreen"
        Me.BlueFromGreen.Size = New System.Drawing.Size(66, 19)
        Me.BlueFromGreen.TabIndex = 2
        Me.BlueFromGreen.Text = "Green"
        Me.BlueFromGreen.UseVisualStyleBackColor = True
        '
        'BlueFromBlue
        '
        Me.BlueFromBlue.AutoSize = True
        Me.BlueFromBlue.Checked = True
        Me.BlueFromBlue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlueFromBlue.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BlueFromBlue.Location = New System.Drawing.Point(296, 4)
        Me.BlueFromBlue.Name = "BlueFromBlue"
        Me.BlueFromBlue.Size = New System.Drawing.Size(69, 19)
        Me.BlueFromBlue.TabIndex = 3
        Me.BlueFromBlue.TabStop = True
        Me.BlueFromBlue.Text = "Blue"
        Me.BlueFromBlue.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Channel Exchange :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Faction Color :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(308, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 60)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TransparentON, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TransparentOFF, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(12, 28)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(289, 27)
        Me.TableLayoutPanel4.TabIndex = 6
        '
        'TransparentON
        '
        Me.TransparentON.AutoSize = True
        Me.TransparentON.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransparentON.Location = New System.Drawing.Point(147, 4)
        Me.TransparentON.Name = "TransparentON"
        Me.TransparentON.Size = New System.Drawing.Size(65, 19)
        Me.TransparentON.TabIndex = 0
        Me.TransparentON.Text = "ON"
        Me.TransparentON.UseVisualStyleBackColor = True
        '
        'TransparentOFF
        '
        Me.TransparentOFF.AutoSize = True
        Me.TransparentOFF.Checked = True
        Me.TransparentOFF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransparentOFF.Location = New System.Drawing.Point(219, 4)
        Me.TransparentOFF.Name = "TransparentOFF"
        Me.TransparentOFF.Size = New System.Drawing.Size(66, 19)
        Me.TransparentOFF.TabIndex = 1
        Me.TransparentOFF.TabStop = True
        Me.TransparentOFF.Text = "OFF"
        Me.TransparentOFF.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 25)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Transparent :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel5.ColumnCount = 6
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label9, 4, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label8, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.NumericUpDownR, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.NumericUpDownG, 3, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.NumericUpDownB, 5, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(12, 61)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(289, 27)
        Me.TableLayoutPanel5.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(196, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 25)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "B:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(100, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 25)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "G:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDownR
        '
        Me.NumericUpDownR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumericUpDownR.Location = New System.Drawing.Point(37, 4)
        Me.NumericUpDownR.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownR.Name = "NumericUpDownR"
        Me.NumericUpDownR.Size = New System.Drawing.Size(56, 21)
        Me.NumericUpDownR.TabIndex = 0
        '
        'NumericUpDownG
        '
        Me.NumericUpDownG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumericUpDownG.Location = New System.Drawing.Point(133, 4)
        Me.NumericUpDownG.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownG.Name = "NumericUpDownG"
        Me.NumericUpDownG.Size = New System.Drawing.Size(56, 21)
        Me.NumericUpDownG.TabIndex = 1
        '
        'NumericUpDownB
        '
        Me.NumericUpDownB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumericUpDownB.Location = New System.Drawing.Point(229, 4)
        Me.NumericUpDownB.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownB.Name = "NumericUpDownB"
        Me.NumericUpDownB.Size = New System.Drawing.Size(56, 21)
        Me.NumericUpDownB.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 25)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "R:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ObjectColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 231)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(412, 270)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(412, 270)
        Me.Name = "ObjectColor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ObjectColor"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.NumericUpDownR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents RedFromRed As RadioButton
    Friend WithEvents RedFromGreen As RadioButton
    Friend WithEvents RedFromBlue As RadioButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents GreenFromRed As RadioButton
    Friend WithEvents GreenFromGreen As RadioButton
    Friend WithEvents GreenFromBlue As RadioButton
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents BlueFromRed As RadioButton
    Friend WithEvents BlueFromGreen As RadioButton
    Friend WithEvents BlueFromBlue As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TransparentON As RadioButton
    Friend WithEvents TransparentOFF As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NumericUpDownR As NumericUpDown
    Friend WithEvents NumericUpDownG As NumericUpDown
    Friend WithEvents NumericUpDownB As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
