using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPerulangan
{
    class Program
    {
        static void Main(string[] args)
        {
            //TesWhile();
            //TesDoWhile();
            //TesFor();
            //TesForeach();
            TesFor2();
        }
        static void TesWhile()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void TesDoWhile()
        {
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
        }

        static void TesFor()
        {
            for (int i = 1; i <=10; i++)
            {
                if (i % 2 == 0)
            Console.WriteLine(i);
            }
        }

        static void TesForeach()
        {
            string[] arrNama = { "Erick", "Jhony", "Budy", "Dhonny" };
            foreach (string nama in arrNama)
            {
                Console.WriteLine(nama);
            }
        }
        static void TesFor2()
        {
             string[] arrNama = { "Erick", "Jhony", "Budy", "Dhonny" };
             for (int i = 0; i <arrNama.Length; i++)
            
             {
                 Console.WriteLine(arrNama[i]);

             }
           
        }

    }
}
