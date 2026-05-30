using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_kelas__2_.Models
{
    public class PaymentModel
    {
        public int id { get; set; }
        public int data_student_id { get; set; }
        public int jumlah_pemasukkan{ get; set; }
        public DateTime tanggal_pemasukkan{ get; set; }
    }
}
