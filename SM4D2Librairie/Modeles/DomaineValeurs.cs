using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2Librairie.Modeles
{
    /// <summary>
    /// Valeurs de domaines utilisees dans l'application
    /// </summary>
    public class DomaineValeurs
    {
        /// <summary>
        /// Categories de la Valeur, ex: Secteurs, Rues, Genres, Fichiers, Medias
        /// </summary>
        public string Categorie { get; set; } = "";
        /// <summary>
        /// Code de la Valeur, ex: Nordet, Rte285N , Masculin, JPG, Photos
        /// </summary>
        public string Code { get; set; } = "";
        /// <summary>
        /// Valeur du domaine qui est affichee, ex: Nordet, Routte 285 Nord , Masculin, JPG, Photos
        /// </summary>
        public string Valeur { get; set; } = "";
        public DateTime DateHeureCreation { get; set; }
        public DateTime DateHeureModification { get; set; }
        public Utilisateurs UtilisateurCreation { get; set; }
        public Utilisateurs UtilisateurModification { get; set; }
        // retourner la concatenation du code et de la valeur
        public string CodeValeur
        {
            get
            {
                return Code + " - " + Valeur;
            }
        }
        public string TrimValeur
        {
            get
            {
                return Valeur.TrimEnd();
            }
        }
        public DomaineValeurs()
        {
  

        }
        public DomaineValeurs(string categorie, string code, string valeur)
        {
            Categorie = categorie;
            Code = code;
            Valeur= valeur;

        }
    }
}
