using ODEV5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5.Verification.EDevlet
{
    class EDevletVerification : IVerificationService
    {
        public bool MakeVerification(User user)
        {
            if (user.TcNo != null && user.Yas >18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      
    }
}
