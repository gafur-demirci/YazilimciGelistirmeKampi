using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classlar ile ürün ekleyip listeleme

            Product urun1 = new Product();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya Elması";
            urun1.Fiyati = 15;

            Product urun2 = new Product();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.Fiyati = 80;

            Product[] products = new Product[] { urun1, urun2 };

            foreach (Product urun in products)
            {
                Console.WriteLine("Id : " + urun.Id + " Adı : " + urun.Adi + " Fiyatı : " + urun.Fiyati + " Açıklama : " + urun.Aciklama);
            }

            Console.WriteLine("----------Metotlar----------");

            //instance - Örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
        }
    }
}