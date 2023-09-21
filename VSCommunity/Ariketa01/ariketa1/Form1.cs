namespace ariketa1
{
    public partial class Form1 : Form
    {

        Esaldia esaldi = new Esaldia();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            esaldi.hitzBakarra = textBox1.Text;
            esaldi.lotuHitzak();
            textBox1.Clear();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            esaldi.hitzBakarra = textBox1.Text;
            esaldi.lotuHitzak();
            textBox1.Clear();
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            esaldi.hitzBakarra = textBox1.Text;
            esaldi.lotuHitzak();
            textBox1.Clear();
            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            esaldi.hitzBakarra = textBox1.Text;
            esaldi.lotuHitzak();
            textBox1.Clear();
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            esaldi.hitzBakarra = textBox1.Text;
            esaldi.lotuHitzak();
            textBox1.Clear();
            button5.Enabled = false;
            buttonLotu.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(esaldi.esaldiaLotuta);
            buttonLotu.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            esaldi.esaldiaLotuta = "";
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}