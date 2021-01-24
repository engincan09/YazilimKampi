using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class BasvuruManager
    {
        
        public void BasvuruYap(IKrediManager krediManager, ILoggerService logger)
        {
            krediManager.Hesapla();
            logger.Log();
        }

        public void KrediOnBilgilendirme(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
