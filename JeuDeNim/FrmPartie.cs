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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDeNim
{
    public partial class FrmPartie : Form
    {
        public FrmPartie(Partie partie)
        {
            InitializeComponent();

            lblCode.Text = partie.CodePartie;
            loadParticipants();
        }

        private void loadParticipants()
        {
            lbJoueurs.Items.Clear();
            using (var db = new FortBoyardDjessimKilianFabienContext())
            {
                var partie = db.Parties.Where(o => o.IdJoueur1 == SessionManager.CurrentUser.IdJoueur)
                               .Include(p => p.IdJoueur1Navigation)
                               .FirstOrDefault();

                if (partie != null)
                {
                    Utilisateur user1 = partie.IdJoueur1Navigation;
                    lbJoueurs.Items.Add(user1.Pseudo);
                }
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
