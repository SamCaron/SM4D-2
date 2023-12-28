using SM4D2Librairie.AccesDonnees;
using SM4D2Librairie.Modeles;
namespace SM4D_2

{

    public partial class Accueil : Form

    {

        private GererMedia ecranGererMedia;
        public Accueil()
        {
            InitializeComponent();

        }
        private void RafraichirCompteurs()
        {
            ConnecteurSQLMedias connection = new ConnecteurSQLMedias();
            labelNombreMediasValeur.Text = connection.CompteMedias().ToString();
            ConnecteurSQLPersonnes connPers = new ConnecteurSQLPersonnes();
            labelNombrePersonnesValeur.Text = connPers.ComptePersonnes().ToString();
            ConnecteurSQLEvenements connEven = new ConnecteurSQLEvenements();
            labelNombreEvenementsValeur.Text = connEven.CompteEvenements().ToString();
            ConnecteurSQLLieux connLieux = new ConnecteurSQLLieux();
            labelNombreLieuxValeur.Text = connLieux.CompteLieux().ToString();
            ConnecteurSQLCommun connComm = new ConnecteurSQLCommun();
            labelNombreLacunesValeur.Text = connComm.CompteLacunes().ToString();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            this.RafraichirCompteurs();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnecteurSQLMedias connection = new ConnecteurSQLMedias();

            List<Medias> medias = connection.MediasGetFirst9();
            ListeMedias ecran = new ListeMedias(medias);
            ecran.ShowDialog();
            this.RafraichirCompteurs();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void linkLabelQuitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabelAccueil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.RafraichirCompteurs();
        }

        private void labelNombreLieuxValeurs_Click(object sender, EventArgs e)
        {

        }

        private void buttonReglages_Click(object sender, EventArgs e)
        {

            GererDomaineValeurs ecran = new GererDomaineValeurs();
            ecran.ShowDialog();

        }

        private void buttonLacunes_Click(object sender, EventArgs e)
        {
            // todo Brancher au bon calcul
        }

        private void buttonLieux_Click(object sender, EventArgs e)
        {
            ConnecteurSQLMedias connection = new ConnecteurSQLMedias();

            //List<Lieux> lieux = connection.MediasGetFirst9();
            ListeLieux ecran = new ListeLieux();
            ecran.ShowDialog();
            this.RafraichirCompteurs();
        }

        private void buttonPersonnes_Click(object sender, EventArgs e)
        {
            AccueilBorne ecran = new AccueilBorne();
            ecran.Show();

        }
    }
}