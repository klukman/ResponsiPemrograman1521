using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrograman1521
{
    public class Karyawan
    {
        public int NIK { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            this.NIK = nik;
            this.Nama = nama;

            if (gaji < 0)
            {
                this.GajiBulanan = 0;
            }
            else
            {
                this.GajiBulanan = gaji;
            }

        }

        public Karyawan()
        {
        }
    }
}
