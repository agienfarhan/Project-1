<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pendaftaran_Admin
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
        Me.contact_admin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_gender_admin = New System.Windows.Forms.ComboBox()
        Me.Batal_admin = New System.Windows.Forms.Button()
        Me.Tambah_admin = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ln_admin = New System.Windows.Forms.TextBox()
        Me.fn_admin = New System.Windows.Forms.TextBox()
        Me.id_admin = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ttl_admin = New System.Windows.Forms.DateTimePicker()
        Me.Tutup_admin = New System.Windows.Forms.Button()
        Me.pass_admin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jbtn_admin = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'contact_admin
        '
        Me.contact_admin.Location = New System.Drawing.Point(200, 279)
        Me.contact_admin.Name = "contact_admin"
        Me.contact_admin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.contact_admin.Size = New System.Drawing.Size(190, 20)
        Me.contact_admin.TabIndex = 105
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(161, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Contact"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Tanggal Lahir"
        '
        'cb_gender_admin
        '
        Me.cb_gender_admin.FormattingEnabled = True
        Me.cb_gender_admin.Items.AddRange(New Object() {"Male", "Female"})
        Me.cb_gender_admin.Location = New System.Drawing.Point(200, 211)
        Me.cb_gender_admin.Name = "cb_gender_admin"
        Me.cb_gender_admin.Size = New System.Drawing.Size(190, 21)
        Me.cb_gender_admin.TabIndex = 96
        '
        'Batal_admin
        '
        Me.Batal_admin.Location = New System.Drawing.Point(261, 341)
        Me.Batal_admin.Name = "Batal_admin"
        Me.Batal_admin.Size = New System.Drawing.Size(51, 23)
        Me.Batal_admin.TabIndex = 95
        Me.Batal_admin.Text = "Batal"
        Me.Batal_admin.UseVisualStyleBackColor = True
        '
        'Tambah_admin
        '
        Me.Tambah_admin.Location = New System.Drawing.Point(198, 341)
        Me.Tambah_admin.Name = "Tambah_admin"
        Me.Tambah_admin.Size = New System.Drawing.Size(57, 23)
        Me.Tambah_admin.TabIndex = 94
        Me.Tambah_admin.Text = "Tambah"
        Me.Tambah_admin.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(161, 214)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(10, 13)
        Me.Label24.TabIndex = 93
        Me.Label24.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(28, 214)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(42, 13)
        Me.Label25.TabIndex = 92
        Me.Label25.Text = "Gender"
        '
        'ln_admin
        '
        Me.ln_admin.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.ln_admin.Location = New System.Drawing.Point(200, 149)
        Me.ln_admin.Name = "ln_admin"
        Me.ln_admin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ln_admin.Size = New System.Drawing.Size(190, 20)
        Me.ln_admin.TabIndex = 91
        Me.ln_admin.Text = "Last"
        '
        'fn_admin
        '
        Me.fn_admin.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.fn_admin.Location = New System.Drawing.Point(200, 113)
        Me.fn_admin.Name = "fn_admin"
        Me.fn_admin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fn_admin.Size = New System.Drawing.Size(190, 20)
        Me.fn_admin.TabIndex = 90
        Me.fn_admin.Text = "First"
        '
        'id_admin
        '
        Me.id_admin.Location = New System.Drawing.Point(200, 50)
        Me.id_admin.Name = "id_admin"
        Me.id_admin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.id_admin.Size = New System.Drawing.Size(190, 20)
        Me.id_admin.TabIndex = 89
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(161, 116)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(10, 13)
        Me.Label28.TabIndex = 88
        Me.Label28.Text = ":"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(28, 116)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(35, 13)
        Me.Label29.TabIndex = 87
        Me.Label29.Text = "Nama"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(161, 53)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(10, 13)
        Me.Label30.TabIndex = 86
        Me.Label30.Text = ":"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(28, 53)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(50, 13)
        Me.Label31.TabIndex = 85
        Me.Label31.Text = "ID Admin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 25)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Pendaftaran Admin"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ttl_admin
        '
        Me.ttl_admin.CustomFormat = ""
        Me.ttl_admin.Location = New System.Drawing.Point(200, 250)
        Me.ttl_admin.Name = "ttl_admin"
        Me.ttl_admin.Size = New System.Drawing.Size(190, 20)
        Me.ttl_admin.TabIndex = 109
        '
        'Tutup_admin
        '
        Me.Tutup_admin.Location = New System.Drawing.Point(340, 341)
        Me.Tutup_admin.Name = "Tutup_admin"
        Me.Tutup_admin.Size = New System.Drawing.Size(50, 23)
        Me.Tutup_admin.TabIndex = 110
        Me.Tutup_admin.Text = "Tutup"
        Me.Tutup_admin.UseVisualStyleBackColor = True
        '
        'pass_admin
        '
        Me.pass_admin.Location = New System.Drawing.Point(200, 81)
        Me.pass_admin.Name = "pass_admin"
        Me.pass_admin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pass_admin.Size = New System.Drawing.Size(190, 20)
        Me.pass_admin.TabIndex = 113
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(161, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Password"
        '
        'jbtn_admin
        '
        Me.jbtn_admin.FormattingEnabled = True
        Me.jbtn_admin.Items.AddRange(New Object() {"Staff", "Manager"})
        Me.jbtn_admin.Location = New System.Drawing.Point(200, 178)
        Me.jbtn_admin.Name = "jbtn_admin"
        Me.jbtn_admin.Size = New System.Drawing.Size(190, 21)
        Me.jbtn_admin.TabIndex = 116
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(161, 181)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 114
        Me.Label11.Text = "Jabatan"
        '
        'Pendaftaran_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 376)
        Me.Controls.Add(Me.jbtn_admin)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.pass_admin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Tutup_admin)
        Me.Controls.Add(Me.ttl_admin)
        Me.Controls.Add(Me.contact_admin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_gender_admin)
        Me.Controls.Add(Me.Batal_admin)
        Me.Controls.Add(Me.Tambah_admin)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.ln_admin)
        Me.Controls.Add(Me.fn_admin)
        Me.Controls.Add(Me.id_admin)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pendaftaran_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pendaftaran_Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents contact_admin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_gender_admin As System.Windows.Forms.ComboBox
    Friend WithEvents Batal_admin As System.Windows.Forms.Button
    Friend WithEvents Tambah_admin As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ln_admin As System.Windows.Forms.TextBox
    Friend WithEvents fn_admin As System.Windows.Forms.TextBox
    Friend WithEvents id_admin As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ttl_admin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tutup_admin As System.Windows.Forms.Button
    Friend WithEvents pass_admin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents jbtn_admin As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
