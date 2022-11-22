Public Class Subject_Information_Form

    Dim Subject As New SubjectClass
    Dim button As New miscClass

    Dim subject_id, ID As String
    Dim col As Integer

    Private Sub Subject_Information_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Subject.displayData(subjectDataGridView)
        button.disableButton(UpdateSubjectButton, deleteSubjectButton)
    End Sub

    Private Sub AddSubjectButton_Click(sender As Object, e As EventArgs) Handles AddSubjectButton.Click
        Subject_Information_Add.Show()
        Me.Close()
    End Sub

    Private Sub UpdateSubjectButton_Click(sender As Object, e As EventArgs) Handles UpdateSubjectButton.Click
        Subject_Information_Update.subject_id = ID
        Subject_Information_Update.Show()
        Me.Close()
    End Sub

    Private Sub subjectDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles subjectDataGridView.CellClick
        Try
            col = subjectDataGridView.CurrentCell.ColumnIndex

            If col <> 0 Then
                button.disableButton(UpdateSubjectButton, deleteSubjectButton)
                Exit Sub
            End If

            subject_id = subjectDataGridView.CurrentCell.RowIndex

            If subject_id <> "" Then
                button.enableButton(UpdateSubjectButton, deleteSubjectButton)
                ID = subjectDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub searchSubjectTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchSubjectTextBox.TextChanged
        Subject.FilterData(searchSubjectTextBox.Text, subjectDataGridView)
    End Sub

    Private Sub deleteSubjectButton_Click(sender As Object, e As EventArgs) Handles deleteSubjectButton.Click
        Dim deleteOk As Boolean

        deleteOk = Subject.deleteSubject(ID)

        If deleteOk Then
            MessageBox.Show("Subject Deleted")
            Subject_Information_Form_Load(sender, e)
        End If
    End Sub

    Private Sub backToHomeButton_Click(sender As Object, e As EventArgs) Handles backToHomeButton.Click
        MainMenuForm.Show()
        Me.Close()
    End Sub
End Class