using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LatArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrBil = new ArrayList();
            arrBil.Add(12);
            arrBil.Add(14);
            arrBil.Add(17);

            Console.WriteLine(arrBil[2].ToString());
            foreach (int bil in arrBil)
            {
                Console.WriteLine(bil.ToString());
            }
        }
    }
}
