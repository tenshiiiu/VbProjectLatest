Imports MySql.Data.MySqlClient
Friend Structure studentRecord
    Dim matric_number, name, ic_number, email, phone_number, address, dob, gender, class_id As String
End Structure

Public Class StudentClass
    Dim Mysqlconn As New MySqlConnection()
    Dim connection = "server=localhost;database=school;user=root;password=;"

    Friend Sub displayData(dataGrid As DataGridView)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("SELECT * FROM student")
            Command.Connection = Mysqlconn
            Command.ExecuteNonQuery()


            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(Command)
            adapter.Fill(table)

            dataGrid.DataSource = table

            dataGrid.Columns(0).HeaderText = "Matric Number"
            dataGrid.Columns(1).HeaderText = "Name"
            dataGrid.Columns(2).HeaderText = "IC Number"
            dataGrid.Columns(3).HeaderText = "Email"
            dataGrid.Columns(4).HeaderText = "Phone Number"
            dataGrid.Columns(5).HeaderText = "Address"
            dataGrid.Columns(6).HeaderText = "Date Of Birth"
            dataGrid.Columns(7).HeaderText = "Gender"
            dataGrid.Columns(8).Visible = False

            Mysqlconn.Close()

        Catch myerror As MySqlException
            MessageBox.Show(myerror.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub

    Friend Function displayStudentInfo(matric_number) As studentRecord
        Dim existingSudentRecord As studentRecord
        Dim dr As MySqlDataReader

        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("SELECT * FROM student WHERE matric_number=@matric_number")
            Command.Connection = Mysqlconn

            Command.Parameters.AddWithValue("@matric_number", matric_number)
            dr = Command.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                existingSudentRecord.matric_number = dr("matric_number").ToString
                existingSudentRecord.name = dr("name").ToString
                existingSudentRecord.ic_number = dr("ic_number").ToString
                existingSudentRecord.email = dr("email").ToString
                existingSudentRecord.phone_number = dr("phone_number").ToString
                existingSudentRecord.address = dr("address").ToString
                existingSudentRecord.dob = dr("dob").ToString
                existingSudentRecord.gender = dr("gender").ToString

                Mysqlconn.Close()

                Return existingSudentRecord
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return existingSudentRecord
    End Function

    Friend Function addStudent(newStudentRecord As studentRecord)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("INSERT INTO student(matric_number, name, ic_number, email, phone_number, address, dob, gender) 
                                            VALUES(@matric_number, @name, @ic_number, @email, @phone_number, @address, @dob, @gender)")
            Command.Connection = Mysqlconn

            Command.Parameters.AddWithValue("@matric_number", newStudentRecord.matric_number)
            Command.Parameters.AddWithValue("@name", newStudentRecord.name)
            Command.Parameters.AddWithValue("@ic_number", newStudentRecord.ic_number)
            Command.Parameters.AddWithValue("@email", newStudentRecord.email)
            Command.Parameters.AddWithValue("@phone_number", newStudentRecord.phone_number)
            Command.Parameters.AddWithValue("@address", newStudentRecord.address)
            Command.Parameters.AddWithValue("@dob", newStudentRecord.dob)
            Command.Parameters.AddWithValue("@gender", newStudentRecord.gender)

            Command.ExecuteNonQuery()

            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try

        Return True

    End Function

    Friend Function updateStudent(updateStudentRecord As studentRecord)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("UPDATE student SET name=@name, ic_number=@ic_number, 
                                                               email=@email, phone_number=@phone_number, address=@address, dob=@dob, gender=@gender WHERE matric_number=@matric_number")

            Command.Connection = Mysqlconn

            Command.Parameters.AddWithValue("@matric_number", updateStudentRecord.matric_number)
            Command.Parameters.AddWithValue("@name", updateStudentRecord.name)
            Command.Parameters.AddWithValue("@ic_number", updateStudentRecord.ic_number)
            Command.Parameters.AddWithValue("@address", updateStudentRecord.address)
            Command.Parameters.AddWithValue("@email", updateStudentRecord.email)
            Command.Parameters.AddWithValue("@phone_number", updateStudentRecord.phone_number)
            Command.Parameters.AddWithValue("@dob", updateStudentRecord.dob)
            Command.Parameters.AddWithValue("@gender", updateStudentRecord.gender)

            Command.ExecuteNonQuery()

            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try

        Return True
    End Function

    Friend Function deleteStudent(matric_number As String)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("DELETE FROM student WHERE matric_number=@matric_number")
            Command.Connection = Mysqlconn
            Command.Parameters.AddWithValue("@matric_number", matric_number)
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

            Dim searchQuery As String = "SELECT * FROM student WHERE ic_number LIKE '%" & valueToSearch & "%' OR name LIKE '%" & valueToSearch & "%'"

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
