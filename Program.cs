using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 00001;
            musteri1.musteriAdi = "Alper Düztaş";
            musteri1.tcNo = "14552554441";
            musteri1.dogumYili = "08.04.1992";
            
            Musteri musteri2 = new Musteri();
            musteri2.Id = 00002;
            musteri2.musteriAdi = "Mehmet Ali";
            musteri2.tcNo = "14552554441";
            musteri2.dogumYili = "08.04.1995";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 00003;
            musteri3.musteriAdi = "Tuğba Akgündüz";
            musteri3.tcNo = "14552554441";
            musteri3.dogumYili = "20.09.1993";

            
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musterim = new MusteriManager();

            musterim.MusteriEkle(musteriler[0]);
            musterim.MusteriEkle(musteriler[1]);
            musterim.MusteriEkle(musteriler[2]);

            musterim.MusteriListele(musteriler);
            
            musterim.MusteriSil(musteriler[0]);
            musterim.MusteriSil(musteriler[1]);
            musterim.MusteriSil(musteriler[2]);
        }
    }
}
