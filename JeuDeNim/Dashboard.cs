using JeuDeNim.Class;
using JeuDeNim.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDeNim
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblConnecte.Text = "Connecté en tant que : " + SessionManager.CurrentUser.Pseudo;
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            Connexion connexion = new Connexion();
            connexion.Show();
            this.Close();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            string code = RandomCode();

            Random btn = new Random();
            int nbBatonnets = btn.Next(16, 22); 


            Partie partie = new Partie();
            partie.NbJoueur = 1;
            partie.EstJoueur1 = rnd.Next(2) == 0;
            partie.DateCreation = DateTime.Now;

            bool isExist = CheckExist(code);

            while (isExist)
            {
                code = RandomCode();
                isExist = CheckExist(code);
            }
            partie.CodePartie = code;
            partie.NbBatonnetsTotal = nbBatonnets;
            partie.NbBatonnetsEnCours = nbBatonnets;
            partie.EstTerminee = false;
            partie.IdJoueur1 = SessionManager.CurrentUser.IdJoueur;

            try
            {
                using (var db = new FortBoyardDjessimKilianFabienContext())
                {
                    db.Parties.Add(partie); 
                    int result = db.SaveChanges();

                    if (result > 0)
                    {
                        FrmPartie frmPartie = new FrmPartie(partie);
                        frmPartie.Show();
                        this.Close();
                    }
                        

                    else
                        MessageBox.Show("Échec de la création !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message);
            }


        }

        private string RandomCode()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 5)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            return result;
        }

        private bool CheckExist(string code)
        {
            using (FortBoyardDjessimKilianFabienContext db = new FortBoyardDjessimKilianFabienContext())
            {
                List<Partie> partieSelected = db.Parties.Where(o => o.CodePartie == code).ToList();
                if (partieSelected.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
