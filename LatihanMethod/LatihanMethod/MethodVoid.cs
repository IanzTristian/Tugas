using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
   public class MethodVoid
    {
       public void HelloWorld()
         {
                Console.WriteLine("Hello World");
         }
        public void InfoBuku(string Judul, String Pengarang)
         {
                Console.WriteLine("Judul {0}, Dibuat Oleh {1}", Judul, Pengarang);
         }     
    }
   
    public class MethodNonVoid
    {
        public int penjumlahan(int bil1, int bil2)
        {
            return bil1 + bil2;
        }

        public double LuasSegitiga(double alas, double tinggi)
        {
            double luas = 0.5 * alas * tinggi;
            return luas;
        }
    }
}
