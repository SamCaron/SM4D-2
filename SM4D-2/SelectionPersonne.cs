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
    public partial class SelectionPersonne : Form
    {
        private Personnes personneCourante;
        ConnecteurSQLPersonnes connecteur = new ConnecteurSQLPersonnes();
        private List<Personnes> personnes = new List<Personnes>();
        public SelectionPersonne()
        {
            personneCourante = new Personnes();
            InitializeComponent();
            InitialiserFormulaire();
        }
        private void InitialiserFormulaire()
        {
            labelPersonneCourante.Text = personneCourante.NomComplet;
            textBoxFiltres.Text = "";
            listBoxPersonnes.SelectionMode = SelectionMode.One;

            personnes = PersonnesFiltres(textBoxFiltres.Text);
            listBoxPersonnes.DataSource = personnes;
            listBoxPersonnes.DisplayMember = "NomComplet";
            pictureBoxPhotoProfil.Image = personneCourante.Miniature50;
        }
        private List<Personnes> PersonnesFiltres(string filtres)
        {
            return connecteur.RechercherPersonnes(filtres);
        }
        private void RafraichirFormulaire()
        {

            personnes = PersonnesFiltres(textBoxFiltres.Text);
            listBoxPersonnes.DataSource = personnes;
        }



        private void listBoxPersonnes_SelectedIndexChanged(object sender, EventArgs e)
        {
            personneCourante = (Personnes)listBoxPersonnes.SelectedItem;
            labelPersonneCourante.Text = personneCourante.NomComplet;
            pictureBoxPhotoProfil.Image = personneCourante.Miniature50;
        }
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonSelection_Click(object sender, EventArgs e)
        {
            GererMedia appelant = (GererMedia)Application.OpenForms["GererMedia"];
            appelant.MAJPersonne(personneCourante);
            this.Close();
        }
        private void listBoxPersonnes_MouseClick(object sender, MouseEventArgs e)
        {
            personneCourante = (Personnes)listBoxPersonnes.SelectedItem;
            labelPersonneCourante.Text = personneCourante.NomComplet;
            pictureBoxPhotoProfil.Image = personneCourante.Miniature50;
        }

        private void textBoxFiltres_TextChanged(object sender, EventArgs e)
        {
            personnes = PersonnesFiltres(textBoxFiltres.Text);
            listBoxPersonnes.DataSource = personnes;

        }

        private void buttonAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    /*  








    }   */
}
