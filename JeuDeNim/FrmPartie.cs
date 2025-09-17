using JeuDeNim.Class;
using JeuDeNim.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JeuDeNim
{
    public partial class FrmPartie : Form
    {
        private System.Windows.Forms.Timer timer;
        Partie partieEnCours;
        public FrmPartie(Partie partie)
        {
            InitializeComponent();

            partieEnCours = partie;

            lblCode.Text = partie.CodePartie;
            loadParticipants(partie);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000; // 5 secondes
            timer.Tick += Timer_Tick;
            timer.Start();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            loadParticipants(partieEnCours);
        }

        private void loadParticipants(Partie searchPartie)
        {
            lbJoueurs.Items.Clear();
            using (var db = new FortBoyardDjessimKilianFabienContext())
            {
                var partie = db.Parties
                   .Include(p => p.IdJoueur1Navigation)
                   .Include(p => p.IdJoueur2Navigation)
                   .FirstOrDefault(o => o.CodePartie == searchPartie.CodePartie);


                if (partie != null)
                {
                    Utilisateur user1 = partie.IdJoueur1Navigation;
                    Utilisateur user2 = partie.IdJoueur2Navigation;
                    if (user1 != null) lbJoueurs.Items.Add(user1.Pseudo);
                    if (user2 != null) lbJoueurs.Items.Add(user2.Pseudo);
                }
            }

        }
        private void timerJoueur_Tick(object sender, EventArgs e)
        {
            loadParticipants(partieEnCours);
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click_1(object sender, EventArgs e)
        {
            Dashboard frmDashboard = new Dashboard();
            frmDashboard.Show();
            this.Close();

        }
    }
}
