<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking_page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_tickno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.book_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_no = New System.Windows.Forms.MaskedTextBox()
        Me.txt_lname = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.Btn_save = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Location = New System.Drawing.Point(628, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Ticket No."
        '
        'txt_tickno
        '
        Me.txt_tickno.Location = New System.Drawing.Point(583, 155)
        Me.txt_tickno.Name = "txt_tickno"
        Me.txt_tickno.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_tickno.Size = New System.Drawing.Size(161, 20)
        Me.txt_tickno.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(628, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Price"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(583, 36)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(161, 20)
        Me.txt_price.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Movie"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Date & Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(332, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Payment Phone no"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(365, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "First Name"
        '
        'book_date
        '
        Me.book_date.Location = New System.Drawing.Point(319, 287)
        Me.book_date.Name = "book_date"
        Me.book_date.Size = New System.Drawing.Size(158, 20)
        Me.book_date.TabIndex = 37
        '
        'txt_no
        '
        Me.txt_no.Location = New System.Drawing.Point(301, 168)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(161, 20)
        Me.txt_no.TabIndex = 35
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(316, 39)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(161, 20)
        Me.txt_lname.TabIndex = 34
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(21, 36)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(161, 20)
        Me.txt_fname.TabIndex = 33
        '
        'Btn_save
        '
        Me.Btn_save.BackColor = System.Drawing.Color.Green
        Me.Btn_save.Location = New System.Drawing.Point(368, 357)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Size = New System.Drawing.Size(120, 41)
        Me.Btn_save.TabIndex = 32
        Me.Btn_save.Text = "Confirm"
        Me.Btn_save.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"--Select--", "Moana  -       Morning", "The Bee Keeper-  Noon", "The Badlands- Evening", "The acoco-    Tonight", "Love from today- Tonignt", "Never have i ever -Tonight"})
        Me.ComboBox1.Location = New System.Drawing.Point(21, 168)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(154, 21)
        Me.ComboBox1.TabIndex = 47
        '
        'Booking_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_tickno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.book_date)
        Me.Controls.Add(Me.txt_no)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.Btn_save)
        Me.Name = "Booking_page"
        Me.Text = "Booking_page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents txt_tickno As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents book_date As DateTimePicker
    Friend WithEvents txt_no As MaskedTextBox
    Friend WithEvents txt_lname As MaskedTextBox
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents Btn_save As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
