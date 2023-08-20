using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using DO_AN.BLL;
using DO_AN.Model;

namespace DO_AN.BLL
{
    internal class CustomerDAL : DBConnection
    {
        public List<Login> ReadCustomer()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Login> lstCus = new List<Login>();
            while (reader.Read())
            {
                Login cus = new Login();
                cus.Id = int.Parse(reader["id"].ToString());

                cus.Name = reader["name"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }

        public void DeleteCustomer(Login cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from customer where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void NewCustomer(Login cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into customer values(@id,@name)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Editcustomer(Login cus)
        {
            // Add your edit logic here
        }

        internal void EditCustomer(Login cus)
        {
            throw new NotImplementedException();
        }
    }
}
