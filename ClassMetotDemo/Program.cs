using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri {Id=1,FirstName="Engin",SurName="Can" };
            Musteri musteri2 = new Musteri { Id = 2, FirstName = "Deniz", SurName = "Şimşek" };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);

            Musteri[] musteriler = { musteri1, musteri2 };
            musteriManager.List(musteriler);

        }
    }
}
