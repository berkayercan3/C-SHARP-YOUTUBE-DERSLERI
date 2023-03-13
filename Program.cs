using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Student: berkay ercan
                                                 
//Course            grade   Credit	
//English       	  4       3
//Algebra        	  3       3
//Biology         	  3       4
//Computer Science I  3       4
//Psychology          4       3

//Final GPA:          3.35

namespace proje2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ogrenciismi = "BERKAY ERCAN";
            string kurs1 = "englısh";
            string kurs2 = "algebra";
            string kurs3 = "bıology";
            string kurs4 = "Computer Scınce";
            string kurs5 = "Physchology";

            int kurs1Credit = 3;
            int kurs2credit = 3;
            int kurs3credit = 4;
            int kurs4credit = 4;
            int kurs5credit = 3;

            int gradeA = 4;
            int gradeB = 3;

            int kurs1grade = gradeA;
            int kurs2grade = gradeB;
            int kurs3grade = gradeB;
            int kurs4grade = gradeB;
            int kurs5grade = gradeA;

            Console.WriteLine($"Öğenci: {ogrenciismi} \n");
            Console.WriteLine("Kurs\t\tGRADE\tCREDİT");
            Console.WriteLine($"{kurs1} \t{kurs1grade} \t{kurs1Credit}");
            Console.WriteLine($"{kurs2} \t{kurs2grade} \t{kurs2credit}");
            Console.WriteLine($"{kurs3} \t{kurs3grade} \t{kurs3credit}");
            Console.WriteLine($"{kurs4} {kurs4grade} \t{kurs4credit}");
            Console.WriteLine($"{kurs5} \t{kurs5grade} \t{kurs5credit}\n");

            int toplamkredisayisi = 0;

            toplamkredisayisi += kurs1Credit;
            toplamkredisayisi += kurs2credit;
            toplamkredisayisi += kurs3credit;
            toplamkredisayisi += kurs4credit;
            toplamkredisayisi += kurs5credit;

            int derslerinçarpımsonucu=0;

            derslerinçarpımsonucu += kurs1Credit * kurs1grade;
            derslerinçarpımsonucu += kurs2credit * kurs2grade;
            derslerinçarpımsonucu += kurs3credit * kurs3grade;
            derslerinçarpımsonucu += kurs4credit * kurs4grade;
            derslerinçarpımsonucu += kurs5credit * kurs5grade;

            decimal notlarınortalaması = derslerinçarpımsonucu / toplamkredisayisi;

            Console.WriteLine($"FINAL GPA: {notlarınortalaması}");
            Console.ReadLine();
                    
        }
    }
}
