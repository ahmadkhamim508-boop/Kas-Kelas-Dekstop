using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_kelas__2_.Config
{
    public class database
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=MSI\\SQLEXPRESS;" +
            "Initial Catalog=dbkaskelas;" +
            "Integrated Security=True"
        );

        public void Open()
        {
            conn.Open();
        }

        public void close()
        {
            conn.Close();
        }

        public SqlConnection getConnection()
        {
            return conn;
        }
    }
}