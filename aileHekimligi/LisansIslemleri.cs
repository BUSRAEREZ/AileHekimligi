using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Text;

namespace aileHekimligi
{
    public static class LisansIslemleri
    {
        public static bool LisansKontrol()
        {
            if (File.Exists("lisans.lo") == false)
                return false;
            string okunanLisans = "";

            StreamReader sr = new StreamReader("lisans.lo", Encoding.Default);
            okunanLisans = sr.ReadLine();
            sr.Close();
            if (okunanLisans == LisansAnahtariOlustur(uygulamaAnahtari()))
                return true;
            else
                return false;
        }

        public static String CPUSeriNoCek()
        {
            String processorID = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * FROM WIN32_Processor");
            ManagementObjectCollection mObject = searcher.Get();

            foreach (ManagementObject obj in mObject)
            {
                processorID = obj["ProcessorId"].ToString();
            }

            return processorID;
        }

        public static List<string> HDDSeriNoCek()
        {
            List<string> serials = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            ManagementObjectCollection disks = searcher.Get();
            foreach (ManagementObject disk in disks)
            {
                if (disk["SerialNumber"] == null)
                    serials.Add("");
                else
                    serials.Add(disk["SerialNumber"].ToString());
            }
            return serials;
        }

        public static string uygulamaAnahtari()
        {
            String CPUSeriNo = CPUSeriNoCek();
            string HddSeriNo = "";
            //foreach (var item in HDDSeriNoCek())
            //{
            //    HddSeriNo += item.Trim();
            //}
            HddSeriNo = HDDSeriNoCek()[0];
            //       textBox1.Text = CPUSeriNo;
            //        textBox2.Text = HddSeriNo;

            string hddCpu = CPUSeriNo.ToUpper() + HddSeriNo.ToUpper();
            string degisenHddCpu = "";

            for (int i = 0; i < hddCpu.Length; i++)
            {
                if (hddCpu[i] == 'B')
                    degisenHddCpu += '5';
                else if (hddCpu[i] == 'F')
                    degisenHddCpu += '7';
                else if (hddCpu[i] == '5')
                    degisenHddCpu += 'F';
                else if (hddCpu[i] == '7')
                    degisenHddCpu += 'B';
                else if (hddCpu[i] == '0')
                    degisenHddCpu += 'S';
                else if (hddCpu[i] == 'S')
                    degisenHddCpu += '6';
                else if (hddCpu[i] == '6')
                    degisenHddCpu += '0';
                else if (hddCpu[i] == '1')
                    degisenHddCpu += '9';
                else if (hddCpu[i] == '9')
                    degisenHddCpu += '1';
                else
                    degisenHddCpu += hddCpu[i];

            }
            //textBox3.Text = degisenHddCpu;

            string a = degisenHddCpu + "-Restorant V1.0";

            a = VTDI.DigerIslemler.MD5Sifrele(a).ToUpper();
            //       tx_lisansAnahtari.Text = a.ToString();

            string uygulamaAnahtari = a.Substring(2, 2) + a.Substring(5, 2) + a.Substring(8, 1) + "-" +
                a.Substring(10, 2) + a.Substring(13, 2) + a.Substring(17, 1) + "-" +
                a.Substring(23, 2) + a.Substring(26, 2) + a.Substring(21, 1) + "-" +
                a.Substring(28, 2) + a.Substring(25, 2) + a.Substring(31, 1);

            // tx_uygulamaAnahtari.Text = uygulamaAnahtari;
            return uygulamaAnahtari;

        }

        public static string LisansAnahtariOlustur(string uygulamaAnahtari)
        {
            string uygulamaAnahtri = uygulamaAnahtari;
            uygulamaAnahtri = uygulamaAnahtri + "-REstorant V1.0-LisansOluşturucu";

            string a = VTDI.DigerIslemler.MD5Sifrele(uygulamaAnahtri);

            string lisansAnahtari = a.Substring(2, 2) + a.Substring(5, 2) + a.Substring(8, 1) + "-" +
               a.Substring(10, 2) + a.Substring(13, 2) + a.Substring(17, 1) + "-" +
               a.Substring(23, 2) + a.Substring(26, 2) + a.Substring(21, 1) + "-" +
               a.Substring(28, 2) + a.Substring(25, 2) + a.Substring(31, 1);
            // tx_lisansAnahtari.Text = lisansAnahtari;

            return lisansAnahtari;
        }
    }
}
