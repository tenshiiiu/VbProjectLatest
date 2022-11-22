Imports MySql.Data.MySqlClient

Public Class Student_Subject_Information_Form

    Dim SubjectRegister As New SubjectRegisterClass
    Public student_id As String
    Dim Fee, Credit, info(2) As String


    Private Sub Student_Subject_Information_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fee = SubjectRegister.displayFee(student_id)
        Credit = SubjectRegister.displayTotalCredit(student_id)

        info = SubjectRegister.displayStudentInfo(student_id)

        nameLabel.Text = info(0).ToString
        matricNumberLabel.Text = info(1).ToString

        totalCreditLabel.Text = Credit
        feeLabel.Text = "RM " + Fee


        SubjectRegister.displaySubjectData(student_id, subjectDataGridView)
    End Sub

End Class