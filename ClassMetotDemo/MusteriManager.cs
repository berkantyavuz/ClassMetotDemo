using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteriler musteri)
        {
            Console.WriteLine("Müşteri eklendi" + " " + musteri.Adi + " " + musteri.Soyadi);
        }
        public  void    MusterSil(Musteriler musteri)
        {
            Console.WriteLine("Musteri Silindi");
        }
        public  void    MusteriListele(Musteriler musteri)
        {
            foreach (var item in musteri)
            {
                Console.WriteLine("Müşteri id : " + item.id);
                Console.WriteLine("Müşteri Adı : " + item.Adi);
                Console.WriteLine("Müşteri Soyadi : " + item.Soyadi);
                Console.WriteLine("Müşteri Sifresi : " + item.Sifre );
                Console.WriteLine("---------------------------");
            }
        }
    }
}
