using System;
using System.Windows.Forms;

namespace aileHekimligi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_personel_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.Show();
        }

        private void btn_receteDetay_Click(object sender, EventArgs e)
        {
            FrmReceteDetay frm = new FrmReceteDetay();
            frm.Show();
        }

        private void btn_hasta_Click(object sender, EventArgs e)
        {
            FrmHasta frm = new FrmHasta();
            frm.Show();
        }
    }
}
