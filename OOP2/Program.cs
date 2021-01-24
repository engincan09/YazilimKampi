using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Can";
            musteri1.TcNo = "13456498";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.SirketAdi = "Can Yazılım";
            musteri2.MusteriNo = "546546";
            musteri2.VergiNo = "65A4SD6AS";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri4);
            

        }
    }
}
