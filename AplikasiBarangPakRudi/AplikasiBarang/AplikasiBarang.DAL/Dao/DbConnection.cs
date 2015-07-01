using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace AplikasiBarang.DAL.Dao
{
    public class DbConnection
    {
        public static SqlConnection GetOpenConnection()
        {
            SqlConnection conn = null;

            try
            {
                var strConn = @"Data Source=.\sqlexpress2008;
                                Initial Catalog=Barang;Integrated Security=True";

                conn = new SqlConnection(strConn);
                conn.Open();

            }
            catch
            {
            }

            return conn;
        }
    }
}
