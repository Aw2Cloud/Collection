using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Collection.ClassInduk;
using Collection.ClassAnak;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Inheritance, Polymorphsim, Abstraction & Collection";

            KaryawanTetap KaryawanTetap = new KaryawanTetap();
            KaryawanTetap.Nik = "123-234-345";
            KaryawanTetap.Nama = "Michael Suyama";
            KaryawanTetap.GajiBulanan = 4000000;

            KaryawanHarian KaryawanHarian = new KaryawanHarian();
            KaryawanHarian.Nik = "234-345-456";
            KaryawanHarian.Nama = "Laura Callahan";
            KaryawanHarian.UpahPerJam = 13000;
            KaryawanHarian.JumlahPerJam = 8;

            Sales Sales = new Sales();
            Sales.Nik = "345-456-567";
            Sales.Nama = "Andrew Fuller";
            Sales.JumlahPenjualan = 30;
            Sales.Komisi = 45000;

            List<Karyawan> ListKaryawan = new List<Karyawan>();
            ListKaryawan.Add(KaryawanTetap);
            ListKaryawan.Add(KaryawanHarian);
            ListKaryawan.Add(Sales);

            int No = 1;

            foreach (Karyawan Karyawan in ListKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1} Nama: {2} \tGaji: {3}",
                    No, Karyawan.Nik, Karyawan.Nama,Karyawan.Gaji());
                No++;
            }
            Console.ReadKey();
        }
    }
}
