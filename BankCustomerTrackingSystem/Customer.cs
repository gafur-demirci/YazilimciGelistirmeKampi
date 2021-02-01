using System;
using System.Collections.Generic;
using System.Text;

namespace BankCustomerTrackingSystem
{
    class Customer
    {
        public int CustomerId { get; set; }            // Müşterinin Id'sini tutuyor tutuyor.
        public int CategoryId { get; set; }            // Müşterinin Kategori Id'sini tutuyor.
        public int CustomerNumber { get; set; }        // Müşterinin Numara'sını tutuyor.
        public string CustomerName { get; set; }       // Müşterinin adını tutuyor.
        public string CustomerSurname { get; set; }    // Müşterinin soyadını tutuyor.
        public char CustomerGender { get; set; }       // Müşterinin cinsiyetini tutuyor.
        public int CustomersYear { get; set; }         // Müşterinin yaşını tutuyor.
        public float MoneyInBank { get; set; }         // Müşterinin bankada ki para miktarını tutuyor.
        public char TypeOfMoney { get; set; }          // Müşterinin parasının türünü tutuyor.
        public int YearsOfCustomer { get; set; }       // Kaç yıllık banka müşteri olduğunu tutuyor.

    }
}
