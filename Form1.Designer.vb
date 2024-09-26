<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblSource = New System.Windows.Forms.Label()
        Me.cboSource = New System.Windows.Forms.ComboBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lvwItems = New System.Windows.Forms.ListView()
        Me.Path = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.hasDanmaku = New System.Windows.Forms.CheckBox()
        Me.isDeleteSourceFile = New System.Windows.Forms.CheckBox()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pgbProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblProgress = New System.Windows.Forms.ToolStripStatusLabel()
        Me.chkCopyStream = New System.Windows.Forms.CheckBox()
        Me.chkToMp3 = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(8, 12)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(63, 15)
        Me.lblSource.TabIndex = 0
        Me.lblSource.Text = "Source:"
        '
        'cboSource
        '
        Me.cboSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSource.FormattingEnabled = True
        Me.cboSource.Location = New System.Drawing.Point(75, 10)
        Me.cboSource.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboSource.Name = "cboSource"
        Me.cboSource.Size = New System.Drawing.Size(706, 23)
        Me.cboSource.TabIndex = 1
        Me.cboSource.Text = "W:\视频\new\"
        '
        'btnCheck
        '
        Me.btnCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCheck.Location = New System.Drawing.Point(783, 8)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(72, 25)
        Me.btnCheck.TabIndex = 2
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lvwItems
        '
        Me.lvwItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Path, Me.Title, Me.SubCount, Me.SubTitle, Me.Type, Me.FileCount})
        Me.lvwItems.FullRowSelect = True
        Me.lvwItems.GridLines = True
        Me.lvwItems.HideSelection = False
        Me.lvwItems.LabelWrap = False
        Me.lvwItems.Location = New System.Drawing.Point(75, 35)
        Me.lvwItems.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lvwItems.Name = "lvwItems"
        Me.lvwItems.Size = New System.Drawing.Size(782, 132)
        Me.lvwItems.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwItems.StateImageList = Me.ImageList1
        Me.lvwItems.TabIndex = 3
        Me.lvwItems.UseCompatibleStateImageBehavior = False
        Me.lvwItems.View = System.Windows.Forms.View.Details
        '
        'Path
        '
        Me.Path.Text = "Path"
        Me.Path.Width = 150
        '
        'Title
        '
        Me.Title.Text = "Title"
        Me.Title.Width = 300
        '
        'SubCount
        '
        Me.SubCount.Text = "Subs"
        '
        'SubTitle
        '
        Me.SubTitle.Text = "Sub Title"
        '
        'Type
        '
        Me.Type.Text = "Type"
        '
        'FileCount
        '
        Me.FileCount.Text = "Files"
        Me.FileCount.Width = 100
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "ava-24.png")
        Me.ImageList1.Images.SetKeyName(1, "av-24.png")
        Me.ImageList1.Images.SetKeyName(2, "audio-24.png")
        Me.ImageList1.Images.SetKeyName(3, "unselected-24.png")
        '
        'btnConvert
        '
        Me.btnConvert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConvert.Location = New System.Drawing.Point(699, 172)
        Me.btnConvert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(159, 25)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Make run.bat"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(785, 201)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 25)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'hasDanmaku
        '
        Me.hasDanmaku.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.hasDanmaku.AutoSize = True
        Me.hasDanmaku.Checked = True
        Me.hasDanmaku.CheckState = System.Windows.Forms.CheckState.Checked
        Me.hasDanmaku.Location = New System.Drawing.Point(281, 176)
        Me.hasDanmaku.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.hasDanmaku.Name = "hasDanmaku"
        Me.hasDanmaku.Size = New System.Drawing.Size(85, 19)
        Me.hasDanmaku.TabIndex = 6
        Me.hasDanmaku.Text = "Danmaku"
        Me.hasDanmaku.UseVisualStyleBackColor = True
        '
        'isDeleteSourceFile
        '
        Me.isDeleteSourceFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.isDeleteSourceFile.AutoSize = True
        Me.isDeleteSourceFile.Enabled = False
        Me.isDeleteSourceFile.Location = New System.Drawing.Point(372, 176)
        Me.isDeleteSourceFile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.isDeleteSourceFile.Name = "isDeleteSourceFile"
        Me.isDeleteSourceFile.Size = New System.Drawing.Size(173, 19)
        Me.isDeleteSourceFile.TabIndex = 7
        Me.isDeleteSourceFile.Text = "Delete source file"
        Me.isDeleteSourceFile.UseVisualStyleBackColor = True
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Location = New System.Drawing.Point(8, 35)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(55, 15)
        Me.lblItems.TabIndex = 8
        Me.lblItems.Text = "items:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pgbProgress, Me.lblProgress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 233)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 9, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(863, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pgbProgress
        '
        Me.pgbProgress.Name = "pgbProgress"
        Me.pgbProgress.Size = New System.Drawing.Size(67, 18)
        Me.pgbProgress.Visible = False
        '
        'lblProgress
        '
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(0, 16)
        '
        'chkCopyStream
        '
        Me.chkCopyStream.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkCopyStream.AutoSize = True
        Me.chkCopyStream.Location = New System.Drawing.Point(75, 176)
        Me.chkCopyStream.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkCopyStream.Name = "chkCopyStream"
        Me.chkCopyStream.Size = New System.Drawing.Size(117, 19)
        Me.chkCopyStream.TabIndex = 11
        Me.chkCopyStream.Text = "Copy stream"
        Me.chkCopyStream.UseVisualStyleBackColor = True
        '
        'chkToMp3
        '
        Me.chkToMp3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkToMp3.AutoSize = True
        Me.chkToMp3.Checked = True
        Me.chkToMp3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkToMp3.Location = New System.Drawing.Point(198, 176)
        Me.chkToMp3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkToMp3.Name = "chkToMp3"
        Me.chkToMp3.Size = New System.Drawing.Size(77, 19)
        Me.chkToMp3.TabIndex = 11
        Me.chkToMp3.Text = "To MP3"
        Me.chkToMp3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 255)
        Me.Controls.Add(Me.chkToMp3)
        Me.Controls.Add(Me.chkCopyStream)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.isDeleteSourceFile)
        Me.Controls.Add(Me.hasDanmaku)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lvwItems)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.cboSource)
        Me.Controls.Add(Me.lblSource)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "bilibili Cache"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSource As Label
    Friend WithEvents cboSource As ComboBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents lvwItems As ListView
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents hasDanmaku As CheckBox
    Friend WithEvents isDeleteSourceFile As CheckBox
    Friend WithEvents lblItems As Label
    Friend WithEvents Type As ColumnHeader
    Friend WithEvents Title As ColumnHeader
    Friend WithEvents Path As ColumnHeader
    Friend WithEvents FileCount As ColumnHeader
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents pgbProgress As ToolStripProgressBar
    Friend WithEvents lblProgress As ToolStripStatusLabel
    Friend WithEvents SubCount As ColumnHeader
    Friend WithEvents SubTitle As ColumnHeader
    Friend WithEvents chkCopyStream As CheckBox
    Friend WithEvents chkToMp3 As CheckBox
    Friend WithEvents ImageList1 As ImageList
End Class
