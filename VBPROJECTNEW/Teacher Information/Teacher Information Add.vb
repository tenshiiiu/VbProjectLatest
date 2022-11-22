Public Class Teacher_Information_Add

    Dim Teacher As New TeacherClass

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Teacher_Information_Form.Show()
        Me.Close()
    End Sub

    Private Sub addTeacherButton_Click(sender As Object, e As EventArgs) Handles addTeacherButton.Click
        Dim newTeacherRecord As teacherRecord
        Dim addOk As Boolean

        With newTeacherRecord
            .teacher_id = addTeacherIDTextBox.Text
            .name = addTeacherNameTextBox.Text
            .ic_number = addTeacherICNumberTextBox.Text
            .email = addTeacherEmailTextBox.Text
            .address = addTeacherAddressTextBox.Text
            .phone_number = addTeacherPhoneNumberTextBox.Text
            .dob = addTeacherDoBDateTimePicker.Value.Date.ToString("yyyy/MM/dd")
            .gender = addTeacherGenderComboBox.Text
        End With

        addOk = Teacher.addTeacher(newTeacherRecord)

        If addOk Then
            MessageBox.Show("Teacher Information Added")
            Teacher_Information_Form.Show()
            Me.Close()
        End If

    End Sub
End Class