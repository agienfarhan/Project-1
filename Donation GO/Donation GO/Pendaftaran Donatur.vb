Public Class Pendaftaran_Donatur

    Private Sub Pendaftaran_Donatur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call openDB()
    End Sub
    Sub bersih()
        id_donatur.Text = ""
        fn_donatur.Text = ""
        ln_donatur.Text = ""
        cb_gender_donatur.Text = ""
        ttl_donatur.Text = ""
        profesi_donatur.Text = ""
        contact_donatur.Text = ""
        email_donatur.Text = ""
        id_donatur.Focus()
        Tambah_donatur.Text = "Tambah"
    End Sub


    Private Sub Tambah_donatur_Click(sender As Object, e As EventArgs) Handles Tambah_donatur.Click
        Dim vttl_donatur As String
        Dim vtgl As String
        Dim vbln As String
        Dim vthn As String

        vtgl = ttl_donatur.Value.Day
        vbln = ttl_donatur.Value.Month
        vthn = ttl_donatur.Value.Year

        vttl_donatur = vthn & "-" & vbln & "-" & vtgl

        If Tambah_donatur.Text = "Tambah" Then
            Tambah_donatur.Text = "Simpan"
            id_donatur.Focus()
        Else
            Try
                Call openDB()
                CMD = New Odbc.OdbcCommand("SELECT id_donatur from donatur WHERE id_donatur = '" & id_donatur.Text & "'", connect)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    MsgBox("Maaf, Data dengan ID tersebut telah ada !", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    Call openDB()
                    simpan = "INSERT INTO donatur (id_donatur,fn_donatur,ln_donatur,gender_donatur,ttl_donatur,profesi_donatur,contact_donatur,email_donatur) VALUES('" & id_donatur.Text & "','" & fn_donatur.Text & "','" & ln_donatur.Text & "','" & cb_gender_donatur.Text & "','" & vttl_donatur & "','" & profesi_donatur.Text & "','" & contact_donatur.Text & "','" & email_donatur.Text & "')"

                    CMD = New Odbc.OdbcCommand(simpan, connect)
                    CMD.ExecuteNonQuery()
                    Call bersih()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub Tutup_donatur_Click(sender As Object, e As EventArgs) Handles Tutup_donatur.Click
        Me.Close()
    End Sub

    Private Sub Batal_donatur_Click(sender As Object, e As EventArgs) Handles Batal_donatur.Click
        Call bersih()
    End Sub
End Class