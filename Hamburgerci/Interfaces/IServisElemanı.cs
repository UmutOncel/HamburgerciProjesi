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
    public interface IServisElemanı
    {
        void KasaPersonelindenSiparişiAl(KasaPersoneli kasaPersoneli);
        void KasaPersonelindenYanÜrünSiparişiniAl(KasaPersoneli kasaPersoneli);
        void MolayaÇık(object value);
        ServisPersoneli MoladanDön();
        Menü SiparişiHazırlaVeTeslimEt();
        YanÜrün YanÜrünSiparişiniHazırlaVeTeslimEt();
    }
}
