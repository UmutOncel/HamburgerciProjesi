using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Ürünler
{
    public abstract class Ürün
    {
        public int HazırlanmaSüresi { get; set; }
        public int BeğenilmeOranı { get; set; }
        public Boyut ÜrünBoyutu { get; set; }
    }
}
