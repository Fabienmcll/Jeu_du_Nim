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
    public partial class Inscriptioncs : Form
    {
        public Inscriptioncs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Connexion connexion = new Connexion();
            connexion.ShowDialog();
        }
    }
}
