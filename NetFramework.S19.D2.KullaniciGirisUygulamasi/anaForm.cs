using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D2.KullaniciGirisUygulamasi
{
    public partial class anaForm : Form
    {


        public anaForm(kullanici kullanici)
        {
            InitializeComponent();

            txtIsim.Text = kullanici.isim;
            txtKullaniciadi.Text = kullanici.kullaniciAdi;
            txtKullaniciadi.Enabled = false;
            txtSifre.Text = kullanici.sifre;
            txtSoyisim.Text = kullanici.soyisim;
            txtAciklama.Text = kullanici.aciklama;
            txtAciklama.Enabled = false;
            btnGüncelle.Tag = kullanici.id;

        }

        private void anaForm_Load(object sender, EventArgs e)
        {

        }

 

        public void btnGüncelle_Click(object sender, EventArgs e)
        {
            //Button btnGuncelleYakala = (Button)sender;
            int id = (int)btnGüncelle.Tag;

            int index = sanalDatabase.kullaniciTablo.FindIndex(i => i.id == id);

            sanalDatabase.kullaniciTablo[index].isim = txtIsim.Text;
            sanalDatabase.kullaniciTablo[index].sifre = txtSifre.Text;
            sanalDatabase.kullaniciTablo[index].soyisim = txtSoyisim.Text;
            
        }
    }
}
