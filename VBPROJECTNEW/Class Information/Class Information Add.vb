Public Class Class_Information_Add

    Dim Classroom As New ClassroomClass
    Dim addClassroomRecord As New classroomRecord

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Class_Information_Form.Show()
        Me.Close()
    End Sub

    Private Sub AddClassButton_Click(sender As Object, e As EventArgs) Handles AddClassButton.Click

        Dim addOk As Boolean

        With addClassroomRecord
            .class_id = addClassIDTextBox.Text
            .class_name = addClassNameTextBox.Text
            .maximum_student = addMaximumStudentTextBox.Text
        End With

        addOk = Classroom.addClassroom(addClassroomRecord)

        If addOk Then
            MessageBox.Show("Classroom Added")
            Class_Information_Form.Show()
            Me.Close()
        Else
            Exit Sub
        End If


    End Sub

    Private Sub addMaximumStudentTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles addMaximumStudentTextBox.KeyPress
        Dim number As New miscClass
        number.numberOnly(sender, e)
    End Sub


End Class