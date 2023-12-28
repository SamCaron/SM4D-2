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
    public partial class BorneParametres : Form
    {
        private System.Windows.Forms.FolderBrowserDialog folderDialogEmplacement = new FolderBrowserDialog();
        private List<DomaineValeurs> installations;
        public BorneParametres()
        {
            InitializeComponent();
            initialiserContexte();
        }
        public void initialiserContexte()
        {
            ConnecteurSQLCommun connecteur = new ConnecteurSQLCommun();
            connecteur.ChargerParametres();
            linkLabelEmplacement.Text = Parametres.EmplacementArchives;
            ConnecteurSQLCommun connection = new ConnecteurSQLCommun();
            installations = connection.DomainesGetDomaineByCategorie("Installation");
            comboBoxTypeInstallation.DataSource = installations;
            comboBoxTypeInstallation.DisplayMember = "TrimValeur";
            comboBoxTypeInstallation.SelectedItem = installations.Find(i => i.Code.Trim() == Parametres.TypeInstallation.Trim());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelEmplacement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (folderDialogEmplacement.ShowDialog() == DialogResult.OK)
            {
                linkLabelEmplacement.Text = folderDialogEmplacement.SelectedPath.ToString();

            }
        }

        private void linkLabelGererDomaines_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GererDomaineValeurs ecran = new GererDomaineValeurs();
            ecran.ShowDialog();
        }

        private void buttonDomaines_Click(object sender, EventArgs e)
        {
            ConnecteurSQLCommun connecteur = new ConnecteurSQLCommun();
            connecteur.ModifierParametres(((DomaineValeurs)(comboBoxTypeInstallation.SelectedItem)).Code.Trim(), linkLabelEmplacement.Text);
            Parametres.TypeInstallation = ((DomaineValeurs)(comboBoxTypeInstallation.SelectedItem)).Code.Trim();
            Parametres.EmplacementArchives = linkLabelEmplacement.Text;
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
