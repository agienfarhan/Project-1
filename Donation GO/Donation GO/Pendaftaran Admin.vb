
Public Class Pendaftaran_Admin
    Private Sub Pendaftaran_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call openDB()
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
        Tambah_admin.Text = "Tambah"
    End Sub

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah_admin.Click
        Dim vttl_admin As String
        Dim vtgl As String
        Dim vbln As String
        Dim vthn As String

        vtgl = ttl_admin.Value.Day
        vbln = ttl_admin.Value.Month
        vthn = ttl_admin.Value.Year

        vttl_admin = vthn & "-" & vbln & "-" & vtgl

        If Tambah_admin.Text = "Tambah" Then
            Tambah_admin.Text = "Simpan"
            id_admin.Focus()
        Else
            Try
                Call openDB()
                CMD = New Odbc.OdbcCommand("SELECT id_admin from admin WHERE id_admin = '" & id_admin.Text & "'", connect)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    MsgBox("Maaf, Data dengan ID tersebut telah ada !", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    Call openDB()
                    simpan = "INSERT INTO admin (id_admin,pass_admin,fn_admin,ln_admin,jbtn_admin,gender_admin,ttl_admin,contact_admin) VALUES('" & id_admin.Text & "','" & pass_admin.Text & "','" & fn_admin.Text & "','" & ln_admin.Text & "','" & jbtn_admin.Text & "','" & cb_gender_admin.Text & "','" & vttl_admin & "','" & contact_admin.Text & "')"

                    CMD = New Odbc.OdbcCommand(simpan, connect)
                    CMD.ExecuteNonQuery()
                    Call bersih()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub Tutup_admin_Click(sender As Object, e As EventArgs) Handles Tutup_admin.Click
        Me.Close()
    End Sub

    Private Sub Batal_admin_Click(sender As Object, e As EventArgs) Handles Batal_admin.Click
        Call bersih()
    End Sub

    Private Sub pass_admin_TextChanged(sender As Object, e As EventArgs) Handles pass_admin.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub cb_gender_admin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_gender_admin.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ttl_admin_ValueChanged(sender As Object, e As EventArgs) Handles ttl_admin.ValueChanged
        
    End Sub
End Class