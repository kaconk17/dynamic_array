Public Class Form1
    Dim data_array() As String  'Dynamic array

    Dim counter As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReDim data_array(counter)   'deklarasi dynamic array
        TextBox_data.Focus()

    End Sub



    Private Sub btn_search_req_Click(sender As Object, e As EventArgs) Handles btn_search_req.Click
        Dim cari As String = TextBox_data.Text 'ambil data text yang dicari
        Dim n_cari = Len(cari) 'menghitung jumlah karakter yang dicari
        Dim max As Integer = UBound(data_array, 1) 'menghitung jumlah total index pada array data_array
        ListBox1.Items.Clear()
        For i As Integer = 0 To max
            Dim n_data = Len(data_array(i)) 'menghitung jumlah karakter pada data_array index ke i

            For j As Integer = 1 To n_data
                If UCase(cari) = UCase(Mid(data_array(i), j, n_cari)) Then 'membandingkan data yang dicari dengan data pada array dalam format uppercase

                    ListBox1.Items.Add(data_array(i)) 'menambahkan data yang sama dengan pencarian pada listbox
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub txt_nama_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            btn_simpan.Focus()
        End If
    End Sub



    Private Sub btn_refresh_po_Click(sender As Object, e As EventArgs) Handles btn_refresh_po.Click
        Dim max As Integer = UBound(data_array, 1)
        ListBox1.Items.Clear()
        For a As Integer = 0 To max Step 1

            ListBox1.Items.Add(data_array(a).ToString) 'menambahkan semua data dalam data_array kedalam listbox

        Next
        TextBox_data.Text = ""
    End Sub



    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If counter = 0 Then

            data_array(counter) = txt_nama.Text.ToString 'menyimpan data dari textbox nama kedalam data_array index ke 0
            ListBox1.Items.Add(data_array(counter)) 'menampilkan data_array index ke 0 kedalam listbox
            counter = counter + 1
            txt_nama.Text = ""
        Else
            ReDim Preserve data_array(UBound(data_array) + 1) 'deklarasi ulang data_array dengan menambahkan 1 index lagi
            data_array(counter) = txt_nama.Text ' menyimpan data dari textbox nama kedalam data_array index yang telah ditambahkan
            ListBox1.Items.Add(data_array(counter)) ' memasukkan data_array kedalam listbox
            counter = counter + 1
            txt_nama.Text = ""
        End If
    End Sub

    Private Sub TextBox_data_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_data.KeyPress
        If e.KeyChar = Chr(13) Then
            btn_search_req.Focus()
        End If

    End Sub
End Class
