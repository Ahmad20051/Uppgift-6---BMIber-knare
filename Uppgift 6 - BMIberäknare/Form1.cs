namespace Uppgift_6___BMIberäknare
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_bmi(object sender, EventArgs e)
        {
            Beräkningar beräkningar = new Beräkningar(txtVikt, txtLängd, txtResultat);
        }

        private void textBox2_ReadOnlyChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnStäng_Click(object sender, EventArgs e)
        {
            //Med hjälp av Close funktionen kan man nu klicka på "Stäng" och så stängs programmet av
            this.Close();
        }

        private void btnStartaOm_Click(object sender, EventArgs e)
        {
            //Här skapas en funktion som gör att om man klickar på "Starta om" så ska namnet, längden, vikten och resultatet rensas från rutan/textboxen
            txtNamn.Text = "";
            txtLängd.Text = "";
            txtVikt.Text = "";
            txtResultat.Text = "";
        }

        private void txtResultat_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}