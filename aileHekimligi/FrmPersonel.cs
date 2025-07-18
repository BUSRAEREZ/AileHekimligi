using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using VTI;

namespace aileHekimligi
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-OLD4T93M\MSSQLSERVER03;Initial Catalog=db_ailehekimligi;Integrated Security=True");
        Veritabani vt = new Veritabani();

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            dgv_personel.DataSource =
                vt.Select(@"SELECT 
                    p.personel_id,
                    p.Ad,
                    p.Soyad,
                    p.Cinsiyet,
                    p.DogumTarihi,
                    p.TcNo,
                    p.Telefon,
                    p.EMail,
                    pt.personelTur_id,
                    pt.personelTur
                FROM 
                    tbl_personel p
                JOIN 
                    tbl_personelTur pt ON p.personelTur_id = pt.personelTur_id;");
            dgv_personel.Columns["personel_id"].Visible = false;
            dgv_personel.Columns["personelTur_id"].Visible = false;

            cbx_personelTur.ValueMember = "personelTur_id";
            cbx_personelTur.DisplayMember = "personelTur";
            cbx_personelTur.DataSource = vt.Select("select personelTur_id,personelTur from tbl_personelTur");



        }


        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_ad.Text.Trim().Length < 2)
            {
                MessageBox.Show("ad en az 2 karakter olmalı");
                return;
            }

            if (tx_soyad.Text.Trim().Length < 2)
            {
                MessageBox.Show("soyad en az 2 karakter olmalı");
                return;
            }
            if (tx_TcNo.Text.Trim().Length != 11)
            {
                MessageBox.Show("tc 11 karakter olmalı");
                return;
            }
            if (tx_telefon.Text.Trim().Length != 11)
            {
                MessageBox.Show("telefon numarası 11 karakter olmalı");
                return;
            }
            vt.Insert(@"INSERT INTO tbl_personel (Ad, Soyad, Cinsiyet, DogumTarihi, TcNo, Telefon, EMail, personelTur_id)
           VALUES ('" + tx_ad.Text + "','" + tx_soyad.Text + "','" + cbx_cinsiyet.SelectedItem.ToString() + "', '" + tx_dogumTarihi.Text.Trim() + "','" + tx_TcNo.Text + "','" + tx_telefon.Text + "','" + tx_eMail.Text + "','" + cbx_personelTur.SelectedValue + "')");
            FrmPersonel_Load(null, null);
            MessageBox.Show("Kayıt Eklendi");

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_personel.SelectedRows.Count == 0)
                return;

            if (tx_ad.Text.Trim().Length < 2)
            {
                MessageBox.Show("ad en az 2 karakter olmalı");
                return;
            }

            if (tx_soyad.Text.Trim().Length < 2)
            {
                MessageBox.Show("soyad en az 2 karakter olmalı");
                return;
            }
            if (tx_TcNo.Text.Trim().Length != 11)
            {
                MessageBox.Show("tc 11 karakter olmalı");
                return;
            }
            if (tx_telefon.Text.Trim().Length != 11)
            {
                MessageBox.Show("telefon numarası 11 karakter olmalı");
                return;
            }
            int kayitsay = vt.Update(@"update tbl_personel
                                            set Ad='" + tx_ad.Text + @"',
                                            Soyad='" + tx_soyad + @"',
                                            Cinsiyet='" + cbx_cinsiyet + @"',
                                            DogumTarihi='" + tx_dogumTarihi + @"',
                                            TcNo='" + tx_TcNo + @"',
                                            Telefon='" + tx_telefon + @"',
                                            EMail='" + tx_eMail + @"'
                                            where personel_id=" + dgv_personel.SelectedRows[0].Cells["personel_id"].Value);
            if (kayitsay > 0)
            {
                FrmPersonel_Load(null, null);
                MessageBox.Show("personel güncellendi");
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_ad.Text = "";
            tx_soyad.Text = "";
            cbx_cinsiyet.Text = "";
            tx_dogumTarihi.Text = "";
            tx_TcNo.Text = "";
            tx_telefon.Text = "";
            tx_eMail.Text = "";
            cbx_personelTur.Text = "";
            if (dgv_personel.SelectedRows.Count > 0)
                dgv_personel.SelectedRows[0].Selected = false;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_personel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek personel Seçiniz...");
                return;
            }
            int kayitsay = vt.Update(" delete from tbl_personel where personel_id = " +
            dgv_personel.SelectedRows[0].Cells["personel_id"].Value);
            FrmPersonel_Load(null, null);
            MessageBox.Show("personel Silindi");
        }

        private void cbx_cinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tx_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void tx_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void dgv_personel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_personel.SelectedRows.Count == 0)
                return;
            tx_ad.Text = dgv_personel.SelectedRows[0].Cells["Ad"].Value.ToString();
            tx_soyad.Text = dgv_personel.SelectedRows[0].Cells["Soyad"].Value.ToString();
            cbx_cinsiyet.Text = dgv_personel.SelectedRows[0].Cells["Cinsiyet"].Value.ToString();
            tx_dogumTarihi.Text = dgv_personel.SelectedRows[0].Cells["DogumTarihi"].Value.ToString();
            tx_TcNo.Text = dgv_personel.SelectedRows[0].Cells["TcNo"].Value.ToString();
            tx_telefon.Text = dgv_personel.SelectedRows[0].Cells["Telefon"].Value.ToString();
            tx_eMail.Text = dgv_personel.SelectedRows[0].Cells["Email"].Value.ToString();
            cbx_personelTur.Text = dgv_personel.SelectedRows[0].Cells["PersonelTur_id"].Value.ToString();
        }
    }
}
