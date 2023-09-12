using Hamburgerci.Ürünler.Hamburgers.HambugerMalzemeleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Ürünler.Hamburgers
{
    public class DoubleKöfteBurger : Hamburger
    {
        public DoubleKöfteBurger()
        {
            //string v = null;
            //bool geçerli = v.GetType() == typeof(HambugerEkmeği);
            // v'nin tipi HambugerEkmeği mi onu sorguluyoruz. Doğru ise bool geçerli'nin değeri true oluyor.
            // GetType değişkenin hangi class ait olduğunu döndürür.
            // TypeOf tipi bu class mı onu döndürür.


            HambugerMalzemeleri = new List<Malzeme>() { new Domates(), new Soğan(), new Marul(), new CheddarPeyniri(), new Ketçap(), new Mayonez(), new Köfte(), new Köfte(), new HambugerEkmeği() };
            HazırlanmaSüresi = 30;
            BeğenilmeOranı = 80;
        }
    }
}
