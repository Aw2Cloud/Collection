using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Collection.ClassInduk;

namespace Collection.ClassAnak
{
    public class KaryawanHarian : Karyawan
    {
        public override string Nama { get; set; }
        public override string Nik { get; set; }
        public double UpahPerJam { get; set; }
        public double JumlahPerJam { get; set; }

        public override double Gaji()
        {
            UpahPerJam = UpahPerJam* JumlahPerJam;
            return UpahPerJam;
        }
        
    }
}
