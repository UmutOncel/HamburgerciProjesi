using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Ürünler.İçeceks
{
    public class Fanta:İçecek
    {
        public Fanta(Boyut ürünBoyutu, Tip içecekTipi)
        {
            HazırlanmaSüresi = 1;
            ÜrünBoyutu = ürünBoyutu;
            İçecekTipi = içecekTipi;
            BeğenilmeOranı = 40;
        }
    }
}
