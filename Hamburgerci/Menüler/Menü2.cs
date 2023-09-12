using Hamburgerci.Ürünler;
using Hamburgerci.Ürünler.Hamburgers;
using Hamburgerci.Ürünler.İçeceks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Menüler
{
    public class Menü2:Menü
    {
        public Menü2(İçecek içecek)
        {
            MenüÜrünleri = new List<Ürün>() { new DoubleTavukBurger(), new PatatesKızartması(Boyut.Normal) };
            İçecek = içecek;
            Fiyat = 100;
            MenüHazırlıkSüresi = 35;
        }
    }
}
