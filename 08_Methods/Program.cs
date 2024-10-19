using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Void Metotlar

            void CustomerList()
            {
                Console.WriteLine("Ali Yıldız");
                Console.WriteLine("Ayşe Yıldız");
                Console.WriteLine("Hilal Zeynep");
                Console.WriteLine("Zülal Hale");
            }

            CustomerList();

            Console.WriteLine("------------------------");

            void sum()
            {
                int x = 5;
                int y = 10;
                int result = x + y;
                Console.WriteLine("Result: " + result);
            }

            sum();

            Console.WriteLine("------------------------");
            //Geriye Değer Döndürmeyen Parametreli Metotlar

            void yazdir(string CustomerName)
            {
                Console.WriteLine("Customer Name: " + CustomerName);
            }

            yazdir("Ali Yıldız");

            Console.WriteLine("------------------------");

            void CustomerCard(string CustomerName, string CustomerSurname)
            {
                Console.WriteLine("Customer Name: " + CustomerName);
                Console.WriteLine("Customer Surname: " + CustomerSurname);
            }

            CustomerCard("Hilal", "Zeynep");
            CustomerCard("Zülal", "Hale");

            Console.WriteLine("------------------------");
            //Geriye Değer Döndürmeyen Int Parametreli Metotlar

            void sum1(int x, int y, int z)
            {
                int result = x + y + z;
                Console.WriteLine("Result: " + result);
            }

            sum1(5, 10, 15);

            Console.WriteLine("------------------------");

            //Geriye Değer Döndüren Metotlar

            string CustomerName1()
            {
                string name = "Ali Yıldız";

                return name;
            }

            Console.WriteLine(CustomerName1());

            Console.WriteLine("------------------------");
            //Geriye Değer Döndüren String Parametreli Metotlar

            string CountryCard(string countryName, string capital, string flagcolor)
            {
                string countryInfo = countryName + " " + capital + " " + flagcolor;
                return countryInfo;
            }

            string x1, y1, z1;

            Console.Write("Country Name: ");
            x1 = Console.ReadLine();

            Console.Write("Capital: ");
            y1 = Console.ReadLine();

            Console.Write("Flag Color: ");
            z1 = Console.ReadLine();

            Console.WriteLine(CountryCard(x1, y1, z1));

            Console.WriteLine("------------------------");

            //Geriye Değer Döndüren Int Parametreli Metotlar

            int sum2(int x, int y, int z)
            {
                int result = x + y + z;
                return result;
            }

            Console.WriteLine(sum2(5, 10, 15));

            Console.WriteLine("------------------------");
            //Örnek Uygulama

            string exam(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;

                if (result >= 50)
                {
                    return student + " Geçti";
                }
                else
                {
                    return student + " Kaldı";
                }
            }

            Console.WriteLine(exam("Ali Yıldız", 50, 60, 70));
            Console.WriteLine(exam("Ayşe Yıldız", 10, 20, 30));


            Console.ReadLine();
        }
    }
}
