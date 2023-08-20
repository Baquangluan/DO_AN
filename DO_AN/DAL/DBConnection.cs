using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN
{
    internal class DBConnection
    {
        public DBConnection()
        {
        }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=MSI\SA;Initial Catalog=QLBH; User Id=sa; Password=sa";
            return conn;
        }

    }
}
