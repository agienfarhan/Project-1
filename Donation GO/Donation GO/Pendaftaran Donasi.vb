Public Class Pendaftaran_Donasi

    Private Sub Pendaftaran_Donasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call openDB()
    End Sub

    Sub bersihba()
        kd_ba.Text = ""
        daerah_ba.Text = ""
        jenis_ba.Text = ""
        kd_ba.Focus()
        Tambah_ba.Text = "Tambah"
    End Sub

    Sub bersihds()
        kd_ds.Text = ""
        nama_sekolah.Text = ""
        alamat_sekolah.Text = ""
        daerah_sekolah.Text = ""
        kd_ds.Focus()
        Tambah_ds.Text = "Tambah"
    End Sub

    Sub bersihpa()
        kd_pa.Text = ""
        nama_panti.Text = ""
        alamat_panti.Text = ""
        daerah_panti.Text = ""
        kd_pa.Focus()
        Tambah_pa.Text = "Tambah"
    End Sub

    Sub bersihyp()
        kd_yp.Text = ""
        nama_yys.Text = ""
        alamat_yys.Text = ""
        jenis_penyakit.Text = ""
        kd_yp.Focus()
        Tambah_yp.Text = "Tambah"
    End Sub
    Private Sub Tambah_ba_Click(sender As Object, e As EventArgs) Handles Tambah_ba.Click
        If Tambah_ba.Text = "Tambah" Then
            Tambah_ba.Text = "Simpan"
            kd_ba.Focus()
        Else
            Try
                Call openDB()
                CMD = New Odbc.OdbcCommand("SELECT kd_ba from bencana_alam WHERE kd_ba = '" & kd_ba.Text & "'", connect)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    MsgBox("Maaf, Data dengan ID tersebut telah ada !", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    Call openDB()
                    simpan = "INSERT INTO bencana_alam (kd_ba,daerah_ba,jenis_ba) VALUES('" & kd_ba.Text & "','" & daerah_ba.Text & "','" & jenis_ba.Text & "')"

                    CMD = New Odbc.OdbcCommand(simpan, connect)
                    CMD.ExecuteNonQuery()
                    Call bersihba()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub Batal_pba_Click(sender As Object, e As EventArgs) Handles Batal_pba.Click
        Call bersihba()
    End Sub

    Private Sub Tambah_ds_Click(sender As Object, e As EventArgs) Handles Tambah_ds.Click
        If Tambah_ds.Text = "Tambah" Then
            Tambah_ds.Text = "Simpan"
            kd_ds.Focus()
        Else
            Try
                Call openDB()
                CMD = New Odbc.OdbcCommand("SELECT kd_ds from dana_sekolah WHERE kd_ds = '" & kd_ds.Text & "'", connect)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    MsgBox("Maaf, Data dengan ID tersebut telah ada !", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    Call openDB()
                    simpan = "INSERT INTO dana_sekolah (kd_ds,nama_sekolah,alamat_sekolah,daerah_sekolah) VALUES('" & kd_ds.Text & "','" & nama_sekolah.Text & "','" & alamat_sekolah.Text & "','" & daerah_sekolah.Text & "')"

                    CMD = New Odbc.OdbcCommand(simpan, connect)
                    CMD.ExecuteNonQuery()
                    Call bersihds()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub Batal_pds_Click(sender As Object, e As EventArgs) Handles Batal_pds.Click
        Call bersihds()
    End Sub

    Private Sub Tambah_pa_Click(sender As Object, e As EventArgs) Handles Tambah_pa.Click
        If Tambah_pa.Text = "Tambah" Then
            Tambah_pa.Text = "Simpan"
            kd_pa.Focus()
        Else
            Try
                Call openDB()
                CMD = New Odbc.OdbcCommand("SELECT kd_pa from panti_asuhan WHERE kd_pa = '" & kd_pa.Text & "'", connect)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    MsgBox("Maaf, Data dengan ID tersebut telah ada !", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    Call openDB()
                    simpan = "INSERT INTO panti_asuhan (kd_pa,nama_panti,alamat_panti,daerah_panti) VALUES('" & kd_pa.Text & "','" & nama_panti.Text & "','" & alamat_panti.Text & "','" & daerah_panti.Text & "')"

                    CMD = New Odbc.OdbcCommand(simpan, connect)
                    CMD.ExecuteNonQuery()
                    Call bersihpa()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub Batal_ppa_Click(sender As Object, e As EventArgs) Handles Batal_ppa.Click
        Call bersihpa()
    End Sub

    Private Sub Tambah_yp_Click(sender As Object, e As EventArgs) Handles Tambah_yp.Click
        If Tambah_yp.Text = "Tambah" Then
            Tambah_yp.Text = "Simpan"
            kd_yp.Focus()
        Else
            Try
                Call openDB()
                CMD = New Odbc.OdbcCommand("SELECT kd_yp from yayasan_penyakit WHERE kd_yp = '" & kd_yp.Text & "'", connect)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    MsgBox("Maaf, Data dengan ID tersebut telah ada !", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    Call openDB()
                    simpan = "INSERT INTO yayasan_penyakit (kd_yp,nama_yys,alamat_yys,jenis_penyakit) VALUES('" & kd_yp.Text & "','" & nama_yys.Text & "','" & alamat_yys.Text & "','" & jenis_penyakit.Text & "')"

                    CMD = New Odbc.OdbcCommand(simpan, connect)
                    CMD.ExecuteNonQuery()
                    Call bersihyp()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub Batal_pyp_Click(sender As Object, e As EventArgs) Handles Batal_pyp.Click
        Call bersihyp()
    End Sub
End Class