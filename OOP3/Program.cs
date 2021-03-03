using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();
            tasıtKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            //Hem yukarıdaki hem de aşağıdaki gibi yazabiliriz.

            IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            //ihtiyacKrediManager1.Hesapla();

            IKrediManager tasıtKrediManager1 = new TasıtKrediManager();
            //tasıtKrediManager1.Hesapla();

            IKrediManager konutKrediManager1 = new KonutKrediManager();
            //konutKrediManager1.Hesapla();

            //ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            //şimdi başvuru yapıyorum:
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager1, tasıtKrediManager1 };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
