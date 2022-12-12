using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace geschwindigkeit
{
    public partial class CGeschwindigkeitDlg : Form
    {
        public CGeschwindigkeitDlg()
        {
            InitializeComponent();
        }

        // Methoden
        private double BerechneGeschwindigkeit(string sStrecke, string sZeit)
        {

            double dblGeschwindigkeit = 0;
            double dblZeit = double.Parse(sZeit);
            double dblStrecke = double.Parse(sStrecke);

            if (dblZeit <= 0)
            {
                MessageBox.Show($"Die Zeit darf nicht 0 oder negativ sein: {sZeit}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtZeit.Focus();
                txtZeit.SelectAll();
            }
            dblGeschwindigkeit = dblStrecke / dblZeit;
            return dblGeschwindigkeit;
        }

        private double BerechneStrecke(string sZeit, string sGeschwindigkeit)
        {
            double dblStrecke = 0;
            double dblZeit = double.Parse(sZeit);
            double dblGeschwindigkeit = double.Parse(sGeschwindigkeit);

            if (dblGeschwindigkeit <= 0)
            {
                MessageBox.Show($"Die Zeit darf nicht 0 oder negativ sein: {sGeschwindigkeit}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGeschwindigkeit.Focus();
                txtGeschwindigkeit.SelectAll();
            }
            dblStrecke = dblZeit * dblGeschwindigkeit;
            return dblStrecke;
        }

        private double BerechneZeit(string sStrecke, string sGeschwindigkeit)
        {
            double dblZeit = 0;
            double dblStrecke = double.Parse(sStrecke);
            double dblGeschwindigkeit = double.Parse(sGeschwindigkeit);

            if (dblGeschwindigkeit <= 0)
            {
                MessageBox.Show($"Die Zeit darf nicht 0 oder negativ sein: {sGeschwindigkeit}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGeschwindigkeit.Focus();
                txtGeschwindigkeit.SelectAll();
            }
            dblZeit = dblStrecke / dblGeschwindigkeit;
            return dblZeit;
        }

        private void BerechneAlleWerte(ref double dblRefStrecke, ref double dblRefGeschwindigkeit, ref double dblRefZeit)
        {
            string textGeschwindigkeit = txtGeschwindigkeit.Text;
            string textStrecke = txtStrecke.Text;
            string textZeit = txtZeit.Text;

            if (string.IsNullOrEmpty(textGeschwindigkeit))
            {
                dblRefGeschwindigkeit = BerechneGeschwindigkeit(textStrecke, textZeit);
            }
            else if (string.IsNullOrEmpty(textStrecke))
            {
                dblRefStrecke = BerechneStrecke(textZeit, textGeschwindigkeit);
            }
            else
            {
                dblRefZeit = BerechneZeit(textStrecke, textGeschwindigkeit);
            }
        }


        private void btnBerechnen_Click(object sender, EventArgs e)
        {

            double dblOutputGeschwindigkeit = 0;
            if (txtGeschwindigkeit.Text != "" && double.TryParse(txtGeschwindigkeit.Text, out dblOutputGeschwindigkeit) == false)
            {
                MessageBox.Show("Die Geschwindigkeit muss ein nummerischer Wert sein: '" + txtGeschwindigkeit.Text + "'");
                txtGeschwindigkeit.Focus();
                txtGeschwindigkeit.SelectAll();
                return;
            }
            double dblOutputStrecke = 0;
            if (txtStrecke.Text != "" && double.TryParse(txtStrecke.Text, out dblOutputStrecke) == false)
            {
                MessageBox.Show("Die Strecke muss ein nummerischer Wert sein: '" + txtStrecke.Text + "'");
                txtStrecke.Focus();
                txtStrecke.SelectAll();
                return;
            }
            double dblOutputZeit = 0;
            if (txtZeit.Text != "" && double.TryParse(txtZeit.Text, out dblOutputZeit) == false)
            {
                MessageBox.Show("Die Zeit muss ein nummerischer Wert sein: '" + txtZeit.Text + "'");
                txtZeit.Focus();
                txtZeit.SelectAll();
                return;
            }

            BerechneAlleWerte(ref dblOutputStrecke, ref dblOutputGeschwindigkeit, ref dblOutputZeit);

            txtStrecke.Text = dblOutputStrecke.ToString();
            txtGeschwindigkeit.Text = dblOutputGeschwindigkeit.ToString();
            txtZeit.Text = dblOutputZeit.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStrecke.Text = "";
            txtGeschwindigkeit.Text = "";
            txtZeit.Text = "";
        }

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie die Applikation wirklich schliessen?", "Applikation schliessen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}