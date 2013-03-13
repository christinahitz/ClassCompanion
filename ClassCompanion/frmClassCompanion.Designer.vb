<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassCompanion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClassCompanion))
        Me.btnClass = New System.Windows.Forms.Button()
        Me.btnClassMainExit = New System.Windows.Forms.Button()
        Me.btnAssignment = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClass
        '
        Me.btnClass.BackgroundImage = Global.ClassCompanion.My.Resources.Resources.classes2
        Me.btnClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClass.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClass.FlatAppearance.BorderSize = 0
        Me.btnClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClass.Location = New System.Drawing.Point(0, 1)
        Me.btnClass.Name = "btnClass"
        Me.btnClass.Size = New System.Drawing.Size(161, 139)
        Me.btnClass.TabIndex = 1
        Me.btnClass.UseVisualStyleBackColor = True
        '
        'btnClassMainExit
        '
        Me.btnClassMainExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClassMainExit.BackgroundImage = Global.ClassCompanion.My.Resources.Resources.exitImage2
        Me.btnClassMainExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClassMainExit.FlatAppearance.BorderSize = 0
        Me.btnClassMainExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassMainExit.Location = New System.Drawing.Point(0, 549)
        Me.btnClassMainExit.Name = "btnClassMainExit"
        Me.btnClassMainExit.Size = New System.Drawing.Size(161, 131)
        Me.btnClassMainExit.TabIndex = 3
        Me.btnClassMainExit.UseVisualStyleBackColor = True
        '
        'btnAssignment
        '
        Me.btnAssignment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAssignment.BackgroundImage = CType(resources.GetObject("btnAssignment.BackgroundImage"), System.Drawing.Image)
        Me.btnAssignment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAssignment.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAssignment.FlatAppearance.BorderSize = 0
        Me.btnAssignment.Location = New System.Drawing.Point(857, 1)
        Me.btnAssignment.Name = "btnAssignment"
        Me.btnAssignment.Size = New System.Drawing.Size(161, 131)
        Me.btnAssignment.TabIndex = 4
        Me.btnAssignment.UseVisualStyleBackColor = True
        '
        'frmClassCompanion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ClassCompanion.My.Resources.Resources.schoolhouse1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.btnClass
        Me.ClientSize = New System.Drawing.Size(1017, 676)
        Me.Controls.Add(Me.btnAssignment)
        Me.Controls.Add(Me.btnClassMainExit)
        Me.Controls.Add(Me.btnClass)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1033, 714)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmClassCompanion"
        Me.Text = "School Companion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClass As System.Windows.Forms.Button
    Friend WithEvents btnClassMainExit As System.Windows.Forms.Button
    Friend WithEvents btnAssignment As System.Windows.Forms.Button

End Class
