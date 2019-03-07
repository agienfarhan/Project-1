<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PD_Donasi
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cb_pdba = New System.Windows.Forms.ComboBox()
        Me.hapus_pdba = New System.Windows.Forms.Button()
        Me.ubah_pdba = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.grid_ba = New System.Windows.Forms.DataGridView()
        Me.jenis_ba = New System.Windows.Forms.TextBox()
        Me.daerah_ba = New System.Windows.Forms.TextBox()
        Me.kd_ba = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cb_pdds = New System.Windows.Forms.ComboBox()
        Me.hapus_pdds = New System.Windows.Forms.Button()
        Me.ubah_pdds = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.grid_ds = New System.Windows.Forms.DataGridView()
        Me.daerah_sekolah = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.alamat_sekolah = New System.Windows.Forms.TextBox()
        Me.nama_sekolah = New System.Windows.Forms.TextBox()
        Me.kd_ds = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cb_pdpa = New System.Windows.Forms.ComboBox()
        Me.hapus_pdpa = New System.Windows.Forms.Button()
        Me.ubah_pdpa = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.grid_pa = New System.Windows.Forms.DataGridView()
        Me.daerah_panti = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.alamat_panti = New System.Windows.Forms.TextBox()
        Me.nama_panti = New System.Windows.Forms.TextBox()
        Me.kd_pa = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.cb_pdyp = New System.Windows.Forms.ComboBox()
        Me.hapus_pdyp = New System.Windows.Forms.Button()
        Me.ubah_pdyp = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.grid_yp = New System.Windows.Forms.DataGridView()
        Me.jenis_penyakit = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.alamat_yys = New System.Windows.Forms.TextBox()
        Me.nama_yys = New System.Windows.Forms.TextBox()
        Me.kd_yp = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.grid_ba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.grid_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.grid_pa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.grid_yp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(10, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(471, 427)
        Me.TabControl1.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cb_pdba)
        Me.TabPage1.Controls.Add(Me.hapus_pdba)
        Me.TabPage1.Controls.Add(Me.ubah_pdba)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.grid_ba)
        Me.TabPage1.Controls.Add(Me.jenis_ba)
        Me.TabPage1.Controls.Add(Me.daerah_ba)
        Me.TabPage1.Controls.Add(Me.kd_ba)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(463, 401)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Bencana Alam"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cb_pdba
        '
        Me.cb_pdba.FormattingEnabled = True
        Me.cb_pdba.Location = New System.Drawing.Point(301, 33)
        Me.cb_pdba.Name = "cb_pdba"
        Me.cb_pdba.Size = New System.Drawing.Size(102, 21)
        Me.cb_pdba.TabIndex = 53
        '
        'hapus_pdba
        '
        Me.hapus_pdba.Location = New System.Drawing.Point(304, 374)
        Me.hapus_pdba.Name = "hapus_pdba"
        Me.hapus_pdba.Size = New System.Drawing.Size(75, 23)
        Me.hapus_pdba.TabIndex = 52
        Me.hapus_pdba.Text = "Hapus"
        Me.hapus_pdba.UseVisualStyleBackColor = True
        '
        'ubah_pdba
        '
        Me.ubah_pdba.Location = New System.Drawing.Point(223, 374)
        Me.ubah_pdba.Name = "ubah_pdba"
        Me.ubah_pdba.Size = New System.Drawing.Size(75, 23)
        Me.ubah_pdba.TabIndex = 51
        Me.ubah_pdba.Text = "Ubah"
        Me.ubah_pdba.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(385, 374)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "Batal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'grid_ba
        '
        Me.grid_ba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_ba.Location = New System.Drawing.Point(0, 145)
        Me.grid_ba.Name = "grid_ba"
        Me.grid_ba.Size = New System.Drawing.Size(463, 217)
        Me.grid_ba.TabIndex = 48
        '
        'jenis_ba
        '
        Me.jenis_ba.Location = New System.Drawing.Point(192, 107)
        Me.jenis_ba.Name = "jenis_ba"
        Me.jenis_ba.Size = New System.Drawing.Size(211, 20)
        Me.jenis_ba.TabIndex = 18
        '
        'daerah_ba
        '
        Me.daerah_ba.Location = New System.Drawing.Point(192, 71)
        Me.daerah_ba.Name = "daerah_ba"
        Me.daerah_ba.Size = New System.Drawing.Size(211, 20)
        Me.daerah_ba.TabIndex = 17
        '
        'kd_ba
        '
        Me.kd_ba.Location = New System.Drawing.Point(192, 34)
        Me.kd_ba.Name = "kd_ba"
        Me.kd_ba.Size = New System.Drawing.Size(103, 20)
        Me.kd_ba.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(153, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Jenis Bencana Alam"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Nama Daerah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Kode Bencana Alam"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cb_pdds)
        Me.TabPage2.Controls.Add(Me.hapus_pdds)
        Me.TabPage2.Controls.Add(Me.ubah_pdds)
        Me.TabPage2.Controls.Add(Me.Button11)
        Me.TabPage2.Controls.Add(Me.grid_ds)
        Me.TabPage2.Controls.Add(Me.daerah_sekolah)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.alamat_sekolah)
        Me.TabPage2.Controls.Add(Me.nama_sekolah)
        Me.TabPage2.Controls.Add(Me.kd_ds)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(463, 401)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dana Sekolah"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cb_pdds
        '
        Me.cb_pdds.FormattingEnabled = True
        Me.cb_pdds.Location = New System.Drawing.Point(304, 34)
        Me.cb_pdds.Name = "cb_pdds"
        Me.cb_pdds.Size = New System.Drawing.Size(101, 21)
        Me.cb_pdds.TabIndex = 53
        '
        'hapus_pdds
        '
        Me.hapus_pdds.Location = New System.Drawing.Point(304, 374)
        Me.hapus_pdds.Name = "hapus_pdds"
        Me.hapus_pdds.Size = New System.Drawing.Size(75, 23)
        Me.hapus_pdds.TabIndex = 52
        Me.hapus_pdds.Text = "Hapus"
        Me.hapus_pdds.UseVisualStyleBackColor = True
        '
        'ubah_pdds
        '
        Me.ubah_pdds.Location = New System.Drawing.Point(223, 374)
        Me.ubah_pdds.Name = "ubah_pdds"
        Me.ubah_pdds.Size = New System.Drawing.Size(75, 23)
        Me.ubah_pdds.TabIndex = 51
        Me.ubah_pdds.Text = "Ubah"
        Me.ubah_pdds.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(385, 374)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 50
        Me.Button11.Text = "Batal"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'grid_ds
        '
        Me.grid_ds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_ds.Location = New System.Drawing.Point(0, 182)
        Me.grid_ds.Name = "grid_ds"
        Me.grid_ds.Size = New System.Drawing.Size(463, 180)
        Me.grid_ds.TabIndex = 48
        '
        'daerah_sekolah
        '
        Me.daerah_sekolah.Location = New System.Drawing.Point(192, 143)
        Me.daerah_sekolah.Name = "daerah_sekolah"
        Me.daerah_sekolah.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.daerah_sekolah.Size = New System.Drawing.Size(213, 20)
        Me.daerah_sekolah.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(153, 146)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(10, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(84, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Daerah Sekolah"
        '
        'alamat_sekolah
        '
        Me.alamat_sekolah.Location = New System.Drawing.Point(192, 107)
        Me.alamat_sekolah.Name = "alamat_sekolah"
        Me.alamat_sekolah.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.alamat_sekolah.Size = New System.Drawing.Size(213, 20)
        Me.alamat_sekolah.TabIndex = 27
        '
        'nama_sekolah
        '
        Me.nama_sekolah.Location = New System.Drawing.Point(192, 71)
        Me.nama_sekolah.Name = "nama_sekolah"
        Me.nama_sekolah.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nama_sekolah.Size = New System.Drawing.Size(213, 20)
        Me.nama_sekolah.TabIndex = 26
        '
        'kd_ds
        '
        Me.kd_ds.Location = New System.Drawing.Point(192, 34)
        Me.kd_ds.Name = "kd_ds"
        Me.kd_ds.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.kd_ds.Size = New System.Drawing.Size(106, 20)
        Me.kd_ds.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(153, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Alamat Sekolah"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(153, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Nama Sekolah"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(153, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(10, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(103, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Kode Dana Sekolah"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cb_pdpa)
        Me.TabPage3.Controls.Add(Me.hapus_pdpa)
        Me.TabPage3.Controls.Add(Me.ubah_pdpa)
        Me.TabPage3.Controls.Add(Me.Button13)
        Me.TabPage3.Controls.Add(Me.grid_pa)
        Me.TabPage3.Controls.Add(Me.daerah_panti)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.alamat_panti)
        Me.TabPage3.Controls.Add(Me.nama_panti)
        Me.TabPage3.Controls.Add(Me.kd_pa)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(463, 401)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Panti Asuhan"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cb_pdpa
        '
        Me.cb_pdpa.FormattingEnabled = True
        Me.cb_pdpa.Location = New System.Drawing.Point(304, 34)
        Me.cb_pdpa.Name = "cb_pdpa"
        Me.cb_pdpa.Size = New System.Drawing.Size(94, 21)
        Me.cb_pdpa.TabIndex = 48
        '
        'hapus_pdpa
        '
        Me.hapus_pdpa.Location = New System.Drawing.Point(304, 374)
        Me.hapus_pdpa.Name = "hapus_pdpa"
        Me.hapus_pdpa.Size = New System.Drawing.Size(75, 23)
        Me.hapus_pdpa.TabIndex = 47
        Me.hapus_pdpa.Text = "Hapus"
        Me.hapus_pdpa.UseVisualStyleBackColor = True
        '
        'ubah_pdpa
        '
        Me.ubah_pdpa.Location = New System.Drawing.Point(223, 374)
        Me.ubah_pdpa.Name = "ubah_pdpa"
        Me.ubah_pdpa.Size = New System.Drawing.Size(75, 23)
        Me.ubah_pdpa.TabIndex = 46
        Me.ubah_pdpa.Text = "Ubah"
        Me.ubah_pdpa.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(385, 374)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 23)
        Me.Button13.TabIndex = 45
        Me.Button13.Text = "Batal"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'grid_pa
        '
        Me.grid_pa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_pa.Location = New System.Drawing.Point(0, 182)
        Me.grid_pa.Name = "grid_pa"
        Me.grid_pa.Size = New System.Drawing.Size(463, 180)
        Me.grid_pa.TabIndex = 43
        '
        'daerah_panti
        '
        Me.daerah_panti.Location = New System.Drawing.Point(192, 143)
        Me.daerah_panti.Name = "daerah_panti"
        Me.daerah_panti.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.daerah_panti.Size = New System.Drawing.Size(206, 20)
        Me.daerah_panti.TabIndex = 42
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(153, 146)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(10, 13)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(20, 146)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(108, 13)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Daerah Panti Asuhan"
        '
        'alamat_panti
        '
        Me.alamat_panti.Location = New System.Drawing.Point(192, 107)
        Me.alamat_panti.Name = "alamat_panti"
        Me.alamat_panti.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.alamat_panti.Size = New System.Drawing.Size(206, 20)
        Me.alamat_panti.TabIndex = 39
        '
        'nama_panti
        '
        Me.nama_panti.Location = New System.Drawing.Point(192, 71)
        Me.nama_panti.Name = "nama_panti"
        Me.nama_panti.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nama_panti.Size = New System.Drawing.Size(206, 20)
        Me.nama_panti.TabIndex = 38
        '
        'kd_pa
        '
        Me.kd_pa.Location = New System.Drawing.Point(192, 34)
        Me.kd_pa.Name = "kd_pa"
        Me.kd_pa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.kd_pa.Size = New System.Drawing.Size(106, 20)
        Me.kd_pa.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(153, 110)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(10, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(20, 110)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(105, 13)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Alamat Panti Asuhan"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(153, 74)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(10, 13)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = ":"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(20, 74)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(101, 13)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "Nama Panti Asuhan"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(153, 37)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(10, 13)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = ":"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(20, 37)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(98, 13)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Kode Panti Asuhan"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.cb_pdyp)
        Me.TabPage4.Controls.Add(Me.hapus_pdyp)
        Me.TabPage4.Controls.Add(Me.ubah_pdyp)
        Me.TabPage4.Controls.Add(Me.Button15)
        Me.TabPage4.Controls.Add(Me.grid_yp)
        Me.TabPage4.Controls.Add(Me.jenis_penyakit)
        Me.TabPage4.Controls.Add(Me.Label24)
        Me.TabPage4.Controls.Add(Me.Label25)
        Me.TabPage4.Controls.Add(Me.alamat_yys)
        Me.TabPage4.Controls.Add(Me.nama_yys)
        Me.TabPage4.Controls.Add(Me.kd_yp)
        Me.TabPage4.Controls.Add(Me.Label26)
        Me.TabPage4.Controls.Add(Me.Label27)
        Me.TabPage4.Controls.Add(Me.Label28)
        Me.TabPage4.Controls.Add(Me.Label29)
        Me.TabPage4.Controls.Add(Me.Label30)
        Me.TabPage4.Controls.Add(Me.Label31)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(463, 401)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Yayasan Penyakit"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'cb_pdyp
        '
        Me.cb_pdyp.FormattingEnabled = True
        Me.cb_pdyp.Location = New System.Drawing.Point(304, 34)
        Me.cb_pdyp.Name = "cb_pdyp"
        Me.cb_pdyp.Size = New System.Drawing.Size(103, 21)
        Me.cb_pdyp.TabIndex = 60
        '
        'hapus_pdyp
        '
        Me.hapus_pdyp.Location = New System.Drawing.Point(304, 374)
        Me.hapus_pdyp.Name = "hapus_pdyp"
        Me.hapus_pdyp.Size = New System.Drawing.Size(75, 23)
        Me.hapus_pdyp.TabIndex = 59
        Me.hapus_pdyp.Text = "Hapus"
        Me.hapus_pdyp.UseVisualStyleBackColor = True
        '
        'ubah_pdyp
        '
        Me.ubah_pdyp.Location = New System.Drawing.Point(223, 374)
        Me.ubah_pdyp.Name = "ubah_pdyp"
        Me.ubah_pdyp.Size = New System.Drawing.Size(75, 23)
        Me.ubah_pdyp.TabIndex = 58
        Me.ubah_pdyp.Text = "Ubah"
        Me.ubah_pdyp.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(385, 374)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(75, 23)
        Me.Button15.TabIndex = 57
        Me.Button15.Text = "Batal"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'grid_yp
        '
        Me.grid_yp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_yp.Location = New System.Drawing.Point(0, 182)
        Me.grid_yp.Name = "grid_yp"
        Me.grid_yp.Size = New System.Drawing.Size(463, 180)
        Me.grid_yp.TabIndex = 55
        '
        'jenis_penyakit
        '
        Me.jenis_penyakit.Location = New System.Drawing.Point(192, 143)
        Me.jenis_penyakit.Name = "jenis_penyakit"
        Me.jenis_penyakit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.jenis_penyakit.Size = New System.Drawing.Size(215, 20)
        Me.jenis_penyakit.TabIndex = 54
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(153, 146)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(10, 13)
        Me.Label24.TabIndex = 53
        Me.Label24.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(20, 146)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(75, 13)
        Me.Label25.TabIndex = 52
        Me.Label25.Text = "Jenis Penyakit"
        '
        'alamat_yys
        '
        Me.alamat_yys.Location = New System.Drawing.Point(192, 107)
        Me.alamat_yys.Name = "alamat_yys"
        Me.alamat_yys.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.alamat_yys.Size = New System.Drawing.Size(215, 20)
        Me.alamat_yys.TabIndex = 51
        '
        'nama_yys
        '
        Me.nama_yys.Location = New System.Drawing.Point(192, 71)
        Me.nama_yys.Name = "nama_yys"
        Me.nama_yys.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nama_yys.Size = New System.Drawing.Size(215, 20)
        Me.nama_yys.TabIndex = 50
        '
        'kd_yp
        '
        Me.kd_yp.Location = New System.Drawing.Point(192, 34)
        Me.kd_yp.Name = "kd_yp"
        Me.kd_yp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.kd_yp.Size = New System.Drawing.Size(106, 20)
        Me.kd_yp.TabIndex = 49
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(153, 110)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(10, 13)
        Me.Label26.TabIndex = 48
        Me.Label26.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(20, 110)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(127, 13)
        Me.Label27.TabIndex = 47
        Me.Label27.Text = "Alamat Yayasan Penyakit"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(153, 74)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(10, 13)
        Me.Label28.TabIndex = 46
        Me.Label28.Text = ":"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(20, 74)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(123, 13)
        Me.Label29.TabIndex = 45
        Me.Label29.Text = "Nama Yayasan Penyakit"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(153, 37)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(10, 13)
        Me.Label30.TabIndex = 44
        Me.Label30.Text = ":"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(20, 37)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(120, 13)
        Me.Label31.TabIndex = 43
        Me.Label31.Text = "Kode Yayasan Penyakit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Pembaruan Data Donasi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PD_Donasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 480)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PD_Donasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembaruan Data Donasi"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.grid_ba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.grid_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.grid_pa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.grid_yp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents jenis_ba As System.Windows.Forms.TextBox
    Friend WithEvents daerah_ba As System.Windows.Forms.TextBox
    Friend WithEvents kd_ba As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents daerah_sekolah As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents alamat_sekolah As System.Windows.Forms.TextBox
    Friend WithEvents nama_sekolah As System.Windows.Forms.TextBox
    Friend WithEvents kd_ds As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents daerah_panti As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents alamat_panti As System.Windows.Forms.TextBox
    Friend WithEvents nama_panti As System.Windows.Forms.TextBox
    Friend WithEvents kd_pa As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents jenis_penyakit As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents alamat_yys As System.Windows.Forms.TextBox
    Friend WithEvents nama_yys As System.Windows.Forms.TextBox
    Friend WithEvents kd_yp As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents hapus_pdpa As System.Windows.Forms.Button
    Friend WithEvents ubah_pdpa As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents grid_pa As System.Windows.Forms.DataGridView
    Friend WithEvents hapus_pdba As System.Windows.Forms.Button
    Friend WithEvents ubah_pdba As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents grid_ba As System.Windows.Forms.DataGridView
    Friend WithEvents hapus_pdds As System.Windows.Forms.Button
    Friend WithEvents ubah_pdds As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents grid_ds As System.Windows.Forms.DataGridView
    Friend WithEvents hapus_pdyp As System.Windows.Forms.Button
    Friend WithEvents ubah_pdyp As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents grid_yp As System.Windows.Forms.DataGridView
    Friend WithEvents cb_pdba As System.Windows.Forms.ComboBox
    Friend WithEvents cb_pdds As System.Windows.Forms.ComboBox
    Friend WithEvents cb_pdpa As System.Windows.Forms.ComboBox
    Friend WithEvents cb_pdyp As System.Windows.Forms.ComboBox
End Class
