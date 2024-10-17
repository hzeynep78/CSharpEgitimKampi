using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Foreach Döngüsü
            //Foreach(1;2;3;4)
            //1: Değişken türü
            //2: Değişken Adı
            //3: In
            //4: Liste, koleksiyon

            string[] cities = { "Ankara", "İstanbul", "İzmir" };

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("------------------------");

            int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205};
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }

            Console.WriteLine("------------------------");

            int[] numbers1 = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205 };
            int total = 0;

            foreach (int number in numbers1)
            {
                total += number;
            }

            Console.WriteLine("Toplam: " + total);

            Console.WriteLine("------------------------");

            List<int> numbers2 = new List<int>()
            {
                1,2,3,4,5
            };

            foreach (int number in numbers2)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("------------------------");

            string word = "Merhaba";

            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine("------------------------");
            //Örnek Sınav Sistemi Uygulaması

            Console.Write("Sınıfta kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());

            string[] studentNames = new string[studentCount];
            double[] studentExam = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrenci Adı: ");
                studentNames[i] = Console.ReadLine();

                double totalExam = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} Öğrencinin {j + 1}. Sınav Notu: ");
                    double exam = double.Parse(Console.ReadLine());
                    totalExam += exam;//notlar toplanıyor
                }
                Console.WriteLine();
                studentExam[i] = totalExam/3;            
            }

            //Öğrenci ortalamalarını yazdırma

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} Öğrencinin Ortalaması: {studentExam[i]}");

                //Öğrenci geçme durumunu yazdırma
                if (studentExam[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} Öğrenci Geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} Öğrenci Kaldı");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
