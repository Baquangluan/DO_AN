using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO_AN.MODEL;

namespace DO_AN.DAL
{
    internal class NguyeLieuBAL
    {
        NguyenLieuDAL dal = new NguyenLieuDAL();

        public List<NguyenLieu> ReadHang()
        {
            List<NguyenLieu> lstHang = dal.ReadHang();
            return lstHang;
        }

        public void NewHang(NguyenLieu cus)
        {
            dal.NewHang(cus);
        }

        public void DeleteHang(NguyenLieu cus)
        {
            dal.DeleteHang(cus);
        }

        public void EditHang(NguyenLieu cus)
        {
            dal.EditHang(cus);
        }

        private SqlConnection CreateConnection()
        {
            string connectionString = "Data Source=MSI\\SA;Initial Catalog=QLBH;User ID=sa;Password=sa";
            return new SqlConnection(connectionString);
        }

    }
}

