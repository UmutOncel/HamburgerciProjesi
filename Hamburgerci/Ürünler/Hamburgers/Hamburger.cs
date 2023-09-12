using Hamburgerci.Ürünler.Hamburgers.HambugerMalzemeleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Ürünler.Hamburgers
{
    public abstract class Hamburger : Ürün
    {
        public List<Malzeme> HambugerMalzemeleri { get; set; }
    }
}
