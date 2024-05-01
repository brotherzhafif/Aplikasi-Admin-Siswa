<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Verifikasi_siswa
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inputTxt_No_daftar = New System.Windows.Forms.TextBox()
        Me.Btn_search_NISN = New System.Windows.Forms.Button()
        Me.Date_tgl_daftar = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inputTxt_Asal_sekolah = New System.Windows.Forms.TextBox()
        Me.inputRichTxt_Alamat = New System.Windows.Forms.RichTextBox()
        Me.Radio_btn_Perempuan = New System.Windows.Forms.RadioButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.Radio_btn_laki = New System.Windows.Forms.RadioButton()
        Me.input_Tanggal_lahir = New System.Windows.Forms.DateTimePicker()
        Me.inputTxt_Tempat_lahir = New System.Windows.Forms.TextBox()
        Me.inputTxt_Nama_siswa = New System.Windows.Forms.TextBox()
        Me.inputTxt_NISN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.inputTxt_Priority1 = New System.Windows.Forms.TextBox()
        Me.inputTxt_Priority2 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_verifikasi = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.btn_clear)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.inputTxt_No_daftar)
        Me.Panel1.Controls.Add(Me.Btn_search_NISN)
        Me.Panel1.Location = New System.Drawing.Point(3, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(733, 52)
        Me.Panel1.TabIndex = 8
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(610, 12)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(113, 26)
        Me.btn_clear.TabIndex = 25
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "No_Pendaftaran"
        '
        'inputTxt_No_daftar
        '
        Me.inputTxt_No_daftar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTxt_No_daftar.Location = New System.Drawing.Point(122, 12)
        Me.inputTxt_No_daftar.Name = "inputTxt_No_daftar"
        Me.inputTxt_No_daftar.Size = New System.Drawing.Size(151, 26)
        Me.inputTxt_No_daftar.TabIndex = 24
        '
        'Btn_search_NISN
        '
        Me.Btn_search_NISN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_search_NISN.Location = New System.Drawing.Point(279, 12)
        Me.Btn_search_NISN.Name = "Btn_search_NISN"
        Me.Btn_search_NISN.Size = New System.Drawing.Size(113, 26)
        Me.Btn_search_NISN.TabIndex = 24
        Me.Btn_search_NISN.Text = "Cari"
        Me.Btn_search_NISN.UseVisualStyleBackColor = True
        '
        'Date_tgl_daftar
        '
        Me.Date_tgl_daftar.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_tgl_daftar.Enabled = False
        Me.Date_tgl_daftar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_tgl_daftar.Location = New System.Drawing.Point(305, 310)
        Me.Date_tgl_daftar.Name = "Date_tgl_daftar"
        Me.Date_tgl_daftar.Size = New System.Drawing.Size(418, 26)
        Me.Date_tgl_daftar.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(41, 349)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 19)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Asal sekolah"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(41, 317)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 19)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Tanggal daftar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Jenis Kelamin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nama Siswa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "NISN"
        '
        'inputTxt_Asal_sekolah
        '
        Me.inputTxt_Asal_sekolah.Enabled = False
        Me.inputTxt_Asal_sekolah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTxt_Asal_sekolah.Location = New System.Drawing.Point(306, 342)
        Me.inputTxt_Asal_sekolah.Name = "inputTxt_Asal_sekolah"
        Me.inputTxt_Asal_sekolah.ReadOnly = True
        Me.inputTxt_Asal_sekolah.Size = New System.Drawing.Size(418, 26)
        Me.inputTxt_Asal_sekolah.TabIndex = 12
        '
        'inputRichTxt_Alamat
        '
        Me.inputRichTxt_Alamat.Enabled = False
        Me.inputRichTxt_Alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputRichTxt_Alamat.Location = New System.Drawing.Point(305, 178)
        Me.inputRichTxt_Alamat.Name = "inputRichTxt_Alamat"
        Me.inputRichTxt_Alamat.Size = New System.Drawing.Size(418, 126)
        Me.inputRichTxt_Alamat.TabIndex = 10
        Me.inputRichTxt_Alamat.Text = ""
        '
        'Radio_btn_Perempuan
        '
        Me.Radio_btn_Perempuan.AutoSize = True
        Me.Radio_btn_Perempuan.Enabled = False
        Me.Radio_btn_Perempuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_btn_Perempuan.Location = New System.Drawing.Point(495, 148)
        Me.Radio_btn_Perempuan.Name = "Radio_btn_Perempuan"
        Me.Radio_btn_Perempuan.Size = New System.Drawing.Size(109, 24)
        Me.Radio_btn_Perempuan.TabIndex = 8
        Me.Radio_btn_Perempuan.TabStop = True
        Me.Radio_btn_Perempuan.Text = "Perempuan"
        Me.Radio_btn_Perempuan.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel6.Controls.Add(Me.btn_kembali)
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(733, 59)
        Me.Panel6.TabIndex = 13
        '
        'btn_kembali
        '
        Me.btn_kembali.Location = New System.Drawing.Point(3, 3)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(124, 53)
        Me.btn_kembali.TabIndex = 0
        Me.btn_kembali.Text = "Kembali"
        Me.btn_kembali.UseVisualStyleBackColor = True
        '
        'Radio_btn_laki
        '
        Me.Radio_btn_laki.AutoSize = True
        Me.Radio_btn_laki.Enabled = False
        Me.Radio_btn_laki.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_btn_laki.Location = New System.Drawing.Point(306, 148)
        Me.Radio_btn_laki.Name = "Radio_btn_laki"
        Me.Radio_btn_laki.Size = New System.Drawing.Size(90, 24)
        Me.Radio_btn_laki.TabIndex = 7
        Me.Radio_btn_laki.TabStop = True
        Me.Radio_btn_laki.Text = "Laki-Laki"
        Me.Radio_btn_laki.UseVisualStyleBackColor = True
        '
        'input_Tanggal_lahir
        '
        Me.input_Tanggal_lahir.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_Tanggal_lahir.Enabled = False
        Me.input_Tanggal_lahir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_Tanggal_lahir.Location = New System.Drawing.Point(305, 116)
        Me.input_Tanggal_lahir.Name = "input_Tanggal_lahir"
        Me.input_Tanggal_lahir.Size = New System.Drawing.Size(418, 26)
        Me.input_Tanggal_lahir.TabIndex = 6
        '
        'inputTxt_Tempat_lahir
        '
        Me.inputTxt_Tempat_lahir.Enabled = False
        Me.inputTxt_Tempat_lahir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTxt_Tempat_lahir.Location = New System.Drawing.Point(305, 84)
        Me.inputTxt_Tempat_lahir.Name = "inputTxt_Tempat_lahir"
        Me.inputTxt_Tempat_lahir.Size = New System.Drawing.Size(418, 26)
        Me.inputTxt_Tempat_lahir.TabIndex = 4
        '
        'inputTxt_Nama_siswa
        '
        Me.inputTxt_Nama_siswa.Enabled = False
        Me.inputTxt_Nama_siswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTxt_Nama_siswa.Location = New System.Drawing.Point(306, 52)
        Me.inputTxt_Nama_siswa.Name = "inputTxt_Nama_siswa"
        Me.inputTxt_Nama_siswa.Size = New System.Drawing.Size(418, 26)
        Me.inputTxt_Nama_siswa.TabIndex = 3
        '
        'inputTxt_NISN
        '
        Me.inputTxt_NISN.Enabled = False
        Me.inputTxt_NISN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTxt_NISN.Location = New System.Drawing.Point(305, 20)
        Me.inputTxt_NISN.Name = "inputTxt_NISN"
        Me.inputTxt_NISN.Size = New System.Drawing.Size(418, 26)
        Me.inputTxt_NISN.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data Siswa :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Date_tgl_daftar)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.inputTxt_Asal_sekolah)
        Me.Panel2.Controls.Add(Me.inputRichTxt_Alamat)
        Me.Panel2.Controls.Add(Me.Radio_btn_Perempuan)
        Me.Panel2.Controls.Add(Me.Radio_btn_laki)
        Me.Panel2.Controls.Add(Me.input_Tanggal_lahir)
        Me.Panel2.Controls.Add(Me.inputTxt_Tempat_lahir)
        Me.Panel2.Controls.Add(Me.inputTxt_Nama_siswa)
        Me.Panel2.Controls.Add(Me.inputTxt_NISN)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(3, 122)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(733, 376)
        Me.Panel2.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(41, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 19)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Prioritas 2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(41, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 19)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Prioritas 1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 19)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Data Orang Tua / Wali :"
        '
        'inputTxt_Priority1
        '
        Me.inputTxt_Priority1.Enabled = False
        Me.inputTxt_Priority1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTxt_Priority1.Location = New System.Drawing.Point(306, 37)
        Me.inputTxt_Priority1.Name = "inputTxt_Priority1"
        Me.inputTxt_Priority1.ReadOnly = True
        Me.inputTxt_Priority1.Size = New System.Drawing.Size(418, 26)
        Me.inputTxt_Priority1.TabIndex = 15
        '
        'inputTxt_Priority2
        '
        Me.inputTxt_Priority2.Enabled = False
        Me.inputTxt_Priority2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTxt_Priority2.Location = New System.Drawing.Point(306, 69)
        Me.inputTxt_Priority2.Name = "inputTxt_Priority2"
        Me.inputTxt_Priority2.ReadOnly = True
        Me.inputTxt_Priority2.Size = New System.Drawing.Size(418, 26)
        Me.inputTxt_Priority2.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.btn_verifikasi)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.inputTxt_Priority1)
        Me.Panel3.Controls.Add(Me.inputTxt_Priority2)
        Me.Panel3.Location = New System.Drawing.Point(3, 504)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(733, 180)
        Me.Panel3.TabIndex = 10
        '
        'btn_verifikasi
        '
        Me.btn_verifikasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_verifikasi.Location = New System.Drawing.Point(600, 119)
        Me.btn_verifikasi.Name = "btn_verifikasi"
        Me.btn_verifikasi.Size = New System.Drawing.Size(124, 53)
        Me.btn_verifikasi.TabIndex = 1
        Me.btn_verifikasi.Text = "Verifikasi"
        Me.btn_verifikasi.UseVisualStyleBackColor = True
        '
        'Verifikasi_siswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 688)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Verifikasi_siswa"
        Me.Text = "Verifikasi_siswa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents inputTxt_No_daftar As TextBox
    Friend WithEvents Btn_search_NISN As Button
    Friend WithEvents Date_tgl_daftar As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents inputTxt_Asal_sekolah As TextBox
    Friend WithEvents inputRichTxt_Alamat As RichTextBox
    Friend WithEvents Radio_btn_Perempuan As RadioButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btn_kembali As Button
    Friend WithEvents Radio_btn_laki As RadioButton
    Friend WithEvents input_Tanggal_lahir As DateTimePicker
    Friend WithEvents inputTxt_Tempat_lahir As TextBox
    Friend WithEvents inputTxt_Nama_siswa As TextBox
    Friend WithEvents inputTxt_NISN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents inputTxt_Priority1 As TextBox
    Friend WithEvents inputTxt_Priority2 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_verifikasi As Button
End Class
