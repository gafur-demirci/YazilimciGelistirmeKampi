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
            urun1.stokAdedi = 100;

            Product urun2 = new Product();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.Fiyati = 80;
            urun2.stokAdedi = 10;

            Product[] products = new Product[] { urun1, urun2 };

            foreach (Product urun in products)
            {
                Console.WriteLine("Id : " + urun.Id + " Adı : " + urun.Adi + " Fiyatı : " + urun.Fiyati + " Açıklama : " + urun.Aciklama + "Stok adedi : " + urun.stokAdedi);
            }

            Console.WriteLine("----------Metotlar----------");

            // instance - Örnek
            // encapsulation    
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            // Ekle2 gibi kullanmamamızın sebebi eğer ki ürünün içerdiği parametre sayısı değişir ise bu değişimi tek tek 
            // mevcut bütün ürünlere yansıtılması  gerektiği için ama class olarak Ekle metodu kullanılsaydı böyle bir 
            // sorun olmayacaktı. ("Class'lar Candır.")
            sepetManager.Ekle2("Elma", "Amasya elması", 15);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 80);
        }
    }
}