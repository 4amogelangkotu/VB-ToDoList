<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToDoList
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
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.lblTask = New System.Windows.Forms.Label()
        Me.btnTask = New System.Windows.Forms.Button()
        Me.lstTasks = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTask
        '
        Me.txtTask.AccessibleName = ""
        Me.txtTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTask.Location = New System.Drawing.Point(117, 14)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(351, 30)
        Me.txtTask.TabIndex = 0
        '
        'lblTask
        '
        Me.lblTask.AutoSize = True
        Me.lblTask.Location = New System.Drawing.Point(12, 21)
        Me.lblTask.Name = "lblTask"
        Me.lblTask.Size = New System.Drawing.Size(99, 20)
        Me.lblTask.TabIndex = 1
        Me.lblTask.Text = "Enter a task:"
        '
        'btnTask
        '
        Me.btnTask.Location = New System.Drawing.Point(475, 12)
        Me.btnTask.Name = "btnTask"
        Me.btnTask.Size = New System.Drawing.Size(136, 39)
        Me.btnTask.TabIndex = 2
        Me.btnTask.Text = "Add Task"
        Me.btnTask.UseVisualStyleBackColor = True
        '
        'lstTasks
        '
        Me.lstTasks.FormattingEnabled = True
        Me.lstTasks.ItemHeight = 20
        Me.lstTasks.Location = New System.Drawing.Point(12, 67)
        Me.lstTasks.Name = "lstTasks"
        Me.lstTasks.Size = New System.Drawing.Size(598, 224)
        Me.lstTasks.TabIndex = 3
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(12, 297)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(289, 41)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove Selected Task"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(308, 298)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(302, 40)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear All Tasks"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'ToDoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 352)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lstTasks)
        Me.Controls.Add(Me.btnTask)
        Me.Controls.Add(Me.lblTask)
        Me.Controls.Add(Me.txtTask)
        Me.Name = "ToDoList"
        Me.Text = "To-Do List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTask As TextBox
    Friend WithEvents lblTask As Label
    Friend WithEvents btnTask As Button
    Friend WithEvents lstTasks As ListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnClear As Button
End Class
