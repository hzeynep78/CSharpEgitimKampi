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
            Console.WriteLine("Merhaba Dünya");
            Console.Write("Selam");
            //line eki imleci bir alt satıra alır

            Console.WriteLine("------------------------");

            string name;
            name = "Hilal";
            Console.WriteLine(name);

            Console.WriteLine("------------------------");

            string customerName = "Hilal";
            string customerSurname = "Zeynep";
            string customerPhone = "1234567890";
            string customerEmail = "deneme@gmail.com", district = "Keçiören", city = "Ankara";

            Console.WriteLine(customerName+" "+customerSurname+" "+customerPhone+" "+customerEmail+" "+district+" "+city);


            Console.Read();
        }
    }
}
