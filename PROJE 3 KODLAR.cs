using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Bir satin alma sitesinde gun icerisinde belli basli
            //siparislerde bir dolandirilma mevzusu olmus.
            //Her siparisin kendine ait bir id si vardir ve 
            //bu id lerin baslangic harfi B ile baslayanlarda dolandirilma olmus,
            //bu idleri kullaniciya gsteren kodu yaziniz.
            //B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179

            string[] sıparıslerID = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach(string IDLER in sıparıslerID)
            {
                if(IDLER.StartsWith("B"))
                {
                    Console.WriteLine(IDLER);
                }
            }

            Console.ReadLine();

        }
    }
}
