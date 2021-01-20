using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Sabit");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Sisteme Giriş Yapıldı");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Yapılmadı");
            }

            

        }
    }
}
