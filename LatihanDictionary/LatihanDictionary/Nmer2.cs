using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanDictionary
{
    class Nmer2
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictBio = new Dictionary<string,string>();
            dictBio.Add("name", "Erick");
            dictBio.Add("jobs", "Lecturer");
            dictBio.Add("city", "jogja");

            Console.WriteLine(dictBio["name"]);

            foreach (KeyValuePair<string, string> kvp in dictBio)
            {
                Console.WriteLine("Key :" + kvp.Key + " Value :" + kvp.Value);
                Console.ReadKey();
            }
        }
    }
}
