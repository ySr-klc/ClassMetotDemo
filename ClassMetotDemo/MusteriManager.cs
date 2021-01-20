using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Musterigrubu(GerekliBilgiler musteriler)
        {


            if ( musteriler.yas<24 && musteriler.yas > 18)
            {
                Console.WriteLine("Öğrenciye özel krediler sizin için öneriliyor " + musteriler.adi + "Bey");
            }
            else if (musteriler.yas>24 && musteriler.yas < 65)
            {
                Console.WriteLine("İşci kredileri sizin için öneriliyor " + musteriler.adi + "Bey");
            }
            else
            {
                Console.WriteLine("Emekliye özel krediler sizin için " + musteriler.adi + "Bey");
            }
           


        }
        public void Add(GerekliBilgiler musteriler)
        {
            Console.WriteLine("başarıyla eklendiniz: " + musteriler.adi +" "+ musteriler.soyadi);
        }
        public void Delete(GerekliBilgiler musteriler)
        {
            Console.WriteLine("Silme işlemi başarılı : " + musteriler.adi);
        }

    }



}