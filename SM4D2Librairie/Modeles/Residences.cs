using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2Librairie.Modeles
{
    /// <summary>
    /// Lieu ou a reside une Personne a St-Marcel
    /// </summary>
    public class Residences
    {
        /// <summary>
        /// Personne objet de la Residence
        /// </summary>
        public Personnes Residant { get; set; }
        /// <summary>
        /// lieu objet de la Residence
        /// </summary>
        public Lieux Lieu { get; set; }
        /// <summary>
        /// Imprecision de Date de debut de la Residence en jours
        /// </summary>
        public int SpanDateDu { get; set; }
        /// <summary>
        /// Date de debut de la Residence
        /// </summary>
        public DateOnly DateDu { get; set; }
        /// <summary>
        /// Imprecision de Date de fin de la Residence en jours
        /// </summary>
        public int SpanDateAu { get; set; }
        /// <summary>
        /// Date de fin de la Residence
        /// </summary>
        public DateOnly DateAu { get; set; }
        /// <summary>
        /// Type de residence (Proprietaire, Residence Familiale, Loyer)
        /// </summary>
        public string Type { get; set; } = "";
        public DateTime DateHeureCreation { get; set; }
        public DateTime DateHeureModification { get; set; }
        public Utilisateurs UtilisateurCreation { get; set; }
        public Utilisateurs UtilisateurModification { get; set; }
    }
}
