using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
    public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {
            
           krediManager.Hesapla();
            foreach (var service in loggerService)
            {
                service.Log();
            }
        }

        public void KrediOnBilgirendirmesiYap(List<IKrediManager> krediler )
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
