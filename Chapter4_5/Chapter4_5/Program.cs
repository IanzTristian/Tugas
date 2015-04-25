using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama = "Erick";
            Console.WriteLine(nama is string);
            Console.WriteLine(nama is object);
            Console.WriteLine(nama is char);

            Mahasiswa mhs = new Mahasiswa();
            Console.WriteLine(mhs is Siswa);
            Console.WriteLine(mhs is Mahasiswa);
            Console.WriteLine(mhs is Random);

            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "23080008";
            mhs1.Nama = "Erick";
            Siswa s1 = mhs1 as Siswa;
            Console.WriteLine(s1.Nama);

            object s2 = new Siswa();
            string strSiswa = s2 as string;
            Console.WriteLine(strSiswa == null ? "null" : "tidak Null");

        }
    }
}
