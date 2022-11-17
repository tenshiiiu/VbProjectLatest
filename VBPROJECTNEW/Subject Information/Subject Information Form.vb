Public Class Subject_Information_Form
    Private Sub Subject_Information_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddSubjectButton_Click(sender As Object, e As EventArgs) Handles AddSubjectButton.Click
        Subject_Information_Add.Show()
        Me.Close()
    End Sub

    Private Sub UpdateSubjectButton_Click(sender As Object, e As EventArgs) Handles UpdateSubjectButton.Click
        Subject_Information_Update.Show()
        Me.Close()
    End Sub

    Private Sub backToHomeButton_Click(sender As Object, e As EventArgs) Handles backToHomeButton.Click
        MainMenuForm.Show()
        Me.Close()
    End Sub
End Class