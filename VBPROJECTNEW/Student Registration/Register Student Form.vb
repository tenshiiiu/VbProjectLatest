Public Class Register_Student_Form

    Public ID As String
    Dim SubjectRegister As New SubjectRegisterClass
    Dim button As New miscClass

    Dim col As Integer
    Dim subject_code, subjectID As String

    Private Sub Register_Student_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayExistingStudent(ID)

        button.disableButton(deleteSubjectButton, deleteSubjectButton)

        SubjectRegister.displaySubjectComboBox(subjectComboBox)

        SubjectRegister.displaySubjectData(ID, subjectDataGridView)

    End Sub

    Public Sub displayExistingStudent(matric_number)
        Dim oldStudentRecord As studentRecord
        Try
            oldStudentRecord = SubjectRegister.displayStudentInfo(matric_number)
            With Me
                .nameLabel.Text = oldStudentRecord.name
                .matricNumberLabel.Text = oldStudentRecord.matric_number
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub addSubjectButton_Click(sender As Object, e As EventArgs) Handles addSubjectButton.Click
        Dim subjectID As String
        Dim addOk As Boolean

        subjectID = subjectComboBox.SelectedValue.ToString

        addOk = SubjectRegister.addSubject(ID, subjectID)

        If addOk Then
            Register_Student_Form_Load(sender, e)
        End If

    End Sub

    Private Sub deleteSubjectButton_Click(sender As Object, e As EventArgs) Handles deleteSubjectButton.Click
        Dim deleteOK As Boolean

        deleteOK = SubjectRegister.deleteSubject(subjectID)

        If deleteOK Then
            MessageBox.Show("Subject Deleted")
            Register_Student_Form_Load(sender, e)
        End If


    End Sub

    Private Sub subjectDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles subjectDataGridView.CellClick
        Try
            col = subjectDataGridView.CurrentCell.ColumnIndex

            If col <> 0 Then
                button.disableButton(deleteSubjectButton, deleteSubjectButton)
                Exit Sub
            End If

            subject_code = subjectDataGridView.CurrentCell.RowIndex

            If subject_code <> "" Then
                button.enableButton(deleteSubjectButton, deleteSubjectButton)
                subjectID = subjectDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
End Class