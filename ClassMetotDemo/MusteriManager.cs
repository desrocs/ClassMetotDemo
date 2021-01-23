using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle (Musteri musteri)
        {
            Console.WriteLine(musteri.Isim + " " +musteri.Soyisim + " " + musteri.Tc +"Müşteri Sisteme Eklenmiştir" );
            Console.WriteLine("--------------------");
        }

        public void MusteriListele(Musteri [] müsteriler)
        {
            foreach (var musteri in müsteriler)
            {
                Console.WriteLine("\nMüşteri Id: " + musteri.Id + "\nMüşterinin Adı: " + musteri.Isim + "\nMüşteri Soyadı: " + musteri.Soyisim + "\nMüşteri Tc nosu : " + musteri.Tc );
                Console.WriteLine("------------------------------------");

            }
        }


        public void MusteriSil ( Musteri musteri)
        {
            Console.WriteLine(musteri.Id +musteri.Isim + " " + musteri.Soyisim + " " + "Müşteri Sistemden Silinmiştir");
        }



    }
}
