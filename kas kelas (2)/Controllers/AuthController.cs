using kas_kelas__2_.Config;
using kas_kelas__2_.Models;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace kas_kelas__2_.Services
{
    public class AuthController
    {
        Database db = new Database();

        public bool LoginAdmin(UsersModel user)
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT COUNT(*)
                             FROM Users
                             WHERE username=@username
                             AND password=@password";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@username", user.username);
                    cmd.Parameters.AddWithValue("@password", user.password);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }
        }
        public StudentsModel LoginStudent(string nis)
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT id, nama_siswa, nis
                             FROM data_students
                             WHERE nis=@nis";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nis", nis);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Debug.WriteLine("AuthController.LoginStudent -> reader.HasRows = " + reader.HasRows);

                        if (reader.Read())
                        {
                            object idObj = reader["id"];
                            int id = idObj == DBNull.Value ? 0 : Convert.ToInt32(idObj);

                            string nama = reader["nama_siswa"] == DBNull.Value ? string.Empty : reader["nama_siswa"].ToString();
                            string nisValue = reader["nis"] == DBNull.Value ? string.Empty : reader["nis"].ToString();

                            Debug.WriteLine($"AuthController.LoginStudent -> found id={id}, nama_siswa={nama}, nis={nisValue}");

                            return new StudentsModel
                            {
                                id = id,
                                nama_siswa = nama,
                                nis = nisValue
                            };
                        }
                    }

                    Debug.WriteLine("AuthController.LoginStudent -> no rows found for nis: " + nis);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("AuthController.LoginStudent Exception -> " + ex);
                MessageBox.Show("Database Error: " + ex.Message);
                return null;
            }
        }
    }
}