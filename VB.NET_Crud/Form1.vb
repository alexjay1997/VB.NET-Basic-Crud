Imports MySql.Data.MySqlClient

Public Class Form1

    Public conn As New MySqlConnection("host=localhost; username=root; password=''; database=vbnet2019_crud;")
    Public Sql_query_cmd As New MySqlCommand
    Public datareader As MySqlDataReader
    Public Adapter As MySqlDataAdapter

    Dim dataset As New DataSet





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Label1.Text = "Username"
        Me.Label2.Text = "Password"
        Me.Label3.Text = "Email"
        Me.label_emp_id.Text = "Employee"

        GetRecords()




    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GetRecords()




        dataset = New DataSet
        Adapter = New MySqlDataAdapter("Select * from tbl_emp", conn)
        Adapter.Fill(dataset, "tbl_emp")

        DataGridView1.DataSource = dataset
        DataGridView1.DataMember = "tbl_emp"




    End Sub

    Private Sub Button_Add_Emp_Click(sender As Object, e As EventArgs) Handles Button_Add_emp.Click
        Try

            conn.Open()
            Sql_query_cmd.Connection = conn
            Sql_query_cmd.CommandType = CommandType.Text
            Sql_query_cmd.CommandText = "Select * from tbl_emp where username ='" & TextBox_username.Text & "'"

            datareader = Sql_query_cmd.ExecuteReader

            If datareader.HasRows Then
                MsgBox("Already Exist!", MsgBoxStyle.Exclamation)

                conn.Close()
            Else
                conn.Close()
                conn.Open()
                Sql_query_cmd = New MySqlCommand("Insert into tbl_emp (username,password,email) VALUES ('" & TextBox_username.Text & "','" & TextBox_password.Text & "','" & TextBox_email.Text & "')", conn)

                Sql_query_cmd.ExecuteNonQuery()

                MsgBox("New Record Added!", MsgBoxStyle.Information)

                Me.label_emp_id.Text = ""
                Me.TextBox_username.Text = ""
                Me.TextBox_password.Text = ""
                Me.TextBox_email.Text = ""

                conn.Close()


                GetRecords()


            End If







        Catch ex As Exception
            MsgBox("Already Exist!", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button_Edit_Emp_Click(sender As Object, e As EventArgs) Handles Button_Edit_Emp.Click

        Dim i As Integer

        i = DataGridView1.CurrentRow.Index

        label_emp_id.Text = DataGridView1.Item(0, i).Value

        TextBox_username.Text = DataGridView1.Item(1, i).Value
        TextBox_password.Text = DataGridView1.Item(2, i).Value
        TextBox_email.Text = DataGridView1.Item(3, i).Value



    End Sub

    Private Sub label_emp_id_Click(sender As Object, e As EventArgs) Handles label_emp_id.Click

    End Sub

    Private Sub Button_Update_Emp_Click(sender As Object, e As EventArgs) Handles Button_Update_Emp.Click

        conn.Open()

        Dim query_update As String

        query_update = "Update tbl_emp  set username ='" & TextBox_username.Text & "', password ='" & TextBox_password.Text & "' ,email = '" & TextBox_email.Text & "' where id = '" & label_emp_id.Text & "'"

        Sql_query_cmd = New MySqlCommand(query_update, conn)


        Sql_query_cmd.ExecuteReader()


        MsgBox(" Record Updated!", MsgBoxStyle.Information)

        Me.label_emp_id.Text = ""
        Me.TextBox_username.Text = ""
        Me.TextBox_password.Text = ""
        Me.TextBox_email.Text = ""

        conn.Close()


        GetRecords()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_clear.Click


        Me.TextBox_username.Clear()
        Me.TextBox_password.Clear()
        Me.TextBox_email.Clear()
        Me.label_emp_id.Text = ""




    End Sub

    Private Sub Button_Delete_Emp_Click(sender As Object, e As EventArgs) Handles Button_Delete_Emp.Click



        conn.Open()

        Dim query_delete As String

        query_delete = "Delete from tbl_emp  where id = '" & label_emp_id.Text & "'"

        Sql_query_cmd = New MySqlCommand(query_delete, conn)


        Sql_query_cmd.ExecuteReader()


        MsgBox(" Record Deleted!", MsgBoxStyle.Critical)

        Me.label_emp_id.Text = ""
        Me.TextBox_username.Text = ""
        Me.TextBox_password.Text = ""
        Me.TextBox_email.Text = ""

        conn.Close()


        GetRecords()



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click

    End Sub
End Class
