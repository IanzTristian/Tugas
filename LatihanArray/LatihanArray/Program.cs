using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrNama = { "erick", "wely", "sony", "joni" };
            Console.WriteLine(arrNama[2].ToString());
            for (int i = 0; i < arrNama.Length; i++) {
                Console.WriteLine(arrNama[i]);

        }
            foreach (string nama in arrNama)
            {
                Console.WriteLine(nama);
            }
            int[] arrBil = new int [3];
            arrBil[0] = 12;
            arrBil[1] = 14;
            arrBil[2] = 24;
            foreach (int bil in arrBil)
            {
                Console.WriteLine(bil.ToString());
            }
            
    }
    }
    }

