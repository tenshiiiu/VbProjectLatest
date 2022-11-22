Public Class Student_Information_Add

    Dim Student As New StudentClass

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Student_Information_Form.Show()
        Me.Close()
    End Sub

    Private Sub addStudentButton_Click(sender As Object, e As EventArgs) Handles addStudentButton.Click
        Dim newStudentRecord As studentRecord
        Dim addOk As Boolean

        With newStudentRecord
            .matric_number = addStudentMarticNumberTextBox.Text
            .name = addStudentNameTextBox.Text
            .ic_number = addStudentICNumberTextBox.Text
            .email = addStudentEmailTextBox.Text
            .address = addStudentAddressTextBox.Text
            .phone_number = addStudentPhoneNumberTextBox.Text
            .dob = addStudentDoBDateTimePicker.Value.Date.ToString("yyyy/MM/dd")
            .gender = addStudentGenderComboBox.Text
        End With

        addOk = Student.addStudent(newStudentRecord)

        If addOk Then
            MessageBox.Show("Student Added")
            Student_Information_Form.Show()
            Me.Close()
        End If

    End Sub

End Class