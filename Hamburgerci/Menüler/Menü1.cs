using Hamburgerci.Ürünler;
using Hamburgerci.Ürünler.Hamburgers;
using Hamburgerci.Ürünler.İçeceks;
using Hamburgerci.Ürünler.YanÜrüns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Menüler
{
    public class Menü1:Menü
    {
        public Menü1(İçecek içecek)
        {
            MenüÜrünleri = new List<Ürün>() { new TavukBurger(), new PatatesKızartması(Boyut.Normal) };
            İçecek = içecek;
            Fiyat = 90;
            MenüHazırlıkSüresi = 30;
        }
    }
}
