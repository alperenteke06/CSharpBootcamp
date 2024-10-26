using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen Şifrenizi Giriniz: ");
            //string pass = Console.ReadLine();
            //if (pass == "admin123")
            //{
            //    Console.WriteLine("Şifre Doğru!");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Hatalı!");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" & country == "Türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi!");
            //}

            //int number;
            //Console.Write("Sayı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı!");
            //}

            //int exam1, exam2, exam3, examAvg;
            //string res = "Hata";

            //Console.Write("Birinci Sınav Notunuzu Giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("İkinci Sınav Notunuzu Giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Üçüncü Sınav Notunuzu Giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());
            //examAvg = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine($"Ortalamanız : {examAvg}");

            //if (examAvg > 84)
            //{
            //    res = "Gayet İyi.";
            //}
            //else if (examAvg > 70 & examAvg <= 84)
            //{
            //    res = "İyi.";
            //}
            //else if (examAvg > 50 & examAvg <= 70)
            //{
            //    res = "Orta.";
            //}
            //else if (examAvg > 0 & examAvg <= 50)
            //{
            //    res = "Vasat";
            //}
            //Console.WriteLine("Sonuç: " + res);

            //string city;
            //Console.WriteLine("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if (city == "Bursa" | city == "Bilecik" | city == "İstanbul" | city == "Ankara" | city == "Eskişehir")
            //{
            //    Console.WriteLine("Şehir Mevcut!");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil!");
            //}

            //string username;
            //Console.WriteLine("Lütfen Kullanıcı Adı Girişi Yapınız: ");
            //username = Console.ReadLine();
            //if(username != "admin")
            //{
            //    Console.WriteLine("Bu Kullanıcı Adı Kabul Edilemez.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz!");
            //}
            #endregion

            #region Mod Process
            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen İlk Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen İkinci Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int res = number1 % number2;
            //if (res % 2 != 0)
            //{
            //    Console.WriteLine($"1. Sayıyının 2. Sayıya Bölümünden Kalan: {res} \nTek Sayı!");
            //}
            //else
            //{
            //    Console.WriteLine($"1. Sayıyının 2. Sayıya Bölümünden Kalan: {res}\nÇift Sayı!");
            //}
            #endregion

            #region Book Practice
            //Console.Write("Lütfen Karakter Giriniz");
            //Console.WriteLine("***** Karakterler *****");
            //Console.WriteLine("1-) G - g");
            //Console.WriteLine("1-) F - f");
            //Console.WriteLine("1-) T - t");
            //Console.WriteLine("1-) B - b");
            //char receivedChar = char.Parse(Console.ReadLine());
            //if (receivedChar == 'G' | receivedChar == 'g')
            //{
            //    Console.WriteLine("Seçilen Takım Galataray!");
            //}
            //else if (receivedChar == 'F' | receivedChar == 'f')
            //{
            //    Console.WriteLine("Seçilen Takım Fenerbahçe!");
            //}
            //else if (receivedChar == 'B' | receivedChar == 'b')
            //{
            //    Console.WriteLine("Seçilen Takım Beşiktaş!");
            //}
            //else if (receivedChar == 'T' | receivedChar == 't')
            //{
            //    Console.WriteLine("Seçilen Takım Trabzonspor!");
            //}
            //else
            //{
            //    Console.WriteLine("Takım Bulunamadı!");
            //}
            #endregion

            #region Practice Restourant
            //Console.WriteLine("***** C# Eğitim Kampı Restoranı *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("1-) Ana Yemekler");
            //Console.WriteLine("2-) Çorbalar");
            //Console.WriteLine("3-) Pizzalar");
            //Console.WriteLine("4-) İçecekler");
            //Console.WriteLine("5-) Tatlılar");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.WriteLine("Detayını Görmek İstediğiniz Menü Seçimi: ");

            //menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Ana Yemekler ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-) Köri Soslu Tavuk");
            //    Console.WriteLine("2-) Kızartma Tabağı");
            //    Console.WriteLine("3-) Fasulye Pilav");
            //    Console.WriteLine("4-) Fırında Somon");
            //    Console.WriteLine("5-) Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Ana Yemekler ------------");
            //}
            //else if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Çorbalar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-) Mercimek Çorbası");
            //    Console.WriteLine("2-) Ezogelin Çorbası");
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Çorbalar ------------");
            //}
            //else if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Pizzalar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-) Akdeniz Pizza");
            //    Console.WriteLine("2-) Margaritha Pizza");
            //    Console.WriteLine("2-) Tavuklu Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Pizzalar ------------");
            //}
            //else if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ İçecekler ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-) Kola");
            //    Console.WriteLine("2-) Ayran");
            //    Console.WriteLine("2-) Su");
            //    Console.WriteLine();
            //    Console.WriteLine("------------ İçecekler ------------");
            //}
            //else if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Tatlılar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-) Trilçe");
            //    Console.WriteLine("2-) Kazandibi");
            //    Console.WriteLine("2-) Sütlaç");
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Tatlılar ------------");
            //}
            #endregion

            #region Switch Case
            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi!"); break;
            //}

            int number1, number2, result;
            char process;

            Console.Write("1. Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Yapmak İstediğiniz İşlemi Giriniz: ");
            process = char.Parse(Console.ReadLine());

            switch (process)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;
                default:
                    Console.WriteLine("Hatalı İşlem Sembolü Girişi!");
                    break;
            }
            #endregion
            Console.Read();
        }
    }
}
