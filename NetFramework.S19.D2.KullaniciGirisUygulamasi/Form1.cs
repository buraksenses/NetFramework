using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D2.KullaniciGirisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public void btnGirisYap_Click(object sender, EventArgs e)
        {

            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            kullanici kontrol = sanalDatabase.kullaniciTablo.Find(i => i.kullaniciAdi == kullaniciAdi && i.sifre == sifre);



            if (kontrol != null)
            {
                anaForm ana = new anaForm(kontrol);
                ana.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.LightYellow;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.White;
        }
    }
}
