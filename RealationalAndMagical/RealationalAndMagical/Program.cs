using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealationalAndMagical
{
    class Program
    {
        static void Main(string[] args)
        {
           //TesRealational();
           TesLogical();


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
        static void TesRealational()
        {
            int i, j;

            i = 10;
            j = 11;

            Console.WriteLine("i < j = " + (i < j));
            Console.WriteLine("i <= j =" + (i <= j ));
            Console.WriteLine("i != j = " + (i != j));

            Console.WriteLine("i == j = {0}", i == j);
            Console.WriteLine("i >= j = {0}", i >= j);
            Console.WriteLine("i > j = {0}", i > j);

        }
        static void TesLogical()
        {
            bool b1 = true, b2 = false, b3 = true, b4 = false;

            Console.WriteLine("b1 & b2 & b3 & b4 = {0}", b1 & b2 & b3 & b4);
            Console.WriteLine("b1 | b2 | b3 | b4 = {0}", b1 | b2 | b3 | b4);
            Console.WriteLine("b1 && b2 && b3 && b4 = {0}", b1 && b2 && b3 && b4);
            Console.WriteLine("b1 || b2 || b3 || b4 = {0}", b1 || b2 || b3 || b4);
            Console.WriteLine("!(b1 & b2) = {0}", !(b1 & b2));
        }
    }
}
