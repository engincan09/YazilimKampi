using ODEV5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5.Concreate
{
    class UserManager : IUserService
    {
        IVerificationService _verifiaction;
        public UserManager(IVerificationService verification)
        {
            _verifiaction = verification;
        }
        List<User> users = new List<User>();
        public void Add(User user)
        {
            
            if (_verifiaction.MakeVerification(user) == true)
            {
                users.Add(user);
                Console.WriteLine("Doğrulama Başarılı! Üyelik kaydınız oluşturulmuştur. Oyun dünyasına hoş geldin!" + " " + user.FirstName + " " + user.LastName);
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız! Sisteme üye olamazsınız." + " " + user.FirstName + " " + user.LastName);
            }
        }

        public void Delete(User user)
        {
            Console.WriteLine("Üyelik kaydınız silinmiştir. Oyun dünyasına elveda!" + " " + user.FirstName + " " + user.LastName);
            users.Remove(user);
           
        }

        public void Update(User user)
        {
            Console.WriteLine("Üyelik kaydınız güncellenmiştir. Oyun dünyasına yeni imajınla tekrar hoş geldin!" + " " + user.FirstName + " " + user.LastName);
        }
    }
}
