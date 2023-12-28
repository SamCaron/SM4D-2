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
    public partial class BorneListePhotos : Form
    {
        // attributs généraux de la fenetre d'accueil de borne de consultation
        private Medias mediaCourant = new Medias();
        private ConnecteurSQLMedias connecteur = new ConnecteurSQLMedias();
        private List<Medias> listeMediasFiltres = new List<Medias>();
        private List<int> listeIdMediasFiltresDoublons = new List<int>();
        private List<int> listeIdMediasFiltres = new List<int>();
        private List<Sujets> listeSujets = new List<Sujets>();
        private List<Lieux> listeLieux = new List<Lieux>();
        private List<Collections> listeCollections = new List<Collections>();
        private string retour;
        private int pageCourante = 1;
        private int nbPages = 1;
        private int nbTotalFiltres = 0;
        private bool enInitialisation = true;
        private bool cacher = false;
        private MediasFiltres filtresMedias = new MediasFiltres();
        private int hauteurFenetre, largeurFenetre;
        private int carreImage = 140;

        // tableau des 1) tris
        private string[,] entetes = { { "Date d'ajout","   ", "DateHeureCreation" },
                           {"Date de prise","   ", "DatePrise" },
                        {"Nom du média","   ", "Nom" },
            {"No de Collection","   ", "IdCollection" },
            //                 {"Site","   ", "IdLieuPrise" }   };
            };
        public BorneListePhotos()
        {
            InitializeComponent();
            InitialiserFormulaire();
        }
        private void InitialiserFormulaire()
        {
            comboBoxLieux.Enabled = false;
            tableLayoutPanelMedias.RowCount = 4;
            tableLayoutPanelMedias.ColumnCount = 6;

            dateTimePickerDe.CustomFormat = "yyyy";
            dateTimePickerA.CustomFormat = "yyyy";
            dateTimePickerDe.Value = ConfigGlobale.ANNEEDE;
            dateTimePickerA.Value = DateTime.Now;

            listeSujets = Sujets();
            comboBoxSujets.Items.Clear();
            comboBoxSujets.DataSource = listeSujets;
            comboBoxSujets.DisplayMember = "Nom";

            listeCollections = Collections();
            comboBoxCollections.Items.Clear();
            comboBoxCollections.DataSource = listeCollections;
            comboBoxCollections.DisplayMember = "NomCollection";

            listeLieux = Lieux();
            comboBoxLieux.Items.Clear();
            comboBoxLieux.DataSource = listeLieux;
            comboBoxLieux.DisplayMember = "AdresseComplete";

            List<string> listeTris = new List<string>();

            for (int i = 0; i < entetes.Length / 3; i++)
            {
                listeTris.Add(entetes[i, 0]);
            }

            comboBoxTri.Items.Clear();
            comboBoxTri.DataSource = listeTris;
            comboBoxTri.SelectedIndex = 0;
            comboBoxSens.SelectedIndex = 1;
            // obtenir une première liste de Id des images filtrees
            MediasFiltres(textBoxTexte.Text, dateTimePickerDe.Value.Year, dateTimePickerA.Value.Year);

            RafraichirFormulaire();
            enInitialisation = false;
            // initialisation liee a la securite
            if (!(Parametres.TypeInstallation.TrimEnd() == "Complet"))
            {
                buttonAjouter.Enabled = false;
            }
        }
        private List<Collections> Collections()
        {


            List<Collections> collections = new List<Collections>();
            Collections toutes = new Collections();
            collections = connecteur.GetCollections(true);
            toutes.NomCollection = "-Toutes les collections-";
            toutes.Id = 0;

            collections.Insert(0, toutes);

            return collections;
        }

        private List<Sujets> Sujets()
        {
            ConnecteurSQLCommun connComm = new ConnecteurSQLCommun();
            //todo decoder date et span
            List<Sujets> sujets = new List<Sujets>();
            Sujets tous = new Sujets();
            sujets = connComm.RechercherSujets("", true);
            tous.Nom = "-Tous les sujets-";
            tous.Id = "Tous";
            tous.IdHiercharique = (float?)null;
            sujets.Insert(0, tous);

            return sujets;
        }

        private List<Lieux> Lieux()
        {
            ConnecteurSQLLieux connLieux = new ConnecteurSQLLieux();

            List<Lieux> lieux = new List<Lieux>();
            Lieux tous = new Lieux();
            lieux = connLieux.RechercherLieux("");
            tous.AdresseComplete = "-Tous les lieux-";
            tous.Id = 0;

            lieux.Insert(0, tous);

            return lieux;
        }
        // obtenir la liste des ID des médias correspondant aux filtres
        private List<int> MediasFiltres(string filtres, int dateFiltreDe, int dateFiltreA)
        {

            List<Medias> liste;
            Medias aucun = new Medias();
            string sens = "Asc";

           Sujets sujetSelection = (Sujets)comboBoxSujets.SelectedItem;
            Collections collectionSelection = (Collections)comboBoxCollections.SelectedItem;
            filtresMedias.Description = filtres;
            filtresMedias.DatePriseDebut = new DateTime(dateFiltreDe, 1, 1);
            filtresMedias.DatePriseFin = new DateTime(dateFiltreA, 12, 31);
            filtresMedias.IdLieuPrise = ((Lieux)(comboBoxLieux.SelectedItem)).Id;
            filtresMedias.IdCollection = ((Collections)comboBoxCollections.SelectedItem).Id;
            filtresMedias.IdSujet = ((Sujets)(comboBoxSujets.SelectedItem)).IdHiercharique;
            filtresMedias.NiveauSujet = ((Sujets)(comboBoxSujets.SelectedItem)).Niveau;
            filtresMedias.DateHeureModificationFin = DateTime.Now;
            filtresMedias.DateHeureCreationFin = DateTime.Now;
            if ((string)comboBoxSens.SelectedItem == "Descendant")
            {
                sens = "(D)";
            }
            else
            {
                sens = "(A)";
            }


            for (int i = 0; i < entetes.Length / 3; i++)
            {
                if ((string)comboBoxTri.SelectedItem == entetes[i, 0])
                {
                    entetes[i, 1] = sens;
                }
                else
                {
                    entetes[i, 1] = "";
                }
            }
            int nbTotalFiltres2 = 0;
            ConnecteurSQLMedias connecteur2 = new ConnecteurSQLMedias();

            listeIdMediasFiltresDoublons = connecteur2.MediasGetFiltresTriTous(filtresMedias, entetes, out nbTotalFiltres2);

            // retire les doublons du au fait de multiple étiquettes
            listeIdMediasFiltres = listeIdMediasFiltresDoublons.Distinct().ToList();

            nbPages = (int)(listeIdMediasFiltres.Count / 24);
            if (listeIdMediasFiltres.Count % 24 > 0)
            {
                nbPages++;
            }
            pageCourante = 1;
            if (nbPages == 0)
            { nbPages = 1; }
            return listeIdMediasFiltres;
        }

        private void RafraichirFormulaire()
        {
            // MAJ liee a la securite
            if (!(Parametres.TypeInstallation.TrimEnd() == "Complet"))
            {
                buttonAjouter.Enabled = false;
            }
            else
            {
                buttonAjouter.Enabled = true;
            }
            ConnecteurSQLMedias conn = new ConnecteurSQLMedias();
            int debut, fin;
            while (tableLayoutPanelMedias.Controls.Count > 0)
            {
                tableLayoutPanelMedias.Controls[0].Dispose();
            }
            listeMediasFiltres.Clear();
            debut = (pageCourante - 1) * 24;
            fin = debut + 23;
            if (fin >= listeIdMediasFiltres.Count)
            {
                fin = listeIdMediasFiltres.Count - 1;
            }

            for (int i = debut; i <= fin; i++)
            {
                Medias med = conn.MediasGetById(listeIdMediasFiltres[i], true);
                listeMediasFiltres.Add(med);

                PictureBox pb = new PictureBox() ;

                pb.ImageLocation = med.MiniatureVariablePath(carreImage);
                pb.Height = carreImage;
                pb.Width = carreImage;  
                pb.SizeMode = PictureBoxSizeMode.StretchImage;

                tableLayoutPanelMedias.Controls.Add(pb);
                pb.MouseClick += new MouseEventHandler(pictureBoxSelection_Click);
            }
            RafraichirPagination();

        }


        Point GetRowColIndex(TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return new Point(6, 4);

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = tlp.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;

            return new Point(col, row);
        }
        private void pictureBoxSelection_Click(object sender, EventArgs e)
        {
            int x, y, z;
            Point cellPos = GetRowColIndex(
    tableLayoutPanelMedias,
    tableLayoutPanelMedias.PointToClient(Cursor.Position));
            x = cellPos.X;
            y = cellPos.Y;
            z = y * 6 + x;
            if (!(z >= listeMediasFiltres.Count))
            {
                mediaCourant = listeMediasFiltres[z];
                OuvrirMedia(mediaCourant);
              

            }

        }
        private void RafraichirPagination()
        {

            buttonPrecedent.Enabled = true;
            buttonSuivant.Enabled = true;
            buttonDebut.Enabled = true;
            buttonDernierePage.Enabled = true;
            if (pageCourante <= 1)
            {
                buttonPrecedent.Enabled = false;
                pageCourante = 1;
            }
            if (pageCourante == 1)
            {
                buttonDebut.Enabled = false;

            }
            if (pageCourante == nbPages)
            {
                buttonDernierePage.Enabled = false;
                buttonSuivant.Enabled = false;
            }
            if (pageCourante > nbPages)
            {
                buttonSuivant.Enabled = false;
                pageCourante = nbPages;
            }
            labelNombreMedias.Text = "Page " + pageCourante.ToString() + " de " + nbPages.ToString();
        }

        private void textBoxTexte_FiltresChanges(object sender, EventArgs e)
        {
            if (!enInitialisation)
            {
                listeIdMediasFiltres = MediasFiltres(textBoxTexte.Text, dateTimePickerDe.Value.Year, dateTimePickerA.Value.Year);
                RafraichirFormulaire();
            }

        }
        private void buttonDebut_Click(object sender, EventArgs e)
        {
            pageCourante = 1;
            RafraichirFormulaire();
        }

        private void buttonDernierePage_Click(object sender, EventArgs e)
        {
            pageCourante = nbPages;
            RafraichirFormulaire();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            pageCourante++;
            RafraichirFormulaire();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            pageCourante--;
            RafraichirFormulaire();
        }

        private void buttonPrecedent_Click_1(object sender, EventArgs e)
        {
            pageCourante--;
            RafraichirFormulaire();
        }

        private void buttonSuivant_Click_1(object sender, EventArgs e)
        {
            pageCourante++;
            RafraichirFormulaire();
        }

        private void buttonDernierePage_Click_1(object sender, EventArgs e)
        {
            pageCourante = nbPages;
            RafraichirFormulaire();
        }
        // une photo a été cliquée, on ouvre la page détails pour 
        private void OuvrirMedia(Medias medium)
        {
            AccueilBorne accueil = (AccueilBorne)Application.OpenForms["AccueilBorne"];
            accueil.BPContexte(medium, listeIdMediasFiltres);
            accueil.basculer("BP");


        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            /* code de test pour jouer avec la taille de la fenetre
             * hauteurFenetre = Form.ActiveForm.Height;
            largeurFenetre = Form.ActiveForm.Width;
            MessageBox.Show("Largeur:" + largeurFenetre.ToString() + " Hauteur:" + hauteurFenetre.ToString() +" Carre Image:" + carreImage.ToString());
            carreImage = (int)(140 * largeurFenetre / 1021);
            tableLayoutPanelMedias.Height = (int)(carreImage * 4);
            tableLayoutPanelMedias.Width = (int)(carreImage * 6); */
            // MAJ liee a la securite
            if (!(Parametres.TypeInstallation.TrimEnd() == "Complet"))
            {
                buttonAjouter.Enabled = false;
            }
            else
            {
                buttonAjouter.Enabled = true;
                GererMedia ecran = new GererMedia();
                ecran.ShowDialog();
                MediasFiltres(textBoxTexte.Text, dateTimePickerDe.Value.Year, dateTimePickerA.Value.Year);
                RafraichirFormulaire();
            }

        }

        private void labelNombreMedias_Click(object sender, EventArgs e)
        {

        }
    }
}
