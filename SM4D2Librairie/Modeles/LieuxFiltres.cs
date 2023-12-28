using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2Librairie.Modeles
{
    public class LieuxFiltres
    {
        /// <summary>
        /// critere sur le Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Critere sur le Secteur
        /// </summary>
        public string Secteur { get; set; } = "";
        /// <summary>
        /// criter sur Rue
        /// </summary>
        // todo implanter critere et domaines TypeMedia
        public string Rue { get; set; } = "";
        /// <summary>
        /// criter sur no civique
        /// </summary>
        public string NoCivique { get; set; } = "";
        /// <summary>
        /// critere sur les champs Descriptifs
        /// </summary>
        public string Texte { get; set; } = "";
        /// <summary>
        /// Critere d'indicateurs de Recherches 
        /// </summary>
        public string IndicateurRecherches { get; set; }
        /// <summary>
        /// Critere sur le début de la date de creation
        /// </summary>
        public DateTime DateHeureCreationDebut { get; set; }
        /// <summary>
        /// Critere sur la fin de la date de creation
        /// </summary>
        public DateTime DateHeureCreationFin { get; set; }
        /// <summary>
        /// Critere sur le début de la date de modification
        /// </summary>
        public DateTime DateHeureModificationDebut { get; set; }
        /// <summary>
        /// Critere sur la fin de la date de modification
        /// </summary>
        public DateTime DateHeureModificationFin { get; set; }


        public LieuxFiltres()
        {
            DateHeureCreationDebut = new DateTime(2023, 01, 01);
            DateHeureModificationDebut = new DateTime(2023, 01, 01);
            DateHeureModificationFin = DateTime.Now;
            DateHeureCreationFin = DateTime.Now;


        }
    }
}
