using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Giris
{
    class Bagci
    {
        private static string _baglantiCumlecigi = "server=.;database=Northwind;user id = sa; password=12345";
        public static string BaglantiCumlecigi
        {
            get
            {
                return _baglantiCumlecigi;
            }

        }
    }
}
