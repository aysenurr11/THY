namespace THY_PROJE_ODEVİ
{
    //Data Source=AYSENURDESKTOP\SQLEXPRESS;Initial Catalog=THYPROJE;Integrated Security=True;Server Certificate=True;Trust Server Certificate=True
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void girisyap_Click(object sender, EventArgs e)
        {

            girisyap grsyap = new girisyap();
            grsyap.Show();

        }

        private void kayıtol_Click(object sender, EventArgs e)
        {

            Kayıtol kytol = new Kayıtol();
            kytol.Show();



        }

        private void satıcıgiris_Click(object sender, EventArgs e)
        {

            satıcıgirisi stcgrs = new satıcıgirisi();
            stcgrs.Show();

        }

        private void admingiris_Click(object sender, EventArgs e)
        {

            admingirisi admgrs = new admingirisi();
            admgrs.Show();

        }

        private void checkin_Click(object sender, EventArgs e)
        {
            checkinyap checkyap = new checkinyap();
            checkyap.Show();

        }

        private void ucusdurum_Click(object sender, EventArgs e)
        {

          ucusdurumları ucusbak = new ucusdurumları();
            ucusbak.Show();
        }
    }
}
