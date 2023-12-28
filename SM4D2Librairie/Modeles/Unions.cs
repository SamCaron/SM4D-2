using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2Librairie.Modeles
{
    /// <summary>
    /// Union d'une Personne a une autre
    /// </summary>
    public class Unions
    {
        /// <summary>
        /// Lien vers la Personne 1, typiquement Mari
        /// </summary>
        public Personnes Conjoint1 { get; set; }
        /// <summary>
        /// Lien vers la Personne 2, typiquement Femme
        /// </summary>
        public Personnes Conjoint2 { get; set; }
        /// <summary>
        /// Date de début de l'union, typiquement Mariage
        /// </summary>
        public DateOnly DateDu { get; set; }
        /// <summary>
        /// Imprecision de Date de debut de l'union en jours
        /// </summary>
        public int SpanDateDu { get; set; }
        /// <summary>
        /// Date de fin de l'union si connue, typiquement Divorce 
        /// </summary>
        public DateOnly DateAu { get; set; }

        ///         /// <summary>
        /// Imprecision de Date de fin de l'union en jours
        /// </summary>
        public int SpanDateAu { get; set; }
        /// <summary>
        /// Type d'union.  Mariage ou Union libre
        /// </summary>
        public string Type { get; set; } = "";
        /// <summary>
        /// Lieu du Mariage
        /// </summary>
        public Lieux LieuUnion { get; set; }
        public DateTime DateHeureCreation { get; set; }
        public DateTime DateHeureModification { get; set; }
        public Utilisateurs UtilisateurCreation { get; set; }
        public Utilisateurs UtilisateurModification { get; set; }
    }
}
