using kas_kelas__2_.Config;
using kas_kelas__2_.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace kas_kelas__2_.Controllers
{
    public class BudgetController
    {
        Database db = new Database();

        public DataTable GetAll()
        {
            using (var conn = db.GetConnection())
            {
                string query = "SELECT id, tanggal_pengeluaran, jumlah_pengeluaran, " +
                    "keterangan FROM pengeluaran_kas ORDER BY id DESC";
                using (var da = new SqlDataAdapter(query, conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
            }
        }

       
        
        public void insertBudget(BudgetModel model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            using (var conn = db.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();

                // compute current saldo: total pemasukan - total pengeluaran
                using (var cmdMasuk = conn.CreateCommand())
                {
                    cmdMasuk.CommandText = "SELECT ISNULL(SUM(jumlah_pemasukkan),0) FROM pembayaran_kas";
                    var objMasuk = cmdMasuk.ExecuteScalar();
                    int totalMasuk = Convert.ToInt32(objMasuk);
                    using (var cmdKeluar = conn.CreateCommand())
                    {
                        cmdKeluar.CommandText = "SELECT ISNULL(SUM(jumlah_pengeluaran),0) FROM pengeluaran_kas";
                        var objKeluar = cmdKeluar.ExecuteScalar();
                        int totalKeluar = Convert.ToInt32(objKeluar);

                        int saldo = totalMasuk - totalKeluar;

                        // prevent inserting pengeluaran yang melebihi saldo
                        if (model.jumlah_pengeluaran > saldo)
                        {
                            throw new InvalidOperationException("Saldo tidak mencukupi untuk pengeluaran ini.");
                        }
                    }
                }

                cmd.CommandText = @"
                    INSERT INTO pengeluaran_kas (tanggal_pengeluaran, jumlah_pengeluaran, keterangan, bukti_foto)
                    VALUES (@tanggal, @jumlah, @keterangan, @foto)";
                cmd.Parameters.AddWithValue("@tanggal", model.tanggal_pengeluaran);
                cmd.Parameters.AddWithValue("@jumlah", model.jumlah_pengeluaran);
                cmd.Parameters.AddWithValue("@keterangan", (object)model.keterangan ?? DBNull.Value);
                if (model.bukti_foto != null && model.bukti_foto.Length > 0)
                    cmd.Parameters.AddWithValue("@foto", model.bukti_foto);
                else
                    cmd.Parameters.AddWithValue("@foto", DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateBudget(BudgetModel model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            using (var conn = db.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    UPDATE pengeluaran_kas
                    SET tanggal_pengeluaran = @tanggal,
                        jumlah_pengeluaran = @jumlah,
                        keterangan = @keterangan,
                        bukti_foto = @foto
                    WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", model.id);
                cmd.Parameters.AddWithValue("@tanggal", model.tanggal_pengeluaran);
                cmd.Parameters.AddWithValue("@jumlah", model.jumlah_pengeluaran);
                cmd.Parameters.AddWithValue("@keterangan", (object)model.keterangan ?? DBNull.Value);
                if (model.bukti_foto != null && model.bukti_foto.Length > 0)
                    cmd.Parameters.AddWithValue("@foto", model.bukti_foto);
                else
                    cmd.Parameters.AddWithValue("@foto", DBNull.Value);

                conn.Open();
                int affected = cmd.ExecuteNonQuery();
                if (affected == 0)
                    throw new InvalidOperationException("Update failed: record not found.");
            }
        }

        public void DeleteBudget(int id)
        {
            using (var conn = db.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM pengeluaran_kas WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                int affected = cmd.ExecuteNonQuery();
                if (affected == 0)
                    throw new InvalidOperationException("Delete failed: record not found.");
            }
        }

        // added: return stored image (bukti_foto) for a given pengeluaran id
        public byte[] GetImage(int id)
        {
            using (var conn = db.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT bukti_foto FROM pengeluaran_kas WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                var result = cmd.ExecuteScalar();
                return result == null || result == DBNull.Value ? null : (byte[])result;
            }
        }
    }
}
