using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Burada başvuran bilgilerini değerlendirme vs işlemleri yaparız.
            /*bir de krediyi hesaplayalım:
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();
            yukarıdaki kod çalışır ama tüm başvurular konut kredisi üzerinden hesaplanır.*/

            krediManager.Hesapla();
            //başvuru kredi türünden bağımsız oldu.
            loggerService.Log();
        }

        //yukarıda tek bir kredi istiyoruz çünkü artık başvuru yapılacak ama aşağıda ön bilgilendirme olduğu için istenilen sayıda krediyi hesaplamak istiyoruz.
        //bana bir liste ver, bu listenin türü IKrediManager olsun.
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
            //listedeki her bir kredinin hesabını yap.
        }
    }
}
