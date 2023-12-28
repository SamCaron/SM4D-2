using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2Librairie.Modeles
{
    /// <summary>
    /// Presence de personne sur un Media
    /// </summary>
    public class Presences
    {
        // Id BD de la Personne
        public int IdPersonne { get; set; }
        /// <summary>
        /// Lien de la Personne qui apparait sur le Media
        /// </summary>
        public Personnes Personne { get; set; }
        // Id BD du Media
        public int IdMedia { get; set; }
        /// <summary>
        /// Lien du Media ou apparait la Personne
        /// </summary>
        public Medias Media { get; set; }
        /// <summary>
        /// Coordonnees X superieur gauche
        /// </summary>
        public float ImageX1 { get; set; }
        /// <summary>
        /// Coordonnees X inferieur droit
        /// </summary>
        public float ImageX2 { get; set; }
        /// <summary>
        /// Coordonnees Y superieur gauche
        /// </summary>
        public float ImageY1 { get; set; }
        /// <summary>
        /// Coordonnees Y inferieur droit 
        /// </summary>
        public float ImageY2 { get; set; }
        /// <summary>
        /// No de la page du document ou est reference la Personne
        /// </summary>
        public int DocumentPage { get; set; }
        /// <summary>
        /// No du paragraphe du document ou est reference la Personne
        /// </summary>
        public int DocumentParagraphe { get; set; }
        /// <summary>
        /// Debut du video ou apparait la Personne en secondes
        /// </summary>
        public int VideoTempsDebut { get; set; }
        public DateTime DateHeureCreation { get; set; }
        public DateTime DateHeureModification { get; set; }
        public Utilisateurs UtilisateurCreation { get; set; }
        public Utilisateurs UtilisateurModification { get; set; }
        public Presences() { }
        public Presences(Personnes personne, Medias medias, float x1, float x2, float y1, float y2, int page, int paragraphe, int debut) 
        {
           Personne = personne;
            Media = medias;
            ImageX1 = x1;
            ImageX2 = x2;
            ImageY1 = y1;
            ImageY2 = y2;
            DocumentPage = page;
            DocumentParagraphe = paragraphe;
            VideoTempsDebut = debut;
            DateHeureCreation = DateTime.Now;
            DateHeureModification = DateTime.Now;
            UtilisateurCreation = ConfigGlobale.UtilisateurCourant();
            UtilisateurModification = ConfigGlobale.UtilisateurCourant();

        }
        public Presences(Personnes personne, Medias medias)
        {
            Personne = personne;
            Media = medias;

            DateHeureCreation = DateTime.Now;
            DateHeureModification = DateTime.Now;
            UtilisateurCreation = ConfigGlobale.UtilisateurCourant();
            UtilisateurModification = ConfigGlobale.UtilisateurCourant();

        }
        // retourner la signature
        public override string ToString()
        {
            return Personne.NomComplet;
        }

    }
}
