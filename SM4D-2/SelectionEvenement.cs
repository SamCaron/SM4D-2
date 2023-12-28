using SM4D2Librairie.AccesDonnees;
using SM4D2Librairie.Modeles;
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
    public partial class SelectionEvenement : Form
    {
        private Evenements evenCourant;
        ConnecteurSQLEvenements connecteur = new ConnecteurSQLEvenements();
        private List<Evenements> evenementsFiltres = new List<Evenements>();
        public SelectionEvenement(Evenements unEven)
        {
            InitializeComponent();
            if (unEven == null)
            {
                evenCourant = new Evenements();
            }
            else
            {
                evenCourant = unEven;
            }
            InitialiserFormulaire();
        }

        private void InitialiserFormulaire()
        {
            labelEvenementCourant.Text = evenCourant.NomEvenement ;
            textBoxFiltres.Text = "";
            listBoxEvenements.SelectionMode = SelectionMode.One;

            evenementsFiltres = EvenementsFiltres(textBoxFiltres.Text);
            listBoxEvenements.DataSource = evenementsFiltres;
            listBoxEvenements.DisplayMember = "NomEvenement";
        }
        private List<Evenements> EvenementsFiltres(string filtres)
        {
            List<Evenements> liste;
            Evenements aucun = new Evenements();
            aucun.NomEvenement = "-Aucun/Inconnu-";
            aucun.Id = 0;
            liste = connecteur.RechercherEvenements(filtres);
            liste.Insert(0, aucun);
            return liste;
        }
        private void RafraichirFormulaire()
        {

            evenementsFiltres = EvenementsFiltres(textBoxFiltres.Text);
            listBoxEvenements.DataSource = evenementsFiltres;
        }
        private void buttonSelection_Click(object sender, EventArgs e)
        {
            GererMedia appelant = (GererMedia)Application.OpenForms["GererMedia"];
            appelant.MAJEven(evenCourant);
            this.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxEvenements_MouseClick(object sender, MouseEventArgs e)
        {
            evenCourant = (Evenements)listBoxEvenements.SelectedItem;
            labelEvenementCourant.Text = evenCourant.NomEvenement;
        }

        private void textBoxFiltres_TextChanged(object sender, EventArgs e)
        {
            evenementsFiltres = EvenementsFiltres(textBoxFiltres.Text);
            listBoxEvenements.DataSource = evenementsFiltres;

        }
    }

}
