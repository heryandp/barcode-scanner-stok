<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDb
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDb))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gbDb = New System.Windows.Forms.GroupBox()
        Me.tbDbBc = New System.Windows.Forms.TextBox()
        Me.lbDbBc = New System.Windows.Forms.Label()
        Me.tbDbId = New System.Windows.Forms.TextBox()
        Me.lbDbId = New System.Windows.Forms.Label()
        Me.btnDbHapus = New System.Windows.Forms.Button()
        Me.btnDbUbah = New System.Windows.Forms.Button()
        Me.btnDbTambah = New System.Windows.Forms.Button()
        Me.tbDbStok = New System.Windows.Forms.TextBox()
        Me.tbDbHarga = New System.Windows.Forms.TextBox()
        Me.tbDbNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDb.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Location = New System.Drawing.Point(334, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(406, 426)
        Me.DataGridView1.TabIndex = 0
        '
        'gbDb
        '
        Me.gbDb.Controls.Add(Me.tbDbBc)
        Me.gbDb.Controls.Add(Me.lbDbBc)
        Me.gbDb.Controls.Add(Me.tbDbId)
        Me.gbDb.Controls.Add(Me.lbDbId)
        Me.gbDb.Controls.Add(Me.btnDbHapus)
        Me.gbDb.Controls.Add(Me.btnDbUbah)
        Me.gbDb.Controls.Add(Me.btnDbTambah)
        Me.gbDb.Controls.Add(Me.tbDbStok)
        Me.gbDb.Controls.Add(Me.tbDbHarga)
        Me.gbDb.Controls.Add(Me.tbDbNama)
        Me.gbDb.Controls.Add(Me.Label3)
        Me.gbDb.Controls.Add(Me.Label2)
        Me.gbDb.Controls.Add(Me.Label1)
        Me.gbDb.Location = New System.Drawing.Point(13, 13)
        Me.gbDb.Name = "gbDb"
        Me.gbDb.Size = New System.Drawing.Size(315, 209)
        Me.gbDb.TabIndex = 1
        Me.gbDb.TabStop = False
        Me.gbDb.Text = "DB"
        '
        'tbDbBc
        '
        Me.tbDbBc.Location = New System.Drawing.Point(114, 47)
        Me.tbDbBc.Name = "tbDbBc"
        Me.tbDbBc.Size = New System.Drawing.Size(195, 20)
        Me.tbDbBc.TabIndex = 12
        '
        'lbDbBc
        '
        Me.lbDbBc.AutoSize = True
        Me.lbDbBc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDbBc.Location = New System.Drawing.Point(13, 47)
        Me.lbDbBc.Name = "lbDbBc"
        Me.lbDbBc.Size = New System.Drawing.Size(61, 17)
        Me.lbDbBc.TabIndex = 11
        Me.lbDbBc.Text = "Barcode"
        '
        'tbDbId
        '
        Me.tbDbId.Location = New System.Drawing.Point(114, 19)
        Me.tbDbId.Name = "tbDbId"
        Me.tbDbId.ReadOnly = True
        Me.tbDbId.Size = New System.Drawing.Size(195, 20)
        Me.tbDbId.TabIndex = 10
        '
        'lbDbId
        '
        Me.lbDbId.AutoSize = True
        Me.lbDbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDbId.Location = New System.Drawing.Point(13, 19)
        Me.lbDbId.Name = "lbDbId"
        Me.lbDbId.Size = New System.Drawing.Size(70, 17)
        Me.lbDbId.TabIndex = 9
        Me.lbDbId.Text = "ID Produk"
        '
        'btnDbHapus
        '
        Me.btnDbHapus.Location = New System.Drawing.Point(214, 166)
        Me.btnDbHapus.Name = "btnDbHapus"
        Me.btnDbHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnDbHapus.TabIndex = 8
        Me.btnDbHapus.Text = "Hapus"
        Me.btnDbHapus.UseVisualStyleBackColor = True
        '
        'btnDbUbah
        '
        Me.btnDbUbah.Location = New System.Drawing.Point(115, 166)
        Me.btnDbUbah.Name = "btnDbUbah"
        Me.btnDbUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnDbUbah.TabIndex = 7
        Me.btnDbUbah.Text = "Ubah"
        Me.btnDbUbah.UseVisualStyleBackColor = True
        '
        'btnDbTambah
        '
        Me.btnDbTambah.Location = New System.Drawing.Point(16, 166)
        Me.btnDbTambah.Name = "btnDbTambah"
        Me.btnDbTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnDbTambah.TabIndex = 6
        Me.btnDbTambah.Text = "Tambah"
        Me.btnDbTambah.UseVisualStyleBackColor = True
        '
        'tbDbStok
        '
        Me.tbDbStok.Location = New System.Drawing.Point(114, 141)
        Me.tbDbStok.Name = "tbDbStok"
        Me.tbDbStok.Size = New System.Drawing.Size(195, 20)
        Me.tbDbStok.TabIndex = 5
        '
        'tbDbHarga
        '
        Me.tbDbHarga.Location = New System.Drawing.Point(114, 109)
        Me.tbDbHarga.Name = "tbDbHarga"
        Me.tbDbHarga.Size = New System.Drawing.Size(195, 20)
        Me.tbDbHarga.TabIndex = 4
        '
        'tbDbNama
        '
        Me.tbDbNama.Location = New System.Drawing.Point(114, 76)
        Me.tbDbNama.Name = "tbDbNama"
        Me.tbDbNama.Size = New System.Drawing.Size(195, 20)
        Me.tbDbNama.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Stok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Harga"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Produk"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 253)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(315, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmDb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbDb)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDb.ResumeLayout(False)
        Me.gbDb.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents gbDb As GroupBox
    Friend WithEvents tbDbStok As TextBox
    Friend WithEvents tbDbHarga As TextBox
    Friend WithEvents tbDbNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDbHapus As Button
    Friend WithEvents btnDbUbah As Button
    Friend WithEvents btnDbTambah As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbDbId As TextBox
    Friend WithEvents lbDbId As Label
    Friend WithEvents tbDbBc As TextBox
    Friend WithEvents lbDbBc As Label
End Class
