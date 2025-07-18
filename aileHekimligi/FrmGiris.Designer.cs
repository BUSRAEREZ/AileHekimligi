
namespace aileHekimligi
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.lbl_tcNo = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.tx_tcNo = new System.Windows.Forms.TextBox();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.chbx_sifreGorunur = new System.Windows.Forms.CheckBox();
            this.hbx_beniHatirla = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_tcNo
            // 
            this.lbl_tcNo.AutoSize = true;
            this.lbl_tcNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tcNo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tcNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_tcNo.Location = new System.Drawing.Point(47, 68);
            this.lbl_tcNo.Name = "lbl_tcNo";
            this.lbl_tcNo.Size = new System.Drawing.Size(66, 21);
            this.lbl_tcNo.TabIndex = 0;
            this.lbl_tcNo.Text = "Tc No :";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sifre.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sifre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_sifre.Location = new System.Drawing.Point(56, 114);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(57, 21);
            this.lbl_sifre.TabIndex = 0;
            this.lbl_sifre.Text = "Şifre :";
            // 
            // tx_tcNo
            // 
            this.tx_tcNo.Location = new System.Drawing.Point(119, 71);
            this.tx_tcNo.Name = "tx_tcNo";
            this.tx_tcNo.Size = new System.Drawing.Size(178, 20);
            this.tx_tcNo.TabIndex = 1;
            // 
            // tx_sifre
            // 
            this.tx_sifre.Location = new System.Drawing.Point(119, 117);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.PasswordChar = '*';
            this.tx_sifre.Size = new System.Drawing.Size(178, 20);
            this.tx_sifre.TabIndex = 1;
            // 
            // btn_Giris
            // 
            this.btn_Giris.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Giris.Location = new System.Drawing.Point(155, 200);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(121, 36);
            this.btn_Giris.TabIndex = 2;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // chbx_sifreGorunur
            // 
            this.chbx_sifreGorunur.AutoSize = true;
            this.chbx_sifreGorunur.BackColor = System.Drawing.Color.Transparent;
            this.chbx_sifreGorunur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbx_sifreGorunur.Location = new System.Drawing.Point(461, 71);
            this.chbx_sifreGorunur.Name = "chbx_sifreGorunur";
            this.chbx_sifreGorunur.Size = new System.Drawing.Size(88, 17);
            this.chbx_sifreGorunur.TabIndex = 3;
            this.chbx_sifreGorunur.Text = "Şifreyi Göster";
            this.chbx_sifreGorunur.UseVisualStyleBackColor = false;
            this.chbx_sifreGorunur.CheckedChanged += new System.EventHandler(this.chbx_sifreGorunur_CheckedChanged);
            // 
            // hbx_beniHatirla
            // 
            this.hbx_beniHatirla.AutoSize = true;
            this.hbx_beniHatirla.BackColor = System.Drawing.Color.Transparent;
            this.hbx_beniHatirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hbx_beniHatirla.ForeColor = System.Drawing.Color.Transparent;
            this.hbx_beniHatirla.Location = new System.Drawing.Point(461, 111);
            this.hbx_beniHatirla.Name = "hbx_beniHatirla";
            this.hbx_beniHatirla.Size = new System.Drawing.Size(90, 19);
            this.hbx_beniHatirla.TabIndex = 4;
            this.hbx_beniHatirla.Text = "Beni Hatirla";
            this.hbx_beniHatirla.UseVisualStyleBackColor = false;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 363);
            this.Controls.Add(this.hbx_beniHatirla);
            this.Controls.Add(this.chbx_sifreGorunur);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.tx_tcNo);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_tcNo);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tcNo;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox tx_tcNo;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.CheckBox chbx_sifreGorunur;
        private System.Windows.Forms.CheckBox hbx_beniHatirla;
    }
}