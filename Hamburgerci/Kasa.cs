using Hamburgerci.Menüler;
using Hamburgerci.Personeller;
using Hamburgerci.Ürünler.YanÜrüns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci
{
    public class Kasa
    {
        private List<Menü> günlükRapor;
        private List<YanÜrün> yanÜrünGünlükRapor;
        public Kasa()
        {
            günlükRapor = new List<Menü>();
            yanÜrünGünlükRapor = new List<YanÜrün>();
        }
        public List<Menü> GünlükRapor 
        { 
            get { return this.günlükRapor; } 
            set { this.günlükRapor = value; } 
        }

        public List<YanÜrün> YanÜrünGünlükRapor 
        { 
            get { return this.yanÜrünGünlükRapor; } 
            set { this.yanÜrünGünlükRapor = value; } 
        }
        public List<KasaPersoneli> KasaPersonelleri { get; set; }
    }
}
