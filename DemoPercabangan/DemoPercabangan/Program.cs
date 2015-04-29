using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPercabangan
{
    class Program
    {
        static void Main(string[] args)
        {
            //TesIfTunggal();
            //TesIfDenganTernary();
            //TesIfMajemuk();
            TesIfMajemuk2();
        }
        static void TesIfTunggal()
        {
            Console.Write("Nilai Anda");
            int nilai = Convert.ToInt32(Console.ReadLine());

            var keterangan = string.Empty;

            if (nilai >= 60)
                keterangan = "Anda Lulus";
            else
                keterangan = "Anda Tidak Lulus";

            Console.WriteLine(keterangan + "\n");
        }

        static void TesIfDenganTernary()
        {
            Console.Write("Nilai Anda : ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            var keterangan = nilai >= 60 ? "Anda Lulus" : "Anda Tidak Lulus";

            Console.WriteLine(keterangan + "\n");
        }
        static void TesIfMajemuk()
        {
            Console.Write("Masukkan Nilai Angka : ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            var nilaiHuruf = string.Empty;

            if (nilai >= 80 && nilai <= 100)
                nilaiHuruf = "A";
            else if (nilai >= 70)
                nilaiHuruf = "B";
            else if (nilai >= 60)
                nilaiHuruf = "C";
            else if (nilai >= 45)
                nilaiHuruf = "D";
            else
                nilaiHuruf = "E";

            Console.WriteLine("Nilai Huruf : {0}\n", nilaiHuruf);
        }
        static void TesIfMajemuk2()
        {
            Console.WriteLine("Pilih Bahasa Pemrograman");
            Console.WriteLine("************************");
            Console.WriteLine("1. C#");
            Console.WriteLine("2. VB.NET");
            Console.WriteLine("3. PHP");

            Console.Write("\nMasukkan Pilihan Anda : ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            var keterangan = string.Empty;

            if (pilihan == 1)
                keterangan = "C#";
            else if (pilihan == 2)
                keterangan = "VB.NET";
            else if (pilihan == 3)
                keterangan = "PHP";
            else
                keterangan = "Pilihan anda tidak ada";
            Console.WriteLine("Anda Memilih : {0}\n", keterangan);
    
        }
    }
}
