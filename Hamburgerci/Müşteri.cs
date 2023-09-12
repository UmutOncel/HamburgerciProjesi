using Hamburgerci.Menüler;
using Hamburgerci.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hamburgerci.Interfaces;
using Hamburgerci.Ürünler.YanÜrüns;

namespace Hamburgerci
{
    public class Müşteri: IMüşteri
    {
        public Menü MenüTipi { get; set; }
        public Menü Siparişim { get; set; }
        public YanÜrün YanÜrünTipi { get; set; }
        public decimal MüşteriParası { get; set; }
        public decimal KrediKartıBakiyesi { get; set; }

        public Menü SiparişVer() 
        {
            return this.MenüTipi;
        }

        public YanÜrün YanÜrünSiparişVer() 
        {
            return this.YanÜrünTipi;
        }

        public void ToplamÜcretiÖde(KasaPersoneli kasaPersoneli, ÖdemeYöntemleri ödemeYöntemleri) 
        {
            if (ödemeYöntemleri == ÖdemeYöntemleri.Nakit)
            {
                this.MüşteriParası -= kasaPersoneli.ToplamÜcretiAl(Siparişim, YanÜrünTipi);
            }
            else
            {
                this.KrediKartıBakiyesi -= kasaPersoneli.ToplamÜcretiAl(Siparişim, YanÜrünTipi);
            }
        }

        public void SiparişiTeslimAl(ServisPersoneli servisPersoneli) 
        {
            this.Siparişim = servisPersoneli.SiparişiHazırlaVeTeslimEt();
        }

        public void SıradaBekle() 
        { 
        }
    }
}
