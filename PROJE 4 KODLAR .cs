using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir dizi tanımlayın ve bu dizinin değerlerine rastgele sayı tanımlayın
            //ardından tanımladığınız sayıların toplamını bulun ve aynı zamanda dizinin son değerine
            //ulaştığınız anı kontrol edin , eğer kontrolünüz geçerliyse sonuncu değeri ekrana yazdırın
            //ve ardından toplam değerinizi ekrana yazdıran kodu yaziniz

            //Hatali kod yazdik
            //int[] numaralar = { 3, 5, 12, 32, 56, 23, 11 };
            //foreach(int number in numaralar)
            //{
            //    int toplam;
            //    toplam += number;
            //    if(number == 11)
            //    {
            //        bool kontrol = true; 
            //    }
            //}

            //if(kontrol)
            //{
            //    Console.WriteLine("sonuncu deger 11");
            //}

            //Console.WriteLine($"Toplam degeri: {toplam}");
            //Console.ReadLine();

            //Hatasiz kod

            int[] numaralar = { 3, 5, 12, 32, 56, 23, 11 };
            int toplam = 0;
            bool kontrol = false;

            foreach(int number in numaralar)
            {
                toplam += number;
                if (number == 11) kontrol = true;
            }

            if (kontrol) Console.WriteLine("Sonuncu degerim: 11");

            Console.WriteLine($"Toplam degeri: {toplam}");
            Console.ReadLine();
        }
    }
}
