Imports System.Data.SqlClient



Public Class Form4

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        Dim con As New SqlConnection


        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bradley\Desktop\Vs Basic Project\SceneView\Sceneviewdb.mdf;Integrated Security=True"
        con.Open()




    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bradley\Desktop\Vs Basic Project\SceneView\Sceneviewdb.mdf;Integrated Security=True"
        con.Open()

        cmd = New SqlCommand("INSERT INTO Bookings values('" & txt_fname.Text & "','" & txt_lname.Text & "','" & txt_no.Text & "','" & book_date.Text & "','" & txt_movie.Text & "','" & txt_tickno.Text & "','" & txt_categ.Text & "','" & txt_price.Text & "')", con)
        MsgBox("Your details acrued successfully", MsgBoxStyle.Information, "Success")
        Me.Hide()
    End Sub
End Class