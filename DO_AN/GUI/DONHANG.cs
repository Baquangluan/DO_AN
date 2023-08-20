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
using DO_AN.BAL;
using DO_AN.DAL;
using DO_AN.Model;
using DO_AN.MODEL;
using OfficeOpenXml;

namespace DO_AN.GUI
{
    public partial class DONHANG : Form
    {
       
        HDBanBLL hdBanBLL = new HDBanBLL();
        public DONHANG()
        {
            InitializeComponent();
            InitializeComboBoxes();
            InitializeEventHandlers();
        }
        private PrintDocument printDocument = new PrintDocument(); // Khai báo biến printDocument

        private void InitializeEventHandlers()
        {
            dgvHDBanHang.CellClick += dgvNguyenLieu_CellClick;
            txtDonGiaBan.TextChanged += UpdateThanhTien;
            txtSoLuong.TextChanged += UpdateThanhTien;
            cbbgiamgia.SelectedIndexChanged += UpdateThanhTien;
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage); // Sử dụng biến printDocument
        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Lấy đối tượng Graphics để vẽ trên trang in
            Graphics graphics = e.Graphics;

            // Thiết lập font và brush
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Vị trí bắt đầu vẽ
            float yPosition = 100;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;

            // Chuỗi nội dung bạn muốn in
            string content = "Đây là nội dung bạn muốn in.";

            // Vẽ nội dung lên trang in
            graphics.DrawString(content, font, brush, leftMargin, yPosition);

            // Di chuyển đến vị trí tiếp theo
            yPosition += font.GetHeight();

            // Kiểm tra xem còn nội dung nào để in không
            if (yPosition + font.GetHeight() > e.MarginBounds.Bottom)
                e.HasMorePages = false;
            else
                e.HasMorePages = true;
        }

        private void UpdateThanhTien(object sender, EventArgs e)
        {
            // Logic để cập nhật thành tiền dựa trên thay đổi trong txtDonGiaBan,
            // txtSoLuong và cbbgiamgia.
            // Ví dụ:
            decimal donGia;
            if (decimal.TryParse(txtDonGiaBan.Text, out donGia))
            {
                int soLuong;
                if (int.TryParse(txtSoLuong.Text, out soLuong))
                {
                    decimal giamGia = Convert.ToDecimal(cbbgiamgia.SelectedItem);
                    decimal thanhTien = (donGia * soLuong) * (1 - giamGia);
                    // Cập nhật giá trị thanhTien ở đây.
                }
            }
        }

        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvHDBanHang.Rows.Count)
            {
                DataGridViewRow row = dgvHDBanHang.Rows[e.RowIndex];

                // Lấy giá trị từ cột MaHoaDon (Cell 0)
                object cellValueMaHoaDon = row.Cells[0].Value;
                string MaHoaDon = cellValueMaHoaDon != null ? cellValueMaHoaDon.ToString() : "";

                // Lấy giá trị từ cột MaNhanVien (Cell 1)
                object cellValueMaNhanVien = row.Cells[1].Value;
                string MaNhanVien = cellValueMaNhanVien != null ? cellValueMaNhanVien.ToString() : "";

                // Lấy giá trị từ cột NgayBan (Cell 2)
                object cellValueNgayBan = row.Cells[2].Value;
                DateTime NgayBan = cellValueNgayBan != null ? Convert.ToDateTime(cellValueNgayBan) : DateTime.MinValue;

                // Lấy giá trị từ cột MaKhachHang (Cell 3)
                object cellValueMaKhachHang = row.Cells[3].Value;
                string MaKhachHang = cellValueMaKhachHang != null ? cellValueMaKhachHang.ToString() : "";

                // Lấy giá trị từ cột TenKhachHang (Cell 4)
                object cellValueTenKhachHang = row.Cells[4].Value;
                string TenKhachHang = cellValueTenKhachHang != null ? cellValueTenKhachHang.ToString() : "";

                // Lấy giá trị từ cột MaHang (Cell 5)
                object cellValueMaHang = row.Cells[5].Value;
                string MaHang = cellValueMaHang != null ? cellValueMaHang.ToString() : "";

                // Lấy giá trị từ cột TenHang (Cell 6)
                object cellValueTenHang = row.Cells[6].Value;
                string TenHang = cellValueTenHang != null ? cellValueTenHang.ToString() : "";

                // Lấy giá trị từ cột SoLuong (Cell 7)
                object cellValueSoLuong = row.Cells[7].Value;
                int SoLuong = cellValueSoLuong != null ? Convert.ToInt32(cellValueSoLuong) : 0;

                // Lấy giá trị từ cột ThanhTien (Cell 8)
                object cellValueThanhTien = row.Cells[8].Value;
                string ThanhTien = cellValueThanhTien != null ? cellValueThanhTien.ToString() : "";

                if (!string.IsNullOrEmpty(MaHang))
                {
                    // Hiển thị thông tin lên các controls tương ứng
                    txtMaHDBan.Text = MaHoaDon;
                    cboMaNhanVien.Text = MaNhanVien;
                    txtNgayBan.Value = NgayBan;
                    cboMaKhach.Text = MaKhachHang;
                    txtTenKhach.Text = TenKhachHang;
                    cboMaHang.Text = MaHang;
                    txtTenHang.Text = TenHang;
                    txtSoLuong.Text = SoLuong.ToString();
                    txtThanhTien.Text = ThanhTien;
                }
            }
            else
            {
                // Nếu người dùng click vào khoảng trống cuối cùng của hàng,
                // bạn có thể làm gì đó ở đây (ví dụ: xóa giá trị của các controls)
                txtMaHDBan.Text = "";
                cboMaNhanVien.Text = "";
                txtNgayBan.Value = DateTime.Now;
                cboMaKhach.Text = "";

                cboMaHang.Text = "";

                txtSoLuong.Text = "";
                txtThanhTien.Text = "";
            }
        }

        private void InitializeComboBoxes()
        {
            // Initialize your ComboBoxes here
        }
        private string GenerateNewMaHDBan()
        {
            string prefix = "HDB"; // Mã tiền tố cho hóa đơn bán
            int currentMaxIndex = 0;

            foreach (DataGridViewRow row in dgvHDBanHang.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().StartsWith(prefix))
                {
                    int index;
                    if (int.TryParse(row.Cells[0].Value.ToString().Substring(prefix.Length), out index))
                    {
                        if (index > currentMaxIndex)
                        {
                            currentMaxIndex = index;
                        }
                    }
                }
            }

            currentMaxIndex++; // Tăng index lên 1 để tạo mã mới

            return $"{prefix}{currentMaxIndex:D4}"; // Định dạng mã với số 4 chữ số
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string newMaHDBan = GenerateNewMaHDBan();
            txtMaHDBan.Text = newMaHDBan;
            string maHoaDon = txtMaHDBan.Text;


            // Kiểm tra xem mã hóa đơn đã tồn tại hay chưa
            bool isMaHoaDonExist = false;
            foreach (DataGridViewRow row in dgvHDBanHang.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maHoaDon)
                {
                    isMaHoaDonExist = true;
                    break;
                }
            }

            if (isMaHoaDonExist)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại. Vui lòng chọn mã hóa đơn khác.");
                return;
            }

            HDBan hdBan = new HDBan();
            hdBan.MaHoaDon = txtMaHDBan.Text;
            hdBan.MaNhanVien = cboMaNhanVien.Text;
            hdBan.NgayBan = txtNgayBan.Value;
            hdBan.MaKhachHang = cboMaKhach.Text;
            hdBan.TenKhachHang = txtTenKhach.Text;
            hdBan.MaHang = cboMaHang.Text;
            hdBan.TenHang = txtTenHang.Text;
            hdBan.SoLuong = int.Parse(txtSoLuong.Text);
            hdBan.ThanhTien = txtThanhTien.Text;

            hdBanBLL.NewHDBan(hdBan);

            MessageBox.Show("Thêm thành công!");

            dgvHDBanHang.Rows.Add(
                hdBan.MaHoaDon,
                hdBan.MaNhanVien,
                hdBan.NgayBan,
                hdBan.MaKhachHang,
                hdBan.TenKhachHang,
                hdBan.MaHang,
                hdBan.TenHang,
                hdBan.SoLuong,
                hdBan.ThanhTien
            );
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HDBan hdBan = new HDBan();
            hdBan.MaHoaDon = txtMaHDBan.Text;
            hdBan.MaNhanVien = cboMaNhanVien.Text;
            hdBan.NgayBan = txtNgayBan.Value;
            hdBan.MaKhachHang = cboMaKhach.Text;
            hdBan.TenKhachHang = txtTenKhach.Text;
            hdBan.MaHang = cboMaHang.Text;
            hdBan.TenHang = txtTenHang.Text;
            hdBan.SoLuong = int.Parse(txtSoLuong.Text);
            hdBan.ThanhTien = txtThanhTien.Text;

            hdBanBLL.DeleteHDBan(hdBan);

            MessageBox.Show("Xóa thành công!");

            int idx = dgvHDBanHang.CurrentCell.RowIndex;
            dgvHDBanHang.Rows.RemoveAt(idx);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HDBan hdBan = new HDBan();
            hdBan.MaHoaDon = txtMaHDBan.Text;
            hdBan.MaNhanVien = cboMaNhanVien.Text;
            hdBan.NgayBan = txtNgayBan.Value;
            hdBan.MaKhachHang = cboMaKhach.Text;
            hdBan.TenKhachHang = txtTenKhach.Text;
            hdBan.MaHang = cboMaHang.Text;
            hdBan.TenHang = txtTenHang.Text;
            hdBan.SoLuong = int.Parse(txtSoLuong.Text);
            hdBan.ThanhTien = txtThanhTien.Text;

            hdBanBLL.EditHDBan(hdBan);

            MessageBox.Show("Chỉnh sửa thành công!");

            DataGridViewRow row = dgvHDBanHang.CurrentRow;
            row.Cells[0].Value = hdBan.MaHoaDon;
            row.Cells[1].Value = hdBan.MaNhanVien;
            row.Cells[2].Value = hdBan.NgayBan;
            row.Cells[3].Value = hdBan.MaKhachHang;
            row.Cells[4].Value = hdBan.TenKhachHang;
            row.Cells[5].Value = hdBan.MaHang;
            row.Cells[6].Value = hdBan.TenHang;
            row.Cells[7].Value = hdBan.SoLuong;
            row.Cells[8].Value = hdBan.ThanhTien;
        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tuple<string, string, string> selectedHangHoa = (Tuple<string, string, string>)cboMaHang.SelectedItem;
            txtTenHang.Text = selectedHangHoa.Item2;
            txtDonGiaBan.Text = selectedHangHoa.Item3;
        }

        private void cboMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tuple<string, string> selectedNhanVien = (Tuple<string, string>)cboMaNhanVien.SelectedItem;
            txtTenNhanVien.Text = selectedNhanVien.Item2;
        }

        private void cboMaKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tuple<string, string, string, string> selectedKhachHang = (Tuple<string, string, string, string>)cboMaKhach.SelectedItem;
            txtTenKhach.Text = selectedKhachHang.Item2;
            txtDiaChi.Text = selectedKhachHang.Item3;
            txtDienThoai.Text = selectedKhachHang.Item4;
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            float scaleWidth = 1.5f; // Tỷ lệ chiều rộng, ví dụ: 1.5 lần

            int newWidth = (int)(this.Width * scaleWidth);
            int newHeight = this.Height;

            Bitmap bmp = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White); // Xóa nền trắng để đảm bảo không có nội dung cũ
                g.ScaleTransform(scaleWidth, 1); // Chỉ áp dụng tỷ lệ cho chiều rộng
                this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            }

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, pe) =>
            {
                pe.Graphics.DrawImage(bmp, 0, 0);
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
                MessageBox.Show("Quá trình in hoàn thành.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Export to Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                    // Đổ tiêu đề cột từ DataGridView
                    for (int i = 0; i < dgvHDBanHang.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dgvHDBanHang.Columns[i].HeaderText;
                    }

                    // Đổ dữ liệu từ DataGridView
                    for (int row = 0; row < dgvHDBanHang.Rows.Count; row++)
                    {
                        for (int col = 0; col < dgvHDBanHang.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dgvHDBanHang.Rows[row].Cells[col].Value;
                        }
                    }

                    FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(excelFile);
                }

                MessageBox.Show("Xuất thành công!");
            }
        }


        }
}

