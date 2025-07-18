using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using VTI;

namespace aileHekimligi
{
    public partial class Kayıtol : Form
    {
        Veritabani db = new Veritabani();

        public Kayıtol()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Giris frm = new Giris();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Herhangi bir bilgi boş geçilemez", "Uyarı");
            }
            else if (textBox4.Text.Length < 6)
            {
                MessageBox.Show("Şifreniz 6 karakterden küçük olamaz.", "Uyarı");
            }
            else
            {
                try
                {
                    string hashedPassword = ComputeMD5(textBox4.Text);
                    using (SqlConnection connection = new SqlConnection("Data Source=.; initial Catalog=otobus; Integrated Security=true"))
                    {
                        connection.Open();
                        SqlCommand kayitolkomutu = new SqlCommand("Insert into KullaniciTablosu (K_adi,K_sifre,K_isim,K_soyisim) values (@kullaniciadi,@sifre,@K_isim,@K_soyisim)", connection);
                        kayitolkomutu.Parameters.AddWithValue("@kullaniciadi", textBox3.Text);
                        kayitolkomutu.Parameters.AddWithValue("@sifre", hashedPassword);
                        kayitolkomutu.Parameters.AddWithValue("@K_isim", textBox1.Text);
                        kayitolkomutu.Parameters.AddWithValue("@K_soyisim", textBox2.Text);
                        kayitolkomutu.ExecuteNonQuery();
                    }
                    MessageBox.Show("Başarıyla kayıt olundu kullanici adiniz = " + textBox3.Text + " Şifreniz = " + textBox4.Text + " Adınız = " + textBox1.Text + " Soyadınız = " + textBox2.Text, "Kayıt Olundu");
                    Giris frm = new Giris();
                    frm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private string ComputeMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.PasswordChar = '\0';
            }
            else
            {
                textBox4.PasswordChar = '*';
            }
        }

        private void Kayıtol_Load(object sender, EventArgs e)
        {

        }
    }
}
