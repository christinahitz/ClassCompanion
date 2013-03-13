<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssignment))
        Me.lblClassName = New System.Windows.Forms.Label()
        Me.lblAssignName = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtAssignName = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrior = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblPointerView = New System.Windows.Forms.Label()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.chkAssignDone = New System.Windows.Forms.CheckBox()
        Me.dtpADueDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblClassName
        '
        Me.lblClassName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClassName.AutoSize = True
        Me.lblClassName.BackColor = System.Drawing.Color.Transparent
        Me.lblClassName.CausesValidation = False
        Me.lblClassName.Font = New System.Drawing.Font("Lucida Bright", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassName.ForeColor = System.Drawing.Color.White
        Me.lblClassName.Location = New System.Drawing.Point(377, 48)
        Me.lblClassName.Name = "lblClassName"
        Me.lblClassName.Size = New System.Drawing.Size(169, 32)
        Me.lblClassName.TabIndex = 0
        Me.lblClassName.Text = "Class Name"
        '
        'lblAssignName
        '
        Me.lblAssignName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAssignName.AutoSize = True
        Me.lblAssignName.BackColor = System.Drawing.Color.Transparent
        Me.lblAssignName.CausesValidation = False
        Me.lblAssignName.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignName.ForeColor = System.Drawing.Color.White
        Me.lblAssignName.Location = New System.Drawing.Point(66, 120)
        Me.lblAssignName.Name = "lblAssignName"
        Me.lblAssignName.Size = New System.Drawing.Size(177, 22)
        Me.lblAssignName.TabIndex = 1
        Me.lblAssignName.Text = "Assignment Name"
        '
        'lblDueDate
        '
        Me.lblDueDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDueDate.CausesValidation = False
        Me.lblDueDate.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDate.ForeColor = System.Drawing.Color.White
        Me.lblDueDate.Location = New System.Drawing.Point(149, 174)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(94, 22)
        Me.lblDueDate.TabIndex = 2
        Me.lblDueDate.Text = "Due Date"
        '
        'lblNotes
        '
        Me.lblNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotes.AutoSize = True
        Me.lblNotes.BackColor = System.Drawing.Color.Transparent
        Me.lblNotes.CausesValidation = False
        Me.lblNotes.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.ForeColor = System.Drawing.Color.White
        Me.lblNotes.Location = New System.Drawing.Point(181, 231)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(62, 22)
        Me.lblNotes.TabIndex = 3
        Me.lblNotes.Text = "Notes"
        '
        'txtAssignName
        '
        Me.txtAssignName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAssignName.CausesValidation = False
        Me.txtAssignName.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssignName.Location = New System.Drawing.Point(243, 117)
        Me.txtAssignName.Name = "txtAssignName"
        Me.txtAssignName.Size = New System.Drawing.Size(254, 30)
        Me.txtAssignName.TabIndex = 4
        '
        'txtNotes
        '
        Me.txtNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotes.CausesValidation = False
        Me.txtNotes.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(243, 217)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(437, 196)
        Me.txtNotes.TabIndex = 6
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = CType(resources.GetObject("btnNext.BackgroundImage"), System.Drawing.Image)
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.CausesValidation = False
        Me.btnNext.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(640, 419)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(40, 30)
        Me.btnNext.TabIndex = 8
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.Black
        Me.btnAdd.CausesValidation = False
        Me.btnAdd.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(312, 596)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(134, 36)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.Black
        Me.btnDelete.CausesValidation = False
        Me.btnDelete.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(592, 596)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(134, 36)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnPrior
        '
        Me.btnPrior.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrior.BackColor = System.Drawing.Color.Transparent
        Me.btnPrior.BackgroundImage = CType(resources.GetObject("btnPrior.BackgroundImage"), System.Drawing.Image)
        Me.btnPrior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrior.CausesValidation = False
        Me.btnPrior.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrior.ForeColor = System.Drawing.Color.White
        Me.btnPrior.Location = New System.Drawing.Point(243, 419)
        Me.btnPrior.Name = "btnPrior"
        Me.btnPrior.Size = New System.Drawing.Size(40, 30)
        Me.btnPrior.TabIndex = 11
        Me.btnPrior.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.CausesValidation = False
        Me.btnSave.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(452, 596)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(134, 36)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblPointerView
        '
        Me.lblPointerView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPointerView.AutoSize = True
        Me.lblPointerView.BackColor = System.Drawing.Color.Transparent
        Me.lblPointerView.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointerView.ForeColor = System.Drawing.Color.White
        Me.lblPointerView.Location = New System.Drawing.Point(393, 431)
        Me.lblPointerView.Name = "lblPointerView"
        Me.lblPointerView.Size = New System.Drawing.Size(0, 18)
        Me.lblPointerView.TabIndex = 13
        '
        'lblAction
        '
        Me.lblAction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAction.AutoSize = True
        Me.lblAction.BackColor = System.Drawing.Color.Transparent
        Me.lblAction.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAction.ForeColor = System.Drawing.Color.White
        Me.lblAction.Location = New System.Drawing.Point(239, 482)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(0, 22)
        Me.lblAction.TabIndex = 14
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.CausesValidation = False
        Me.btnBack.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(60, 596)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(134, 36)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "&Classes"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'chkAssignDone
        '
        Me.chkAssignDone.AutoSize = True
        Me.chkAssignDone.BackColor = System.Drawing.Color.Transparent
        Me.chkAssignDone.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAssignDone.ForeColor = System.Drawing.Color.White
        Me.chkAssignDone.Location = New System.Drawing.Point(521, 117)
        Me.chkAssignDone.Name = "chkAssignDone"
        Me.chkAssignDone.Size = New System.Drawing.Size(159, 21)
        Me.chkAssignDone.TabIndex = 15
        Me.chkAssignDone.Text = "Assignment Done"
        Me.chkAssignDone.UseVisualStyleBackColor = False
        '
        'dtpADueDate
        '
        Me.dtpADueDate.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpADueDate.Location = New System.Drawing.Point(243, 171)
        Me.dtpADueDate.Name = "dtpADueDate"
        Me.dtpADueDate.Size = New System.Drawing.Size(280, 25)
        Me.dtpADueDate.TabIndex = 16
        '
        'frmAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ClassCompanion.My.Resources.Resources.Chalkboard_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1017, 676)
        Me.Controls.Add(Me.dtpADueDate)
        Me.Controls.Add(Me.chkAssignDone)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me.lblPointerView)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPrior)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtAssignName)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.lblAssignName)
        Me.Controls.Add(Me.lblClassName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximumSize = New System.Drawing.Size(1033, 714)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmAssignment"
        Me.Text = "frmAssignment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClassName As System.Windows.Forms.Label
    Friend WithEvents lblAssignName As System.Windows.Forms.Label
    Friend WithEvents lblDueDate As System.Windows.Forms.Label
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtAssignName As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnPrior As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblPointerView As System.Windows.Forms.Label
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents chkAssignDone As System.Windows.Forms.CheckBox
    Friend WithEvents dtpADueDate As System.Windows.Forms.DateTimePicker
End Class
