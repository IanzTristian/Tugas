using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSukuBungaPelanggan
{
    class Program
    {
        static void Main(string[] args)
    {
        DemoSukuBungaPelanggan();
    }
   
        
        static void DemoSukuBungaPelanggan()
        {
            Console.Write("Masukkan Peringkat anda : ");
            string Peringkat = Console.ReadLine().ToUpper();

            float SukuBunga = 0.00F;

            if (Peringkat == "A" || Peringkat == "B")
                SukuBunga = 0.11F;
            else if (Peringkat == "C")
                SukuBunga = 0.15F;
            else if (Peringkat == "D")
                SukuBunga = 0.17F;
            else if (Peringkat == "E")
                SukuBunga = 0.19F;
            else
                SukuBunga = 0.21F;

            Console.WriteLine("Suku Bunga Anda adalah: {0}%\n", SukuBunga * 100);
        }
    }
}
