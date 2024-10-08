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
            //For Döngüsü

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------");

            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------");

            for (int i = 3; i <= 50; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------");

            Console.Write("Lütfen ekrana yazılmasını istediğiniz sayı adedini girin: ");
            int finisValue = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= finisValue; i++)
            {
                Console.WriteLine("Yaşasın Cumhuriyet");
            }

            Console.WriteLine("------------------------");

            //For döngüsü ile karar yapıları kullanımı

            for (int i = 1; i <= 50; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("------------------------");

            int totalValue = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    totalValue += i;
                }
            }

            Console.WriteLine(totalValue);

            Console.WriteLine("------------------------");

            int bacterium = 1;

            for (int i = 1; i <= 10; i++)
            {
                bacterium *= 2;
                Console.WriteLine(i + ". Saat: " + bacterium);
            }

            Console.WriteLine("------------------------");

            //While Döngüsü

            int i1 = 1;

            while (i1 <= 10)
            {
                Console.WriteLine(i1);
                i1++;
            }

            Console.WriteLine("------------------------");

            int i2 = 1;

            while (i2 <= 10)
            {
                if (i2 % 3 == 0)
                {
                    Console.WriteLine(i2);
                }
                i2++;
            }

            Console.WriteLine("------------------------");

            int i3 = 1;
            int sum = 0;

            while (i3 <= 10)
            {
                sum += i3;
                i3++;

            }

            Console.WriteLine(sum);

            Console.WriteLine("------------------------");

            //Örnek Soru

            Console.Write("Lütfen 3 basamaklı bir sayı girin: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;

            ones = number % 10;
            tens = (number / 10) % 10;
            hundreds = number / 100;

            Console.WriteLine("Birler Basamağı: " + ones+" Onlar Basamağı: "+tens+" Yüzler Basamağı: "+hundreds);
            sum = ones + tens + hundreds;
            Console.WriteLine("Sayının basamakları toplamı: " + sum);

            Console.ReadLine();
        }
    }
}
