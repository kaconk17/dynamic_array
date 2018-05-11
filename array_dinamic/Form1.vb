Public Class Form1
    Dim data_array() As String
    ' Dim jum_index As Integer = 0
    Dim counter As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nama.Focus()
        ReDim data_array(counter)

    End Sub



    Private Sub btn_search_req_Click(sender As Object, e As EventArgs) Handles btn_search_req.Click
        Dim cari As String = txt_cari.Text
        Dim n_cari = Len(cari)
        Dim max As Integer = UBound(data_array, 1)
        ListBox1.Items.Clear()
        For i As Integer = 0 To max
            Dim n_data = Len(data_array(i))

            For j As Integer = 1 To n_data
                If UCase(cari) = UCase(Mid(data_array(i), j, n_cari)) Then

                    ListBox1.Items.Add(data_array(i))
                    'Exit For
                End If
            Next
        Next
    End Sub

    Private Sub txt_nama_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            btn_simpan.Focus()
        End If
    End Sub

    Private Sub txt_cari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cari.KeyPress
        If e.KeyChar = Chr(13) Then
            btn_search_req.Focus()
        End If
    End Sub

    Private Sub btn_refresh_po_Click(sender As Object, e As EventArgs) Handles btn_refresh_po.Click
        Dim max As Integer = UBound(data_array, 1)
        ListBox1.Items.Clear()
        For a As Integer = 0 To max Step 1

            ListBox1.Items.Add(data_array(a).ToString)

        Next
    End Sub



    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If counter = 0 Then

            data_array(counter) = txt_nama.Text.ToString
            ListBox1.Items.Add(data_array(counter))
            counter = counter + 1
            txt_nama.Text = ""
        Else
            ReDim Preserve data_array(UBound(data_array) + 1)
            data_array(counter) = txt_nama.Text
            ListBox1.Items.Add(data_array(counter))
            counter = counter + 1
            txt_nama.Text = ""
        End If
    End Sub
End Class
