using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2
{
    public static class Connexion
    {
        public static string Prenom = "";
        public static string Nom = "";
        public static string Details = "";
        public static bool EstConnecté = false;

        public static void setConnexion(string p_Prenom, string p_Nom, string p_Details)
        {
            Prenom = p_Prenom;
            Nom = p_Nom;
            Details = p_Details;
            EstConnecté = true;
        }

        public static void resetConnexion()
        {
            Prenom = "";
            Nom = "";
            Details = "";
            EstConnecté= false;
        }
    }
}
