using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace aileHekimligi
{
    public partial class WinAyar : Form
    {
        public WinAyar()
        {
            InitializeComponent();
        }

        private void chbx_windowslaBasla_CheckedChanged(object sender, EventArgs e)
        {

            if (chbx_windowslaBasla.Checked)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("Restorant", "\"" + Application.ExecutablePath + "\"");
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue("Restorant");
            }
        }

        private void WinAyar_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                if (key.GetValue("Restorant").ToString() == "\"" + Application.ExecutablePath + "\"")
                {
                    chbx_windowslaBasla.Checked = true;
                }
            }
            catch
            { }

        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
