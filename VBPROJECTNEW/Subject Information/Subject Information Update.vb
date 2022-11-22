Public Class Subject_Information_Update

    Dim Subject As New SubjectClass
    Public subject_id As String

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Subject_Information_Form.Show()
        Me.Close()
    End Sub

    Private Sub Subject_Information_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateSubjectCodeTextBox.ReadOnly = True
        displayExistingStudent(subject_id)
    End Sub

    Private Sub displayExistingStudent(subject_id As String)
        Dim oldSubjectRecord As SubjectRecord
        Try
            oldSubjectRecord = Subject.displayExistingSubjectInfo(subject_id)

            With Me
                .UpdateSubjectCodeTextBox.Text = oldSubjectRecord.subject_id
                .UpdateSubjectNameTextBox.Text = oldSubjectRecord.subject_name
                .UpdateCreditSubjectTextBox.Text = oldSubjectRecord.credit
                .UpdateFeeSubjectTextBox.Text = oldSubjectRecord.fee

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AddClassButton_Click(sender As Object, e As EventArgs) Handles AddClassButton.Click
        Dim updateSubjectRecord As SubjectRecord
        Dim editOK As Boolean

        With updateSubjectRecord
            .subject_id = UpdateSubjectCodeTextBox.Text
            .subject_name = UpdateSubjectNameTextBox.Text
            .credit = UpdateCreditSubjectTextBox.Text
            .fee = UpdateFeeSubjectTextBox.Text
        End With

        editOK = Subject.updateSubject(updateSubjectRecord)

        If editOK Then
            MessageBox.Show("Subject Information Updated")
            Subject_Information_Form.Show()
            Me.Close()
        End If

    End Sub
End Class