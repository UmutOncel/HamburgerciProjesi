using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Ürünler.YanÜrüns.SoğanHalkaları
{
    public abstract class SoğanHalkası : YanÜrün
    {
        public SoğanHalkaSayısı SoğanHalkaSayısı { get; set; }
        public SoğanHalkası(SoğanHalkaSayısı soğanHalkaSayısı)
        {
            SoğanHalkaSayısı = soğanHalkaSayısı;
        }
    }
}
