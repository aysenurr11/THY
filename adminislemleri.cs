using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace THY_PROJE_ODEVİ
{
    public partial class adminislemleri : Form
    {
       

        SqlConnection baglanti = new SqlConnection("Data Source = AYSENURDESKTOP\\SQLEXPRESS; Initial Catalog = THYPROJE; Integrated Security = True; Encrypt=True;Server Certificate = True; Trust Server Certificate=True");
        SqlDataAdapter adtr;
        SqlCommand komut;
        DataTable tablo1 = new DataTable();
        DataTable tablo2 = new DataTable();

        public adminislemleri()
        {
            InitializeComponent(GetLabel2());
        }




   





        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
