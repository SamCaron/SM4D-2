using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM4D_2
{
    public partial class FenetreConnexion : Form
    {
        public string nom, prenom, details = "";
        public bool estIdentifie = false;
        public FenetreConnexion()
        {
            InitializeComponent();
        }

        private void Enregistrer()
        {
            txtbPrenom.Enabled = false;
            txtbNom.Enabled = false;
            txtbDetails.Enabled = false;

            prenom = txtbPrenom.Text;
            nom = txtbNom.Text;
            details = txtbDetails.Text;

            this.estIdentifie = true;
        }
        private void Recommencer()
        {
            txtbPrenom.Enabled = true;
            txtbNom.Enabled = true;
            txtbDetails.Enabled = true;

            txtbPrenom.Text = "";
            txtbNom.Text = "";
            txtbDetails.Text = "";

            this.estIdentifie = false;
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Enregistrer();
        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            Recommencer();
        }
    }
}
