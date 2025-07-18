using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace aileHekimligi
{
    public partial class Baslangic : Form
    {
        public Baslangic()
        {
            InitializeComponent();
        }
        //   VTDI.DigerIslemler di;//= new VTDI.DigerIslemler();
        private void Baslangic_Load(object sender, EventArgs e)
        {
            tx_uygulamaAnahtari.Text = LisansIslemleri.uygulamaAnahtari(); ;
        }

        private void btn_Lisansla_Click(object sender, EventArgs e)
        {
            string uygulamaAnahtri = tx_uygulamaAnahtari.Text;


            string lisansAnahtari = LisansIslemleri.LisansAnahtariOlustur(uygulamaAnahtri);

            if (lisansAnahtari == tx_lisansAnahtari.Text)
            {
                //  if(File.Exists("lisans.lo")==false)
                StreamWriter sw = new StreamWriter("lisans.lo", false, Encoding.Default);
                sw.WriteLine(lisansAnahtari);
                sw.Close();
                MessageBox.Show("Lisanslama İşlemi Başarılı. Uygulama Yeniden Başlatılıyor....");
                Application.Restart();
            }
            else
                MessageBox.Show("Lisans Kodu Hatalı !!!");
        }
    }
}
