using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> kisiler = new MyDictionary<string, int>();  // MyDictionary class'ından kisiler takma adına sahip obje oluşturur.
            kisiler.Add("Engin", 25);   // Add metodu ile key değeri "Engin" , value değeri 25 olan obje eklenir.
            kisiler.Add("Kerem", 19);   // Add metodu ile key değeri "Kerem" , value değeri 19 olan obje eklenir.

            for (int i = 0; i < kisiler.keys.Length; i++)                        // kisiler dictionary'nin key uzunluğu kadar döner ve her dönüşte
                                                                                 // o indexdeki key ve value değerlerini yazdırır.
            {
                Console.WriteLine(kisiler.keys[i] + " " + kisiler.values[i]);  
            }

            Console.WriteLine(kisiler.keys.Length);    // Key sayısını yazdırır.

            Console.WriteLine(kisiler.values.Length);  // Value sayısını yazdırır.

        }
    }
}
