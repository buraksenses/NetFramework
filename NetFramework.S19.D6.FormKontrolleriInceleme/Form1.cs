using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D6.FormKontrolleriInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtIsim_Enter(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.LightYellow;
        }

        private void txtIsim_Leave(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.White;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Temizlemek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Kullanıcı başarıyla silindi!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //kayitTemizle();
                formElemanIndexTemizle();
            }
         
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            yeniKayitEkle(new musteri() 
            { 
            
                isim = txtIsim.Text,
                soyisim = txtSoyisim.Text,
                emailAdres = txtEmail.Text,
                telefonNo = txtTelefon.Text,
                id = Guid.NewGuid()
            
            });
            MessageBox.Show("Kullanıcı başarıyla kaydedildi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //kayitTemizle();
            
            formElemanIndexTemizle();
        }

        private void kayitTemizle()
        {
            foreach (Control item in this.Controls)
            {
                
                if (item is TextBox)
                {
                    TextBox t1 = (TextBox)item;
                    t1.Text = string.Empty;
                }
            }
        }

        private void formElemanIndexTemizle()
        {
            ((TextBox)this.Controls["txtIsim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtTelefon"]).Text = string.Empty;
            ((TextBox)this.Controls["txtEmail"]).Text = string.Empty;
            ((TextBox)this.Controls["txtSoyisim"]).Text = string.Empty;
        }

        private void yeniKayitEkle(musteri data)
        {
            sanalDatabase.musteriler.Add(data);

        }
    }
}
