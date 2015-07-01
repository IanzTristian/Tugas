using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplikasiBarang.DAL.Model
{
    public class Barang
    {
        public string BarangID { get; set; }
        public int KategoriID { get; set; }
        public string NamaBarang { get; set; }
        public int Harga { get; set; }
    }
}
