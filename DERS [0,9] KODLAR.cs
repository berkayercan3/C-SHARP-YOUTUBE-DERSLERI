using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DERS__0_9_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BOOLE İFADELERİ 
            // == ESİT Mİ
            // != ESİT DEĞİL Mİ 

            Console.WriteLine("a" == "a");
            Console.WriteLine("a" == "A");
            Console.WriteLine(2 == 1);
            Console.WriteLine(1 != 2);
            string ifade1 = "a";
            Console.WriteLine(ifade1 != "a");

            Console.WriteLine("a" == "a ");

            string ifade2 = " a";
            string ifade3 = "A ";

            Console.WriteLine(ifade2.ToLower().Trim() == ifade3.ToLower().Trim());

            // Trim() aradaki boşlukları yok edecek 
            // ToLower() büyük harf küçük harf değişikliğini yok edecek

            Console.WriteLine(1 > 2);
            Console.WriteLine(2 <= 1);

            // MANTIKSAL OLUMSUZLAMA

            //İKİ İFADENİN BİRBİRNE EŞİT OLMAMA DURUMU KESİNLEŞTİRİ

            string ifade4 = "Berkay Ercan youtube dersleri";
            //Contains içerime anlamına gelen bir yöntemdir

            Console.WriteLine(ifade4.Contains("Berkay") == true);
            Console.WriteLine(!ifade4.Contains("berkay"));

            //KOŞULLU İŞLEÇ (?)

            //Bir müşterinin satın alma işleminin promosyon indirimine 
            //uygun olup olmadığını hızla belirlemeniz
            //gerektiğini varsayalım. Satış tutarı 1000’den
            //büyükse satın alma tutarına 100 dolar indirim uygulayın.
            //Tutar 1000 veya daha düşükse satışa yalnızca 50 dolar indirim uygulayın.

            int satıştutarı = 1001;

            if(satıştutarı>1000)
                Console.WriteLine("100 dolar indirim kazandınız");
            else
                Console.WriteLine("50 dolar indirim kazandınız");


            Console.WriteLine($"İndirim tutarınız: {(satıştutarı > 1000 ? 100 : 50)}");
            // küçük büyük karşılaştırması ile koşulu mu yazdırış oldumn
            // soru işareti if yerine kullanıldı
            // iki nokta ise else ifadeesi yerine kullanıldı

            //ÖRNEK ( YAZI MI TURA MI)
                //Değer oluşturmak için Random sınıfını kullanın. 
                //Değere göre, yazı veya tura değerini görüntülemek için koşullu işleci kullanın.
                //Sonucun yazı veya tura olması ihtimali % 50 olmalıdır.
                //İstenen sonucu üç veya daha az kod satırında gerçekleştirebilmelisiniz.

            // tura gelmesi 1 olsun
            //yazı gelmesi 0 olsun

            Random para = new Random();
            int üstyüzey = para.Next(0,2);
            Console.WriteLine((üstyüzey == 0) ? "yazı geldi" : "Tura geldi");

            // DAHA SADE HALi
            Random para2 = new Random();
            Console.WriteLine((para2.Next(0, 2) == 1) ? "Tura geldi" : "Yazı geldi");

            Console.ReadLine();

        }
    }
}
