using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS__0_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KARAKTER KAÇIŞ DİZİLERİ
            //UTF-16 karakter kodlamısıdır UNICODE A
            // İKİ FARKLI DLDE FATURA OLUŞTURACAĞIZ
            // \t tab kadar boşluk bırakıcak , \n alt satıra geçirecek , \" özel karakter kullanmak istersek kullanıyoruz
            // \
            // @ ters slash ımızı ve boluk karakterlerimizi hepsini kullanmak için kullanılır
            // \u 353c  

            Console.WriteLine("ŞİRKETE FATURA OLUŞTURMA \"ABC CORP\"...\n");
            Console.WriteLine("FATURA: 50\t\tOLUŞTURULDU");
            Console.WriteLine("FATURA: 51\t\tOLUŞTURULDU");
            Console.WriteLine("\nÇIKIŞ DİZESİ:\t");
            Console.WriteLine(@"c:\faturalar");

            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine(@"c:\faturalar\uygulama.exe -j");
            Console.ReadLine();

            // çıktı olarak  \ almak 
           

        }
    }
}
