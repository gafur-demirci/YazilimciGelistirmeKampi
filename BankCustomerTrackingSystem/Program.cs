using System;

namespace BankCustomerTrackingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bankanıza Hoşgeldiniz!");

            // Customer class ından örnekler oluşturulup özelliklerinin belirlenmesi

            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CategoryId = 1;
            customer1.CustomerNumber = 123;
            customer1.CustomerName = "Engin";
            customer1.CustomerSurname = "Demirog";
            customer1.CustomerGender = 'E';
            customer1.CustomersYear = 20;
            customer1.TypeOfMoney = 'T';
            customer1.MoneyInBank = 5000;
            customer1.YearsOfCustomer = 2;

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CategoryId = 3;
            customer2.CustomerNumber = 124;
            customer2.CustomerName = "Murat";
            customer2.CustomerSurname = "Kurtbogan";
            customer2.CustomerGender = 'E';
            customer2.CustomersYear = 25;
            customer2.TypeOfMoney = 'T';
            customer2.MoneyInBank = 300;
            customer2.YearsOfCustomer = 5;

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CategoryId = 5;
            customer3.CustomerNumber = 125;
            customer3.CustomerName = "İlker";
            customer3.CustomerSurname = "Demirog";
            customer3.CustomerGender = 'E';
            customer3.CustomersYear = 27;
            customer3.TypeOfMoney = 'D';
            customer3.MoneyInBank = 1000;
            customer3.YearsOfCustomer = 3;

            Customer customer4 = new Customer();
            customer4.CustomerId = 4;
            customer4.CategoryId = 1;
            customer4.CustomerNumber = 126;
            customer4.CustomerName = "Kübra";
            customer4.CustomerSurname = "Terzi";
            customer4.CustomerGender = 'K';
            customer4.CustomersYear = 24;
            customer4.TypeOfMoney = 'D';
            customer4.MoneyInBank = 3000;
            customer4.YearsOfCustomer = 1;

            Customer customer5 = new Customer();
            customer5.CustomerId = 5;
            customer5.CategoryId = 3;
            customer5.CustomerNumber = 127;
            customer5.CustomerName = "Halil";
            customer5.CustomerSurname = "Duymaz";
            customer5.CustomerGender = 'E';
            customer5.CustomersYear = 28;
            customer5.TypeOfMoney = 'E';
            customer5.MoneyInBank = 500;
            customer5.YearsOfCustomer = 2;

            // Customer class'ından liste oluşturulup içerisine tanımlanan Customer objelerinin eklenmesi

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5};

            // CustomerManager class'ından obje oluşturulması.

            CustomerManager customerManager = new CustomerManager();

            // Listing ( Listeleme ) , Add ( Ekleme ) , Update ( Güncelleme ) , Delete ( Silme ) komutlarının çağırılıp kullanılması.

            customerManager.Listing(customers);
            customerManager.Add(customer3);
            customerManager.Update(customer2);
            customerManager.Delete(customer5);

            // Programı durdurma komutu.

            Console.ReadLine();
        }
    }
}
