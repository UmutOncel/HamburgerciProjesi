using Hamburgerci.Ürünler;
using Hamburgerci.Ürünler.Hamburgers;
using Hamburgerci.Ürünler.İçeceks;
using Hamburgerci.Ürünler.YanÜrüns;
using Hamburgerci.Ürünler.YanÜrüns.SoğanHalkaları;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Menüler
{
    public abstract class Menü
    {
        public İçecek İçecek { get; set; }
        public decimal Fiyat { get; set; }
        public decimal BüyükBoyFiyatFarkı { get; set; } = 20;
        public int MenüHazırlıkSüresi { get; set; }
        public List<Ürün> MenüÜrünleri { get; set; }
    }
}
