using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Kategorilerin ID, isim ve açıklamasını yazdırma

            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U60JKD5\SQLEXPRESS; Initial Catalog=NORTHWND;Integrated Security=True");

            //conn.Open();
            //string query = "SELECT CategoryID, CategoryName, Description FROM Categories";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine($"{reader["CategoryID"]}) {reader["CategoryName"]}, {reader["Description"]}");
            //}
            //conn.Close();

            #endregion

            #region Kategori Sayısı

            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U60JKD5\SQLEXPRESS; Initial Catalog=NORTHWND;Integrated Security=True");

            //conn.Open();
            //string query = "SELECT COUNT(*) AS [Kategori Sayı] FROM Categories";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //int count = (int)cmd.ExecuteScalar();
            //Console.WriteLine($"Kategori Sayısı: {count}");
            //conn.Close();

            #endregion

            #region Ürünlerin sayısı

            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U60JKD5\SQLEXPRESS; Initial Catalog=NORTHWND;Integrated Security=True");

            //conn.Open();
            //string query = "SELECT COUNT(*) FROM Products";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //int count = (int)cmd.ExecuteScalar();
            //Console.WriteLine($"Ürün Sayısı: {count}");
            //conn.Close();

            #endregion

            #region Deniz ürünleri kategorisindeki ürün sayısı

            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U60JKD5\SQLEXPRESS; Initial Catalog=NORTHWND;Integrated Security=True");

            //conn.Open();
            //string query = "SELECT COUNT(*) FROM Products WHERE CategoryID=8";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //int count = (int)cmd.ExecuteScalar();
            //Console.WriteLine($"Deniz Ürünleri Kategorisindeki Ürün Sayısı: {count}");
            //conn.Close();

            #endregion

            #region Nancy Davolio'nun yaptığı satışların sayısı

            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U60JKD5\SQLEXPRESS; Initial Catalog=NORTHWND;Integrated Security=True");

            //conn.Open();
            //string query = "SELECT COUNT(*) FROM Orders WHERE EmployeeID=1"; // Assume Nancy Davolio's EmployeeID is 1
            //SqlCommand cmd = new SqlCommand(query, conn);
            //int count = (int)cmd.ExecuteScalar();
            //Console.WriteLine($"Nancy Davolio'nun Yaptığı Satışların Sayısı: {count}");
            //conn.Close();

            #endregion

            #region Almanya, Amerika veya Fransa'ya gönderilen siparişler

            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U60JKD5\SQLEXPRESS; Initial Catalog=NORTHWND;Integrated Security=True");

            //conn.Open();
            //string query = "SELECT * FROM Orders WHERE ShipCountry IN ('Germany', 'France', 'USA')";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine($"{reader["OrderID"]}, {reader["ShipCountry"]}");
            //}
            //conn.Close();

            #endregion

            #region Almanya, Amerika veya Fransa'ya gönderilen siparişler sayısı

            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U60JKD5\SQLEXPRESS; Initial Catalog=NORTHWND;Integrated Security=True");

            //conn.Open();
            //string query = "SELECT COUNT(*) FROM Orders WHERE ShipCountry IN ('Germany', 'France', 'USA')";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //int count = (int)cmd.ExecuteScalar();
            //Console.WriteLine($"Almanya, Amerika veya Fransa'ya Gönderilen Siparişler Sayısı: {count}");
            //conn.Close();

            #endregion

            #region İsmi A ile başlayan ürünler

            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U60JKD5\SQLEXPRESS; Initial Catalog=NORTHWND;Integrated Security=True");

            //conn.Open();
            //string query = "SELECT * FROM Products WHERE ProductName LIKE 'A%'";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine($"{reader["ProductID"]}) {reader["ProductName"]}");
            //}
            //conn.Close();

            #endregion

            #region İsmi A ile biten ürünler

            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U60JKD5\SQLEXPRESS; Initial Catalog=NORTHWND;Integrated Security=True");

            //conn.Open();
            //string query = "SELECT * FROM Products WHERE ProductName LIKE '%A'";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine($"{reader["ProductID"]}) {reader["ProductName"]}");
            //}
            //conn.Close();

            #endregion

            #region İsmi içerisinde 'a' geçen ürünler

            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U60JKD5\SQLEXPRESS; Initial Catalog=NORTHWND;Integrated Security=True");

            //conn.Open();
            //string query = "SELECT * FROM Products WHERE ProductName LIKE '%a%'";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine($"{reader["ProductID"]}, {reader["ProductName"]}");
            //}
            //conn.Close();

            #endregion

            #region İsmi içerisinde 'un' geçen ürünler

            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U60JKD5\SQLEXPRESS; Initial Catalog=NORTHWND;Integrated Security=True");

            //conn.Open();
            //string query = "SELECT * FROM Products WHERE ProductName LIKE '%un%'";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine($"{reader["ProductID"]}) {reader["ProductName"]}");
            //}
            //conn.Close();

            #endregion

            #region Stoğumda toplam kaç adet ürün var

            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U60JKD5\SQLEXPRESS; Initial Catalog=NORTHWND;Integrated Security=True");

            //conn.Open();
            //string query = "SELECT SUM(UnitsInStock) FROM Products";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //int totalUnits = (int)cmd.ExecuteScalar();
            //Console.WriteLine($"Stoğumdaki Toplam Ürün Sayısı: {totalUnits}");
            //conn.Close();

            #endregion

            #region Stoğumda toplam kaç TL'lik ürün var

            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U60JKD5\SQLEXPRESS; Initial Catalog=NORTHWND;Integrated Security=True");

            //conn.Open();
            //string query = "SELECT SUM(UnitsInStock * UnitPrice) FROM Products";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //decimal totalValue = (decimal)cmd.ExecuteScalar();
            //Console.WriteLine($"Stoğumdaki Toplam Ürün Değeri: {totalValue} TL");
            //conn.Close();

            #endregion

            #region Her bir kategoride kaç adet ürün var listeleyiniz.

            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U60JKD5\SQLEXPRESS; Initial Catalog=NORTHWND;Integrated Security=True");

            //conn.Open();

            //string query = @"
            //    SELECT c.CategoryName, COUNT(p.ProductID) AS ProductCount
            //    FROM Categories c
            //    JOIN Products p ON c.CategoryID = p.CategoryID
            //    GROUP BY c.CategoryName";

            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    Console.WriteLine($"{reader["CategoryName"]}: {reader["ProductCount"]}");
            //}

            //conn.Close();

            #endregion
        }
    }
}
