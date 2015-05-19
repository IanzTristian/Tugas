using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod2
{
   public class ParameterClass
   {
        //method by value
       public int Kali(int bil1, int bil2)
       {
           int hasil = bil1 * bil2;
           bil1 += 2;
           bil2 *= 2;

           return hasil;
       }
       //method by ref
       public int tambah (ref int bil1, ref int bil2)
       {
           int hasil = bil1 + bil2;
           bil1 += 2;
           bil2 *= 2;

           return hasil;
       }

       //output paramaters
       public int Kurang (int bil1, int bil2, out string tipe)
       {
           int hasil = bil1 - bil2;
           if (hasil < 0)
               tipe = "negatif";
           else
               tipe = "positif";

           return hasil;
       }
   }
}
