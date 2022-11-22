Public Class Subject_Information_Add

    Dim Subject As New SubjectClass

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Subject_Information_Form.Show()
        Me.Close()
    End Sub

    Private Sub AddSubjectButton_Click(sender As Object, e As EventArgs) Handles AddSubjectButton.Click
        Dim newSubjectRecord As SubjectRecord
        Dim addOk As Boolean

        With newSubjectRecord
            .subject_id = AddSubjectCodeTextBox.Text
            .subject_name = AddSubjectNameTextBox.Text
            .credit = AddSubjectCreditTextBox.Text
            .fee = AddSubjectFeeTextBox.Text
        End With

        addOk = Subject.addSubject(newSubjectRecord)

        If addOk Then
            MessageBox.Show("Subject Added")
            Subject_Information_Form.Show()
            Me.Close()
        End If
    End Sub
End Class