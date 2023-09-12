using Hamburgerci.Ürünler.Hamburgers.HambugerMalzemeleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Ürünler.Hamburgers
{
    public class KöfteBurger : Hamburger
    {
        public KöfteBurger()
        {
            HambugerMalzemeleri = new List<Malzeme>() { new Domates(), new Soğan(), new Marul(), new CheddarPeyniri(), new Ketçap(), new Mayonez(), new Köfte(), new HambugerEkmeği() };
            HazırlanmaSüresi = 20;
            BeğenilmeOranı = 80;
        }
    }
}
