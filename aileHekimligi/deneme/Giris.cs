using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using VTI;

namespace aileHekimligi
{
    public partial class Giris : Form
    {
        Veritabani db = new Veritabani();

        public Giris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kayıtol frm = new Kayıtol();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Şifreyi hashleme
                string hashedPassword = ComputeMd5Hash(textBox2.Text);

                // Kullanıcı adı ve şifreyi parametre olarak ekleyerek Select metodunu kullanarak veritabanından veri çekme
                DataTable dt = db.Select("SELECT * FROM KullaniciTablosu WHERE K_adi=@pkadi AND K_sifre=@psifre", textBox1.Text, hashedPassword);


                // Kullanıcı adı ve şifre doğruysa ve personel kodu da doğruysa admin panelini aç
                if (dt.Rows.Count > 0 && textBox3.Text == "1")
                {
                    MessageBox.Show("Personel Girişi Başarılı");
                    FrmPersonel frm = new FrmPersonel();
                    frm.Show();
                    this.Hide();
                }
                // Kullanıcı adı ve şifre doğruysa ve personel kodu yanlışsa
                else if (dt.Rows.Count > 0 && textBox3.Text != "1" && checkBox2.Checked)
                {
                    MessageBox.Show("Personel Kodu Yanlış");
                }
                // Sadece kullanıcı adı ve şifre doğruysa
                else if (dt.Rows.Count > 0 && !checkBox2.Checked)
                {
                    MessageBox.Show("Müşteri Girişi Başarılı");
                    FrmPersonel frm = new FrmPersonel();
                    frm.Show();
                    this.Hide();
                }
                // Kullanıcı adı veya şifre yanlışsa
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Visible = label3.Visible = checkBox2.Checked;
        }

        public static string ComputeMd5Hash(string rawData)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            // Uygulama başladığında beni hatırla seçeneği işaretliyse, kaydedilmiş kullanıcı adı ve şifreyi doldur
            if (Ayarlar.Default.beniHatirla)
            {
                textBox1.Text = Ayarlar.Default.kullaniciAdi;
                textBox2.Text = Ayarlar.Default.sifre;
                chbx_beniHatirla.Checked = true;
            }
        }

        private void chbx_beniHatirla_CheckedChanged(object sender, EventArgs e)
        {
            // Beni hatırla işaretleme durumuna göre ayarları kaydet veya sil
            if (chbx_beniHatirla.Checked)
            {
                Ayarlar.Default.beniHatirla = true;
                Ayarlar.Default.kullaniciAdi = textBox1.Text;
                Ayarlar.Default.sifre = textBox2.Text;
                Ayarlar.Default.Save();
            }
            else
            {
                Ayarlar.Default.beniHatirla = false;
                Ayarlar.Default.kullaniciAdi = "";
                Ayarlar.Default.sifre = "";
                Ayarlar.Default.Save();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void büyütToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
