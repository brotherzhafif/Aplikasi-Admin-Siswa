Imports System.Data.SqlClient

Public Class Login

    Dim cnn As New SqlConnection("Data Source=BROTHERZHAFIF\SQLEXPRESS;Initial Catalog=lks_test;Integrated Security=True")

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        Dim cmd As New SqlCommand("SELECT * FROM Verifikator WHERE Username='" & inputTxt_username.Text & "' AND Password='" & inputTxt_password.Text & "'", cnn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            MessageBox.Show("Login Berhasil")
            Me.Hide()
            Admin_Nav.Show()
        Else
            MessageBox.Show("Login Gagal")
        End If
    End Sub
End Class