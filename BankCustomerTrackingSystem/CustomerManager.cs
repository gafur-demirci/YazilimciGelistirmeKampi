using System;
using System.Collections.Generic;
using System.Text;

namespace BankCustomerTrackingSystem
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + "  " + customer.CustomerSurname + " isimli müşteri eklenmiştir." );
        }

        public void Listing(Customer[] customers)
        {
            Console.WriteLine("CustomerId" + " " + " " + "CustomerNumber" + " " + "CustomerName" + " " + "CustomerSurname");

            foreach (Customer customer in customers)
            {
                Console.WriteLine( "    " + customer.CustomerId + "           " + customer.CustomerNumber + "          " + customer.CustomerName
                    + "          " + customer.CustomerSurname);
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " isimli müşteri silinmiştir.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + "  " + customer.CustomerSurname + " isimli müşteri güncellenmiştir.");
        }
    }
}
