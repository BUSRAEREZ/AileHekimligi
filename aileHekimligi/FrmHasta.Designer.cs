
namespace aileHekimligi
{
    partial class FrmHasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHasta));
            this.cbx_cinsiyet = new System.Windows.Forms.ComboBox();
            this.tx_eMail = new System.Windows.Forms.TextBox();
            this.tx_telefon = new System.Windows.Forms.TextBox();
            this.tx_TcNo = new System.Windows.Forms.TextBox();
            this.tx_dogumTarihi = new System.Windows.Forms.TextBox();
            this.tx_soyad = new System.Windows.Forms.TextBox();
            this.tx_ad = new System.Windows.Forms.TextBox();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.lbl_eMail = new System.Windows.Forms.Label();
            this.lbl_tcNo = new System.Windows.Forms.Label();
            this.lbl_dogumTarihi = new System.Windows.Forms.Label();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.dgv_hasta = new System.Windows.Forms.DataGridView();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.cbx_kangrup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hasta)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_cinsiyet
            // 
            this.cbx_cinsiyet.FormattingEnabled = true;
            this.cbx_cinsiyet.Items.AddRange(new object[] {
            "Kız",
            "Erkek"});
            this.cbx_cinsiyet.Location = new System.Drawing.Point(182, 139);
            this.cbx_cinsiyet.Name = "cbx_cinsiyet";
            this.cbx_cinsiyet.Size = new System.Drawing.Size(166, 21);
            this.cbx_cinsiyet.TabIndex = 18;
            // 
            // tx_eMail
            // 
            this.tx_eMail.Location = new System.Drawing.Point(182, 262);
            this.tx_eMail.Name = "tx_eMail";
            this.tx_eMail.Size = new System.Drawing.Size(166, 20);
            this.tx_eMail.TabIndex = 12;
            // 
            // tx_telefon
            // 
            this.tx_telefon.Location = new System.Drawing.Point(182, 98);
            this.tx_telefon.Name = "tx_telefon";
            this.tx_telefon.Size = new System.Drawing.Size(166, 20);
            this.tx_telefon.TabIndex = 13;
            // 
            // tx_TcNo
            // 
            this.tx_TcNo.Location = new System.Drawing.Point(182, 182);
            this.tx_TcNo.Name = "tx_TcNo";
            this.tx_TcNo.Size = new System.Drawing.Size(166, 20);
            this.tx_TcNo.TabIndex = 14;
            // 
            // tx_dogumTarihi
            // 
            this.tx_dogumTarihi.Location = new System.Drawing.Point(182, 226);
            this.tx_dogumTarihi.Name = "tx_dogumTarihi";
            this.tx_dogumTarihi.Size = new System.Drawing.Size(166, 20);
            this.tx_dogumTarihi.TabIndex = 15;
            // 
            // tx_soyad
            // 
            this.tx_soyad.Location = new System.Drawing.Point(182, 57);
            this.tx_soyad.Name = "tx_soyad";
            this.tx_soyad.Size = new System.Drawing.Size(166, 20);
            this.tx_soyad.TabIndex = 16;
            // 
            // tx_ad
            // 
            this.tx_ad.Location = new System.Drawing.Point(182, 19);
            this.tx_ad.Name = "tx_ad";
            this.tx_ad.Size = new System.Drawing.Size(166, 20);
            this.tx_ad.TabIndex = 17;
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefon.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefon.Location = new System.Drawing.Point(70, 98);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(99, 25);
            this.lbl_telefon.TabIndex = 5;
            this.lbl_telefon.Text = "Telefon :";
            // 
            // lbl_eMail
            // 
            this.lbl_eMail.AutoSize = true;
            this.lbl_eMail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_eMail.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eMail.Location = new System.Drawing.Point(76, 262);
            this.lbl_eMail.Name = "lbl_eMail";
            this.lbl_eMail.Size = new System.Drawing.Size(97, 25);
            this.lbl_eMail.TabIndex = 6;
            this.lbl_eMail.Text = "E-Mail :";
            // 
            // lbl_tcNo
            // 
            this.lbl_tcNo.AutoSize = true;
            this.lbl_tcNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tcNo.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tcNo.Location = new System.Drawing.Point(92, 182);
            this.lbl_tcNo.Name = "lbl_tcNo";
            this.lbl_tcNo.Size = new System.Drawing.Size(77, 25);
            this.lbl_tcNo.TabIndex = 7;
            this.lbl_tcNo.Text = "TcNo :";
            // 
            // lbl_dogumTarihi
            // 
            this.lbl_dogumTarihi.AutoSize = true;
            this.lbl_dogumTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dogumTarihi.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dogumTarihi.Location = new System.Drawing.Point(12, 220);
            this.lbl_dogumTarihi.Name = "lbl_dogumTarihi";
            this.lbl_dogumTarihi.Size = new System.Drawing.Size(165, 25);
            this.lbl_dogumTarihi.TabIndex = 8;
            this.lbl_dogumTarihi.Text = "Doğum Tarihi :";
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cinsiyet.Location = new System.Drawing.Point(76, 139);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(102, 25);
            this.lbl_cinsiyet.TabIndex = 9;
            this.lbl_cinsiyet.Text = "Cinsiyet :";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_soyad.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soyad.Location = new System.Drawing.Point(92, 54);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(82, 25);
            this.lbl_soyad.TabIndex = 10;
            this.lbl_soyad.Text = "Soyad :";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ad.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ad.Location = new System.Drawing.Point(116, 16);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(53, 25);
            this.lbl_ad.TabIndex = 11;
            this.lbl_ad.Text = "Ad :";
            // 
            // dgv_hasta
            // 
            this.dgv_hasta.AllowUserToAddRows = false;
            this.dgv_hasta.AllowUserToDeleteRows = false;
            this.dgv_hasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hasta.Location = new System.Drawing.Point(61, 352);
            this.dgv_hasta.Name = "dgv_hasta";
            this.dgv_hasta.ReadOnly = true;
            this.dgv_hasta.Size = new System.Drawing.Size(844, 204);
            this.dgv_hasta.TabIndex = 19;
            this.dgv_hasta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hasta_CellContentClick);
            this.dgv_hasta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hasta_CellDoubleClick);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guncelle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_guncelle.Location = new System.Drawing.Point(715, 182);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(94, 40);
            this.btn_guncelle.TabIndex = 20;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_temizle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_temizle.Location = new System.Drawing.Point(558, 182);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(94, 40);
            this.btn_temizle.TabIndex = 21;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ekle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ekle.Location = new System.Drawing.Point(558, 86);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(94, 40);
            this.btn_ekle.TabIndex = 22;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kan Grup :";
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_sil.Location = new System.Drawing.Point(715, 83);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(94, 40);
            this.btn_sil.TabIndex = 22;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // cbx_kangrup
            // 
            this.cbx_kangrup.FormattingEnabled = true;
            this.cbx_kangrup.Items.AddRange(new object[] {
            "0+",
            "0-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.cbx_kangrup.Location = new System.Drawing.Point(182, 303);
            this.cbx_kangrup.Name = "cbx_kangrup";
            this.cbx_kangrup.Size = new System.Drawing.Size(166, 21);
            this.cbx_kangrup.TabIndex = 23;
            // 
            // FrmHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 568);
            this.Controls.Add(this.cbx_kangrup);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dgv_hasta);
            this.Controls.Add(this.cbx_cinsiyet);
            this.Controls.Add(this.tx_eMail);
            this.Controls.Add(this.tx_telefon);
            this.Controls.Add(this.tx_TcNo);
            this.Controls.Add(this.tx_dogumTarihi);
            this.Controls.Add(this.tx_soyad);
            this.Controls.Add(this.tx_ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.lbl_eMail);
            this.Controls.Add(this.lbl_tcNo);
            this.Controls.Add(this.lbl_dogumTarihi);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Name = "FrmHasta";
            this.Text = "FrmHasta";
            this.Load += new System.EventHandler(this.FrmHasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_cinsiyet;
        private System.Windows.Forms.TextBox tx_eMail;
        private System.Windows.Forms.TextBox tx_telefon;
        private System.Windows.Forms.TextBox tx_TcNo;
        private System.Windows.Forms.TextBox tx_dogumTarihi;
        private System.Windows.Forms.TextBox tx_soyad;
        private System.Windows.Forms.TextBox tx_ad;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_eMail;
        private System.Windows.Forms.Label lbl_tcNo;
        private System.Windows.Forms.Label lbl_dogumTarihi;
        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.DataGridView dgv_hasta;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.ComboBox cbx_kangrup;
    }
}