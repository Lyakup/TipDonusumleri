using System;

namespace TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Implicit Conversion - Bilinçsiz / Kapalı");
            //Düşük kapasitlei bir değişkenin kendinden büyük başka bir değişkene atanması.

            byte a = 5;
            sbyte b = 3;
            short c = 4;

            int d = a + b + c;

            long l = d;

            float f = l;

            string s = "hell";
            char ch = 'o';

            object o = s + ch;


            Console.WriteLine("***** Explictic Conversion - Bilinçli / Açık");
            int x = 6;
            byte by = (byte)x;

            float fl = 20.22f;
            byte bt = (byte)fl;

            int sayi = 12;
            string yazi = sayi.ToString();


            Console.WriteLine("***** System.Convert");
            string d1 = "10", d2 = "21";
            int deger1, deger2;
            int toplam;

            deger1 = Convert.ToInt32(d1);
            deger2 = Convert.ToInt32(d2);

            toplam = deger1 + deger2;

            Console.WriteLine("***** Parse");
            ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1 = "10", metin2 = "2,88";
            int rakam1;
            double dl;

            rakam1 = Int32.Parse(metin1);
            dl = Double.Parse(metin2);

            Console.WriteLine(dl);
        }
    }
}
