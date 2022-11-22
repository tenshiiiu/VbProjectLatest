Imports MySql.Data.MySqlClient
Friend Structure teacherRecord
    Dim teacher_id, name, ic_number, address, phone_number, email, dob, gender As String
End Structure

Public Class TeacherClass

    Dim Mysqlconn As New MySqlConnection()
    Dim connection = "server=localhost;database=school;user=root;password=;"

    Friend Sub displayData(dataGrid As DataGridView)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("SELECT * FROM teacher")
            Command.Connection = Mysqlconn
            Command.ExecuteNonQuery()


            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(Command)
            adapter.Fill(table)

            dataGrid.DataSource = table

            dataGrid.Columns(0).HeaderText = "Teacher ID"
            dataGrid.Columns(1).HeaderText = "Name"
            dataGrid.Columns(2).HeaderText = "IC Number"
            dataGrid.Columns(3).HeaderText = "Email"
            dataGrid.Columns(4).HeaderText = "Phone Number"
            dataGrid.Columns(5).HeaderText = "Address"
            dataGrid.Columns(6).HeaderText = "Date Of Birth"
            dataGrid.Columns(7).HeaderText = "Gender"

            Mysqlconn.Close()

        Catch myerror As MySqlException
            MessageBox.Show(myerror.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub

    Friend Function displayExistingTeacherInfo(teacher_id) As teacherRecord
        Dim existingTeacherRecord As teacherRecord
        Dim dr As MySqlDataReader

        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("SELECT * FROM teacher WHERE teacher_id=@teacher_id")
            Command.Connection = Mysqlconn

            Command.Parameters.AddWithValue("@teacher_id", teacher_id)
            dr = Command.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                existingTeacherRecord.teacher_id = dr("teacher_id").ToString
                existingTeacherRecord.name = dr("name").ToString
                existingTeacherRecord.ic_number = dr("ic_number").ToString
                existingTeacherRecord.email = dr("email").ToString
                existingTeacherRecord.phone_number = dr("phone_number").ToString
                existingTeacherRecord.address = dr("address").ToString
                existingTeacherRecord.dob = dr("dob").ToString
                existingTeacherRecord.gender = dr("gender").ToString

                Mysqlconn.Close()

                Return existingTeacherRecord
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function

    Friend Function addTeacher(newTeacherRecord As teacherRecord)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("INSERT INTO teacher(teacher_id, name, ic_number, email, phone_number, address, dob, gender) 
                                            VALUES(@teacher_id, @name, @ic_number, @email, @phone_number, @address, @dob, @gender)")
            Command.Connection = Mysqlconn

            Command.Parameters.AddWithValue("@teacher_id", newTeacherRecord.teacher_id)
            Command.Parameters.AddWithValue("@name", newTeacherRecord.name)
            Command.Parameters.AddWithValue("@ic_number", newTeacherRecord.ic_number)
            Command.Parameters.AddWithValue("@email", newTeacherRecord.email)
            Command.Parameters.AddWithValue("@phone_number", newTeacherRecord.phone_number)
            Command.Parameters.AddWithValue("@address", newTeacherRecord.address)
            Command.Parameters.AddWithValue("@dob", newTeacherRecord.dob)
            Command.Parameters.AddWithValue("@gender", newTeacherRecord.gender)

            Command.ExecuteNonQuery()

            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try

        Return True

    End Function

    Friend Function updateTeacher(updateTeacherRecord As teacherRecord)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("UPDATE teacher SET name=@name, ic_number=@ic_number, 
                                                               email=@email, phone_number=@phone_number, address=@address, dob=@dob, gender=@gender WHERE teacher_id=@teacher_id")

            Command.Connection = Mysqlconn

            Command.Parameters.AddWithValue("@teacher_id", updateTeacherRecord.teacher_id)
            Command.Parameters.AddWithValue("@name", updateTeacherRecord.name)
            Command.Parameters.AddWithValue("@ic_number", updateTeacherRecord.ic_number)
            Command.Parameters.AddWithValue("@address", updateTeacherRecord.address)
            Command.Parameters.AddWithValue("@email", updateTeacherRecord.email)
            Command.Parameters.AddWithValue("@phone_number", updateTeacherRecord.phone_number)
            Command.Parameters.AddWithValue("@dob", updateTeacherRecord.dob)
            Command.Parameters.AddWithValue("@gender", updateTeacherRecord.gender)

            Command.ExecuteNonQuery()

            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try

        Return True
    End Function

    Friend Function deleteTeacher(teacher_id As String)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("DELETE FROM teacher WHERE teacher_id=@teacher_id")
            Command.Connection = Mysqlconn
            Command.Parameters.AddWithValue("@teacher_id", teacher_id)
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

            Dim searchQuery As String = "SELECT * FROM teacher WHERE ic_number LIKE '%" & valueToSearch & "%' OR name LIKE '%" & valueToSearch & "%'"

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
