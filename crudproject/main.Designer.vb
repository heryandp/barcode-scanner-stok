<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btndb = New System.Windows.Forms.Button()
        Me.btncek = New System.Windows.Forms.Button()
        Me.tbcek = New System.Windows.Forms.TextBox()
        Me.cbdevices = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picbc = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lbWaktu = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.picbc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btndb
        '
        Me.btndb.Location = New System.Drawing.Point(250, 13)
        Me.btndb.Name = "btndb"
        Me.btndb.Size = New System.Drawing.Size(110, 23)
        Me.btndb.TabIndex = 0
        Me.btndb.Text = "Database Barang"
        Me.btndb.UseVisualStyleBackColor = True
        '
        'btncek
        '
        Me.btncek.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncek.Location = New System.Drawing.Point(122, 113)
        Me.btncek.Name = "btncek"
        Me.btncek.Size = New System.Drawing.Size(133, 35)
        Me.btncek.TabIndex = 1
        Me.btncek.Text = "Cek Barang"
        Me.btncek.UseVisualStyleBackColor = True
        '
        'tbcek
        '
        Me.tbcek.AcceptsTab = True
        Me.tbcek.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcek.Location = New System.Drawing.Point(22, 79)
        Me.tbcek.Name = "tbcek"
        Me.tbcek.Size = New System.Drawing.Size(333, 30)
        Me.tbcek.TabIndex = 2
        Me.tbcek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbdevices
        '
        Me.cbdevices.FormattingEnabled = True
        Me.cbdevices.Location = New System.Drawing.Point(175, 324)
        Me.cbdevices.Name = "cbdevices"
        Me.cbdevices.Size = New System.Drawing.Size(176, 21)
        Me.cbdevices.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Camera / Capture"
        '
        'picbc
        '
        Me.picbc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picbc.Image = CType(resources.GetObject("picbc.Image"), System.Drawing.Image)
        Me.picbc.Location = New System.Drawing.Point(18, 167)
        Me.picbc.Name = "picbc"
        Me.picbc.Size = New System.Drawing.Size(333, 133)
        Me.picbc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picbc.TabIndex = 6
        Me.picbc.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Masukkan Kode Barang / Scan Barcode"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'lbWaktu
        '
        Me.lbWaktu.AutoSize = True
        Me.lbWaktu.Location = New System.Drawing.Point(22, 18)
        Me.lbWaktu.Name = "lbWaktu"
        Me.lbWaktu.Size = New System.Drawing.Size(39, 13)
        Me.lbWaktu.TabIndex = 9
        Me.lbWaktu.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(140, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "(Apabila tidak terbaca, mohon lebih dekat)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "HERYAN DP - 2022"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 380)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbWaktu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picbc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbdevices)
        Me.Controls.Add(Me.tbcek)
        Me.Controls.Add(Me.btncek)
        Me.Controls.Add(Me.btndb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kelontong Mas Her"
        CType(Me.picbc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btndb As Button
    Friend WithEvents btncek As Button
    Friend WithEvents tbcek As TextBox
    Friend WithEvents cbdevices As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents picbc As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lbWaktu As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
