using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DemoBoxingDanUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            TesStronglyTypedCollection();
            //TesBoxingDanUnboxing();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        static void TesBoxingDanUnboxing()
        {
            ArrayList arrBilangan = new ArrayList();

            arrBilangan.Add(12);
            arrBilangan.Add(32);
            arrBilangan.Add(24);

            for (int i = 0; i < arrBilangan.Count; i++)
            {
                int bil = (int)arrBilangan[i];

                Console.WriteLine(bil.ToString());
            }
        }

            
            
        static void TesStronglyTypedCollection()
        {
            List<int> listBilangan = new List<int>();
            listBilangan.Add(12);
            listBilangan.Add(32);
            listBilangan.Add(24);
            
            for (int i = 0; i < listBilangan.Count; i++)
            {
                int bil = (int)listBilangan[i];

                Console.WriteLine(bil.ToString());
            }
            
        }

        }

    
    }

