using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using VTI;

namespace aileHekimligi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-OLD4T93M\MSSQLSERVER03;Initial Catalog=db_ailehekimligi;Integrated Security=True");


        private void chbx_sifreGorunur_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_sifreGorunur.Checked)
            {
                //karakteri gösterme
                tx_sifre.PasswordChar = '\0';
            }
            //karakterlerin yerine * koy.
            else
            {
                tx_sifre.PasswordChar = '*'; // "*" yerine ne eklerseniz şifreyi gizlerken ne yazmışsanız o şekilde gizler .
            }
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tx_tcNo.Text) || string.IsNullOrWhiteSpace(tx_sifre.Text))
            {
                MessageBox.Show("Boş bırakmayınız...");
                return;
            }

            string query = @"SELECT kullanici_id, ad, soyad, tcNo, sifre FROM tbl_kullanici 
                     WHERE tcNo = @tcNo AND sifre = @sifre";
            SqlCommand komut = new SqlCommand(query, baglanti);
            komut.Parameters.AddWithValue("@tcNo", tx_tcNo.Text);
            komut.Parameters.AddWithValue("@sifre", tx_sifre.Text);

            DataTable dtSonuc = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dtSonuc);

            if (dtSonuc.Rows.Count == 0)
            {
                MessageBox.Show("Tc No veya Sifre hatalı...");
                return;
            }

            FrmAnaForm afrm = new FrmAnaForm();
            afrm.Show();

            //try
            //{
            //    if (tx_kullaniciGirisi.Text==" "|| tx_sifre.Text==" ")
            //    {
            //        MessageBox.Show("boş bırakmayınız...");
            //        return;
            //    }


            //    baglanti.Open();
            //    string sql = "select * from tbl_adminGiris where kullaniciAdi=@kullanici AND sifre=@sifresi";
            //    SqlParameter prm1 = new SqlParameter("@kullanici", tx_kullaniciGirisi.Text.Trim());
            //    SqlParameter prm2 = new SqlParameter("@sifresi", tx_sifre.Text.Trim());
            //    SqlCommand komut = new SqlCommand(sql, baglanti);
            //    komut.Parameters.Add(prm1);
            //    komut.Parameters.Add(prm2);

            //    DataTable dt = new DataTable();
            //    SqlDataAdapter da = new SqlDataAdapter(komut);

            //    da.Fill(dt);

            //    if (dt.Rows.Count > 0)
            //    {
            //        FrmAnaForm fr = new FrmAnaForm();
            //        fr.Show();
            //        this.Hide();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Hatalı giriş: " + ex.Message);
            //    // Hata detaylarını loglayabilmek için.
            //}
        }
    }
}
