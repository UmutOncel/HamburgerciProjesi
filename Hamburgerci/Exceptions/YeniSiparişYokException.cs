using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Exceptions
{
    public class YeniSiparişYokException:Exception
    {
        public YeniSiparişYokException():base("Yeni Sipariş Yok")
        {
            
        }
    }
}
