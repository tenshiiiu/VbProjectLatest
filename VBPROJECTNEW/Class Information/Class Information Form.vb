Imports MySql.Data.MySqlClient

Public Class Class_Information_Form

    Dim Mysqlconn As New MySqlConnection()
    Dim connection = "server=localhost;database=school;user=root;password=;"
    Dim button As New miscClass

    Dim Classroom As New ClassroomClass

    Dim col As Integer
    Dim classID, ID As String

    Public Sub displayData()
        Dim Command = New MySqlCommand("SELECT * FROM classroom")
        Command.Connection = Mysqlconn
        Command.ExecuteNonQuery()

        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter(Command)
        adapter.Fill(table)

        classDataGridView.DataSource = table
        classDataGridView.Columns(0).HeaderText = "CLASS ID"
        classDataGridView.Columns(1).HeaderText = "CLASS NAME"
        classDataGridView.Columns(2).HeaderText = "CURRENT STUDENT"
        classDataGridView.Columns(3).HeaderText = "MAXIMUM STUDENT"

    End Sub

    Private Sub Class_Information_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        button.disableButton(editClassButton, deleteClassButton)

        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            displayData()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try

    End Sub

    Private Sub addClassButton_Click(sender As Object, e As EventArgs) Handles addClassButton.Click
        Class_Information_Add.Show()
        Me.Close()
    End Sub

    Private Sub editClassButton_Click(sender As Object, e As EventArgs) Handles editClassButton.Click
        Class_Information_Update.classID = ID
        Class_Information_Update.Show()
        Me.Close()
    End Sub

    Private Sub backToHomeButton_Click(sender As Object, e As EventArgs) Handles backToHomeButton.Click
        MainMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub deleteClassButton_Click(sender As Object, e As EventArgs) Handles deleteClassButton.Click
        Dim deleteOk As Boolean

        deleteOk = Classroom.deleteClassroom(ID)

        If deleteOk Then
            MessageBox.Show("Classroom Deleted")
            Class_Information_Form_Load(sender, e)
        End If

    End Sub

    Private Sub classDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles classDataGridView.CellClick

        Try
            col = classDataGridView.CurrentCell.ColumnIndex

            If col <> 0 Then
                button.disableButton(editClassButton, deleteClassButton)
                Exit Sub
            End If

            classID = classDataGridView.CurrentCell.RowIndex

            If classID <> "" Then
                button.enableButton(editClassButton, deleteClassButton)
                ID = classDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class