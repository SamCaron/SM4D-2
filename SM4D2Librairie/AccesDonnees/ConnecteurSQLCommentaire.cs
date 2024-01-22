using Dapper;
using SM4D2Librairie.Modeles;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2Librairie.AccesDonnees
{
    public class ConnecteurSQLCommentaire
    {
        public List<Commentaire> VoirCommentaires(string nomFichier)
        {
            List<Commentaire> desCommentaires = new List<Commentaire>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@NomFichier", nomFichier, dbType: DbType.String);
                desCommentaires = connection.Query<Commentaire>("spCommentaires_GetCommentaireDuMedia", p, 
                    commandType: CommandType.StoredProcedure).ToList();
            }
            return desCommentaires;
        }

        public void AjouterCommentaire(string prenom, string nom, string details,
            string contenu, string nomFichier)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();

                p.Add("@Prenom", prenom, dbType: DbType.String);
                p.Add("@Nom", nom, dbType: DbType.String);
                p.Add("@Details", details, dbType: DbType.String);
                p.Add("@Contenu", contenu, dbType: DbType.String);
                p.Add("@NomDeFichier", nomFichier, dbType: DbType.String);

                connection.Query<Medias>("spCommentaires_Ajouter", p, 
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
