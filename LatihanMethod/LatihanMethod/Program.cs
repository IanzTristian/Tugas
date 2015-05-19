using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //membuat object MethoidVoid
            MethodVoid mv = new MethodVoid();

            //invoke/panggilan method
            mv.HelloWorld();
            mv.InfoBuku("C# Fundamental", "Rudi");

            //membuat object MethodVoid
            MethodNonVoid mnv = new MethodNonVoid();

            //invoke pemanggilan method
            int hasil = mnv.penjumlahan(10, 5);
            Console.WriteLine("Hasil : {0}", hasil);

            double luas = mnv.LuasSegitiga(10, 5);
            Console.WriteLine("Hasil : {0}", luas);


            Console.ReadKey();
        }
    }
}
