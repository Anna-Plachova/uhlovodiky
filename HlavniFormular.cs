namespace Uhlovodiky
{
    public partial class HlavniFormular : Form
    {
        IUhlovodik uhlovodik = null;

        public HlavniFormular()
        {
            InitializeComponent();
        }

        private void VyberUhlovodik()
        {
            if (radioAlkan.Checked)
                uhlovodik = new Alkan();
            else if (radioAlken.Checked)
                uhlovodik = new Alken();
            else
                uhlovodik = new Alkyn();
        }

        private void btnNazevZeVzorce_Click(object sender, EventArgs e)
        {
            try
            {
                var vzorec = txtVzorec.Text;

                // kontrola neprázdné hodnoty
                if (string.IsNullOrEmpty(vzorec))
                    throw new Exception("Pole vzorec je prázdné. Zadejte vzorec a zkuste znovu.");

                VyberUhlovodik();
                       
                txtNazev.Text = uhlovodik.NazevZeVzorce(vzorec);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chybný vzorec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVzorecZNazvu_Click(object sender, EventArgs e)
        {
            try
            {
                var nazev = txtNazev.Text;
                if (string.IsNullOrEmpty(nazev))
                    throw new Exception("Pole název je prázdné. Zadejte název a zkuste znovu.");

                VyberUhlovodik();

                txtVzorec.Text = uhlovodik.VzorecZNazvu(nazev);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chybný název", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            txtNazev.Text = "";
            txtVzorec.Text = "";
        }
    }
}