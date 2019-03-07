Public Class Penerimaan

    Private Sub Penerimaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call openDB()

        Call isicombokdba()
        Call isicombokdds()
        Call isicombokdpa()
        Call isicombokdyp()

        Call isicomboiddonaturba()
        Call isicomboiddonaturds()
        Call isicomboiddonaturpa()
        Call isicomboiddonaturyp()

        Call isicombotuba()
        Call isicombotuds()
        Call isicombotupa()
        Call isicombotuyp()

        Call isicomboidadminba()
        Call isicomboidadminds()
        Call isicomboidadminpa()
        Call isicomboidadminyp()

    End Sub
    'sub bersih untuk donasi
    Sub bersihprba()
        kd_penerimaan_ba.Text = ""
        fn_donatur_ba.Text = ""
        ln_donatur_ba.Text = ""
        daerah_ba.Text = ""
        jenis_ba.Text = ""
        nominal_uang_ba.Text = ""
        tgl_penerimaan_ba.Text = ""
        ln_admin_ba.Text = ""
        kd_penerimaan_ba.Focus()
        tambah_ba.Text = "Tambah"
    End Sub
    'isi combo kode donasi
    Sub isicombokdba()
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT kd_ba from bencana_alam", connect)
        DR = CMD.ExecuteReader
        cb_kd_ba.Items.Clear()
        Do While DR.Read
            cb_kd_ba.Items.Add(DR.Item(0))
        Loop
        CMD.Dispose()
        DR.Close()
        connect.Close()
    End Sub

    Sub isicombokdds()

    End Sub

    Sub isicombokdpa()

    End Sub

    Sub isicombokdyp()

    End Sub
    ' isi combo id_donatur
    Sub isicomboiddonaturba()
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT id_donatur from donatur", connect)
        DR = CMD.ExecuteReader
        cb_id_donatur_ba.Items.Clear()
        Do While DR.Read
            cb_id_donatur_ba.Items.Add(DR.Item(0))
        Loop
        CMD.Dispose()
        DR.Close()
        connect.Close()
    End Sub

    Sub isicomboiddonaturds()

    End Sub

    Sub isicomboiddonaturpa()

    End Sub

    Sub isicomboiddonaturyp()

    End Sub
    'isi combo tipe uang
    Sub isicombotuba()
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT kd_tpuang from tipe_uang", connect)
        DR = CMD.ExecuteReader
        cb_tu_ba.Items.Clear()
        Do While DR.Read
            cb_tu_ba.Items.Add(DR.Item(0))
        Loop
        CMD.Dispose()
        DR.Close()
        connect.Close()
    End Sub

    Sub isicombotuds()

    End Sub

    Sub isicombotupa()

    End Sub

    Sub isicombotuyp()

    End Sub
    'isi combo id_admin
    Sub isicomboidadminba()
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT id_admin from admin", connect)
        DR = CMD.ExecuteReader
        cb_id_admin_ba.Items.Clear()
        Do While DR.Read
            cb_id_admin_ba.Items.Add(DR.Item(0))
        Loop
        CMD.Dispose()
        DR.Close()
        connect.Close()
    End Sub

    Sub isicomboidadminds()

    End Sub

    Sub isicomboidadminpa()

    End Sub

    Sub isicomboidadminyp()

    End Sub

    Private Sub tambah_ba_Click(sender As Object, e As EventArgs) Handles tambah_ba.Click
        If tambah_ba.Text = "Tambah" Then
            tambah_ba.Text = "Simpan"
            kd_penerimaan_ba.Focus()
        Else
            Try
                Call openDB()
                CMD = New Odbc.OdbcCommand("SELECT kd_penerimaan from penerimaan_ba WHERE kd_penerimaan = '" & kd_penerimaan_ba.Text & "'", connect)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    MsgBox("Maaf, Data dengan ID tersebut telah ada !", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    Call openDB()
                    simpan = "INSERT INTO penerimaan_ba (kd_penerimaan,id_donatur,kd_ba,uang_ba,tgl_penerimaan_ba,id_admin) VALUES('" & kd_penerimaan_ba.Text & "','" & cb_id_donatur_ba.Text & "','" & cb_kd_ba.Text & "','" & nominal_uang_ba.Text & "','" & Format(tgl_penerimaan_ba.Value, "yyyy-MM-dd") & "','" & cb_id_admin_ba.Text & "')"

                    CMD = New Odbc.OdbcCommand(simpan, connect)
                    CMD.ExecuteNonQuery()
                    Call bersihprba()
                    Call isicomboiddonaturba()
                    Call isicombokdba()
                    Call isicomboidadminba()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub cb_id_donatur_ba_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_id_donatur_ba.SelectedIndexChanged
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT fn_donatur,ln_donatur FROM donatur WHERE id_donatur = '" & cb_id_donatur_ba.Text & "'", connect)

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            fn_donatur_ba.Text = DR.Item(0)
            ln_donatur_ba.Text = DR.Item(1)

            fn_donatur_ba.Enabled = False
            ln_donatur_ba.Enabled = False
            fn_donatur_ba.Focus()
        End If
    End Sub

    Private Sub cb_kd_ba_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_kd_ba.SelectedIndexChanged
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT daerah_ba,jenis_ba FROM bencana_alam WHERE kd_ba = '" & cb_kd_ba.Text & "'", connect)

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            daerah_ba.Text = DR.Item(0)
            jenis_ba.Text = DR.Item(1)

            daerah_ba.Enabled = False
            jenis_ba.Enabled = False
            daerah_ba.Focus()
        End If
    End Sub

    Private Sub cb_tu_ba_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_tu_ba.SelectedIndexChanged
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT nominal_uang FROM tipe_uang WHERE kd_tpuang = '" & cb_tu_ba.Text & "'", connect)

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            nominal_uang_ba.Text = DR.Item(0)

            nominal_uang_ba.Enabled = False
            nominal_uang_ba.Focus()
        End If
    End Sub

    Private Sub cb_id_admin_ba_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_id_admin_ba.SelectedIndexChanged
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT ln_admin FROM admin WHERE id_admin = '" & cb_id_admin_ba.Text & "'", connect)

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            ln_admin_ba.Text = DR.Item(0)

            ln_admin_ba.Enabled = False
            ln_admin_ba.Focus()
        End If
    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click

    End Sub
End Class