using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention
        // Product metot içerisinde kullanılacak objenin türünü urun ise takma adı temsil etmektedir.
        // Buna da paramatre denmektedir.
        public void Ekle(Product urun)
        {
            Console.WriteLine("Seçilen " + urun.Adi + " isimli ürün eklendi.");
        }

        public void Ekle2(string urunAdi, string urunAciklama, double urunFiyati)
        {
            Console.WriteLine("Seçilen " + urunAdi + " isimli ürün eklendi.");
        }
    }
}
