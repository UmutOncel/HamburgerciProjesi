using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Personeller
{
    public abstract class Personel
    {
        public Görev Görev { get; set; }

        public Personel(Görev görev)
        {
            Görev = görev;
        }
    }
}
