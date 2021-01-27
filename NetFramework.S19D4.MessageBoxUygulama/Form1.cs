using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19D4.MessageBoxUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            int islemsonuc = YeniKayitEkle(new musteri()
            {
                id = Guid.NewGuid(),
                isim = txtIsim.Text,
                soyisim = txtSoyisim.Text,
                emailAdres = txtEmail.Text,
                telefonNo = txtTelefon.Text     
            });

            if (islemsonuc > 0)
            {
                DialogResult res = MessageBox.Show("Müşteri ekleme şlemi başarılı, yeni müşteri eklemek ister misiniz?",
                    "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    bildirimcubugu = new NotifyIcon();
                    bildirimcubugu.BalloonTipText = "Toplam kayıt sayısı" +" "+ sanalDatabase.musteriler.Count.ToString(); 
                    bildirimcubugu.BalloonTipTitle = "Müşteri Adet Bilgisi";
                    bildirimcubugu.Visible = true;
                    bildirimcubugu.Icon = SystemIcons.Information;
                    bildirimcubugu.ShowBalloonTip(20000);
                }
                else
                {
                    
                }
                ekraniTemizle();
                ekraniListele();
            }
        }

        private int YeniKayitEkle(musteri data)
        {
            sanalDatabase.musteriler.Add(data);
            return 1;
        }

        private void ekraniTemizle()
        {
            txtIsim.Text = string.Empty;
            txtSoyisim.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void ekraniListele()
        {
            lstMusteriler.DataSource = sanalDatabase.musteriler;
        }

        private void txtIsim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
