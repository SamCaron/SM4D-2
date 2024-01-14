using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2Librairie.Modeles
{
    public class Commentaire
    {
        public int IdComm{ get; set; }
        public string Prenom { get; set; } = "";
        public string Nom { get; set; } = "";
        public string Details { get; set; } = "";
        public string Contenu { get; set; } = "";
        public DateTime DateCreation { get; set; }

    }
}
