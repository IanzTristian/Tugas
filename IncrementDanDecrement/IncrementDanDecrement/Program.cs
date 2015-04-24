using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementDanDecrement
{
    class Program
    {
        static void Main(string[] args)
        {
            TesIncrementDanDecrement();
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
        static void TesIncrementDanDecrement()
        {
            int x = 1;
            int y = x + x++;
            Console.WriteLine("\nIncrement");
            Console.WriteLine(string.Format("\nHasilnya : {0}", y));
            Console.WriteLine(string.Format("Nilai x : {0}", x));
            Console.WriteLine(string.Format("Decrement : {0}", y--));


            x = 1;
            y = x + ++x;
            Console.WriteLine("\n\n\nDecrement");
            Console.WriteLine(string.Format("\nHasilnya : {0}", y));
            Console.WriteLine(string.Format("Nilai x : {0}", x));
            Console.WriteLine(string.Format("Decrement : {0}", --y));
           
        }
    }
}
