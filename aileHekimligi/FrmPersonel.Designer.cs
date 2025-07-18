
namespace aileHekimligi
{
    partial class FrmPersonel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.lbl_dogumTarihi = new System.Windows.Forms.Label();
            this.lbl_tcNo = new System.Windows.Forms.Label();
            this.lbl_eMail = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.tx_ad = new System.Windows.Forms.TextBox();
            this.tx_soyad = new System.Windows.Forms.TextBox();
            this.tx_dogumTarihi = new System.Windows.Forms.TextBox();
            this.tx_TcNo = new System.Windows.Forms.TextBox();
            this.tx_telefon = new System.Windows.Forms.TextBox();
            this.tx_eMail = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.cbx_cinsiyet = new System.Windows.Forms.ComboBox();
            this.dgv_personel = new System.Windows.Forms.DataGridView();
            this.btn_sil = new System.Windows.Forms.Button();
            this.cbx_personelTur = new System.Windows.Forms.ComboBox();
            this.tx_personelTur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ad.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ad.Location = new System.Drawing.Point(109, 31);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(53, 25);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "Ad :";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_soyad.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soyad.Location = new System.Drawing.Point(85, 69);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(82, 25);
            this.lbl_soyad.TabIndex = 0;
            this.lbl_soyad.Text = "Soyad :";
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cinsiyet.Location = new System.Drawing.Point(69, 109);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(102, 25);
            this.lbl_cinsiyet.TabIndex = 0;
            this.lbl_cinsiyet.Text = "Cinsiyet :";
            // 
            // lbl_dogumTarihi
            // 
            this.lbl_dogumTarihi.AutoSize = true;
            this.lbl_dogumTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dogumTarihi.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dogumTarihi.Location = new System.Drawing.Point(5, 140);
            this.lbl_dogumTarihi.Name = "lbl_dogumTarihi";
            this.lbl_dogumTarihi.Size = new System.Drawing.Size(165, 25);
            this.lbl_dogumTarihi.TabIndex = 0;
            this.lbl_dogumTarihi.Text = "Doğum Tarihi :";
            // 
            // lbl_tcNo
            // 
            this.lbl_tcNo.AutoSize = true;
            this.lbl_tcNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tcNo.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tcNo.Location = new System.Drawing.Point(85, 185);
            this.lbl_tcNo.Name = "lbl_tcNo";
            this.lbl_tcNo.Size = new System.Drawing.Size(77, 25);
            this.lbl_tcNo.TabIndex = 0;
            this.lbl_tcNo.Text = "TcNo :";
            // 
            // lbl_eMail
            // 
            this.lbl_eMail.AutoSize = true;
            this.lbl_eMail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_eMail.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eMail.Location = new System.Drawing.Point(69, 260);
            this.lbl_eMail.Name = "lbl_eMail";
            this.lbl_eMail.Size = new System.Drawing.Size(97, 25);
            this.lbl_eMail.TabIndex = 0;
            this.lbl_eMail.Text = "E-Mail :";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefon.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefon.Location = new System.Drawing.Point(71, 219);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(99, 25);
            this.lbl_telefon.TabIndex = 0;
            this.lbl_telefon.Text = "Telefon :";
            // 
            // tx_ad
            // 
            this.tx_ad.Location = new System.Drawing.Point(175, 34);
            this.tx_ad.Name = "tx_ad";
            this.tx_ad.Size = new System.Drawing.Size(166, 20);
            this.tx_ad.TabIndex = 1;
            this.tx_ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_ad_KeyPress);
            // 
            // tx_soyad
            // 
            this.tx_soyad.Location = new System.Drawing.Point(175, 72);
            this.tx_soyad.Name = "tx_soyad";
            this.tx_soyad.Size = new System.Drawing.Size(166, 20);
            this.tx_soyad.TabIndex = 1;
            this.tx_soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_soyad_KeyPress);
            // 
            // tx_dogumTarihi
            // 
            this.tx_dogumTarihi.Location = new System.Drawing.Point(175, 146);
            this.tx_dogumTarihi.Name = "tx_dogumTarihi";
            this.tx_dogumTarihi.Size = new System.Drawing.Size(166, 20);
            this.tx_dogumTarihi.TabIndex = 1;
            // 
            // tx_TcNo
            // 
            this.tx_TcNo.Location = new System.Drawing.Point(175, 185);
            this.tx_TcNo.Name = "tx_TcNo";
            this.tx_TcNo.Size = new System.Drawing.Size(166, 20);
            this.tx_TcNo.TabIndex = 1;
            // 
            // tx_telefon
            // 
            this.tx_telefon.Location = new System.Drawing.Point(175, 222);
            this.tx_telefon.Name = "tx_telefon";
            this.tx_telefon.Size = new System.Drawing.Size(166, 20);
            this.tx_telefon.TabIndex = 1;
            // 
            // tx_eMail
            // 
            this.tx_eMail.Location = new System.Drawing.Point(175, 260);
            this.tx_eMail.Name = "tx_eMail";
            this.tx_eMail.Size = new System.Drawing.Size(166, 20);
            this.tx_eMail.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ekle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ekle.Location = new System.Drawing.Point(513, 54);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(94, 40);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_temizle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_temizle.Location = new System.Drawing.Point(668, 146);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(94, 40);
            this.btn_temizle.TabIndex = 2;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guncelle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_guncelle.Location = new System.Drawing.Point(513, 146);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(94, 40);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // cbx_cinsiyet
            // 
            this.cbx_cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_cinsiyet.FormattingEnabled = true;
            this.cbx_cinsiyet.Items.AddRange(new object[] {
            "Kız",
            "Erkek"});
            this.cbx_cinsiyet.Location = new System.Drawing.Point(175, 109);
            this.cbx_cinsiyet.Name = "cbx_cinsiyet";
            this.cbx_cinsiyet.Size = new System.Drawing.Size(166, 21);
            this.cbx_cinsiyet.TabIndex = 4;
            this.cbx_cinsiyet.SelectedIndexChanged += new System.EventHandler(this.cbx_cinsiyet_SelectedIndexChanged);
            // 
            // dgv_personel
            // 
            this.dgv_personel.AllowUserToAddRows = false;
            this.dgv_personel.AllowUserToDeleteRows = false;
            this.dgv_personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_personel.Location = new System.Drawing.Point(12, 374);
            this.dgv_personel.Name = "dgv_personel";
            this.dgv_personel.ReadOnly = true;
            this.dgv_personel.Size = new System.Drawing.Size(863, 155);
            this.dgv_personel.TabIndex = 5;
            this.dgv_personel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_personel_CellDoubleClick);
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_sil.Location = new System.Drawing.Point(668, 56);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(94, 38);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // cbx_personelTur
            // 
            this.cbx_personelTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_personelTur.FormattingEnabled = true;
            this.cbx_personelTur.Items.AddRange(new object[] {
            "Doktor",
            "Hemşire",
            "Hasta"});
            this.cbx_personelTur.Location = new System.Drawing.Point(175, 305);
            this.cbx_personelTur.Name = "cbx_personelTur";
            this.cbx_personelTur.Size = new System.Drawing.Size(166, 21);
            this.cbx_personelTur.TabIndex = 7;
            // 
            // tx_personelTur
            // 
            this.tx_personelTur.AutoSize = true;
            this.tx_personelTur.BackColor = System.Drawing.Color.Transparent;
            this.tx_personelTur.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_personelTur.ForeColor = System.Drawing.Color.Black;
            this.tx_personelTur.Location = new System.Drawing.Point(18, 299);
            this.tx_personelTur.Name = "tx_personelTur";
            this.tx_personelTur.Size = new System.Drawing.Size(153, 25);
            this.tx_personelTur.TabIndex = 8;
            this.tx_personelTur.Text = "Personel Tür :";
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 541);
            this.Controls.Add(this.tx_personelTur);
            this.Controls.Add(this.cbx_personelTur);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.dgv_personel);
            this.Controls.Add(this.cbx_cinsiyet);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.tx_eMail);
            this.Controls.Add(this.tx_telefon);
            this.Controls.Add(this.tx_TcNo);
            this.Controls.Add(this.tx_dogumTarihi);
            this.Controls.Add(this.tx_soyad);
            this.Controls.Add(this.tx_ad);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.lbl_eMail);
            this.Controls.Add(this.lbl_tcNo);
            this.Controls.Add(this.lbl_dogumTarihi);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Name = "FrmPersonel";
            this.Text = "FrmPersonel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.Label lbl_dogumTarihi;
        private System.Windows.Forms.Label lbl_tcNo;
        private System.Windows.Forms.Label lbl_eMail;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.TextBox tx_ad;
        private System.Windows.Forms.TextBox tx_soyad;
        private System.Windows.Forms.TextBox tx_dogumTarihi;
        private System.Windows.Forms.TextBox tx_TcNo;
        private System.Windows.Forms.TextBox tx_telefon;
        private System.Windows.Forms.TextBox tx_eMail;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.ComboBox cbx_cinsiyet;
        private System.Windows.Forms.DataGridView dgv_personel;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.ComboBox cbx_personelTur;
        private System.Windows.Forms.Label tx_personelTur;
    }
}