using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            OverloadingMethod om = new OverloadingMethod();

            Console.WriteLine(om.HelloWorld());
            Console.WriteLine(om.HelloWorld("Hello C#"));
            Console.WriteLine(om.HelloWorld("Hello C#", "Andi"));

            Console.WriteLine(om.HelloWorld(2));
        }
    }
}
