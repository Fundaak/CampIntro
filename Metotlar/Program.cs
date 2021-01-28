using System;

namespace Metotlar
{
    class Program
    {

        static void Main(string[] args)
        {
            string UrunAdi = "Elma";
            double Fiyatı = 15;
            string Açiklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma;";
            urun1.Fiyatı = 15;
            urun1.Açiklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 80;
            urun2.Açiklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Açiklama);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("--------Metotlar------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 10);


            
    
      
        
        