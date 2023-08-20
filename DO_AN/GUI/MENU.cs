using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN.GUI
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            DUNGCU dUNGCU = new DUNGCU();
            dUNGCU.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            NHANVIEN nHANVIEN = new NHANVIEN();
            nHANVIEN.ShowDialog();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            KHACHHANG kHACHHANG = new KHACHHANG();
            kHACHHANG.ShowDialog();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            NGUYENLIEU nGUYENLIEU = new NGUYENLIEU();
            nGUYENLIEU.ShowDialog();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            HOADON hOADON = new HOADON();
            hOADON.ShowDialog();
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            DONHANG dONHANG = new DONHANG();    
            dONHANG.ShowDialog();
        }

     

        
    }
}
