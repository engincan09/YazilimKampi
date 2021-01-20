using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Adi = "Dolap";
            product1.Aciklama = "Beyaz";
            product1.Fiyati = 1500;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Adi = "Telefon";
            product2.Aciklama = "Samsung";
            product2.Fiyati = 5500;

            Product product3 = new Product();
            product3.Id = 3;
            product3.Adi = "Kazak";
            product3.Aciklama = "Yün";
            product3.Fiyati = 500;

            Product[] products = { product1, product2, product3 };
            foreach (var product in products)
            {
                Console.WriteLine(product.Adi +" " + product.Aciklama +" " +product.Fiyati);
            }

            Console.WriteLine("--------------Metotlar-------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);


            
        }
    }
}

