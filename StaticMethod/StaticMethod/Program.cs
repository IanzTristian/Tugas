using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Kucing kucing1 = new Kucing();
            Kucing.BanyakKucing();

            Kucing kucing2 = new Kucing();
            Kucing kucing3 = new Kucing();

            Kucing.BanyakKucing();

        }
    }
}
