namespace JeuDeNim
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Inscriptioncs inscriptioncs = new Inscriptioncs();
            inscriptioncs.ShowDialog();
        }
    }
}
