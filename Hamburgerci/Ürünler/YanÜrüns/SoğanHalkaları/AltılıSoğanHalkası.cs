using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Ürünler.YanÜrüns.SoğanHalkaları
{
    public class AltılıSoğanHalkası : SoğanHalkası
    {
        public AltılıSoğanHalkası() : base(SoğanHalkaSayısı.Altılı)
        {
            Fiyat = 15;
        }
    }
}
