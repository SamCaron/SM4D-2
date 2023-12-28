using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2Librairie.Modeles
{
    /// <summary>
    /// Evenements survenus a St-Marcel
    /// </summary>
    public class Evenements
    {
        /// <summary>
        /// Identifiant unique de l'evenement attribue par le systeme
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Date de l'evenement.  Si dure plus d'une journee, contient la date de debut
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Duree en jours de l'evenement
        /// </summary>
        public int DureeJours { get; set; }
        /// <summary>
        /// Nom descriptif de l'evenement
        /// </summary>
        public string NomEvenement { get; set; } = "";
        /// <summary>
        /// Description de l'evenement
        /// </summary>
        public string Description { get; set; } = "";
        /// <summary>
        /// Lieu ou l'evenement s'est tenu
        /// </summary>
        public Lieux LieuEvenement { get; set; }
        /// <summary>
        /// Media qui représente levenement s'est tenu
        /// </summary>
        public Evenements EvenementLie { get; set; }    
        /// <summary>
        /// Indicateur Oui ou Non si des recherches sont necessaires pour le Media
        /// </summary>
        ///         /// 
        public Medias MediaEvenement { get; set; }
        /// <summary>
        /// Evenement principal (parent) auquel est associe ce sous-evenement
        /// </summary>

   
        public bool indicateurRecherches { get; set; }
        /// <summary>
        /// Description des recherches et questionnements qui restent a repondre sur l'evenement
        /// </summary>
        /// 
 
        public string NotesRecherches { get; set; } = "";
        public DateTime DateHeureCreation { get; set; }
        public DateTime DateHeureModification { get; set; }
        public Utilisateurs UtilisateurCreation { get; set; }
        public Utilisateurs UtilisateurModification { get; set; }
        public override string ToString()
        {
            return Date.ToString() + " " + NomEvenement;
        }


    }
}
