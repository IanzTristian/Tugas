using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoJumpStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //TesGoto();
            //TesBreak();
            TesContinue();
        }
        static void TesGoto()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                    goto berhenti;
            }
        berhenti:
            Console.WriteLine("\nProgram berhenti...");
        }
        static void TesBreak()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    Console.WriteLine("\nProgram berhenti...");
                    break;
                }
            }
        }
        static void TesContinue()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                    continue;

                Console.WriteLine(i);
            }
        }
    }
}
