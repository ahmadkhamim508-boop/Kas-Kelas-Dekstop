using kas_kelas__2_.Helpers;
using kas_kelas__2_.Models;
using kas_kelas__2_.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kas_kelas__2_
{
    public partial class LoginStudent : Form
    {

        public LoginStudent()
        {
            InitializeComponent();
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            // Ensure the button and textbox events are wired at runtime
            btnMasuk.Click -= btnMasuk_Click;
            btnMasuk.Click += btnMasuk_Click;

            txtNIS.KeyDown -= txtNIS_KeyDown;
            txtNIS.KeyDown += txtNIS_KeyDown;
        }

        private void txtNIS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnMasuk_Click(this, EventArgs.Empty);
            }
        }


        private void btnMasuk_Click(object sender, EventArgs e)
        {
            // Ambil input NIS
            string nis = txtNIS.Text.Trim();

            // Validasi kosong
            if (string.IsNullOrEmpty(nis))
            {
                MessageBox.Show("NIS wajib diisi!");
                txtNIS.Focus();
                return;
            }

            // Panggil controller / auth
            AuthController auth = new AuthController();

            // Ambil data siswa
            StudentsModel siswa = auth.LoginStudent(nis);

            // Jika berhasil login
            if (siswa != null)
            {
                // set session as student
                SessionManager.SetStudent(siswa);

                MessageBox.Show("Login berhasil!");

                this.Hide();

                dashboard dashboard = new dashboard();
                dashboard.FormClosed += (s, args) => this.Close();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("NIS tidak ditemukan!");
            }
        }
    }
}
