<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_save = New System.Windows.Forms.Button()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.txt_lname = New System.Windows.Forms.MaskedTextBox()
        Me.txt_no = New System.Windows.Forms.MaskedTextBox()
        Me.book_date = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_clear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_movie = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_categ = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_tickno = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(528, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Your Ticket"
        '
        'Btn_save
        '
        Me.Btn_save.BackColor = System.Drawing.Color.Green
        Me.Btn_save.Location = New System.Drawing.Point(46, 396)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Size = New System.Drawing.Size(73, 41)
        Me.Btn_save.TabIndex = 9
        Me.Btn_save.Text = "Save"
        Me.Btn_save.UseVisualStyleBackColor = False
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(46, 45)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(161, 20)
        Me.txt_fname.TabIndex = 10
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(46, 103)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(161, 20)
        Me.txt_lname.TabIndex = 11
        '
        'txt_no
        '
        Me.txt_no.Location = New System.Drawing.Point(46, 164)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(161, 20)
        Me.txt_no.TabIndex = 12
        '
        'book_date
        '
        Me.book_date.Location = New System.Drawing.Point(49, 351)
        Me.book_date.Name = "book_date"
        Me.book_date.Size = New System.Drawing.Size(158, 20)
        Me.book_date.TabIndex = 14
        '
        'Btn_Update
        '
        Me.Btn_Update.BackColor = System.Drawing.Color.Orange
        Me.Btn_Update.Location = New System.Drawing.Point(157, 396)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(73, 41)
        Me.Btn_Update.TabIndex = 15
        Me.Btn_Update.Text = "Update"
        Me.Btn_Update.UseVisualStyleBackColor = False
        '
        'Btn_Delete
        '
        Me.Btn_Delete.BackColor = System.Drawing.Color.Green
        Me.Btn_Delete.Location = New System.Drawing.Point(46, 460)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(73, 41)
        Me.Btn_Delete.TabIndex = 16
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = False
        '
        'Btn_clear
        '
        Me.Btn_clear.BackColor = System.Drawing.Color.Green
        Me.Btn_clear.Location = New System.Drawing.Point(157, 460)
        Me.Btn_clear.Name = "Btn_clear"
        Me.Btn_clear.Size = New System.Drawing.Size(73, 41)
        Me.Btn_clear.TabIndex = 17
        Me.Btn_clear.Text = "Clear"
        Me.Btn_clear.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Payment Phone no"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(94, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Date & Time"
        '
        'txt_movie
        '
        Me.txt_movie.Location = New System.Drawing.Point(46, 216)
        Me.txt_movie.Name = "txt_movie"
        Me.txt_movie.Size = New System.Drawing.Size(161, 20)
        Me.txt_movie.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Movie"
        '
        'txt_categ
        '
        Me.txt_categ.FormattingEnabled = True
        Me.txt_categ.Location = New System.Drawing.Point(46, 285)
        Me.txt_categ.Name = "txt_categ"
        Me.txt_categ.Size = New System.Drawing.Size(161, 21)
        Me.txt_categ.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(77, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Movie Categories"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(362, 148)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(553, 274)
        Me.DataGridView1.TabIndex = 25
        '
        'Column1
        '
        Me.Column1.HeaderText = "First Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Last Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Payment Phone no"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 101
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Movie"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 61
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Price"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 56
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Movie Categories"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 105
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(687, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Search"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(642, 116)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(161, 20)
        Me.txt_search.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(288, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Price"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(243, 45)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(161, 20)
        Me.txt_price.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Location = New System.Drawing.Point(288, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Ticket No."
        '
        'txt_tickno
        '
        Me.txt_tickno.Location = New System.Drawing.Point(243, 100)
        Me.txt_tickno.Name = "txt_tickno"
        Me.txt_tickno.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_tickno.Size = New System.Drawing.Size(161, 20)
        Me.txt_tickno.TabIndex = 30
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 661)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_tickno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_categ)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_clear)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.book_date)
        Me.Controls.Add(Me.txt_movie)
        Me.Controls.Add(Me.txt_no)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.Btn_save)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "reg"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_save As Button
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents txt_lname As MaskedTextBox
    Friend WithEvents txt_no As MaskedTextBox
    Friend WithEvents book_date As DateTimePicker
    Friend WithEvents Btn_Update As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_clear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_movie As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_categ As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_tickno As TextBox
End Class
