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
    public partial class GererCollection : Form
    {
        private bool Creation { get; } = true;
        private Collections collectionCourante;

        private List<string> messages = new List<string>();  // liste des messages d'erreurs

        /// <summary>
        /// Ouvrir l'écran de gestion d'une collection En création 
        /// </summary>
        public GererCollection()
        {
            InitializeComponent();
            Creation = true;
            collectionCourante = new Collections();

            InitialiserFormulaire();
        }

        /// <summary>
        /// Ouvrir l'écran de gestion d'une collection En modification de la collection recue en parametre, 
        /// ou en consultation selon le parametre modif
        /// </summary>
        /// <param name="uneColl"></param>
        /// <param name="modif"></param>
        public GererCollection(Collections uneColl, bool modif)
        {
            InitializeComponent();
            Creation = false;
            collectionCourante = uneColl;

            InitialiserFormulaire();
        }

        /// <summary>
        /// Initialisation du formulaire pour la gestion d'une collection
        /// </summary>
        private void InitialiserFormulaire()
        {
            if (Creation)
            {
                buttonEnregistrer.Hide();
            }
            else
            {
                buttonAjouter.Hide();

            }
            labelIdValeur.Text = collectionCourante.Id.ToString();
            textBoxNomCollection.Text = collectionCourante.NomCollection;
            textBoxContributeur.Text = collectionCourante.Contributeur;
            textBoxReponsable.Text = collectionCourante.Responsable;
            textBoxDescription.Text = collectionCourante.Notes;
            checkBoxDeployee.Checked = collectionCourante.Deployee;
            messages.Clear();

        }
        /// <summary>
        /// Rafraichit les valeurs dans l'écranc
        /// </summary>
        private void RafraichirFormulaire()
        {
            if (Creation)
            {
                buttonEnregistrer.Hide();
            }
            else
            {
                buttonAjouter.Hide();

            }
            labelIdValeur.Text = collectionCourante.Id.ToString();
            textBoxNomCollection.Text = collectionCourante.NomCollection;
            textBoxContributeur.Text = collectionCourante.Contributeur;
            textBoxReponsable.Text = collectionCourante.Responsable;
            textBoxDescription.Text = collectionCourante.Notes;
            checkBoxDeployee.Checked = collectionCourante.Deployee;


        }
        /// <summary>
        /// actions déclenchées par le bouton Ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouter_Click(object sender, EventArgs e)
        {

            bool valide = this.ValiderFormulaire();
            string chemin;
            if (valide)
            {
                this.CreerCollection(sender, e);
                // creer repertoire
                chemin = collectionCourante.CreerSousRep();
                // si répertoire existe, vérifie si contient des fichiers, et si oui, offrir d'importer la collection
                var dossier = new DirectoryInfo(chemin);
                if (dossier.GetFileSystemInfos().Length > 0)
                {
                    // il y a au moins un fichier.
                    //todo raffiner si fichiers sont importables par leur type
                    DialogResult confirmation = MessageBox.Show("Le répertoire de la collection contient des médias, souhaitez-vous les importer maintenant?", "Importation de collection", MessageBoxButtons.YesNo);
                    switch (confirmation)
                    {
                        case DialogResult.Yes:
                            //todo coder l'import
                            MessageBox.Show("L'import serait lancé ici", "Import confirmé");
                            //todo ajouter ici l'appel à l'import d'une collection
                            break;
                        case DialogResult.No:
                            MessageBox.Show("L'import ne serait pas lancé ici", "Import refusé");
                            break;
                    }

                }
                this.Close();
            }

        }

        /// <summary>
        /// Creation dans la BD de la collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreerCollection(object sender, EventArgs e)
        {

            collectionCourante.NomCollection = textBoxNomCollection.Text;
            collectionCourante.Notes = textBoxDescription.Text;
            collectionCourante.Deployee = checkBoxDeployee.Checked;
            collectionCourante.Contributeur = textBoxContributeur.Text;
            collectionCourante.Responsable = textBoxReponsable.Text;
            collectionCourante.DateHeureCreation = DateTime.Now;
            collectionCourante.DateHeureModification = DateTime.Now;
            collectionCourante.UtilisateurCreation = ConfigGlobale.UtilisateurCourant();
            collectionCourante.UtilisateurModification = ConfigGlobale.UtilisateurCourant();
            ConnecteurSQLMedias connection = new ConnecteurSQLMedias();
            bool succes = connection.CreerCollection(collectionCourante);

        }
        /// <summary>
        /// Modification dans la BD de la collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifierCollection(object sender, EventArgs e)
        {
            string source, destination;
            source = collectionCourante.SousRepComplet();
            destination = ConfigGlobale.EmplacementImages() + textBoxNomCollection.Text+"\\";
            collectionCourante.NomCollection = textBoxNomCollection.Text;
            collectionCourante.Notes = textBoxDescription.Text;
            collectionCourante.Deployee = checkBoxDeployee.Checked;
            collectionCourante.Contributeur = textBoxContributeur.Text;
            collectionCourante.Responsable = textBoxReponsable.Text;

            collectionCourante.DateHeureModification = DateTime.Now;

            collectionCourante.UtilisateurModification = ConfigGlobale.UtilisateurCourant();
            // enregistrement de la modif dans la bd
            ConnecteurSQLMedias connection = new ConnecteurSQLMedias();
            bool succes = connection.ModifierCollection(collectionCourante);
            // renommer le répertoire si le nom a changé
            if (source != destination)
            {
                Directory.Move(source, destination);
            }
            // créer le répertoire s'il n'a jamais été créé (auto-correction)
            if (!Directory.Exists(destination))
            { 
                Directory.CreateDirectory(destination);

            }
        }
        /// <summary>
        /// Valide les entrées pour une collection
        /// </summary>
        /// <returns></returns>
        private bool ValiderFormulaire()
        {
            bool valide = true;

            messages.Clear();
            int entier;
            float reel;
            // Nom obligatoire
            if (textBoxNomCollection.Text == "")
            {
                messages.Add("Vous devez entrer un nom.");
                valide = false;
            }
            else
            {
                // Collection existe déjà
                ConnecteurSQLMedias connection = new ConnecteurSQLMedias();
                if (Creation && connection.CollectionsGetByNom(textBoxNomCollection.Text) != null)
                {
                    messages.Add("Une collection existe déjà avec ce nom.");
                    valide = false;
                }
                // Répertoire existe déjà, renommer en modif impossible en modification
                if (!Creation)
                {
                    // nom a changé
                    if (textBoxNomCollection.Text != collectionCourante.NomCollection)
                    {
                        // répertoire existe déjà
                        if (Directory.Exists(ConfigGlobale.EmplacementImages() + textBoxNomCollection.Text + "\\"))
                        {
                            messages.Add("Impossible de renommer la collection " + textBoxNomCollection.Text + " , un répertoire existe déjà sous ce nom.");
                            valide = false;
                        }

                    }
                }


            }
            // Nom Responsable obligatoire
            if (textBoxReponsable.Text == "")
            {
                messages.Add("Vous devez entrer le nom du responsable de la collection.");
                valide = false;
            }
            // Description obligatoire
            if (textBoxDescription.Text == "")
            {
                messages.Add("Vous devez entrer une courte description de la collection.");
                valide = false;
            }
            // Nom valide pour un nom de dossier
            if (textBoxNomCollection.Text.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
            {
                messages.Add("Le nom de la collection contient des caractères invalides qui empêchent de créer son dossier.");
                valide = false;
            }
            // 
            if (!valide)
            {
                labelSymboleErreur.Text = "X";
            }
            else
            {
                labelSymboleErreur.Text = " ";
                messages.Add("Enregistré avec succès");
            }
            listBoxMessages.DataSource = null;
            listBoxMessages.DataSource = messages;

            return valide;
        }
        /// <summary>
        /// Enregistre les modifications de la collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            {
                bool valide = this.ValiderFormulaire();
                if (valide)
                {
                    this.ModifierCollection(sender, e);
                    this.Close();
                }

            }
        }
        /// <summary>
        /// Annule et ferme l'ecran
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
