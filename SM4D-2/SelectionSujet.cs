using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SM4D2Librairie.AccesDonnees;
using SM4D2Librairie.Modeles;

namespace SM4D_2
{
    public partial class SelectionSujet : Form
    {
        private Sujets sujetCourant = new Sujets();
        ConnecteurSQLCommun connecteur = new ConnecteurSQLCommun();
        private List<Sujets> listeSujets = new List<Sujets>();
        public SelectionSujet()
        {
            InitializeComponent();
            InitialiserFormulaire();
        }
        private void InitialiserFormulaire()
        {
            labelSujetCourant.Text = sujetCourant.NomSujet;
            textBoxFiltres.Text = "";
            listeSujets = SujetsFiltres(textBoxFiltres.Text);
            listBoxSujets.SelectionMode = SelectionMode.One;
            listBoxSujets.DataSource = listeSujets;
            listBoxSujets.DisplayMember = "NomSujet";
            checkBoxDetailles.Checked = false;
        }
        private List<Sujets> SujetsFiltres(string filtres)
        {
            return connecteur.RechercherSujets(filtres, checkBoxDetailles.Checked);
        }

        private void buttonSelection_Click(object sender, EventArgs e)
        {
            GererMedia appelant = (GererMedia)Application.OpenForms["GererMedia"];
            appelant.MAJSujet(sujetCourant);
            this.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBoxFiltres_TextChanged(object sender, EventArgs e)
        {
            listeSujets = SujetsFiltres(textBoxFiltres.Text);
            listBoxSujets.DataSource = listeSujets;
            listBoxSujets.DisplayMember = "NomSujet";
        }
        private void RafraichirFormulaire()
        {

            listeSujets = SujetsFiltres(textBoxFiltres.Text);
            listBoxSujets.DataSource = listeSujets;
        }
        private void listBoxSujets_SelectedIndexChanged(object sender, EventArgs e)
        {
            sujetCourant = (Sujets)listBoxSujets.SelectedItem;
            labelSujetCourant.Text = sujetCourant.NomSujet;
        }

        private void buttonAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RafraichirFormulaire();
        }
    }

}
