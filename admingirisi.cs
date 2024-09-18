using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace THY_PROJE_ODEVİ
{
    public partial class admingirisi : Form
    {
        public admingirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


           adminislemleri  islemadmn = new adminislemleri();
            islemadmn.Show();

        }
    }
}
