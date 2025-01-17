using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FrmPersonelIstatistik : Form
    {
        public FrmPersonelIstatistik()
        {
            InitializeComponent();
        }
        DbİsTakipEntities db = new DbİsTakipEntities();
        private void FrmPersonelIstatistik_Load(object sender, EventArgs e)
        {
            LblToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();
            LblToplamFirma.Text = db.TblFirmalar.Count().ToString();
            LblToplamPersonel.Text = db.TblPersonel.Count().ToString();
            LblAktifIs.Text = db.TblGörevler.Count(x => x.Durum == "true").ToString();
            LblPasifIs.Text = db.TblGörevler.Count(x => x.Durum == "false").ToString();
            LblSonGorev.Text = db.TblGörevler.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault().ToString();
            LblSehirSayisi.Text = db.TblFirmalar.Select(x => x.İl).Distinct().Count().ToString();
            LblSektor.Text = db.TblFirmalar.Select(x => x.Sektor).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            LblBugunAcilanGorevler.Text = db.TblGörevler.Count(x => x.Tarih == bugun).ToString();

            var pers = db.TblGörevler
                .GroupBy(x => x.GörevAlan)
                .OrderByDescending(y => y.Count())
                .Select(z => z.Key)
                .FirstOrDefault();

            var personel = db.TblPersonel.FirstOrDefault(x => x.ID == pers);
            LblAyinPersoneli.Text = personel != null ? $"{personel.Ad} {personel.Soyad}" : string.Empty;
            LblAyinDepartmani.Text = db.TblDepartmanlar.Where(x => x.ID == personel.Departman).Select(y => y.Ad).FirstOrDefault().ToString();

            var sonGorevTarihi = db.TblGörevDetaylar
                .OrderByDescending(x => x.ID)
                .Select(x => x.Tarih)
                .FirstOrDefault();
            LblSonGorevDetay.Text = sonGorevTarihi.HasValue ? sonGorevTarihi.Value.ToString("yyyy-MM-dd") : string.Empty;

        }
    }
}
