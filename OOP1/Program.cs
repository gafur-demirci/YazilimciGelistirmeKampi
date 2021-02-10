using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 4;

            Product product2 = new Product();
            product2.Id = 2;
            product2.CategoryId = 3;
            product2.ProductName = "Televizyon";
            product2.UnitPrice = 5000;
            product2.UnitsInStock = 2;

            // Böyle de oluşturulabilir.

            Product product3 = new Product { Id = 3, CategoryId = 4, ProductName = "Laptop", UnitPrice = 8000, UnitsInStock = 1 };

            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            // Stack                        // Heap
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            productManager.Update(product3);

            // int tanımlama değer tip olduğundan değeri değişmez ama product1.ProductName class yapısında yani referans tip olduğundan değişir.
            //                 100                                                                 Kamera

            //int sayi = 100;
            //productManager.abc(sayi);
            //Console.WriteLine(sayi); // 100

            //productManager.Topla2(3, 6);  // Sadece işlemi yapar ve ekrana yazdırır (Void den ötürü) Programın devamında kullanılacak bir değer vermez bağlantısı sadece ekrana yazdırma işlemini
            //                              // yapar ve bağlantı kopar.

            //int toplamSonucu = productManager.Topla(3, 6);  // int kullanılırsa böyle çağırılıp bir değişken adına atanır böylece kodun devamında kullanılabilmeyi sağlar.

            //Console.WriteLine(toplamSonucu*8);
        }
    }
}
