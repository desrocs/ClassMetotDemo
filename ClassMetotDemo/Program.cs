using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Isim = "Ahmet";
            musteri1.Soyisim = "Türkmen";
            musteri1.Tc = 11111111111;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Isim = "Erdem";
            musteri2.Soyisim = "Çakır";
            musteri2.Tc = 22222222222;


            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Isim = "Hikmet";
            musteri3.Soyisim = "Yiğit";
            musteri3.Tc = 3333333333;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriListele(musteriler);
            musteriManager.MusteriSil(musteri1);
            Console.WriteLine("-----------------------------");
            musteriManager.MusteriEkle(musteri1);



        }
    }
}
