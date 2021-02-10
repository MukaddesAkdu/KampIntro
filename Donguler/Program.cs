using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            //bunları tek tek yazmak yerine diziler de tanımlıyoruz. *DİZİ *ARRAY
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" , "Programlamaya başlangıç için temel kurs" , "Java" };
            
            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i <= 10; i=i+2)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i+=2)
            {
                Console.WriteLine(i);
            }

        }
    }
}
