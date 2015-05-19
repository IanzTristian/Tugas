using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    public class Kucing
    {
        private static int instances = 0;

        //Constructor : Method Khusus
        public Kucing()
        {
            instances++;
        }

        public static void BanyakKucing()
        {
           Console.WriteLine("Banyak Kucing : (0)", instances);
        }
    }
}
