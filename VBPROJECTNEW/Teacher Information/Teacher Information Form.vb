Public Class Teacher_Information_Form

    Dim Teacher As New TeacherClass
    Dim button As New miscClass

    Dim teacher_ID, ID As String
    Dim col As Integer

    Private Sub Teacher_Information_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Teacher.displayData(TeacherDataGridView)
        button.disableButton(UpdateTeacherButton, deleteTeacherButton)
    End Sub

    Private Sub AddTeacherButton_Click(sender As Object, e As EventArgs) Handles AddTeacherButton.Click
        Teacher_Information_Add.Show()
        Me.Close()
    End Sub

    Private Sub UpdateTeacherButton_Click(sender As Object, e As EventArgs) Handles UpdateTeacherButton.Click
        Teacher_Information_Update.TeacherID = ID
        Teacher_Information_Update.Show()
        Me.Close()

    End Sub

    Private Sub TeacherDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TeacherDataGridView.CellClick
        Try
            col = TeacherDataGridView.CurrentCell.ColumnIndex

            If col <> 0 Then
                button.disableButton(UpdateTeacherButton, deleteTeacherButton)
                Exit Sub
            End If

            teacher_ID = TeacherDataGridView.CurrentCell.RowIndex

            If teacher_ID <> "" Then
                button.enableButton(UpdateTeacherButton, deleteTeacherButton)
                ID = TeacherDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub SearchTeacherTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTeacherTextBox.TextChanged
        Teacher.FilterData(SearchTeacherTextBox.Text, TeacherDataGridView)
    End Sub

    Private Sub deleteTeacherButton_Click(sender As Object, e As EventArgs) Handles deleteTeacherButton.Click
        Dim deleteOk As Boolean

        deleteOk = Teacher.deleteTeacher(ID)

        If deleteOk Then
            MessageBox.Show("Teacher Information Deleted")
            Teacher_Information_Form_Load(sender, e)
        End If

    End Sub

    Private Sub backToHomeButton_Click(sender As Object, e As EventArgs) Handles backToHomeButton.Click
        MainMenuForm.Show()
        Me.Close()
    End Sub
End Class