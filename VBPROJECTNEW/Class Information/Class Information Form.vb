Public Class Class_Information_Form
    Private Sub addClassButton_Click(sender As Object, e As EventArgs) Handles addClassButton.Click
        Class_Information_Add.Show()
        Me.Close()
    End Sub

    Private Sub editClassButton_Click(sender As Object, e As EventArgs) Handles editClassButton.Click
        Class_Information_Update.Show()
        Me.Close()
    End Sub

    Private Sub backToHomeButton_Click(sender As Object, e As EventArgs) Handles backToHomeButton.Click
        MainMenuForm.Show()
        Me.Close()
    End Sub
End Class