using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con;
        SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(baglantiYollari.baglantiYolu);
            cmd = con.CreateCommand();
        }

        #region Ogretmen Metotları

        public bool OgretmenEkle(Ogretmen ogretmen)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Ogretmen(Ad,Soyad) VALUES(@ad,@soyad)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ad", ogretmen.Ad);
                cmd.Parameters.AddWithValue("@soyad", ogretmen.Soyad);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Ogretmen> OgretmenListele()
        {
            List<Ogretmen> ogretmenler = new List<Ogretmen>();
            try
            {
                cmd.CommandText = "SELECT * FROM Ogretmen";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Ogretmen hoca = new Ogretmen();

                    hoca.OgretmenNo = reader.GetInt32(0);
                    hoca.Ad = reader.GetString(1);
                    hoca.Soyad = reader.GetString(2);
                    ogretmenler.Add(hoca);
                }
                return ogretmenler;
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



        #endregion



    }
}
