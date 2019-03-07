Public Class PD_Donatur

    Private Sub PD_Donatur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call isigridpdd() 'menjalankan perintah dari sub isigrid()
        Call openDB()
        Call isicombopdd()
    End Sub

    Sub isigridpdd()

        openDB() 'memanggil koneksi ke database melalui modul
        DA = New Odbc.OdbcDataAdapter("SELECT * FROM donatur", connect)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "donatur")
        DataGridView1.DataSource = (DS.Tables("donatur")) 'setting datasource dari datagridview
        DataGridView1.Enabled = True 'jadikan datagridview hanya readonly
    End Sub

    Sub isicombopdd()
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT id_donatur from donatur", connect)
        DR = CMD.ExecuteReader
        ComboBox1.Items.Clear()
        Do While DR.Read
            ComboBox1.Items.Add(DR.Item(0))
        Loop
        CMD.Dispose()
        DR.Close()
        connect.Close()
    End Sub
    Sub bersih()
        id_donatur.Text = ""
        fn_donatur.Text = ""
        ln_donatur.Text = ""
        cb_gender_donatur.Text = ""
        ttl_donatur.Text = ""
        profesi_donatur.Text = ""
        contact_donatur.Text = ""
        id_donatur.Focus()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Call openDB()
            hapus = "DELETE FROM donatur WHERE id_donatur='" & id_donatur.Text & "'"
            CMD = New Odbc.OdbcCommand(hapus, connect)
            CMD.ExecuteNonQuery()
            Call bersih()
            Call isigridpdd()
            Call isicombopdd()

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT id_donatur,fn_donatur,ln_donatur,gender_donatur,ttl_donatur,profesi_donatur,contact_donatur FROM donatur WHERE id_donatur = '" & ComboBox1.Text & "'", connect)

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            id_donatur.Text = DR.Item(0)
            fn_donatur.Text = DR.Item(1)
            ln_donatur.Text = DR.Item(2)
            cb_gender_donatur.Text = DR.Item(3)
            ttl_donatur.Text = DR.Item(4)
            profesi_donatur.Text = DR.Item(5)
            contact_donatur.Text = DR.Item(6)


            id_donatur.Enabled = False
            id_donatur.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Call openDB()
            ubah = "UPDATE donatur SET fn_donatur='" & fn_donatur.Text & "',ln_donatur='" & ln_donatur.Text & "',gender_donatur='" & cb_gender_donatur.Text & "',ttl_donatur='" & Format(ttl_donatur.Value, "yyyy-MM-dd") & "',profesi_donatur='" & profesi_donatur.Text & "',contact_donatur='" & contact_donatur.Text & "' WHERE id_donatur = '" & id_donatur.Text & "'"

            CMD = New Odbc.OdbcCommand(ubah, connect)
            CMD.ExecuteNonQuery()
            Call bersih()
            Call isigridpdd()
            Call isicombopdd()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call bersih()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class