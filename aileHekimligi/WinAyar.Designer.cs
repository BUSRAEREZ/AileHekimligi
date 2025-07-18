namespace aileHekimligi
{
    partial class WinAyar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinAyar));
            this.chbx_windowslaBasla = new System.Windows.Forms.CheckBox();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chbx_windowslaBasla
            // 
            this.chbx_windowslaBasla.AutoSize = true;
            this.chbx_windowslaBasla.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbx_windowslaBasla.Location = new System.Drawing.Point(48, 15);
            this.chbx_windowslaBasla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbx_windowslaBasla.Name = "chbx_windowslaBasla";
            this.chbx_windowslaBasla.Size = new System.Drawing.Size(278, 21);
            this.chbx_windowslaBasla.TabIndex = 1;
            this.chbx_windowslaBasla.Text = "Uygulama Windows İle Birlikte Başlasın ";
            this.chbx_windowslaBasla.UseVisualStyleBackColor = true;
            this.chbx_windowslaBasla.CheckedChanged += new System.EventHandler(this.chbx_windowslaBasla_CheckedChanged);
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(125, 43);
            this.btn_kapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(100, 28);
            this.btn_kapat.TabIndex = 2;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // WinAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 102);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.chbx_windowslaBasla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WinAyar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinAyar";
            this.Load += new System.EventHandler(this.WinAyar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbx_windowslaBasla;
        private System.Windows.Forms.Button btn_kapat;
    }
}