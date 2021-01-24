using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler1 = new List<string>();
            isimler1.Add("Engin");
            isimler1.Add("Deniz");
            Console.WriteLine(isimler1[0]);
            Console.WriteLine(isimler1[1]);          
        }
    }
}
