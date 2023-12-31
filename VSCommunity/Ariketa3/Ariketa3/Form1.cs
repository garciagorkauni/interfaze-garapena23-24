namespace Ariketa3
{
    public partial class Form1 : Form
    {
        List<Kontaktua> kontaktuak = new List<Kontaktua>();
        List<Bezeroa> bezeroak = new List<Bezeroa>();
        List<Langile> langileak = new List<Langile>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonGorde_Click(object sender, EventArgs e)
        {
            Kontaktua datuak = new Kontaktua();
            datuak.nan = textBoxNAN.Text;
            datuak.izena = textBoxIzena.Text;
            datuak.abizena = textBoxAbizena.Text;
            datuak.email = textBoxEmail.Text;

            if (radioButtonKontaktua.Checked)
            {
                kontaktuak.Add(datuak);
                datuak.gorde();
            }
            else if (radioButtonBezeroa.Checked)
            {
                Bezeroa bezeroa = new Bezeroa();
                bezeroa.nan = datuak.nan;
                bezeroa.izena = datuak.izena;
                bezeroa.abizena = datuak.abizena;
                bezeroa.email = datuak.email;
                bezeroa.kategoria = comboBoxKategoria.Text;

                bezeroak.Add(bezeroa);
                bezeroa.gorde();
            }
            else if (radioButtonLangilea.Checked)
            {
                Langile langilea = new Langile();
                langilea.nan = datuak.nan;
                langilea.izena = datuak.izena;
                langilea.abizena = datuak.abizena;
                langilea.email = datuak.email;
                langilea.soldata = float.Parse(textBoxSoldata.Text);
                langilea.segurtasunSoziala = textBoxSegurtasunSoziala.Text;

                langileak.Add(langilea);
                langilea.gorde();
            }
            else
            {
                MessageBox.Show("Mota bat aukera behar duzu");
                Application.Restart();
            }

            textBoxNAN.Clear();
            textBoxIzena.Clear();
            textBoxAbizena.Clear();
            textBoxEmail.Clear();
            textBoxSoldata.Clear();
            textBoxSegurtasunSoziala.Clear();

            radioButtonKontaktua.Checked = false;
            radioButtonBezeroa.Checked = false;
            radioButtonLangilea.Checked = false;
            comboBoxKategoria.Text = "";
        }

        private void comboBoxKategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String erakustekoa = "";
            switch (comboBoxErakutsi.Text)
            {
                case ("Kontaktuak"):
                    for (int i = 0; i < kontaktuak.Count();i++)
                    {
                        erakustekoa += kontaktuak[i] + "\n";
                    }

                   break;

                case ("Bezeroak"):
                    for (int i = 0; i < bezeroak.Count(); i++)
                    {
                        erakustekoa += bezeroak[i] + "\n";
                    }

                    break;

                case ("Langileak"):
                    for (int i = 0; i < langileak.Count(); i++)
                    {
                        erakustekoa += langileak[i] + "\n";
                    }

                    break;

                default:
                    erakustekoa += "Ez dago horrekin loturiko informazioa";
                    break;

            }

            MessageBox.Show(erakustekoa);
            comboBoxErakutsi.Text = "";
        }
    }
}