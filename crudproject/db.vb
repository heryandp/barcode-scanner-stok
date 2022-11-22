Imports System.Data.SQLite

Public Class frmDb
    Dim mydata As New DataTable
    Dim myconnection As New SQLiteConnection("Data Source=.\produk.db")
    Dim mycommand, reader

    Sub Koneksi()
        myconnection.Open()
        mycommand = New SQLiteCommand(myconnection)
    End Sub

    Function RefreshDb()
        Call Koneksi()
        mycommand.CommandText = "select * from produk"
        reader = mycommand.ExecuteReader()
        mydata.Load(reader)
        reader.Close()
        myconnection.Close()
        DataGridView1.DataSource = mydata

        For Each txt In gbDb.Controls.OfType(Of TextBox)()
            txt.Text = Nothing
        Next

        Return 0
    End Function

    Private Sub frmDb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDb()
    End Sub

    Private Sub tbDbHarga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbDbHarga.KeyPress
        'Hanya menerima inputan number
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbDbStok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbDbStok.KeyPress
        'Hanya menerima inputan number
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        tbDbId.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        tbDbBc.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        tbDbNama.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        tbDbHarga.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        tbDbStok.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
    End Sub

    Private Sub btnDbTambah_Click(sender As Object, e As EventArgs) Handles btnDbTambah.Click
        If String.IsNullOrEmpty(tbDbBc.Text) Or String.IsNullOrEmpty(tbDbNama.Text) Or String.IsNullOrEmpty(tbDbHarga.Text) Or String.IsNullOrEmpty(tbDbStok.Text) Then
            MsgBox("Isian belum lengkap!", MessageBoxIcon.Information, "Hmm")
        Else
            crud("1", tbDbBc.Text, tbDbNama.Text, tbDbHarga.Text, tbDbStok.Text)
        End If
    End Sub

    Private Sub btnDbUbah_Click(sender As Object, e As EventArgs) Handles btnDbUbah.Click
        If String.IsNullOrEmpty(tbDbBc.Text) Or String.IsNullOrEmpty(tbDbNama.Text) Or String.IsNullOrEmpty(tbDbHarga.Text) Or String.IsNullOrEmpty(tbDbStok.Text) Then
            MsgBox("Isian belum lengkap!", MessageBoxIcon.Information, "Hmm")
        Else
            crud("2", tbDbId.Text, tbDbBc.Text, tbDbNama.Text, tbDbHarga.Text, tbDbStok.Text)
        End If
    End Sub
    Private Sub btnDbHapus_Click(sender As Object, e As EventArgs) Handles btnDbHapus.Click
        crud("3", tbDbId.Text)
    End Sub

    Function crud(ByVal ParamArray data() As String)
        Call Koneksi()
        If data(0) = "1" Then
            Try
                mycommand.CommandText = "INSERT INTO produk (barcode,nama,harga,stok) VALUES ('" & data(1) & "','" & data(2) & "'," & data(3) & "," & data(4) & ");"
                mycommand.ExecuteReader()
                MsgBox("Produk " & data(2) & " berhasil ditambahkan!",, "Tambah Produk")
            Catch ex As Exception
                If ex.Message.Contains("UNIQUE") Then
                    MsgBox("Barcode sudah ada! Pakai kode yang lain!")
                Else
                    MsgBox(ex.Message)
                End If
            End Try
        ElseIf data(0) = "2" Then
            Try
                Dim hasil As DialogResult = MsgBox("Apakah Anda yakin mengubah produk?", MessageBoxButtons.YesNo + MessageBoxIcon.Warning, "Konfirmasi Ubah")
                If hasil = DialogResult.Yes Then
                    mycommand.CommandText = "UPDATE produk SET barcode='" & data(2) & "',nama='" & data(3) & "',harga=" & data(4) & ",stok=" & data(5) & " WHERE id=" & data(1) & ";"
                    mycommand.ExecuteReader()
                    MsgBox("Produk " & data(2) & " berhasil diupdate!",, "Update Produk")
                End If
            Catch ex As Exception
                If ex.Message.Contains("UNIQUE") Then
                    MsgBox("Barcode sudah ada! Pakai kode yang lain!")
                Else
                    MsgBox(ex.Message)
                End If
            End Try
        ElseIf data(0) = "3" Then
            Try
                Dim hasil As DialogResult = MsgBox("Apakah Anda yakin menghapus produk?", MessageBoxButtons.YesNo + MessageBoxIcon.Warning, "Konfirmasi Hapus")
                If hasil = DialogResult.Yes Then
                    mycommand.CommandText = "DELETE FROM produk WHERE id=" & data(1) & ";"
                    mycommand.ExecuteReader()
                    MsgBox("Produk " & data(1) & " berhasil dihapus!",, "Hapus Produk")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        myconnection.Close()
        RefreshDb()
        Return 0
    End Function
End Class