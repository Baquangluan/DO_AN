using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DO_AN.DAL;
using DO_AN.Model;
using DO_AN.MODEL;

namespace DO_AN.GUI
{
    public partial class KHACHHANG : Form
    {
        KhachBAL clBAL = new KhachBAL();
       
      
        public KHACHHANG()
        {
            InitializeComponent();
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            LoadDataFromDatabase();
        }
        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            // Load data from the database using clBAL and populate the DataGridView
            List<Khach> khachhangList = clBAL.ReadkhachHang(); // You need to implement this method
            foreach (Khach khachhang in khachhangList)
            {
                dgvKhachHang.Rows.Add(khachhang.MaKhach, khachhang.TenKhach, khachhang.DiaChi, khachhang.DienThoai);
            }
        }
        private void LoadDataFromDatabase()
        {
            List<Khach> khachhangList = clBAL.ReadkhachHang();
            foreach (Khach khachhang in khachhangList)
            {
                dgvKhachHang.Rows.Add(khachhang.MaKhach, khachhang.TenKhach, khachhang.DiaChi, khachhang.DienThoai);
            }
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKhachHang.Rows.Count) // Kiểm tra e.RowIndex hợp lệ
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                // Kiểm tra số cột và số ô được chọn có đúng không
                if (e.ColumnIndex >= 0 && e.ColumnIndex < row.Cells.Count)
                {
                    // Lấy giá trị từ cột MaChatLieu
                    string txtMaKhachValue = row.Cells[0].Value?.ToString(); // Sử dụng ?. để tránh lỗi nếu giá trị là null

                    // Lấy giá trị từ cột TenChatLieu
                    string txtTenKhachValue = row.Cells[1].Value?.ToString(); // Sử dụng ?. để tránh lỗi nếu giá trị là null

                    // Hiển thị giá trị lên TextBox
                    txtMaKhach.Text = txtMaKhachValue;
                    txtTenKhach.Text = txtTenKhachValue;
                }
            }
        }

   

        private void btnXoa_Click(object sender, EventArgs e)
        {

            Khach kh = new Khach();
            kh.MaKhach = txtMaKhach.Text;
            kh.TenKhach = txtTenKhach.Text;

            kh.DiaChi = txtDiaChi.Text;
            kh.DienThoai = mtbDienThoai.Text;

            // Xử lý ngày sinh: chuyển đổi từ kiểu chuỗi sang kiểu DateTime
         

            // Gọi phương thức DeleteNhanVien để xóa Nhân viên khỏi cơ sở dữ liệu
            clBAL.DeletekhachHang(kh);

            // Thông báo thành công và xóa dòng khỏi DataGridView
            MessageBox.Show("Xóa thành công!");
            int idx = dgvKhachHang.CurrentCell.RowIndex;
            dgvKhachHang.Rows.RemoveAt(idx);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Khach kh = new Khach();
            kh.MaKhach = txtMaKhach.Text;
            kh.TenKhach = txtTenKhach.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.DienThoai = mtbDienThoai.Text;

            // Xử lý ngày sinh: chuyển đổi từ kiểu chuỗi sang kiểu DateTime

            {

                // Chỉ gọi hàm EditNhanVien nếu ngày sinh hợp lệ
                clBAL.EditkhachHang(kh);

                MessageBox.Show("Chỉnh sửa thành công!");

                // Cập nhật dòng hiện tại trong DataGridView
                DataGridViewRow row = dgvKhachHang.CurrentRow;
                row.Cells[0].Value = kh.MaKhach;
                row.Cells[1].Value = kh.TenKhach;
                row.Cells[3].Value = kh.DiaChi;
                row.Cells[4].Value = kh.DienThoai;
            }
           
        }

      


        private void txtMaKhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhach.Text))
            {
                MessageBox.Show("Không được để trống mã.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtMaKhach.Text, out int id))
            {
                MessageBox.Show("Không được nhập kí tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mã trùng lặp
            string newMaKhachHang = txtMaKhach.Text;
            foreach (DataGridViewRow row in dgvKhachHang.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == newMaKhachHang)
                {
                    MessageBox.Show("Mã Khách hàng đã tồn tại. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Khach cus = new Khach();
            cus.MaKhach = txtMaKhach.Text;
            cus.TenKhach = txtTenKhach.Text;

            // Thêm trường địa chỉ và số liên lạc
            cus.DiaChi = txtDiaChi.Text;
            cus.DienThoai = mtbDienThoai.Text;

            clBAL.NewkhachHang(cus);

            dgvKhachHang.Rows.Add(cus.MaKhach, cus.TenKhach, cus.DiaChi, cus.DienThoai);
        }
    }
        
}

