namespace aileHekimligi
{
    partial class Baslangic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baslangic));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_lisansAnahtari = new System.Windows.Forms.TextBox();
            this.tx_uygulamaAnahtari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Lisansla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Uygulama Anahtarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lisans Anahtarı :";
            // 
            // tx_lisansAnahtari
            // 
            this.tx_lisansAnahtari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_lisansAnahtari.Location = new System.Drawing.Point(218, 145);
            this.tx_lisansAnahtari.Name = "tx_lisansAnahtari";
            this.tx_lisansAnahtari.Size = new System.Drawing.Size(631, 30);
            this.tx_lisansAnahtari.TabIndex = 1;
            // 
            // tx_uygulamaAnahtari
            // 
            this.tx_uygulamaAnahtari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_uygulamaAnahtari.Location = new System.Drawing.Point(218, 28);
            this.tx_uygulamaAnahtari.Name = "tx_uygulamaAnahtari";
            this.tx_uygulamaAnahtari.Size = new System.Drawing.Size(631, 30);
            this.tx_uygulamaAnahtari.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(214, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(588, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Uygulama Anahtarnızı Uygulama yöneticisine vererek Lisans Anhatarı Alınız....";
            // 
            // btn_Lisansla
            // 
            this.btn_Lisansla.Location = new System.Drawing.Point(289, 215);
            this.btn_Lisansla.Name = "btn_Lisansla";
            this.btn_Lisansla.Size = new System.Drawing.Size(310, 61);
            this.btn_Lisansla.TabIndex = 4;
            this.btn_Lisansla.Text = "Lisansla";
            this.btn_Lisansla.UseVisualStyleBackColor = true;
            this.btn_Lisansla.Click += new System.EventHandler(this.btn_Lisansla_Click);
            // 
            // Baslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 424);
            this.Controls.Add(this.btn_Lisansla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_uygulamaAnahtari);
            this.Controls.Add(this.tx_lisansAnahtari);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Baslangic";
            this.Text = "Baslangic";
            this.Load += new System.EventHandler(this.Baslangic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_lisansAnahtari;
        private System.Windows.Forms.TextBox tx_uygulamaAnahtari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Lisansla;
    }
}