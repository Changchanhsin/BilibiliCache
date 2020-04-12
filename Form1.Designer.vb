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
        Me.lblSource = New System.Windows.Forms.Label()
        Me.cboSource = New System.Windows.Forms.ComboBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lvwItems = New System.Windows.Forms.ListView()
        Me.Path = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.hasRedundantMusic = New System.Windows.Forms.CheckBox()
        Me.hasDanmaku = New System.Windows.Forms.CheckBox()
        Me.isDeleteSourceFile = New System.Windows.Forms.CheckBox()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pgbProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblProgress = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SubTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(12, 20)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(94, 24)
        Me.lblSource.TabIndex = 0
        Me.lblSource.Text = "Source:"
        '
        'cboSource
        '
        Me.cboSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSource.FormattingEnabled = True
        Me.cboSource.Location = New System.Drawing.Point(112, 17)
        Me.cboSource.Name = "cboSource"
        Me.cboSource.Size = New System.Drawing.Size(934, 32)
        Me.cboSource.TabIndex = 1
        Me.cboSource.Text = "W:\视频\new\"
        '
        'btnCheck
        '
        Me.btnCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCheck.Location = New System.Drawing.Point(1052, 12)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(107, 41)
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
        Me.lvwItems.Location = New System.Drawing.Point(113, 55)
        Me.lvwItems.Name = "lvwItems"
        Me.lvwItems.Size = New System.Drawing.Size(1047, 618)
        Me.lvwItems.Sorting = System.Windows.Forms.SortOrder.Ascending
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
        'Type
        '
        Me.Type.Text = "Type"
        '
        'FileCount
        '
        Me.FileCount.Text = "Files"
        Me.FileCount.Width = 100
        '
        'btnConvert
        '
        Me.btnConvert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConvert.Location = New System.Drawing.Point(1053, 679)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(107, 41)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(1053, 726)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 41)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'hasRedundantMusic
        '
        Me.hasRedundantMusic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.hasRedundantMusic.AutoSize = True
        Me.hasRedundantMusic.Checked = True
        Me.hasRedundantMusic.CheckState = System.Windows.Forms.CheckState.Checked
        Me.hasRedundantMusic.Location = New System.Drawing.Point(113, 692)
        Me.hasRedundantMusic.Name = "hasRedundantMusic"
        Me.hasRedundantMusic.Size = New System.Drawing.Size(222, 28)
        Me.hasRedundantMusic.TabIndex = 6
        Me.hasRedundantMusic.Text = "Redundant music"
        Me.hasRedundantMusic.UseVisualStyleBackColor = True
        '
        'hasDanmaku
        '
        Me.hasDanmaku.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.hasDanmaku.AutoSize = True
        Me.hasDanmaku.Checked = True
        Me.hasDanmaku.CheckState = System.Windows.Forms.CheckState.Checked
        Me.hasDanmaku.Location = New System.Drawing.Point(341, 692)
        Me.hasDanmaku.Name = "hasDanmaku"
        Me.hasDanmaku.Size = New System.Drawing.Size(126, 28)
        Me.hasDanmaku.TabIndex = 6
        Me.hasDanmaku.Text = "Danmaku"
        Me.hasDanmaku.UseVisualStyleBackColor = True
        '
        'isDeleteSourceFile
        '
        Me.isDeleteSourceFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.isDeleteSourceFile.AutoSize = True
        Me.isDeleteSourceFile.Location = New System.Drawing.Point(473, 692)
        Me.isDeleteSourceFile.Name = "isDeleteSourceFile"
        Me.isDeleteSourceFile.Size = New System.Drawing.Size(258, 28)
        Me.isDeleteSourceFile.TabIndex = 7
        Me.isDeleteSourceFile.Text = "Delete source file"
        Me.isDeleteSourceFile.UseVisualStyleBackColor = True
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Location = New System.Drawing.Point(12, 55)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(82, 24)
        Me.lblItems.TabIndex = 8
        Me.lblItems.Text = "items:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pgbProgress, Me.lblProgress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 786)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1171, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pgbProgress
        '
        Me.pgbProgress.Name = "pgbProgress"
        Me.pgbProgress.Size = New System.Drawing.Size(100, 15)
        Me.pgbProgress.Visible = False
        '
        'lblProgress
        '
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(0, 12)
        '
        'SubTitle
        '
        Me.SubTitle.Text = "Sub Title"
        '
        'SubCount
        '
        Me.SubCount.Text = "Subs"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 808)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.isDeleteSourceFile)
        Me.Controls.Add(Me.hasDanmaku)
        Me.Controls.Add(Me.hasRedundantMusic)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lvwItems)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.cboSource)
        Me.Controls.Add(Me.lblSource)
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
    Friend WithEvents hasRedundantMusic As CheckBox
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
End Class
