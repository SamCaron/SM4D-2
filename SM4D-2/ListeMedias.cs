using SM4D2Librairie.AccesDonnees;
using SM4D2Librairie.Modeles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM4D_2
{
    public partial class ListeMedias : Form

    {
        public const int NBPARPAGE = 9;
        private List<Medias> listeMedias;
        private MediasFiltres filtresMedias = new MediasFiltres();
        private int noColonneTri = 2;
        private int nbParPage = NBPARPAGE;
        private int pageCourante = 1;
        private int nbPages = 1;
        private int nbTotalFiltre = 0;
        // tableau de trios contenant dans l'ordre de l'index 0: Entete de la colonne, 1: suffixe et determinant du sens du tri (A), (D) ou rien et 2: nom de la colonne dans la BD
        private string[,] entetes = { { "","   ", "Id" },
                        {"Nom","   ", "Nom" },
            {"Collection","   ", "IdCollection" },
             {"Nom du Fichier","   ", "NomFichierSM4D" },
              {"Id","   " , "Id"},
               {"Date Prise","   ", "DatePrise" },
                {"Type","   " , "TypeFichier"},
                 {"Rech?","   " ,"IndicateurRecherches"},
                  {"Site","   ", "IdLieuPrise" } };


        public ListeMedias()
        {

            InitializeComponent();

        }

        public ListeMedias(List<Medias> desMedias)
        {
            listeMedias = desMedias;
            InitializeComponent();
            dataGridViewMedias.DataSource = listeMedias;
            RafraichirListe();


        }
        public void RafraichirFomulaire()
        {
            dataGridViewMedias.EnableHeadersVisualStyles = false;
            switch (dataGridViewMedias.SelectedRows.Count)
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
        }
        public void RafraichirListe()
        {
            ConnecteurSQLMedias connection = new ConnecteurSQLMedias();
            listeMedias = connection.MediasGetFiltresTri(filtresMedias, entetes, pageCourante, nbParPage, out nbPages, out nbTotalFiltre);
            dataGridViewMedias.DataSource = listeMedias;
            labelNombreMedias.Text = "(" + nbTotalFiltre.ToString() + ")    Page " + pageCourante.ToString() + " de " + nbPages.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)

            {
                // Assigner le suffixe et indicateur de tri et determine aussi le sens du tri 
                for (int i = 1; i < 9; i++)
                {
                    if (e.ColumnIndex == i)
                    {
                        dataGridViewMedias.EnableHeadersVisualStyles = false;
                        dataGridViewMedias.Columns[e.ColumnIndex].HeaderCell.Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
                        switch (entetes[i, 1])
                        {
                            case "   ":
                                entetes[i, 1] = "(A)";
                                break;
                            case "(A)":
                                entetes[i, 1] = "(D)";
                                break;
                            case "(D)":
                                entetes[i, 1] = "(A)";
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        dataGridViewMedias.Columns[i].HeaderCell.Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Regular);
                        entetes[i, 1] = "   ";
                    }
                }
                // reecrire les entetes de colonnes avec le suffixe de tri 
                if (e.RowIndex == -1)

                {
                    for (int i = 1; i < 9; i++)
                    {
                        dataGridViewMedias.Columns[i].HeaderText = entetes[i, 0] + "  " + entetes[i, 1];
                    }
                }
                RafraichirListe();

            }


        }

        private void buttonSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            GererMedia ecran = new GererMedia();
            ecran.ShowDialog();
            RafraichirListe();

        }
        public void MAJFiltres(MediasFiltres filtre)
        {
            this.filtresMedias = filtre;
        }

        private void dataGridViewMedias_MultiSelectChanged(object sender, EventArgs e)
        {
            this.RafraichirFomulaire();

        }

        private void dataGridViewMedias_SelectionChanged(object sender, EventArgs e)
        {
            this.RafraichirFomulaire();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            Medias unMedia = (Medias)(dataGridViewMedias.SelectedRows[0].DataBoundItem);
            int choix = dataGridViewMedias.SelectedRows[0].Index;
            GererMedia ecran = new GererMedia(unMedia);
            ecran.ShowDialog();
            RafraichirListe();
            dataGridViewMedias.Rows[0].Selected = false;
            dataGridViewMedias.Rows[choix].Selected = true;

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            // todo ajouter validation pour empecher la suppression si media est utilise comme profil

            DialogResult confirmation = MessageBox.Show("Souhaitez-vous vraiment supprimer les Médias sélectionnés, (incluant les présences et étiquettes)?", "Suppression", MessageBoxButtons.YesNo);
            ConnecteurSQLMedias connection = new ConnecteurSQLMedias();
            Medias media;
            switch (confirmation)
            {
                case DialogResult.Yes:
                    // suppression
                    for (int i = 0; i < dataGridViewMedias.SelectedRows.Count; i++)

                    {

                        media = (Medias)dataGridViewMedias.SelectedRows[i].DataBoundItem;
                        connection.MediasSupprimer(media.Id);
                    }
                    break;
                case DialogResult.No:
                    // rien
                    break;
                default:
                    break;
            }
            RafraichirListe();
        }

        private void buttonFiltrer_Click(object sender, EventArgs e)
        {
            FiltresMedias ecran = new FiltresMedias(filtresMedias);
            ecran.ShowDialog();
            RafraichirListe();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonDebut_Click(object sender, EventArgs e)
        {
            pageCourante = 1;
            RafraichirListe();
        }

        private void buttonDernierePage_Click(object sender, EventArgs e)
        {
            pageCourante = nbPages;
            RafraichirListe();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            if (pageCourante < nbPages)
            {
                pageCourante++;

            }
            else
            {
                pageCourante = 1;
            }
            RafraichirListe();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            if (pageCourante == 1)
            {
                pageCourante = nbPages;
            }
            else
            {
                pageCourante--;
            }
            RafraichirListe();
        }

        private void linkLabelQuitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
