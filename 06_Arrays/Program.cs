using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Temel Dizi İşlemleri
            string[] colors = new string[4];
            colors[0] = "Kırmızı";
            colors[1] = "Mavi";
            colors[2] = "Yeşil";
            colors[3] = "Sarı";

            Console.WriteLine(colors[1]);

            Console.WriteLine("------------------------");

            string[] cities = { "Ankara", "İstanbul", "İzmir" };

            Console.WriteLine(cities[1]);

            Console.WriteLine("------------------------");
            //Listedeki tüm elemanları yazdırma

            string[] colors2 = { "Kırmızı", "Mavi", "Yeşil", "Sarı" };

            for (int i = 0; i < colors2.Length; i++)
            {
                Console.WriteLine(colors2[i]);
            }

            Console.WriteLine("------------------------");

            int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("------------------------");

            int[] myarrays = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            int max = myarrays[0];

            for (int i = 1; i < myarrays.Length; i++)
            {
                if (myarrays[i] > max)
                {
                    max = myarrays[i];
                }
            }
            Console.WriteLine(max);

            Console.WriteLine("------------------------");

            int[] numbers2 = { 45, 85, 52, 41, 86, 10, 22 };
            Array.Sort(numbers2);

            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }

            Console.WriteLine("--");

            Array.Reverse(numbers2);

            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }

            Console.WriteLine("------------------------");
            //Dizi Metotlar

            string[] customers = { "Engin", "Derin", "Salih" };
            int index = Array.IndexOf(customers, "Derin");
            Console.WriteLine(index);

            Console.WriteLine("------------------------");

            int[] numbers3 = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            Console.WriteLine("Dizinin en büyük elemanı: "+numbers3.Max()+", Dizinin en küçük elemanı: "+numbers3.Min());

            Console.WriteLine("------------------------");
            //Kullanıcıdan değer alma

            string[] cities1 = new string[3];

            for (int i = 0; i < cities1.Length; i++)
            {
                Console.Write($"{i+1}. Şehri Griniz: ");
                cities1[i] = Console.ReadLine();
            }
            Console.WriteLine("--");
            for (int i = 0; i < cities1.Length; i++)
            {
                Console.WriteLine(cities1[i]);
            }

            Console.WriteLine("------------------------");

            Console.ReadLine();
        }
    }
}
