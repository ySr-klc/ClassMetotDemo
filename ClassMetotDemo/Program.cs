using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GerekliBilgiler musteri1 = new GerekliBilgiler();
            musteri1.id = 01;
            musteri1.adi = "Eset";
            musteri1.soyadi = "Demirtas";
            musteri1.yas = 19;

            GerekliBilgiler musteri2 = new GerekliBilgiler();
            musteri2.id = 02;
            musteri2.adi = "Sedat";
            musteri2.soyadi = "Gül";
            musteri2.yas = 66;

            GerekliBilgiler musteri3 = new GerekliBilgiler();
            musteri3.id = 03;
            musteri3.adi = "Ahmet";
            musteri3.soyadi = "Savaş";
            musteri3.yas = 30;

            GerekliBilgiler[] musteriler = new GerekliBilgiler[] { musteri1, musteri2, musteri3 };
            foreach (GerekliBilgiler musterileri  in musteriler)

            {
                Console.WriteLine("Adi : " + musterileri.adi);
                Console.WriteLine("Soy adı : " + musterileri.soyadi);
                Console.WriteLine("Yaşı : " + musterileri.yas);
                Console.WriteLine("ID : "+ musterileri.id);
            }
            
            Console.WriteLine("---------------");
            
            MusteriManager kredigrubu = new MusteriManager();
            kredigrubu.Musterigrubu(musteri1);
            kredigrubu.Musterigrubu(musteri2);
            kredigrubu.Musterigrubu(musteri3);

            Console.WriteLine("---------------");

            kredigrubu.Add(musteri1);
            kredigrubu.Delete(musteri3);


        }
    }




}