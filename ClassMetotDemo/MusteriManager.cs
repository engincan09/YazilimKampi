using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Kayıt İşleminiz Oluşturuldu. Sayın: "+musteri.FirstName + " " + musteri.SurName);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Silme İşleminiz Oluşturuldu. Sayın: " + musteri.FirstName + " " + musteri.SurName);
        }

        public void List(Musteri[] musteriler) 
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.FirstName + " " + musteri.SurName );
            }
        }
    }
}
