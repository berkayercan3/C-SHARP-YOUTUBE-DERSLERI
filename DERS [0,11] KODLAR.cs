using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS__0_11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Çalışanın düzeyini temsil eden sayıyı bir unvanla eşleştirmemizi
            //gerektiren bir senaryo düşünelim.Bu dallanma mantığını uygulayan 
            //bir switch-case yapı kullanacağız.

            //int calısansevıyesı = 200;
            //string calısanismi = "Ali Temel";

            //string unvan = "";

            //switch (calısansevıyesı) 
            //{
            //    case 100:
            //        unvan = "junıor";
            //        break;
            //    case 200:
            //        unvan = "Middle";
            //        break;
            //    case 300:
            //        unvan = "Senior";
            //        break;
            //    default:
            //        unvan = "Manager";
            //        break;
            //}
            //Console.WriteLine($"{calısanismi},{unvan}");
            //Console.ReadLine();

            //ÖRNEK

            //    Bir üniversite kentinde okulun logosunu ve renklerini taşıyan tişört, 
            //    eşofman ve diğer hediyelik eşyaların satıldığı bir hediyelik 
            //    eşya mağazasında çalıştığımızı düşünün.Aylık satış raporu, 
            //    satılan ürünlerin tam açıklamasının yanı sıra Stok Tutma 
            //    Birimi'ni (SKU) kullanır. Bizden kodun bazı bölümlerini daha 
            //    okunabilir olacak şekilde "yeniden" yazmamız istendi. 
            //    Görevlerden biri SKU'nun switch deyimi kullanılarak açıklamaya dönüştürülmesidir.

            // SKU = Stok Tutma Birimi

            string sku = "01-MN-L"; // barkod sweet shırt marron large

            string[] product = sku.Split('-');  // .Split yöntemi dahil edilen ifadeyi parçalarına ayırır ve bu ayırma işleminde eğer sembol, şekil gibi //ifadeler varsa bun ifadeleri ayraç olarak kullanır ve 						//bunlar arasında olan ifadeleri 
                                                //sırasıyla dizinine kaydeder
            string type = "";
            string color = "";
            string size = "";

            switch(product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
            }
            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }
            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }

            Console.WriteLine($"Product: {size} {color} {type}");
            Console.ReadLine();



            //if (product[0] == "01")
            //{
            //    type = "Sweat shirt";
            //}
            //else if (product[0] == "02")
            //{
            //    type = "T-Shirt";
            //}
            //else if (product[0] == "03")
            //{
            //    type = "Sweat pants";
            //}
            //else
            //{
            //    type = "Other";
            //}

            //if (product[1] == "BL")
            //{
            //    color = "Black";
            //}
            //else if (product[1] == "MN")
            //{
            //    color = "Maroon";
            //}
            //else
            //{
            //    color = "White";
            //}

            //if (product[2] == "S")
            //{
            //    size = "Small";
            //}
            //else if (product[2] == "M")
            //{
            //    size = "Medium";
            //}
            //else if (product[2] == "L")
            //{
            //    size = "Large";
            //}
            //else
            //{
            //    size = "One Size Fits All";
            //}



        }
    }
}
