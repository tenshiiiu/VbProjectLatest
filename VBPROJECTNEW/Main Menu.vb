Public Class MainMenuForm
    Private Sub ListOfTeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfTeacherToolStripMenuItem.Click
        Teacher_Information_Form.Show()
        Me.Close()
    End Sub

    Private Sub UserManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserManagementToolStripMenuItem.Click

    End Sub

    Private Sub SubjectListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubjectListToolStripMenuItem.Click
        Subject_Information_Form.Show()
        Me.Close()
    End Sub

    Private Sub ListOfStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfStudentToolStripMenuItem.Click
        Student_Information_Form.Show()
        Me.Close()
    End Sub

    Private Sub ListOfSubjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfSubjectToolStripMenuItem.Click
        Subject_Information_Form.Show()
        Me.Close()
    End Sub

    Private Sub LisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LisToolStripMenuItem.Click
        Class_Information_Form.Show()
        Me.Close()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login_Form.Show()
        Me.Close()
    End Sub

End Class
