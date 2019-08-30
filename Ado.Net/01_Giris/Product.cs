using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Giris
{
    class Product
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal BirimFiyat { get; set; }
        public short Stok { get; set; }
        public bool SatisiDevamEdiyorMu { get; set; }
        public override string ToString()
        {
            return Ad;
        }
    }
}
