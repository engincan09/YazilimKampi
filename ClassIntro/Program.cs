using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Programlama Temelleri";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 50;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Engin Demirog";
            kurs2.IzlenmeOrani = 50;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Engin Demirog";
            kurs3.IzlenmeOrani = 50;

            Console.WriteLine(kurs1.KursAdi + " " +kurs1.Egitmen );
            Console.WriteLine("---------");

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }

    }

    class Kurs
    {
        public string KursAdi  { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani  { get; set; }
    }



}
