﻿using is_takip_proje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.PersonelGorevFormlari
{
	public partial class FrmPasifGorevler : Form
	{
		public FrmPasifGorevler()
		{
			InitializeComponent();
		}

		public string kullaniciAdi;
        DbİsTakipEntities db = new DbİsTakipEntities();
        private void FrmPasifGorevler_Load(object sender, EventArgs e)
		{
			var personelId = db.TblPersonel.Where(x => x.KullaniciAdi == kullaniciAdi).Select(y => y.ID).FirstOrDefault();
			var degerler = (from x in db.TblGörevler
							select new
							{
								x.ID,
								x.Aciklama,
								x.Tarih,
								x.GörevAlan,
								x.TblPersonel.Ad,
								x.Durum
							}).Where(x => x.GörevAlan == personelId && x.Durum == "false").ToList();


			gridControl1.DataSource = degerler;
			gridView1.Columns["Durum"].Visible = false;
			gridView1.Columns["GorevAlan"].Visible = false;
		}
	}
}
