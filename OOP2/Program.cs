using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mukaddes";
            musteri1.Soyadi = "Akdu";
            musteri1.Id = 1;
            musteri1.TcNo = "11111122233";
            musteri1.MusteriNo = "12345";
            musteri1.SirketAdi = "?";
            musteri1.VergiNo = "?";
            şirket adı ve vergi no benimle alakalı özellikler değildir.*/

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.TcNo = "11111122233";
            musteri1.Adi = "Mukaddes";
            musteri1.Soyadi = "Akdu";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "123";
            musteri2.VergiNo = "1234567890";
            musteri2.SirketAdi = "Kodlama.io";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);
        }
    }
}
