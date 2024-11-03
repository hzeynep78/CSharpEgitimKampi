using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menü Sipariş İşlem Paneli");
            Console.WriteLine("------------------------");

            //Kategori Ekleme

            Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            string categoryName = Console.ReadLine();

            if (categoryName != "0")
            {
                SqlConnection connection1 = new SqlConnection("Data Source=FAHRIYECORTU;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
                connection1.Open();
                SqlCommand command1 = new SqlCommand("INSERT INTO TBL_CATEGORY (CATEGORYNAME) VALUES (@p1)", connection1);
                command1.Parameters.AddWithValue("@p1", categoryName);
                command1.ExecuteNonQuery(); // executeNonQuery() metodu insert, update, delete işlemlerinde kullanılır. Geriye dönüş yapmaz.
                connection1.Close();
                Console.WriteLine("Kategori Eklendi.");
            }
            else
            {
                Console.WriteLine("Kategori ekleme işlemi atlandı.");
            }

            Console.WriteLine("------------------------");
            //Ürün Ekleme İşlemi

            string productName;
            decimal productPrice;

            Console.Write("Ürün Adı: ");
            productName = Console.ReadLine();

            if (productName != "0")
            {
                Console.Write("Ürün Fiyatı: ");
                productPrice = decimal.Parse(Console.ReadLine());

                SqlConnection connection1 = new SqlConnection("Data Source=FAHRIYECORTU;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
                connection1.Open();
                SqlCommand command1 = new SqlCommand("INSERT INTO TBL_PRODUCT (PRODUCTNAME, PRODUCTPRICE, PRODUCTSTATUS) VALUES (@p1, @p2, @p3)", connection1);
                command1.Parameters.AddWithValue("@p1", productName);
                command1.Parameters.AddWithValue("@p2", productPrice);
                command1.Parameters.AddWithValue("@p3", true);
                command1.ExecuteNonQuery();
                connection1.Close();
                Console.WriteLine("Ürün Eklendi.");
            }
            else
            {
                Console.WriteLine("Ürün ekleme işlemi atlandı.");
            }

            Console.WriteLine("------------------------");
            //Ürün Listeleme

            SqlConnection connection = new SqlConnection("Data Source=FAHRIYECORTU;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TBL_PRODUCT", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["PRODUCTID"] + " " + row["PRODUCTNAME"] + " " + row["PRODUCTPRICE"] + " " + row["PRODUCTSTATUS"]);
            }
            Console.WriteLine("------------------------");
            //Ürün Silme

            int productId;

            Console.Write("Silmek istediğiniz ürünün ID'sini giriniz: ");
            productId = int.Parse(Console.ReadLine());

            if (productId != 0)
            {
                SqlConnection connection1 = new SqlConnection("Data Source=FAHRIYECORTU;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
                connection1.Open();
                SqlCommand command1 = new SqlCommand("DELETE FROM TBL_PRODUCT WHERE PRODUCTID = @p1", connection1);
                command1.Parameters.AddWithValue("@p1", productId);
                command1.ExecuteNonQuery();
                connection1.Close();
                Console.WriteLine("Ürün Silindi.");
            }
            else
            {
                Console.WriteLine("Ürün silme işlemi atlandı.");
            }

            Console.WriteLine("------------------------");
            //Ürün Güncelleme

            int productId2;
            string productName2;
            decimal productPrice2;

            Console.Write("Güncellemek istediğiniz ürünün ID'sini giriniz: ");
            productId2 = int.Parse(Console.ReadLine());

            if (productId2 != 0)
            {
                Console.Write("Yeni Ürün Adı: ");
                productName2 = Console.ReadLine();
                Console.Write("Yeni Ürün Fiyatı: ");
                productPrice2 = decimal.Parse(Console.ReadLine());

                SqlConnection connection1 = new SqlConnection("Data Source=FAHRIYECORTU;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
                connection1.Open();
                SqlCommand command1 = new SqlCommand("UPDATE TBL_PRODUCT SET PRODUCTNAME = @p1, PRODUCTPRICE = @p2 WHERE PRODUCTID = @p3", connection1);
                command1.Parameters.AddWithValue("@p1", productName2);
                command1.Parameters.AddWithValue("@p2", productPrice2);
                command1.Parameters.AddWithValue("@p3", productId2);
                command1.ExecuteNonQuery();
                connection1.Close();
                Console.WriteLine("Ürün Güncellendi.");
            }
            else
            {
                Console.WriteLine("Ürün güncelleme işlemi atlandı.");
            }



            Console.ReadLine();
        }
    }
}
