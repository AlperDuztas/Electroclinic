using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void MusteriEkle (Musteri musteri) 
        {
            Console.WriteLine(musteri.Id + " Numaralı " + musteri.musteriAdi + " isimli müşteri eklenmiştir.");
            Console.WriteLine("---------------------------------------");
        }

        public void MusteriSil (Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " Numaralı " + musteri.musteriAdi + " isimli müşteri silinmiştir.");
            Console.WriteLine("----------------------------------------");
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var item in musteriler)
            {
                Console.WriteLine("Müşteri Bilgileri");
                Console.WriteLine("Ad Soyad: " + item.musteriAdi);
                Console.WriteLine("Tc No:  " + item.tcNo);
                Console.WriteLine("---------------------------");
            }
        }

    }
}
