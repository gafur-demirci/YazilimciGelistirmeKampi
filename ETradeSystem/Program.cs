using System;

namespace ETradeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To ETrade Site");

            Product product1 = new Product
            {
                ProductName = "Samsung S6 Edge Plus", ProductCategory = "Electronic", UnitPrice = 1549, UnitsInStock = 1000
            };

            Product product2 = new Product
            {
                ProductName = "Xiaomi Redmi Note 9", ProductCategory = "Electronic", UnitPrice = 2685, UnitsInStock = 300
            };

            Product product3 = new Product
            {
                ProductName = "Nike Air", ProductCategory = "Spor", UnitPrice = 349.98, UnitsInStock = 100
            };
            Product product4 = new Product
            {
                ProductName = "Slazenger Genesis ", ProductCategory = "Spor", UnitPrice = 107.20, UnitsInStock = 200
            };
            Product product5 = new Product
            {
                ProductName = "Xiaomi Mijia", ProductCategory = "Home", UnitPrice = 89, UnitsInStock = 150
            };
            Product product6 = new Product
            {
                ProductName = "Scotch Brite Microfiber Mop ", ProductCategory = "Home", UnitPrice = 95, UnitsInStock = 50
            };
            Product product7 = new Product
            {
                ProductName = "Elements", ProductCategory = "Book", UnitPrice = 18.90, UnitsInStock = 200
            };
            Product product8 = new Product
            {
                ProductName = "Earthquake In Turkey", ProductCategory = "Book", UnitPrice = 21.75, UnitsInStock = 100
            };

            Product[] products = {product1, product2, product3, product4, product5, product6, product7, product8};

            Console.WriteLine("--------------------------");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Foreach Loops");

            foreach (var product in products)
            {
                Console.WriteLine("Product Name : " + product.ProductName);
                Console.WriteLine("Product Category : " + product.ProductCategory);
                Console.WriteLine("Unit Price : " + product.UnitPrice);
                Console.WriteLine("Units In Stock : " + product.UnitsInStock);
                Console.WriteLine("*******************************************");
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("--------------------------");

            Console.WriteLine("For Loops");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Product Name : " + products[i].ProductName);
                Console.WriteLine("Product Category : " + products[i].ProductCategory);
                Console.WriteLine("Unit Price : " + products[i].UnitPrice);
                Console.WriteLine("Units In Stock : " + products[i].UnitsInStock);
                Console.WriteLine("*******************************************");
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("--------------------------");

            Console.WriteLine("While Loops");

            int index = 0;
            while (index< products.Length)
            {
                Console.WriteLine("Product Name : " + products[index].ProductName);
                Console.WriteLine("Product Category : " + products[index].ProductCategory);
                Console.WriteLine("Unit Price : " + products[index].UnitPrice);
                Console.WriteLine("Units In Stock : " + products[index].UnitsInStock);
                Console.WriteLine("*******************************************");
                index++;
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Quit this site please...");

        }
    }
}
