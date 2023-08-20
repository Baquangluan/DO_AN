using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DO_AN.GUI;

namespace DO_AN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == "luan" && password == "12345")
            {
                this.Hide();
                MENU form2 = new MENU();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác!");
            }
        }

       
    }
}
