using System;
using System.Collections.Generic;
using System.Text;

namespace oop3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService  loggerService)
        {
            krediManager.Hesapla();
            loggerService.log();


        }

        public void KediÖnBilgilendirmesiYap(List<KrediManager>krediler)
        {


        }

        internal class KrediÖnBilgilendirmesiYap
        {
        }
    }
}
