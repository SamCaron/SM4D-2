using SM4D2;
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
    // Écran d'accueil principal
    public partial class AccueilBorne : Form
    {
        private bool enInitialisation = true;
        private bool cacher = false;

        // définition des formulaires du niveau 1 
        BorneListePhotos formBLP;
        BorneMedia formBP;
        BorneParametres formParm;
        BorneListeCollections formColl;
        FenetreConnexion formConn;



        public AccueilBorne()
        {
            InitializeComponent();
            InitialiserFormulaire();
        }
        private void InitialiserFormulaire()
        {
            // Chargement des paramètres
            ConnecteurSQLCommun connecteur = new ConnecteurSQLCommun();
            connecteur.ChargerParametres();

            // définition des formulaires du niveau 1 
            formBLP = new BorneListePhotos();
            formBP = new BorneMedia();
            formParm = new BorneParametres();
            formColl = new BorneListeCollections();
            formConn = new FenetreConnexion();

            // boutons d'accès aux écrans du niveau 1 (bandeau de gauche)
            buttonMedias.Enabled = true;
            // buttonPersonnes.Enabled = false;
            buttonCollections.Enabled = true;
            //  buttonEvenements.Enabled = false;
            buttonReglages.Enabled = true;

            // Instanciation de l'Écran Liste des photos
            formBLP.TopLevel = false;
            formBLP.AutoScroll = true;
            formBLP.FormBorderStyle = FormBorderStyle.None;
            this.panelCentreNiveau1.Controls.Add(formBLP);

            // Instanciation de l'Écran d'affichage d'une photo
            formBP.TopLevel = false;
            formBP.AutoScroll = true;
            formBP.FormBorderStyle = FormBorderStyle.None;
            this.panelCentreNiveau1.Controls.Add(formBP);

            // Instanciation de l'Écran de paramètres
            formParm.TopLevel = false;
            formParm.AutoScroll = true;
            formParm.FormBorderStyle = FormBorderStyle.None;
            this.panelCentreNiveau1.Controls.Add(formParm);

            // Instanciation de l'Écran des collections
            formColl.TopLevel = false;
            formColl.AutoScroll = true;
            formColl.FormBorderStyle = FormBorderStyle.None;
            this.panelCentreNiveau1.Controls.Add(formColl);

            // Instanciation de l'écran de connexion
            formConn.TopLevel = false;
            formConn.AutoScroll = true;
            formConn.FormBorderStyle = FormBorderStyle.None;
            
            this.panelCentreNiveau1.Controls.Add(formConn);


            RafraichirFormulaire();
            enInitialisation = false;
        }


        private void RafraichirFormulaire()
        {
            this.lblUtilisateur.Text = Connexion.Prenom + " "
                + Connexion.Nom;
        }
        /*   private void linkLabelCacher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
           {
               if (cacher)
               {
                   cacher = false;
                   panelCentreNiveau1.Visible = true;

               }
               else
               {
                   cacher = true;
                   panelCentreNiveau1.Visible = false;

               }

           }*/
        // Bouton quitter application
        private void linkLabelQuitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        // Bouton Medias qui affichent par défault  la liste des images 
        //  On ajoute les 2 écrans et les contrôles permettront de basculer de la liste à l'écran de détails
        private void buttonMedias_Click(object sender, EventArgs e)
        {
            //this.panelCentreNiveau1.Controls.Add(formBLP);
            //     this.panelCentreNiveau1.Controls.Remove(formBLP);
            //this.panelCentreNiveau1.Controls.Add(formBP);
            //   formBLP.Show();
            basculer("BLP");
        }

        public void basculer(string ecran)
        {
            // fonction responsable de basculer d'une page à une autre 
            labelInstructions.Hide();
            formBLP.Hide();
            formBP.Hide();
            formParm.Hide();
            formColl.Hide();
            formConn.Hide();
            switch (ecran)
            {
                case "BLP":
                    formBLP.Show();
                    break;
                case "BP":
                    formBP.initialiserContexte();
                    formBP.Show();
                    break;
                case "BLC":
                    formColl.initialiserContexteSecurite();
                    formColl.Show();
                    break;
                case "Parm":
                    formParm.initialiserContexte();
                    formParm.Show();
                    break;
                case "Login":
                    formConn.Show();
                    
                    ConnecteurSQLCommun connecteur = new ConnecteurSQLCommun();
                    connecteur.ChargerParametres();
                    // labelInstructions.Show();

                    break;
                default: break;

            }

            RafraichirFormulaire();
        }
        public void BPContexte(Medias medium, List<int> listeIds)
        {
            formBP.contexte(medium, listeIds);
        }

        private void panelRubanGauche_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabelBascule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // basculer vers formulaire blanc

            basculer("");
        }

        private void buttonReglages_Click(object sender, EventArgs e)
        {


            using (Prompt prompt = new Prompt("Entrez le mot de passe administateur pour modifier les paramètres", "Accès restreint"))
            {
                string result = prompt.Result;
                if (result == Parametres.MotPasseAdmin)
                {
                    basculer("Parm");
                }
                else
                {
                    DialogResult confirmation = MessageBox.Show("Erreur de mot de passe, accès refusé!", "Accès refusé", MessageBoxButtons.OK);
                }
            }

            // GererDomaineValeurs ecran = new GererDomaineValeurs();
            // ecran.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // écran pour la saisie d'un mot de passe pour accéder aux parametres
        public class Prompt : IDisposable
        {
            private Form prompt { get; set; }
            public string Result { get; }

            public Prompt(string text, string caption)
            {
                Result = ShowDialog(text, caption);
            }
            //use a using statement
            private string ShowDialog(string text, string caption)
            {
                prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen,
                    TopMost = true
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Dock = DockStyle.Top, TextAlign = ContentAlignment.MiddleCenter };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }

            public void Dispose()
            {
                //See Marcus comment
                if (prompt != null)
                {
                    prompt.Dispose();
                }
            }
        }

        private void buttonPersonnes_Click(object sender, EventArgs e)
        {

        }

        private void buttonCollections_Click(object sender, EventArgs e)
        {
            basculer("BLC");
        }

        private void labelInstructions_Click(object sender, EventArgs e)
        {

        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            basculer("Login");
        }
    }
}
