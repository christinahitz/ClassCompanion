<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClass))
        Me.btnClassExit = New System.Windows.Forms.Button()
        Me.txtClassName = New System.Windows.Forms.TextBox()
        Me.btnAddClass = New System.Windows.Forms.Button()
        Me.btnNewClass = New System.Windows.Forms.Button()
        Me.lblNewClass = New System.Windows.Forms.Label()
        Me.lblDateMeet = New System.Windows.Forms.Label()
        Me.txtDayMeet = New System.Windows.Forms.TextBox()
        Me.lblTimeClassStarts = New System.Windows.Forms.Label()
        Me.txtTimeClassStarts = New System.Windows.Forms.TextBox()
        Me.cboDeleteClass = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnDeleteClass = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClassExit
        '
        Me.btnClassExit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClassExit.BackgroundImage = Global.ClassCompanion.My.Resources.Resources.EEraser
        Me.btnClassExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClassExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClassExit.Location = New System.Drawing.Point(768, 558)
        Me.btnClassExit.Name = "btnClassExit"
        Me.btnClassExit.Size = New System.Drawing.Size(195, 75)
        Me.btnClassExit.TabIndex = 0
        Me.btnClassExit.UseVisualStyleBackColor = True
        '
        'txtClassName
        '
        Me.txtClassName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtClassName.BackColor = System.Drawing.Color.Black
        Me.txtClassName.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClassName.ForeColor = System.Drawing.Color.White
        Me.txtClassName.Location = New System.Drawing.Point(338, 445)
        Me.txtClassName.Name = "txtClassName"
        Me.txtClassName.Size = New System.Drawing.Size(397, 30)
        Me.txtClassName.TabIndex = 1
        Me.txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtClassName.Visible = False
        '
        'btnAddClass
        '
        Me.btnAddClass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnAddClass.AutoEllipsis = True
        Me.btnAddClass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddClass.BackColor = System.Drawing.Color.Black
        Me.btnAddClass.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddClass.FlatAppearance.BorderSize = 0
        Me.btnAddClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnAddClass.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddClass.ForeColor = System.Drawing.Color.White
        Me.btnAddClass.Location = New System.Drawing.Point(456, 576)
        Me.btnAddClass.Name = "btnAddClass"
        Me.btnAddClass.Size = New System.Drawing.Size(145, 34)
        Me.btnAddClass.TabIndex = 4
        Me.btnAddClass.Text = "&Add Class"
        Me.btnAddClass.UseVisualStyleBackColor = False
        Me.btnAddClass.Visible = False
        '
        'btnNewClass
        '
        Me.btnNewClass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewClass.BackColor = System.Drawing.Color.Black
        Me.btnNewClass.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNewClass.FlatAppearance.BorderSize = 0
        Me.btnNewClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnNewClass.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewClass.ForeColor = System.Drawing.Color.White
        Me.btnNewClass.Location = New System.Drawing.Point(56, 596)
        Me.btnNewClass.Name = "btnNewClass"
        Me.btnNewClass.Size = New System.Drawing.Size(134, 36)
        Me.btnNewClass.TabIndex = 1
        Me.btnNewClass.Text = "&New Class"
        Me.btnNewClass.UseVisualStyleBackColor = False
        '
        'lblNewClass
        '
        Me.lblNewClass.BackColor = System.Drawing.Color.Transparent
        Me.lblNewClass.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewClass.ForeColor = System.Drawing.Color.White
        Me.lblNewClass.Location = New System.Drawing.Point(151, 445)
        Me.lblNewClass.Name = "lblNewClass"
        Me.lblNewClass.Size = New System.Drawing.Size(149, 33)
        Me.lblNewClass.TabIndex = 27
        Me.lblNewClass.Text = "New Class"
        Me.lblNewClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNewClass.Visible = False
        '
        'lblDateMeet
        '
        Me.lblDateMeet.BackColor = System.Drawing.Color.Transparent
        Me.lblDateMeet.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateMeet.ForeColor = System.Drawing.Color.White
        Me.lblDateMeet.Location = New System.Drawing.Point(121, 484)
        Me.lblDateMeet.Name = "lblDateMeet"
        Me.lblDateMeet.Size = New System.Drawing.Size(201, 33)
        Me.lblDateMeet.TabIndex = 28
        Me.lblDateMeet.Text = "Day Class Meets"
        Me.lblDateMeet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDateMeet.Visible = False
        '
        'txtDayMeet
        '
        Me.txtDayMeet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtDayMeet.BackColor = System.Drawing.Color.Black
        Me.txtDayMeet.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDayMeet.ForeColor = System.Drawing.Color.White
        Me.txtDayMeet.Location = New System.Drawing.Point(338, 484)
        Me.txtDayMeet.Name = "txtDayMeet"
        Me.txtDayMeet.Size = New System.Drawing.Size(397, 30)
        Me.txtDayMeet.TabIndex = 2
        Me.txtDayMeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDayMeet.Visible = False
        '
        'lblTimeClassStarts
        '
        Me.lblTimeClassStarts.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeClassStarts.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeClassStarts.ForeColor = System.Drawing.Color.White
        Me.lblTimeClassStarts.Location = New System.Drawing.Point(111, 523)
        Me.lblTimeClassStarts.Name = "lblTimeClassStarts"
        Me.lblTimeClassStarts.Size = New System.Drawing.Size(201, 33)
        Me.lblTimeClassStarts.TabIndex = 30
        Me.lblTimeClassStarts.Text = "Time Class Starts"
        Me.lblTimeClassStarts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTimeClassStarts.Visible = False
        '
        'txtTimeClassStarts
        '
        Me.txtTimeClassStarts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtTimeClassStarts.BackColor = System.Drawing.Color.Black
        Me.txtTimeClassStarts.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeClassStarts.ForeColor = System.Drawing.Color.White
        Me.txtTimeClassStarts.Location = New System.Drawing.Point(338, 523)
        Me.txtTimeClassStarts.Name = "txtTimeClassStarts"
        Me.txtTimeClassStarts.Size = New System.Drawing.Size(397, 30)
        Me.txtTimeClassStarts.TabIndex = 3
        Me.txtTimeClassStarts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTimeClassStarts.Visible = False
        '
        'cboDeleteClass
        '
        Me.cboDeleteClass.AllowDrop = True
        Me.cboDeleteClass.BackColor = System.Drawing.Color.Black
        Me.cboDeleteClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboDeleteClass.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDeleteClass.ForeColor = System.Drawing.Color.White
        Me.cboDeleteClass.FormattingEnabled = True
        Me.cboDeleteClass.Location = New System.Drawing.Point(413, 454)
        Me.cboDeleteClass.Name = "cboDeleteClass"
        Me.cboDeleteClass.Size = New System.Drawing.Size(200, 30)
        Me.cboDeleteClass.TabIndex = 31
        Me.cboDeleteClass.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.AutoEllipsis = True
        Me.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDelete.BackColor = System.Drawing.Color.Black
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnDelete.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(432, 495)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(143, 40)
        Me.btnDelete.TabIndex = 32
        Me.btnDelete.Text = "Delete "
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'btnDeleteClass
        '
        Me.btnDeleteClass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteClass.BackColor = System.Drawing.Color.Black
        Me.btnDeleteClass.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDeleteClass.FlatAppearance.BorderSize = 0
        Me.btnDeleteClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnDeleteClass.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteClass.ForeColor = System.Drawing.Color.White
        Me.btnDeleteClass.Location = New System.Drawing.Point(196, 596)
        Me.btnDeleteClass.Name = "btnDeleteClass"
        Me.btnDeleteClass.Size = New System.Drawing.Size(134, 36)
        Me.btnDeleteClass.TabIndex = 33
        Me.btnDeleteClass.Text = "&Delete"
        Me.btnDeleteClass.UseVisualStyleBackColor = False
        '
        'frmClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ClassCompanion.My.Resources.Resources.Chalkboard_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1017, 676)
        Me.Controls.Add(Me.btnDeleteClass)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cboDeleteClass)
        Me.Controls.Add(Me.txtTimeClassStarts)
        Me.Controls.Add(Me.lblTimeClassStarts)
        Me.Controls.Add(Me.txtDayMeet)
        Me.Controls.Add(Me.lblDateMeet)
        Me.Controls.Add(Me.lblNewClass)
        Me.Controls.Add(Me.btnNewClass)
        Me.Controls.Add(Me.btnAddClass)
        Me.Controls.Add(Me.txtClassName)
        Me.Controls.Add(Me.btnClassExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1033, 714)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmClass"
        Me.Text = "                                                                                 " & _
    "                                                         "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClassExit As System.Windows.Forms.Button
    Friend WithEvents txtClassName As System.Windows.Forms.TextBox
    Friend WithEvents btnAddClass As System.Windows.Forms.Button
    Friend WithEvents btnNewClass As System.Windows.Forms.Button
    Friend WithEvents lblNewClass As System.Windows.Forms.Label
    Friend WithEvents lblDateMeet As System.Windows.Forms.Label
    Friend WithEvents txtDayMeet As System.Windows.Forms.TextBox
    Friend WithEvents lblTimeClassStarts As System.Windows.Forms.Label
    Friend WithEvents txtTimeClassStarts As System.Windows.Forms.TextBox
    Friend WithEvents cboDeleteClass As System.Windows.Forms.ComboBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnDeleteClass As System.Windows.Forms.Button
End Class
