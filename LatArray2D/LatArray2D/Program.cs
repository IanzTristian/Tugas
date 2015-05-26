using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatArray2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[3, 2];

            matrix1[0, 0] = 12;
            matrix1[0, 1] = 23;
            matrix1[1, 0] = 14;
            matrix1[1, 1] = 45;
            matrix1[2, 0] = 15;
            matrix1[2, 1] = 11;

            for (int b = 0; b < 3; b++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write(matrix1[b, k] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
