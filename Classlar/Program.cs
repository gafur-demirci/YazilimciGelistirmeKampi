using System;

namespace YazilimciGelistirmeKampi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Selam Dünyalı");

            string adi = "Gafur";
            int yas = 24;

            Kurs javaKursu = new Kurs();
            javaKursu.KursAdi = "Java";
            javaKursu.KursEgitmeni = "Engin";
            javaKursu.KursKatilimciSayisi = 5000;
            javaKursu.KursİzlenmeOrani = 85;

            Kurs pythonKursu = new Kurs();
            pythonKursu.KursAdi = "Python";
            pythonKursu.KursEgitmeni = "Murat";
            pythonKursu.KursKatilimciSayisi = 50000;
            pythonKursu.KursİzlenmeOrani = 100;

            Console.WriteLine(javaKursu.KursAdi + " : " + javaKursu.KursEgitmeni);

            Kurs[] kurslar = new Kurs[] { javaKursu, pythonKursu };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursEgitmeni);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int KursKatilimciSayisi { get; set; }
        public int KursİzlenmeOrani { get; set; }

    }
}