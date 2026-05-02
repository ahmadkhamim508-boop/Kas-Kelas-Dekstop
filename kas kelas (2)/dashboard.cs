using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //panelIsi.Controls.Clear();
            //var UCdasboard = new UC_Dashboard ();
            //panelIsi.Controls.Add(UCdasboard);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelIsi.Controls.Clear();
            var UCdasboard = new UC_Dashboard();
            panelIsi.Controls.Add(UCdasboard);
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            panelIsi.Controls.Clear();
            var UCTransaction = new UCTransaction();
            panelIsi.Controls.Add(UCTransaction);

        }

        private void btnBudgets_Click(object sender, EventArgs e)
        {
            panelIsi.Controls.Clear();
            var UCBudgets = new UC_Budget();
            panelIsi.Controls.Add(UCBudgets);
        }
    }
}

