using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2Librairie.Modeles
{
    /// <summary>
    /// Tags (comme les #tags) sur un Media qui categorise le Media selon des Sujets
    /// </summary>
    public class Etiquettes
    {
        /// <summary>
        /// 
     
        /// Media sur lequel s'applique l'etiquette
        /// </summary>
        public Medias Media { get; set; }
        public int IdMedia { get; set; }
        /// <summary>
        /// Sujet applicable sur le Media
        /// </summary>
        public Sujets Sujet { get; set; }
        public string IdSujet { get; set; }
        /// <summary>
        /// Notes supplementaire associees a l'etiquette
        /// </summary>
        public string Notes { get; set; } = "";
        public DateTime DateHeureCreation { get; set; }
        public DateTime DateHeureModification { get; set; }
        public Utilisateurs UtilisateurCreation { get; set; }
        public Utilisateurs UtilisateurModification { get; set; }
        public string NomSujet
        {
            get
            {
                return $"{this.Sujet.Nom}";
            }
        }
        public Etiquettes() { }
        public Etiquettes(Medias media, Sujets sujet, string notes)
        {
            Media = media;

            Sujet = sujet;
            IdSujet = sujet.Id;
            Notes = notes;
            DateHeureCreation = DateTime.Now;
            DateHeureModification = DateTime.Now;
            UtilisateurCreation = ConfigGlobale.UtilisateurCourant();
            UtilisateurModification = ConfigGlobale.UtilisateurCourant();

        }
    }
}
