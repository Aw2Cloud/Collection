using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.ClassInduk
{
    public abstract class Karyawan
    {
        public abstract string Nama { get; set; }
        public abstract string Nik { get; set; }
        public virtual double Gaji()
        {
            return 0;
        }

    }
}
