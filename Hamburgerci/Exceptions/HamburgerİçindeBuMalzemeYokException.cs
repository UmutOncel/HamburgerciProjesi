using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Exceptions
{
    internal class HamburgerİçindeBuMalzemeYokException:Exception
    {
        public HamburgerİçindeBuMalzemeYokException():base("Hamburger İçinde Bu Malzeme Yok")
        {
            
        }
    }
}
