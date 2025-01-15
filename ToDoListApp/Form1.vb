Public Class ToDoList
    Private Sub btnTask_Click(sender As Object, e As EventArgs) Handles btnTask.Click
        If Not String.IsNullOrWhiteSpace(txtTask.Text) Then
            lstTasks.Items.Add(txtTask.Text)
            txtTask.Clear()
        Else
            MessageBox.Show("Please enter a task!", "Input required!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        txtTask.Focus()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstTasks.SelectedIndex <> -1 Then
            lstTasks.Items.RemoveAt(lstTasks.SelectedIndex)
        Else
            MessageBox.Show("Please select a task to remove!", "No task is selected.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear all tasks?", "Confirm clear.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            lstTasks.Items.Clear()
        End If
    End Sub
End Class
