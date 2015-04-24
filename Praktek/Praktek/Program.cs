using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktek
{
    class Program
    {
        static void Main(string[] args)
        {
            TesTipeDasar();
            Console.WriteLine("\nPres Any Key To Exit...");
            Console.ReadKey();
        }

        static void TesTipeDasar()
        {
            int bill = 12;
            int bil2 = bill;

            Console.WriteLine("bil2=" + bil2);
            bil2 = 23;

            Console.WriteLine("bill=" + bill);

        }
    }
}
