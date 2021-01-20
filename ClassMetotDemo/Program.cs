using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteriler musteri1 = new Musteriler()
            {
                id = 123,
                Adi = "Mehmet",
                Soyadi = "Vurmaz",
                Sifre = "Vurmaz3213",
            };

            Musteriler musteri2 = new Musteriler()
            {
                id = 216,
                Adi = "Ahmet",
                Soyadi = "Kara",
                Sifre = "KaraHarekati"
            };

            Musteriler musteri3 = new Musteriler()
            {
                id = 865,
                Adi = "Hakan",
                Soyadi = "Polat",
                Sifre = "PolatAlemdar"
            };

            

            MusteriManager musteriManager = new MusteriManager();

            foreach (var item in musteri)
            {
                musteriManager.MusteriListele(item);
            }

            foreach (var item in musteri)
            {
                musteriManager.MusteriEkle(item);
            }

            musteriManager.MusterSil(musteri1);


            
            


        }
    }
}
