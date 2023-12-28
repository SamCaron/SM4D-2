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
    public class ConnecteurSQLLieux
    {
 
        ////////////////////////////////////////////////////////////
        /// Lieux
        /// <summary>
        /// Retourne le nombre total d'entrees de Lieux la BD
        /// </summary>
        /// <returns>int</returns>
        public int CompteLieux()
        {
            int decompte = 0;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@compte", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spLieux_Compte", p, commandType: CommandType.StoredProcedure);
                decompte = p.Get<int>("@compte");
                return decompte;

            }
        }
        public Lieux LieuxGetById(int Id)
        {
            {
                List<Lieux> liste;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", Id, dbType: DbType.Int32);

                    liste = connection.Query<Lieux>("dbo.spLieux_GetById", p, commandType: CommandType.StoredProcedure).ToList();
                }
                if (liste.Count > 0)
                {
                    return liste.First();
                }
                return null;
            }
        }
        public void LieuxSupprimer(int idLieu)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@Id", idLieu, dbType: DbType.Int32);
                connection.Execute("dbo.spLieux_Supprimer", p, commandType: CommandType.StoredProcedure);

            }
        }
        public List<Lieux> LieuxGetFiltresTri(LieuxFiltres filtresLieux, string[,] entetes, int pageCourante, int nbParPage, out int nbPages, out int nbTotalFiltre)
        {
            List<Lieux> desLieux;
            string tri = "";
            int nbTotal = 0;


            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                // calculer le nombre des lieux qui matchent et le nombre de pages
                var p = new DynamicParameters();
                p.Add("@Compte", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                if (filtresLieux.Texte.Length ==0)
                    p.Add("@Texte", (string?) null, dbType: DbType.String);
                else
                    p.Add("@Texte", filtresLieux.Texte, dbType: DbType.String);
                p.Add("@DateCreaDe", filtresLieux.DateHeureCreationDebut, dbType: DbType.DateTime2);
                p.Add("@DateCreaA", filtresLieux.DateHeureCreationFin, dbType: DbType.DateTime2);
                p.Add("@DateModDe", filtresLieux.DateHeureModificationDebut, dbType: DbType.DateTime2);
                p.Add("@DateModA", filtresLieux.DateHeureModificationFin, dbType: DbType.DateTime2);
                if (filtresLieux.Id == 0)
                    p.Add("@Id", (int?) null, dbType: DbType.Int32);
                else
                    p.Add("@Id", filtresLieux.Id, dbType: DbType.Int32);
                switch (filtresLieux.IndicateurRecherches)
                {
                    case "Tous":
                        p.Add("@IndRech", (bool?)null, dbType: DbType.Boolean);
                        break;
                    case "Oui":
                        p.Add("@IndRech", true, dbType: DbType.Boolean);
                        break;
                    case "Non":
                        p.Add("@IndRech", false, dbType: DbType.Boolean);
                        break;
                    default:
                        p.Add("@IndRech", (bool?)null, dbType: DbType.Boolean);
                        break;
                }
                if (filtresLieux.Secteur=="")
                    p.Add("@CodeSec", (string?)null, dbType: DbType.String);
                else
                    p.Add("@CodeSec", filtresLieux.Secteur, dbType: DbType.String);
                if (filtresLieux.Rue == "")
                    p.Add("@CodeRue", (string?)null, dbType: DbType.String);
                else
                    p.Add("@CodeRue", filtresLieux.Rue, dbType: DbType.String);
           
                connection.Execute("dbo.spLieux_CompteFiltree", p, commandType: CommandType.StoredProcedure);
                nbTotal = p.Get<int>("@Compte");

            }
            nbTotalFiltre = nbTotal;
            nbPages = (int)(nbTotal / nbParPage);
            if (nbTotal % nbParPage > 0)
            {
                nbPages += 1;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            // pour les pages suivantes, calculer le offset qui elimine par un IN les entrees des pages precedentes
            int offsetPagesAvant = (pageCourante - 1) * nbParPage;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();

                if (filtresLieux.Texte.Length == 0)
                    p.Add("@Texte", (string?)null, dbType: DbType.String);
                else
                    p.Add("@Texte", filtresLieux.Texte, dbType: DbType.String);
                p.Add("@DateCreaDe", filtresLieux.DateHeureCreationDebut, dbType: DbType.DateTime2);
                p.Add("@DateCreaA", filtresLieux.DateHeureCreationFin, dbType: DbType.DateTime2);
                p.Add("@DateModDe", filtresLieux.DateHeureModificationDebut, dbType: DbType.DateTime2);
                p.Add("@DateModA", filtresLieux.DateHeureModificationFin, dbType: DbType.DateTime2);
                if (filtresLieux.Id == 0)
                    p.Add("@Id", (int?)null, dbType: DbType.Int32);
                else
                    p.Add("@Id", filtresLieux.Id, dbType: DbType.Int32);
                switch (filtresLieux.IndicateurRecherches)
                {
                    case "Tous":
                        p.Add("@IndRech", (bool?)null, dbType: DbType.Boolean);
                        break;
                    case "Oui":
                        p.Add("@IndRech", true, dbType: DbType.Boolean);
                        break;
                    case "Non":
                        p.Add("@IndRech", false, dbType: DbType.Boolean);
                        break;
                    default:
                        p.Add("@IndRech", (bool?)null, dbType: DbType.Boolean);
                        break;
                }
                if (filtresLieux.Secteur == "")
                    p.Add("@CodeSec", (string?)null, dbType: DbType.String);
                else
                    p.Add("@CodeSec", filtresLieux.Secteur, dbType: DbType.String);
                if (filtresLieux.Rue == "")
                    p.Add("@CodeRue", (string?)null, dbType: DbType.String);
                else
                    p.Add("@CodeRue", filtresLieux.Rue, dbType: DbType.String);
                p.Add("@Offset", offsetPagesAvant, dbType: DbType.Int32);
                tri = contruireTriLieux(entetes);
                p.Add("@Tri", tri, dbType: DbType.String);
                desLieux = connection.Query<Lieux>("dbo.spLieux_ListeFiltreeTrieePaginee", p, commandType: CommandType.StoredProcedure).ToList();
            }
            foreach (Lieux l in desLieux)
            {
                RemplirObjets(l);
            }
            return desLieux;

        }
        /// <summary>
        /// Utilitaire pour mapper les ID de la bd aux objets
        /// </summary>
        public void RemplirObjets(Lieux unLieu)
        {
            ConnecteurSQLMedias connection = new ConnecteurSQLMedias();

            // obtenir Collection
            if (unLieu.IdPhotoLieu > 0)
            {
                unLieu.PhotoLieu = connection.MediasGetById(unLieu.IdPhotoLieu, false);
            }
            ConnecteurSQLCommun connComm = new ConnecteurSQLCommun();
            // obtenir Utilisateur Creation
            if (unLieu.IdUtilisateurCreation > 0)
            {
                unLieu.UtilisateurCreation = connComm.UtilisateursGetById(unLieu.IdUtilisateurCreation);
            }
            // obtenir Utilisateur Mofidication
            if (unLieu.IdUtilisateurModification > 0)
            {
                unLieu.UtilisateurModification = connComm.UtilisateursGetById(unLieu.IdUtilisateurModification);
            }
        }
        public List<Lieux> RechercherLieux(string chaine)
        {
            List<Lieux> desLieux;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();

                if (chaine.Length == 0)
                    p.Add("@Texte", (string?)null, dbType: DbType.String);
                else
                    p.Add("@Texte", chaine, dbType: DbType.String);           

                desLieux = connection.Query<Lieux>("dbo.spLieux_ListeSelection", p, commandType: CommandType.StoredProcedure).ToList();
            }


            return desLieux;
        }
        public Lieux CreerLieu(Lieux unLieu)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                // parametres pour l'entree Lieux
                var p = new DynamicParameters();

                p.Add("@secteur", unLieu.CodeSecteur, dbType: DbType.String);
                p.Add("@rue", unLieu.CodeRue, dbType: DbType.String);
                p.Add("@noCivique", unLieu.NoCivique, dbType: DbType.Int32);
                p.Add("@app", unLieu.AppSuite, dbType: DbType.String);
                p.Add("@descriptionAilleurs", unLieu.DescriptionAilleurs, dbType: DbType.String);
                p.Add("@description", unLieu.Description, dbType: DbType.String);
                p.Add("@longitude", unLieu.Longitude, dbType: DbType.Decimal, precision: 18, scale: 7);
                p.Add("@latitude", unLieu.Latitude, dbType: DbType.Decimal, precision:18, scale:7);

                p.Add("@indRech", unLieu.IndicateurRecherches, dbType: DbType.Boolean);
                p.Add("@notes", unLieu.NotesRecherches, dbType: DbType.String);
                p.Add("@anneeCons", unLieu.AnneeConstruction, dbType: DbType.Int32);
                p.Add("@dateC", unLieu.DateHeureCreation, dbType: DbType.DateTime2);
                p.Add("@dateM", unLieu.DateHeureModification, dbType: DbType.DateTime2);
                p.Add("@userC", unLieu.UtilisateurCreation.Id, dbType: DbType.Int32);
                p.Add("@userM", unLieu.UtilisateurModification.Id, dbType: DbType.Int32);
                p.Add("@AddComp", unLieu.AdresseComplete, dbType: DbType.String);
                int noPhoto = 0;
                if (unLieu.PhotoLieu != null)
                    p.Add("@IdPhotoLieu", unLieu.PhotoLieu.Id, dbType: DbType.Int32);
                else
                    p.Add("@IdPhotoLieu", noPhoto, dbType: DbType.Int32);

                // appel de la stored proc avec retour du Id
                unLieu.Id = connection.Execute("dbo.spLieux_Creer", p, commandType: CommandType.StoredProcedure);

                // todo creer les presences et sujets
            }
            return unLieu;
        }
        public Lieux ModifierLieu(Lieux unLieu)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                // parametres pour l'entree Lieux
                var p = new DynamicParameters();
                p.Add("@Id", unLieu.Id, dbType: DbType.Int32);
                p.Add("@secteur", unLieu.CodeSecteur, dbType: DbType.String);
                p.Add("@rue", unLieu.CodeRue, dbType: DbType.String);
                p.Add("@noCivique", unLieu.NoCivique, dbType: DbType.Int32);
                p.Add("@app", unLieu.AppSuite, dbType: DbType.String);
                p.Add("@descriptionAilleurs", unLieu.DescriptionAilleurs, dbType: DbType.String);
                p.Add("@description", unLieu.Description, dbType: DbType.String);
                p.Add("@longitude", unLieu.Longitude, dbType: DbType.Decimal, precision:18, scale:7);
                p.Add("@latitude", unLieu.Latitude, dbType: DbType.Decimal, precision:18, scale: 7) ;

                p.Add("@indRech", unLieu.IndicateurRecherches, dbType: DbType.Boolean);
                p.Add("@notes", unLieu.NotesRecherches, dbType: DbType.String);
                p.Add("@anneeCons", unLieu.AnneeConstruction, dbType: DbType.Int32);

                p.Add("@dateM", unLieu.DateHeureModification, dbType: DbType.DateTime2);

                p.Add("@userM", unLieu.UtilisateurModification.Id, dbType: DbType.Int32);
                p.Add("@AddComp", unLieu.AdresseComplete, dbType: DbType.String);
                int noPhoto = 0;
                if (unLieu.PhotoLieu != null)
                    p.Add("@IdPhotoLieu", unLieu.PhotoLieu.Id, dbType: DbType.Int32);
                else
                    p.Add("@IdPhotoLieu", noPhoto, dbType: DbType.Int32);

                // appel de la stored proc avec retour du Id
                unLieu.Id = connection.Execute("dbo.spLieux_Modifier", p, commandType: CommandType.StoredProcedure);

                // todo creer les sujets
            }
            return unLieu;
        }

        
        /// <summary>
        /// Construire le code qui servira au OrderBy selon la colonne de tri  choisie et son sens
        /// </summary>
        /// <param name="entetes"></param>
        /// <returns></returns>
        public string contruireTriLieux(string[,] entetes)
        {
            string colonne = entetes[0, 2];
            string sens = " ASC ";
            for (int i = 0; i < 10; i++)
            {
                switch (entetes[i, 1])
                {
                    case "(A)":
                        sens = "ASC";
                        colonne = entetes[i, 2];
                        break;
                    case "(D)":
                        sens = "DESC";
                        colonne = entetes[i, 2];
                        break;

                    default:
                        break;
                }

            }

            return colonne + sens;
        }

    }

}

