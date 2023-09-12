using Hamburgerci.Ürünler.Hamburgers;
using Hamburgerci.Ürünler.İçeceks;
using Hamburgerci.Ürünler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Menüler
{
    public class Menü3:Menü
    {
        public Menü3(İçecek içecek)
        {
            MenüÜrünleri = new List<Ürün>() { new KöfteBurger(), new PatatesKızartması(Boyut.Normal) };
            İçecek = içecek;
            Fiyat = 130;
            MenüHazırlıkSüresi = 40;
        }
    }
}
