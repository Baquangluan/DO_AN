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
using DO_AN.BAL;
using DO_AN.DAL;
using DO_AN.Model;
using DO_AN.MODEL;

using System.IO;


namespace DO_AN.GUI
{
    public partial class NHANVIEN : Form
    {
        NhanVienBAL clBAL = new NhanVienBAL();
        private List<NhanVien> nhanvienList; // Lưu trữ danh sách nhân viên

        public NHANVIEN()
        {
            InitializeComponent();
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            LoadDataFromDatabase();
        }

        private void NHANVIEN_Load(object sender, EventArgs e)
        {
  
            // Hiển thị dữ liệu từ biến lưu trữ
            foreach (NhanVien nhanvien in nhanvienList)
            {
                dgvNhanVien.Rows.Add(nhanvien.MaNhanVien, nhanvien.TenNhanVien, nhanvien.DiaChi, nhanvien.SoLienLac, nhanvien.NgaySinh.ToString("dd/MM/yyyy"));
            }
        }

        private void LoadDataFromDatabase()
        {
            // Lấy dữ liệu từ cơ sở dữ liệu và lưu vào biến
            nhanvienList = clBAL.ReadNhanVien();

            // Hiển thị dữ liệu lên DataGridView
            foreach (NhanVien nhanvien in nhanvienList)
            {
                dgvNhanVien.Rows.Add(nhanvien.MaNhanVien, nhanvien.TenNhanVien, nhanvien.DiaChi, nhanvien.SoLienLac, nhanvien.NgaySinh.ToString("dd/MM/yyyy"));
            }
        }



        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                DataGridViewCell clickedCell = dgvNhanVien.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Tô chọn hết nội dung trong ô
                dgvNhanVien.CurrentCell = clickedCell;

                // Kích hoạt chế độ chỉnh sửa
                dgvNhanVien.BeginEdit(true);

                // Kiểm tra xem ô có phải là ô văn bản không
                if (dgvNhanVien.EditingControl is DataGridViewTextBoxEditingControl textBoxEditingControl)
                {
                    // Tô chọn toàn bộ nội dung trong ô
                    textBoxEditingControl.SelectAll();
                }

                // Lấy giá trị từ cột MaNhanVien (Cell 0)
                object cellValueMaNhanVien = row.Cells[0].Value;
                string MaNhanVien = cellValueMaNhanVien != null ? cellValueMaNhanVien.ToString() : "";

                // Lấy giá trị từ cột TenNhanVien (Cell 1)
                object cellValueTenNhanVien = row.Cells[1].Value;
                string TenNhanVien = cellValueTenNhanVien != null ? cellValueTenNhanVien.ToString() : "";

                // Lấy giá trị từ cột GioiTinh (Cell 2)
               

                // Lấy giá trị từ cột DiaChi (Cell 3)
                object cellValueDiaChi = row.Cells[2].Value;
                string DiaChi = cellValueDiaChi != null ? cellValueDiaChi.ToString() : "";

                // Lấy giá trị từ cột DienThoai (Cell 4)
                object cellValueDienThoai = row.Cells[3].Value;
                string DienThoai = cellValueDienThoai != null ? cellValueDienThoai.ToString() : "";

                // Lấy giá trị từ cột NgaySinh (Cell 5)
                object cellValueNgaySinh = row.Cells[4].Value;
                DateTime NgaySinh;
                if (cellValueNgaySinh != null && DateTime.TryParse(cellValueNgaySinh.ToString(), out NgaySinh))
                {
                    // Ngày sinh hợp lệ, gán giá trị
                }
                else
                {
                    // Nếu ngày sinh không hợp lệ, bạn có thể gán giá trị mặc định hoặc xử lý sai sót khác
                    NgaySinh = DateTime.MinValue;
                }

                // Hiển thị giá trị lên TextBox
                txtMaNhanVien.Text = MaNhanVien;
                txtTenNhanVien.Text = TenNhanVien;
                
                txtDiaChi.Text = DiaChi;
                mtbDienThoai.Text = DienThoai;
                mskNgaySinh.Text = NgaySinh.ToString("dd/MM/yyyy"); // Hiển thị theo định dạng dd/MM/yyyy
            }
            else
            {
                // Nếu người dùng click vào khoảng trống cuối cùng của hàng,
                // bạn có thể làm gì đó ở đây (ví dụ: xóa giá trị của TextBox)
                txtMaNhanVien.Text = "";
                txtTenNhanVien.Text = "";
               
                txtDiaChi.Text = "";
                mtbDienThoai.Text = "";
                mskNgaySinh.Text = "";
            }

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = txtMaNhanVien.Text;
            nv.TenNhanVien = txtTenNhanVien.Text;      
            nv.DiaChi = txtDiaChi.Text;
            nv.SoLienLac = mtbDienThoai.Text;

            // Xử lý ngày sinh: chuyển đổi từ kiểu chuỗi sang kiểu DateTime
            DateTime ngaySinh;
            if (DateTime.TryParseExact(mskNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
            {
                nv.NgaySinh = ngaySinh;
            }
            else
            {
                // Nếu ngày sinh không hợp lệ, bạn có thể xử lý sai sót khác hoặc đưa ra thông báo lỗi
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return; // Không xóa Nhân viên nếu ngày sinh không hợp lệ
            }

            // Gọi phương thức DeleteNhanVien để xóa Nhân viên khỏi cơ sở dữ liệu
            clBAL.DeleteNhanVien(nv);

            // Thông báo thành công và xóa dòng khỏi DataGridView
            MessageBox.Show("Xóa thành công!");
            int idx = dgvNhanVien.CurrentCell.RowIndex;
            dgvNhanVien.Rows.RemoveAt(idx);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = txtMaNhanVien.Text;
            nv.TenNhanVien = txtTenNhanVien.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.SoLienLac = mtbDienThoai.Text;

            // Xử lý ngày sinh: chuyển đổi từ kiểu chuỗi sang kiểu DateTime
            DateTime ngaySinh;
            if (DateTime.TryParseExact(mskNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
            {
                nv.NgaySinh = ngaySinh;
            }
            else
            {
                // Nếu ngày sinh không hợp lệ, bạn có thể xử lý sai sót khác hoặc đưa ra thông báo lỗi
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return; // Không chỉnh sửa Nhân viên nếu ngày sinh không hợp lệ
            }

            // Gọi phương thức EditNhanVien để chỉnh sửa thông tin Nhân viên
            clBAL.EditNhanVien(nv);

            // Thông báo chỉnh sửa thành công và cập nhật DataGridView với thông tin mới
            MessageBox.Show("Chỉnh sửa thành công!");

            DataGridViewRow row = dgvNhanVien.CurrentRow;
            row.Cells[0].Value = nv.MaNhanVien;
            row.Cells[1].Value = nv.TenNhanVien;
            row.Cells[2].Value = nv.DiaChi;
            row.Cells[3].Value = nv.SoLienLac;
            row.Cells[4].Value = nv.NgaySinh.ToString("dd/MM/yyyy");
        }


        private void chkGioiTinh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
                // You can add your save functionality here.
                // For now, I'll just show a message box.
                MessageBox.Show("Data has been saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string newMaNhanVien = txtMaNhanVien.Text;
            txtMaNhanVien.Text = newMaNhanVien;
            string maNv = txtMaNhanVien.Text;

            // Kiểm tra xem mã hàng đã tồn tại hay chưa
            bool isNhanVienExist = false;
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maNv)
                {
                    isNhanVienExist = true;
                    break;
                }
            }

            if (isNhanVienExist)
            {
                MessageBox.Show("Mã hàng đã tồn tại. Vui lòng chọn mã hàng khác.");
                return;
            }
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = txtMaNhanVien.Text;
            nv.TenNhanVien = txtTenNhanVien.Text;
           
            nv.DiaChi = txtDiaChi.Text;
            nv.SoLienLac = mtbDienThoai.Text;


            DateTime ngaySinh;
            if (DateTime.TryParseExact(mskNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
            {
                nv.NgaySinh = ngaySinh;
            }
            else
            {
                // Nếu ngày sinh không hợp lệ, bạn có thể xử lý sai sót khác hoặc đưa ra thông báo lỗi
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return; // Không thêm Nhân viên nếu ngày sinh không hợp lệ
            }

            // Gọi phương thức NewNhanVien để thêm Nhân viên vào cơ sở dữ liệu
            clBAL.NewNhanVien(nv);

            // Thông báo thành công và thêm dòng mới vào DataGridView
            MessageBox.Show("Thêm thành công!");
            dgvNhanVien.Rows.Add(nv.MaNhanVien, nv.TenNhanVien, nv.DiaChi, nv.SoLienLac, nv.NgaySinh.ToString("dd/MM/yyyy"));
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NHANVIEN_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}

