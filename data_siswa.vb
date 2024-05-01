Imports System.Data.SqlClient

Public Class data_siswa

    Dim cnn As New SqlConnection("Data Source=BROTHERZHAFIF\SQLEXPRESS;Initial Catalog=lks_test;Integrated Security=True")



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub data_siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Lks_testDataSet.Verifikated_child' table. You can move, or remove it, as needed.
        Me.Verifikated_childTableAdapter.Fill(Me.Lks_testDataSet.Verifikated_child)
    End Sub

    Private Sub Btn_search_NISN_Click(sender As Object, e As EventArgs) Handles Btn_search_NISN.Click

        Dim cmd As New SqlCommand("SELECT * FROM Daftar WHERE No_daftar='" & inputTxt_No_daftar.Text & "'", cnn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        da.Fill(dt)

        inputTxt_NISN.Text = dt.Rows(0)(1).ToString()
        Date_tgl_daftar.Value = dt.Rows(0)(2).ToString()
        inputTxt_Asal_sekolah.Text = dt.Rows(0)(3).ToString()
        inputTxt_Priority1.Text = dt.Rows(0)(5).ToString()
        inputTxt_Priority2.Text = dt.Rows(0)(6).ToString()

        Dim img As Byte()
        img = dt.Rows(0)(7)

        Dim cmd_ As New SqlCommand("SELECT * FROM Calon_siswa WHERE NISN='" & inputTxt_NISN.Text & "'", cnn)


        Dim da_ As New SqlDataAdapter(cmd_)
        Dim dtt As New DataTable()
        da_.Fill(dtt)

        inputTxt_Nama_siswa.Text = dtt.Rows(0)(1).ToString()
        inputTxt_Tempat_lahir.Text = dtt.Rows(0)(2).ToString()
        input_Tanggal_lahir.Value = dtt.Rows(0)(3).ToString()

        If dtt.Rows(0)(4) = "Perempuan      " Then
            Radio_btn_Perempuan.Checked = True
        Else
            Radio_btn_laki.Checked = True
        End If

        inputRichTxt_Alamat.Text = dtt.Rows(0)(5).ToString

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click

        inputTxt_NISN.Clear()
        Date_tgl_daftar.Value = Date.Now
        inputTxt_Asal_sekolah.Clear()
        inputTxt_Priority1.Clear()
        inputTxt_Priority2.Clear()
        inputTxt_Nama_siswa.Clear()
        inputTxt_Tempat_lahir.Clear()
        input_Tanggal_lahir.Value = Date.Now
        Radio_btn_Perempuan.Checked = False
        Radio_btn_laki.Checked = False
        inputRichTxt_Alamat.Clear()
    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        Me.Hide()
        Admin_Nav.Show()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selected_row As DataGridViewRow
        selected_row = DataGridView1.Rows(index)
        inputTxt_No_daftar.Text = selected_row.Cells(1).Value.ToString()
    End Sub
End Class