using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2Librairie.Modeles
{
    public class ParametresQuery
    {
    
        /// <summary>
        /// Identifiant a 1 car 1 seul enregistrement dans BD
        /// </summary>
        public  int Id { get; set; } = 1;
        /// <summary>
        /// Chemin d'acces pour l'entreposage interne des Archives
        /// </summary>
        public  string EmplacementArchives { get; set; } = "";
        /// <summary>
        /// Chemin d'acces pour l'entreposage interne des Videos
        /// </summary>

        public  string TypeInstallation { get; set; } = "";
        /// <summary>
        /// Type d'installation (Lecture ou Complet)
        /// </summary>
        /// 

        public  string MotPasseAdmin { get; set; } = "";
        /// <summary>
        /// Mot de passe admin
        /// </summary>
        /// 

  

    }
}
