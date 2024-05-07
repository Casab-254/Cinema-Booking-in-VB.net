Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Runtime.Versioning


Public Class register
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub registration_Click(sender As Object, e As EventArgs) Handles registration.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub register_btn_Click(sender As Object, e As EventArgs) Handles register_btn.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bradley\Desktop\Vs Basic Project\SceneView\Sceneviewdb.mdf;Integrated Security=True"
        con.Open()


        If (fname.Text = "" Or lname.Text = "" Or gender.Text = "" Or phone.Text = "" Or email.Text = "" Or password.Text = "") Then
            MessageBox.Show("Please fill all the fields")
        Else
            cmd = New SqlCommand("INSERT INTO users values('" & fname.Text & "','" & lname.Text & "','" & gender.Text & "','" & phone.Text & "','" & email.Text & "','" & password.Text & "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Your Registration Was Successfull. Welcome to SceneView", MsgBoxStyle.Information, "Success")
            Me.Hide()

            Dim Form3 As New Form3()
            Form3.Show()

            'login.Show()
            fname.Clear()
            lname.Clear()
            phone.Clear()
            email.Clear()
            password.Clear()
        End If

        con.Close()

    End Sub

    Private Sub Buttoncancel_Click(sender As Object, e As EventArgs) Handles Buttoncancel.Click
        Me.Close()
    End Sub
End Class