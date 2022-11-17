Public Class Student_Information_Form
    Private Sub Student_Information_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub disableButton()
        With Me
            .AddStudentButton.Enabled = False
            .UpdateStudentButton.Enabled = False
            .deleteStudentButton.Enabled = False
        End With
    End Sub
    Private Sub enableButton()
        With Me
            .AddStudentButton.Enabled = True
            .UpdateStudentButton.Enabled = True
            .deleteStudentButton.Enabled = True
        End With
    End Sub

    Private Sub backToHomeButton_Click(sender As Object, e As EventArgs) Handles backToHomeButton.Click
        MainMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub AddStudentButton_Click(sender As Object, e As EventArgs) Handles AddStudentButton.Click
        Student_Information_Add.Show()
        Me.Close()
    End Sub

    Private Sub UpdateStudentButton_Click(sender As Object, e As EventArgs) Handles UpdateStudentButton.Click
        Student_Information_Update.Show()
        Me.Close()
    End Sub
End Class