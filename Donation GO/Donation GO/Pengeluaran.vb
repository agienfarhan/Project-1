Public Class Pengeluaran

    Private Sub Pengeluaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call isigridLPba()
        Call isicomboidadminba()
    End Sub
    Sub isigridLPba()
        openDB() 'memanggil koneksi ke database melalui modul
        DA = New Odbc.OdbcDataAdapter("SELECT * FROM penerimaan_ba", connect)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "penerimaan_ba")
        DGLP_ba.DataSource = (DS.Tables("penerimaan_ba")) 'setting datasource dari datagridview
        DGLP_ba.Enabled = True 'jadikan datagridview hanya readonly
    End Sub
    Sub bersihplba()
        kd_pengeluaran_ba.Text = ""
        Saring_ba.Text = ""
        td_ba.Text = ""
        tgl_pengeluaran_ba.Text = ""
        TT_ba.Text = ""
        cb_id_admin_ba.Text = ""
        cb_id_relawan_ba.Text = ""
        kd_pengeluaran_ba.Focus()
        tambah_ba.Text = "Tambah"
    End Sub
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
    Private Sub Hitung_tdba_Click(sender As Object, e As EventArgs) Handles Hitung_tdba.Click
        Dim total_ba As Integer = 0
        For i As Integer = 0 To DGLP_ba.RowCount - 1
            If DGLP_ba.Rows(i).Cells(4).Value Then
                total_ba += DGLP_ba.Rows(i).Cells(4).Value
            End If
        Next
        If total_ba = 0 Then
            MessageBox.Show("No Records Found")
        End If
        td_ba.Text = total_ba
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Saring_ba.TextChanged
        openDB() 'memanggil koneksi ke database melalui modul
        DA = New Odbc.OdbcDataAdapter("SELECT * FROM penerimaan_ba WHERE kd_ba LIKE '" & Saring_ba.Text & "%'", connect)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "penerimaan_ba")
        DGLP_ba.DataSource = (DS.Tables("penerimaan_ba")) 'setting datasource dari datagridview
        DGLP_ba.Enabled = True 'jadikan datagridview hanya readonly
    End Sub


   
    Private Sub tambah_ba_Click(sender As Object, e As EventArgs) Handles tambah_ba.Click
        If tambah_ba.Text = "Tambah" Then
            tambah_ba.Text = "Simpan"
            kd_pengeluaran_ba.Focus()
        Else
            Try
                Call openDB()
                CMD = New Odbc.OdbcCommand("SELECT kd_pengeluaran_ba from pengeluaran_ba WHERE kd_pengeluaran_ba = '" & kd_pengeluaran_ba.Text & "'", connect)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    MsgBox("Maaf, Data dengan ID tersebut telah ada !", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    Call openDB()
                    simpan = "INSERT INTO pengeluaran_ba (kd_pengeluaran_ba,td_ba,tgl_pengeluaran,tipe_transaksi,id_admin,id_relawan) VALUES('" & kd_pengeluaran_ba.Text & "','" & td_ba.Text & "','" & Format(tgl_pengeluaran_ba.Value, "yyyy-MM-dd") & "','" & TT_ba.Text & "','" & cb_id_admin_ba.Text & "','" & cb_id_relawan_ba.Text & "')"

                    CMD = New Odbc.OdbcCommand(simpan, connect)
                    CMD.ExecuteNonQuery()
                    Call bersihplba()
                    Call isicomboidadminba()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
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
End Class