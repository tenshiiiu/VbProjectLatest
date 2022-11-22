Public Class Student_Information_Form

    Dim Student As New StudentClass
    Dim button As New miscClass

    Dim matric_number, ID As String
    Dim col As Integer

    Private Sub Student_Information_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Student.displayData(studentDataGridView)
        button.disableButton(UpdateStudentButton, deleteStudentButton)

    End Sub

    Private Sub backToHomeButton_Click(sender As Object, e As EventArgs) Handles backToHomeButton.Click
        MainMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub AddStudentButton_Click(sender As Object, e As EventArgs) Handles AddStudentButton.Click
        Student_Information_Add.Show()
        Me.Close()
    End Sub

    Private Sub UpdateStudentButton_Click(sender As Object, e As EventArgs) Handles UpdateStudentButton.Click
        Student_Information_Update.matric_number = ID
        Student_Information_Update.Show()
        Me.Close()
    End Sub

    Private Sub deleteStudentButton_Click(sender As Object, e As EventArgs) Handles deleteStudentButton.Click
        Dim deleteOk As Boolean

        deleteOk = Student.deleteStudent(ID)

        If deleteOk Then
            MessageBox.Show("Student Information Deleted")
            Student_Information_Form_Load(sender, e)
        End If

    End Sub

    Private Sub searchStudentTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchStudentTextBox.TextChanged
        Student.FilterData(searchStudentTextBox.Text, studentDataGridView)
    End Sub

    Private Sub studentDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentDataGridView.CellClick
        Try
            col = studentDataGridView.CurrentCell.ColumnIndex

            If col <> 0 Then
                button.disableButton(UpdateStudentButton, deleteStudentButton)
                Exit Sub
            End If

            matric_number = studentDataGridView.CurrentCell.RowIndex

            If matric_number <> "" Then
                button.enableButton(UpdateStudentButton, deleteStudentButton)
                ID = studentDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class