using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1,urun2};

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("-----------------METOTLAR------------------");

            //Encapsulation
            //instance - örnek
            BasketManager sepetManager = new BasketManager();
            sepetManager.Add(urun1);
            sepetManager.Add(urun2);

            sepetManager.Add2("Armut", "Yeşil armut", 12,1);
            sepetManager.Add2("Elma", "Yeşil elma", 12,2);
            sepetManager.Add2("Karpuz", "Diyarbakır", 12,3);
        }
    }
}

//Dont repeat yourself - Clean Code - Best Practice
