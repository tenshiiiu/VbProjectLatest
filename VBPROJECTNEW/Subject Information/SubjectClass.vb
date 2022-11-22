Imports MySql.Data.MySqlClient
Friend Structure SubjectRecord
    Dim subject_id, subject_name As String
    Dim credit, fee As Integer
End Structure

Public Class SubjectClass

    Dim Mysqlconn As New MySqlConnection()
    Dim connection = "server=localhost;database=school;user=root;password=;"

    Friend Sub displayData(dataGrid As DataGridView)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("SELECT * FROM subject")
            Command.Connection = Mysqlconn
            Command.ExecuteNonQuery()


            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(Command)
            adapter.Fill(table)

            dataGrid.DataSource = table

            dataGrid.Columns(0).HeaderText = "Subject ID"
            dataGrid.Columns(1).HeaderText = "Subject Name"
            dataGrid.Columns(2).HeaderText = "Credit"
            dataGrid.Columns(3).HeaderText = "Fee"

            Mysqlconn.Close()

        Catch myerror As MySqlException
            MessageBox.Show(myerror.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub

    Friend Function displayExistingSubjectInfo(subject_id) As SubjectRecord
        Dim existingSubjectRecord As SubjectRecord
        Dim dr As MySqlDataReader

        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("SELECT * FROM subject WHERE subject_id=@subject_id")
            Command.Connection = Mysqlconn

            Command.Parameters.AddWithValue("@subject_id", subject_id)
            dr = Command.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                existingSubjectRecord.subject_id = dr("subject_id").ToString
                existingSubjectRecord.subject_name = dr("subject_name").ToString
                existingSubjectRecord.credit = dr("credit").ToString
                existingSubjectRecord.fee = dr("fee").ToString

                Mysqlconn.Close()

                Return existingSubjectRecord
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function

    Friend Function addSubject(newSubjectRecord As SubjectRecord)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("INSERT INTO subject(subject_id, subject_name, credit, fee) 
                                                        VALUES(@subject_id, @subject_name, @credit, @fee)")
            Command.Connection = Mysqlconn

            Command.Parameters.AddWithValue("@subject_id", newSubjectRecord.subject_id)
            Command.Parameters.AddWithValue("@subject_name", newSubjectRecord.subject_name)
            Command.Parameters.AddWithValue("@credit", newSubjectRecord.credit)
            Command.Parameters.AddWithValue("@fee", newSubjectRecord.fee)

            Command.ExecuteNonQuery()

            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try

        Return True

    End Function

    Friend Function updateSubject(updateSubjectRecord As SubjectRecord)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("UPDATE subject SET subject_name=@subject_name, credit=@credit, fee=@fee
                                                            WHERE  subject_id=@subject_id")

            Command.Connection = Mysqlconn

            Command.Parameters.AddWithValue("@subject_id", updateSubjectRecord.subject_id)
            Command.Parameters.AddWithValue("@subject_name", updateSubjectRecord.subject_name)
            Command.Parameters.AddWithValue("@fee", updateSubjectRecord.fee)
            Command.Parameters.AddWithValue("@credit", updateSubjectRecord.credit)

            Command.ExecuteNonQuery()

            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try

        Return True
    End Function

    Friend Function deleteSubject(subject_id As String)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("DELETE FROM subject WHERE subject_id=@subject_id")
            Command.Connection = Mysqlconn
            Command.Parameters.AddWithValue("@subject_id", subject_id)
            Command.ExecuteNonQuery()

            Mysqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            Mysqlconn.Dispose()
        End Try

        Return True
    End Function

    Friend Sub FilterData(valueToSearch As String, datagrid As DataGridView)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim searchQuery As String = "SELECT * FROM subject WHERE subject_id LIKE '%" & valueToSearch & "%' OR subject_name LIKE '%" & valueToSearch & "%'"

            Dim Command = New MySqlCommand(searchQuery)
            Command.Connection = Mysqlconn
            Command.ExecuteNonQuery()

            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(Command)
            adapter.Fill(table)

            datagrid.DataSource = table

            Mysqlconn.Close()

        Catch myerror As MySqlException
            MessageBox.Show(myerror.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub

End Class
