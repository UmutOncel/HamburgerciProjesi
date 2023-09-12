using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Ürünler
{
    public class PatatesKızartması:Ürün
    {
        public PatatesKızartması(Boyut ürünBoyutu)
        {
            HazırlanmaSüresi = 10;
            ÜrünBoyutu = ürünBoyutu;
            BeğenilmeOranı = 90;
        }
    }
}
