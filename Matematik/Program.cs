using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 12;
            int sayi2 = 10;
            int sayi3 = 5;
            int sayi4 = 2;

            DortIslem dortIslem = new DortIslem();
            dortIslem.toplama(sayi1 , sayi2);
            dortIslem.cikarma(sayi2 , sayi3);
            dortIslem.carpma( sayi3 , sayi4);
            dortIslem.bolme(  sayi2 , sayi4);
        }
    }
}
