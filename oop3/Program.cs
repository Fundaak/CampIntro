using System;

namespace oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutcrediManager = new KonutcrediManager();

            ILoggerService databaseloggerService = new DateBaseLoggerService();
            ILoggerService fileLoggerService = new fileLoggerService();




            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutcrediManager, databaseloggerService);

            list<IKrediManager> krediler = new list<IKrediManager>() { };

            BasvuruManager.KrediÖnBilgilendirmesiYap(krediler);
        }
    }
