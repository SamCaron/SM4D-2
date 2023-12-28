using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM4D2Librairie;
using SM4D2Librairie.Modeles;
using System.Security.Policy;
using System.Web;

namespace SM4D2Librairie.AccesDonnees
{
    public class ConnecteurSQLEvenements
    {
        ////////////////////////////////////////////////////////////////
        /// Evenements
        /// <summary>
        /// Retourne le nombre total d'entrees de Evenements la BD
        /// </summary>
        /// <returns>int</returns>
        public int CompteEvenements()
        {
            int decompte = 0;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@compte", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spEvenements_Compte", p, commandType: CommandType.StoredProcedure);
                decompte = p.Get<int>("@compte");
                return decompte;

            }
        }
        public Evenements EvenementsGetById(int Id)
        {
            {
                List<Evenements> liste;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", Id, dbType: DbType.Int32);

                    liste = connection.Query<Evenements>("dbo.spEvenements_GetById", p, commandType: CommandType.StoredProcedure).ToList();
                }
                if (liste.Count > 0)
                {
                    return liste.First();
                }
                return null;
            }
        }
        public List<Evenements> RechercherEvenements(string chaine)
        {
            List<Evenements> desEvens;
            string requete = "Select * from dbo.Evenements ";
            string tri = " Order By NomEvenement ASC ;";
            string filtre = " Where NomEvenement = NomEvenement";
            if (chaine.Length > 0)
            {
                foreach (string e in chaine.Split())
                {
                    filtre += " AND NomEvenement like '%" + e + "%' ";
                }
            }

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                desEvens = connection.Query<Evenements>(requete + filtre + tri).ToList();
            }
            foreach (Evenements e in desEvens)
            {
                // todo coder RemplirObjets pour evenements
               // RemplirObjets(e);
            }

            return desEvens;
        }
    }
}

