namespace Ariketa2
{
    public partial class Form1 : Form
    {
        public int i = 1;

        Ariketa ariketa = new Ariketa();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbZenbakia_Click(object sender, EventArgs e)
        {

        }

        private void tbEmaitza_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHurrengoa_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1:
                    lbZenbakia.Text = "Zenbakia 2";
                    ariketa.a = float.Parse(tbEmaitza.Text);
                    tbEmaitza.Clear();
                    i = 2;
                    break;
                case 2:
                    lbZenbakia.Text = "Zenbakia 3";
                    ariketa.b = float.Parse(tbEmaitza.Text);
                    tbEmaitza.Clear();
                    i = 3;
                    break;
                case 3:
                    lbZenbakia.Text = "Zenbakia 4";
                    ariketa.c = float.Parse(tbEmaitza.Text);
                    tbEmaitza.Clear();
                    i = 4;
                    break;

                case 4:
                    lbZenbakia.Text = "Emaitza";
                    ariketa.d = float.Parse(tbEmaitza.Text);
                    tbEmaitza.Text = "(" + ariketa.a + " + (" + ariketa.b + "x2)" + " + (" + ariketa.c + "x3)" + " + (" + ariketa.d + "x4)/4 = " + ariketa.eragiketaluzea().ToString();
                    i++;
                    break;


            }
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            lbZenbakia.Text = "Zenbakia 1";
            tbEmaitza.Clear();
            i = 1;
        }

        private void btIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}