using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoImplicitVsExplicitConvertion
{
    class Program
    {
        static void TesImplicitConvertion()
        {
        int bil1 = 12;
        float bil2 = bil1;

        Console.WriteLine("Bilangan 2 : "+ bil2);
    }
    
       
        static void Main(string[] args)
        {
            TesImplicitConvertion();

            Console.WriteLine("\nPress any Key to exit");
            Console.ReadKey();
        }
        
    }
}
