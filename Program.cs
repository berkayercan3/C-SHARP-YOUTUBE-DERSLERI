using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-Oyuncu 16 veya daha yüksek puan alırsa yeni bir araba kazanır.
//-Oyuncu 10 veya daha yüksek puan alırsa yeni bir dizüstü bilgisayar kazanır.
//-Oyuncu tam 7 puan alırsa seyahat kazanır.
//-Aksi takdirde oyuncu bir yavru kedi kazanır.

namespace DERS__0._7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random zar = new Random();

            int zar1 = zar.Next(1,2);
            int zar2 = zar.Next(1, 2);
            int zar3 = zar.Next(1, 3);

            int toplam = zar1 + zar2 + zar3;

            Console.WriteLine($"TOPLAM DEĞERİM: {zar1} + {zar2} + {zar3} = {toplam}");

            if ((zar1 == zar2) || (zar1 == zar3) || (zar2 == zar3))
            {
                if ((zar1 == zar2) && (zar2 == zar3))
                {
                    Console.WriteLine("OLAĞANÜSTÜ 3 ZARINIZ DA AYNI GELDİ.VE +6 PUAN KAZANDINIZ");
                    toplam += 6;
                }
                else
                {
                    Console.WriteLine("MÜKEMMEL DUBLE ATTINIZ. VE EKSTRA +2 PUAN KAZANDINIZ");
                    toplam += 2;
                }
            }

            if (toplam >= 16)
            {
                Console.WriteLine("TEBRİKLER ARABA KAZANDINIZ");
            }
            else if(toplam >= 10)
            { 
                Console.WriteLine("TEBRİKLER DİZÜSTÜ BİLGİSAYAR KAZANDINIZ");
            }
            else if(toplam == 7)
            {
                Console.WriteLine("TEBRİKLER SEYEHAT KAZANDINIZ");
            }
            else
            {
                Console.WriteLine("TEBRİKLER YAVRU KEDİ KAZADNINIZ");
            }

            Console.ReadLine();
        }
    }
}
