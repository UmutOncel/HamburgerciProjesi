using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hamburgerci.Menüler;
using Hamburgerci.Exceptions;
using Hamburgerci.Ürünler.İçeceks;
using Hamburgerci.Ürünler;
using Hamburgerci.Interfaces;
using Hamburgerci.Ürünler.Hamburgers;
using Hamburgerci.Ürünler.Hamburgers.HambugerMalzemeleri;
using Hamburgerci.Ürünler.YanÜrüns;

namespace Hamburgerci.Personeller
{
    public class KasaPersoneli:Personel, IKasaPersoneli
    {
        private bool büyükBoyMu;
        private bool servisElemanlarıBoşMu;
        private bool büyükBoyİsterMisin;
        private bool yanÜrünİsterMisin;
        private bool yanÜrünVarMı;
        private List<Menü> Siparişler;
        private List<YanÜrün> YanÜrünSiparişleri;

        public KasaPersoneli():base(Görev.KasaPersoneli)
        {
            Siparişler = new List<Menü>();
            YanÜrünSiparişleri = new List<YanÜrün>();
        }

        public Kasa Kasa { get; set; }

        public void MüşteridenSiparişAl(Müşteri müşteri) 
        {
            if (!servisElemanlarıBoşMu)
            {
                throw new BoştaServisElemanıYokException();
            }
            if (büyükBoyİsterMisin)
            {
                İçecekVePatatesKızartmasıBoyutunuDeğiştir(müşteri.SiparişVer());
            }
            Siparişler.Add(müşteri.SiparişVer());
            Kasa.GünlükRapor.Add(müşteri.SiparişVer());
        }

        public void MüşteridenYanÜrünSiparişiAl(Müşteri müşteri) 
        {
            YanÜrünSiparişleri.Add(müşteri.YanÜrünSiparişVer());
            Kasa.YanÜrünGünlükRapor.Add(müşteri.YanÜrünSiparişVer());
        }

        public Menü Siparişiİlet() 
        {
            if (Siparişler.Count == 0)
            {
                throw new YeniSiparişYokException();
            }
            Menü güncelSipariş = Siparişler[0];
            Siparişler.Remove(güncelSipariş);
            return güncelSipariş;
        }

        public YanÜrün YanÜrünSiparişiİlet()
        {
            if (YanÜrünSiparişleri.Count == 0)
            {
                throw new YeniSiparişYokException();
            }
            YanÜrün güncelSipariş = YanÜrünSiparişleri[0];
            YanÜrünSiparişleri.Remove(güncelSipariş);
            return güncelSipariş;
        }

        public decimal ToplamÜcretiAl(Menü menü, YanÜrün yanÜrün) 
        {
            decimal fiyat = menü.Fiyat;
            if (büyükBoyMu)
            {
                fiyat += menü.BüyükBoyFiyatFarkı;
            }
            if (yanÜrünVarMı)
            {
                fiyat += yanÜrün.Fiyat;
            }
            return fiyat;
        }

        public void İçecekVePatatesKızartmasıBoyutunuDeğiştir(Menü menü) 
        {
            menü.İçecek.ÜrünBoyutu = Boyut.Büyük;
            menü.MenüÜrünleri[1].ÜrünBoyutu = Boyut.Büyük;
        }
        
        public void MenüdenÜrünÇıkar(Hamburger hamburger, Malzeme malzeme) 
        {
            if (hamburger.HambugerMalzemeleri.Contains(malzeme))
            {
                hamburger.HambugerMalzemeleri.Remove(malzeme);
            }
            else
            {
                throw new HamburgerİçindeBuMalzemeYokException();
            }
        }
    }
}
