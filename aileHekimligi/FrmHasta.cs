using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using VTI;


namespace aileHekimligi
{
    public partial class FrmHasta : Form
    {
        public FrmHasta()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-OLD4T93M\MSSQLSERVER03;Initial Catalog=db_ailehekimligi;Integrated Security=True");
        Veritabani vt = new Veritabani();

        private void hastaGridiDoldur()
        {
            DataTable hasta = vt.Select(@"SELECT hasta_id, Ad,Soyad, Telefon, Cinsiyet, TcNo,dogumTarihi,EMail KanGrup
                    
                FROM 
                    tbl_hasta ");
            dgv_hasta.DataSource = hasta;
            dgv_hasta.Columns["hasta_id"].Visible = false;
            dgv_hasta.DataSource = hasta;
        }


        private void FrmHasta_Load(object sender, EventArgs e)
        {

            hastaGridiDoldur();

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
            vt.Insert(@"INSERT INTO tbl_hasta (Ad, Soyad,Telefon, Cinsiyet,TcNo, dogumTarihi, EMail, KanGrup)
           VALUES ('" + tx_ad.Text + "','" + tx_soyad.Text + "','" + tx_telefon.Text + "','" + cbx_cinsiyet.SelectedItem.ToString() +
           "', '" + tx_TcNo.Text + "','" + tx_dogumTarihi.Text + "','" + tx_eMail.Text + "','" + cbx_kangrup.SelectedItem.ToString() + "')");
            hastaGridiDoldur();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_hasta.SelectedRows.Count == 0)
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
            int kayitsay = vt.Update(@"UPDATE tbl_hasta
                                             SET Ad = '" + tx_ad + @"',
                                             Soyad = '" + tx_soyad + @"',
	                                         Telefon = '" + tx_telefon + @"',
                                             Cinsiyet = '" + cbx_cinsiyet + @"',
	                                         TcNo = '" + tx_TcNo + @"',
                                             dogumTarihi = '" + tx_dogumTarihi + @"',
                                             EMail = '" + tx_eMail + @"',
                                             KanGrup='" + cbx_kangrup + @"'
                                             WHERE hasta_id=" + dgv_hasta.SelectedRows[0].Cells["hasta_id"].Value);
            if (kayitsay > 0)
            {
                FrmHasta_Load(null, null);
                MessageBox.Show("hasta güncellendi");
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_ad.Text = "";
            tx_soyad.Text = "";
            tx_telefon.Text = "";
            cbx_cinsiyet.Text = "";
            tx_TcNo.Text = "";
            tx_dogumTarihi.Text = "";
            tx_eMail.Text = "";
            cbx_kangrup.Text = "";
            if (dgv_hasta.SelectedRows.Count > 0)
                dgv_hasta.SelectedRows[0].Selected = false;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_hasta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek personel Seçiniz...");
                return;
            }
            int kayitsay = vt.Update(" delete from tbl_hasta where hasta_id = " +
            dgv_hasta.SelectedRows[0].Cells["hasta_id"].Value);
            FrmHasta_Load(null, null);
            MessageBox.Show("hasta Silindi");
        }

        private void dgv_hasta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tx_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void tx_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void dgv_hasta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_hasta.SelectedRows.Count == 0)
                return;
            tx_ad.Text = dgv_hasta.SelectedRows[0].Cells["Ad"].Value.ToString();
            tx_soyad.Text = dgv_hasta.SelectedRows[0].Cells["Soyad"].Value.ToString();
            tx_telefon.Text = dgv_hasta.SelectedRows[0].Cells["Telefon"].Value.ToString();
            cbx_cinsiyet.Text = dgv_hasta.SelectedRows[0].Cells["Cinsiyet"].Value.ToString();
            tx_TcNo.Text = dgv_hasta.SelectedRows[0].Cells["TcNo"].Value.ToString();
            tx_dogumTarihi.Text = dgv_hasta.SelectedRows[0].Cells["DogumTarihi"].Value.ToString();
            tx_eMail.Text = dgv_hasta.SelectedRows[0].Cells["Email"].Value.ToString();
            cbx_kangrup.Text = dgv_hasta.SelectedRows[0].Cells["KanGrup"].Value.ToString();

        }
    }
}
