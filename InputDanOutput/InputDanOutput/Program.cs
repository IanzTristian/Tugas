using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputDanOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInput Data Siswa\n");

            Console.Write("Nis \t:");
            string Nis = Console.ReadLine();

            Console.Write("Nama\t:");
            string Nama = Console.ReadLine();

            Console.Write("Nilai\t:");
            int Nilai = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(string.Format("\nNis : {0}, Nama : {1}, Nilai : {2}",Nis, Nama, Nilai));

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
