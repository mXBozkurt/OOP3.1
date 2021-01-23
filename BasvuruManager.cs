using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3._1
{
    class BasvuruManager
    {
        //Method İnjection
        public void BasvuruYap(IKrediManager krediManager , List<ILoggerService> loggerServices)
        {
            //Başvuru Bilgilerini Değerlendirme
 
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}
