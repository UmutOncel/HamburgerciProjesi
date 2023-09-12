using Hamburgerci.Exceptions;
using Hamburgerci.Interfaces;
using Hamburgerci.Menüler;
using Hamburgerci.Ürünler.YanÜrüns;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Personeller
{
    public class ServisPersoneli:Personel, IServisElemanı
    {
        private bool siparişHazırMı;
        private bool yanÜrünSiparişiHazırMı;
        private List<Menü> ServisBölümüSiparişleri;
        private List<YanÜrün> ServisBölümüYanÜrünSiparişleri;
        public ServisPersoneli():base(Görev.ServisPersoneli)
        {
            ServisBölümüSiparişleri = new List<Menü>();
            ServisBölümüYanÜrünSiparişleri = new List<YanÜrün>();
        }

        public void KasaPersonelindenSiparişiAl(KasaPersoneli kasaPersoneli) 
        {
            try
            {
                ServisBölümüSiparişleri.Add(kasaPersoneli.Siparişiİlet());
            }
            catch (YeniSiparişYokException)
            {
                MolayaÇık(this);
            }
        }

        public void KasaPersonelindenYanÜrünSiparişiniAl(KasaPersoneli kasaPersoneli)
        {
            try
            {
                ServisBölümüYanÜrünSiparişleri.Add(kasaPersoneli.YanÜrünSiparişiİlet());
            }
            catch (YeniSiparişYokException)
            {
                MolayaÇık(this);
            }
        }

        public ServisPersoneli MoladanDön()
        {
            ServisPersoneli servisPersoneli = new ServisPersoneli();
            return servisPersoneli;
        }

        public void MolayaÇık(object value) 
        {
            value = null;
        }

        public Menü SiparişiHazırlaVeTeslimEt() 
        {
            if (ServisBölümüSiparişleri.Count == 0)
            {
                throw new YeniSiparişYokException();
            }
            if (siparişHazırMı)
            {
                Menü hazırSipariş = ServisBölümüSiparişleri[0];
                ServisBölümüSiparişleri.Remove(hazırSipariş);
                return hazırSipariş;
            }
            else
            {
                throw new SiparişHazırDeğilException();
            }
        }

        public YanÜrün YanÜrünSiparişiniHazırlaVeTeslimEt()
        {
            if (ServisBölümüYanÜrünSiparişleri.Count == 0)
            {
                throw new YeniSiparişYokException();
            }
            if (yanÜrünSiparişiHazırMı)
            {
                YanÜrün hazırSipariş = ServisBölümüYanÜrünSiparişleri[0];
                ServisBölümüYanÜrünSiparişleri.Remove(hazırSipariş);
                return hazırSipariş;
            }
            else
            {
                throw new SiparişHazırDeğilException();
            }
        }
    }
}
