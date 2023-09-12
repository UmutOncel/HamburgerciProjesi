using Hamburgerci.Menüler;
using Hamburgerci.Personeller;
using Hamburgerci.Ürünler.YanÜrüns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Interfaces
{
    public interface IMüşteri
    {
        Menü SiparişVer();
        YanÜrün YanÜrünSiparişVer();
        void SiparişiTeslimAl(ServisPersoneli servisPersoneli);
        void ToplamÜcretiÖde(KasaPersoneli kasaPersoneli, ÖdemeYöntemleri ödemeYöntemleri);
        void SıradaBekle();
    }
}
