using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string urunAdi = "Elma";
            //double fiyati = 15;
            //string aciklama = "Amasya ELması";

            string[] meyveler = new string[] { };
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.aciklama = "Amasya ELması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati=80;
            urun2.aciklama = "Diyarbakı karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            
            
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.aciklama);
                Console.WriteLine("--------------------------");
            }

            Console.WriteLine("--------------METODLAR--------------");


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut ", "yeşil armut ", 12,10) ;
            sepetManager.Ekle2("elma " ,"yeşil elma ",12,9);
            sepetManager.Ekle2("elma " , "diyabakır karpuzu ", 12,8);
            

        }
    }
    


}
