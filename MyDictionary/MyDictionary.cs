using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>                      // T -> O an kullanıcı <> içerisine hangi tür (str int ...) yazarsa o tipte veri tutacağını göstermek için yazılır.
    {
        TKey[] Keys;
        TValue[] Values;
        // constructor 
        public MyDictionary()                             // MyDictionary class ını bir yerde new olarak eklediğinde bu kısım direkt çalışır.
        {
            Keys = new TKey[0];                           // 0 elemanlı array oluşturuldu.
            Values = new TValue[0];                       // 0 elemanlı array oluşturuldu.
        }
        // constructor sonu
        public void Add(TKey key , TValue value)
        {
            TKey[] tempKey = Keys;                        // Aşağıda ki arttırma işleminin eksiği olan her seferinde ref değeri değişeceği için bu ref değerini geçici dizi (tempKey v tempValue) ile tutuyoruz.

            TValue[] tempValue = Values;                  // Böylece aynı ref değerde ki list üzerinde çalışıyoruz ve eklenen elemanlar aynı ref değerde ki list de tutulmuş oluyor.

            Keys = new TKey[Keys.Length + 1];             // Diziye eleman eklemek için yer açmalıyız bunu da eleman sayısı başlangıçta 0 olduğundan her seferinde +1 koyarak ilerletmek için bu şekilde yazıyoruz.
            Values = new TValue[Values.Length + 1];       // Diziye eleman eklemek için yer açmalıyız bunu da eleman sayısı başlangıçta 0 olduğundan her seferinde +1 koyarak ilerletmek için bu şekilde yazıyoruz.

            for (int i = 0; i < tempKey.Length; i++)
            {
                Keys[i] = tempKey[i];                     // Geçici olarak tempKey de tutulan değerleri Keys dizimize index bazlı ekliyoruz. 
            }                                             // tempKey Keys dan bir eleman eksik olduğu için bir elemanlık boş alan kalacaktır.

            Keys[Keys.Length - 1] = key;                  //  Boş kalan alana (aynı zamanda Keys'de de boşluk olacak eşitlemeden ötürü) yukarıda gönderilen key değerine eşitlenecek.

            for (int i = 0; i < tempValue.Length; i++)
            {
                Values[i] = tempValue[i];                 // Geçici olarak tempValue de tutulan değerleri Values dizimize index bazlı ekliyoruz. 
            }                                             // tempValue Values dan bir eleman eksik olduğu için bir elemanlık boş alan kalacaktır.

            Values[Values.Length - 1] = value;            //  Boş kalan alana (aynı zamanda Values'de de boşluk olacak eşitlemeden ötürü) yukarıda gönderilen value değerine eşitlenecek.

        }
        
        public TKey[] keys                                // Dictionary'nin key'lerini göstermek için
        {
            get { return Keys; }
        }
        public TValue[] values                            // Dictionary'nin value'lerini göstermek için
        {
            get { return Values; }
        }
    }
}
