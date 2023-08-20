using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO_AN.Model;
using DO_AN.MODEL;

namespace DO_AN.DAL
{
    internal class NhanVienBAL
    {
        NhanVienDAL dal = new NhanVienDAL();

        public List<NhanVien> ReadNhanVien()
        {
            List<NhanVien> lstCus = dal.ReadNhanVien();
            return lstCus;
        }
      


        public void NewNhanVien(NhanVien cus)
        {
            dal.NewNhanVien(cus);
        }

        public void DeleteNhanVien(NhanVien cus)
        {
            dal.DeleteNhanVien(cus);
        }

        public void EditNhanVien(NhanVien cus)
        {
            dal.EditNhanVien(cus);
        }
        public void SaveNhanVien(NhanVien cus)
        {
            dal.SaveNhanVien(cus);
        }

    }
}
