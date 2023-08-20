using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DO_AN.DAL;
using DO_AN.Model;
using DO_AN.MODEL;




namespace DO_AN.GUI
{
    
    public partial class NGUYENLIEU : Form
    {
        NguyenLieuDAL hangBLL = new NguyenLieuDAL();

        public NGUYENLIEU()
        {
            InitializeComponent();
            dgvNguyenLieu.CellClick += dgvNguyenLieu_CellClick;
            dgvNguyenLieu.SelectionChanged += dgvHangHoa_SelectionChanged;
            LoadDataFromDatabase();



        }
        private void NGUYENLIEU_Load(object sender, EventArgs e)
        {
            // Load data from the database using clBAL and populate the DataGridView
            List<NguyenLieu> nguyenlieuList = hangBLL.ReadHang(); // You need to implement this method
            foreach (NguyenLieu nguyenlieu in nguyenlieuList)
            {
                dgvNguyenLieu.Rows.Add(nguyenlieu.MaHang, nguyenlieu.TenHang, nguyenlieu.MaChatLieu, nguyenlieu.SoLuong, nguyenlieu.DonGiaNhap, nguyenlieu.DonGiaBan, nguyenlieu.Anh, nguyenlieu.GhiChu);
            }
        }
        private void LoadDataFromDatabase()
        {
            List<NguyenLieu> nguyenlieuList = hangBLL.ReadHang();
            foreach (NguyenLieu nguyenlieu in nguyenlieuList)
            {
                dgvNguyenLieu.Rows.Add(nguyenlieu.MaHang, nguyenlieu.TenHang, nguyenlieu.MaChatLieu, nguyenlieu.SoLuong, nguyenlieu.DonGiaNhap, nguyenlieu.DonGiaBan, nguyenlieu.Anh, nguyenlieu.GhiChu);
            }
        }
        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvNguyenLieu.Rows.Count)
            {
                DataGridViewRow row = dgvNguyenLieu.Rows[e.RowIndex];

                // Lấy giá trị từ cột MaHang (Cell 0)
                object cellValueMaHang = row.Cells[0].Value;
                string MaHang = cellValueMaHang != null ? cellValueMaHang.ToString() : "";

                // Lấy giá trị từ cột TenHang (Cell 1)
                object cellValueTenHang = row.Cells[1].Value;
                string TenHang = cellValueTenHang != null ? cellValueTenHang.ToString() : "";

                // Lấy giá trị từ cột ChatLieu (Cell 2)
                object cellValueMaChatLieu = row.Cells[2].Value;
                string MaChatLieu = cellValueMaChatLieu != null ? cellValueMaChatLieu.ToString() : "";

                // Lấy giá trị từ cột SoLuong (Cell 3)
                object cellValueSoLuong = row.Cells[3].Value;
                int SoLuong = cellValueSoLuong != null ? Convert.ToInt32(cellValueSoLuong) : 0;

                // Lấy giá trị từ cột DonGiaNhap (Cell 4)
                object cellValueDonGiaNhap = row.Cells[4].Value;
                string DonGiaNhap = cellValueDonGiaNhap != null ? cellValueDonGiaNhap.ToString() : "";

                // Lấy giá trị từ cột DonGiaBan (Cell 5)
                object cellValueDonGiaBan = row.Cells[5].Value;
                string DonGiaBan = cellValueDonGiaBan != null ? cellValueDonGiaBan.ToString() : "";

                // Lấy giá trị từ cột Anh (Cell 6)
                object cellValueAnh = row.Cells[6].Value;
                string Anh = cellValueAnh != null ? cellValueAnh.ToString() : "";

                // Lấy giá trị từ cột GhiChu (Cell 7)
                object cellValueGhiChu = row.Cells[7].Value;
                string GhiChu = cellValueGhiChu != null ? cellValueGhiChu.ToString() : "";
                if (!string.IsNullOrEmpty(Anh))
                {
                    // Kết hợp đường dẫn ảnh với thư mục gốc của ứng dụng
                    string fullPath = Path.Combine(Application.StartupPath, Anh);

                    // Kiểm tra xem đường dẫn ảnh có tồn tại hay không
                    if (File.Exists(fullPath))
                    {
                        // Hiển thị ảnh lên PictureBox
                        picAnh.Image = Image.FromFile(fullPath);
                    }
                    else
                    {
                        picAnh.Image = null;
                    }
                }

                // Hiển thị giá trị lên TextBox hoặc các controls tương ứng
                txtMaHang.Text = MaHang;
                txtTenHang.Text = TenHang;
                cboMaChatLieu.Text = MaChatLieu;
                txtSoLuong.Text = SoLuong.ToString();
                txtDonGiaNhap.Text = DonGiaNhap.ToString();
                txtDonGiaBan.Text = DonGiaBan.ToString();
                txtAnh.Text = Anh;

                txtGhiChu.Text = GhiChu;
            }
            else
            {
                // Nếu người dùng click vào khoảng trống cuối cùng của hàng,
                // bạn có thể làm gì đó ở đây (ví dụ: xóa giá trị của TextBox và PictureBox)
                txtMaHang.Text = "";
                txtTenHang.Text = "";
                cboMaChatLieu.Text = "";
                txtSoLuong.Text = "";
                txtDonGiaNhap.Text = "";
                txtDonGiaBan.Text = "";
                txtAnh.Text = "";
                txtGhiChu.Text = "";
                picAnh.Image = null; ;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text;

            bool isMaHangExist = false;
            foreach (DataGridViewRow row in dgvNguyenLieu.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maHang)
                {
                    isMaHangExist = true;
                    break;
                }
            }

            if (isMaHangExist)
            {
                MessageBox.Show("Mã hàng đã tồn tại. Vui lòng chọn mã hàng khác.");
                return;
            }

            NguyenLieu hang = new NguyenLieu();
            hang.MaHang = txtMaHang.Text;
            hang.TenHang = txtTenHang.Text;
            hang.MaChatLieu = cboMaChatLieu.Text;
            hang.SoLuong = int.Parse(txtSoLuong.Text);
            hang.DonGiaNhap = txtDonGiaNhap.Text;
            hang.DonGiaBan = txtDonGiaBan.Text;
            hang.Anh = txtAnh.Text; ;
            hang.GhiChu = txtGhiChu.Text;

            hangBLL.NewHang(hang);

            MessageBox.Show("Thêm thành công!");

            // Thêm dòng mới vào đầu danh sách
            dgvNguyenLieu.Rows.Insert(0, hang.MaHang, hang.TenHang, hang.MaChatLieu, hang.SoLuong, hang.DonGiaNhap, hang.DonGiaBan, hang.Anh, hang.GhiChu);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NguyenLieu hang = new NguyenLieu();
            hang.MaHang = txtMaHang.Text;
            hang.TenHang = txtTenHang.Text;
            hang.MaChatLieu = cboMaChatLieu.Text;
            hang.SoLuong = int.Parse(txtSoLuong.Text);
            hang.DonGiaNhap = txtDonGiaNhap.Text;
            hang.DonGiaBan = txtDonGiaBan.Text;
            hang.Anh = txtAnh.Text;
            hang.GhiChu = txtGhiChu.Text;
            hangBLL.DeleteHang(hang);

            MessageBox.Show("Xóa thành công!");

            int idx = dgvNguyenLieu.CurrentCell.RowIndex;
            dgvNguyenLieu.Rows.RemoveAt(idx);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NguyenLieu hang = new NguyenLieu();
            hang.MaHang = txtMaHang.Text;
            hang.TenHang = txtTenHang.Text;
            hang.MaChatLieu = cboMaChatLieu.Text;

            // Kiểm tra và chuyển đổi DonGiaNhap
            hang.DonGiaNhap = txtDonGiaNhap.Text;
            hang.DonGiaBan = txtDonGiaBan.Text;


            hang.SoLuong = int.Parse(txtSoLuong.Text);
            hang.Anh = txtAnh.Text;
            hang.GhiChu = txtGhiChu.Text;

            hangBLL.EditHang(hang);

            MessageBox.Show("Chỉnh sửa thành công!");

            DataGridViewRow row = dgvNguyenLieu.CurrentRow;
            row.Cells[0].Value = hang.MaHang;
            row.Cells[1].Value = hang.TenHang;
            row.Cells[2].Value = hang.MaChatLieu;
            row.Cells[3].Value = hang.SoLuong;
            row.Cells[4].Value = hang.DonGiaNhap;
            row.Cells[5].Value = hang.DonGiaBan;
            row.Cells[6].Value = hang.Anh;
            row.Cells[7].Value = hang.GhiChu;
        }



        private void btnBoqua_Click(object sender, EventArgs e)
        {
           
        }
    


    private void btnOpen_Click(object sender, EventArgs e)
        {
            picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG files (*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picAnh.ImageLocation = dlg.FileName;
                txtAnh.Text = dlg.FileName;
            }
        }
        private void dgvHangHoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNguyenLieu.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dgvNguyenLieu.SelectedRows[0];

                // Lấy giá trị cột chứa đường dẫn ảnh (ví dụ: cột có tên "ImagePath")
                string imagePath = selectedRow.Cells["Column7"].Value.ToString();

                // Hiển thị ảnh lên PictureBox
                picAnh.Image = Image.FromFile(imagePath);
            }
        }

        private void txtDonGiaBan_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDonGiaNhap.Text))
            {
                // Xóa các dấu phân cách hiện có, như dấu phẩy
                string input = txtDonGiaBan.Text.Replace(",", "");

                // Chuyển đổi thành số nguyên
                if (int.TryParse(input, out int amount))
                {
                    // Định dạng số tiền theo định dạng VND và gán lại vào TextBox
                    txtDonGiaBan.Text = string.Format("{0:N0} ", amount);
                    txtDonGiaBan.SelectionStart = txtDonGiaBan.Text.Length;
                }
            }

        }
        private void txtDonGiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDonGiaNhap.Text))
            {
                // Xóa các dấu phân cách hiện có, như dấu phẩy
                string input = txtDonGiaNhap.Text.Replace(",", "");

                // Chuyển đổi thành số nguyên
                if (int.TryParse(input, out int amount))
                {
                    // Định dạng số tiền theo định dạng VND và gán lại vào TextBox
                    txtDonGiaNhap.Text = string.Format("{0:N0} VND", amount);
                    txtDonGiaNhap.SelectionStart = txtDonGiaNhap.Text.Length;
                }
            }

        }

        
      

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TIMNGUYENLIEU nGUYENLIEU = new TIMNGUYENLIEU();
            nGUYENLIEU.ShowDialog();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            // Đặt tỷ lệ khung hình mong muốn
            float scaleWidth = 1.5f;
            int newWidth = (int)(this.Width * scaleWidth);
            int newHeight = this.Height;
            Bitmap bmp = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.ScaleTransform(scaleWidth, 1);
                this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            }

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, pe) => pe.Graphics.DrawImage(bmp, 0, 0);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
                MessageBox.Show("Quá trình in hoàn thành.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBan_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvNguyenLieu.CurrentRow;
            if (selectedRow != null)
            {
                // Lấy dữ liệu liên quan từ hàng được chọn
                string maHang = selectedRow.Cells[0].Value.ToString();
                string tenHang = selectedRow.Cells[1].Value.ToString();

                // Thực hiện logic bán hàng tại đây
                // Ví dụ: hiển thị hộp thoại để nhập số lượng và tạo hoá đơn

                // Đoạn mã ở đây để nhập giá bán từ người dùng
                decimal donGiaBan = 0;
                if (decimal.TryParse(txtDonGiaBan.Text, out donGiaBan) && donGiaBan >= 0)
                {
                    int soLuongBan = 1; // Số lượng bạn nhận từ người dùng

                    decimal tongTien = soLuongBan * donGiaBan;

                    // Tạo hoá đơn hoặc cập nhật bản ghi doanh thu

                    MessageBox.Show($"Bán {soLuongBan} đơn vị của {tenHang} với giá {tongTien} VND.", "Bán hàng thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật số lượng trong nguồn dữ liệu của bạn nếu cần
                    // Bạn cũng có thể làm mới DataGridView sau khi đã bán hàng
                }
                else
                {
                    MessageBox.Show("Dữ liệu giá bán không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng để bán.", "Không có lựa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NGUYENLIEU_Load_1(object sender, EventArgs e)
        {

        }
    }


}
