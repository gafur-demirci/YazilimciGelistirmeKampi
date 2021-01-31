using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>  // T o an kullanıcı <> içerisine hangi tür (str int ...) yazarsa o tipte veri tutacağını göstermek için yazılır.
    {
        T[] items;
        // constructor
        public MyList()  // MyList class ını bir yerde new olarak eklediğinde bu kısım direkt çalışır. ( ctor )
        {
            items = new T[0];   // 0 elemanlı array oluşturuldu.
        }
        public void Add(T item)
        {
            T[] tempArray = items;  // Aşağıda ki arttırma işleminin eksiği olan her seferinde ref değeri değişeceği için bu ref değerini geçici dizi (tempArray) ile tutuyoruz.
                                    // Böylece aynı ref değerde ki list üzerinde çalışıyoruz ve eklenen elemanlar aynı ref değerde ki list de tutulmuş oluyor.
            items = new T[items.Length + 1];  // Diziye eleman eklemek için yer açmalıyız bunu da eleman sayısı başlangıçta 0 olduğundan her seferinde +1 koyarak ilerletmek için bu şekilde yazıyoruz.
            for (int i = 0; i < tempArray.Length; i++)  // 0 dan tempArray in uzunluğu kadar dön. 5 elemanlı ise 0,1,2,3,4 olacak böylece indexler uygun olacak.
            {
                items[i] = tempArray[i];  // Geçici olarak tempArray de tutulan değerleri items dizimize index bazlı ekliyoruz. 
            }                             // tempArray items dan bir eleman eksik olduğu için bir elemanlık boş alan kalacaktır.  

            items[items.Length - 1] = item;  //  Boş kalan alana (aynı zamanda itemsda da boşluk olacak eşitlemeden ötürü) yukarıda gönderilen item değerine eşitlenecek.
        }
        public int Length                   // Listenin uzunluk değerlerini göstermek için
        {
            get { return items.Length; }
        }

        public T[] Items                   // Listenin elemanlarını göstermek için
        {
            get { return items; }
        }

    }
}
