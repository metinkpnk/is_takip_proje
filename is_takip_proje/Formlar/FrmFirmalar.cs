using DevExpress.XtraEditors;
using is_takip_proje.Entity;
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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        DbİsTakipEntities db = new DbİsTakipEntities();
        void Listele()
        {
            var degerler = (from x in db.TblFirmalar
                            select new
                            {
                                x.ID,
                                x.Ad,
                                x.Yetkili,
                                x.Telefon,
                                x.Mail,
                                x.Sektor,
                                x.İl,
                                x.İlce,
                                x.Adres
                            }).ToList();

            gridControl1.DataSource = degerler;
        }
         



       

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
           Listele();
        }
    }

}

