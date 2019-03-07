Public Class PD_Donasi

    Private Sub PD_Donasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call openDB()
        Call isigridpdba() 'menjalankan perintah dari sub isigrid()
        Call isigridpdds()
        Call isigridpdpa()
        Call isigridpdyp()
        Call isicombopdba()
        Call isicombopdds()
        Call isicombopdpa()
        Call isicombopdyp()
    End Sub

    'isi data grid'
    Sub isigridpdba()

        openDB() 'memanggil koneksi ke database melalui modul
        DA = New Odbc.OdbcDataAdapter("SELECT * FROM bencana_alam", connect)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "bencana_alam")
        grid_ba.DataSource = (DS.Tables("bencana_alam")) 'setting datasource dari datagridview
        grid_ba.Enabled = True 'jadikan datagridview hanya readonly
    End Sub
    Sub isigridpdds()

        openDB() 'memanggil koneksi ke database melalui modul
        DA = New Odbc.OdbcDataAdapter("SELECT * FROM dana_sekolah", connect)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "dana_sekolah")
        grid_ds.DataSource = (DS.Tables("dana_sekolah")) 'setting datasource dari datagridview
        grid_ds.Enabled = True 'jadikan datagridview hanya readonly
    End Sub
    Sub isigridpdpa()

        openDB() 'memanggil koneksi ke database melalui modul
        DA = New Odbc.OdbcDataAdapter("SELECT * FROM panti_asuhan", connect)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "panti_asuhan")
        grid_pa.DataSource = (DS.Tables("panti_asuhan")) 'setting datasource dari datagridview
        grid_pa.Enabled = True 'jadikan datagridview hanya readonly
    End Sub
    Sub isigridpdyp()

        openDB() 'memanggil koneksi ke database melalui modul
        DA = New Odbc.OdbcDataAdapter("SELECT * FROM yayasan_penyakit", connect)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "yayasan_penyakit")
        grid_yp.DataSource = (DS.Tables("yayasan_penyakit")) 'setting datasource dari datagridview
        grid_yp.Enabled = True 'jadikan datagridview hanya readonly
    End Sub

    'isi combo box'
    Sub isicombopdba()
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT kd_ba from bencana_alam", connect)
        DR = CMD.ExecuteReader
        cb_pdba.Items.Clear()
        Do While DR.Read
            cb_pdba.Items.Add(DR.Item(0))
        Loop
        CMD.Dispose()
        DR.Close()
        connect.Close()
    End Sub
    Sub isicombopdds()
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT kd_ds from dana_sekolah", connect)
        DR = CMD.ExecuteReader
        cb_pdds.Items.Clear()
        Do While DR.Read
            cb_pdds.Items.Add(DR.Item(0))
        Loop
        CMD.Dispose()
        DR.Close()
        connect.Close()
    End Sub
    Sub isicombopdpa()
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT kd_pa from panti_asuhan", connect)
        DR = CMD.ExecuteReader
        cb_pdpa.Items.Clear()
        Do While DR.Read
            cb_pdpa.Items.Add(DR.Item(0))
        Loop
        CMD.Dispose()
        DR.Close()
        connect.Close()
    End Sub
    Sub isicombopdyp()
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT kd_yp from yayasan_penyakit", connect)
        DR = CMD.ExecuteReader
        cb_pdyp.Items.Clear()
        Do While DR.Read
            cb_pdyp.Items.Add(DR.Item(0))
        Loop
        CMD.Dispose()
        DR.Close()
        connect.Close()
    End Sub

    'sub bersih'
    Sub bersihba()
        kd_ba.Text = ""
        daerah_ba.Text = ""
        jenis_ba.Text = ""
        kd_ba.Focus()
    End Sub

    Sub bersihds()
        kd_ds.Text = ""
        nama_sekolah.Text = ""
        alamat_sekolah.Text = ""
        daerah_sekolah.Text = ""
        kd_ds.Focus()
    End Sub

    Sub bersihpa()
        kd_pa.Text = ""
        nama_panti.Text = ""
        alamat_panti.Text = ""
        daerah_panti.Text = ""
        kd_pa.Focus()
    End Sub

    Sub bersihyp()
        kd_yp.Text = ""
        nama_yys.Text = ""
        alamat_yys.Text = ""
        jenis_penyakit.Text = ""
        kd_yp.Focus()
    End Sub

    Private Sub ubah_pdba_Click(sender As Object, e As EventArgs) Handles ubah_pdba.Click

        Try
            Call openDB()
            ubah = "UPDATE bencana_alam SET daerah_ba='" & daerah_ba.Text & "',jenis_ba='" & jenis_ba.Text & "' WHERE kd_ba= '" & kd_ba.Text & "'"

            CMD = New Odbc.OdbcCommand(ubah, connect)
            CMD.ExecuteNonQuery()
            Call bersihba()
            Call isigridpdba()
            Call isicombopdba()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub cb_pdba_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_pdba.SelectedIndexChanged
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT kd_ba,daerah_ba,jenis_ba FROM bencana_alam WHERE kd_ba = '" & cb_pdba.Text & "'", connect)

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            kd_ba.Text = DR.Item(0)
            daerah_ba.Text = DR.Item(1)
            jenis_ba.Text = DR.Item(2)

            kd_ba.Enabled = False
            kd_ba.Focus()
        End If
    End Sub

    Private Sub hapus_pdba_Click(sender As Object, e As EventArgs) Handles hapus_pdba.Click
        Try
            Call openDB()
            hapus = "DELETE FROM bencana_alam WHERE kd_ba='" & kd_ba.Text & "'"
            CMD = New Odbc.OdbcCommand(hapus, connect)
            CMD.ExecuteNonQuery()
            Call bersihba()
            Call isigridpdba()
            Call isicombopdba()

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub ubah_pdds_Click(sender As Object, e As EventArgs) Handles ubah_pdds.Click

        Try
            Call openDB()
            ubah = "UPDATE dana_sekolah SET nama_sekolah='" & nama_sekolah.Text & "',alamat_sekolah='" & alamat_sekolah.Text & "',daerah_sekolah='" & daerah_sekolah.Text & "' WHERE kd_ds = '" & kd_ds.Text & "'"

            CMD = New Odbc.OdbcCommand(ubah, connect)
            CMD.ExecuteNonQuery()
            Call bersihds()
            Call isigridpdds()
            Call isicombopdds()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub cb_pdds_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_pdds.SelectedIndexChanged
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT kd_ds,nama_sekolah,alamat_sekolah,daerah_sekolah FROM dana_sekolah WHERE kd_ds = '" & cb_pdds.Text & "'", connect)

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            kd_ds.Text = DR.Item(0)
            nama_sekolah.Text = DR.Item(1)
            alamat_sekolah.Text = DR.Item(2)
            daerah_sekolah.Text = DR.Item(3)

            kd_ds.Enabled = False
            kd_ds.Focus()
        End If
    End Sub

    Private Sub hapus_pdds_Click(sender As Object, e As EventArgs) Handles hapus_pdds.Click
        Try
            Call openDB()
            hapus = "DELETE FROM dana_sekolah WHERE kd_ds='" & kd_ds.Text & "'"
            CMD = New Odbc.OdbcCommand(hapus, connect)
            CMD.ExecuteNonQuery()
            Call bersihds()
            Call isigridpdds()
            Call isicombopdds()

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub ubah_pdpa_Click(sender As Object, e As EventArgs) Handles ubah_pdpa.Click

        Try
            Call openDB()
            ubah = "UPDATE panti_asuhan SET nama_panti='" & nama_panti.Text & "',alamat_panti='" & alamat_panti.Text & "',daerah_panti='" & daerah_panti.Text & "' WHERE kd_pa = '" & kd_pa.Text & "'"

            CMD = New Odbc.OdbcCommand(ubah, connect)
            CMD.ExecuteNonQuery()
            Call bersihpa()
            Call isigridpdpa()
            Call isicombopdpa()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub cb_pdpa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_pdpa.SelectedIndexChanged
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT kd_pa,nama_panti,alamat_panti,daerah_panti FROM panti_asuhan WHERE kd_pa = '" & cb_pdpa.Text & "'", connect)

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            kd_pa.Text = DR.Item(0)
            nama_panti.Text = DR.Item(1)
            alamat_panti.Text = DR.Item(2)
            daerah_panti.Text = DR.Item(3)

            kd_pa.Enabled = False
            kd_pa.Focus()
        End If
    End Sub

    Private Sub hapus_pdpa_Click(sender As Object, e As EventArgs) Handles hapus_pdpa.Click
        Try
            Call openDB()
            hapus = "DELETE FROM panti_asuhan WHERE kd_pa='" & kd_pa.Text & "'"
            CMD = New Odbc.OdbcCommand(hapus, connect)
            CMD.ExecuteNonQuery()
            Call bersihpa()
            Call isigridpdpa()
            Call isicombopdpa()

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub ubah_pdyp_Click(sender As Object, e As EventArgs) Handles ubah_pdyp.Click

        Try
            Call openDB()
            ubah = "UPDATE yayasan_penyakit SET nama_yys='" & nama_yys.Text & "',alamat_yys='" & alamat_yys.Text & "', jenis_penyakit='" & jenis_penyakit.Text & "' WHERE kd_yp = '" & kd_yp.Text & "'"

            CMD = New Odbc.OdbcCommand(ubah, connect)
            CMD.ExecuteNonQuery()
            Call bersihyp()
            Call isigridpdyp()
            Call isicombopdyp()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub cb_pdyp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_pdyp.SelectedIndexChanged
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT kd_yp,nama_yys,alamat_yys,jenis_penyakit FROM yayasan_penyakit WHERE kd_yp = '" & cb_pdyp.Text & "'", connect)

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            kd_yp.Text = DR.Item(0)
            nama_yys.Text = DR.Item(1)
            alamat_yys.Text = DR.Item(2)
            jenis_penyakit.Text = DR.Item(3)

            kd_yp.Enabled = False
            kd_yp.Focus()
        End If
    End Sub

    Private Sub hapus_pdyp_Click(sender As Object, e As EventArgs) Handles hapus_pdyp.Click
        Try
            Call openDB()
            hapus = "DELETE FROM yayasan_penyakit WHERE kd_yp='" & kd_yp.Text & "'"
            CMD = New Odbc.OdbcCommand(hapus, connect)
            CMD.ExecuteNonQuery()
            Call bersihyp()
            Call isigridpdyp()
            Call isicombopdyp()

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub
End Class