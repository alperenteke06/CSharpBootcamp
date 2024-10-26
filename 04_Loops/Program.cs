using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loop
            //for (x;y;z)
            //x = başlangıç
            //y = bitiş
            //z = artış - azalış

            //int i;
            //for(i = 1; i<=5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <=50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Lütfen ekrana yazılması gereken adeti giriniz: ");
            //int finishVal = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= finishVal; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            #endregion

            #region Using the For loop with Decision Structures
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine($"5'e Tam Bölünen Sayı: {i}");
            //    }
            //}

            //int totalVal = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    totalVal += i;
            //}
            //Console.WriteLine(totalVal);

            //int totalVal = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        totalVal += i;
            //        Console.WriteLine($"Değişken Değeri: {i}");
            //    }
            //}
            //Console.WriteLine("-------");
            //Console.WriteLine(totalVal);

            //int totalCount = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        totalCount++;
            //    }
            //}
            //Console.WriteLine(totalCount);

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine($"Saat: {i} Sonunda. - Bakteri Sayısı: {bacterium}");
            //}
            #endregion

            #region While Loop
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i%3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Sample Exam Question
            ////Klavyeden Girilen 3 Basamaklı Sayının Basamakları Toplamını Bulunuz!
            ////Örnek Değer = 456
            //Console.Write("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens= (number % 100) / 10;
            //hundreds = number / 100; //4.56 --> 4 (int tipinde değişken)

            ////Console.WriteLine(hundreds + "-" + tens + "-" + ones);

            //sum = ones + tens + hundreds;
            //Console.WriteLine(sum);
            #endregion
            Console.Read();
        }
    }
}
