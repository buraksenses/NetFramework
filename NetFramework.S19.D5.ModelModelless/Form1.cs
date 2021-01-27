using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D5.ModelModelless
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGöstre_Click(object sender, EventArgs e)
        {
            musteriKayit musteri = new musteriKayit();
            musteri.Show();
            //yeni form oluşturmak için kullanılır birden fazla kez tıklanabilir veya kullanıcı form açıkken uygulamanın diğer 
            //menülerine erişebilir.
        }

        private void btnGöstrePopup_Click(object sender, EventArgs e)
        {
            musteriKayit musteri1 = new musteriKayit();
            musteri1.ShowDialog();
            //Kullanıcı bu şekilde form açtığı zaman ilgili form kapanmadan herhangi başka bir işlem yapamaz.
        }
    }
}
