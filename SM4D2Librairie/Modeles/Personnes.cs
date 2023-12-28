using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2Librairie.Modeles
{
    /// <summary>
    /// Personne ayant un lien avec St-Marcel
    /// </summary>
    public class Personnes
    {
        /// <summary>
        /// Identifiant unique de la personne attribue automatiquement 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nom de la Personne
        /// </summary>
        public string Nom { get; set; } = "";
        /// <summary>
        /// Prenom de la personne
        /// </summary>
        public string Prenom { get; set; } = "";
        /// <summary>
        /// Autres prenoms de la personne
        /// </summary>
        public string AutresPrenoms { get; set; } = "";
        /// <summary>
        /// Annee de Naissance
        /// </summary>
        public int AnneeNaissance { get; set; }
        /// <summary>
        /// Imprecision de l'annee de Naissance en nombre d'annees.  0 si l'annee est precise
        /// </summary>
        public int SpanDateNaissance { get; set; }
        /// <summary>
        /// Indicateur Oui/Non si la Personne est decedee
        /// </summary>
        public bool IndicateurDeces { get; set; }

        /// <summary>
        /// Date de déces
        /// </summary>
        public DateOnly DateDeces { get; set; }
        /// <summary>
        /// Imprecision de la date de décès en nombre de jours.  0 si l'annee est precise
        /// </summary>
        public int SpanDateDeces { get; set; }
        /// <summary>
        /// Genre de la Personne.  Code de domaine de valeurs
        /// </summary>
        /// 
        public string Genre { get; set; } = "";
        /// <summary>
        /// Notes biographiques sur la personne
        /// </summary>
        public string Biographie { get; set; } = "";
        /// <summary>
        /// Indicateur Oui ou Non si des recherches sont necessaires pour la personne
        /// </summary>
        public bool IndicateurRecherches { get; set; }
        /// <summary>
        /// Description des recherches et questionnements qui restent a repondre sur la Personne
        /// </summary>
        public string NotesRecherches { get; set; } = "";
        /// <summary>
        /// Lien vers la premiere Personne parent (typiquement Pere)
        /// </summary>
        /// 
        public int IdParent1 { get; set; }
        public Personnes Parent1 { get; set; }
        /// <summary>
        /// Lien vers la deuxieme PerIsonne parent (typiquement Mere))
        /// </summary>
        /// 
        public  int IdParent2 { get; set; }
        public Personnes Parent2 { get; set; }
        /// <summary>
        /// Lien vers la photo de profil de la Personne
        /// </summary>
        /// 
        public int IdPhotoProfil { get; set; }
        public Medias PhotoProfil { get; set; }
        public DateTime DateHeureCreation { get; set; }
        public DateTime DateHeureModification { get; set; }
        public int IdUtilisateurCreation { get; set; }
        public Utilisateurs UtilisateurCreation { get; set; }
        public int IdUtilisateurModification { get; set; }
        public Utilisateurs UtilisateurModification { get; set; }
        /// <summary>
        /// Liste des residences de la personne a St-Marcel
        /// </summary>
        public List<Residences> ResidencesPersonne { get; set; } = new List<Residences>();
        /// <summary>
        /// Liste des unions de la Personne
        /// </summary>
        public List<Unions> UnionsPersonne { get; set; } = new List<Unions>();
        public string NomComplet
        {
            get
            {
                if (AutresPrenoms.Length > 0)
                {
                    return $"{Prenom} {AutresPrenoms} {Nom} {AnneeNaissance.ToString()}";
                }
                else
                {
                    return $"{Prenom} {Nom} {AnneeNaissance.ToString()}";
                }
            }
        }

        /// </summary>
        //  retourner la miniature en 50 x 50 pixels
        public System.Drawing.Image Miniature50
        {
            get
            {
                System.Drawing.Image image;
                if (this.PhotoProfil == null)
                {
                    image = System.Drawing.Image.FromFile(ConfigGlobale.EmplacementImages() + "Nondefini.png");
                }
                else
                {
                    image = System.Drawing.Image.FromFile(ConfigGlobale.EmplacementImages() + PhotoProfil.NomFichierSM4D);
                }
                return image.GetThumbnailImage(50, 50, () => false, IntPtr.Zero);
            }
        }
    }
}
