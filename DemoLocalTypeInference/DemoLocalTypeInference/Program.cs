using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLocalTypeInference
{
    class Program
    {
        static void Main(string[] args)
        {
            TesEnumeration();

            Console.WriteLine("\nPres any key to exit...");
            Console.ReadKey();
        }
        enum Warna
        {
            Merah, Biru, Kuning
        }
        static void TesEnumeration()
        {
            Warna warna = Warna.Merah;

            switch (warna)
            {
                case Warna.Merah:
                    Console.WriteLine("warna.Merah");
                    break;

                case Warna.Kuning:
                    Console.WriteLine("warna.Kuning");
                    break;
                case Warna.Biru:
                    Console.WriteLine("warna.Biru");
                    break;

                default:
                    break;
            }
        }
           
        }
    }


