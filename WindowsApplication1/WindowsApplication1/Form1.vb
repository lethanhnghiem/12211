Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class Form1
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=.;Initial Catalog=demo2;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMasp.Text = DataGridView1.Item(0, click).Value
        txtTenSp.Text = DataGridView1.Item(1, click).Value
        txtSoluong.Text = DataGridView1.Item(2, click).Value
        txtDonGia.Text = DataGridView1.Item(3, click).Value
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Reset()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        If btnsua.Text = "sua" Then
            txtMasp.ReadOnly = True
            btnsua.Text = "Update"
            txtTenSp.Focus()
        ElseIf btnsua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update SANPHAM1 set TenSP=@TENSP, Soluong=@SOLUONG, Dongia=@DONGIA where MaSP=@MASP"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASP", txtMasp.Text)
            save.Parameters.AddWithValue("@TENSP", txtTenSp.Text)
            save.Parameters.AddWithValue("@SOLUONG", txtSoluong.Text)
            save.Parameters.AddWithValue("@DONGIA", txtDonGia.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMasp.ReadOnly = False
            btnsua.Text = "sua"
            LoadData()
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMasp.Text = "" Then
            MessageBox.Show("Nhap MaSP cần xóa")
            txtMasp.Focus()
        Else
            Dim delquery As String = "delete from SANPHAM1 where MaSP=@MASP"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MASP", txtMasp.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMasp.Text = "" Then
            MessageBox.Show("Chua nhap mã sản phẩm")
            txtMasp.Focus()
        ElseIf txtTenSp.Text = "" Then
            MessageBox.Show("Chua nhap Tên sản phẩm")
            txtTenSp.Focus()
        ElseIf txtSoluong.Text = "" Then
            MessageBox.Show("Chua nhap Số lượng")
            txtSoluong.Focus()
        ElseIf txtDonGia.Text = "" Then
            MessageBox.Show("Chua nhap đơn giá")
            txtDonGia.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into SANPHAM1 values(@MASP,@TENSP,@SOLUONG,@DONGIA)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASP", txtMasp.Text)
            save.Parameters.AddWithValue("@TENSP", txtTenSp.Text)
            save.Parameters.AddWithValue("@SOLUONG", txtSoluong.Text)
            save.Parameters.AddWithValue("@DONGIA", txtDonGia.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub
    'load ne
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã SP' ,TenSP as 'Tên Sản phẩm', Soluong as 'Số lượng', Dongia as 'Đơn giá', Soluong * Dongia as 'Thành tiền' from SANPHAM1", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    ' reset cua btnthem ne
    Private Sub reset()
        txtDongia.Text = ""
        txtMaSP.Text = ""
        txtSoluong.Text = ""
        txtTenSP.Text = ""
        txtMaSP.Focus()
    End Sub
End Class
