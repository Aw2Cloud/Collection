using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Collection.ClassInduk;

namespace Collection.ClassAnak
{
    public class Sales : Karyawan
    {
        public override string Nama { get; set; }
        public override string Nik { get; set; }
        public double JumlahPenjualan;
        public double Komisi;
        public override double Gaji()
        {
            Komisi = Komisi * JumlahPenjualan;
            return Komisi;
        }
    }
}
