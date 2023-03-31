//string isim = null;

//if(isim=="Ali")
//{
//    string soyisim = "Abc";
//    Console.WriteLine($"{isim}");
//    Console.WriteLine($"{soyisim}");
//}


//Console.ReadLine();


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//KOD BLOKLARI

namespace DERS__0_10__ // AD ALANIMIZ
{
    class Program // SINIF ALANIMIZ
    {
        static void Main(string[] args) // YÖNTEM ALANI
        {
            string name = "hasa";
            if (name == "hasan") Console.WriteLine("hasani bulduk");
            else if (name == "ali") Console.WriteLine("aliyi bulduk");
            else Console.WriteLine("baskasini bulduk");
            Console.ReadLine();
        }
    }
}

//aynı sınıftaki bir yöntemi çağırma

//namespace internetsitesi  //ad alani
//{
//    class Program// sinifimiz
//    {
//        static void Main(string[] args) // yontemimiz
//        {
//            string isim = "Berkay";
//            string cagrilan = cagirma(isim);
//            Console.WriteLine($"{cagrilan}");
//            Console.ReadLine();
//        }

//        static string cagirma(string message)
//        {
//            char[] dizi = message.ToCharArray();
//            Array.Reverse(dizi);
//            return new string(dizi);
//        }

//    }
//} // AYNI SINIF İÇERİSİNDEKİ FARKLI YÖNTEMLERE SADECE YÖNTEMİN İSMİNİ KULLANARAK ÇAĞIRABİLİRİZ

//ToCharArray bir veriyi karakterlerine ayirip char tipinde tanimlanmis bir diziye aktarir
//Array.Reverse(dizi); dizi elemanlarimi tersine cevirdi
//return ile yeniden olkusturulan dizimiz yenilenmis sekilde programa yeniden donderildi



// FARKLI SINIFLAR ARASI YÖNTEM ÇAĞIRMA

//using System;

//namespace MyNewApp
//{
//    class Program// sinifimiz
//    {
//        static void Main(string[] args) // yontemimiz
//        {
//            string isim = "Berkay";
//            string cagrilan = program2.cagirma(isim);
//            Console.WriteLine($"{cagrilan}");
//            Console.ReadLine();
//        }
//    }

//    class program2
//    {
//        public static string cagirma(string message)
//        {
//            char[] dizi = message.ToCharArray();
//            Array.Reverse(dizi);
//            return new string(dizi);
//        }
//    }
//}



//FARKLI AD ALANLARI ARASI YÖNTEM ÇAĞIRMA


//namespace internetsitesi  //ad alani
//{
//    class Program// sinifimiz
//    {
//        static void Main(string[] args) // yontemimiz
//        {
//            string isim = "Berkay";
//            string cagrilan = internetsitesi.tasarim.program2.cagirma(isim);
//            Console.WriteLine($"{cagrilan}");
//            Console.ReadLine();
//        }
//    }
//}

//namespace internetsitesi.tasarim
//{
//    class program2
//    {
//       public static string cagirma(string message)
//        {
//            char[] dizi = message.ToCharArray();
//            Array.Reverse(dizi);
//            return new string(dizi);
//        }
//    }
//}


