using JeuDeNim.Models;
using System.Text;
using System.Security.Cryptography;
using JeuDeNim.Class;

namespace JeuDeNim
{
    public partial class Connexion : Form
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        public Connexion()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inscriptioncs inscriptioncs = new Inscriptioncs();
            inscriptioncs.Show();
            this.Hide();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (txtMotDePasseConnexion.Text == "" || txtPseudoConnexion.Text =="")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }
            using (FortBoyardDjessimKilianFabienContext db = new FortBoyardDjessimKilianFabienContext())
            {
                Utilisateur user = db.Utilisateurs.Where(o => o.Pseudo == txtPseudoConnexion.Text).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Le pseudo est incorrect");
                    return;
                }
                string mdpHash = HashPassword(txtMotDePasseConnexion.Text);
                if (mdpHash == user.Mdp)
                {
                    try
                    {
                        SessionManager.Login(user);

                    }
                    catch (Exception erreur)
                    {
                        MessageBox.Show(erreur.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect");
                }
            }
        }
    }
}
