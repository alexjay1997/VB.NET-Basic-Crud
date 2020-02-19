Imports MySql.Data.MySqlClient
Module connection

    Public conn As New MySqlConnection
    Dim String_connection As String
    Dim Result As Boolean

    Public Function OpenConnection() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                String_connection = "host=localhost; username=root; password=''; database=vbnet2019_crud;"
                conn.ConnectionString = String_connection
                'conn.Open()
                Result = True

            End If
        Catch ex As Exception
            Result = False


        End Try

        Return Result
    End Function


End Module
