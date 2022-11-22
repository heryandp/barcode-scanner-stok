<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCek
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCek))
        Me.lbCekNama = New System.Windows.Forms.Label()
        Me.lbCekHarga = New System.Windows.Forms.Label()
        Me.lbCekStok = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbCekBc = New System.Windows.Forms.Label()
        Me.pbCekBC = New System.Windows.Forms.PictureBox()
        Me.lbCekBc2 = New System.Windows.Forms.Label()
        Me.lbCekNama2 = New System.Windows.Forms.Label()
        Me.lbCekHarga2 = New System.Windows.Forms.Label()
        Me.lbCekStok2 = New System.Windows.Forms.Label()
        CType(Me.pbCekBC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbCekNama
        '
        Me.lbCekNama.AutoSize = True
        Me.lbCekNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCekNama.Location = New System.Drawing.Point(24, 72)
        Me.lbCekNama.Name = "lbCekNama"
        Me.lbCekNama.Size = New System.Drawing.Size(51, 20)
        Me.lbCekNama.TabIndex = 0
        Me.lbCekNama.Text = "Nama"
        '
        'lbCekHarga
        '
        Me.lbCekHarga.AutoSize = True
        Me.lbCekHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCekHarga.Location = New System.Drawing.Point(24, 109)
        Me.lbCekHarga.Name = "lbCekHarga"
        Me.lbCekHarga.Size = New System.Drawing.Size(53, 20)
        Me.lbCekHarga.TabIndex = 1
        Me.lbCekHarga.Text = "Harga"
        '
        'lbCekStok
        '
        Me.lbCekStok.AutoSize = True
        Me.lbCekStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCekStok.Location = New System.Drawing.Point(24, 153)
        Me.lbCekStok.Name = "lbCekStok"
        Me.lbCekStok.Size = New System.Drawing.Size(42, 20)
        Me.lbCekStok.TabIndex = 2
        Me.lbCekStok.Text = "Stok"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(356, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tekan Enter / Spasi untuk keluar"
        '
        'lbCekBc
        '
        Me.lbCekBc.AutoSize = True
        Me.lbCekBc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCekBc.Location = New System.Drawing.Point(24, 32)
        Me.lbCekBc.Name = "lbCekBc"
        Me.lbCekBc.Size = New System.Drawing.Size(69, 20)
        Me.lbCekBc.TabIndex = 7
        Me.lbCekBc.Text = "Barcode"
        '
        'pbCekBC
        '
        Me.pbCekBC.Image = CType(resources.GetObject("pbCekBC.Image"), System.Drawing.Image)
        Me.pbCekBC.Location = New System.Drawing.Point(129, 196)
        Me.pbCekBC.Name = "pbCekBC"
        Me.pbCekBC.Size = New System.Drawing.Size(64, 64)
        Me.pbCekBC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbCekBC.TabIndex = 9
        Me.pbCekBC.TabStop = False
        '
        'lbCekBc2
        '
        Me.lbCekBc2.AutoSize = True
        Me.lbCekBc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCekBc2.Location = New System.Drawing.Point(125, 32)
        Me.lbCekBc2.Name = "lbCekBc2"
        Me.lbCekBc2.Size = New System.Drawing.Size(14, 20)
        Me.lbCekBc2.TabIndex = 10
        Me.lbCekBc2.Text = "-"
        '
        'lbCekNama2
        '
        Me.lbCekNama2.AutoSize = True
        Me.lbCekNama2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCekNama2.Location = New System.Drawing.Point(125, 72)
        Me.lbCekNama2.Name = "lbCekNama2"
        Me.lbCekNama2.Size = New System.Drawing.Size(15, 20)
        Me.lbCekNama2.TabIndex = 11
        Me.lbCekNama2.Text = "-"
        '
        'lbCekHarga2
        '
        Me.lbCekHarga2.AutoSize = True
        Me.lbCekHarga2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCekHarga2.Location = New System.Drawing.Point(125, 109)
        Me.lbCekHarga2.Name = "lbCekHarga2"
        Me.lbCekHarga2.Size = New System.Drawing.Size(14, 20)
        Me.lbCekHarga2.TabIndex = 12
        Me.lbCekHarga2.Text = "-"
        '
        'lbCekStok2
        '
        Me.lbCekStok2.AutoSize = True
        Me.lbCekStok2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCekStok2.Location = New System.Drawing.Point(125, 153)
        Me.lbCekStok2.Name = "lbCekStok2"
        Me.lbCekStok2.Size = New System.Drawing.Size(14, 20)
        Me.lbCekStok2.TabIndex = 13
        Me.lbCekStok2.Text = "-"
        '
        'frmCek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 334)
        Me.Controls.Add(Me.lbCekStok2)
        Me.Controls.Add(Me.lbCekHarga2)
        Me.Controls.Add(Me.lbCekNama2)
        Me.Controls.Add(Me.lbCekBc2)
        Me.Controls.Add(Me.pbCekBC)
        Me.Controls.Add(Me.lbCekBc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbCekStok)
        Me.Controls.Add(Me.lbCekHarga)
        Me.Controls.Add(Me.lbCekNama)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCek"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Info Barang"
        CType(Me.pbCekBC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbCekNama As Label
    Friend WithEvents lbCekHarga As Label
    Friend WithEvents lbCekStok As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbCekBc As Label
    Friend WithEvents pbCekBC As PictureBox
    Friend WithEvents lbCekBc2 As Label
    Friend WithEvents lbCekNama2 As Label
    Friend WithEvents lbCekHarga2 As Label
    Friend WithEvents lbCekStok2 As Label
End Class
