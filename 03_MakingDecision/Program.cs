using System;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if else

            Console.Write("Lütfen şifreyi giriniz: ");
            string password;
            password = Console.ReadLine();

            if (password == "abcd")
            {
                Console.WriteLine("Şifre doğru");
            }
            else
            {
                Console.WriteLine("Şifre yanlış");
            }

            Console.WriteLine("------------------------");

            string capital, country;

            Console.Write("Başkent Giriniz: ");
            capital = Console.ReadLine();

            Console.Write("Ülke Giriniz: ");
            country = Console.ReadLine();

            if (capital == "ankara" && country == "türkiye")
            {
                Console.WriteLine("Veriler doğrulandı");
            }
            else
            {
                Console.WriteLine("Hatalı bilgi");
            }

            Console.WriteLine("------------------------");

            int number;
            Console.Write("Sayıyı giriniz: ");
            number = int.Parse(Console.ReadLine());

            if (number == 5)
            {
                Console.WriteLine("Sayı doğru");
            }
            else
            {
                Console.WriteLine("Sayı yanlış");
            }

            Console.WriteLine("------------------------");

            int exam1, exam2, exam3, average;
            string result = "Hatalı Giriş";

            Console.Write("1. Sınavı giriniz: ");
            exam1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sınavı giriniz: ");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("3. Sınavı giriniz: ");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Sınavların ortalaması: " + average);

            if (average > 0 && average <= 50)
            {
                result = "Sonuç vasat";
            }
            if (average > 50 && average <= 70)
            {
                result = "Sonuç orta";
            }
            if (average > 70 && average <= 84)
            {
                result = "Sonuç iyi";
            }
            if (average > 85 && average <= 100)
            {
                result = "Sonuç çok iyi";
            }

            Console.WriteLine(result);

            Console.WriteLine("------------------------");

            string city;
            Console.Write("Şehir giriniz: ");
            city = Console.ReadLine();

            if (city == "ankara" || city == "istanbul" || city == "izmir")
            {
                Console.WriteLine("Şehir mevcut");
            }
            else
            {
                Console.WriteLine("Şehir mevcut değil");
            }

            Console.WriteLine("------------------------");

            Console.Write("Kullanıcı adı giriniz: ");
            string username = Console.ReadLine();

            if (username != "admin")
            {
                Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            }
            else
            {
                Console.WriteLine("Hoşgeldiniz");
            }

            Console.WriteLine("------------------------");
            //mod işlemleri

            int number1;
            number1 = 26;
            int result1 = number1 % 5;
            Console.WriteLine(result1);

            Console.WriteLine("------------------------");

            Console.Write("1. Sayıyı giriniz: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("2. Sayıyı giriniz: ");
            int number3 = int.Parse(Console.ReadLine());

            int result2 = number2 % number3;
            Console.WriteLine("1. sayının 2. sayıya bölümünden kalan: " + result2);

            Console.WriteLine("------------------------");

            Console.Write("Sayıyı giriniz: ");
            int number4 = int.Parse(Console.ReadLine());

            if (number4 % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir");
            }
            else
            {
                Console.WriteLine("Sayı tektir");
            }

            Console.WriteLine("------------------------");

            char team;
            Console.Write("Lütfen takım sembolünü giriniz: ");
            team = char.Parse(Console.ReadLine());

            if (team == 'g' || team == 'G')
            {
                Console.WriteLine("Galatasaray");
            }
            if (team == 'f' || team == 'F')
            {
                Console.WriteLine("Fenerbahçe");
            }
            if (team == 'b' || team == 'B')
            {
                Console.WriteLine("Beşiktaş");
            }

            Console.WriteLine("------------------------");

            Console.WriteLine("****** C# Eğitim Kampı Restorant ******");
            Console.WriteLine();
            Console.WriteLine("**********************");
            Console.WriteLine("1. Ana Yemekler");
            Console.WriteLine("2. Çorbalar");
            Console.WriteLine("3. Pizzalar");
            Console.WriteLine("4. İçecekler");
            Console.WriteLine("5. Tatlılar");
            Console.WriteLine("**********************");

            string menuItem;

            Console.Write("Detayını görmek istediğiniz menü seçin: ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine("1. Kuzu Tandır");
                Console.WriteLine("2. İskender");
                Console.WriteLine("3. Kuzu Şiş");
            }
            if (menuItem == "2")
            {
                Console.WriteLine("1. Mercimek Çorbası");
                Console.WriteLine("2. Tarhana Çorbası");
                Console.WriteLine("3. Domates Çorbası");
            }
            if (menuItem == "3")
            {
                Console.WriteLine("1. Sucuklu Pizza");
                Console.WriteLine("2. Kavurmalı Pizza");
                Console.WriteLine("3. Mantarlı Pizza");
            }
            if (menuItem == "4")
            {
                Console.WriteLine("1. Ayran");
                Console.WriteLine("2. Kola");
                Console.WriteLine("3. Limonata");
            }
            if (menuItem == "5")
            {
                Console.WriteLine("1. Kadayıf");
                Console.WriteLine("2. Baklava");
                Console.WriteLine("3. Sütlaç");
            }

            Console.WriteLine("------------------------");
            //switch case

            Console.Write("Lütfen ay girişi yapınız:");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Ağustos");
                    break;
                case 9:
                    Console.WriteLine("Eylül");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                case 12:
                    Console.WriteLine("Aralık");
                    break;
                default:
                    Console.WriteLine("Hatalı giriş");
                    break;
            }

            Console.WriteLine("------------------------");

            int number5, number6, result3;
            char symbol;

            Console.Write("1. Sayıyı giriniz: ");
            number5 = int.Parse(Console.ReadLine());

            Console.Write("2. Sayıyı giriniz: ");
            number6 = int.Parse(Console.ReadLine());

            Console.Write("İşlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result3 = number5 + number6;
                    Console.WriteLine("Toplam: " + result3);
                    break;
                case '-':
                    result3 = number5 - number6;
                    Console.WriteLine("Fark: " + result3);
                    break;
                case '*':
                    result3 = number5 * number6;
                    Console.WriteLine("Çarpım: " + result3);
                    break;
                case '/':
                    result3 = number5 / number6;
                    Console.WriteLine("Bölüm: " + result3);
                    break;
                default:
                    Console.WriteLine("Hatalı giriş");
                    break;
            }




            Console.Read();
        }
    }
}
