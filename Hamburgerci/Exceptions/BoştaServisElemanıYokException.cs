using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Exceptions
{
    public class BoştaServisElemanıYokException:Exception
    {
        public BoştaServisElemanıYokException():base("Boşta Servis Elemanı Yok")
        {
            
        }
    }
}
