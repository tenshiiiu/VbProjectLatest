Public Class Teacher_Information_Update

    Dim Teacher As New TeacherClass
    Public TeacherID As String

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Teacher_Information_Form.Show()
        Me.Close()
    End Sub

    Private Sub Teacher_Information_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTeacherIDTextBox.ReadOnly = True
        displayExistingTeacher(TeacherID)
    End Sub

    Private Sub displayExistingTeacher(teacher_id As String)
        Dim oldTeacherRecord As teacherRecord
        Try
            oldTeacherRecord = Teacher.displayExistingTeacherInfo(teacher_id)

            With Me
                .updateTeacherIDTextBox.Text = oldTeacherRecord.teacher_id
                .updateTeacherNameTextBox.Text = oldTeacherRecord.name
                .updateTeacherICNumberTextBox.Text = oldTeacherRecord.ic_number
                .updateTeacherEmailTextBox.Text = oldTeacherRecord.email
                .updateTeacherAddressTextBox.Text = oldTeacherRecord.address
                .updateTeacherPhoneNumberTextBox.Text = oldTeacherRecord.phone_number
                .updateTeacherDoBDateTimePicker.Value = oldTeacherRecord.dob
                .updateTeacherGenderComboBox.SelectedItem = oldTeacherRecord.gender

            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateTeacherButton_Click(sender As Object, e As EventArgs) Handles UpdateTeacherButton.Click
        Dim updateTeacherRecord As teacherRecord
        Dim editOK As Boolean

        With updateTeacherRecord
            .teacher_id = updateTeacherIDTextBox.Text
            .name = updateTeacherNameTextBox.Text
            .ic_number = updateTeacherICNumberTextBox.Text
            .email = updateTeacherEmailTextBox.Text
            .address = updateTeacherAddressTextBox.Text
            .phone_number = updateTeacherPhoneNumberTextBox.Text
            .dob = updateTeacherDoBDateTimePicker.Value.ToString("yyyy/MM/dd")
            .gender = updateTeacherGenderComboBox.SelectedItem
        End With

        editOK = Teacher.updateTeacher(updateTeacherRecord)

        If editOK Then
            MessageBox.Show("Teacher Information Updated")
            Teacher_Information_Form.Show()
            Me.Close()
        End If
    End Sub

End Class