Imports System.Data.SqlClient


Public Class login_page
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxemail.TextChanged

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bradley\Desktop\Vs Basic Project\SceneView\Sceneviewdb.mdf;Integrated Security=True")

        Dim cmd As New SqlCommand("select * from users where email = @email and password= @password", connection)

        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = TextBoxemail.Text
        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxpassword.Text

        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable()

        adapter.Fill(table)
        If table.Rows.Count <= 0 Then
            MessageBox.Show("Email or Password are incorrect")

        Else
            MessageBox.Show("Login successful")

            Me.Hide()

            Dim Form3 As New Form3()
            Form3.Show()
        End If


    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click

        Me.Close()

    End Sub
End Class