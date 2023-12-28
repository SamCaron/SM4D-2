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
using System.Reflection;

namespace SM4D2Librairie.AccesDonnees
{
    public class ConnecteurSQLCommun
    {
        ///////////////////////////////////////////////////////////
        /// LACUNES
        /// <summary>
        /// Retourne le nombre total d'entrees des 4 entites dans la BD qui ont des indicateurs de recherche a Oui 
        /// </summary>
        /// <returns>int</returns>
        public int CompteLacunes()
        {
            int decompte = 0;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@compte", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spLacunes_Compte", p, commandType: CommandType.StoredProcedure);
                decompte = p.Get<int>("@compte");
                return decompte;

            }
        }

        /// ////////////////////////////////////////////////////////////////////////
        /// UTILISATEURS
        /// <summary>
        /// Retourne la liste des utilisateurs
        /// todo retirer stub richard et retourner vrai valeur de l'utilisateur courant
        /// </summary>
        /// <returns></returns>

        public Utilisateurs UtilisateurCourant()
        {
            return Utilisateurs.UtilisateurRichard();
        }
        // retourne l'information de l'utilisateur associé à Id
        public Utilisateurs UtilisateursGetById(int Id)
        {
            {
                List<Utilisateurs> liste;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", Id, dbType: DbType.Int32);

                    liste = connection.Query<Utilisateurs>("dbo.spUtilisateurs_GetById", p, commandType: CommandType.StoredProcedure).ToList();
                }
                if (liste.Count > 0)
                {
                    return liste.First();
                }
                return null;
            }
        }
        //////////////////////////////////////////////////////////////////////
        /// PARAMETRES
        /// <summary>
        /// Retourne l'ensemble des valeurs (domaine) pour une categorie.  Le Domaine Categorie a lui-meme son domaine de valeur qui sont toutes les categories du systeme
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<DomaineValeurs> DomainesGetDomaineByCategorie(string Categorie)
        {
            {
                List<DomaineValeurs> liste;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
                {
                    var p = new DynamicParameters();
                    p.Add("@Categorie", Categorie, dbType: DbType.String);

                    liste = connection.Query<DomaineValeurs>("dbo.spDomaines_GetByCategory", p, commandType: CommandType.StoredProcedure).ToList();
                }
   

                return liste;
            }
        }
        // Retourne toutes les catégories dans la bd
        public List<string> DomainesGetAllCategories()
        {
            {
                List<string> liste;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
                {


                    liste = connection.Query<string>("dbo.spDomaines_GetAllCategories", commandType: CommandType.StoredProcedure).ToList();
                }

                return liste;
            }
        }
        // retourne la valeur associée au code de la catégorie
        public DomaineValeurs GetCodeValeur(string categorie, string code)
        {
            {
                List<DomaineValeurs> liste;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
                {
                    var p = new DynamicParameters();
                    p.Add("@Categorie", categorie, dbType: DbType.String);
                    p.Add("@Code", code, dbType: DbType.String);


                    liste = connection.Query<DomaineValeurs>("dbo.spDomaines_GetByCategoryCode", p, commandType: CommandType.StoredProcedure).ToList();
                }
                if (liste.Count == 0)
                {
                    return (new DomaineValeurs("Secteurs", "S.O.", "Sans objet"));
                }

                return liste[0];
            }
        }
        // Retourne booleen si le code+valeur existe 
        public bool CodeValeurExiste(string categorie, string code)
        {
            {
                List<string> liste;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
                {
                    var p = new DynamicParameters();
                    p.Add("@Categorie", categorie, dbType: DbType.String);
                    p.Add("@Code", code, dbType: DbType.String);


                    liste = connection.Query<string>("dbo.spDomaines_GetByCategoryCode", p, commandType: CommandType.StoredProcedure).ToList();
                }
                if (liste.Count > 0) { return true; }

                return false;
            }
        }
        // Creation BD d'un nouveau domaine de valeurs
        public void DomaineCreer(string categorie, string code, string valeur)
        {
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
                {
                    var p = new DynamicParameters();
                    p.Add("@Categorie", categorie, dbType: DbType.String);
                    p.Add("@Code", code, dbType: DbType.String);
                    p.Add("@Valeur", valeur, dbType: DbType.String);
                    p.Add("@DateCreation", DateTime.Now, dbType: DbType.DateTime2);
                    p.Add("@UtilCreation", ConfigGlobale.UtilisateurCourant().Id, dbType: DbType.Int32);


                    connection.Query<string>("dbo.spDomaines_Creer", p, commandType: CommandType.StoredProcedure).ToList();
                }

            }
        }
        // Modification BD de la valeur d'un code 
        public void DomaineModifier(string categorie, string code, string valeur)
        {
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
                {
                    var p = new DynamicParameters();
                    p.Add("@Categorie", categorie, dbType: DbType.String);
                    p.Add("@Code", code, dbType: DbType.String);
                    p.Add("@Valeur", valeur, dbType: DbType.String);
                    p.Add("@DateModif", DateTime.Now, dbType: DbType.DateTime2);
                    p.Add("@UtilModif", ConfigGlobale.UtilisateurCourant().Id, dbType: DbType.Int32);

                    connection.Query<string>("dbo.spDomaines_Modifier", p, commandType: CommandType.StoredProcedure).ToList();
                }

            }
        }
        // suppression d'un code valeur d'un domaine de valeur
        public void DomaineSupprimer(string categorie, string code)
        {
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
                {
                    var p = new DynamicParameters();
                    p.Add("@Categorie", categorie, dbType: DbType.String);
                    p.Add("@Code", code, dbType: DbType.String);

                    connection.Query<string>("dbo.spDomaines_Supprimer", p, commandType: CommandType.StoredProcedure).ToList();
                }

            }
        }
        // Retourne les valeurs des paramètres systeme
        public void  ChargerParametres()
        {
            List<ParametresQuery> liste;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@Id", 1, dbType: DbType.Int32);

               liste= connection.Query<ParametresQuery>("dbo.spParametres_Get", p, commandType: CommandType.StoredProcedure).ToList();
            }
            if (liste.Count == 1)
            {
                Parametres.TypeInstallation = liste[0].TypeInstallation.Trim();
                Parametres.EmplacementArchives = liste[0].EmplacementArchives.Trim();
                Parametres.MotPasseAdmin = liste[0].MotPasseAdmin.Trim();
            }
            else
            {
                
            }

        }
        // Modifie les valeurs des paramètres systeme
        public void ModifierParametres(string typeInst, string emplArch)
        {
           
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@Id", 1, dbType: DbType.Int32);
                p.Add("@Installation", typeInst, dbType:DbType.String );
                p.Add("@Emplacement", emplArch, dbType: DbType.String);


                connection.Query<string>("dbo.spParametres_Modifier", p, commandType: CommandType.StoredProcedure).ToList();
            }


        }
        //////////////////////////////////////////////////////////////////////////////////////////
        /// Sujets
        /// 
        public List<Sujets> RechercherSujets(string chaine, bool indDetailles)
        {
            List<Sujets> desSujets;
            string requete = "Select * from dbo.Sujets ";
            string tri = " Order By Niveau ASC, IdHiercharique ASC ;";
            string filtre = " Where Nom = Nom ";
            if (!indDetailles) { filtre += " AND Niveau = 1 "; }
            if (chaine.Length > 0)
            {
                foreach (string e in chaine.Split())
                {
                    filtre += " AND (" +
                        "(Categorie like '%" + e + "%') OR " +
                                     "(Nom like '%" + e + "%'))";
                }
            }

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                desSujets = connection.Query<Sujets>(requete + filtre + tri).ToList();
            }
            foreach (Sujets s in desSujets)
            {

                // todo coder RemplirObjets pour sujets si necessaire
                // RemplirObjets(e);
            }

            return desSujets;
        }
        public Sujets SujetsGetById(string Id)
        {
            {
                List<Sujets> liste;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", Id, dbType: DbType.String);

                    liste = connection.Query<Sujets>("dbo.spSujets_GetById", p, commandType: CommandType.StoredProcedure).ToList();
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

