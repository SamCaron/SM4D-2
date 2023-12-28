using SM4D2Librairie.AccesDonnees;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using GoogleMaps;
using GoogleMaps.LocationServices;

namespace SM4D2Librairie.Modeles
{
    /// <summary>
    /// Lieu physique precis de St-Marcel ou general si exterieur a St-Marcel
    /// </summary>
    public class Lieux
    {
        /// <summary>
        /// Identifiant unique du media attribue automatiquement 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Code du Secteur sous forme de Domaine de Valeurs (Nordet, Suroit, Village...)
        /// </summary>
        public string CodeSecteur { get; set; } = "";
        /// <summary>
        /// Code de l'artere sous forme de Domaine de Valeurs (TacheEst, Rang7Ouest, Rte285Nord...)
        /// </summary>
        public string CodeRue { get; set; } = "";
        /// <summary>
        /// No Civique du lieu
        /// </summary>
        public int NoCivique { get; set; }
        /// <summary>
        /// No appartement ou Suite du lieu
        /// </summary>
        public string AppSuite { get; set; } = "";
        /// <summary>
        /// Nom descriptif si le Code de Secteur est Exterieur a St-Marcel.  Ex: St-Cyrille, Montréal...
        /// </summary>
        public string DescriptionAilleurs { get; set; } = "";
        /// <summary>
        /// Longitude du lieu
        /// </summary>
        public decimal Longitude { get; set; }
        /// <summary>
        /// Latitude du lieu
        /// </summary>
        public decimal Latitude { get; set; }
        /// <summary>
        /// Description et notes decrivant le Lieu
        /// </summary>
        public string Description { get; set; } = "";
        /// <summary>
        /// Lien vers le Media qui represente le mieux le Lieu
        /// </summary>
        public Medias PhotoLieu { get; set; }
        /// <summary>
        /// Indicateur Oui ou Non si des recherches sont necessaires pour le Media
        /// </summary>
        public bool IndicateurRecherches { get; set; } = true;
        /// <summary>
        /// Description des recherches et questionnements qui restent a repondre sur le Lieux
        /// </summary>
        public string NotesRecherches { get; set; } = "";
        public int AnneeConstruction { get; set; } = 0;
        public DateTime DateHeureCreation { get; set; } = System.DateTime.Now;
        public DateTime DateHeureModification { get; set; } = System.DateTime.Now;
        public Utilisateurs UtilisateurCreation { get; set; } = ConfigGlobale.UtilisateurCourant();
        public Utilisateurs UtilisateurModification { get; set; } = ConfigGlobale.UtilisateurCourant();
        public string AdresseComplete { get; set; }



        public Lieux()
        {
         
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Attributs calcules a partir des champs originaux (image de profil, signature string...)
        /// </summary>
        //  retourner la miniature en 50 x 50 pixels
        public System.Drawing.Image Miniature50
        {
            get
            {
                System.Drawing.Image image;
                if (PhotoLieu == null)
                {
                     image = System.Drawing.Image.FromFile(ConfigGlobale.EmplacementImages() + "Nondefini.png");
                }
                else
                {
                     image = System.Drawing.Image.FromFile(ConfigGlobale.EmplacementImages() + PhotoLieu.NomFichierSM4D);
                } 
                return image.GetThumbnailImage(50, 50, () => false, IntPtr.Zero);
            }
        }
        //  retourner la miniature en 150 x 150 pixels
        public System.Drawing.Image Miniature150
        {
            get
            {
                System.Drawing.Image image;
                if (PhotoLieu == null)
                {
                    image = System.Drawing.Image.FromFile(ConfigGlobale.EmplacementImages() + "Nondefini.png");
                }
                else
                {
                    image = System.Drawing.Image.FromFile(ConfigGlobale.EmplacementImages() + PhotoLieu.NomFichierSM4D);
                }
                return image.GetThumbnailImage(150, 150, () => false, IntPtr.Zero);
            }
        }
        public string Signature()
        {
            return NoCivique.ToString() + ", " + CodeRue + " " + CodeSecteur;
            //   return NoCivique.ToString() + ", " + Rue + " " + Secteur +  ;
        }


        public string Secteur
        {
            get
            {
                ConnecteurSQLCommun conn = new ConnecteurSQLCommun();
                DomaineValeurs pilote = conn.GetCodeValeur("Secteurs", this.CodeSecteur);
                return pilote.TrimValeur;
            }
            
        }
        public string Rue
        {
            get
            {
                ConnecteurSQLCommun conn = new ConnecteurSQLCommun();
                DomaineValeurs pilote = conn.GetCodeValeur("Artères", this.CodeRue);
                return pilote.TrimValeur;
            }

        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Attributs necessaires pour mapper les objets vs les Id de la BD 
        /// </summary>
        public int IdPhotoLieu { get; set; }

        public int IdUtilisateurCreation { get; set; }
        public int IdUtilisateurModification { get; set; }
        public void CalculerLongLat()
        {
            string adresse = NoCivique.ToString() + ", " + Rue + " St-Marcel, Québec G0R3R0";
            var serviceLocalisation = new GoogleLocationService();
            var point = serviceLocalisation.GetLatLongFromAddress(adresse);
            this.Longitude = (decimal) point.Longitude;
            this.Latitude =  (decimal) point.Latitude;
        }


      


    }

}
