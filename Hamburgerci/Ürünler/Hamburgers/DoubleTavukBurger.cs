using Hamburgerci.Ürünler.Hamburgers.HambugerMalzemeleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Ürünler.Hamburgers
{
    public class DoubleTavukBurger : Hamburger
    {
        public DoubleTavukBurger()
        {
            HambugerMalzemeleri = new List<Malzeme>() { new Domates(), new Soğan(), new Marul(), new CheddarPeyniri(), new Ketçap(), new Mayonez(), new TavukEti(), new TavukEti(), new HambugerEkmeği() };
            HazırlanmaSüresi = 10;
            BeğenilmeOranı = 70;
        }
    }
}
