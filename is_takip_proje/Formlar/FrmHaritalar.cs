using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraMap;


namespace is_takip_proje.Formlar
{
    public partial class FrmHaritalar : Form
    {
        public FrmHaritalar()
        {
            InitializeComponent();
        }
        private void FrmHaritalar_Load_1(object sender, EventArgs e)
        {
            // OpenStreetMap sağlayıcısı ile haritayı başlat
            ImageLayer imageLayer = new ImageLayer();
            OpenStreetMapDataProvider osmProvider = new OpenStreetMapDataProvider();
            imageLayer.DataProvider = osmProvider;

            // Haritayı MapControl'e ekle
            mapControl1.Layers.Add(imageLayer);

            // Haritanın başlangıç konumu ve zoom seviyesi
            mapControl1.ZoomLevel = 5; // Yakınlaştırma seviyesi
            mapControl1.CenterPoint = new GeoPoint(39.92077, 32.85411); // Ankara'nın koordinatları

            // İşaretçiler ekle
            AddMarker(41.0082, 28.9784, "İstanbul"); // İstanbul
            AddMarker(39.92077, 32.85411, "Ankara"); // Ankara
        }

        // Haritaya işaretçi ekleyen metot
        private void AddMarker(double latitude, double longitude, string description)
        {
            // İşaretçi katmanı oluştur
            VectorItemsLayer vectorLayer = new VectorItemsLayer();
            MapItemStorage itemStorage = new MapItemStorage();

            // İşaretçi (pushpin) ekle
            MapPushpin pushpin = new MapPushpin()
            {
                Location = new GeoPoint(latitude, longitude),
                Text = description,
            };

            // İşaretçiyi depoya ekle
            itemStorage.Items.Add(pushpin);

            // İşaretçi katmanını haritaya ekle
            vectorLayer.Data = itemStorage;
            mapControl1.Layers.Add(vectorLayer);
        }

        
    }
}

