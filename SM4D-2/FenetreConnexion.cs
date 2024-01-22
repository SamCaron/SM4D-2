using SM4D2;
using SM4D2Librairie;
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

            Connexion.setConnexion(prenom, nom, details);

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

            Connexion.resetConnexion();

            this.estIdentifie = false;
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Enregistrer();
                MessageBox.Show("Connecté en tant que: " + Connexion.Prenom + " " + Connexion.Nom
                    + "\n Changer de menu pour que le changement s'applique.");
                errorProvider1.Clear();
            }
        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            Recommencer();
        }

        private void FenetreConnexion_Load(object sender, EventArgs e)
        {

        }

        private void txtbPrenom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbPrenom.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbPrenom, "Ce champ ne peut être vide.");
            }
        }

        private void txtbNom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbNom.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbNom, "Ce champ ne peut être vide.");
            }
        }


    }
}
