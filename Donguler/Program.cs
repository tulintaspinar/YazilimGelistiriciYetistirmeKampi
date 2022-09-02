using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi
            string[] kurslar = new string[] 
                                {
                                    "Yazılım Geliştirici Yetiştirme Kampı",
                                    "Programlamaya Başlangıç için Temel Kurs",
                                    "Java",
                                    "Python",
                                    "C#"
                                };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Sayfa sonu - footer");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
