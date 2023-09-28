namespace Ariketa02_Array
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

        private void btnHurrengoa_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1:
                    lbZenbakia.Text = "Zenbakia 2";
                    ariketa.Zenbakiak[0] = float.Parse(tbEmaitza.Text);
                    tbEmaitza.Clear();
                    i = 2;
                    break;
                case 2:
                    lbZenbakia.Text = "Zenbakia 3";
                    ariketa.Zenbakiak[1] = float.Parse(tbEmaitza.Text);
                    tbEmaitza.Clear();
                    i = 3;
                    break;
                case 3:
                    lbZenbakia.Text = "Zenbakia 4";
                    ariketa.Zenbakiak[2] = float.Parse(tbEmaitza.Text);
                    tbEmaitza.Clear();
                    i = 4;
                    break;

                case 4:
                    lbZenbakia.Text = "Emaitza";
                    ariketa.Zenbakiak[3] = float.Parse(tbEmaitza.Text);
                    tbEmaitza.Text = "(" + ariketa.Zenbakiak[0] + " + (" + ariketa.Zenbakiak[1] + "x2)" + " + (" + ariketa.Zenbakiak[2] + "x3)" + " + (" + ariketa.Zenbakiak[3] + "x4)/4 = " + ariketa.eragiketaluzea().ToString();
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