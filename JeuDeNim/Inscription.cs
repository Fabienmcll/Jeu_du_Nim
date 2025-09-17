using JeuDeNim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;



namespace JeuDeNim
{
    public partial class Inscriptioncs : Form
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

        public Inscriptioncs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMdpInscription.Text == "" || txtNomInscription.Text == "" || txtPrenomInscription.Text == "" || txtPseudoInscription.Text =="")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }
            Utilisateur user = new Utilisateur();
            user.Nom = txtNomInscription.Text.Trim();
            user.Prenom = txtPrenomInscription.Text.Trim();
            user.Mdp = HashPassword(txtMdpInscription.Text.Trim());
            user.Pseudo = txtPseudoInscription.Text.Trim();
            user.DateCreation = DateTime.Now;
            user.NbVictoire = 0;
            try
            {
                using (var db = new FortBoyardDjessimKilianFabienContext())
                {
                    db.Utilisateurs.Add(user);
                    int result = db.SaveChanges();

                    if (result > 0)
                        MessageBox.Show("Utilisateur ajouté avec succès !");
                    else
                        MessageBox.Show("Échec de l'ajout !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message);
            }

        }
    }
}
