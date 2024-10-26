using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic Array Exams
            //dataType [] arrayName = new dataType[lenght]

            //string[] colors = new string[5];
            //colors[0] = "Red";
            //colors[1] = "Green";
            //colors[2] = "Blue";
            //colors[3] = "Cyan";
            //colors[4] = "Magenta";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            ////4 is null, default value is 0
            //numbers[5] = 748;

            //Console.WriteLine(numbers[4]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);
            #endregion

            #region List All Elements In The Array
            //string[] colors = { "Red", "Green", "Blue", "Cyan", "Magenta", "Black", "Yellow", "Purple" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520, 7456, 2365, 1120, 75, 522 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine($"Dizi İçerisinde 3'e Tam Bölünen Sayı: {numbers[i]}");
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '\\', '-', '/' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myNumbers = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxVal = myNumbers[0];

            //for (int i = 0; i < myNumbers.Length; i++)
            //{
            //    if (myNumbers[i] > maxVal)
            //    {
            //        maxVal = myNumbers[i];
            //    }
            //}
            //Console.WriteLine($"En Yüksek Değer: {maxVal}");

            //string[] persons = { "Ali", "Alperen", "Mert", "Mehmet", "Eren", "Barış", "Murat" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Array Methods
            //string[] customers = { "Ali", "Buse", "Mert", "Ayşe", "Kayra", "Ahmet" };
            //int index = Array.IndexOf(customers, "Kayra");
            //Console.WriteLine(index + " - " + customers[index]);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " \n" +
            //    "Dizinin En Küçük Elemanı: " + numbers.Min());
            #endregion

            #region Receive Input from User
            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen Dizideki [{i + 1}] Numaralı Şehrini Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();

            //Console.WriteLine("-----------------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"{i}-) {cities[i]}");
            //}
            //Console.WriteLine("-----------------------");

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Finding Odd and Even Numbers in an Array
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            Console.WriteLine("***** Çift Sayılar *****");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine($"Çift Sayı: {numbers[i]}");
                }
            }
            Console.WriteLine("***** Çift Sayılar *****");
            Console.WriteLine();
            Console.WriteLine("***** Tek Sayılar *****");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine($"Tek Sayı: {numbers[i]}");
                }
            }
            Console.WriteLine("***** Tek Sayılar *****");
            #endregion
            Console.Read();
        }
    }
}
