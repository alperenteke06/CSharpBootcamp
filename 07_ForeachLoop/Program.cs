using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loop
            /* Foreach(1;2;3;4)
               1-) Variable Type
               2-) Variable Name
               3-) In
               3-) List, Collection, Array
            */

            //string[] cities = { "İstanbul", "Ankara", "Eskişehir", "Bursa", "Bilecik" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int sum = 0;
            //foreach (int i in numbers)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //List<int> numbers = new List<int>()
            //{ 4, 6, 8, 12, 24 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Hello";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region Sample Examination System Practice
            Console.WriteLine("***** C# Bootcamp Sınav Sistemi Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            /* Getting Student Count from User */
            Console.WriteLine("------------------------------------------------");
            Console.Write("Sınıfınızdaki Öğrenci Sayısını Giriniz: ");
            int countOfStudent = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------");
            /* Arrays to store student names and exam avgs */
            string[] studentNames = new string[countOfStudent];
            double[] studentExamAvg = new double[countOfStudent];
            for (int i = 0; i < countOfStudent; i++)
            {
                Console.Write($"Lütfen {i + 1}. Öğrencinin Adını Giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamRes = 0;

                //3 Exam Grade Entries Input for each student
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{studentNames[i]}] Adlı Öğrencinin {j + 1}. Sınav Notunu Giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamRes += value; //Adding Grades
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamRes / 3;
            }

            /* Student's Grade Point Average And Class Success Status */
            for (int i = 0; i < countOfStudent; i++)
            {
                Console.WriteLine("------------------------");
                /* Student's Grade Point Average */
                Console.WriteLine($"[{studentNames[i]}] Adlı Öğrencinin Ortalaması: {studentExamAvg[i]}");
                /* Student's Class Success Status */
                Console.WriteLine($"[{studentNames[i]}] Adlı Öğrencinin Sınıf Durumu: {(studentExamAvg[i] >= 50 ? "Başarılı!" : "Başarısız!")}");
                Console.WriteLine("------------------------");
            }
            #endregion

            Console.Read();
        }
    }
}
