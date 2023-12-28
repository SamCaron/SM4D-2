using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2Librairie.Modeles
{
    /// <summary>
    /// Utilisateur du systeme
    /// </summary>
    public class Utilisateurs
    {
        /// <summary>
        /// Identifiant unique 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// code de login de l'utilisateur
        /// </summary>
        public string Login { get; set; } = "";
        /// <summary>
        /// Mot de passe de l'utilisateur
        /// </summary>
        public string Password { get; set; } = "";
        /// <summary>
        /// Adresse courriel de l'utilisateur
        /// </summary>
        public string Email { get; set; } = "";   
        /// <summary>
        /// Identifiant du dossier de la Personne associee a l'utilisateur
        /// </summary>
        public int NoPersonne { get; set; }
        /// <summary>
        /// Role de securite de l'utilisateur
        /// </summary>
        public string Role { get; set; } = "";
        public DateTime DateHeureCreation { get; set; }
        public DateTime DateHeureModification { get; set; }
        public Utilisateurs UtilisateurCreation { get; set; }
        public Utilisateurs UtilisateurModification { get; set; }
        // todo retirer cet utilisateur bidon
        public static Utilisateurs UtilisateurRichard()
        {
            Utilisateurs uc = new Utilisateurs();
            uc.Id = 1;
            uc.Login = "Richard";
            uc.Password = "rca12345";
            return uc;
        }
    }
}
