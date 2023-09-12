using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Ürünler.YanÜrüns.SoğanHalkaları
{
    public class DörtlüSoğanHalkası : SoğanHalkası
    {
        public DörtlüSoğanHalkası() : base(SoğanHalkaSayısı.Dörtlü)
        {
            Fiyat = 10;
        }
    }
}
