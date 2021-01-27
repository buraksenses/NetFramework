using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Z1.Udemy.RSSOkumaUygulaması
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

        private void txt_rssurl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            List<Haber> kayitlar = XMLcevir();
            lst_baslik.DataSource = kayitlar;
        }

        private List<Haber> XMLcevir()
        {
            List<Haber> Kayitlar = new List<Haber>();
            XDocument XMLkaynak = XDocument.Load(txt_rssurl.Text);
            List<XElement> rows = XMLkaynak.Descendants("item").ToList();

            foreach (XElement item in rows)
            {
                Haber temp = new Haber();
                temp.aciklama = item.Element("description").Value.ToString();
                temp.baslik = item.Element("title").Value.ToString();
                Kayitlar.Add(temp);
            }
            return Kayitlar;
        }

        private void lst_baslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox secilenDeger = (ListBox)sender;
            Haber secilenHaber = (Haber)secilenDeger.SelectedItem;
            webBrowser1.DocumentText = secilenHaber.aciklama;
        }
    }
}
