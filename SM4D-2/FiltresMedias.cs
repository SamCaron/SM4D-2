using SM4D2Librairie;
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
    public partial class FiltresMedias : Form
    {
        private List<string> messages = new List<string>();
        private MediasFiltres MediasFiltres = new MediasFiltres();
        private List<Collections> listeCollections = ConfigGlobale.Connection.GetCollections(false);
        public FiltresMedias()
        {
            InitializeComponent();
        }
        public FiltresMedias(MediasFiltres mediasFiltres)
        {
            MediasFiltres = mediasFiltres;

            InitializeComponent();
            InitialiserFormulaire();

        }
        private void InitialiserFormulaire()
        {
            if (MediasFiltres.Id == 0)
            {
                textBoxIdValeur.Text = string.Empty;
            }
            else
            {
                textBoxIdValeur.Text = MediasFiltres.Id.ToString();
            }

            // liste des collections avec une entree supp pour non choisie
            Collections aucune = new Collections();
            aucune.NomCollection = "- Toutes -";
            listeCollections.Insert(0, aucune);
            comboBoxCollectionValeur.DataSource = listeCollections;
            comboBoxCollectionValeur.DisplayMember = "NomCollection";

            // liste des valeurs pour Indicateur recherche
            List<string> rechs = new List<string>();
            rechs.Add("Tous");
            rechs.Add("Oui");
            rechs.Add("Non");
            comboBoxIndicateurRecherches.DataSource = rechs;
            comboBoxIndicateurRecherches.SelectedItem = MediasFiltres.IndicateurRecherches;


            comboBoxCollectionValeur.SelectedItem = listeCollections.Find(x => x.Id == MediasFiltres.IdCollection);
            textBoxDescription.Text = MediasFiltres.Description;

            // todo coder et traiter filtres de Lieux et Evenements
            // todo coder et traiter Etiquettes et Presences
            if ((MediasFiltres.DatePriseDebut > dateTimePickerDe.MinDate) && (MediasFiltres.DatePriseDebut < dateTimePickerDe.MaxDate))
                dateTimePickerDe.Value = MediasFiltres.DatePriseDebut;
            if ((MediasFiltres.DatePriseFin > dateTimePickerDe.MinDate) && (MediasFiltres.DatePriseFin < dateTimePickerDe.MaxDate))
                dateTimePickerA.Value = MediasFiltres.DatePriseFin;
            else
                dateTimePickerA.Value = DateTime.Now;
            if ((MediasFiltres.DateHeureCreationDebut > dateTimePickerDe.MinDate) && (MediasFiltres.DateHeureCreationDebut < dateTimePickerDe.MaxDate))
                dateTimePickerDateCreationDe.Value = MediasFiltres.DateHeureCreationDebut;
            if ((MediasFiltres.DateHeureCreationFin > dateTimePickerDe.MinDate) && (MediasFiltres.DateHeureCreationFin < dateTimePickerDe.MaxDate))
                dateTimePickerDateCreationA.Value = MediasFiltres.DateHeureCreationFin;
            else
                dateTimePickerDateCreationA.Value = DateTime.Now;
            if ((MediasFiltres.DateHeureModificationDebut > dateTimePickerDe.MinDate) && (MediasFiltres.DateHeureModificationDebut < dateTimePickerDe.MaxDate))
                dateTimePickerDateModificationDe.Value = MediasFiltres.DateHeureModificationDebut;
            if ((MediasFiltres.DateHeureModificationFin > dateTimePickerDe.MinDate) && (MediasFiltres.DateHeureModificationFin < dateTimePickerDe.MaxDate))
                dateTimePickerDateModificationA.Value = MediasFiltres.DateHeureModificationFin;
            else
                dateTimePickerDateModificationA.Value = DateTime.Now;
            // coder le service sql et la store proc pour l'applciation des filtres.
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxCollectionValeur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValiderFormulaire()
        {
            bool valide = true;
            int Id = 0;
            messages = new List<string>();
            // Id numerique
            if ((textBoxIdValeur.Text != "") && (!(int.TryParse(textBoxIdValeur.Text, out Id))))
            {
                messages.Add("L'Identifiant (Id) doit être un nombre valide");
                valide = false;
            }
            // Date de fin Prise doit être supérieure à date de début

            if (dateTimePickerA.Value < dateTimePickerDe.Value)
            {
                messages.Add("La date de fin de Prise doit être supérieure ou égale à la date de début");
                valide = false;
            }
            if (dateTimePickerDateCreationA.Value < dateTimePickerDateCreationDe.Value)
            {
                messages.Add("La date de fin de Création doit être supérieure ou égale à la date de début");
                valide = false;
            }
            if (dateTimePickerDateModificationA.Value < dateTimePickerDateModificationDe.Value)
            {
                messages.Add("La date de fin de Modifcation doit être supérieure ou égale à la date de début");
                valide = false;
            }


            if (!valide)
            {
                labelSymboleErreur.Text = "X";
            }
            else
            {
                labelSymboleErreur.Text = " ";
                messages.Add("Enregistré avec succès");
            }

            this.listBoxMessages.DataSource = messages;
            return valide;
        }

        private void buttonAppliquer_Click(object sender, EventArgs e)
        {
            int valeurNumerique = 0;
            if (this.ValiderFormulaire())
            {
                int.TryParse(textBoxIdValeur.Text, out valeurNumerique);
                MediasFiltres.Id = valeurNumerique;

                MediasFiltres.IdCollection = ((Collections)(comboBoxCollectionValeur.SelectedItem)).Id;
                MediasFiltres.Description = textBoxDescription.Text;
                MediasFiltres.IndicateurRecherches = comboBoxIndicateurRecherches.Text;
                // todo coder et traiter filtres de Lieux et Evenements
                MediasFiltres.DatePriseDebut = dateTimePickerDe.Value;
                MediasFiltres.DatePriseFin = dateTimePickerA.Value;

                MediasFiltres.DateHeureCreationDebut = dateTimePickerDateCreationDe.Value;
                MediasFiltres.DateHeureCreationFin = dateTimePickerDateCreationA.Value;
                MediasFiltres.DateHeureModificationDebut = dateTimePickerDateModificationDe.Value;
                MediasFiltres.DateHeureModificationFin = dateTimePickerDateModificationA.Value;
                ListeMedias liste = (ListeMedias)Application.OpenForms["ListeMedias"];
                liste.MAJFiltres(MediasFiltres);
                this.Close();
            }
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
