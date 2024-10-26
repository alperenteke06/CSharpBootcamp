using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            /* double number;
               number=4.75;
               Console.WriteLine($"Value: {number}"); */

            Console.WriteLine("***** Fiyat Listesi *****");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.60;
            strawberryPrice = 35;
            potatoPrice = 9.75;
            tomatoPrice = 7.44;

            Console.WriteLine($"---- Elma Birim Fiyatı: {applePrice} TL");
            Console.WriteLine($"---- Portakal Birim Fiyatı: {orangePrice} ");
            Console.WriteLine($"---- Çilek Birim Fiyatı: {strawberryPrice}");
            Console.WriteLine($"---- Patates Birim Fiyatı: {potatoPrice}");
            Console.WriteLine($"---- Domates Birim Fiyatı: {tomatoPrice}");

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 3.400;
            orangeGram = 2.480;
            strawberryGram = 2.545;
            potatoGram = 1.520;
            tomatoGram = 2.250;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine();
            Console.WriteLine($"Alınan Ürün: Elma - Birim Fiyat: {applePrice} - Gramaj: {appleGram} - Toplam Tutar: {appleTotalPrice} TL");
            Console.WriteLine($"Alınan Ürün: Portakal - Birim Fiyat: {orangePrice} - Gramaj: {orangeGram} - Toplam Tutar: {orangeTotalPrice} TL");
            Console.WriteLine($"Alınan Ürün: Çilek - Birim Fiyat: {strawberryPrice} - Gramaj: {strawberryGram} - Toplam Tutar: {strawberryTotalPrice} TL");
            Console.WriteLine($"Alınan Ürün: Patates - Birim Fiyat: {potatoPrice} - Gramaj: {potatoGram} - Toplam Tutar: {potatoTotalPrice} TL");
            Console.WriteLine($"Alınan Ürün: Domates - Birim Fiyat: {tomatoPrice} - Gramaj: {tomatoGram} - Toplam Tutar: {tomatoTotalPrice} TL");

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Alışveriş Toplam Tutar: {shoppingTotalPrice}");
            #endregion

            #region Char Değişkenler
            char symbol;
            symbol = 'a';
            Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri - String Değişkenler
            Console.WriteLine("***** C# Hava Yolları Yolcu Bilgisi *****");
            Console.WriteLine();
            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();
            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();
            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();
            Console.Write("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();
            Console.Write("Yolcu Yaş: ");
            passengerAge = Console.ReadLine();
            Console.WriteLine("Yolcu TC Kimlik No: ");
            passengerIdentityNumber = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine($"Yolcu TC Kimlik No: {passengerIdentityNumber} Yolcu Ad Soyad: {passengerName} {passengerSurname} {passengerDistrict}/{passengerCity} " +
                $"{passengerAge}");
            Console.WriteLine("--------------------");
            #endregion

            #region Klavyeden Veri Girişleri Ve Dönüşümler - Int Değişkenler
            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız Koltuk Sayısını Giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice +
                chairCount * chairPrice + tvCount * tvPrice;

            Console.WriteLine();
            Console.WriteLine($"Toplam Ödemeniz Gereken Tutar: {totalPrice}");
            #endregion
            
            #region Klavyeden Veri Girişleri - Double Değişkenler
            double exam1, exam2, exam3, res;

            Console.Write("Lütfen 1. Sınav Notunuzu Giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. Sınav Notunuzu Giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3. Sınav Notunuzu Giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            res = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();
            Console.WriteLine($"Ders Ortalamanız: {res}");
            #endregion

            #region Klavyeden Veri Girişleri - Char Değişkenler
            char gender;
            Console.Write("Lütfen Cinsiyet Seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine($"Seçtiğiniz Cinsiyet: {gender}");
            #endregion

            Console.Read();
        }
    }
}
