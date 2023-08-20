using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO_AN.BLL;
using DO_AN.Model;

namespace DO_AN
{
    internal class CustomerBAL
    {
        private CustomerDAL dal = new CustomerDAL(); // Assuming CustomerDAL is accessible and instantiated correctly.

        public List<Login> ReadCustomer()
        {
            List<Login> lstCus = dal.ReadCustomer();
            return lstCus;
        }

        public void NewCustomer(Login cus)
        {
            dal.NewCustomer(cus);
        }

        public void DeleteCustomer(Login cus)
        {
            dal.DeleteCustomer(cus);
        }

        public void EditCustomer(Login cus)
        {
            dal.EditCustomer(cus);
        }
    }
}
