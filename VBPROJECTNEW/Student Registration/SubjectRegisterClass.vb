Imports MySql.Data.MySqlClient
Imports ComponentFactory.Krypton.Toolkit

Friend Structure SubjectRegisterRecord
    Dim subject_id, student_id As String
End Structure

Public Class SubjectRegisterClass

    Dim Mysqlconn As New MySqlConnection()
    Dim connection = "server=localhost;database=school;user=root;password=;"

    Friend Sub displayData(dataGrid As DataGridView)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("SELECT matric_number, name FROM student")
            Command.Connection = Mysqlconn
            Command.ExecuteNonQuery()


            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(Command)
            adapter.Fill(table)

            dataGrid.DataSource = table

            dataGrid.Columns(0).HeaderText = "Matric Number"
            dataGrid.Columns(1).HeaderText = "Name"

            Mysqlconn.Close()

        Catch myerror As MySqlException
            MessageBox.Show(myerror.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub

    Friend Function displayFee(student_id As String)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim sum As Integer

            Dim Command = New MySqlCommand("SELECT subject_register.subject_id, subject.fee FROM subject_register, subject WHERE subject_register.student_id=@student_id AND subject.subject_id = subject_register.subject_id")
            Command.Connection = Mysqlconn
            Command.Parameters.AddWithValue("@student_id", student_id)
            Dim reader As MySqlDataReader = Command.ExecuteReader()

            While reader.Read()
                sum += Integer.Parse(reader("fee"))
            End While

            reader.Close()


            Mysqlconn.Close()

            Return sum
        Catch myerror As MySqlException
            MessageBox.Show(myerror.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Function

    Friend Function displayStudentInfo(student_id As String)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim info(2) As String

            Dim Command = New MySqlCommand("SELECT name, matric_number FROM student WHERE matric_number=@student_id")
            Command.Connection = Mysqlconn
            Command.Parameters.AddWithValue("@student_id", student_id)
            Dim reader As MySqlDataReader = Command.ExecuteReader()

            While reader.Read()
                info(0) = reader("name")
                info(1) = reader("matric_number")
            End While

            reader.Close()


            Mysqlconn.Close()

            Return info
        Catch myerror As MySqlException
            MessageBox.Show(myerror.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Function

    Friend Function displayTotalCredit(student_id As String)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim credit As Integer

            Dim Command = New MySqlCommand("SELECT subject_register.subject_id, subject.credit FROM subject_register, subject WHERE subject_register.student_id=@student_id AND subject.subject_id = subject_register.subject_id")
            Command.Connection = Mysqlconn
            Command.Parameters.AddWithValue("@student_id", student_id)
            Dim reader As MySqlDataReader = Command.ExecuteReader()

            While reader.Read()
                credit += Integer.Parse(reader("credit"))
            End While

            reader.Close()


            Mysqlconn.Close()

            Return credit
        Catch myerror As MySqlException
            MessageBox.Show(myerror.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Function

    Friend Sub displaySubjectData(student_id As String, datagrid As DataGridView)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("SELECT a.subject_id, b.subject_name FROM subject_register AS a INNER JOIN subject AS b ON a.subject_id=b.subject_id WHERE student_id=@student_id ")
            Command.Connection = Mysqlconn
            Command.Parameters.AddWithValue("@student_id", student_id)
            Command.ExecuteScalar()


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

    Friend Sub displaySubjectComboBox(sujectComboBox As KryptonComboBox)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("SELECT * FROM subject")
            Command.Connection = Mysqlconn
            Command.ExecuteNonQuery()


            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(Command)
            adapter.Fill(table)

            sujectComboBox.DataSource = table
            sujectComboBox.DisplayMember = "subject_name"
            sujectComboBox.ValueMember = "subject_id"

            Mysqlconn.Close()


        Catch myerror As MySqlException
            MessageBox.Show(myerror.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub

    Friend Function addSubject(matric_number, subject_id) As String
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("INSERT INTO subject_register(student_id, subject_id) 
                                            VALUES(@student_id, @subject_id)")
            Command.Connection = Mysqlconn

            Command.Parameters.AddWithValue("@student_id", matric_number)
            Command.Parameters.AddWithValue("@subject_id", subject_id)
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

            Dim Command = New MySqlCommand("DELETE FROM subject_register WHERE subject_id=@subject_id")
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

    Friend Function displayStudentInfo(student_id) As studentRecord
        Dim existingSudentRecord As studentRecord
        Dim dr As MySqlDataReader

        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("SELECT * FROM student WHERE matric_number=@matric_number")
            Command.Parameters.AddWithValue("@matric_number", student_id)
            Command.Connection = Mysqlconn

            dr = Command.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                existingSudentRecord.matric_number = dr("matric_number").ToString
                existingSudentRecord.name = dr("name").ToString

                Mysqlconn.Close()

                Return existingSudentRecord
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try

        Return existingSudentRecord
    End Function




    Friend Sub FilterData(valueToSearch As String, datagrid As DataGridView)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim searchQuery As String = "SELECT * FROM student WHERE matric_number LIKE '%" & valueToSearch & "%' OR name LIKE '%" & valueToSearch & "%'"

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
