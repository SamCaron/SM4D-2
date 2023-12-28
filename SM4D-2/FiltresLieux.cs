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
    public partial class FiltresLieux : Form
    {
        LieuxFiltres unFiltre;
        List<DomaineValeurs> secteurs;
        List<DomaineValeurs> rues;
        public FiltresLieux(LieuxFiltres filtre)
        {
            unFiltre = filtre;
            InitializeComponent();
            InitialiserFormulaire();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAppliquer_Click(object sender, EventArgs e)
        {
            int valeurNumerique = 0;


            int.TryParse(textBoxIdValeur.Text, out valeurNumerique);
            unFiltre.Id = valeurNumerique;

            unFiltre.Texte = textBoxDescription.Text;

            unFiltre.IndicateurRecherches = comboBoxIndicateurRecherches.Text;

            // todo inclure les sujets dans la recherche par texte
            unFiltre.Secteur = ((DomaineValeurs)comboBoxSecteur.SelectedItem).Code;
            unFiltre.Rue = ((DomaineValeurs)comboBoxRue.SelectedItem).Code;
            unFiltre.DateHeureCreationDebut = dateTimePickerDateCreationDe.Value;
            unFiltre.DateHeureCreationFin = dateTimePickerDateCreationA.Value;
            unFiltre.DateHeureModificationDebut = dateTimePickerDateModificationDe.Value;
            unFiltre.DateHeureModificationFin = dateTimePickerDateModificationA.Value;

            ListeLieux liste = (ListeLieux)Application.OpenForms["ListeLieux"];
            liste.MAJFiltres(unFiltre);
            this.Close();
        }
        private void InitialiserFormulaire()
        {
            if (unFiltre.Id == 0)
            {
                textBoxIdValeur.Text = string.Empty;
            }
            else
            {
                textBoxIdValeur.Text = unFiltre.Id.ToString();
            }
            textBoxDescription.Text = unFiltre.Texte;
            // liste des secteurs avec une entree supp pour non choisie
            ConnecteurSQLCommun connecteur = new ConnecteurSQLCommun();
            secteurs = connecteur.DomainesGetDomaineByCategorie("Secteurs");
            DomaineValeurs aucun = new DomaineValeurs();
            aucun.Valeur = "- Tous -";
            secteurs.Insert(0, aucun);
            comboBoxSecteur.DataSource = secteurs;
            comboBoxSecteur.DisplayMember = "TrimValeur";
            comboBoxSecteur.SelectedItem = secteurs.Find(s => s.Code == unFiltre.Secteur);

            // liste des rues avec une entree supp pour non choisie
            rues = connecteur.DomainesGetDomaineByCategorie("Artères");
            aucun = new DomaineValeurs();
            aucun.Valeur = "- Tous -";
            rues.Insert(0, aucun);
            comboBoxRue.DataSource = rues;
            comboBoxRue.DisplayMember = "TrimValeur";
            comboBoxRue.SelectedItem = rues.Find(r => r.Code == unFiltre.Rue);

            // liste des valeurs pour Indicateur recherche
            List<string> rechs = new List<string>();
            rechs.Add("Tous");
            rechs.Add("Oui");
            rechs.Add("Non");
            comboBoxIndicateurRecherches.DataSource = rechs;
            comboBoxIndicateurRecherches.SelectedItem = unFiltre.IndicateurRecherches;

            // todo coder et traiter Etiquettes 

            if ((unFiltre.DateHeureCreationDebut > dateTimePickerDateCreationDe.MinDate) && (unFiltre.DateHeureCreationDebut < dateTimePickerDateCreationDe.MaxDate))
                dateTimePickerDateCreationDe.Value = unFiltre.DateHeureCreationDebut;
            else
                dateTimePickerDateCreationDe.Value = dateTimePickerDateCreationDe.MinDate;

            if ((unFiltre.DateHeureCreationFin > dateTimePickerDateCreationA.MinDate) && (unFiltre.DateHeureCreationFin < dateTimePickerDateCreationA.MaxDate))
                dateTimePickerDateCreationA.Value = unFiltre.DateHeureCreationFin;
            else
                dateTimePickerDateCreationA.Value = DateTime.Now;

            if ((unFiltre.DateHeureModificationDebut > dateTimePickerDateModificationDe.MinDate) && (unFiltre.DateHeureModificationDebut < dateTimePickerDateModificationDe.MaxDate))
                dateTimePickerDateModificationDe.Value = unFiltre.DateHeureModificationDebut;
            else
                dateTimePickerDateModificationDe.Value = dateTimePickerDateModificationDe.MinDate;

            if ((unFiltre.DateHeureModificationFin > dateTimePickerDateModificationA.MinDate) && (unFiltre.DateHeureModificationFin < dateTimePickerDateModificationA.MaxDate))
                dateTimePickerDateModificationA.Value = unFiltre.DateHeureModificationFin;
            else
                dateTimePickerDateModificationA.Value = DateTime.Now;

        }
    }

}
