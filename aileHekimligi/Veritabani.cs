using System;
using System.Data;
using System.Data.SqlClient;
using VTDI;
using VTI;
using System.Data.Sql;

namespace VTI
{
    class Veritabani
    {
        public Veritabani()
        {
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=havalimani;Integrated Security=True");
        public DataTable Select(string sorgu, string pkadi, string psifre)
        {
            DataTable dt = new DataTable();
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@pkadi", pkadi);
                komut.Parameters.AddWithValue("@psifre", psifre);
                SqlDataAdapter adtr = new SqlDataAdapter(komut);
                adtr.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Veri alınamadı: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            return dt;
        }

        public DataTable Select(string sorgu)
        {
            DataTable dt = new DataTable();
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataAdapter adtr = new SqlDataAdapter(komut);
                adtr.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Veri alınamadı: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            return dt;
        }

        public int Insert(string sorgu, params SqlParameter[] parameters)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddRange(parameters); // Parametreleri komuta ekleyin
                int etkilenenSatirSayisi = komut.ExecuteNonQuery();
                return etkilenenSatirSayisi;
            }
            catch (Exception ex)
            {
                throw new Exception("İşlem gerçekleştirilemedi: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        public int Update(string sorgu, params SqlParameter[] parameters)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddRange(parameters); // Parametreleri komuta ekleyin
                int etkilenenSatirSayisi = komut.ExecuteNonQuery();
                return etkilenenSatirSayisi;
            }
            catch (Exception ex)
            {
                throw new Exception("Güncelleme işlemi gerçekleştirilemedi: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        public int Delete(string sorgu, params SqlParameter[] parameters)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddRange(parameters); // Parametreleri komuta ekleyin
                int etkilenenSatirSayisi = komut.ExecuteNonQuery();
                return etkilenenSatirSayisi;
            }
            catch (Exception ex)
            {
                throw new Exception("Silme işlemi gerçekleştirilemedi: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
