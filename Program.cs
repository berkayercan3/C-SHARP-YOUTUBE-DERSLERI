using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Üç altı taraflı zar atmayı simüle etmek için yöntemini kullanacağız Random.Next() . Puanı hesaplamak için değerleri değerlendireceğiz. Puan rastgele toplamdan büyükse kullanıcıya kazanan bir ileti görüntüleriz. Aksi takdirde, kullanıcıya kaybetme iletisi görüntüleriz.

//-Attığınız iki zar aynı değerle sonuçlanırsa çifte zar attığınız için ekstra iki puan kazanırsınız.
//-Attığınız üç zarın tümü de aynı değerle sonuçlanırsa üçlü zar attığınız için ekstra altı puan kazanırsınız.
//-Attığınız üç zarın toplamı artı ekstra puanlar 15 veya daha büyük olursa oyunu kazanırsınız. Aksi takdirde kaybedersiniz.

namespace DERS__0_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random zar = new Random();

            int zar1 = zar.Next(1,1);
            int zar2 = zar.Next(1,1);
            int zar3 = zar.Next(1,1);

            int toplam = zar1 + zar2 + zar3;

            Console.WriteLine($"TOPLAM DEĞERİM: {zar1} + {zar2} + {zar3} = {toplam}");

            if( (zar1==zar2) || (zar1==zar3) || (zar2==zar3) )  // 2 TANE EŞİTTİR EŞİTSE ANLAMINA GELİR 2 TANE | ÇİZGİ VEYA ANLAMINA GELİR
            {
                Console.WriteLine("MÜKEMMEL DUBLE ATTINIZ. VE EKSTRA +2 PUAN KAZANDINIZ");
                toplam += 2;
            }

            if( (zar1==zar2) && (zar2==zar3) ) // 2 tane gemici düğümü VE anlamına gelir
            {
                Console.WriteLine("OLAĞANÜSTÜ 3 ZARINIZ DA AYNI GELDİ.VE +6 PUAN KAZANDINIZ");
                toplam += 6;
            }

            if (toplam >= 15) // eğer anlamına geliyo , >= 15 e eşit ve 115 ten büyükse anlamına geldi
            {
                Console.WriteLine("TEBRİKLER KAZANDINIZ");
            }

            if (toplam < 15)
            {
                Console.WriteLine("ÜZGÜNÜZ KAYBETTİNİZ");
            }
            Console.ReadLine();


        }
    }
}
