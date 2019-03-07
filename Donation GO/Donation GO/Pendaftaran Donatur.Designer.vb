<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pendaftaran_Donatur
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ln_donatur = New System.Windows.Forms.TextBox()
        Me.fn_donatur = New System.Windows.Forms.TextBox()
        Me.id_donatur = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cb_gender_donatur = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.profesi_donatur = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.contact_donatur = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.email_donatur = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ttl_donatur = New System.Windows.Forms.DateTimePicker()
        Me.Tambah_donatur = New System.Windows.Forms.Button()
        Me.Tutup_donatur = New System.Windows.Forms.Button()
        Me.Batal_donatur = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pendaftaran Donatur"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(149, 163)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(10, 13)
        Me.Label24.TabIndex = 67
        Me.Label24.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(16, 163)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(42, 13)
        Me.Label25.TabIndex = 66
        Me.Label25.Text = "Gender"
        '
        'ln_donatur
        '
        Me.ln_donatur.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.ln_donatur.Location = New System.Drawing.Point(188, 124)
        Me.ln_donatur.Name = "ln_donatur"
        Me.ln_donatur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ln_donatur.Size = New System.Drawing.Size(190, 20)
        Me.ln_donatur.TabIndex = 65
        Me.ln_donatur.Text = "Last"
        '
        'fn_donatur
        '
        Me.fn_donatur.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.fn_donatur.Location = New System.Drawing.Point(188, 88)
        Me.fn_donatur.Name = "fn_donatur"
        Me.fn_donatur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fn_donatur.Size = New System.Drawing.Size(190, 20)
        Me.fn_donatur.TabIndex = 64
        Me.fn_donatur.Text = "First"
        '
        'id_donatur
        '
        Me.id_donatur.Location = New System.Drawing.Point(188, 51)
        Me.id_donatur.Name = "id_donatur"
        Me.id_donatur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.id_donatur.Size = New System.Drawing.Size(190, 20)
        Me.id_donatur.TabIndex = 63
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(149, 91)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(10, 13)
        Me.Label28.TabIndex = 60
        Me.Label28.Text = ":"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(16, 91)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(35, 13)
        Me.Label29.TabIndex = 59
        Me.Label29.Text = "Nama"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(149, 54)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(10, 13)
        Me.Label30.TabIndex = 58
        Me.Label30.Text = ":"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(16, 54)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(59, 13)
        Me.Label31.TabIndex = 57
        Me.Label31.Text = "ID Donatur"
        '
        'cb_gender_donatur
        '
        Me.cb_gender_donatur.FormattingEnabled = True
        Me.cb_gender_donatur.Items.AddRange(New Object() {"Male", "Female"})
        Me.cb_gender_donatur.Location = New System.Drawing.Point(188, 160)
        Me.cb_gender_donatur.Name = "cb_gender_donatur"
        Me.cb_gender_donatur.Size = New System.Drawing.Size(190, 21)
        Me.cb_gender_donatur.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Tanggal Lahir"
        '
        'profesi_donatur
        '
        Me.profesi_donatur.Location = New System.Drawing.Point(189, 234)
        Me.profesi_donatur.Name = "profesi_donatur"
        Me.profesi_donatur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.profesi_donatur.Size = New System.Drawing.Size(190, 20)
        Me.profesi_donatur.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(150, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Profesi"
        '
        'contact_donatur
        '
        Me.contact_donatur.Location = New System.Drawing.Point(189, 270)
        Me.contact_donatur.Name = "contact_donatur"
        Me.contact_donatur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.contact_donatur.Size = New System.Drawing.Size(190, 20)
        Me.contact_donatur.TabIndex = 80
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(150, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Contact"
        '
        'email_donatur
        '
        Me.email_donatur.Location = New System.Drawing.Point(189, 306)
        Me.email_donatur.Name = "email_donatur"
        Me.email_donatur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.email_donatur.Size = New System.Drawing.Size(190, 20)
        Me.email_donatur.TabIndex = 83
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(150, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Email"
        '
        'ttl_donatur
        '
        Me.ttl_donatur.CustomFormat = ""
        Me.ttl_donatur.Location = New System.Drawing.Point(189, 193)
        Me.ttl_donatur.Name = "ttl_donatur"
        Me.ttl_donatur.Size = New System.Drawing.Size(190, 20)
        Me.ttl_donatur.TabIndex = 110
        '
        'Tambah_donatur
        '
        Me.Tambah_donatur.Location = New System.Drawing.Point(189, 332)
        Me.Tambah_donatur.Name = "Tambah_donatur"
        Me.Tambah_donatur.Size = New System.Drawing.Size(57, 23)
        Me.Tambah_donatur.TabIndex = 111
        Me.Tambah_donatur.Text = "Tambah"
        Me.Tambah_donatur.UseVisualStyleBackColor = True
        '
        'Tutup_donatur
        '
        Me.Tutup_donatur.Location = New System.Drawing.Point(331, 332)
        Me.Tutup_donatur.Name = "Tutup_donatur"
        Me.Tutup_donatur.Size = New System.Drawing.Size(50, 23)
        Me.Tutup_donatur.TabIndex = 113
        Me.Tutup_donatur.Text = "Tutup"
        Me.Tutup_donatur.UseVisualStyleBackColor = True
        '
        'Batal_donatur
        '
        Me.Batal_donatur.Location = New System.Drawing.Point(252, 332)
        Me.Batal_donatur.Name = "Batal_donatur"
        Me.Batal_donatur.Size = New System.Drawing.Size(51, 23)
        Me.Batal_donatur.TabIndex = 112
        Me.Batal_donatur.Text = "Batal"
        Me.Batal_donatur.UseVisualStyleBackColor = True
        '
        'Pendaftaran_Donatur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 363)
        Me.Controls.Add(Me.Tutup_donatur)
        Me.Controls.Add(Me.Batal_donatur)
        Me.Controls.Add(Me.Tambah_donatur)
        Me.Controls.Add(Me.ttl_donatur)
        Me.Controls.Add(Me.email_donatur)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.contact_donatur)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.profesi_donatur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_gender_donatur)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.ln_donatur)
        Me.Controls.Add(Me.fn_donatur)
        Me.Controls.Add(Me.id_donatur)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pendaftaran_Donatur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pendaftaran Donatur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ln_donatur As System.Windows.Forms.TextBox
    Friend WithEvents fn_donatur As System.Windows.Forms.TextBox
    Friend WithEvents id_donatur As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cb_gender_donatur As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents profesi_donatur As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents contact_donatur As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents email_donatur As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ttl_donatur As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tambah_donatur As System.Windows.Forms.Button
    Friend WithEvents Tutup_donatur As System.Windows.Forms.Button
    Friend WithEvents Batal_donatur As System.Windows.Forms.Button
End Class
