using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            int j = 123;
            Console.WriteLine(i == j);
            Console.WriteLine((object)i == (object)j);
            
            Mahasiswa mhs1 = new Mahasiswa();
            Mahasiswa mhs2 = new Mahasiswa();
            mhs1.Nim = "23080008";
            mhs1.Nama = "Erick";
            mhs2.Nim = "23080008";
            mhs2.Nama = "Erick";
            Console.WriteLine(mhs1 == mhs2);

            Mahasiswa mhs3 = mhs1;
            Console.WriteLine(mhs1 == mhs3);
            Console.WriteLine(mhs2 == mhs3);

            Mahasiswa mhs4 = null, mhs5 = null;
            Console.WriteLine(mhs4 == mhs5);
        }
    }
}
