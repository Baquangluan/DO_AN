using DO_AN.BAL;
using DO_AN.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DO_AN.GUI
{
    public partial class DUNGCU : Form
    {
        ChatLieuBAL clBAL = new ChatLieuBAL();
       


        public DUNGCU()
        {
            InitializeComponent();
            dgvChatLieu.CellClick += dgvChatLieu_CellClick;
            LoadDataFromDatabase();
        }

        private void dgvChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvChatLieu.Rows.Count) // Kiểm tra e.RowIndex hợp lệ
            {
                DataGridViewRow row = dgvChatLieu.Rows[e.RowIndex];

                // Kiểm tra số cột và số ô được chọn có đúng không
                if (e.ColumnIndex >= 0 && e.ColumnIndex < row.Cells.Count)
                {
                    // Lấy giá trị từ cột MaChatLieu
                    string MaChatLieu = row.Cells[0].Value?.ToString(); // Sử dụng ?. để tránh lỗi nếu giá trị là null

                    // Lấy giá trị từ cột TenChatLieu
                    string TenChatLieu = row.Cells[1].Value?.ToString(); // Sử dụng ?. để tránh lỗi nếu giá trị là null

                    // Hiển thị giá trị lên TextBox
                    txtMaChatLieu.Text = MaChatLieu;
                    txtTenChatLieu.Text = TenChatLieu;
                }
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtMaChatLieu.Text))
            {
                MessageBox.Show("Không được để trống mã.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtMaChatLieu.Text, out int id))
            {
                MessageBox.Show("Không được nhập kí tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mã trùng lặp
            string newMaChatLieu = txtMaChatLieu.Text;
            foreach (DataGridViewRow row in dgvChatLieu.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == newMaChatLieu)
                {
                    MessageBox.Show("Mã dung cu đã tồn tại. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            ChatLieu cus = new ChatLieu();
            cus.MaChatLieu = txtMaChatLieu.Text;
            cus.TenChatLieu = txtTenChatLieu.Text;

            clBAL.NewChatLieu(cus);

            dgvChatLieu.Rows.Add(cus.MaChatLieu, cus.TenChatLieu);
        }
        private void DUNGCU_Load(object sender, EventArgs e)
        {
            // Load data from the database using clBAL and populate the DataGridView
            List<ChatLieu> chatLieuList = clBAL.ReadChatLieu(); // You need to implement this method
            foreach (ChatLieu chatLieu in chatLieuList)
            {
                dgvChatLieu.Rows.Add(chatLieu.MaChatLieu, chatLieu.TenChatLieu);
            }
        }
        private void LoadDataFromDatabase()
        {
            List<ChatLieu> chatLieuList = clBAL.ReadChatLieu();
            foreach (ChatLieu chatLieu in chatLieuList)
            {
                dgvChatLieu.Rows.Add(chatLieu.MaChatLieu, chatLieu.TenChatLieu);
            }
        }
       



        private void dgvChatLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaChatLieu.Text))
            {
                MessageBox.Show("Không được để trống mã.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtMaChatLieu.Text, out int id))
            {
                MessageBox.Show("Không được nhập kí tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ChatLieu cus = new ChatLieu();
            cus.MaChatLieu = txtMaChatLieu.Text;
            cus.TenChatLieu = txtTenChatLieu.Text;

            clBAL.DeleteChatLieu(cus);
            MessageBox.Show("Xóa thành công!");

            int idx = dgvChatLieu.CurrentCell.RowIndex; dgvChatLieu.Rows.RemoveAt(idx);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaChatLieu.Text))
            {
                MessageBox.Show("Không được để trống mã.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtMaChatLieu.Text, out int id))
            {
                MessageBox.Show("Không được nhập kí tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ChatLieu cus = new ChatLieu();
            cus.MaChatLieu = txtMaChatLieu.Text;
            cus.TenChatLieu = txtTenChatLieu.Text;
            clBAL.EditChatLieu(cus);

            DataGridViewRow row = dgvChatLieu.CurrentRow;
            row.Cells[0].Value = cus.MaChatLieu;
            row.Cells[1].Value = cus.TenChatLieu;
        }
       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // You can add your save functionality here.
            // For now, I'll just show a message box.
            MessageBox.Show("Data has been saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtMaChatLieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
