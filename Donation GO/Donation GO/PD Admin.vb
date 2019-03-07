Public Class PD_Admin
 Private Sub PD_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call isigridpda() 'menjalankan perintah dari sub isigrid()
        Call openDB()
        Call isicombopda()

    End Sub
    Sub isigridpda()

        openDB() 'memanggil koneksi ke database melalui modul
        DA = New Odbc.OdbcDataAdapter("SELECT * FROM admin", connect)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "admin")
        DataGridView1.DataSource = (DS.Tables("admin")) 'setting datasource dari datagridview
        DataGridView1.Enabled = True 'jadikan datagridview hanya readonly
    End Sub
    Sub isicombopda()
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT id_admin from admin", connect)
        DR = CMD.ExecuteReader
        ComboBox2.Items.Clear()
        Do While DR.Read
            ComboBox2.Items.Add(DR.Item(0))
        Loop
        CMD.Dispose()
        DR.Close()
        connect.Close()
    End Sub
    Sub bersih()
        id_admin.Text = ""
        pass_admin.Text = ""
        fn_admin.Text = ""
        ln_admin.Text = ""
        jbtn_admin.Text = ""
        cb_gender_admin.Text = ""
        ttl_admin.Text = ""
        contact_admin.Text = ""
        id_admin.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Call openDB()
            hapus = "DELETE FROM admin WHERE id_admin='" & id_admin.Text & "'"
            CMD = New Odbc.OdbcCommand(hapus, connect)
            CMD.ExecuteNonQuery()
            Call bersih()
            Call isigridpda()
            Call isicombopda()

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call openDB()
        CMD = New Odbc.OdbcCommand("SELECT id_admin,pass_admin,fn_admin,ln_admin,jbtn_admin,gender_admin,ttl_admin,contact_admin FROM admin WHERE id_admin = '" & ComboBox2.Text & "'", connect)

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            id_admin.Text = DR.Item(0)
            pass_admin.Text = DR.Item(1)
            fn_admin.Text = DR.Item(2)
            ln_admin.Text = DR.Item(3)
            jbtn_admin.Text = DR.Item(4)
            cb_gender_admin.Text = DR.Item(5)
            ttl_admin.Text = DR.Item(6)
            contact_admin.Text = DR.Item(7)

            id_admin.Enabled = False
            id_admin.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Call openDB()
            ubah = "UPDATE admin SET pass_admin='" & pass_admin.Text & "',fn_admin='" & fn_admin.Text & "',ln_admin='" & ln_admin.Text & "',jbtn_admin='" & jbtn_admin.Text & "',gender_admin='" & cb_gender_admin.Text & "',ttl_admin='" & ttl_admin.Text & "',contact_admin='" & contact_admin.Text & "' WHERE id_admin = '" & id_admin.Text & "'"

            CMD = New Odbc.OdbcCommand(ubah, connect)
            CMD.ExecuteNonQuery()
            Call bersih()
            Call isigridpda()
            Call isicombopda()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call bersih()
    End Sub
End Class