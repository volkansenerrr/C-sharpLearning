using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoNetDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-U60JKD5\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();

            #region Ürün Ekleme

            //Console.Write("Ürün adı = ");
            //string isim = Console.ReadLine();

            //Console.Write("Kategori Numarası = ");
            //int kategori = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Stok Miktarı = ");
            //short stok = Convert.ToInt16(Console.ReadLine());

            //Console.Write("Fiyat = ");
            //decimal fiyat = Convert.ToDecimal(Console.ReadLine());

            //Console.Write("Güvenlik Stoğu = ");
            //short guvenlik = Convert.ToInt16(Console.ReadLine());

            //try
            //{
            //    cmd.CommandText = "INSERT INTO Products(CategoryID, ProductName, UnitsInStock, ReorderLevel, UnitPrice) VALUES(" + kategori + ",'" + isim + "'," + stok + "," + guvenlik + "," + fiyat + ")";
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    Console.WriteLine("Ürün Başarı ile eklenmiştir.");
            //}
            //catch
            //{
            //    Console.WriteLine("Ürün eklenirken bir hata oluştu.");
            //}
            //finally 
            //{ 
            //    con.Close();
            //}

            #endregion

            #region KategoriID ' ye göre ürün listeleme

            try
            {
                cmd.CommandText = "SELECT CategoryID, CategoryName FROM Categories";
                con.Open();
                SqlDataReader katreader = cmd.ExecuteReader();
                while (katreader.Read())
                {
                    int id = katreader.GetInt32(0);
                    string isim = katreader.GetString(1);
                    Console.WriteLine($"{id}) {isim}");
                }
                katreader.Close();
                Console.WriteLine("Ürünlerini listelemek istediğiniz kategori numarasını giriniz");
                string no = Console.ReadLine();
                cmd.CommandText = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products WHERE CategoryID = " + no;
                //Yukarıdaki sorguya '' or 1=1-- yazılırsa SQL INJECTION gerçekleşir.
                SqlDataReader proreader = cmd.ExecuteReader();
                while (proreader.Read())
                {
                    int id = proreader.GetInt32(0);
                    string isim = proreader.GetString(1);
                    decimal fiyat = proreader.GetDecimal(2);
                    short stok = proreader.GetInt16(3);
                    Console.WriteLine($"{id}) İsim = {isim} Fiyat = {fiyat} TL Stok = {stok}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine("Hata Oluştu.");
            }
            finally 
            { 
                con.Close();
            }
            

            #endregion
        }
    }
}
