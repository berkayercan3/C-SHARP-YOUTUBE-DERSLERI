using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS__0_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // iki adet sayıyı toplama

            //string ad = "berkay";
            //int sayi = 5;
            //Console.WriteLine(ad + " SATILDI " + (sayi + 5) + " sayi.");
            //Console.ReadLine();

            //int toplam = 7 + 5;
            //int çıkarma = 7 - 5;
            //int çarpma = 7 * 5;
            //int bölme = 7 / 5;

            //Console.WriteLine("Toplam değeri: " + toplam);
            //Console.WriteLine("ÇIkarma: " + çıkarma);
            //Console.WriteLine("çarpmanın değeri: " + çarpma);
            //Console.WriteLine("Bölme işlemin sonucu: " + bölme);


            //decimal ondalıklısayi = 7.0m / 5;
            //Console.WriteLine("sonuç: " + ondalıklısayi);

            // % simgesi mod alma işlemidir yani bölümünden kalan kaçtır anlamını bize veriyo

            //Console.WriteLine("bölümünden kaç kalır 200/5: " + (200%3) ); 

            //int örnek1 = 3 + 4 * 5;
            //int örnek2 = (3 + 4) * 5;
            //Console.WriteLine(örnek1);
            //Console.WriteLine(örnek2);

            //ARTTIRMA AZALTMA

            //int deger = 0;
            //deger = deger + 3;
            //deger -= 3;
            //Console.WriteLine(deger);

            //int deger = 0;
            //deger++; //1
            //ÇOK ÖNEMLİ
            //Console.WriteLine("1: " + deger); //1 
            //Console.WriteLine("2: " + deger++); //1
            //Console.WriteLine("3: " + deger); //2
            //Console.WriteLine("4: " + ++deger); //3

            //ÖRNEK
            //fahrenhayt olarak verilen sıcaklığı santigrat olarak dönüştüren kodu yazın
            //fahrenhayt dan 32 yi çıkarıyoruz ardından sonucu 5/9 ile çarpıyoruz

            int fahrenhayt = 84;
            decimal santigrat = (fahrenhayt - 32m) * (5m / 9m);
            Console.WriteLine("sıcaklığımız " + santigrat + " celsius.");



            Console.ReadLine();

        }
    }
}
