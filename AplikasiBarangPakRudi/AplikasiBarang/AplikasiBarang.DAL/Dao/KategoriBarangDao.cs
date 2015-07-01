using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using AplikasiBarang.DAL.Model;

namespace AplikasiBarang.DAL.Dao
{
    public class KategoriBarangDao
    {
        public int Save(KategoriBarang kategori)
        {
            var result = 0;

            try
            {
                using (var conn = DbConnection.GetOpenConnection())
                {
                    var sql = @"INSERT INTO KategoriBarang (KategoriID, NamaKategori)
                            VALUES (@1, @2)";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@1", kategori.KategoriID);
                        cmd.Parameters.AddWithValue("@2", kategori.NamaKategori);

                        result = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
            }

            return result;
        }

        public int Update(KategoriBarang kategori)
        {
            var result = 0;

            using (var conn = DbConnection.GetOpenConnection())
            {
                var sql = @"UPDATE KategoriBarang SET NamaKategori = @1
                            WHERE KategoriID = @2";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@1", kategori.NamaKategori);
                    cmd.Parameters.AddWithValue("@2", kategori.KategoriID);

                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }

        public int Delete(KategoriBarang kategori)
        {
            var result = 0;

            using (var conn = DbConnection.GetOpenConnection())
            {
                var sql = @"DELETE FROM KategoriBarang
                            WHERE KategoriID = @1";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@1", kategori.KategoriID);

                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }

        public KategoriBarang GetByID(int kategoriID)
        {
            KategoriBarang kategori = null;

            using (var conn = DbConnection.GetOpenConnection())
            {
                var sql = @"SELECT KategoriID, NamaKategori 
                            FROM KategoriBarang
                            WHERE KategoriID = @1";

                using (var cmd = new SqlCommand(sql, conn))
                {

                    cmd.Parameters.AddWithValue("@1", kategoriID);

                    using (var dtr = cmd.ExecuteReader())
                    {
                        if (dtr.Read())
                        {
                            kategori = new KategoriBarang();
                            kategori.KategoriID = dtr["KategoriID"] is DBNull ? 0 : Convert.ToInt32(dtr["KategoriID"]);
                            kategori.NamaKategori = dtr["NamaKategori"] is DBNull ? string.Empty : dtr["NamaKategori"].ToString();
                        }
                    }
                }
            }

            return kategori;
        }

        public List<KategoriBarang> GetAll()
        {
            var daftarKategori = new List<KategoriBarang>();

            using (var conn = DbConnection.GetOpenConnection())
            {
                var sql = @"SELECT KategoriID, NamaKategori 
                            FROM KategoriBarang
                            ORDER BY NamaKategori";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            // proses mapping
                            KategoriBarang kategori = new KategoriBarang();
                            kategori.KategoriID = dtr["KategoriID"] is DBNull ? 0 : Convert.ToInt32(dtr["KategoriID"]);
                            kategori.NamaKategori = dtr["NamaKategori"] is DBNull ? string.Empty : dtr["NamaKategori"].ToString();

                            // tampung ke dalam objek collection
                            daftarKategori.Add(kategori);
                        }
                    }
                }
            }

            return daftarKategori;
        }

        public List<KategoriBarang> GetByName(string namaKategori)
        {
            var daftarKategori = new List<KategoriBarang>();

            using (var conn = DbConnection.GetOpenConnection())
            {
                var sql = @"SELECT * FROM KategoriBarang 
                            WHERE NamaKategori LIKE @1
                            ORDER BY NamaKategori";

                // select * from KategoriBarang where namakategori like '%tea%'

                using (var cmd = new SqlCommand(sql, conn))
                {

                    cmd.Parameters.AddWithValue("@1", "%" + namaKategori + "%");

                    using (var dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var kategori = new KategoriBarang
                            {
                                KategoriID = dtr["KategoriID"] is DBNull ? 0 : Convert.ToInt32(dtr["KategoriID"]),
                                NamaKategori = dtr["NamaKategori"] is DBNull ? string.Empty : dtr["NamaKategori"].ToString()
                            };

                            daftarKategori.Add(kategori);
                        }
                    }
                }
            }

            return daftarKategori;
        }
    }
}
