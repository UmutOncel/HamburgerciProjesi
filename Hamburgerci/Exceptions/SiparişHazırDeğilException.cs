using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Exceptions
{
    public class SiparişHazırDeğilException:Exception
    {
        public SiparişHazırDeğilException():base("Sipariş Hazır Değil")
        {
            
        }
    }
}
