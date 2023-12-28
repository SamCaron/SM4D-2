using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SM4D2Librairie;
using SM4D2Librairie.AccesDonnees;
using SM4D2Librairie.Modeles;

namespace SM4D_2
{
    public partial class GererDomaineValeurs : Form
    {
        private List<string> listeCategories;
        private List<DomaineValeurs> domaines;
        public GererDomaineValeurs()
        {
            InitializeComponent();
            InitialiserFormulaire();
            InitialiserValeurs();
        }
        private void InitialiserFormulaire()
        {
            listBoxDomaineValeurs.DisplayMember = "CodeValeur";
            this.Cursor = Cursors.Arrow;
        }

        private void UpdateListes()
        {

        }

        private bool ValiderFormulaire()
        {
            bool valide = true;

            return valide;
        }

        private void buttonAjouterRester_Click(object sender, EventArgs e)
        {
            ConnecteurSQLCommun connection = new ConnecteurSQLCommun();

            if (connection.CodeValeurExiste(((string)(comboBoxDomaine.SelectedItem)), textBoxCode.Text))
            {
                connection.DomaineModifier(((string)(comboBoxDomaine.SelectedItem)), textBoxCode.Text.Trim(), textBoxValeur.Text.Trim());
            }
            else
            {
                connection.DomaineCreer(((string)(comboBoxDomaine.SelectedItem)), textBoxCode.Text.Trim(), textBoxValeur.Text.Trim());
            }
            RafraichirFormulaire();
        }

        private void buttonSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            // todo ajouter validation pour empecher la suppression si valeur deja utilisee

            DialogResult confirmation = MessageBox.Show("Souhaitez-vous vraiment supprimer la valeur sélectionnée?", "Suppression", MessageBoxButtons.YesNo);
            ConnecteurSQLCommun connection = new ConnecteurSQLCommun();
            DomaineValeurs valeur;
            switch (confirmation)
            {
                case DialogResult.Yes:
                    // suppression
                    valeur = (DomaineValeurs)(listBoxDomaineValeurs.SelectedItem);
                    connection.DomaineSupprimer((string)(comboBoxDomaine.SelectedItem), textBoxCode.Text);
                    break;
                case DialogResult.No:
                    // rien
                    break;
                default:
                    break;
            }
            RafraichirFormulaire();
        }
        private void InitialiserValeurs()
        {
            ConnecteurSQLCommun connection = new ConnecteurSQLCommun();

            listeCategories = connection.DomainesGetAllCategories();


            comboBoxDomaine.DataSource = listeCategories;
            comboBoxDomaine.SelectedIndex = 0;
            domaines = connection.DomainesGetDomaineByCategorie(((string)comboBoxDomaine.SelectedItem));
            listBoxDomaineValeurs.DataSource = domaines;
        }
        private void RafraichirFormulaire()
        {
            ConnecteurSQLCommun connection = new ConnecteurSQLCommun();



            domaines = connection.DomainesGetDomaineByCategorie(((string)comboBoxDomaine.SelectedItem));
            listBoxDomaineValeurs.DataSource = domaines;
        }

        private void comboBoxDomaine_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
            textBoxValeur.Text = "";
            RafraichirFormulaire();
        }

        private void listBoxDomaineValeurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCode.Text = ((DomaineValeurs)listBoxDomaineValeurs.SelectedItem).Code;
            textBoxValeur.Text = ((DomaineValeurs)listBoxDomaineValeurs.SelectedItem).Valeur;
        }

        private void linkLabelQuitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        /*  methodes d'écrans
*  private bool ValiderFormulaire()
*  private void InitialiserValeursModification()
*  private void InitialiserValeursCreation()
*  private void InitialiserFormulaire()
*  private void UpdateListes()
*  */
    }
}

