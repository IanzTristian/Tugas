using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            TesSwicth();
        }
        static void TesSwicth()
        {
            Console.WriteLine("Pilih Bahasa Pemrograman");
            Console.WriteLine("************************");
            Console.WriteLine("1. C#");
            Console.WriteLine("2. VB.NET");
            Console.WriteLine("3. PHP");

            Console.Write("\nMasukkan Pilihan Anda : ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            var keterangan = string.Empty;

            switch (pilihan)
            {
                case 1:
                    keterangan = "C";
                    break;

                case 2:
                    keterangan = "VB.NET";
                    break;

                case 3:
                    keterangan = "PHP";
                    break;
                default:
                    keterangan = "Pilihan anda tidak ada";
                    break;
            }
            Console.WriteLine("Anda Memilih : {0}\n", keterangan);
        }
    }
}
