using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutarı
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Merhaba!");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-) Çorbalar");
            //Console.WriteLine("2-) Ana Yemekler");
            //Console.WriteLine("3-) Soğuk Başlangıçlar");
            //Console.WriteLine("4-) Salatalar");
            //Console.WriteLine("5-) Tatlılar");
            //Console.WriteLine("6-) İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            #endregion YazdırmaKomutarı

            #region StringDeğişkenler
            //string name = "Alperen";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, customerDistrict, customerCity;

            //customerName = "Alperen";
            //customerSurname = "Teke";
            //customerPhone = "+90 555 555 55 55";
            //customerEmail = "alperen.teke06@gmail.com";
            //customerDistrict = "Kadıköy";
            //customerCity = "İstanbul";

            //Console.WriteLine("***** Rezarvasyon Kartı *****");
            //Console.WriteLine("----------------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            //Console.WriteLine("----------------------------------------------------------");
            //Console.WriteLine();

            //customerName = "Murat";
            //customerSurname = "Yücedağ";
            //customerPhone = "+90 555 555 55 55";
            //customerEmail = "muratyucedag@gmail.com";
            //customerDistrict = "Sapanca";
            //customerCity = "Sakarya";

            //Console.WriteLine("----------------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            //Console.WriteLine("----------------------------------------------------------");

            #endregion StringDeğişkenler

            #region IntDeğişkenler
            //int number = 18;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int pizzaPrice = 250;
            int friesPrice = 50;
            int cokePrice = 35;
            int lemonadePrice = 30;
            int waterPrice = 10;

            Console.WriteLine("***** Restoran Menü Fiyatları *****");
            Console.WriteLine();
            Console.WriteLine("------Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("------Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("------Kızartmalar: " + friesPrice + "TL");
            Console.WriteLine("------Kola: " + cokePrice + "TL");
            Console.WriteLine("------Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("------Su: " + waterPrice + "TL");
            Console.WriteLine("***** Restoran Menü Fiyatları *****");
            Console.WriteLine();

            int hamburgerCount;
            int pizzaCount;
            int friesCount;
            int cokeCount;
            int lemonadeCount;
            int waterCount;

            
            hamburgerCount = 3;
            pizzaCount = 0;
            friesCount = 1;
            cokeCount = 3;
            lemonadeCount = 0;
            waterCount = 3;

            int totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            int totalPizzaPrice = pizzaCount * pizzaPrice;
            int totalFriesPrice = friesCount * friesPrice;
            int totalCokePrice = cokeCount * cokePrice;
            int totalLemonadePrice = lemonadeCount * lemonadePrice;
            int totalWaterPrice = waterCount * waterPrice;
            int totalPrice = 0;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Hamburger Toplam Tutar: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Toplam Tutar: " + totalPizzaPrice + "TL");
            Console.WriteLine("Kızartmalar Toplam Tutar: " + totalFriesPrice + "TL");
            Console.WriteLine("Kola Toplam Tutar: " + totalCokePrice + "TL");
            Console.WriteLine("Limonata Toplam Tutar: " + totalLemonadePrice + "TL");
            Console.WriteLine("Su Toplam Tutar: " + totalWaterPrice + "TL");
            Console.WriteLine();
            totalPrice =
                (totalHamburgerPrice + totalPizzaPrice + totalFriesPrice + totalCokePrice 
                + totalLemonadePrice + totalWaterPrice);
            Console.WriteLine("Toplam Tutar: " + totalPrice + "TL");
            Console.WriteLine("-----------------------------------");

            #endregion IntDeğişkenler

            Console.Read();
        }
    }
}