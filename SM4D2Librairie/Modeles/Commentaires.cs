using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2Librairie.Modeles
{
    /// <summary>
    /// Commentaires fournis par les utilisateurs durant le visionnement des archives
    /// </summary>
    public class Commentaires
    {
        /// <summary>
        /// Timestamp du commentaire
        /// </summary>
        public DateTime DateHeureCreation { get; set; }
        /// <summary>
        /// Nom fourni par le commentateur
        /// </summary>
        public string NomCorrespondant { get; set; } = "";
        /// <summary>
        /// Lien vers le dossier utilisateur si le commentateur est autentifié
        /// </summary>
        public Utilisateurs Utilisateur { get; set; }
        /// <summary>
        /// Courriel fourni par le commentateur
        /// </summary>
        public string Courriel { get; set; } = "";
        /// <summary>
        /// No Telephone fourni par le commentateur
        /// </summary>
        public string Telephone { get; set; } = "";
        /// <summary>
        /// Nom de la classe de l'objet commente
        /// </summary>
        public string TypeObjet { get; set; } = "";
        /// <summary>
        /// No d'identifiant de l'objet commente
        /// </summary>
        public int  IdObjet { get; set; }

    }
}
