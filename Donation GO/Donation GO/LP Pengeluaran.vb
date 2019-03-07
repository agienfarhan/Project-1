Public Class LP_Pengeluaran

    Private Sub LP_Pengeluaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call isigridLPba()
    End Sub
    Sub isigridLPba()
        openDB() 'memanggil koneksi ke database melalui modul
        DA = New Odbc.OdbcDataAdapter("SELECT * FROM pengeluaran_ba", connect)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "pengeluaran_ba")
        DGLP_ba.DataSource = (DS.Tables("pengeluaran_ba")) 'setting datasource dari datagridview
        DGLP_ba.Enabled = True 'jadikan datagridview hanya readonly
    End Sub
End Class