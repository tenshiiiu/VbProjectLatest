Imports MySql.Data.MySqlClient

Friend Structure classroomRecord
    Dim class_id, class_name As String
    Dim current_student, maximum_student As Integer
End Structure

Public Class ClassroomClass

    Dim Mysqlconn As New MySqlConnection()
    Dim connection = "server=localhost;database=school;user=root;password=;"

    Friend Function getClassroomInfo(classID) As classroomRecord
        Dim classRecord As classroomRecord
        Dim dr As MySqlDataReader

        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("SELECT * FROM classroom WHERE class_id=@class_id")
            Command.Connection = Mysqlconn

            Command.Parameters.AddWithValue("class_id", classID)
            dr = Command.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                classRecord.class_id = dr("class_id").ToString
                classRecord.class_name = dr("class_name").ToString
                classRecord.current_student = dr("current_student").ToString
                classRecord.maximum_student = dr("maximum_student").ToString

                Mysqlconn.Close()
                Return classRecord
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return classRecord
    End Function

    Friend Function addClassroom(newClassroomRecord As classroomRecord)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("INSERT INTO classroom(class_id, class_name, current_student, maximum_student) VALUES(@class_id, @class_name, 0, @maximum_student)")
            Command.Connection = Mysqlconn

            Command.Parameters.AddWithValue("@class_id", newClassroomRecord.class_id)
            Command.Parameters.AddWithValue("@class_name", newClassroomRecord.class_name)
            Command.Parameters.AddWithValue("@maximum_student", newClassroomRecord.maximum_student)
            Command.ExecuteNonQuery()

            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try

        Return True
    End Function

    Friend Function updateClassroom(updateClassroomRecord As classroomRecord)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("UPDATE classroom SET class_id = @class_id, class_name = @class_name, maximum_student = @maximum_student")
            Command.Connection = Mysqlconn

            Command.Parameters.AddWithValue("@class_id", updateClassroomRecord.class_id)
            Command.Parameters.AddWithValue("@class_name", updateClassroomRecord.class_name)
            Command.Parameters.AddWithValue("@maximum_student", updateClassroomRecord.maximum_student)
            Command.ExecuteNonQuery()

            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try

        Return True
    End Function

    Friend Function deleteClassroom(classID As String)
        Try
            Mysqlconn.ConnectionString = connection
            Mysqlconn.Open()

            Dim Command = New MySqlCommand("DELETE FROM classroom WHERE class_id=@class_id")
            Command.Connection = Mysqlconn
            Command.Parameters.AddWithValue("@class_id", classID)
            Command.ExecuteNonQuery()

            Mysqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            Mysqlconn.Dispose()
        End Try

        Return True
    End Function

End Class
