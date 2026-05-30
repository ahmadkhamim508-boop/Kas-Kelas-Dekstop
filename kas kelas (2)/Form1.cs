using kas_kelas__2_.Config;
using kas_kelas__2_.Helpers;
using kas_kelas__2_.Models;
using kas_kelas__2_.Services;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kas_kelas__2_
{
    public partial class Form1 : Form
    {
        AuthController auth = new AuthController();
        public Form1()
        {
            InitializeComponent();
            txtPasword.UseSystemPasswordChar = true;
            this.AcceptButton = btnMasuk;
        }
        private void btnMasuk_Click(object sender, EventArgs e)
        {
            string username = txtNama.Text.Trim();
            string password = txtPasword.Text; // adjust as needed

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Isi username dan password!");
                return;
            }
            var userModel = new UsersModel { username = username, password = password };

            if (auth.LoginAdmin(userModel))
            {
                // store admin session (you can extend UsersModel with role if needed)
                SessionManager.SetAdmin(new UsersModel { username = username, password = null });

                this.Hide();
                dashboard dashboard = new dashboard();
                dashboard.FormClosed += (s, args) => this.Close();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Login anda Gagal!");
            }
        }

        private void checkBoxTampilkanpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTampilkanpassword.Checked)
            {
                txtPasword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPasword.UseSystemPasswordChar = true;
            }
        }

        private void txtloginSiswa_Click(object sender, EventArgs e)
        {
            LoginStudent loginStudent = new LoginStudent();
            loginStudent.Show();
            this.Hide();
        }
    }
}