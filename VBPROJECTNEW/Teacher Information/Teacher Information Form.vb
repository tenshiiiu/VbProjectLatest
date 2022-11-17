Public Class Teacher_Information_Form
    Private Sub Teacher_Information_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddTeacherButton_Click(sender As Object, e As EventArgs) Handles AddTeacherButton.Click
        Teacher_Information_Add.Show()
        Me.Close()
    End Sub

    Private Sub UpdateTeacherButton_Click(sender As Object, e As EventArgs) Handles UpdateTeacherButton.Click
        Teacher_Information_Update.Show()
        Me.Close()

    End Sub

    Private Sub backToHomeButton_Click(sender As Object, e As EventArgs) Handles backToHomeButton.Click
        MainMenuForm.Show()
        Me.Close()
    End Sub
End Class