Public Class Staff_Form
    Private Sub Staff_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SchoolDataSetDataSet.loginuser' table. You can move, or remove it, as needed.
        Me.LoginuserTableAdapter.Fill(Me.SchoolDataSetDataSet.loginuser)

    End Sub
End Class