using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using kas_kelas__2_.Config;
using System.Windows.Forms.DataVisualization.Charting;

namespace kas_kelas__2_
{
    public partial class UC_Dashboard : UserControl
    {
        Database db = new Database();
        public UC_Dashboard()
        {
            InitializeComponent();
            totalSaldo();
            totalSiswa();
            totalPending();
            totalDebt();
            recentTransaction();
            recentExpenditure();
        }
        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            recentTransaction();
            recentExpenditure();
        }

        private void totalSaldo()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string pemasukan = "SELECT ISNULL(SUM(jumlah_pemasukkan),0) FROM pembayaran_kas";
                string pengeluaran = "SELECT ISNULL(SUM(jumlah_pengeluaran),0) FROM pengeluaran_kas";

                SqlCommand cmdMasuk = new SqlCommand(pemasukan, conn);
                SqlCommand cmdKeluar = new SqlCommand(pengeluaran, conn);

                int totalMasuk = Convert.ToInt32(cmdMasuk.ExecuteScalar());
                int totalKeluar = Convert.ToInt32(cmdKeluar.ExecuteScalar());

                int saldo = totalMasuk - totalKeluar;

                lblSaldo.Text = "Rp. " + saldo.ToString("N0");
            }
        }

        private void totalSiswa()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();


                string query = "SELECT COUNT(*) FROM data_students";

                SqlCommand cmd = new SqlCommand(query, conn);

                int total = (int)cmd.ExecuteScalar();

                lblSiswa.Text = total + " SISWA";
            }
        }

        private void totalPending()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM pembayaran_kas";
                SqlCommand cmd = new SqlCommand(query, conn);
                int total = (int)cmd.ExecuteScalar();
                lblPending.Text = total + " RECORD";
            }
        }

        private void totalDebt()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT ISNULL(SUM(jumlah_pengeluaran),0) FROM pengeluaran_kas";
                SqlCommand cmd = new SqlCommand(query, conn);
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                lblDebt.Text = "Rp. " + total.ToString("N0");
            }
        }

        private void recentTransaction()
        {

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    MessageBox.Show("Koneksi berhasil");

                    string query = @"SELECT TOP 5
                data_students.nama_siswa,
                pembayaran_kas.jumlah_pemasukkan,
                pembayaran_kas.tanggal_pemasukkan
                FROM pembayaran_kas
                JOIN data_students
                ON pembayaran_kas.data_student_id = data_students.id
                ORDER BY pembayaran_kas.id DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    MessageBox.Show("Jumlah data: " + dt.Rows.Count); // 🔥 INI KUNCI

                    dgvRecent.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void recentExpenditure()
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT TOP 5
                    tanggal_pengeluaran,
                    jumlah_pengeluaran,
                    keterangan
                    FROM pengeluaran_kas
                    ORDER BY id DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvbudget.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
