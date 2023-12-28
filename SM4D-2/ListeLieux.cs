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
    public partial class ListeLieux : Form
    {
        public const int NBPARPAGE = 9;
        private List<Lieux> listeLieux;
        private LieuxFiltres filtresLieux = new LieuxFiltres();
        private int noColonneTri = 0;
        private int nbParPage = NBPARPAGE;
        private int pageCourante = 1;
        private int nbPages = 1;
        private int nbTotalFiltre = 0;
        // tableau de trios contenant dans l'ordre de l'index 0: Entete de la colonne, 1: suffixe et determinant du sens du tri (A), (D) ou rien et 2: nom de la colonne dans la BD
        private string[,] entetes = { {"Profil","   " , "IdPhotoLieu"},
                        {"No Civ.","   ", "NoCivique" },
                        {"Rue","   ", "CodeRue" },
                        { "Secteur","(A)", "CodeSecteur" },
                        {"Rech?","   " , "IndicateurRecherches"},
                        {"Id","   ", "Id" },
                        {"Constr.","   " ,"AnneeConstruction"},
                        {"Long.","   " ,"Longitude"},
                        {"Lat.","   ", "Latitude" },
                        {"Créé le","   ", "DateHeureCreation" } };



        public ListeLieux()
        {

            InitializeComponent();
            dataGridViewLieux.DataSource = listeLieux;
            RafraichirListe();
        }
        public void RafraichirFomulaire()
        {
            dataGridViewLieux.EnableHeadersVisualStyles = false;
            switch (dataGridViewLieux.SelectedRows.Count)
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
            ConnecteurSQLLieux connection = new ConnecteurSQLLieux();
            listeLieux = connection.LieuxGetFiltresTri(filtresLieux, entetes, pageCourante, nbParPage, out nbPages, out nbTotalFiltre);
            dataGridViewLieux.DataSource = listeLieux;
            labelNombreLieux.Text = "("+nbTotalFiltre.ToString()+ ")    Page " + pageCourante.ToString() + " de " + nbPages.ToString();
            dataGridViewLieux.EnableHeadersVisualStyles = false;
            switch (dataGridViewLieux.SelectedRows.Count)
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
        private void buttonDebut_Click(object sender, EventArgs e)
        {
            pageCourante = 1;
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

        private void buttonDernierePage_Click(object sender, EventArgs e)
        {
            pageCourante = nbPages;
            RafraichirListe();
        }

        private void buttonSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            GererLieu ecran = new GererLieu();
            ecran.ShowDialog();
            RafraichirListe();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            Lieux unLieu = (Lieux)(dataGridViewLieux.SelectedRows[0].DataBoundItem);
            int choix = dataGridViewLieux.SelectedRows[0].Index;
            GererLieu ecran = new GererLieu(unLieu);
            ecran.ShowDialog();

            dataGridViewLieux.Rows[0].Selected = false;
            dataGridViewLieux.Rows[choix].Selected = true;
            filtresLieux.DateHeureModificationFin = DateTime.Now;
            RafraichirListe();

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            // todo ajouter validation pour empecher la suppression si Lieux est utilise ailleurs

            DialogResult confirmation = MessageBox.Show("Souhaitez-vous vraiment supprimer les Lieux sélectionnés?", "Suppression", MessageBoxButtons.YesNo);
            ConnecteurSQLLieux connection = new ConnecteurSQLLieux();
            Lieux lieu;
            switch (confirmation)
            {
                case DialogResult.Yes:
                    // suppression
                    for (int i = 0; i < dataGridViewLieux.SelectedRows.Count; i++)

                    {

                        lieu = (Lieux)dataGridViewLieux.SelectedRows[i].DataBoundItem;
                        connection.LieuxSupprimer(lieu.Id);
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

        private void dataGridViewLieux_SelectionChanged(object sender, EventArgs e)
        {
            RafraichirFomulaire();
        }

        private void dataGridViewLieux_MultiSelectChanged(object sender, EventArgs e)
        {
            RafraichirFomulaire();
        }

        private void dataGridViewLieux_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)

            {
                // Assigner le suffixe et indicateur de tri et determine aussi le sens du tri 
                for (int i = 1; i < 10; i++)
                {
                    if (e.ColumnIndex == i)
                    {
                        dataGridViewLieux.EnableHeadersVisualStyles = false;
                        dataGridViewLieux.Columns[e.ColumnIndex].HeaderCell.Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
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
                        dataGridViewLieux.Columns[i].HeaderCell.Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Regular);
                        entetes[i, 1] = "   ";
                    }
                }
                // reecrire les entetes de colonnes avec le suffixe de tri 
                if (e.RowIndex == -1)

                {
                    for (int i = 1; i < 10; i++)
                    {
                        dataGridViewLieux.Columns[i].HeaderText = entetes[i, 0] + "  " + entetes[i, 1];
                    }
                }
                RafraichirListe();
            }
        }
        public void MAJFiltres(LieuxFiltres filtre)
        {
            this.filtresLieux = filtre;
        }
        private void buttonFiltrer_Click(object sender, EventArgs e)
        {

            FiltresLieux ecran = new FiltresLieux(filtresLieux);
            ecran.ShowDialog();
            pageCourante = 1;
            RafraichirListe();
        }

        private void linkLabelQuitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}

