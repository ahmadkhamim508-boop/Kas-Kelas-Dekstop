using kas_kelas__2_.Config;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kas_kelas__2_
{
    public partial class Form1 : Form
    {
        database conn = new database();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim() == "" || txtPasword.Text.Trim() == "")
            {
                MessageBox.Show("Username dan Password wajib di isi");
                return;
            }

            conn.Open();

            string query = "SELECT * FROM admin WHERE username=@username AND password=@password";

            SqlCommand cmd = new SqlCommand(query, conn.getConnection());

            cmd.Parameters.AddWithValue("@username", txtNama.Text.Trim());
            cmd.Parameters.AddWithValue("@password", txtPasword.Text.Trim());

            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                rd.Close();

                MessageBox.Show("Login Berhasil");
                
                dashboard dashboard = new dashboard();
                dashboard.Show();

                //this.Hide();
            }
            else
            {
                rd.Close();

                MessageBox.Show("Username atau Password Salah");
            }

            conn.close();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSiswa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login sebagai Siswa");
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login sebagai Admin");
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPasword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}