Public Class Form3
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Paneltop.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAction.Click
        pnlOnButtonposition.Height = BtnAction.Height
        pnlOnButtonposition.Top = BtnAction.Top
        PnlAction.Visible = True
        PnlRomance.Visible = False
        PnlScifi.Visible = False
        PnlAnimation.Visible = False
        PnlMyChoice.Visible = False
        PnlAbout.Visible = False
    End Sub
    Private Sub BtnRomance_Click(sender As Object, e As EventArgs) Handles BtnRomance.Click
        pnlOnButtonposition.Height = BtnRomance.Height
        pnlOnButtonposition.Top = BtnRomance.Top
        PnlAction.Visible = False
        PnlRomance.Visible = True
        PnlScifi.Visible = False
        PnlAnimation.Visible = False
        PnlMyChoice.Visible = False
        PnlAbout.Visible = False
    End Sub


    Private Sub PnlMovies_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btnrebel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnScifi_Click(sender As Object, e As EventArgs) Handles BtnScifi.Click
        pnlOnButtonposition.Height = BtnScifi.Height
        pnlOnButtonposition.Top = BtnScifi.Top
        PnlAction.Visible = False
        PnlRomance.Visible = False
        PnlScifi.Visible = True
        PnlAnimation.Visible = False
        PnlMyChoice.Visible = False
        PnlAbout.Visible = False
    End Sub

    Private Sub BtnAnimation_Click(sender As Object, e As EventArgs) Handles BtnAnimation.Click
        pnlOnButtonposition.Height = BtnAnimation.Height
        pnlOnButtonposition.Top = BtnAnimation.Top
        PnlAction.Visible = False
        PnlRomance.Visible = False
        PnlScifi.Visible = False
        PnlAnimation.Visible = True
        PnlMyChoice.Visible = False
        PnlAbout.Visible = False
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnChoice.Click
        pnlOnButtonposition.Height = BtnChoice.Height
        pnlOnButtonposition.Top = BtnChoice.Top
        PnlAction.Visible = False
        PnlRomance.Visible = False
        PnlScifi.Visible = False
        PnlAnimation.Visible = False
        PnlMyChoice.Visible = True
        PnlAbout.Visible = False
    End Sub
    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        pnlOnButtonposition.Height = BtnAbout.Height
        pnlOnButtonposition.Top = BtnAbout.Top
        PnlAction.Visible = False
        PnlRomance.Visible = False
        PnlScifi.Visible = False
        PnlAnimation.Visible = False
        PnlMyChoice.Visible = False
        PnlAbout.Visible = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles Button1.Click


        Booking_page.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
    End Sub
End Class