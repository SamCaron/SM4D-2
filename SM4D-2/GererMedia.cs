using SM4D2Librairie;
using SM4D2Librairie.AccesDonnees;
using SM4D2Librairie.Modeles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SM4D_2
{
    public partial class GererMedia : Form

    {
        private Medias mediaCourant = new Medias();
        Medias mediaMetas = new Medias();
        private ConnecteurSQLMedias connection = new ConnecteurSQLMedias();
        private bool Creation { get; } = true;
        private List<string> messages = new List<string>();
        private List<Collections> listeCollections = ConfigGlobale.Connection.GetCollections(false);
        private List<Lieux> listeLieuPrise;
        private List<Presences> listePersonnesIdentifiees = new List<Presences>();
        private List<Etiquettes> listeSujetsApplicables = new List<Etiquettes>();
        private Collections collectionChoisie { get; set; }
        private Lieux lieuUI;
        private Evenements evenementUI;
        private System.Windows.Forms.OpenFileDialog openFileDialogFichierMedia = new OpenFileDialog();
        private string nomFichierCourt = "";
        // Ouverture de l'écran pour gérer un media en mode création
        public GererMedia()
        {
            InitializeComponent();

            Creation = true;
            InitialiserFormulaire();
            InitialiserValeursCreation();
        }
        // Ouverture de l'écran pour gérer un media en mode modification/consultation
        public GererMedia(Medias unMedia)
        {
            mediaCourant = unMedia;
            InitializeComponent();
            Creation = false;
            InitialiserFormulaire();
            InitialiserValeursModification();
        }
        // initialiser le formulaire pour une creation de media, lors de l'ouverture de la fenetre
        private void InitialiserFormulaire()
        {



            //  selection de fichiers images
            openFileDialogFichierMedia.InitialDirectory = ConfigGlobale.CheminImages;
            openFileDialogFichierMedia.Title = "Choisir le fichier Média";
            openFileDialogFichierMedia.CheckFileExists = true;
            openFileDialogFichierMedia.CheckPathExists = true;
            openFileDialogFichierMedia.DefaultExt = "JPG";
            openFileDialogFichierMedia.Filter =
                "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                "All files (*.*)|*.*";
            openFileDialogFichierMedia.FilterIndex = 2;
            openFileDialogFichierMedia.RestoreDirectory = true;
            openFileDialogFichierMedia.ReadOnlyChecked = true;
            openFileDialogFichierMedia.ShowReadOnly = true;
            labelNomFichierSM4DValeur.Hide();
            UpdateListes();
        }
        private void InitialiserValeursCreation()
        {
            // liste des collections avec une entree supp pour non choisie
            Collections aucune = new Collections();
            aucune.NomCollection = "- Choisir -";
            listeCollections.Insert(0, aucune);
            comboBoxCollection.DataSource = listeCollections;
            comboBoxCollection.DisplayMember = "NomCollection";


            // format de boutons et dates
            buttonEnregistrer.Hide();
            UpdateListes();

            // types media et fichier
            labelTypeFichierValeur.Text = "";
            labelTypeMediaValeur.Text = "";

            // utilisateur courant
            labelParCreationValeur.Text = ConfigGlobale.UtilisateurCourant().Login;
            labelParModificationValeur.Text = ConfigGlobale.UtilisateurCourant().Login;

            // Dates et date de prise max à date du jour
            labelDateCreation.Text = DateTime.Now.ToShortDateString();
            labelDateModification.Text = DateTime.Now.ToShortDateString();
            dateTimePickerDatePrise.Value = ConfigGlobale.DatePriseDefaut;

            // utilisateur courant
            labelParCreationValeur.Text = ConfigGlobale.UtilisateurCourant().Login;
            labelParModificationValeur.Text = ConfigGlobale.UtilisateurCourant().Login;

            // Dates et date de prise max à date du jour

            dateTimePickerDatePrise.MaxDate = DateTime.Now;
            dateTimePickerDatePrise.Value = ConfigGlobale.DatePriseDefaut;

            listBoxPresences.DataSource = mediaCourant.Presences;
            listBoxPresences.DisplayMember = "Personne.NomComplet";

            listBoxSujets.DataSource = listeSujetsApplicables;
            listBoxSujets.DisplayMember = "NomSujet";
           
        }
        // Blanchir le formulaire pour une creation de media supplementaires [Ajouter et Continuer]
        private void RafraichirFormulaire()
        {
            // reinitialiser les champs lies au fichier media à vide
            openFileDialogFichierMedia.FileName = String.Empty;
            nomFichierCourt = "";
            pictureBoxMiniature128.Image = null;

            // todo brancher le type de media avec le domaine de valeur

            // Valeurs des champs
            labelFichierOriginalValeur.Text = "";
            labelTypeFichierValeur.Text = "";
            labelTypeMediaValeur.Text = "";
            labelEvenementPrise.Text = "";
            textBoxNomMedia.Text = "";

            textBoxDescriptionMedia.Text = "";
            labelDateCreation.Text = DateTime.Now.ToShortDateString();
            labelDateModification.Text = DateTime.Now.ToShortDateString();


            if (mediaCourant.Site == null)
                labelLieuPrise.Text = "";
            else
                labelLieuPrise.Text = mediaCourant.Site.AdresseComplete;
            if (mediaCourant.Evenement == null)
                labelEvenementPrise.Text = "";
            else
                labelEvenementPrise.Text = mediaCourant.Evenement.NomEvenement;
            UpdateListes();

        }
        // initialiser le formulaire pour une modification de media, lors de l'ouverture de la fenetre
        private void InitialiserValeursModification()
        {
            // controles
            buttonAjouterRester.Hide();
            buttonAjouterSortir.Hide();
            buttonChoisirFichier.Enabled = false;
            // todo permettre de modifier la collection et supporter le déplacement du fichier
            //comboBoxCollection.Enabled = false;  // empecher de modifier la collection.  
            // Valeurs des champs
            labelIdValeur.Text = mediaCourant.Id.ToString();
            dateTimePickerDatePrise.MaxDate = mediaCourant.DateHeureCreation;
            labelFichierOriginalValeur.Text = mediaCourant.NomFichierSM4D;
            openFileDialogFichierMedia.FileName = ConfigGlobale.EmplacementImages() + mediaCourant.NomFichierSM4D;
            pictureBoxMiniature128.ImageLocation = mediaCourant.MiniatureVariablePath(128);
            pictureBoxMiniature128.SizeMode = PictureBoxSizeMode.StretchImage;
            // Image image = Image.FromFile(ConfigGlobale.EmplacementImages() + mediaCourant.NomFichierSM4D);
            // pictureBoxMiniature128.Image = image.GetThumbnailImage(128, 128, () => false, IntPtr.Zero);

            labelTypeMediaValeur.Text = mediaCourant.TypeMedia;
            labelTypeFichierValeur.Text = mediaCourant.TypeFichier;
            comboBoxCollection.DataSource = listeCollections;
            comboBoxCollection.DisplayMember = "NomCollection";
            comboBoxCollection.SelectedItem = listeCollections.Find(c => c.Id == mediaCourant.Collection.Id);


            labelParCreationValeur.Text = mediaCourant.UtilisateurCreation.Login;
            if (mediaCourant.UtilisateurModification == null)
            {
                mediaCourant.UtilisateurModification = ConfigGlobale.UtilisateurCourant();
            }
            labelParModificationValeur.Text = mediaCourant.UtilisateurModification.Login;

            labelDateCreation.Text = mediaCourant.DateHeureCreation.ToShortDateString();

            labelDateModification.Text = mediaCourant.DateHeureModification.ToShortDateString();

            dateTimePickerDatePrise.Value = mediaCourant.DatePrise;
            textBoxNombreAnsValeur.Text = mediaCourant.SpanDatePrise.ToString();
            checkBoxAnalyseRequise.Checked = mediaCourant.IndicateurRecherches;
            textBoxDescriptionRecherches.Text = mediaCourant.NotesRecherches;

            if (mediaCourant.Evenement != null)
            {
                labelEvenementPrise.Text = mediaCourant.Evenement.NomEvenement;
            }

            textBoxDescriptionMedia.Text = mediaCourant.Description;
            //
            // remplir adequatement les listes de Presences et Sujets.
            listePersonnesIdentifiees = mediaCourant.Presences;
            listBoxPresences.DataSource = listePersonnesIdentifiees;
            listBoxPresences.DisplayMember = "Personne.NomComplet";

            listeSujetsApplicables = mediaCourant.Etiquettes;
            listBoxSujets.DataSource = listeSujetsApplicables;
            listBoxSujets.DisplayMember = "NomSujet";

            listeSujetsApplicables = mediaCourant.Etiquettes;
            if (mediaCourant.Site == null)
                labelLieuPrise.Text = "";
            else
                labelLieuPrise.Text = mediaCourant.Site.AdresseComplete;
            textBoxNomMedia.Text = mediaCourant.Nom;


        }
        /*  methodes d'écrans
         *  private bool ValiderFormulaire()
         *  private void InitialiserValeursModification()
         *  private void InitialiserValeursCreation()
         *  private void InitialiserFormulaire()
         *  private void UpdateListes()
         *  */
        // Valider la saisie des données en mode création et modfication
        private bool ValiderFormulaire()
        {
            bool valide = true;
            messages = new List<string>();
            //bool premierOnglet = 
            // Premier onglet
            // fichier media obligatoire
            if (openFileDialogFichierMedia.FileName == "")
            {
                messages.Add("Vous devez choisir une fichier média");
                valide = false;
            }
            // collection obligatoire
            Collections collChoix = (Collections)comboBoxCollection.SelectedItem;
            if (collChoix.Id == 0)
            {
                messages.Add("La Collection est obligatoire, veuillez en choisir une");
                valide = false;
            }
            // Description recheches obligatoire si analyse cochee
            if ((checkBoxAnalyseRequise.Checked) && (textBoxDescriptionRecherches.Text.Length == 0))
            {
                messages.Add("Si l'Analyse est requise, décrire sommairement celle-ci");
                valide = false;
            }
            // Nom obligatoire 
            if (textBoxNomMedia.Text.Length == 0)
            {
                messages.Add("Le nom du média est obligatoire.  Choisir qq mots décrivant son contenu et utile à sa recherche.");
                valide = false;
            }
            // Au moins 1 sujet
            if (listBoxSujets.Items.Count == 0)

            {
                messages.Add("Vous devez choisir au moins 1 sujet.");
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


        private void labelNombreMedias_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBoxMiniature_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_5(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void buttonAjouterRester_Click(object sender, EventArgs e)
        {

            bool valide = this.ValiderFormulaire();
            if (valide)
            {
                this.creerMedia(sender, e);
                this.RafraichirFormulaire();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonChoisirFichier_Click(object sender, EventArgs e)
        {
            string copyright, collection;
            if (openFileDialogFichierMedia.ShowDialog() == DialogResult.OK)
            {
                labelFichierOriginalValeur.Text = openFileDialogFichierMedia.FileName;

                nomFichierCourt = openFileDialogFichierMedia.SafeFileName;
                //  Image image = Image.FromFile(openFileDialogFichierMedia.FileName);
                //  pictureBoxMiniature128.Image = image.GetThumbnailImage(128, 128, () => false, IntPtr.Zero);
                pictureBoxMiniature128.ImageLocation = openFileDialogFichierMedia.FileName;
                pictureBoxMiniature128.SizeMode = PictureBoxSizeMode.StretchImage;
                FileInfo propFichier = new FileInfo(openFileDialogFichierMedia.FileName);
                // todo brancher le type de media avec le domaine de valeur
                labelTypeMediaValeur.Text = "Image";
                labelTypeFichierValeur.Text = propFichier.Extension;
                mediaMetas = mediaCourant.ExtraireMetadonnees(openFileDialogFichierMedia.FileName, out collection, out copyright);
                if (mediaMetas.IndicateurRecherches)
                {
                    DialogResult confirmation = MessageBox.Show("Le fichier image a des métadonnées, souhaitez-vous les utiliser?", "Métadonnées disponible", MessageBoxButtons.YesNo);
                    if (confirmation == DialogResult.Yes)
                    {
                        // Initialiser les champs de l'écran avec les données 
                        textBoxNomMedia.Text =  mediaMetas.Nom;
                        dateTimePickerDatePrise.Value = mediaMetas.DatePrise;
                        textBoxNombreAnsValeur.Text = mediaMetas.SpanDatePrise.ToString();
                        textBoxDescriptionMedia.Text = mediaMetas.Description;
                        foreach ( Etiquettes et in mediaMetas.Etiquettes)
                        {
                            listeSujetsApplicables.Add(et);

                        }
                        listBoxSujets.DataSource = null;
                        listBoxSujets.DataSource = listeSujetsApplicables;
                        listBoxSujets.DisplayMember = "NomSujet";


                        if (collection != "")
                        {
                            collectionChoisie = listeCollections.Find(c=> c.NomCollection.Equals(collection));
                            if (collectionChoisie != null)
                            {
                                comboBoxCollection.SelectedItem = collectionChoisie;
                            }

                        }
                    }
                }              
            }           
        }

        private void comboBoxCollection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonChoisirLieu_Click(object sender, EventArgs e)
        {
            // todo brancher à la sélection d'un lieu
            // todo assigner le lieu choisi
        }

        private void buttonChoixEvenement_Click(object sender, EventArgs e)
        {
            SelectionEvenement ecran = new SelectionEvenement(mediaCourant.Evenement);
            ecran.ShowDialog();
        }

        private void buttonAjoutPresence_Click(object sender, EventArgs e)
        {
            SelectionPersonne ecran = new SelectionPersonne();
            ecran.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectionSujet ecran = new SelectionSujet();
            ecran.ShowDialog();

        }

        private void buttonRetraitPresence_Click(object sender, EventArgs e)
        {
            if (listBoxPresences.SelectedItems.Count > 0)
            {
                foreach (Presences p in listBoxPresences.SelectedItems)
                {
                    listePersonnesIdentifiees.Remove(p);
                }
                listBoxPresences.DataSource = null;
                listBoxPresences.DataSource = listePersonnesIdentifiees;
            }
        }

        private void buttonRetraitSujet_Click(object sender, EventArgs e)
        {
            if (listBoxSujets.SelectedItems.Count > 0)
            {
                foreach (Etiquettes et in listBoxSujets.SelectedItems)
                {
                    listeSujetsApplicables.Remove(et);
                }
                listBoxSujets.DataSource = null;
                listBoxSujets.DataSource = listeSujetsApplicables;
            }
            // todo retirer la selection de sujets de la liste
            // todo rendre inactif si aucune selection
        }

        private void buttonAjouterSortir_Click(object sender, EventArgs e)
        {
            // todo Valider
            bool valide = this.ValiderFormulaire();
            if (valide)
            {
                this.creerMedia(sender, e);
                this.Close();
            }

        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {

            bool valide = this.ValiderFormulaire();

            int entier = 0;
            if (valide)

            {
                // ENREGISTRER LES MODIFICATIONS DANS LA BD
                Collections collCible = (Collections)comboBoxCollection.SelectedItem;
                string nomSMUnique = mediaCourant.NomFichierSM4D;

                // déterminer si la collection a changé.  Si oui, il faut déplacer le fichier media d'un répertoire à l'autre.
                if (mediaCourant.Collection.Id != collCible.Id)
                {
                    nomSMUnique = collCible.AjouterMedia(mediaCourant, mediaCourant.Collection);
                    // libérer le fichier avant de le supprimer dans le dossier
                    pictureBoxMiniature128.ImageLocation = collCible.SousRepComplet() + mediaCourant.NomFichierSM4D;
                    mediaCourant.Collection.RetirerMedia(mediaCourant);
                }
                // copie du media dans le repertoire d'archives sous un nom unique
                mediaCourant.NomFichierSM4D = nomSMUnique;
                mediaCourant.Collection = (Collections)comboBoxCollection.SelectedItem;
                mediaCourant.TypeMedia = labelTypeMediaValeur.Text;
                mediaCourant.TypeFichier = labelTypeFichierValeur.Text;
                mediaCourant.DatePrise = dateTimePickerDatePrise.Value;
                Int32.TryParse(textBoxNombreAnsValeur.Text, out entier);
                mediaCourant.SpanDatePrise = entier;
                mediaCourant.Description = textBoxDescriptionMedia.Text;

                mediaCourant.IndicateurRecherches = checkBoxAnalyseRequise.Checked;
                mediaCourant.NotesRecherches = textBoxDescriptionRecherches.Text;
                mediaCourant.Presences = listePersonnesIdentifiees;
                mediaCourant.Etiquettes = listeSujetsApplicables;
                mediaCourant.Nom = textBoxNomMedia.Text;
                connection.ModifierMedia(mediaCourant);

                // ENREGISTRER LES METADONNEES DANS LE FICHIER
                bool succes = false;

                // 1) libérer miniature pour permettre la sauvegarde
                nomSMUnique = pictureBoxMiniature128.ImageLocation;
                pictureBoxMiniature128.ImageLocation = "";

                // 2 créer les metadonnees dans les proprietes du fichier image du media
                succes = mediaCourant.EnregistrerMetadonnees( );
                
                this.Close();
            }
        }

        private void buttonSortir_Click(object sender, EventArgs e)
        {
            // todo valider si modification et si oui demander confirmation
            // todo fermer sur confirmation
            this.Close();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void creerMedia(object sender, EventArgs e)

        {

            // creation du media
            Medias unMedia = new Medias(
                (Collections)comboBoxCollection.SelectedItem,
                labelFichierOriginalValeur.Text,
                nomFichierCourt,
                labelTypeMediaValeur.Text,
                labelTypeFichierValeur.Text,
                dateTimePickerDatePrise.Value,
                textBoxNombreAnsValeur.Text,
                textBoxDescriptionMedia.Text,
                mediaCourant.Site,
                mediaCourant.Evenement,
                checkBoxAnalyseRequise.Checked,
                textBoxDescriptionRecherches.Text,
                listePersonnesIdentifiees,
                listeSujetsApplicables,
                textBoxNomMedia.Text);

            // enregistrement du media dans la BD
            connection.CreerMedia(unMedia);

            // copie du fichier media dans le repertoire d'archives sous un nom unique
            Collections coll = (Collections)comboBoxCollection.SelectedItem;
            nomFichierCourt = coll.AjouterMedia(unMedia, labelFichierOriginalValeur.Text);
            unMedia.NomFichierSM4D = nomFichierCourt;

            // ENREGISTRER LES METADONNEES DANS LE FICHIER
            bool succes = false;


            // 1) libérer miniature pour permettre la sauvegarde
            string nomSMUnique = pictureBoxMiniature128.ImageLocation;
            pictureBoxMiniature128.ImageLocation = "";

            // 2 créer les metadonnees dans les proprietes du fichier image du media
            succes = unMedia.EnregistrerMetadonnees();


            // 3) réinitialiser miniature
            pictureBoxMiniature128.ImageLocation = nomSMUnique;


        }


        private void dateTimePickerDateCreation_ValueChanged(object sender, EventArgs e)
        {


        }
        // met à jour les listes déroulantes de l'ecran
        private void UpdateListes()
        {

            listBoxPresences.DataSource = listePersonnesIdentifiees;
            listBoxPresences.DisplayMember = "Personne.NomComplet";
            listBoxSujets.DataSource = null;
            listBoxSujets.DataSource = listeSujetsApplicables;
            listBoxSujets.DisplayMember = "NomSujet";
        }

        private void listBoxSujets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDatePrise_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelTypeMediaValeur_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelectionLieuPrise_Click(object sender, EventArgs e)
        {

            SelectionLieu ecran = new SelectionLieu(mediaCourant.Site);
            ecran.ShowDialog();

        }
        public void MAJLieu(Lieux lieu)
        {
            if (lieu.Id == 0)
            {
                mediaCourant.Site = null;
                labelLieuPrise.Text = "";
            }
            else
            {
                mediaCourant.Site = lieu;
                labelLieuPrise.Text = mediaCourant.Site.AdresseComplete;
            }
        }
        public void MAJEven(Evenements even)
        {
            if (even.Id == 0)
            {
                mediaCourant.Evenement = null;
                labelEvenementPrise.Text = "";
            }
            else
            {
                mediaCourant.Evenement = even;
                labelEvenementPrise.Text = mediaCourant.Evenement.NomEvenement;
            }
        }
        public void MAJPersonne(Personnes unePersonne)
        {
            Presences unePres = new Presences(unePersonne, mediaCourant);
            bool dejaLa = listePersonnesIdentifiees.Any(p => p.IdPersonne == unePersonne.Id);
            if (!dejaLa)
            {
                listePersonnesIdentifiees.Add(unePres);
            }
            listBoxPresences.DataSource = null;
            listBoxPresences.DataSource = listePersonnesIdentifiees;
        }
        public void MAJSujet(Sujets unSujet)
        {
            Etiquettes unEtiq = new Etiquettes(mediaCourant, unSujet, "");
            bool dejaLa = listeSujetsApplicables.Any(e => e.Sujet.Id == unSujet.Id);
            if (!dejaLa)
            {
                listeSujetsApplicables.Add(unEtiq);
            }
            listBoxSujets.DataSource = null;
            listBoxSujets.DataSource = listeSujetsApplicables;
            listBoxSujets.DisplayMember = "NomSujet";
        }
        private void linkLabelQuitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
