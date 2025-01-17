using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Formlar.FrmDepartmanlar frm;
        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Formlar.FrmDepartmanlar();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        Formlar.FrmPersoneller frm2;
        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new Formlar.FrmPersoneller();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        Formlar.FrmPersonelIstatistik frm3;
        private void BtnPersonelIsatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new Formlar.FrmPersonelIstatistik();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        Formlar.FrmGorevListesi frm4;
        private void BtnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new Formlar.FrmGorevListesi();
                frm4.MdiParent = this;
                frm4.Show();
            }

        }

        private void BtnYeniGorev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniGorev frm5 = new Formlar.FrmYeniGorev();
            frm5.Show();
        }

        private void BtnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevDetay frm6 = new Formlar.FrmGorevDetay();
            frm6.Show();
        }
        Formlar.FrmAnaForm anaform;
        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anaform == null || anaform.IsDisposed)
            {
                anaform = new Formlar.FrmAnaForm();
                anaform.MdiParent = this;
                anaform.Show();
            }
        }
		Formlar.FrmAktifCagrilar aktifcagri;
		private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (aktifcagri == null || aktifcagri.IsDisposed)
			{
				aktifcagri = new Formlar.FrmAktifCagrilar();
				aktifcagri.MdiParent = this;
				aktifcagri.Show();
			}
		}
		Formlar.FrmPasifCagrilar pasifcagri;
		private void BtnPasifCagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (pasifcagri == null || pasifcagri.IsDisposed)
			{
				pasifcagri = new Formlar.FrmPasifCagrilar();
				pasifcagri.MdiParent = this;
				pasifcagri.Show();
			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Formlar.FrmHesapMakinesi frm6;
        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (frm6 == null || frm6.IsDisposed)
            {
                frm6 = new Formlar.FrmHesapMakinesi();
                frm6.Show();
            }

        }
        Formlar.FrmDövizKuru frm7;
        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {
                frm7 = new Formlar.FrmDövizKuru();
                frm7.Show();
            }
        }
        Formlar.FrmHaritalar frm8;
        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm8 == null || frm8.IsDisposed)
            {
                frm8 = new Formlar.FrmHaritalar();
                frm8.Show();
            }
        }
        Formlar.FrmYeniDepartman frm9;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm9 == null || frm9.IsDisposed)
            {
                frm9 = new Formlar.FrmYeniDepartman();
                frm9.Show();
            }
        }
        Formlar.FrmDepartmanİstatistikleri frm10;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm10 == null || frm10.IsDisposed)
            {
                frm10 = new Formlar.FrmDepartmanİstatistikleri();
                frm10.MdiParent = this;
                frm10.Show();
            } 
        }
        Formlar.FrmFirmalar frm11;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm11 == null || frm11.IsDisposed)
            {
                frm11 = new Formlar.FrmFirmalar();
                frm11.MdiParent = this;
                frm11.Show();
            }
        }
        Formlar.FrmYeniPersonel frm12;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm12 == null || frm12.IsDisposed)
            {
                frm12 = new Formlar.FrmYeniPersonel();
                frm12.Show();
            }
        }
    }
}
