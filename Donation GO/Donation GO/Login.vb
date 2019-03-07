Imports MySql.Data.MySqlClient
Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As MySqlConnection
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user id=root; password= ; database=donation_go"

        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Ada kesalahan dalam koneksi database, silahkan periksa koneksi database")
        End Try

        Dim sql, id_admin, password, jabatan As String
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader

        id_admin = id_admin_text.Text
        password = pass_admin_text.Text
        jabatan = cb_jabatan.SelectedItem

        sql = "select * from admin where id_admin='" + id_admin + "'AND pass_admin='" + password + "'AND jbtn_admin='" + jabatan + "'"
        cmd = New MySqlCommand(sql, conn)
        dr = cmd.ExecuteReader()

        If dr.HasRows = True And cb_jabatan.SelectedItem = "Staff" Then
            Donation_GO.Show()
            Call openstaff()
            Me.Hide()
        ElseIf dr.HasRows = True And cb_jabatan.SelectedItem = "Manager" Then
            Donation_GO.Show()
            Call openmanager()
            Me.Hide()
        Else
            MsgBox("Username atau Password ada yang salah !", MsgBoxStyle.Exclamation, "Error Login")
        End If
    End Sub

    Sub openstaff()
        Donation_GO.LoginToolStripMenuItem.Enabled = False
        Donation_GO.LogoutToolStripMenuItem.Enabled = True
        Donation_GO.ExitToolStripMenuItem.Enabled = True
        Donation_GO.DonasiToolStripMenuItem.Enabled = True
        Donation_GO.AdminToolStripMenuItem.Enabled = True
        Donation_GO.DonaturToolStripMenuItem.Enabled = True
        Donation_GO.DonasiToolStripMenuItem1.Enabled = True
        Donation_GO.AdminToolStripMenuItem1.Enabled = True
        Donation_GO.DonaturToolStripMenuItem1.Enabled = True
        Donation_GO.PenerimaanToolStripMenuItem.Enabled = True
        Donation_GO.PengeluaranToolStripMenuItem.Enabled = True
        Donation_GO.PenerimaanToolStripMenuItem1.Enabled = True
        Donation_GO.PengeluaranToolStripMenuItem1.Enabled = True
    End Sub
    Sub openmanager()
        Donation_GO.LoginToolStripMenuItem.Enabled = False
        Donation_GO.LogoutToolStripMenuItem.Enabled = True
        Donation_GO.ExitToolStripMenuItem.Enabled = True
        Donation_GO.DonasiToolStripMenuItem.Enabled = False
        Donation_GO.AdminToolStripMenuItem.Enabled = False
        Donation_GO.DonaturToolStripMenuItem.Enabled = False
        Donation_GO.DonasiToolStripMenuItem1.Enabled = False
        Donation_GO.AdminToolStripMenuItem1.Enabled = False
        Donation_GO.DonaturToolStripMenuItem1.Enabled = False
        Donation_GO.PenerimaanToolStripMenuItem.Enabled = False
        Donation_GO.PengeluaranToolStripMenuItem.Enabled = False
        Donation_GO.PenerimaanToolStripMenuItem1.Enabled = True
        Donation_GO.PengeluaranToolStripMenuItem1.Enabled = True
    End Sub
End Class