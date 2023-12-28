using SM4D2Librairie.AccesDonnees;
using SM4D2Librairie.Modeles;
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

    public partial class SelectionLieu : Form
    {

        private Lieux lieuCourant = new Lieux();
        ConnecteurSQLLieux connecteur = new ConnecteurSQLLieux();
        private List<Lieux> listeLieuxFiltres = new List<Lieux>();
        public SelectionLieu(Lieux lieuChoisi)
        {
            InitializeComponent();
            if (lieuChoisi != null)
            {
                lieuCourant = lieuChoisi;
            }
            else
            {
                lieuCourant = new Lieux();
            }
            InitialiserFormulaire();
        }
        private void InitialiserFormulaire()
        {
            labelLieuCourant.Text = lieuCourant.AdresseComplete;
            textBoxFiltres.Text = "";
            listeLieuxFiltres = LieuxFiltres(textBoxFiltres.Text);
            listBoxLieux.SelectionMode = SelectionMode.One;
            listBoxLieux.DataSource = listeLieuxFiltres;
            listBoxLieux.DisplayMember = "AdresseComplete";
        }
        private void RafraichirFormulaire()
        {

            listBoxLieux.DataSource = listeLieuxFiltres;
            listBoxLieux.DisplayMember = "AdresseComplete";
            labelLieuCourant.Text = lieuCourant.AdresseComplete;
        }
        private List<Lieux> LieuxFiltres(string filtres)
        {
            List<Lieux> liste;
            Lieux aucun = new Lieux();
            aucun.AdresseComplete = "-Aucun/Inconnu-";
            aucun.Id = 0;
            liste = connecteur.RechercherLieux(filtres);
            liste.Insert(0, aucun);
            return liste;
        }
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxLieux_SelectedIndexChanged(object sender, EventArgs e)
        {
            lieuCourant = (Lieux)listBoxLieux.SelectedItem;
            RafraichirFormulaire();
        }

        private void buttonSelection_Click(object sender, EventArgs e)
        {
            GererMedia appelant = (GererMedia)Application.OpenForms["GererMedia"];
            appelant.MAJLieu(lieuCourant);
            this.Close();
        }

        private void textBoxFiltres_TextChanged(object sender, EventArgs e)
        {

            listeLieuxFiltres = LieuxFiltres(textBoxFiltres.Text);
            RafraichirFormulaire();

        }

        private void listBoxLieux_SelectedIndexChanged(object sender, MouseEventArgs e)
        {
            lieuCourant = (Lieux)listBoxLieux.SelectedItem;
            RafraichirFormulaire();

        }
    }
}
