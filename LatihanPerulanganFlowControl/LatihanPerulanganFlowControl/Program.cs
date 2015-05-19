using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPerulanganFlowControl
{
    class Program
    {
        static void For()
        {
            Console.Write("Masukan Data Yang Ingin Di Masukan : ");
            int jumlah = Convert.ToInt32(Console.ReadLine());
            string[] nama = new string [jumlah];


            for (int i = 0; i < nama.Length;i++)
            {
                Console.Write("Data ke #{0}, Nama = ", i + 1);
                nama[i] = Console.ReadLine();
            }

            Console.WriteLine("\nDaftar yang sudah di dinputkan :");

            for (int i = 0; i < nama.Length; i++)
            {
               Console.WriteLine("{0}.{1}", i+1, nama[i]);
            }
        }
        
        static void TestWhile ()
        {
            Console.Write("Masukan Data Yang Ingin Di Masukan : ");
            int jumlah = Convert.ToInt32(Console.ReadLine()); 
            string[] nama = new string [jumlah];
            int i = 0;

            while (i  < nama.Length) 
            {
                Console.Write("Data ke #{0}, Nama = ", i+ 1);
                nama[i] = Console.ReadLine();
                i++;
            }

            Console.WriteLine("\nDaftar yang sudah di dinputkan :");
            
           i =  nama.Length - 1;
           while (i >= 0)
           {
               Console.WriteLine("{0}.{1}", i + 1, nama[i]);
               i--;
           }     

        }

        static void Main(string[] args)
        {
            TestWhile();
           //For();
           Console.ReadKey();
        }
    }
}
