using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SM4D2Librairie.Modeles
{
    public static class Parametres
    {
        /// <summary>
        /// Identifiant a 1 car 1 seul enregistrement dans BD
        /// </summary>
        public static int Id { get; set; } = 1;
        /// <summary>
        /// Chemin d'acces pour l'entreposage interne des Archives
        /// </summary>
        public static string EmplacementArchives { get; set; } = "";
        /// <summary>
        /// Chemin d'acces pour l'entreposage interne des Videos
        /// </summary>
       
        public static string TypeInstallation { get; set; } = "";
        /// <summary>
        /// Repertoire des domaines de valeurs
        /// </summary>
        /// 

        public static string MotPasseAdmin { get; set; } = "";
        /// <summary>
        /// Mot de passe admin
        /// </summary>
        /// 

        public static List<DomaineValeurs> Valeurs { get; set; } = new List<DomaineValeurs> { };
   
    }
}
