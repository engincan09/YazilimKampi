using ODEV5.Abstract;
using ODEV5.Concreate;
using ODEV5.Entities;
using ODEV5.Verification.EDevlet;
using System;
using System.Collections.Generic;

namespace ODEV5
{
    class Program
    {


        static void Main(string[] args)
        {
            //Üyelik İşlemleri        
          
            User user1 = new User { Id = 1, FirstName = "Engin", LastName = "Can", TcNo = "12345678910", Email = "engin@gmail.com", Password = "123", UserName = "EmginC#", Yas = 21 };
            User user2 = new User { Id = 2, FirstName = "Deniz", LastName = "Kaya", TcNo = "12648678910", Email = "deniz@gmail.com", Password = "123", UserName = "DenizJava", Yas = 20 };
            User user3 = new User { Id = 3, FirstName = "Ali", LastName = "Mersin", TcNo = null, Email = "deniz@gmail.com", Password = "123", UserName = "DenizJava", Yas = 20 };
            //Hesabı Doğrula
            UserManager userManager = new UserManager(new EDevletVerification());
            userManager.Add(user3);
            //Hesabı Sil
            userManager.Delete(user2);
            Console.WriteLine("-----------------------------------------------------");

            //Kampanya İşlemleri
           
            Campaign campaign1 = new Campaign { Id=1,Title = "Sepette %50 İndirim!", Descr="Hemen Al Hemen İndirimi Kap!"};
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            Console.WriteLine("-----------------------------------------------------");













        }
    }
}
