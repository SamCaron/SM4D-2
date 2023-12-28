using SM4D2Librairie.AccesDonnees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Imaging;
using System.ComponentModel.Design;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.CompilerServices;

namespace SM4D2Librairie.Modeles
{
    /// <summary>
    /// Medias conservés dans les archives tels Photos, Documents, Videos et Audios
    /// </summary>
    public class Medias
    {
        /// <summary>
        /// Identifiant unique du media attribue automatiquement 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Collection contenant le media
        /// equivalent jpg pour Collection.Nom = Auteurs       
        /// /// </summary>
        public Collections Collection { get; set; }
        /// <summary>
        /// Nom du fichier original capture lors de l'ajout au systeme

        /// </summary>
        public string NomFichierOriginal { get; set; } = "";
        /// <summary>
        /// Nom du fichier attribue par le système au besoin si déjà présent avec même nom
        /// /// </summary>
        public string NomFichierSM4D { get; set; } = "";
        /// <summary>
        /// Type de Media, i.e. Photo, Video, Document, Audio
        /// </summary>
        public string TypeMedia { get; set; } = "";
        /// <summary>
        /// Type de fichier du media, i.e. jpg, png, wmv, mp4, pdf, mp3
        /// </summary>
        public string TypeFichier { get; set; } = "";
        /// <summary>
        /// Date a laquelle le media aurait ete pris, ex: date de prise de photo, video
        /// equivalent jpg pour DatePrise.tostring()  = Prise de Vue
        /// </summary>
        public DateTime DatePrise { get; set; }
        /// <summary>
        /// Imprecision en annees qui doit etre applique a la datePrise.  
        /// </summary>
        public int SpanDatePrise { get; set; }
        /// <summary>
        /// Description generale du contenu du media
        /// equivalent jpg pour Description = Commentaires
        /// </summary>
        public string Description { get; set; } = ""; 
        /// <summary>
        /// Lieu où le media aurait ete pris
        /// </summary>
        public Lieux Site { get; set; }
        /// <summary>
        /// Evenement associe au Media, ex: Photo prise lors du 100e St-Marcel 
        /// </summary>
        public Evenements Evenement { get; set; }
        /// <summary>
        /// Indicateur Oui ou Non si des recherches sont necessaires pour le Media
        /// </summary>
        public bool IndicateurRecherches { get; set; }
        /// <summary>
        /// Description des recherches et questionnements qui restent a repondre sur le Media
        /// </summary>
        public string NotesRecherches { get; set; } = "";

        /// <summary>
        /// Nom court du media
        /// equivalent jpg = Titre
        /// </summary>
        public string Nom { get; set; }
        /// equivalent jpg = Date d'acquisition.tostring()
        public DateTime DateHeureCreation { get; set; }
        public DateTime DateHeureModification { get; set; }
        public Utilisateurs UtilisateurCreation { get; set; }
        public Utilisateurs UtilisateurModification { get; set; }
        /// <summary>
        /// Liste des tags de presences sur le media, ex: personne qui apparait sur la photo
        /// </summary>
        public List<Presences> Presences { get; set; } = new List<Presences>();
        /// equivalent JPG Copyright = Tous droits réservés
        public static string Copyright = "Archives St-Marcel";
        /// <summary>
        /// Liste des tags de sujets qui porte le media.  Ex: Mariage, Anniversaire, Metier...
        /// equivalent JPG Liste des étiquettes.nom séparés par ; et concaténé dans = Mots clés
        /// </summary>
        /// 
        
        public List<Etiquettes> Etiquettes { get; set; } = new List<Etiquettes>();

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Attributs calcules a partir des champs originaux (image, signature string...)
        /// </summary>
        //  retourner la miniature  
        public System.Drawing.Image Miniature
        {
            get
            {

                if (Id == 0 && NomFichierSM4D == "")
                    return ConfigGlobale.ImageNonDisponible();

                return MiniatureVariable(50);
            }
        }
        // Extraire les métadonnées d'un fichier image et initialiser les valeurs d'un  media temporaire servant à initialiser sélectivement l'objet principal. 
        public Medias ExtraireMetadonnees(string nomFichier, out string coll, out string copyr)
        {

            Medias mediaMetas = new Medias();  // media temporaire pour ramasser les métadonnées dans les propriétés 
            string nomCompletFicher = nomFichier;  // nom complet du ficher avec chemin
            System.Drawing.Image image = System.Drawing.Image.FromFile(nomCompletFicher);  // objet image pour extraire les métadonnées

            // Extraction de la liste des propriétés et de leurs id
            int nbProp = image.PropertyItems.Count();
            List<PropertyItem> props = new List<PropertyItem>();
            copyr = ""; // capture le copyright si présent et le retourne en paramètre out pour validations
            coll = ""; // capture la collection si présent et le retourne en paramètre out pour validations

            string proprieteBrute = "";
            bool valide;
            DateTime dateTravail = DateTime.Now;
            mediaMetas.IndicateurRecherches = false;
   

            for (int i= 0; i < nbProp; i++ )
            {


                switch (image.PropertyIdList[i])
                {
                    
                    case 270: // Titre - UTF8 - Nom media
                        mediaMetas.Nom = Encoding.UTF8.GetString(image.PropertyItems[i].Value);
                        mediaMetas.IndicateurRecherches = true;
                        break;
                    case 40091:  // Titre - UNICODE - Nom media doublon en unicode
                        if (mediaMetas.Nom == "")  // prendre si disponible et pas déjà obtenu par prop #270
                        {
                            mediaMetas.Nom = Encoding.Unicode.GetString(image.PropertyItems[i].Value).Replace("\0", string.Empty);
                        }
                        mediaMetas.IndicateurRecherches = true;
                        break;
                    case 315: // Auteur - UTF8 - Nom collection. Devrait être cohérent avec la collection, on le capture et le retourne en parm
                        coll = Encoding.UTF8.GetString(image.PropertyItems[i].Value).Replace("\0",string.Empty);
                        mediaMetas.IndicateurRecherches = true;
                        break;
                    case 33432: // tous droits réservés - UTF8 - si présent, devrait être "Archives St-Marcel", on le capture et le retourne en parm
                        copyr = Encoding.UTF8.GetString(image.PropertyItems[i].Value).Replace("\0", string.Empty);
                        mediaMetas.IndicateurRecherches = true;
                        break;
                    case 36867:  // Prise de vue - UTF8- Date et heure de prise 
                    //case 36868:  // Prise de vue -UTF8 - Date et heure de prise doublon

                        proprieteBrute = Encoding.UTF8.GetString(image.PropertyItems[i].Value).Replace("\0", string.Empty);
                        proprieteBrute = proprieteBrute.Substring(0, 19);
  
                        dateTravail = DateTime.ParseExact(proprieteBrute, "yyyy:MM:dd HH:mm:ss", null );
                            mediaMetas.DatePrise = dateTravail;
                            mediaMetas.SpanDatePrise = dateTravail.Second;  // le span d'imprécision est enregistré en secondes dans la date de prise
                            mediaMetas.IndicateurRecherches = true;

                        break;
                    case 40092:  // Commentaires - Unicode - Description
                        mediaMetas.Description = Encoding.Unicode.GetString(image.PropertyItems[i].Value).Replace("\0", string.Empty);
                        mediaMetas.IndicateurRecherches = true;
                        break;
                    case 40094:  // Mots clés - Unicode - Mots clés
                        if (Etiquettes.Count == 0)  // Les étiquettes de la BD ont préséance sur les métas.  On n' ajoute celles des metas que si étiquettes est vide    
                        {
                            // obtenir la liste des sujets possibles
                            ConnecteurSQLCommun connComm = new ConnecteurSQLCommun();
                            List<Sujets> listeSujets = connComm.RechercherSujets("", true);
                            Sujets sujetTrouve;
                            int motCleInt;
                            // extraire la chaine de Id et découper
                            proprieteBrute = Encoding.Unicode.GetString(image.PropertyItems[i].Value).Replace("\0", string.Empty);
                            string[] motsCles = proprieteBrute.Split(';');
                            // pour chaque Id, trouver le sujet et ajouter l'étiquette au media
                            for (int j = 0; j < motsCles.Length; j++)
                            {

                                sujetTrouve = listeSujets.Find(s => s.Id == motsCles[j]);
                                if (sujetTrouve != null)
                                {

                                    mediaMetas.Etiquettes.Add(new Etiquettes(this, sujetTrouve, ""));
                                    mediaMetas.IndicateurRecherches = true;
                                }
                            }
                        }

                        
                        break;
                    default:
                        // metadonnee non pertinente
                        break;
                }
            }
            return mediaMetas;
        }
        /// <summary>
        /// Enregistre une propri
        /// </summary>
        /// <param name="noProp"></param>
        /// <param name="typeProp"></param>
        /// <param name="valeurProp"></param>
        /// <returns></returns>
        private System.Drawing.Image  EnregistrerUneMetadonnee(int noProp, int typeProp, string valeurProp, System.Drawing.Image fichierImage, PropertyItem propriete)
        {
            
            var comm = Encoding.ASCII.GetBytes("Commentaires Commentaires Commentaires");
            propriete.Id = noProp;
            if (typeProp == 1)
            {
                propriete.Value = Encoding.Unicode.GetBytes(valeurProp + "\0") ;  // type 1 est short, donc unicode
            }
            else
            {
                propriete.Value = Encoding.UTF8.GetBytes(valeurProp + "\0"); // type 2 est byte, donc utf8
            }
            
            propriete.Len = propriete.Value.Length;
            propriete.Type = (short) typeProp;
            fichierImage.SetPropertyItem(propriete);

            return fichierImage;
        }

        /// <summary>
        /// Enregistrer les métadonnées d'un fichier image à partir des information de l'objet principal. 
        /// </summary>
        /// <param name=""></param>
        /// <returns> booleen si l'entregistrement s'est bien fait</returns>
        public bool EnregistrerMetadonnees()
        {
            bool succes = false;
            // Obtenir objet image du fichier du media
            string nomCompletFicher = this.Collection.SousRepComplet() + this.NomFichierSM4D;  // nom complet du ficher avec chemin
            System.Drawing.Image image = System.Drawing.Image.FromFile(nomCompletFicher);  // objet image pour enregistrer les métadonnées

            // Obtenir une propriete ([0]) du fichier qui servira à enregistrer toutes les autres nécessaires
            int nombrePropriete = image.PropertyItems.Count();

            // Si au moins une propriete, on peut enregistrer.  Sinon, impossible.
            if (nombrePropriete > 0)
            {
                succes = true;
                // propriété #270 Titre - UTF8 - Nom media
                image = EnregistrerUneMetadonnee(270, 2, this.Nom, image, image.PropertyItems[0]);

                // propriété #271 Propriété logicielle de Soaff Techno Inc.
                image = EnregistrerUneMetadonnee(271, 2, "Soaff Techno Inc.", image, image.PropertyItems[0]);

                // propriété #272 Propriété logicielle du logiciel SM4D
                image = EnregistrerUneMetadonnee(272, 2, "SM4D", image, image.PropertyItems[0]);

                // propriété #40091 Titre - Unicode - Nom media
                image = EnregistrerUneMetadonnee(40091, 1, this.Nom, image, image.PropertyItems[0]);

                // propriété #315 Auteur - UTF8 - Nom collection. 
                image = EnregistrerUneMetadonnee(315, 2, this.Collection.NomCollection, image, image.PropertyItems[0]);

                // propriété #33432 tous droits réservés - UTF8 
                image = EnregistrerUneMetadonnee(33432, 2, Medias.Copyright , image, image.PropertyItems[0]);

                // propriété #36867 Date de prise ainsi que SpanDatePrise dans les Secondes - UTF8 
                DateTime date = this.DatePrise;
                TimeSpan span = new TimeSpan(0, 0, this.SpanDatePrise);
                date = date.Date + span;
                image = EnregistrerUneMetadonnee(36867, 2, date.ToString("yyyy:MM:dd HH:mm:ss"), image, image.PropertyItems[0]);

                // propriété #40092 Commentaires - Unicode - Description
                image = EnregistrerUneMetadonnee(40092, 1, this.Description, image, image.PropertyItems[0]);

                // propriété #40094 Mots clés - Unicode - Sujets des etiquettes
                string chaineEtiquettes = "";
                foreach (Etiquettes eti in this.Etiquettes)
                {
                    chaineEtiquettes += eti.IdSujet.ToString() + ";";
                }
                image = EnregistrerUneMetadonnee(40094, 1, chaineEtiquettes, image, image.PropertyItems[0]);
            }

            // 3) enregistrer dans fichier et copier ensuite dans fichier original

            string nomFichierTemp = this.Collection.SousRepComplet() + "sm4dtempmeta.jpg";
            string nomSM4D = this.Collection.SousRepComplet() + this.NomFichierSM4D;
            File.Delete(nomFichierTemp);
            image.Save(nomFichierTemp);
            image.Dispose();
            File.Delete(nomSM4D);
            File.Move(nomFichierTemp, nomSM4D);
            File.Delete(nomFichierTemp);


            return succes;
        }

        // Retourne une miniature de l'image dont la taille est cotePixel en largeur et hauteur
        public System.Drawing.Image MiniatureVariable(int cotePixel)
        {
            System.Drawing.Image image;
            // si fichier image sans nom ou id vide, retourne image non trouvee
            if (Id == 0 && NomFichierSM4D == "")
                return ConfigGlobale.ImageNonDisponible();
            // si fichier image absent, retourne image non trouvee
            if (!File.Exists(ConfigGlobale.EmplacementImages() + this.Collection.SousRep() + NomFichierSM4D))
            {
                image = ConfigGlobale.ImageNonDisponible();

                return image.GetThumbnailImage(cotePixel, cotePixel, () => false, IntPtr.Zero); ;
            }

            image = System.Drawing.Image.FromFile(ConfigGlobale.EmplacementImages() + this.Collection.SousRep() + NomFichierSM4D);
            return image.GetThumbnailImage(cotePixel, cotePixel, () => false, IntPtr.Zero);
        }
        // retourner le chemin complet du fichier média.  Le paramêtre est conservé pour l'instant par souci de compabilité mais ne sert à rien
        public string MiniatureVariablePath(int cotePixel)
        {
            
            // si fichier image sans nom ou id vide, retourne image non trouvee
            if (Id == 0 && NomFichierSM4D == "")
                return ConfigGlobale.ImageNonDisponiblePath();
            // si fichier image absent, retourne image non trouvee
            if (!File.Exists(ConfigGlobale.EmplacementImages() + this.Collection.SousRep() + NomFichierSM4D))
            {
                return ConfigGlobale.ImageNonDisponiblePath();
            }

            return(ConfigGlobale.EmplacementImages() + this.Collection.SousRep() + NomFichierSM4D);
   
        }
        // retourner la signature de la collection
        public string CollectionSig
        {
            get
            {
                if (Collection != null)
                    return Collection.ToString();
                return "N/A";
            }
        }
        // retourner la signature du lieu de la prise
        public string SiteSig
        {
            get
            {
                if (Site != null)
                    return Site.AdresseComplete;
                return "N/A";
            }
        }
        // retourner la signature de l'evenement de la prise
        public string EvenementSig
        {
            get
            {
                if (Evenement != null)
                    return Evenement.Date.Year.ToString() + " " + Evenement.NomEvenement;
                return "N/A";
            }
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Attributs necessaires pour mapper les objets vs les Id de la BD 
        /// </summary>
        /// No de la collection 
        public int IdCollection { get; set; }
        // No du lieu ou le média a été pris
        public int IdLieuPrise { get; set; }
        // No de l'évenement lors duquel le média a été pris lorsqu'applicable
        public int IdEvenement { get; set; }
        // Id de l'utilisateur qui a créé l'enregistrement
        public int IdUtilisateurCreation { get; set; }
        // Id du dernier utilisateur qui a modifié l'enregistrement (le plus récent)
        public int IdUtilisateurModification { get; set; }
        ///////////////////////////////////////////////////////////////////////
        /// constructeurs et utilitaires
        /// <summary>
        /// Constructeur generique
        /// </summary>
        public Medias()
        {
        }
      /// <summary>
      /// Constructeur specifique a la saisie (numeriques en string)
      /// </summary>
      /// <param name="collection"></param>
      /// <param name="nomOriginal"></param>
      /// <param name="nomSM4D"></param>
      /// <param name="typeMedia"></param>
      /// <param name="typeFichier"></param>
      /// <param name="datePrise"></param>
      /// <param name="span"></param>
      /// <param name="description"></param>
      /// <param name="lieu"></param>
      /// <param name="evenement"></param>
      /// <param name="indRech"></param>
      /// <param name="notes"></param>
      /// <param name="listePresences"></param>
      /// <param name="listeSujets"></param>
        public Medias(
            Collections collection,
            string nomOriginal,
            string nomSM4D,
            string typeMedia,
            string typeFichier,
            DateTime datePrise,
            string span,
            string description,
            Lieux lieu,
            Evenements evenement,
            bool indRech,
            string notes,
            List<Presences> listePresences,
            List<Etiquettes> listeSujets,
            string unNom
            )
        {
            this.Collection = collection;
            this.NomFichierOriginal = nomOriginal;
            this.NomFichierSM4D = nomSM4D;
            this.TypeMedia = typeMedia;
            this.TypeFichier = typeFichier;
            this.DatePrise = datePrise;
            int spanDate = 0;
            int.TryParse(span, out spanDate);
            this.SpanDatePrise = spanDate;
            this.Description = description;
            this.Site = lieu;      
            this.Evenement = evenement; 
            this.IndicateurRecherches = indRech;
            this.NotesRecherches = notes;
            DateHeureCreation = DateTime.Now;
            DateHeureModification = DateTime.Now;
            UtilisateurCreation = ConfigGlobale.UtilisateurCourant();
            UtilisateurModification = ConfigGlobale.UtilisateurCourant();
            this.Presences= listePresences;
            this.Etiquettes = listeSujets;
            this.Nom = unNom;

        }


    }
}
