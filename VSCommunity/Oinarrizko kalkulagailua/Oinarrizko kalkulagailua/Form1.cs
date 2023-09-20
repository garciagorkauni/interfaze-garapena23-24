namespace Oinarrizko_kalkulagailua
{
    public partial class Form1 : Form
    {
        Kalkulagailua kalkulagailua = new Kalkulagailua();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGehiketa_Click(object sender, EventArgs e)
        {
            try
            {
                Balidazioa();
                MessageBox.Show((kalkulagailua.Gehiketa()).ToString());
            }catch(Exception ex)
            {
                MessageBox.Show("Zerbait gaizki joan da, zaiatu berriz");
            }

}

        private void btnKenketa_Click(object sender, EventArgs e)
        {
            try {
                Balidazioa();
                MessageBox.Show((kalkulagailua.Kenketa()).ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Zerbait gaizki joan da, zaiatu berriz");
             }
        }

        private void btnBiderketa_Click(object sender, EventArgs e)
        {
            try
            {
                Balidazioa();
                MessageBox.Show((kalkulagailua.Biderketa()).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Zerbait gaizki joan da, zaiatu berriz");
            }
        }

        private void btnZatiketa_Click(object sender, EventArgs e)
        {
            try
            {
                Balidazioa();
                MessageBox.Show((kalkulagailua.Zatiketa()).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Zerbait gaizki joan da, zaiatu berriz");
            }
        }

            private void label1_Click(object sender, EventArgs e)
        {
 
        }

        private void tbZenbaki1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbZenbaki2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Balidazioa()
        {
            kalkulagailua.Zenbaki1 = float.Parse(tbZenbaki1.Text);
            kalkulagailua.Zenbaki2 = float.Parse(tbZenbaki2.Text);
        }
    }
}