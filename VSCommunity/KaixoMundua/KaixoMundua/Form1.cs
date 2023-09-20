namespace KaixoMundua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKaixo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaixo Mundua"); Application.Exit();
        }
    }
}