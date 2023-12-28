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
    public partial class BorneListeCollections : Form

    {
        // attributs généraux de la fenetre de liste des collections
        private Collections collectionCourante = new Collections();
        private ConnecteurSQLMedias connecteur = new ConnecteurSQLMedias();
        private List<Collections> listeCollections = new List<Collections>();



        private int pageCourante = 1;
        private int nbPages = 1;
        private int nbTotalCollections = 0;
        private bool enInitialisation = true;

        public BorneListeCollections()
        {
            InitializeComponent();
            InitialiserFormulaire();
        }
        private void InitialiserFormulaire()
        {
            listeCollections = Collections();
            dataGridViewCollections.DataSource = null;
            dataGridViewCollections.DataSource = listeCollections;
            enInitialisation = false;
            initialiserContexteSecurite();

        }
        public void initialiserContexteSecurite()
        {

            // initialisation liee a la securite
            if (!(Parametres.TypeInstallation.TrimEnd() == "Complet"))
            {
                buttonAjouter.Enabled = false;
                buttonSupprimer.Enabled = false;
                buttonModifier.Text = "Consulter";
            }
            else
            {
                switch (dataGridViewCollections.SelectedRows.Count)
                {
                    case 0:
                        buttonModifier.Enabled = false;
                        buttonSupprimer.Enabled = false;
                        break;
                    case 1:
                        buttonModifier.Enabled = true;
                        buttonSupprimer.Enabled = true;
                        break;
                    default:
                        buttonModifier.Enabled = false;
                        buttonSupprimer.Enabled = true;
                        break;
                }
                buttonAjouter.Enabled = true;

                buttonModifier.Text = "Modifier";
            }
        }
        private List<Collections> Collections()
        {


            List<Collections> collections = new List<Collections>();
            Collections toutes = new Collections();
            collections = connecteur.GetCollections(false);

            return collections;
        }
        /// <summary>
        /// Déclenche le traitement de modification d'une collection 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            bool ecriture = true;
            Collections uneColl = (Collections)(dataGridViewCollections.SelectedRows[0].DataBoundItem);
            int choix = dataGridViewCollections.SelectedRows[0].Index;
            GererCollection ecran = new GererCollection(uneColl, ecriture);
            ecran.ShowDialog();
         //   InitialiserFormulaire();
            dataGridViewCollections.Rows[0].Selected = false;
            dataGridViewCollections.Rows[choix].Selected = true;

            RafraichirListe();
        }
        public void RafraichirListe()
        {
            initialiserContexteSecurite();


        }
        /// <summary>
        /// Declenche le traitement de creation d'une collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouter_Click(object sender, EventArgs e)
        {

            GererCollection ecran = new GererCollection();
            ecran.ShowDialog();
            InitialiserFormulaire();
            RafraichirListe();

        }
        /// <summary>
        /// Déclenche le traitement de suppression des collections sélectionnées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            // validation avant de supprimer

            // valider si la collection contient des médias dans la BD
            bool valide = true;
            ConnecteurSQLMedias connection = new ConnecteurSQLMedias();
            Collections coll;
            for (int i = 0; (i < dataGridViewCollections.SelectedRows.Count && valide); i++)
            {
                coll = (Collections)dataGridViewCollections.SelectedRows[i].DataBoundItem;
                List<Medias> meds = connection.MediasGetByIdColl(coll.Id);
                if (meds.Count > 0)
                {
                    MessageBox.Show("La collection " + coll.NomCollection + " ne peut être supprimée, elle contient des medias.  Supprimer ou réassigner les médias avant de supprimer");
                    valide = false;
                }
            }
            if (!valide)
            {
                return;
            }
            // valider si le repertoire de la collection contient des fichiers.
            for (int i = 0; (i < dataGridViewCollections.SelectedRows.Count && valide); i++)
            {
                coll = (Collections)dataGridViewCollections.SelectedRows[i].DataBoundItem;
                string chemin = ConfigGlobale.EmplacementImages() + coll.NomCollection;
                bool existe = Directory.Exists(chemin);
                if (existe)
                {
                    var dossier = new DirectoryInfo(chemin);
                    if (dossier.GetFileSystemInfos().Length > 0)
                    {
                        MessageBox.Show("La collection " + coll.NomCollection + " ne peut être supprimée, son répertoire contient des fichiers.  Supprimer ou déplacer les fichiers avant de supprimer");
                        valide = false;
                    }
                }
            }

            if (!valide)
            {
                return;
            }

            DialogResult confirmation = MessageBox.Show("Souhaitez-vous vraiment supprimer les collections sélectionnées?", "Suppression", MessageBoxButtons.YesNo);
  

            switch (confirmation)
            {
                case DialogResult.Yes:
                    // suppression
                
                    for (int i = 0; i < dataGridViewCollections.SelectedRows.Count; i++)

                    {
                        // supprimer de la bd
                        coll = (Collections)dataGridViewCollections.SelectedRows[i].DataBoundItem;
                        connection.CollectionsSupprimer(coll.Id);
                        // supprimer le répertoire
                        string chemin = ConfigGlobale.EmplacementImages() + coll.NomCollection;
                        bool existe = Directory.Exists(chemin);
                        if (existe)
                        {
                            Directory.Delete(chemin, true);
                        }
                    }
                    break;
                case DialogResult.No:
                    // rien
                    break;
                default:
                    break;
            }
            InitialiserFormulaire();
            RafraichirListe();
        }

        private void dataGridViewCollections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RafraichirListe();
        }

        private void dataGridViewCollections_SelectionChanged(object sender, EventArgs e)
        {
            RafraichirListe();
        }
    }
}
