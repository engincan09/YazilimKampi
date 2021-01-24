using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5.Abstract
{
    public class User  : IUser
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string TcNo { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Yas { get; set; }
    }
}
