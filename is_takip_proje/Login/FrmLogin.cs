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

namespace is_takip_proje.Login
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}
        DbİsTakipEntities db = new DbİsTakipEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre kontrolü olmadan direkt giriş
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre kontrolü olmadan direkt giriş
            PersonelGorevFormlari.FrmPersonelFormu fr = new PersonelGorevFormlari.FrmPersonelFormu();
            // Eğer kullanıcının adını manuel set etmek isterseniz
            fr.KullaniciAdi = "Misafir";
            fr.Show();
            this.Hide();
        }		

		private void hyperlinkLabelControl3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
