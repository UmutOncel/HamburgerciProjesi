using Hamburgerci.Menüler;
using Hamburgerci.Ürünler.Hamburgers.HambugerMalzemeleri;
using Hamburgerci.Ürünler.Hamburgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hamburgerci.Ürünler.YanÜrüns;

namespace Hamburgerci.Interfaces
{
    public interface IKasaPersoneli
    {
        void MüşteridenSiparişAl(Müşteri müşteri);
        void MüşteridenYanÜrünSiparişiAl(Müşteri müşteri);
        Menü Siparişiİlet();
        YanÜrün YanÜrünSiparişiİlet();
        decimal ToplamÜcretiAl(Menü menü, YanÜrün yanÜrün);
        void İçecekVePatatesKızartmasıBoyutunuDeğiştir(Menü menü);
        void MenüdenÜrünÇıkar(Hamburger hamburger, Malzeme malzeme);
    }
}
