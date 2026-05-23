using kas_kelas__2_.Config;
using System.Data.SqlClient;

namespace kas_kelas__2_.Services
{
    public class LoginAdService
    {
        database db = new database();

        public bool Login(string username, string password)
        {
            db.Open();

            string query = "SELECT COUNT(*) FROM admin WHERE username=@username AND password=@password";

            SqlCommand cmd = new SqlCommand(query, db.getConnection());

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            int count = (int)cmd.ExecuteScalar();

            db.close();

            return count > 0;
        }
    }
}