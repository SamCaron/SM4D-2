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
using System.Transactions;

namespace SM4D2Librairie.AccesDonnees
{
    public class ConnecteurSQLMedias
    {
        ///////////////////////////////////////////////////////////////
        /// Medias
        /// <summary>
        /// Retourne le nombre total d'entrees de Medias dans la BD
        /// </summary>
        /// <returns>int</returns>
        public int CompteMedias()
        {
            int decompte = 0;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@compte", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spMedias_Compte", p, commandType: CommandType.StoredProcedure);
                decompte = p.Get<int>("@compte");
                return decompte;

            }
        }
        /// <summary>
        ///  Enregistre un media dans la BD
        /// </summary>
        /// <param name="unMedia"></param>
        /// <returns></returns>
        public bool CreerMedia(Medias unMedia)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                // parametres pour l'entree Media
                var p = new DynamicParameters();
                p.Add("@coll", unMedia.Collection.Id, dbType: DbType.Int32);
                p.Add("@nFichOrig", unMedia.NomFichierOriginal, dbType: DbType.String);
                p.Add("@nFichSM4D", unMedia.NomFichierSM4D, dbType: DbType.String);
                p.Add("@TypeMedia", unMedia.TypeMedia, dbType: DbType.String);
                p.Add("@TypeFichier", unMedia.TypeFichier, dbType: DbType.String);
                p.Add("@DatePrise", unMedia.DatePrise, dbType: DbType.Date);
                p.Add("@SpanDatePrise", unMedia.SpanDatePrise, dbType: DbType.Int32);
                p.Add("@Description", unMedia.Description, dbType: DbType.String);
                int noSite = 0;
                if (unMedia.Site != null)
                    noSite = unMedia.Site.Id;
                int noEven = 0;
                if (unMedia.Evenement != null)
                    noEven = unMedia.Evenement.Id;
                p.Add("@Site", noSite, dbType: DbType.Int32);
                p.Add("@Even", noEven, dbType: DbType.String);
                p.Add("@indRech", unMedia.IndicateurRecherches, dbType: DbType.Boolean);
                p.Add("@notes", unMedia.NotesRecherches, dbType: DbType.String);
                p.Add("@dateC", unMedia.DateHeureCreation, dbType: DbType.DateTime2);
                p.Add("@dateM", unMedia.DateHeureModification, dbType: DbType.DateTime2);
                p.Add("@userC", unMedia.UtilisateurCreation.Id, dbType: DbType.Int32);
                p.Add("@userM", unMedia.UtilisateurModification.Id, dbType: DbType.Int32);
                p.Add("@Id", unMedia.Id, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@Nom", unMedia.Nom, dbType: DbType.String);

                // appel de la stored proc avec retour du Id
                connection.Execute("dbo.spMedias_Creer", p, commandType: CommandType.StoredProcedure);
                unMedia.Id = p.Get<Int32>("Id");




                // todo creer les presences et sujets
            }
            RemplacerPresences(unMedia);
            RemplacerEtiquettes(unMedia);
            return true;

        }
        /// <summary>
        ///  Enregistre les modifications d'un media dans la BD
        /// </summary>
        /// <param name="unMedia"></param>
        /// <returns></returns>
        public bool ModifierMedia(Medias unMedia)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                // parametres pour l'entree Media
                var p = new DynamicParameters();
                p.Add("@Id", unMedia.Id, dbType: DbType.Int32);
                p.Add("@coll", unMedia.Collection.Id, dbType: DbType.Int32);
                p.Add("@nFichOrig", unMedia.NomFichierOriginal, dbType: DbType.String);
                p.Add("@nFichSM4D", unMedia.NomFichierSM4D, dbType: DbType.String);
                p.Add("@TypeMedia", unMedia.TypeMedia, dbType: DbType.String);
                p.Add("@TypeFichier", unMedia.TypeFichier, dbType: DbType.String);
                p.Add("@DatePrise", unMedia.DatePrise, dbType: DbType.Date);
                p.Add("@SpanDatePrise", unMedia.SpanDatePrise, dbType: DbType.Int32);
                p.Add("@Description", unMedia.Description, dbType: DbType.String);
                int noSite = 0;
                if (unMedia.Site != null)
                    noSite = unMedia.Site.Id;
                int noEven = 0;
                if (unMedia.Evenement != null)
                    noEven = unMedia.Evenement.Id;
                p.Add("@Site", noSite, dbType: DbType.Int32);
                p.Add("@Even", noEven, dbType: DbType.String);
                p.Add("@indRech", unMedia.IndicateurRecherches, dbType: DbType.Boolean);
                p.Add("@notes", unMedia.NotesRecherches, dbType: DbType.String);
                p.Add("@dateC", unMedia.DateHeureCreation, dbType: DbType.DateTime2);
                p.Add("@dateM", unMedia.DateHeureModification, dbType: DbType.DateTime2);
                p.Add("@userC", unMedia.UtilisateurCreation.Id, dbType: DbType.Int32);
                p.Add("@userM", unMedia.UtilisateurModification.Id, dbType: DbType.Int32);
                p.Add("@Nom", unMedia.Nom, dbType: DbType.String);

                // appel de la stored proc avec retour du Id
                connection.Execute("dbo.spMedias_Modifier", p, commandType: CommandType.StoredProcedure);

                // todo maj les presences et sujets
            }
            RemplacerPresences(unMedia);
            RemplacerEtiquettes(unMedia);
            return true;

        }
        public void RemplacerPresences(Medias media)
        {
            // suppression d'éventuels presences liées au Media pour remplacer avec les nouvelles
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@Id", media.Id, dbType: DbType.Int32);
                connection.Execute("dbo.spPresences_Supprimer", p, commandType: CommandType.StoredProcedure);
                foreach (Presences pr in media.Presences)
                {
                    p = new DynamicParameters();
                    p.Add("@Id", media.Id, dbType: DbType.Int32);
                    p.Add("@IdPersonne", pr.Personne.Id, dbType: DbType.Int32);
                    p.Add("@dateCrea", DateTime.Now, dbType: DbType.DateTime2);
                    p.Add("@dateMod", DateTime.Now, dbType: DbType.DateTime2);
                    p.Add("@IdUtCrea", ConfigGlobale.UtilisateurCourant().Id, dbType: DbType.Int32);
                    p.Add("@IdUtMod", ConfigGlobale.UtilisateurCourant().Id, dbType: DbType.Int32);
                    connection.Execute("dbo.spPresences_Creer", p, commandType: CommandType.StoredProcedure);

                }
            }

        }

        public void RemplacerEtiquettes(Medias media)
        {
            // suppression d'éventuels etiquettes liées au Media pour remplacer avec les nouvelles
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@Id", media.Id, dbType: DbType.Int32);
                connection.Execute("dbo.spEtiquettes_Supprimer", p, commandType: CommandType.StoredProcedure);
                foreach (Etiquettes et in media.Etiquettes)
                {
                    p = new DynamicParameters();
                    p.Add("@IdMedia", media.Id, dbType: DbType.Int32);
                    p.Add("@IdSujet", et.Sujet.Id, dbType: DbType.String);
                    p.Add("@notes", et.Notes, dbType: DbType.String);
                    p.Add("@dateCrea", DateTime.Now, dbType: DbType.DateTime2);
                    p.Add("@dateMod", DateTime.Now, dbType: DbType.DateTime2);
                    p.Add("@IdUtCrea", ConfigGlobale.UtilisateurCourant().Id, dbType: DbType.Int32);
                    p.Add("@IdUtMod", ConfigGlobale.UtilisateurCourant().Id, dbType: DbType.Int32);
                    connection.Execute("dbo.spEtiquettes_Creer", p, commandType: CommandType.StoredProcedure);

                }
            }

        }
        /// <summary>
        /// Retourne le premier media avec le Id recherche
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Medias MediasGetById(int Id, bool remplir)
        {
            List<Medias> desMedias;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@Id", Id, dbType: DbType.Int32);

                //  unMedia = connection.Execute("dbo.spMedias_GetById", p, commandType: CommandType.StoredProcedure);

                desMedias = connection.Query<Medias>("dbo.spMedias_GetById", p, commandType: CommandType.StoredProcedure).ToList();
            }
            Medias unMedia = desMedias.First();
            if (remplir)
            {
                RemplirObjets(unMedia);
            }
            return unMedia;
        }
        /// <summary>
        /// Retourne les  medias de la collection IdColl
        /// </summary>
        /// <param name="IdColl"></param>
        /// <returns></returns>
        public List<Medias> MediasGetByIdColl(int IdColl)
        {
            List<Medias> desMedias = new List<Medias>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@collId", IdColl, dbType: DbType.Int32);
                desMedias = connection.Query<Medias>("dbo.spMedias_GetByIdCollection", p, commandType: CommandType.StoredProcedure).ToList();
            }

                 
            return desMedias;
        }
        /// <summary>
        /// Retourne tous les medias
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<Medias> MediasGetAll()
        {
            List<Medias> desMedias;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                desMedias = connection.Query<Medias>("dbo.spMedias_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
            foreach (Medias m in desMedias)
            {
                RemplirObjets(m);
            }
            return desMedias;
        }
        /// <summary>
        /// Retourne  les 9 premiers medias
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<Medias> MediasGetFirst9()
        {
            List<Medias> desMedias;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                desMedias = connection.Query<Medias>("dbo.spMedias_GetFirst9", commandType: CommandType.StoredProcedure).ToList();
            }
            foreach (Medias m in desMedias)
            {
                RemplirObjets(m);
            }
            return desMedias;
        }
        /// <summary>
        /// suppression du media dont le IdMedia est recu en parametre
        /// </summary>
        /// <param name="idMedia"></param>
        // 

        public void MediasSupprimer(int idMedia)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@Id", idMedia, dbType: DbType.Int32);
                connection.Execute("dbo.spMedias_Supprimer", p, commandType: CommandType.StoredProcedure);

            }
        }
        /// <summary>
        /// Utilitaire pour mapper les ID de la bd aux objets
        /// </summary>
        public void RemplirObjets(Medias unMed)
        {
            ConnecteurSQLMedias connection = new ConnecteurSQLMedias();

            // obtenir Collection
            if (unMed.IdCollection > 0)
            {
                unMed.Collection = connection.CollectionsGetById(unMed.IdCollection);
            }
            //  obtenir les presences
            unMed.Presences = connection.PresencesByMediaId(unMed);

            //  obtenir les etiquettes
            unMed.Etiquettes = connection.EtiquettesByMediaId(unMed);

            ConnecteurSQLLieux connLieux = new ConnecteurSQLLieux();

            // obtenir Site
            if (unMed.IdLieuPrise > 0)
            {
                unMed.Site = connLieux.LieuxGetById(unMed.IdLieuPrise);
            }
            ConnecteurSQLEvenements connEven = new ConnecteurSQLEvenements();
            // obtenir Evenement
            if (unMed.IdEvenement > 0)
            {
                unMed.Evenement = connEven.EvenementsGetById(unMed.IdEvenement);
            }
            ConnecteurSQLCommun connComm = new ConnecteurSQLCommun();
            // obtenir Utilisateur Creation
            if (unMed.IdUtilisateurCreation > 0)
            {
                unMed.UtilisateurCreation = connComm.UtilisateursGetById(unMed.IdUtilisateurCreation);
            }
            // obtenir Utilisateur Mofidication
            if (unMed.IdUtilisateurModification > 0)
            {
                unMed.UtilisateurModification = connComm.UtilisateursGetById(unMed.IdUtilisateurModification);
            }

            // todo obtenir les etiquettes


        }
        /// <summary>
        /// Retourne  les Presences d'un media
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<Presences> PresencesByMediaId(Medias media)
        {
            List<Presences> desPresences;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@MediaId", media.Id, dbType: DbType.Int32);
                desPresences = connection.Query<Presences>("dbo.spPresences_GetByMediaId", p, commandType: CommandType.StoredProcedure).ToList();
            }
            foreach (Presences p in desPresences)
            {
                p.Media = media;
                ConnecteurSQLPersonnes connPers = new ConnecteurSQLPersonnes();

                p.Personne = connPers.PersonneGetById(p.IdPersonne);
            }
            return desPresences;
        }
        /// <summary>
        /// Retourne  les etiquettes d'un media
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<Etiquettes> EtiquettesByMediaId(Medias media)
        {
            List<Etiquettes> desEtiquettes;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@MediaId", media.Id, dbType: DbType.Int32);
                desEtiquettes = connection.Query<Etiquettes>("dbo.spEtiquettes_GetByMediaId", p, commandType: CommandType.StoredProcedure).ToList();
            }
            foreach (Etiquettes et in desEtiquettes)
            {
                et.Media = media;
                ConnecteurSQLCommun connComm = new ConnecteurSQLCommun();

                et.Sujet = connComm.SujetsGetById(et.IdSujet);
            }
            return desEtiquettes;
        }
        // retourne la liste des medias filtree selon filtresMedias et triee selon entetes.  Cette methode retourne seulement les images pour la page

        public List<Medias> MediasGetFiltresTri(MediasFiltres filtresMedias, string[,] entetes, int pageCourante, int nbParPage, out int nbPages, out int nbTotalFiltre)
        {
            List<Medias> desMedias;

            string tri = "";
            int nbTotal = 0;
            tri = contruireTriMedias(entetes);

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                // calculer le nombre des lieux qui matchent et le nombre de pages
                var p = new DynamicParameters();
                p.Add("@Compte", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                if (filtresMedias.Description.Length == 0)
                    p.Add("@Texte", (string?)null, dbType: DbType.String);
                else
                    p.Add("@Texte", filtresMedias.Description, dbType: DbType.String);
                p.Add("@DateCreaDe", filtresMedias.DateHeureCreationDebut, dbType: DbType.DateTime2);
                p.Add("@DateCreaA", filtresMedias.DateHeureCreationFin, dbType: DbType.DateTime2);
                p.Add("@DateModDe", filtresMedias.DateHeureModificationDebut, dbType: DbType.DateTime2);
                p.Add("@DateModA", filtresMedias.DateHeureModificationFin, dbType: DbType.DateTime2);
                p.Add("@DatePriseDe", filtresMedias.DatePriseDebut, dbType: DbType.DateTime2);
                p.Add("@DatePriseA", filtresMedias.DatePriseFin, dbType: DbType.DateTime2);
                if (filtresMedias.Id == 0)
                    p.Add("@Id", (int?)null, dbType: DbType.Int32);
                else
                    p.Add("@Id", filtresMedias.Id, dbType: DbType.Int32);
                switch (filtresMedias.IndicateurRecherches)
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
                if (filtresMedias.IdCollection == 0)
                    p.Add("@IdColl", (string?)null, dbType: DbType.String);
                else
                    p.Add("@IdColl", filtresMedias.IdCollection, dbType: DbType.String);
                p.Add("@IdHSujet", (float?)filtresMedias.IdSujet, dbType: DbType.Decimal);
                p.Add("@NivSuj", (int?)filtresMedias.NiveauSujet, dbType: DbType.Int32);
                //  p.Add("@NbParPage", nbParPage, dbType: DbType.Int32);
                connection.Execute("dbo.spMedias_CompteFiltree", p, commandType: CommandType.StoredProcedure);
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

                if (filtresMedias.Description.Length == 0)
                    p.Add("@Texte", (string?)null, dbType: DbType.String);
                else
                    p.Add("@Texte", filtresMedias.Description, dbType: DbType.String);
                p.Add("@DateCreaDe", filtresMedias.DateHeureCreationDebut, dbType: DbType.DateTime2);
                p.Add("@DateCreaA", filtresMedias.DateHeureCreationFin, dbType: DbType.DateTime2);
                p.Add("@DateModDe", filtresMedias.DateHeureModificationDebut, dbType: DbType.DateTime2);
                p.Add("@DateModA", filtresMedias.DateHeureModificationFin, dbType: DbType.DateTime2);
                p.Add("@DatePriseDe", filtresMedias.DatePriseDebut, dbType: DbType.Date);
                p.Add("@DatePriseA", filtresMedias.DatePriseFin, dbType: DbType.Date);
                if (filtresMedias.Id == 0)
                    p.Add("@Id", (int?)null, dbType: DbType.Int32);
                else
                    p.Add("@Id", filtresMedias.Id, dbType: DbType.Int32);
                switch (filtresMedias.IndicateurRecherches)
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
                if (filtresMedias.IdCollection == 0)
                    p.Add("@IdColl", (string?)null, dbType: DbType.String);
                else
                    p.Add("@IdColl", filtresMedias.IdCollection, dbType: DbType.String);
                p.Add("@Offset", offsetPagesAvant, dbType: DbType.Int32);
                tri = contruireTriMedias(entetes);
                p.Add("@Tri", tri, dbType: DbType.String);
                p.Add("@NbParPage", nbParPage, dbType: DbType.Int32);
                p.Add("@IdHSujet", (float?)filtresMedias.IdSujet, dbType: DbType.Decimal);
                p.Add("@NivSuj", (int?)filtresMedias.NiveauSujet, dbType: DbType.Int32);
                desMedias = connection.Query<Medias>("dbo.spMedias_ListeFiltreeTrieePaginee", p, commandType: CommandType.StoredProcedure).ToList();
            }
            foreach (Medias m in desMedias)
            {
                RemplirObjets(m);
            }
            return desMedias;
        }
        // retourne la liste des medias filtree selon filtresMedias et triee selon entetes.  Cette methode retourne tous les ID des medias filtres et tries

        public List<int> MediasGetFiltresTriTous(MediasFiltres filtresMedias, string[,] entetes, out int nbTotalFiltre)
        {
            List<int> desMedias;

            string tri = "";

            tri = contruireTriMedias(entetes);


            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();

                if (filtresMedias.Description.Length == 0)
                    p.Add("@Texte", (string?)null, dbType: DbType.String);
                else
                    p.Add("@Texte", filtresMedias.Description, dbType: DbType.String);
                p.Add("@DateCreaDe", filtresMedias.DateHeureCreationDebut, dbType: DbType.DateTime2);
                p.Add("@DateCreaA", filtresMedias.DateHeureCreationFin, dbType: DbType.DateTime2);
                p.Add("@DateModDe", filtresMedias.DateHeureModificationDebut, dbType: DbType.DateTime2);
                p.Add("@DateModA", filtresMedias.DateHeureModificationFin, dbType: DbType.DateTime2);
                p.Add("@DatePriseDe", filtresMedias.DatePriseDebut, dbType: DbType.Date);
                p.Add("@DatePriseA", filtresMedias.DatePriseFin, dbType: DbType.Date);
                if (filtresMedias.Id == 0)
                    p.Add("@Id", (int?)null, dbType: DbType.Int32);
                else
                    p.Add("@Id", filtresMedias.Id, dbType: DbType.Int32);
                switch (filtresMedias.IndicateurRecherches)
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
                if (filtresMedias.IdCollection == 0)
                    p.Add("@IdColl", (string?)null, dbType: DbType.String);
                else
                    p.Add("@IdColl", filtresMedias.IdCollection, dbType: DbType.String);
                tri = contruireTriMedias(entetes);
                p.Add("@Tri", tri, dbType: DbType.String);
                p.Add("@IdHSujet", (float?)filtresMedias.IdSujet, dbType: DbType.Decimal);
                p.Add("@NivSuj", (int?)filtresMedias.NiveauSujet, dbType: DbType.Int32);
                desMedias = connection.Query<int>("dbo.spMedias_ListeFiltreeTrieeTous", p, commandType: CommandType.StoredProcedure).ToList();
            }
            nbTotalFiltre = desMedias.Count;

            return desMedias;
        }
        // recherche de medias pour la selection
        //   RechercherMedias(filtres, dateFiltre, spanFiltre);
        public List<Medias> RechercherMedias(string texte, int anneeDe, int anneeA, int pageCourante, int nbParPage, float? IdHSujet, int nivSujet, out int nbPages, out int nbTotalFiltre)

        {
            List<Medias> desMedias;

            string tri = "NomASC";
            int nbTotal = 0;
            DateTime DatePriseDebut = new DateTime(anneeDe, 1, 1);
            DateTime DatePriseFin = new DateTime(anneeA, 12, 31);
            if (nivSujet == 0) { IdHSujet = 0; }

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {


                // calculer le nombre des lieux qui matchent et le nombre de pages
                var p = new DynamicParameters();
                p.Add("@Compte", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                if (texte.Length == 0)
                    p.Add("@Texte", (string?)null, dbType: DbType.String);
                else
                    p.Add("@Texte", texte, dbType: DbType.String);
                p.Add("@DateCreaDe", (DateTime?)null, dbType: DbType.DateTime2);
                p.Add("@DateCreaA", (DateTime?)null, dbType: DbType.DateTime2);
                p.Add("@DateModDe", (DateTime?)null, dbType: DbType.DateTime2);
                p.Add("@DateModA", (DateTime?)null, dbType: DbType.DateTime2);

                p.Add("@DatePriseDe", DatePriseDebut, dbType: DbType.DateTime2);
                p.Add("@DatePriseA", DatePriseFin, dbType: DbType.DateTime2);


                p.Add("@IndRech", (bool?)null, dbType: DbType.Boolean);
                p.Add("@IdColl", (string?)null, dbType: DbType.String);
                p.Add("@Id", (int?)null, dbType: DbType.Int32);

                //   p.Add("@NbParPage", nbParPage, dbType: DbType.Int32);

                p.Add("@IdHSujet", (float?)IdHSujet, dbType: DbType.Decimal);
                p.Add("@NivSuj", nivSujet, dbType: DbType.Int32);

                connection.Execute("dbo.spMedias_CompteFiltree", p, commandType: CommandType.StoredProcedure);
                nbTotal = p.Get<int>("@Compte");

            }
            nbTotalFiltre = nbTotal;
            nbPages = (int)(nbTotal / nbParPage);
            if ((nbTotal % nbParPage > 0) || (nbTotal == 0))
            {
                nbPages += 1;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            // pour les pages suivantes, calculer le offset qui elimine par un IN les entrees des pages precedentes
            int offsetPagesAvant = (pageCourante - 1) * nbParPage;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {

                var p = new DynamicParameters();
                if (texte.Length == 0)
                    p.Add("@Texte", (string?)null, dbType: DbType.String);
                else
                    p.Add("@Texte", texte, dbType: DbType.String);
                p.Add("@DateCreaDe", (DateTime?)null, dbType: DbType.DateTime2);
                p.Add("@DateCreaA", (DateTime?)null, dbType: DbType.DateTime2);
                p.Add("@DateModDe", (DateTime?)null, dbType: DbType.DateTime2);
                p.Add("@DateModA", (DateTime?)null, dbType: DbType.DateTime2);

                p.Add("@DatePriseDe", DatePriseDebut, dbType: DbType.DateTime2);
                p.Add("@DatePriseA", DatePriseFin, dbType: DbType.DateTime2);


                p.Add("@IndRech", (bool?)null, dbType: DbType.Boolean);
                p.Add("@IdColl", (string?)null, dbType: DbType.String);
                p.Add("@Id", (int?)null, dbType: DbType.Int32);

                p.Add("@Offset", offsetPagesAvant, dbType: DbType.Int32);
                tri = tri = " Nom ASC ";
                p.Add("@Tri", tri, dbType: DbType.String);
                p.Add("@NbParPage", nbParPage, dbType: DbType.Int32);

                p.Add("@IdHSujet", (float?)IdHSujet, dbType: DbType.Decimal);
                p.Add("@NivSuj", nivSujet, dbType: DbType.Int32);
                desMedias = connection.Query<Medias>("dbo.spMedias_ListeFiltreeTrieePaginee", p, commandType: CommandType.StoredProcedure).ToList();
            }
            foreach (Medias m in desMedias)
            {
                RemplirObjets(m);
            }
            return desMedias;
        }

        /// <summary>
        /// Construire le OrderBy selon la colonne de tri  choisie et son sens
        /// </summary>
        /// <param name="entetes"></param>
        /// <returns></returns>
        public string contruireTriMedias(string[,] entetes)
        {
            string colonne = entetes[0, 2];
            int taille = (int)(entetes.Length / 3);
            string sens = "ASC";
            for (int i = 0; i < taille; i++)
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

        /////////////////////////////////////////////////////////////////////////
        /// Collections

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        public List<Collections> GetCollections(bool indDeployee)
        {
            List<Collections> listeTout, listeDeployees;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                listeTout = connection.Query<Collections>("dbo.spCollections_ListeAll").ToList();
            }
            listeDeployees = new List<Collections>();
            if (indDeployee)
            {
                foreach (Collections c in listeTout)
                {
                    if (c.Deployee)
                        listeDeployees.Add(c);
                }
                return listeDeployees;
            }

            return listeTout;
        }
        /// <summary>
        /// Retourne la collection dont le Id = Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Collections CollectionsGetById(int Id)
        {
            {
                List<Collections> liste;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", Id, dbType: DbType.Int32);

                    liste = connection.Query<Collections>("dbo.spCollections_GetById", p, commandType: CommandType.StoredProcedure).ToList();
                }
                if (liste.Count > 0)
                {
                    return liste.First();
                }
                return null;
            }
        }
        /// <summary>
        /// Recherche et retourne une collection dont le nom == nomColl.  retourne null si aucun trouvé
        /// </summary>
        /// <param name="nomColl"></param>
        /// <returns></returns>
        public Collections CollectionsGetByNom(string nomColl)
        {
            {
                List<Collections> liste;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
                {
                    var p = new DynamicParameters();
                    p.Add("@Nom", nomColl, dbType: DbType.String);

                    liste = connection.Query<Collections>("dbo.spCollections_GetByNom", p, commandType: CommandType.StoredProcedure).ToList();
                }
                if (liste.Count > 0)
                {
                    return liste.First();
                }
                return null;
            }
        }
        /// <summary>
        /// suppression du media dont le IdMedia est recu en parametre
        /// </summary>
        /// <param name="idColl"></param>
        // 

        public void CollectionsSupprimer(int idColl)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                var p = new DynamicParameters();
                p.Add("@Id", idColl, dbType: DbType.Int32);
                connection.Execute("dbo.spCollections_Supprimer", p, commandType: CommandType.StoredProcedure);

            }
        }
        /// <summary>
        ///  Crée une collection dans la BD
        /// </summary>
        /// <param name="uneColl"></param>
        /// <returns></returns>
        public bool CreerCollection(Collections uneColl)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                // parametres pour l'entree Media
                var p = new DynamicParameters();
                p.Add("@Id", uneColl.Id, dbType: DbType.Int32);
                p.Add("@nom", uneColl.NomCollection, dbType: DbType.String);
                p.Add("@contrib", uneColl.Contributeur, dbType: DbType.String);
                p.Add("@resp", uneColl.Responsable, dbType: DbType.String);
                p.Add("@notes", uneColl.Notes, dbType: DbType.String);
                p.Add("@deployee", uneColl.Deployee, dbType: DbType.Boolean);
                p.Add("@dateC", uneColl.DateHeureCreation, dbType: DbType.DateTime2);
                p.Add("@dateM", uneColl.DateHeureModification, dbType: DbType.DateTime2);
                p.Add("@idUserC", uneColl.IdUtilisateurCreation, dbType: DbType.Int32);
                p.Add("@idUserM", uneColl.IdUtilisateurModification, dbType: DbType.Int32);

                // appel de la stored proc avec retour du Id
                connection.Execute("dbo.spCollections_Creer", p, commandType: CommandType.StoredProcedure);
                uneColl.Id = p.Get<Int32>("Id");
            }

            return true;

        }
        /// <summary>
        ///  Modifie une collection dans la BD
        /// </summary>
        /// <param name="uneColl"></param>
        /// <returns></returns>
        public bool ModifierCollection(Collections uneColl)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigGlobale.StringConnection("SM4D")))
            {
                // parametres pour l'entree Media
                var p = new DynamicParameters();
                p.Add("@Id", uneColl.Id, dbType: DbType.Int32);
                p.Add("@nom", uneColl.NomCollection, dbType: DbType.String);
                p.Add("@contrib", uneColl.Contributeur, dbType: DbType.String);
                p.Add("@resp", uneColl.Responsable, dbType: DbType.String);
                p.Add("@notes", uneColl.Notes, dbType: DbType.String);
                p.Add("@deployee", uneColl.Deployee, dbType: DbType.Boolean);

                p.Add("@dateM", uneColl.DateHeureModification, dbType: DbType.DateTime2);
                p.Add("@idUserM", uneColl.IdUtilisateurModification, dbType: DbType.Int32);

                // appel de la stored proc avec retour du Id
                connection.Execute("dbo.spCollections_Modifier", p, commandType: CommandType.StoredProcedure);

            }

            return true;

        }


    }
}

