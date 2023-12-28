using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using SM4D2Librairie.AccesDonnees;
using SM4D2Librairie.Modeles;
using System.Reflection.Metadata.Ecma335;
using System.Web;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace SM4D2Librairie
{
    public static class ConfigGlobale
    {
        public static ConnecteurSQLMedias Connection { get; set; } = new ConnecteurSQLMedias();
        // todo desactiver et mettre le bon code d'utilisateur
        public static int IdUtilisateur = 1;
        // todo alimenter la valeur par defaut a partir de parametre
        public static DateTime DatePriseDefaut = new DateTime(1950, 1, 1);
        // chemin par defaut pour ouvrir les images
        // toto parametrer ce repertoire
        public static string CheminImages = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        public static DateTime ANNEEDE = new DateTime(1800, 12, 31);

        public static  string StringConnection(string nom)
        {
            return ConfigurationManager.ConnectionStrings[nom].ConnectionString;

        }
        public static void InitialiseConnection()
        {
            Connection = new ConnecteurSQLMedias();
        }
        public static Utilisateurs UtilisateurCourant()
        {
            // todo remplacer par le vrai utilisateur
            return Utilisateurs.UtilisateurRichard();
        }
        // todo charger les tables de pilotages au début du programme pour éviter les acces repetes a BD 
        public static string EmplacementImages()
        {
            //todo connecter a la table ParametresSystems
            string emplacement =   "C:\\SM4D\\Archives\\Images\\";
            System.IO.Directory.CreateDirectory(emplacement);
            return emplacement;
        }
        // retourner une image "Non disponible"
        public static System.Drawing.Image ImageNonDisponible()
        {
            string imageND = ConfigGlobale.EmplacementImages() + "Nondefini.jpg" + "";
            System.Drawing.Image image = System.Drawing.Image.FromFile(imageND);
            return image;
        }
        // retourner le chemin une image "Non disponible"
        public static string ImageNonDisponiblePath()
        {
            return ConfigGlobale.EmplacementImages() + "Nondefini.jpg" + "";
        
        }

    }
}
