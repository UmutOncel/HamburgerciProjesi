using Hamburgerci.Menüler;
using Hamburgerci.Personeller;
using Hamburgerci.Ürünler;
using Hamburgerci.Ürünler.Hamburgers;
using Hamburgerci.Ürünler.İçeceks;

namespace Hamburgerci
{
    public class Class1
    {
        void Deneme() 
        {
            TavukBurger burger1 = new TavukBurger();

            PatatesKızartması patates = new PatatesKızartması(Boyut.Büyük);

            Kola kola = new Kola(Boyut.Büyük, Tip.Şekerli);

            Menü1 menü = new Menü1(new Kola((Boyut.Küçük), Tip.Şekersiz));

            Personel Furkan = new KasaPersoneli();
            Furkan.Görev = Görev.ServisPersoneli;
        }
    }
}