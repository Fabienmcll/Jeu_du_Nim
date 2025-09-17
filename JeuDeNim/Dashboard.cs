using JeuDeNim.Class;
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
    }
}
