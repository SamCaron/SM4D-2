using SM4D2;
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
    public partial class BorneMedia : Form

    {
        Medias mediaCourant;
        Medias mediaMetas;
        string copyright, collection;
        List<int> listeIdMedias = new List<int>();
        int position = 0;
        ConnecteurSQLMedias connecteur = new ConnecteurSQLMedias();
        public BorneMedia()
        {
            InitializeComponent();
        }
        public void initialiserContexte()
        {
            labelNomCollection.Text = mediaCourant.CollectionSig;
            labelFichierOriginalValeur.Text = mediaCourant.NomFichierSM4D;
            labelNomMedia.Text = mediaCourant.Nom;
            labelDatePrise.Text = mediaCourant.DatePrise.ToShortDateString();
            labelNbAnsPres.Text = mediaCourant.SpanDatePrise.ToString();
            textBoxDescriptionMedia.Text = mediaCourant.Description;
            pictureBoxMiniature500.ImageLocation = mediaCourant.MiniatureVariablePath(600);
            pictureBoxMiniature500.SizeMode = PictureBoxSizeMode.StretchImage;
            // initialisation liee a la securite
            if (!(Parametres.TypeInstallation.TrimEnd() == "Complet"))
            {
                buttonModifier.Enabled = false;
                buttonSupprimer.Enabled = false;

            }

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelQuitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccueilBorne accueil = (AccueilBorne)Application.OpenForms["AccueilBorne"];
            accueil.basculer("BLP");
        }
        public void contexte(Medias medium, List<int> listeIds)
        {
            mediaCourant = medium;
            listeIdMedias = listeIds;
            position = listeIdMedias.IndexOf(medium.Id);
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            position--;
            if (position < 0)
            { position = listeIdMedias.Count - 1; }

            mediaCourant = connecteur.MediasGetById(listeIdMedias[position], true);
            initialiserContexte();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            position++;
            if (position >= listeIdMedias.Count)
            { position = 0; }

            mediaCourant = connecteur.MediasGetById(listeIdMedias[position], true);
            initialiserContexte();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            GererMedia ecran = new GererMedia();
            ecran.ShowDialog();
            initialiserContexte();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {

            GererMedia ecran = new GererMedia(mediaCourant);
            ecran.ShowDialog();
            initialiserContexte();

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {

            DialogResult confirmation = MessageBox.Show("Souhaitez-vous vraiment supprimer le Média sélectionné (incluant les présences et étiquettes)?", "Suppression", MessageBoxButtons.YesNo);
            ConnecteurSQLMedias connection = new ConnecteurSQLMedias();
            Medias mediaASupprimer;
            switch (confirmation)
            {
                case DialogResult.Yes:
                    // suppression
                    {
                        mediaASupprimer = mediaCourant;
                        pictureBoxMiniature500.ImageLocation = "";
                        connection.MediasSupprimer(mediaASupprimer.Id); // supprimer de la bd
                        //pictureBoxMiniature500.Dispose();
                        mediaCourant.Collection.RetirerMedia(mediaASupprimer); // supprimer le fichier media
                        listeIdMedias.RemoveAll(I => I == mediaCourant.Id);
                        buttonPrecedent_Click(sender, e);
                        // pictureBoxMiniature500.ImageLocation = mediaCourant.MiniatureVariablePath(600);
                        //   pictureBoxMiniature500.SizeMode = PictureBoxSizeMode.StretchImage;

                    }
                    break;
                case DialogResult.No:
                    // rien
                    break;
                default:
                    break;
            }

        }

        private void buttonRetourListe_Click(object sender, EventArgs e)
        {
            // on revient à l'écran de liste donc on bascule du details à la liste
            AccueilBorne accueil = (AccueilBorne)Application.OpenForms["AccueilBorne"];
            accueil.basculer("BLP");
        }

        private void chargerCommentaires()
        {
            rtbCommentaires.ResetText();
            StringBuilder sb = new StringBuilder("\n");
            List<Commentaire> lesCommentaires = new List<Commentaire>();
            ConnecteurSQLCommentaire connection = new ConnecteurSQLCommentaire();
            lesCommentaires = connection.VoirCommentaires(labelFichierOriginalValeur.Text);

            // Append = ajoute, AppendLine = ajoute puis echappe
            foreach (Commentaire comm in lesCommentaires)
            {
                sb.AppendLine(comm.DateCreation.ToString());
                sb.Append(comm.Prenom + " ");
                sb.AppendLine(comm.Nom + ": ");
                sb.AppendLine(comm.Contenu);
                sb.Append("\n");
            }
            rtbCommentaires.Text = sb.ToString();
        }
        // Lorsque le nom de fichier change, charge les comm.
        private void labelFichierOriginalValeur_TextChanged(object sender, EventArgs e)
        {
            chargerCommentaires();
        }

        private void commenterMedia(string prenom, string nom, string details, string nomDeFichier, string contenuComm)
        {
            if (rtbCommenter.Text != "")
            {
                ConnecteurSQLCommentaire connection = new ConnecteurSQLCommentaire();
                connection.AjouterCommentaire(prenom, nom, details, contenuComm, nomDeFichier);
            }
        }

        private void btnCommenter_Click(object sender, EventArgs e)
        {
            if (Connexion.EstConnecté)
            {
                commenterMedia(Connexion.Prenom,
                    Connexion.Nom,
                     Connexion.Details,
                      labelFichierOriginalValeur.Text,
                       rtbCommenter.Text);
                chargerCommentaires();
            }
            else
            {
                MessageBox.Show("Action impossible, vous devez vous identifier");
            }

            rtbCommenter.Text = "";
        }

        private void labelNomMedia_Click(object sender, EventArgs e)
        {

        }
    }
}
