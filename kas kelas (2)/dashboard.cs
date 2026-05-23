using System;
using System.Windows.Forms;

namespace kas_kelas__2_
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            panelIsi.Controls.Clear();

            var UCdasboard = new UC_Dashboard();
            UCdasboard.Dock = DockStyle.Fill;

            panelIsi.Controls.Add(UCdasboard);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelIsi.Controls.Clear();

            var UCdasboard = new UC_Dashboard();
            UCdasboard.Dock = DockStyle.Fill;

            panelIsi.Controls.Add(UCdasboard);
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            panelIsi.Controls.Clear();

            var UCTransaction = new UCTransaction();
            UCTransaction.Dock = DockStyle.Fill;

            panelIsi.Controls.Add(UCTransaction);
        }

        private void btnBudgets_Click(object sender, EventArgs e)
        {
            panelIsi.Controls.Clear();

            var UCBudgets = new UC_Budget();
            UCBudgets.Dock = DockStyle.Fill;

            panelIsi.Controls.Add(UCBudgets);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelIsi.Controls.Clear();

            var UCStudentList = new UC_Student_List();
            UCStudentList.Dock = DockStyle.Fill;

            panelIsi.Controls.Add(UCStudentList);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();

            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panelIsi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}