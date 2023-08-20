using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO_AN.MODEL;

namespace DO_AN.DAL
{
    internal class KhachBAL
    {
        KhachDAL dal = new KhachDAL();

        public List<Khach> ReadkhachHang()
        {
            List<Khach> lstCus = dal.ReadKhachHang();
            return lstCus;
        }


        public void NewkhachHang(Khach cus)
        {
            dal.NewkhachHang(cus);
        }

        public void DeletekhachHang(Khach cus)
        {
            dal.DeletekhachHang(cus);
        }

        public void EditkhachHang(Khach cus)
        {
            dal.EditkhachHang(cus);
        }
       
    }
}

