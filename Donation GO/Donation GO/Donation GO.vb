Public Class Donation_GO
    Sub Terkunci()
        LoginToolStripMenuItem.Enabled = True
        ExitToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        DonasiToolStripMenuItem.Enabled = False
        AdminToolStripMenuItem.Enabled = False
        DonaturToolStripMenuItem.Enabled = False
        DonasiToolStripMenuItem1.Enabled = False
        AdminToolStripMenuItem1.Enabled = False
        DonaturToolStripMenuItem1.Enabled = False
        PenerimaanToolStripMenuItem.Enabled = False
        PengeluaranToolStripMenuItem.Enabled = False
        PenerimaanToolStripMenuItem1.Enabled = False
        PengeluaranToolStripMenuItem1.Enabled = False
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembaruanToolStripMenuItem.Click

    End Sub

    Private Sub TransaksiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem1.Click

    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub DonasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonasiToolStripMenuItem.Click
        Pendaftaran_Donasi.Show()
        Pendaftaran_Donasi.MdiParent = Me
    End Sub

    Private Sub DonaturToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonaturToolStripMenuItem.Click
        Pendaftaran_Donatur.Show()
        Pendaftaran_Donatur.MdiParent = Me
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Pendaftaran_Admin.Show()
        Pendaftaran_Admin.MdiParent = Me
    End Sub

    Private Sub PenerimaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenerimaanToolStripMenuItem.Click
        Penerimaan.Show()
        Penerimaan.MdiParent = Me
    End Sub

    Private Sub PengeluaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengeluaranToolStripMenuItem.Click
        Pengeluaran.Show()
        Pengeluaran.MdiParent = Me
    End Sub

    Private Sub DonasiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DonasiToolStripMenuItem1.Click
        PD_Donasi.Show()
        PD_Donasi.MdiParent = Me
    End Sub

    Private Sub DonaturToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DonaturToolStripMenuItem1.Click
        PD_Donatur.Show()
        PD_Donatur.MdiParent = Me
    End Sub

    Private Sub AdminToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem1.Click
        PD_Admin.Show()
        PD_Admin.MdiParent = Me
    End Sub

    Private Sub PenerimaanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PenerimaanToolStripMenuItem1.Click
        LP_Penerimaan.Show()
        LP_Penerimaan.MdiParent = Me
    End Sub

    Private Sub PengeluaranToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PengeluaranToolStripMenuItem1.Click
        LP_Pengeluaran.Show()
        LP_Pengeluaran.MdiParent = Me
    End Sub

    Private Sub LogoutToolStripMenuItem2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Login.Show()
        Login.MdiParent = Me
    End Sub

    Private Sub LogoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Terkunci()
        Login.Show()
        Close()
    End Sub
End Class
