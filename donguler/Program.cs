using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]
            {
                "Yazılım Gelistirici Yetirtirme Kampı","Programlamaya başlamak için temel kurs","java","pyhthon","C+"
            };
            for (int i =0 ; i < kurslar.Length; i=+i+1)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("for bitti");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.Write("Sayfa sonu - fooder");
        }
    }
}
