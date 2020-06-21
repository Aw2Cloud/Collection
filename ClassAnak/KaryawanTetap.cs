using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Collection.ClassInduk;

namespace Collection.ClassAnak
{
    public class KaryawanTetap : Karyawan
    {
        public override string Nik { get; set; }
        public override string Nama { get; set; }
        public double GajiBulanan;
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}
