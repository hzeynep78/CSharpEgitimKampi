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
            double number = 4.85;

            Console.WriteLine(number);

            Console.WriteLine("------------------------");

            char symbol = 'A';

            Console.WriteLine(symbol);

            Console.WriteLine("------------------------");
            //Klavyeden veri girişi

            Console.WriteLine("***CSharp Hava Yolları Yolcu Bilgisi");

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("Yolcu İlçe: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Yolcu Şehir: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaş: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu T.C. Kimlik Numarası: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine("**********************");

            Console.WriteLine("Yolcu: " + passengerName + "/" + passengerSurname + "/" + passengerDistrict + "/" + passengerCity + "/" + passengerAge + "/" + passengerIdentityNumber);

            Console.WriteLine("------------------------");

            //Klavyeden Tam Sayı Girişi

            int shoePrice, computerPrice, chairPrice, tvPrice;
            shoePrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoeCount, computerCount, chairCount, tvCount;

            Console.Write("Ayakkabı Adet: ");
            shoeCount = int.Parse(Console.ReadLine());
            //csharp veri girişlerini string olarak alır.Bu yüzden int'e çevirmemiz gerekiyor.

            Console.Write("Bilgisayar Adet: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Sandalye Adet: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Televizyon Adet: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrices = (shoePrice * shoeCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);
            Console.Write("Toplam tutarınız: " + totalPrices);

            Console.WriteLine("------------------------");

            //Klavyeden ondalıklı sayı girişi

            double exam1, exam2, exam3, result;

            Console.Write("1. Sınav: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("2. Sınav: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("3. Sınav: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Ortalama: " + result);

            Console.WriteLine("------------------------");
            //Klavyeden karakter girişi

            char gender;

            Console.Write("Cinsiyet giriniz: ");
            gender = char.Parse(Console.ReadLine());


            Console.ReadLine();
        }
    }
}
