using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Methods
            /*
                ()
                Geriye Değer Döndürmeyen Methotlar (Void Methodlar)
                Customer -> Listele, Ekle, Sil, Güncelle
            */

            //void CustomerList()
            //{
            //    string[] customers = { "Alperen", "Eren", "Barış", "Mehmet", "Mert", "Ayşe", "Fatma" };
            //    foreach (string customer in customers)
            //    {
            //        Console.WriteLine(customer);
            //    }
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x = 10, y = 20, sum;
            //    sum = x + y;
            //    Console.WriteLine($"Toplam: {sum}");
            //}
            //Sum();


            #endregion

            #region String Void Methods With Paramaters
            //void MyWriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //MyWriteMethod("Alperen Teke");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine($"Müşteri: {name} {surName}");
            //}

            //CustomerCard("Alperen","Teke");
            //CustomerCard("Ayşe","Kaya");
            #endregion

            #region Int Void Methods With Paramaters
            //void Sum(int number1, int number2, int number3)
            //{
            //    int res = number1 + number2 + number3;
            //    Console.WriteLine(res);
            //}

            //Sum(10, 20, 30);
            #endregion

            #region Methods That Return a Value
            //string StudentCard()
            //{
            //    string name = "Alperen";
            //    string surname = "Teke";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());
            #endregion

            #region String Methods That Return a Value With Parameters
            //string CountryCard(string _cauntryName, string _capital, string _flagColor)
            //{
            //    string cardInfo = "Ülke: " + _cauntryName + " - " + "Başkent: " + _capital + " - " + "Bayrak Rengi: " + _flagColor;
            //    return cardInfo;
            //}
            //string cauntryName, capital, flagColor;
            //Console.Write("Lütfen Ülke Adını Giriniz: ");
            //cauntryName = Console.ReadLine();
            //Console.Write("Lütfen Başkent Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Lütfen Bayrak Renklerini Giriniz: ");
            //flagColor = Console.ReadLine();

            //Console.WriteLine(CountryCard(cauntryName, capital, flagColor));
            #endregion

            #region Int Methods That Return a Value With Parameters
            //int Sum(int number1, int number2)
            //{
            //    int res = number1 + number2;
            //    return res;
            //}

            //Console.WriteLine(Sum(10, 23));
            //Console.WriteLine(Sum(45, 67));
            //Console.WriteLine(Sum(12, 78));
            //Console.WriteLine(Sum(57, 35));
            #endregion

            #region Sample Practice
            string ExamResult(string studentName, int grade1, int grade2, int grade3)
            {
                string res;
                int gradeAvg = (grade1 + grade2 + grade3) / 3;
                if (gradeAvg >= 50 && gradeAvg <= 100)
                {
                    res = $"[{studentName}] - Başarılı ! - Not Ortalaması: {gradeAvg}";
                }
                else if (gradeAvg < 50 && gradeAvg > 0)
                {
                    res = $"[{studentName}] - Başarısız ! - Not Ortalaması: {gradeAvg}";
                }
                else
                {
                    res = $"[{studentName}]\nHatalı Veri Girişi! {gradeAvg}";
                }
                return res;
            }

            Console.Write("Lütfen Öğrenci Adını Giriniz: ");
            string sName = Console.ReadLine();
            Console.Write("Lütfen 1. Notu Giriniz: ");
            int g1 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen 2. Notu Giriniz: ");
            int g2 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen 3. Notu Giriniz: ");
            int g3 = int.Parse(Console.ReadLine());

            Console.WriteLine(ExamResult(sName, g1, g2, g3));
            #endregion

            Console.Read();
        }
    }
}
