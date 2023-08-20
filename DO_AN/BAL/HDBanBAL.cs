using DO_AN.DAL;
using DO_AN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.BAL
{
    internal class HDBanBLL
    {
        HDBanDAL dal = new HDBanDAL();

        public List<HDBan> ReadHDBan()
        {
            List<HDBan> lstHDBan = dal.ReadHDBan();
            return lstHDBan;
        }

        public void NewHDBan(HDBan hdBan)
        {
            dal.NewHDBan(hdBan);
        }

        public void DeleteHDBan(HDBan hdBan)
        {
            dal.DeleteHDBan(hdBan);
        }

        public void EditHDBan(HDBan hdBan)
        {
            dal.EditHDBan(hdBan);
        }
    }
}
