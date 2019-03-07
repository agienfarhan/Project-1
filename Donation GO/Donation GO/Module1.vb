Imports System.Data
Imports System.Data.Odbc
Module Module1
    Public connect As OdbcConnection 'untuk input data'
    Public DA As OdbcDataAdapter
    Public DS As DataSet
    Public DR As OdbcDataReader
    Public CMD As OdbcCommand
    Public simpan, ubah, hapus As String

    Sub openDB()
        Try
            connect = New OdbcConnection("DSN=donation_go;MultipleActiveResultSets=True")
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If
        Catch ex As Exception
            MsgBox("Connect ke Database Bermasalah, Silahkan Periksa Koneksi Anda !")
        End Try
    End Sub

End Module

