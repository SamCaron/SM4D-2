using SM4D2Librairie;
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
    public partial class GererLieu : Form
    {
        private bool Creation { get; } = true;
        private Lieux lieuCourant;
        private List<DomaineValeurs> secteurs;
        string codeSecteur = "Autre";
        private List<DomaineValeurs> arteres;
        private List<string> messages;


        public GererLieu()
        {
            Creation = true;
            lieuCourant = new Lieux();
            InitializeComponent();
            InitialiserFormulaire();

        }
        // en modification
        public GererLieu(Lieux unLieu)
        {
            Creation = false;
            lieuCourant = unLieu;
            InitializeComponent();
            InitialiserFormulaire();

        }
        private void InitialiserFormulaire()
        {


            if (Creation)
            {
                buttonEnregistrer.Hide();
            }
            else
            {
                buttonAjouterRester.Hide();
                buttonAjouterSortir.Hide();
            }
            labelIdValeur.Text = lieuCourant.Id.ToString();

            ConnecteurSQLCommun connection = new ConnecteurSQLCommun();
            secteurs = connection.DomainesGetDomaineByCategorie("Secteurs");

            arteres = connection.DomainesGetDomaineByCategorie("Artères");
            arteres.Insert(0, new DomaineValeurs("Artères", "", "<Choisir rue>"));
            comboBoxArtere.DisplayMember = "TrimValeur";
            comboBoxArtere.DataSource = arteres;
            comboBoxArtere.SelectedItem = arteres.Find(a => a.Code.TrimEnd() == lieuCourant.CodeRue.TrimEnd());


            textBoxNoCivique.Text = lieuCourant.NoCivique.ToString();

            textBoxAppValeur.Text = lieuCourant.AppSuite;

            textBoxDescription.Text = lieuCourant.Description;

            textBoxDescriptionAilleurs.Text = lieuCourant.DescriptionAilleurs;

            if (lieuCourant.AnneeConstruction == 0)
                textBoxAnneeConstructionValeur.Text = "";
            else
                textBoxAnneeConstructionValeur.Text = lieuCourant.AnneeConstruction.ToString();

            textBoxLongitudeValeur.Text = lieuCourant.Longitude.ToString();

            textBoxLatitudeValeur.Text = lieuCourant.Latitude.ToString();

            checkBoxAnalyseRequise.Checked = lieuCourant.IndicateurRecherches;

            textBoxDescriptionRecherches.Text = lieuCourant.NotesRecherches;

            dateTimePickerCreation.Value = lieuCourant.DateHeureCreation;

            dateTimePickerModification.Value = lieuCourant.DateHeureModification;

            labelUtilisateurCreationValeur.Text = lieuCourant.UtilisateurCreation.Login;

            labelUtilisateurModificationValeur.Text = lieuCourant.UtilisateurModification.Login;

            labelAdresseComplete.Text = concatenerAdresse();

            pictureBoxMiniature256.Image = lieuCourant.Miniature150;
            RafraichirFormulaire();
        }

        private void RafraichirFormulaire()
        {
            DomaineValeurs artere = (DomaineValeurs)comboBoxArtere.SelectedItem;
            ConnecteurSQLCommun connecteur = new ConnecteurSQLCommun();
            codeSecteur = "Autre";
            int noCiv = 0;
            Int32.TryParse(textBoxNoCivique.Text, out noCiv);
            textBoxDescriptionAilleurs.Enabled = false;

            switch (artere.Code.TrimEnd())
            {
                case "285 Nord":
                    if (noCiv > 16 && noCiv <= 400)
                        codeSecteur = "Route";
                    if (noCiv <= 16)
                        codeSecteur = "Village";
                    if (noCiv > 400)
                        codeSecteur = "BrasApic";
                    break;
                case "285 Sud":
                    codeSecteur = "Village";
                    break;
                case "Autre":
                    codeSecteur = "Autre";
                    textBoxDescriptionAilleurs.Enabled = true;

                    break;
                case "Belanger":
                    codeSecteur = "Bélanger";
                    break;
                case "Couillards":
                    codeSecteur = "Côte";
                    break;
                case "Ecole":
                    codeSecteur = "Village";
                    break;
                case "FontClaire":
                    codeSecteur = "LacFC";
                    break;
                case "Loisirs":
                    codeSecteur = "Village";
                    break;
                case "Madril":
                    codeSecteur = "Madril";
                    break;
                case "Mercier":
                    codeSecteur = "LacFC";
                    break;
                case "LacApic":
                    codeSecteur = "LacApic";
                    break;
                case "Rang4":
                    codeSecteur = "Rang4";
                    break;
                case "Rang7Est":
                    codeSecteur = "Rang7";
                    break;
                case "Rang7Ouest":
                    codeSecteur = "Rang7";
                    break;
                case "Ratsoul":
                    codeSecteur = "Rang7";
                    break;
                case "TacheEst":
                    if (noCiv <= 89)
                        codeSecteur = "Village";
                    if (noCiv > 89 && noCiv < 242)
                        codeSecteur = "Côte";
                    if (noCiv >= 242)
                        codeSecteur = "Nordet";
                    break;
                case "TacheOuest":
                    if (noCiv < 40)
                        codeSecteur = "Village";
                    else
                        codeSecteur = "Suroît";
                    break;
                default:
                    codeSecteur = "Autre";
                    textBoxDescriptionAilleurs.Enabled = true;
                    break;

            }
            labelSecteurValeur.Text = connecteur.GetCodeValeur("Secteurs", codeSecteur).Valeur;
            labelAdresseComplete.Text = concatenerAdresse();
            //   lieuCourant.CalculerLongLat();

        }
        // todo Developper le selecteur d'images
        // todo Developper un selecteur de sujets

        private bool ValiderFormulaire()
        {
            bool valide = true;
            bool val2 = true;
            messages = new List<string>();
            int entier;
            float reel;
            // Artere obligatoire
            if (comboBoxArtere.SelectedIndex == 0)
            {
                messages.Add("Vous devez choisir une artère. (Utiliser Ailleurs pour des lieux hors-St-Marcel)");
                valide = false;
            }
            // Description recheches obligatoire si analyse cochee
            if ((checkBoxAnalyseRequise.Checked) && (textBoxDescriptionRecherches.Text.Length == 0))
            {
                messages.Add("Si l'Analyse est requise, décrire sommairement celle-ci");
                valide = false;
            }
            // le numero civique doit être numérique
            val2 = Int32.TryParse(textBoxNoCivique.Text, out entier);
            if (!val2)
            {
                messages.Add("Le numéro civique doit être un entier");
                valide = false;
            }
            // l'annee doit être numérique 
            val2 = Int32.TryParse(textBoxAnneeConstructionValeur.Text, out entier);
            if (!val2 && textBoxAnneeConstructionValeur.Text != "")
            {
                messages.Add("L'année de construction doit être un entier. Laisser à blanc si inconnu.");
                valide = false;
            }
            // la latitude  doit être numérique et dans les bornes
            val2 = float.TryParse(textBoxLatitudeValeur.Text, out reel);
            if ((!val2) || (reel < -90) || (reel > 90))
            {
                messages.Add("La latitude doit être un nombre entre -90 et 90");
                valide = false;
            }
            // la longitude  doit être numérique et dans les bornes
            val2 = float.TryParse(textBoxLongitudeValeur.Text, out reel);
            if ((!val2) || (reel < -180) || (reel > 180))
            {
                messages.Add("La longitude doit être un nombre entre -180 et 180");
                valide = false;
            }
            // l'annee doit être valide (futur)
            val2 = Int32.TryParse(textBoxAnneeConstructionValeur.Text, out entier);
            if (entier > DateTime.Now.Year)
            {
                messages.Add("L'année de construction ne peut être dans le futur");
                valide = false;
            }
            // l'annee doit être valide (passé)
            val2 = Int32.TryParse(textBoxAnneeConstructionValeur.Text, out entier);
            if (entier != 0 && entier < 1850)
            {
                messages.Add("L'année de construction ne peut être antérieure à la colonisation");
                valide = false;
            }
            // Description Ailleurs obligatoire si Ailleurs choisi
            if ((((DomaineValeurs)comboBoxArtere.SelectedItem).Code.TrimEnd() == "Autre")
                && (textBoxDescriptionAilleurs.Text.Length == 0))
            {
                messages.Add("Si l'adresse est Ailleurs, décrire sommairement la localisation");
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

        private void buttonSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelLatitude_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLatitudeValeur_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLongitude_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxArtere_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RafraichirFormulaire();
        }

        private void buttonAjouterRester_Click(object sender, EventArgs e)
        {
            bool valide = this.ValiderFormulaire();
            if (valide)
            {
                this.CreerLieu(sender, e);
                this.RafraichirFormulaire();
            }
        }

        private void buttonAjouterSortir_Click(object sender, EventArgs e)
        {
            {
                bool valide = this.ValiderFormulaire();
                if (valide)
                {
                    this.CreerLieu(sender, e);
                }
                this.Close();
            }
        }
        private void CreerLieu(object sender, EventArgs e)
        {
            //     lieuCourant.Id = labelIdValeur.Text ;
            int entier;
            decimal reel;

            ConnecteurSQLLieux connection = new ConnecteurSQLLieux();

            lieuCourant.CodeRue = ((DomaineValeurs)comboBoxArtere.SelectedItem).Code;
            lieuCourant.CodeSecteur = codeSecteur;

            Int32.TryParse(textBoxNoCivique.Text, out entier);
            lieuCourant.NoCivique = entier;

            lieuCourant.AppSuite = textBoxAppValeur.Text;

            lieuCourant.Description = textBoxDescription.Text;

            lieuCourant.DescriptionAilleurs = textBoxDescriptionAilleurs.Text;

            Int32.TryParse(textBoxAnneeConstructionValeur.Text, out entier);
            lieuCourant.AnneeConstruction = entier;

            decimal.TryParse(textBoxLongitudeValeur.Text, out reel);
            lieuCourant.Longitude = reel;

            decimal.TryParse(textBoxLatitudeValeur.Text, out reel);
            lieuCourant.Latitude = reel;

            lieuCourant.IndicateurRecherches = checkBoxAnalyseRequise.Checked;

            lieuCourant.NotesRecherches = textBoxDescriptionRecherches.Text;

            lieuCourant.DateHeureCreation = DateTime.Now;

            lieuCourant.DateHeureModification = DateTime.Now;

            lieuCourant.UtilisateurCreation.Login = ConfigGlobale.UtilisateurCourant().Login;

            lieuCourant.UtilisateurModification.Login = ConfigGlobale.UtilisateurCourant().Login;
            lieuCourant.AdresseComplete = labelAdresseComplete.Text;
            lieuCourant = connection.CreerLieu(lieuCourant);


            // todo  pictureBoxMiniature256.Image = lieuCourant.Miniature;
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            bool valide = this.ValiderFormulaire();
            int entier = 0;
            decimal reel = 0;
            if (valide)
            {
                ConnecteurSQLLieux connecteur = new ConnecteurSQLLieux();
                lieuCourant.CodeRue = ((DomaineValeurs)comboBoxArtere.SelectedItem).Code;
                lieuCourant.CodeSecteur = codeSecteur;

                Int32.TryParse(textBoxNoCivique.Text, out entier);
                lieuCourant.NoCivique = entier;

                lieuCourant.AppSuite = textBoxAppValeur.Text;

                lieuCourant.Description = textBoxDescription.Text;

                lieuCourant.DescriptionAilleurs = textBoxDescriptionAilleurs.Text;

                Int32.TryParse(textBoxAnneeConstructionValeur.Text, out entier);
                lieuCourant.AnneeConstruction = entier;

                decimal.TryParse(textBoxLongitudeValeur.Text, out reel);
                lieuCourant.Longitude = reel;

                decimal.TryParse(textBoxLatitudeValeur.Text, out reel);
                lieuCourant.Latitude = reel;

                lieuCourant.IndicateurRecherches = checkBoxAnalyseRequise.Checked;

                lieuCourant.NotesRecherches = textBoxDescriptionRecherches.Text;



                lieuCourant.DateHeureModification = DateTime.Now;



                lieuCourant.UtilisateurModification.Login = ConfigGlobale.UtilisateurCourant().Login;
                lieuCourant.AdresseComplete = labelAdresseComplete.Text;

                // todo  pictureBoxMiniature256.Image = lieuCourant.Miniature;

                connecteur.ModifierLieu(lieuCourant);
                this.Close();
            }
        }
        // retourne l'adresse complete concatenee
        private string concatenerAdresse()
        {
            string adresseComplete = "";
            string rue = "";
            string municipalite = ", St-Marcel, G0R3R0";
            ConnecteurSQLLieux connecteur = new ConnecteurSQLLieux();

            adresseComplete = textBoxNoCivique.Text;
            if (textBoxAppValeur.Text.Length > 0)
            {
                adresseComplete += (" " + textBoxAppValeur.Text);
            }
            rue = ((DomaineValeurs)comboBoxArtere.SelectedItem).Valeur.TrimEnd();
            adresseComplete += ", " + rue + municipalite;
            return adresseComplete;
        }

        private void linkLabelQuitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        public void MAJMedia(Medias media)
        {
            if (media.Id == 0)
            {
                lieuCourant.PhotoLieu = null;
                lieuCourant.IdPhotoLieu = 0;
                pictureBoxMiniature256.Image = ConfigGlobale.ImageNonDisponible();
            }
            else
            {
                lieuCourant.PhotoLieu = media;
                lieuCourant.IdPhotoLieu = media.Id;
                pictureBoxMiniature256.Image = lieuCourant.Miniature150;
            }

        }

        private void buttonChoisirFichier_Click(object sender, EventArgs e)
        {
            SelectionMedia ecran = new SelectionMedia(lieuCourant.PhotoLieu, "GererLieu");
            ecran.ShowDialog();
            RafraichirFormulaire();
        }
    }
}
