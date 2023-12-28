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
    public class ConnecteurSQLPersonnes
    {



        /////////////////////////////////////////////////////////////////////////
        /// Personnes
        /// <summary>
        /// Retourne le nombre total d'entrees de Personnes dans la BD
        /// </summary>
        /// <returns>int</returns>
        public int ComptePersonnes()
        {
            int decompte = 0;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@compte", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPersonnes_Compte", p, commandType: CommandType.StoredProcedure);
                decompte = p.Get<int>("@compte");
                return decompte;

            }
        }
        public List<Personnes> RechercherPersonnes(string chaine)
        {
            List<Personnes> desPers;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();

                if (chaine.Length == 0)
                    p.Add("@Texte", (string?)null, dbType: DbType.String);
                else
                    p.Add("@Texte", chaine, dbType: DbType.String);

                desPers = connection.Query<Personnes>("dbo.spPersonnes_ListeSelection", p, commandType: CommandType.StoredProcedure).ToList();
            }
            foreach (Personnes p in desPers)
            {
                // todo obtenir Parent 1 et 2 si non null

                // photo de profil
                if (p.IdPhotoProfil > 0)
                {
                    ConnecteurSQLMedias connMed = new ConnecteurSQLMedias();
                    p.PhotoProfil = connMed.MediasGetById(p.IdPhotoProfil, false);
                }

                
                // todo coder RemplirObjets pour evenements
                // RemplirObjets(e);
            }

            return desPers;
        }
        public Personnes PersonneGetById(int Id)
        {
            {
                List<Personnes> liste;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", Id, dbType: DbType.Int32);

                    liste = connection.Query<Personnes>("dbo.spPersonnes_GetById", p, commandType: CommandType.StoredProcedure).ToList();
                }
                if (liste.Count > 0)
                {
                    return liste.First();
                }
                return null;
            }
        }
    }
}

