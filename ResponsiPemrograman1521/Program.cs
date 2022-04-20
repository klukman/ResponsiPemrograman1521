using System;

namespace ResponsiPemrograman1521
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan();

            karyawan.NIK = 190302123;
            karyawan.Nama = "Paijo";
            karyawan.GajiBulanan = 3000000;

            Karyawan karyawan2 = new Karyawan();

            karyawan2.NIK = 190302124;
            karyawan2.Nama = "Jono";
            karyawan2.GajiBulanan = 2000000;

            Console.WriteLine("No \tNIK/ Nama\t \t Gaji");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("1. {0}\t{1} \t \t {2} ", karyawan.NIK, karyawan.Nama, karyawan.GajiBulanan);
            Console.WriteLine("2. {0}\t{1} \t \t {2} ", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.WriteLine("\nAsyiiiiik kenaikan gaji 10%!!\n");

            Console.WriteLine("No \tNIK/Nama\t  \t Gaji");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", karyawan.NIK, karyawan.Nama, karyawan.GajiBulanan + (karyawan.GajiBulanan * 0.10));
            Console.WriteLine("2. \t{0} {1}\t\t{2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan + (karyawan2.GajiBulanan * 0.10));

            Console.ReadKey();
        }
    }
}

