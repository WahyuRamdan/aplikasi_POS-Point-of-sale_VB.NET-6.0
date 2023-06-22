Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Function HitungTotalHarga() As Decimal
        Dim totalHarga As Decimal = 0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim harga As Decimal = Convert.ToDecimal(row.Cells("harga").Value)
                Dim kuantitas As Integer = Convert.ToInt32(row.Cells("kuantitas").Value)

                totalHarga += harga * kuantitas
            End If
        Next
        Return totalHarga


    End Function

    Private Sub ShowHadiah(totalHarga As Decimal)
        Dim hadiah As String = GetHadiah(totalHarga)
        MessageBox.Show(hadiah, "Hadiah")
    End Sub

    Private Function GetHadiah(totalHarga As Decimal) As String
        If totalHarga <= 0 Then
            Return "Error: Total harga pesanan tidak valid."
        ElseIf totalHarga < 150000 Then
            Return "Hadiah: Masker & Hand Sanitizer."
        ElseIf totalHarga < 250000 Then
            Return "Hadiah: Goodie Bag & Cutlery."
        ElseIf totalHarga < 350000 Then
            Return "Hadiah: Tumbler."
        ElseIf totalHarga < 450000 Then
            Return "Hadiah: Lunch Box."
        ElseIf totalHarga >= 450000 AndAlso totalHarga <= 1000000 Then
            Return "Hadiah: Member Card."
        Else
            Return "Tidak ada hadiah yang sesuai dengan total harga pesanan."
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAyamGeprek.KeyPress
        ' Memeriksa apakah karakter yang dimasukkan bukan angka
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAyamPenyet.KeyPress
        ' Memeriksa apakah karakter yang dimasukkan bukan angka
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxBebekGeprek.KeyPress
        ' Memeriksa apakah karakter yang dimasukkan bukan angka
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNasi.KeyPress
        ' Memeriksa apakah karakter yang dimasukkan bukan angka
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAir.KeyPress
        ' Memeriksa apakah karakter yang dimasukkan bukan angka
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAyamNasi.KeyPress
        ' Memeriksa apakah karakter yang dimasukkan bukan angka
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxEs.KeyPress
        ' Memeriksa apakah karakter yang dimasukkan bukan angka
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub ButtonAyamGeprek_Click(sender As Object, e As EventArgs) Handles ButtonAyamGeprek.Click

        ' Buat objek DataGridViewRow baru
        Dim row As New DataGridViewRow()

        ' Tambahkan nilai ke dalam sel-sel baru
        row.CreateCells(DataGridView1, "Ayam Geprek", "20000", TextBoxAyamGeprek.Text)

        ' Tambahkan baris ke DataGridView
        DataGridView1.Rows.Add(row)
        Dim total As Decimal = HitungTotalHarga()
        totalHarga.Text = total

    End Sub


    Private Sub ButtonAyamPenyet_Click(sender As Object, e As EventArgs) Handles ButtonAyamPenyet.Click
        ' Buat objek DataGridViewRow baru
        Dim row As New DataGridViewRow()

        ' Tambahkan nilai ke dalam sel-sel baru
        row.CreateCells(DataGridView1, "Ayam Penyet", "25000", TextBoxAyamPenyet.Text)

        ' Tambahkan baris ke DataGridView
        DataGridView1.Rows.Add(row)
        Dim total As Decimal = HitungTotalHarga()
        totalHarga.Text = total
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Buat objek DataGridViewRow baru
        Dim row As New DataGridViewRow()

        ' Tambahkan nilai ke dalam sel-sel baru
        row.CreateCells(DataGridView1, "Bebek Geprek", "30000", TextBoxBebekGeprek.Text)

        ' Tambahkan baris ke DataGridView
        DataGridView1.Rows.Add(row)
        Dim total As Decimal = HitungTotalHarga()
        totalHarga.Text = total
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Buat objek DataGridViewRow baru
        Dim row As New DataGridViewRow()

        ' Tambahkan nilai ke dalam sel-sel baru
        row.CreateCells(DataGridView1, "Nasi", "5000", TextBoxNasi.Text)

        ' Tambahkan baris ke DataGridView
        DataGridView1.Rows.Add(row)
        Dim total As Decimal = HitungTotalHarga()
        totalHarga.Text = total
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Buat objek DataGridViewRow baru
        Dim row As New DataGridViewRow()

        ' Tambahkan nilai ke dalam sel-sel baru
        row.CreateCells(DataGridView1, "Air putih", "4000", TextBoxAir.Text)

        ' Tambahkan baris ke DataGridView
        DataGridView1.Rows.Add(row)
        Dim total As Decimal = HitungTotalHarga()
        totalHarga.Text = total
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Buat objek DataGridViewRow baru
        Dim row As New DataGridViewRow()

        ' Tambahkan nilai ke dalam sel-sel baru
        row.CreateCells(DataGridView1, "Ayam + Nasi", "20000", TextBoxAyamNasi.Text)

        ' Tambahkan baris ke DataGridView
        DataGridView1.Rows.Add(row)
        Dim total As Decimal = HitungTotalHarga()
        totalHarga.Text = total
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Buat objek DataGridViewRow baru
        Dim row As New DataGridViewRow()

        ' Tambahkan nilai ke dalam sel-sel baru
        row.CreateCells(DataGridView1, "Es Teh", "7000", TextBoxEs.Text)

        ' Tambahkan baris ke DataGridView
        DataGridView1.Rows.Add(row)
        Dim total As Decimal = HitungTotalHarga()
        totalHarga.Text = total
    End Sub

    Private Sub hitung_Click(sender As Object, e As EventArgs) Handles hitung.Click
        Dim harga As Integer = CInt(totalHarga.Text)
        Dim tunai As Integer = CInt(jumlahTunai.Text)
        TextBox8.Text = tunai - harga
        ShowHadiah(harga)
    End Sub
End Class
