Imports System.Globalization
Imports System.Data.SQLite
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing

Public Class frmMain
    Dim dt As String = ""
    Dim dtfInfo As DateTimeFormatInfo
    Dim dtStyle As String = "ddd, dd MMMM yyyy"
    Dim videoSource As VideoCaptureDevice
    Dim captureDevice As FilterInfoCollection
    Dim reader As New BarcodeReader()
    Dim writer As New BarcodeWriter()
    Dim bmp As Bitmap
    Dim result
    Dim mydata As New DataTable
    Dim myconnection As New SQLiteConnection("Data Source=.\produk.db")
    Dim mycommand, readercek

    Sub Koneksi()
        myconnection.Open()
        mycommand = New SQLiteCommand(myconnection)
    End Sub

    Private Sub btncek_Click(sender As Object, e As EventArgs) Handles btncek.Click
        Try
            If String.IsNullOrEmpty(tbcek.Text) Then
                'pass
            Else
                Call Koneksi()
                mycommand.CommandText = "select * from produk where barcode='" & tbcek.Text & "';"
                readercek = mycommand.ExecuteReader()
                If readercek.Read() Then
                    frmCek.lbCekBc2.Text = readercek("barcode").ToString
                    frmCek.lbCekNama2.Text = readercek("nama").ToString
                    frmCek.lbCekHarga2.Text = String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", readercek("harga"))
                    frmCek.lbCekStok2.Text = readercek("stok").ToString
                    writer.Format = BarcodeFormat.CODE_128
                    frmCek.pbCekBC.Image = writer.Write(readercek("barcode").ToString)
                    frmCek.Show()
                    myconnection.Close()
                Else
                    MsgBox("Data tidak ditemukan!", MessageBoxIcon.Error, "Oops")
                    myconnection.Close()
                End If
            End If
        Catch ex As Exception
            myconnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtfInfo = DateTimeFormatInfo.InvariantInfo
        dt = DateTime.Now.ToString(dtStyle, dtfInfo)

        captureDevice = New FilterInfoCollection(FilterCategory.VideoInputDevice)

        If captureDevice.Count = 0 Then
            MsgBox("Tidak ada camera terdeteksi!",, "Oops")
            For Each dev In captureDevice
                cbdevices.Items.Add(dev.Name)
            Next
            videoSource = New VideoCaptureDevice()
        Else
            For Each dev In captureDevice
                cbdevices.Items.Add(dev.Name)
            Next
            videoSource = New VideoCaptureDevice()
            cbdevices.SelectedIndex = 0
        End If
    End Sub

    Private Sub btndb_Click(sender As Object, e As EventArgs) Handles btndb.Click
        frmDb.Show()
    End Sub

    Private Sub cbdevices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdevices.SelectedIndexChanged
        webcam()
    End Sub

    Private Function webcam()
        If videoSource.IsRunning Then
            videoSource.SignalToStop()
            videoSource.WaitForStop()
            picbc.Image = Nothing
            picbc.Invalidate()
        End If
        videoSource = New VideoCaptureDevice(captureDevice(cbdevices.SelectedIndex).MonikerString)
        AddHandler videoSource.NewFrame, New NewFrameEventHandler(AddressOf videoSource_NewFrame)
        videoSource.Start()
        Timer1.Start()
        Return 0
    End Function

    Private Sub videoSource_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        picbc.Image = bmp
    End Sub
    Private Sub frm1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        videoSource.SignalToStop()
        videoSource.WaitForStop()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        result = reader.Decode(bmp)
        If result IsNot Nothing Then
            If tbcek.InvokeRequired Then
                tbcek.Invoke(CType(Sub() tbcek.Text = result.ToString, MethodInvoker))
            Else
                Call Koneksi()
                mycommand.CommandText = "select * from produk where barcode='" & result.ToString & "';"
                readercek = mycommand.ExecuteReader()
                If readercek.Read() Then
                    My.Computer.Audio.Play(".\beep.wav")
                    frmCek.lbCekBc2.Text = readercek("barcode").ToString
                    frmCek.lbCekNama2.Text = readercek("nama").ToString
                    frmCek.lbCekHarga2.Text = String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", readercek("harga"))
                    frmCek.lbCekStok2.Text = readercek("stok").ToString
                    writer.Format = BarcodeFormat.CODE_128
                    frmCek.pbCekBC.Image = writer.Write(readercek("barcode").ToString)
                    frmCek.Show()
                    myconnection.Close()
                Else
                    MsgBox("Data tidak ditemukan!", MessageBoxIcon.Error, "Oops")
                    myconnection.Close()
                End If
            End If
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        lbWaktu.Text = DateTime.Now.ToString()
    End Sub
    Private Function tambahZero(ByVal value As Integer) As String
        Return value.ToString().PadLeft(2, "0")
    End Function
End Class