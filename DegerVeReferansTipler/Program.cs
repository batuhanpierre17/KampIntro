using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30

            int[] sayilar1 = new int[] {10,20,30 }; // 
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            var x = sayilar1[0];
            Console.WriteLine(sayilar1[0]);

            //sayisal veri tipleri int decimal floot doble, bool = Veri tip
            //arrey, class, interpace = referans tip
            //stack(sayı1=10 sayi 2=30  alttan yukarı gider alti değiştirdiğin için üst kısımla ilgisi yoktur)))) ve heap diye bellekte iki tane alan var ((( new dediğin anda sayılar 1 için heap de yeni bir alan olusturulur. Sonra sayılar 2 diye bir şey tanımladın onu newlediğin anda değer olusturur ve heap adresine gider new bellekten bir adres olusturmak yani yeni bir heap olusturmak. Yani sayılar1 sayılar2 nin referans numnarası adresine heapine esittir
        }
    }
}
