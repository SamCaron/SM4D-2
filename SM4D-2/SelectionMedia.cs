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
    public partial class SelectionMedia : Form
    {
        private Medias mediaCourant = new Medias();
        private ConnecteurSQLMedias connecteur = new ConnecteurSQLMedias();
        private List<Medias> listeMediasFiltres = new List<Medias>();
        private List<Sujets> listeSujets = new List<Sujets>();
        private string retour;
        private int pageCourante = 1;
        private int nbPages = 1;
        private int nbTotalFiltres = 0;
        private bool enInitialisation = true;
        public SelectionMedia(Medias mediaChoisi, string appelantRetour)
        {
            InitializeComponent();
            retour = appelantRetour;
            if (mediaChoisi != null)
            {
                mediaCourant = mediaChoisi;
            }
            else
            {
                mediaCourant = new Medias();
            }
            InitialiserFormulaire();
        }
        private void InitialiserFormulaire()
        {
            labelSelection.Text = mediaCourant.Nom;
            pictureBoxSelection.ImageLocation = mediaCourant.MiniatureVariablePath(50);
            pictureBoxSelection.SizeMode = PictureBoxSizeMode.StretchImage;
            tableLayoutPanelMedias.RowCount = 5;
            tableLayoutPanelMedias.ColumnCount = 5;

            dateTimePickerDe.CustomFormat = "yyyy";
            dateTimePickerA.CustomFormat = "yyyy";
            dateTimePickerDe.Value = ConfigGlobale.ANNEEDE;
            dateTimePickerA.Value = DateTime.Now;

            listeSujets = Sujets();
            comboBoxSujets.Items.Clear();
            comboBoxSujets.DataSource = listeSujets;
            comboBoxSujets.DisplayMember = "Nom";

            listeMediasFiltres = MediasFiltres(textBoxTexte.Text, dateTimePickerDe.Value.Year, dateTimePickerA.Value.Year);

            RafraichirFormulaire();
            enInitialisation = false;
        }
        private void buttonSelection_Click(object sender, EventArgs e)
        {
            switch (retour)
            {
                case "GererLieu":
                    GererLieu appelantLieu = (GererLieu)Application.OpenForms[retour];
                    appelantLieu.MAJMedia(mediaCourant);
                    break;
                default:
                    break;
            }

            this.Close();
        }
        private void RafraichirPagination()
        {

            buttonPrevious.Enabled = true;
            buttonNext.Enabled = true;
            if (pageCourante < 1)
            {
                buttonPrevious.Enabled = false;
                pageCourante = 1;
            }
            if (pageCourante == 1)
            {
                buttonPrevious.Enabled = false;

            }
            if (pageCourante == nbPages)
            {
                buttonNext.Enabled = false;
            }
            if (pageCourante > nbPages)
            {
                buttonNext.Enabled = false;
                pageCourante = nbPages;
            }
            labelPage.Text = "Page " + pageCourante.ToString() + " de " + nbPages.ToString();
        }

        private void RafraichirFormulaire()
        {
            while (tableLayoutPanelMedias.Controls.Count > 0)
            {
                tableLayoutPanelMedias.Controls[0].Dispose();
            }
            foreach (Medias med in listeMediasFiltres)
            {
                PictureBox pb = new PictureBox();
                pb.ImageLocation = med.MiniatureVariablePath(0);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                tableLayoutPanelMedias.Controls.Add(pb);
                pb.MouseClick += new MouseEventHandler(pictureBoxSelection_Click);
            }

            labelSelection.Text = mediaCourant.Nom;
            pictureBoxSelection.ImageLocation = mediaCourant.MiniatureVariablePath(100);
            pictureBoxSelection.SizeMode = PictureBoxSizeMode.StretchImage;
            RafraichirPagination();

        }
        private List<Medias> MediasFiltres(string filtres, int dateFiltreDe, int dateFiltreA)
        {
            //todo decoder date et span
            List<Medias> liste;
            Medias aucun = new Medias();
            // aucun.Nom = "-Aucun/Inconnu-";
            // aucun.Id = 0;

            Sujets sujetSelection = (Sujets)comboBoxSujets.SelectedItem;

            liste = connecteur.RechercherMedias(filtres, dateFiltreDe, dateFiltreA, pageCourante, 25, sujetSelection.IdHiercharique, sujetSelection.Niveau, out nbPages, out nbTotalFiltres);
            // todo remettre moyen de deselectionner l'image d'avant
            //   liste.Insert(0, aucun);
            return liste;
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
            sujets.Insert(0, tous);


            // todo  moyen de deselectionner l'image d'avant
            //   liste.Insert(0, aucun);
            return sujets;
        }


        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTexte_TextChanged(object sender, EventArgs e)
        {

            int anneeDe = 0;
            int anneeA = 0;
            anneeDe = dateTimePickerDe.Value.Year;
            anneeA = dateTimePickerA.Value.Year;

            if (!enInitialisation)
            {

                listeMediasFiltres = MediasFiltres(textBoxTexte.Text, anneeDe, anneeA);

                RafraichirFormulaire();
            }

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            pageCourante--;
            textBoxTexte_TextChanged(sender, e);

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            pageCourante++;
            textBoxTexte_TextChanged(sender, e);

        }

        private void dateTimePickerDe_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerDe.Value > dateTimePickerA.Value)
            {
                dateTimePickerDe.Value = dateTimePickerA.Value;
            }
            if (dateTimePickerDe.Value < ConfigGlobale.ANNEEDE)
            {
                dateTimePickerDe.Value = ConfigGlobale.ANNEEDE;
            }
            textBoxTexte_TextChanged(sender, e);
        }

        private void dateTimePickerA_ValueChanged(object sender, EventArgs e)
        {

            if (dateTimePickerA.Value < dateTimePickerDe.Value)
            {
                dateTimePickerA.Value = dateTimePickerDe.Value;
            }
            if (dateTimePickerA.Value > DateTime.Now)
            {
                dateTimePickerDe.Value = DateTime.Now;
            }
            textBoxTexte_TextChanged(sender, e);
        }
        private void tableLayoutPanelMedias_Click(object sender, PaintEventArgs e)
        {


        }


        private void tableLayoutPanelMedias_Paint(object sender, PaintEventArgs e)
        {


        }
        Point GetRowColIndex(TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return new Point(5, 5);

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
            z = y * 5 + x;
            if (!(z >= listeMediasFiltres.Count))
            {
                mediaCourant = listeMediasFiltres[z];
                labelSelection.Text = mediaCourant.Nom;
                pictureBoxSelection.ImageLocation = mediaCourant.MiniatureVariablePath(100);
                pictureBoxSelection.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void comboBoxSujets_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxTexte_TextChanged(sender, e);
        }
    }

}
