using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanListT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lstNama = new List<string>();
            lstNama.Add("erick");
            lstNama.Add("welly");
            lstNama.Add("rully");

            lstNama.RemoveAt(1);
            foreach(string nama in lstNama)
            {
                Console.WriteLine(nama);
            }
        }
    }
}
