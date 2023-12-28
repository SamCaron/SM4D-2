using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2Librairie.Modeles
{
    /// <summary>
    /// Sujets de categorisation des media
    /// </summary>
    public class Sujets
    {
        /// <summary>
        /// Identifiant unique du sujet
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Nom du sujet
        /// </summary>
        public float? IdHiercharique = null;
        public int Niveau;
        public string Nom { get; set; } = "";
        /// <summary>
        /// Categorie generale du sujet.  Domaine de valeurs
        /// </summary>
        /// 

        public string Categorie { get; set; } = "";
        /// <summary>
        /// Description explicative du sujet
        /// </summary>
        public string Description { get; set; } = "";
        public DateTime DateHeureCreation { get; set; }
        public DateTime DateHeureModification { get; set; }
        public Utilisateurs UtilisateurCreation { get; set; }
        public Utilisateurs UtilisateurModification { get; set; }
        public string NomSujet
        { 
            get
            {
                return $"{Nom}";
            }
        }
    }
}
