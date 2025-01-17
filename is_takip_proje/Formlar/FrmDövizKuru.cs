using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using DevExpress.XtraGrid;
using System.Xml;

namespace is_takip_proje.Formlar
{
    public partial class FrmDövizKuru : Form
    {
        public FrmDövizKuru()
        {
            InitializeComponent();
        }




        // Döviz bilgilerini gösteren metot
        public void DovizGoster()
        {
            try
            {
                // XML Verisini yükle
                XmlDocument xmlVerisi = new XmlDocument();
                xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

                // Döviz bilgilerini çek
                decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/ForexSelling").InnerText.Replace('.', ','));
                decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/ForexSelling").InnerText.Replace('.', ','));
                decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/ForexSelling").InnerText.Replace('.', ','));

                // Label'lara yazdır
                lblDolar.Text = $"{dolar:C}";
                lblEuro.Text = $"{euro:C}";
                lblSterlin.Text = $"{sterlin:C}";
            }
            catch (XmlException xml)
            {
                timer1.Stop(); // Timer'ı durdur
                MessageBox.Show("Döviz bilgisi alınamadı: " + xml.Message);
            }
            catch (Exception ex)
            {
                timer1.Stop(); // Timer'ı durdur
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Timer Tick olayı
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 5000; // 5 saniyede bir yenile
            DovizGoster();
        }

        // Form yüklendiğinde Timer'ı başlat
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); // Timer'ı başlat
            DovizGoster(); // İlk döviz bilgilerini hemen yükle
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            DovizGoster(); // Döviz bilgilerini yenile
        }
    }
}