Public Class Class_Information_Update
    Public classID As String
    Dim Classroom As New ClassroomClass
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Class_Information_Form.Show()
        Me.Close()
    End Sub

    Private Sub Class_Information_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        classIDTextBox.ReadOnly = True
        displayExistingClassroom(classID)
    End Sub

    Private Sub displayExistingClassroom(classID As String)
        Dim oldClassroomRecord As classroomRecord
        Try
            oldClassroomRecord = Classroom.getClassroomInfo(classID)
            With Me
                .classIDTextBox.Text = oldClassroomRecord.class_id
                .updateClassNameTextBox.Text = oldClassroomRecord.class_name
                .maximumStudentTextBox.Text = oldClassroomRecord.maximum_student
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub maximumStudentTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles maximumStudentTextBox.KeyPress
        Dim number As New miscClass
        number.numberOnly(sender, e)
    End Sub

    Private Sub UpdateClassButton_Click(sender As Object, e As EventArgs) Handles UpdateClassButton.Click
        Dim editClassroomRecord As classroomRecord
        Dim editOK As Boolean

        With editClassroomRecord
            .class_id = classIDTextBox.Text
            .class_name = updateClassNameTextBox.Text
            .maximum_student = maximumStudentTextBox.Text
        End With

        editOK = Classroom.updateClassroom(editClassroomRecord)

        If editOK Then
            MessageBox.Show("Classroom Updated")
            Class_Information_Form.Show()
            Me.Close()
        End If

    End Sub
End Class