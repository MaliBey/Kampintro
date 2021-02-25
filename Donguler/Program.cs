using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Progrmalamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Pyhton";
            string kurs5 = "C#";


            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
            "Progrmalamaya başlangıç için temel kurs","Java","Pyhton","C#" };

            for (int i = 0; i < kurslar.Length ; i ++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer ");
        }
    }
}
