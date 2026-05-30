using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_kelas__2_.Models
{
    public class BudgetModel
    {
        public int id { get; set; }
        public DateTime tanggal_pengeluaran { get; set; }
        public int jumlah_pengeluaran { get; set; }
        public string keterangan { get; set; }
        public byte[] bukti_foto { get; set; }
    }
}