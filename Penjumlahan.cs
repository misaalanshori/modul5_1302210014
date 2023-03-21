using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210014
{
    internal class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic a1 = angka1;
            dynamic a2 = angka2;
            dynamic a3 = angka3;
            return a1 + a2 + a3;
        }
    }
}
