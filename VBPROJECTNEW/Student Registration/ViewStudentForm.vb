Public Class ViewStudentForm

    Dim matric_number, ID As String
    Dim col As Integer
    Dim RegisterStudent As New SubjectRegisterClass

    Private Sub ViewStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RegisterStudent.displayData(studentDataGridView)
    End Sub

    Private Sub searchStudentTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchStudentTextBox.TextChanged
        RegisterStudent.FilterData(searchStudentTextBox.Text, studentDataGridView)
    End Sub

    Private Sub RegisterStudentButton_Click(sender As Object, e As EventArgs) Handles RegisterStudentButton.Click
        Register_Student_Form.ID = ID
        Register_Student_Form.ShowDialog()
    End Sub

    Private Sub backToHomeButton_Click(sender As Object, e As EventArgs) Handles backToHomeButton.Click
        MainMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub viewStudentSubjectButton_Click(sender As Object, e As EventArgs) Handles viewStudentSubjectButton.Click
        Student_Subject_Information_Form.student_id = ID
        Student_Subject_Information_Form.ShowDialog()
    End Sub

    Private Sub studentDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentDataGridView.CellClick
        Try
            col = studentDataGridView.CurrentCell.ColumnIndex

            If col <> 0 Then
                'Button.disableButton(UpdateStudentButton, deleteStudentButton)
                Exit Sub
            End If

            matric_number = studentDataGridView.CurrentCell.RowIndex

            If matric_number <> "" Then
                'Button.enableButton(UpdateStudentButton, deleteStudentButton)
                ID = studentDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class