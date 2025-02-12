using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VeriErisimKatmani
{
    public class VeriModeli
    {
        SqlConnection con;
        SqlCommand cmd;

        public VeriModeli() 
        { 
           //Veri Modeli sınıfının nesnesi oluştuğu anda SqlConnection ve SqlCommand Sınıfının nesneleri olan con ve cmd otomatik olarak 
           //Constructor tarafından oluşturulacak.
           //Static verilerin nesnesi oluşturululamaz.
           con = new SqlConnection(BaglantiYollari.BaglantiYolu);
           cmd = con.CreateCommand();
        }

        #region Kategori Metotları

        public bool KategoriEkle(Kategori k) 
        {
            try
            {
                cmd.CommandText = "INSERT INTO Categories(CategoryName,Description) VALUES (@isim,@a)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@isim", k.Isim);
                cmd.Parameters.AddWithValue("@a", k.Aciklama);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally 
            { 
                con.Close();
            }
        }

        public List<Kategori> KategorileriGetir() 
        { 
            List <Kategori> kategoriler = new List<Kategori>();
            try
            {
                cmd.CommandText = "SELECT CategoryID,CategoryName,Description FROM Categories";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader okuyucu = cmd.ExecuteReader();
                while (okuyucu.Read())
                {
                    Kategori k = new Kategori();
                    k.KategoriID = okuyucu.GetInt32(0);
                    k.Isim = okuyucu.GetString(1);
                    if (!okuyucu.IsDBNull(2))
                    {
                        k.Aciklama = okuyucu.GetString(2);
                    }
                    kategoriler.Add(k);


                }
                return kategoriler;
            }
            catch
            {
                return null;
            }
            finally 
            { 
                con.Close();
            }
        }

        public bool KategoriGuncelle(Kategori k) 
        {
            try
            {
                cmd.CommandText = "UPDATE Categories SET CategoryName=@categoryName, Description=@description WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", k.KategoriID);
                cmd.Parameters.AddWithValue("@categoryName", k.Isim);
                cmd.Parameters.AddWithValue("@description", k.Aciklama);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally 
            { 
                con.Close();
            }
        }


        public bool KategoriSil(int id) 
        {
            try
            {
                cmd.CommandText = "DELETE FROM Categories WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally 
            { 
                con.Close();
            }
        }
        #endregion
    }
}
