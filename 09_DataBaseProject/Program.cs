using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DataBaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            string tableNumber;

            Console.WriteLine("C# Veri Tabanlı Ürün-Bilgi Sistemi");
            Console.WriteLine("------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış");
            Console.WriteLine("------------------------");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("------------------------");

            SqlConnection connection = new SqlConnection("Data Source=FAHRIYECORTU;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TBL_CATEGORY", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);//bunu kullanma nedenimiz verileri tabloya doldurmak
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["CATEGORYID"] + " " + row["CATEGORYNAME"]);
            }

            Console.ReadLine();
        }
    }
}
