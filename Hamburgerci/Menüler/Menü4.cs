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
    public class Menü4:Menü
    {
        public Menü4(İçecek içecek)
        {
            MenüÜrünleri = new List<Ürün>() { new DoubleKöfteBurger(), new PatatesKızartması(Boyut.Normal) };
            İçecek = içecek;
            Fiyat = 150;
            MenüHazırlıkSüresi = 45;
        }
    }
}
