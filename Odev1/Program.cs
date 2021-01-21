using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            product1.UrununAdi = "Keyboard";
            product1.UrunAcıklaması = "Ledli gammer klavye";
            product1.UrunFiyati = 500;
            product1.UretenFirma = "Fastcom bilgisayar";
            product1.EnvanterMiktari = 100;


            Product product2 = new Product
            product1.UrununAdi = "Monitör";
            product1.UrunAcıklaması = "Ultra hd monitör";
            product1.UrunFiyati = 700;
            product1.UretenFirma = "Fastcom bilgisayar";
            product1.EnvanterMiktari = 1000;
        }
    }
    class Product
    {
        public string UrununAdi { get; set; }
        public string UrunAcıklaması { get; set; }
        public int UrunFiyati { get; set; }
        public string UretenFirma { get; set; }
        public int EnvanterMiktari { get; set; }
    }
}
