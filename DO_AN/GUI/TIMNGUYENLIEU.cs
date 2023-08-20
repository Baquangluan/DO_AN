using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DO_AN.DAL;
using DO_AN.MODEL;

namespace DO_AN.GUI
{
    public partial class TIMNGUYENLIEU : Form
    {
        public TIMNGUYENLIEU()
        {
            InitializeComponent();
        }

        private void TIMNGUYENLIEU_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text;
            string tenHang = txtTenHang.Text;

            // Gọi phương thức tìm kiếm từ BLL và lấy kết quả đầu tiên (hoặc null nếu không tìm thấy)
            NguyenLieuDAL hangBLL = new NguyenLieuDAL();
            NguyenLieu searchResult = hangBLL.SearchHangByMaAndTen(maHang, tenHang).FirstOrDefault();

            if (searchResult != null)
            {
                dgvHang.DataSource = new List<NguyenLieu> { searchResult }; // Hiển thị kết quả trong DataGridView
            }
            else
            {
                dgvHang.DataSource = null;
                MessageBox.Show("Không tìm thấy kết quả.");// Không tìm thấy kết quả, không hiển thị gì trong DataGridView
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
