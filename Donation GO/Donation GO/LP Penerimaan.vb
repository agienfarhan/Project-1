Public Class LP_Penerimaan

    Private Sub LP_Penerimaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call isigridLPba()
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

    Private Sub DGPenerimaan_ba_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGLP_ba.CellContentClick

    End Sub

    Private Sub Hitung_Click(sender As Object, e As EventArgs) Handles Hitung.Click
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
    Private Function Search(ByVal Name As String) As Integer
        Try
            Dim FoundRow As DataGridViewRow = (
            From row As DataGridViewRow In DGLP_ba.Rows
            Where row.Cells(1).Value = Name
            Select row
            ).First

            If FoundRow IsNot Nothing Then
                Return (FoundRow.Index)
            Else
                Return -1
            End If
        Catch ex As Exception
            Return -1
        End Try

    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        openDB() 'memanggil koneksi ke database melalui modul
        DA = New Odbc.OdbcDataAdapter("SELECT * FROM penerimaan_ba WHERE kd_ba LIKE '" & TextBox1.Text & "%'", connect)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "penerimaan_ba")
        DGLP_ba.DataSource = (DS.Tables("penerimaan_ba")) 'setting datasource dari datagridview
        DGLP_ba.Enabled = True 'jadikan datagridview hanya readonly

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class