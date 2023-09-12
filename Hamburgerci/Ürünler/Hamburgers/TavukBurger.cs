using Hamburgerci.Ürünler.Hamburgers.HambugerMalzemeleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Ürünler.Hamburgers
{
    public class TavukBurger : Hamburger
    {
        public TavukBurger()
        {
            HambugerMalzemeleri = new List<Malzeme>() { new Domates(), new Soğan(), new Marul(), new CheddarPeyniri(), new Ketçap(), new Mayonez(), new TavukEti(), new HambugerEkmeği() };
            HazırlanmaSüresi = 5;
            BeğenilmeOranı = 60;
        }
    }
}
