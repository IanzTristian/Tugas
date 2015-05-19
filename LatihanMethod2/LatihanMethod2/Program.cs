using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 2;
            ParameterClass pc = new ParameterClass();
            /*
            int hasil = pc.Kali(a, b);
            Console.WriteLine("Hasil : {0}", hasil);
            Console.WriteLine("Bilangan 1 : {0}", a);
            Console.WriteLine("Bilangan 2 : {0}", b);
            */

            /*
            int hasil = pc.tambah(ref a, ref b);
            Console.WriteLine("Hasil  {0}", hasil);
            Console.WriteLine("Bilangan 1 : {0}", a);
            Console.WriteLine("Bilangan 2 : {0}", b);
            */
            string tipe = string.Empty;
            int hasil = pc.Kurang(a, b, out tipe);
            Console.WriteLine("Hasil : {0}", hasil);
            Console.WriteLine("Tipe : {0}", tipe);

            Console.ReadKey();
        }
    }
}
