using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Ürünler.İçeceks
{
    public abstract class İçecek:Ürün
    {
        public Tip İçecekTipi { get; set; }
    }
}
