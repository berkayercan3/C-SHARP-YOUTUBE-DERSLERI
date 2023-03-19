using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS__0_8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sınıf = { "ayse", "ali", "vedat" };

            //sınıf[0] = "Ayşe";
            //sınıf[1] = "mehmet";
            //sınıf[2] = "ali";
            
            //Console.WriteLine($"İLK ELEMAN: {sınıf[0]}");
            //Console.WriteLine($"İKİNCİ ELEMAN:{sınıf[1]}");
            //Console.WriteLine($"UCUNCU ELEMAN:{sınıf[2]}");
            Console.WriteLine($"DİZİMİZ BOYUTU : {sınıf.Length} dır ");

            foreach(string sınıf1 in sınıf) // 0 dan başlayarak bellirtiğimiz sayıda döngüyü kullanmamızı sağlar
            {
                Console.WriteLine(sınıf1);
            }

            int[] sayılar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int toplam = 0;
            int döngü = 0;

            foreach(int sayılarıntoplamu in sayılar) 
            {
                toplam += sayılarıntoplamu;
                döngü++;
                Console.WriteLine($"{döngü}. Tur sayısı: dizimizin şuanki toplam değeri: {toplam}  ");
            }
            Console.WriteLine($"dizimizin toplam değeri: {toplam}");
            Console.ReadLine();

        }
    }
}
