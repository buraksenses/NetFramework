using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D1.WindowsFormNedir
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

 

        private void btnAc_Click(object sender, EventArgs e)
        {
            string mesaj = txtMesaj.Text;

            MerhabaForm merhabaForm = new MerhabaForm(mesaj);
            merhabaForm.Show();

        }

        private void txtMesaj_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.Text = string.Empty;
        }
    }
}
