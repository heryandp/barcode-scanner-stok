Public Class frmCek
    Private Sub frmCek_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Space Then
            Me.Close()
        End If
    End Sub

    Private Sub frmCek_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmMain.tbcek.Text = Nothing
    End Sub

    Private Sub frmCek_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        lbCekBc2.Text = "-"
        lbCekNama2.Text = "-"
        lbCekHarga2.Text = "-"
        lbCekStok2.Text = "-"
    End Sub
End Class