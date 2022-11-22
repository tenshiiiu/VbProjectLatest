Public Class Student_Information_Update

    Dim Student As New StudentClass
    Public matric_number As String

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Student_Information_Form.Show()
        Me.Close()
    End Sub

    Private Sub Student_Information_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateStudentMarticNumberTextBox.ReadOnly = True
        displayExistingStudent(matric_number)
    End Sub
    Private Sub displayExistingStudent(matric_number As String)
        Dim oldStudentRecord As studentRecord
        Try
            oldStudentRecord = Student.displayStudentInfo(matric_number)

            With Me
                .updateStudentMarticNumberTextBox.Text = oldStudentRecord.matric_number
                .updateStudentNameTextBox.Text = oldStudentRecord.name
                .updateStudentICNumberTextBox.Text = oldStudentRecord.ic_number
                .updateStudentEmailTextBox.Text = oldStudentRecord.email
                .updateStudentAddressTextBox.Text = oldStudentRecord.address
                .updateStudentPhoneNumberTextBox.Text = oldStudentRecord.phone_number
                .updateStudentDoBDateTimePicker.Value = oldStudentRecord.dob
                .updateStudentGenderComboBox.SelectedItem = oldStudentRecord.gender

            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub editStudentButton_Click(sender As Object, e As EventArgs) Handles editStudentButton.Click
        Dim updateStudentRecord As studentRecord
        Dim editOK As Boolean

        With updateStudentRecord
            .matric_number = updateStudentMarticNumberTextBox.Text
            .name = updateStudentNameTextBox.Text
            .ic_number = updateStudentICNumberTextBox.Text
            .email = updateStudentEmailTextBox.Text
            .address = updateStudentAddressTextBox.Text
            .phone_number = updateStudentPhoneNumberTextBox.Text
            .dob = updateStudentDoBDateTimePicker.Value.ToString("yyyy/MM/dd")
            .gender = updateStudentGenderComboBox.SelectedItem
        End With

        editOK = Student.updateStudent(updateStudentRecord)

        If editOK Then
            MessageBox.Show("Student Updated")
            Student_Information_Form.Show()
            Me.Close()
        End If

    End Sub
End Class