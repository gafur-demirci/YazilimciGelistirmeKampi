using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            //MyList isimler = new MyList();  // Generic class olduğu için yukarıda ki gibi obje oluşturulmalıdır. (kullanılacak veri türü belirtilme zorunluluğu vardır.)

            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);

            isimler.Add("Kerem");
            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Hello World!");
        }
        
            
    }
}
