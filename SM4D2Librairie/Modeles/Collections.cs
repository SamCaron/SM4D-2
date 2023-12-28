using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2Librairie.Modeles
{
    /// <summary>
    /// Collection de Media fournie par un(e) contributeur(trice)
    /// </summary>
    public class Collections
    {
        /// <summary>
        /// Identifiant unique attribue par le systeme a l'ajout
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nom court de la Collection, typiquement le nom complet du contributeur
        /// </summary>
        public string NomCollection { get; set; } = "";
        /// <summary>
        /// Notes additionnells 
        /// </summary>
        public string Notes { get; set; } = "";
        /// <summary>
        /// Lien vers le dossier de la personne qui est contributeur
        /// </summary>
        public string Contributeur { get; set; } = "";
        public string Responsable { get; set; } = "";
        public DateTime DateHeureCreation { get; set; }
        public DateTime DateHeureModification { get; set; }
        public Utilisateurs UtilisateurCreation { get; set; }
        public Utilisateurs UtilisateurModification { get; set; }
        /// <summary>
        /// Indicateur si la collection est deployee et peut être affiche
        /// </summary>
        public bool Deployee { get; set; }
        public override string ToString()
        {
            return Id.ToString() + " " + NomCollection;
        }
        // creer le sous-repertoire associe a la collection

        public string CreerSousRep()

        {
            string cheminSousRemp = ConfigGlobale.EmplacementImages() + SousRep();
            // vérifie si répertoire existe déjà
            if (!Directory.Exists(cheminSousRemp))
            {
                System.IO.Directory.CreateDirectory(cheminSousRemp);
            }        
            return cheminSousRemp;
        }
        // retourne le nom du sous-repertoire associe a la collection

        public string SousRep()
        {
            return ( NomCollection + "\\"); 
        }
        // retourne l'emplacement du sous-repertoire associe a la collection

        public string SousRepComplet()
        {
            string cheminComplet = ConfigGlobale.EmplacementImages() + NomCollection + "\\";
            if (!Directory.Exists(cheminComplet))
            {
                CreerSousRep();
            }
            return cheminComplet;
        }
        /// Collections - medias
        /// 
        /// Ajouter un Media au répertoire de la collection - nouveau
        public string  AjouterMedia(Medias unMedia, string chemin)
        {
            string nomFichierUnique = unMedia.NomFichierSM4D;
            // Vérifier si un fichier existe déjà avec ce nom.  si oui, lui attribuer un nom unique
            if (File.Exists(SousRepComplet() + nomFichierUnique))
            {
                int seq = 0;
                string ext = unMedia.TypeFichier;
                nomFichierUnique = nomFichierUnique.Replace(ext, seq.ToString("00") + ext);
                string nomCible = this.SousRepComplet() + nomFichierUnique;

                while (File.Exists(nomCible))
                {
                    seq++;
                    nomFichierUnique = nomFichierUnique.Replace(ext, seq.ToString("00") + ext);
                    nomCible = this.SousRepComplet() + nomFichierUnique;
                }
            }
            // copie du fichier et retour du nom rendu unique au besoin
            File.Copy(chemin, SousRepComplet() + nomFichierUnique);
            return nomFichierUnique;
        }
        /// Ajouter un Media au répertoire de la collection - d'une autre collection
        public string AjouterMedia(Medias unMedia, Collections collDe)
        {
            string nomFichierUnique = unMedia.NomFichierSM4D;
            // Vérifier si un fichier existe déjà avec ce nom.  si oui, lui attribuer un nom unique
            if (File.Exists(SousRepComplet() + nomFichierUnique))
            {
                int seq = 0;
                string ext = unMedia.TypeFichier;
                nomFichierUnique = nomFichierUnique.Replace(ext, seq.ToString("0000") + ext);
                string nomCible = this.SousRepComplet() + nomFichierUnique;

                while (File.Exists(nomCible))
                {
                    seq++;
                    nomFichierUnique = nomFichierUnique.Replace(ext, seq.ToString("0000") + ext);
                    nomCible = this.SousRepComplet() + nomFichierUnique;
                }
            }
            string source, destination;
            source = collDe.SousRepComplet() + unMedia.NomFichierSM4D;
            destination = SousRepComplet() + nomFichierUnique;
            File.Copy(source, destination);
            return nomFichierUnique;
        }

        /// Retirer un Media du répertoire de la collection
        public void RetirerMedia(Medias unMedia)
        {
            if (File.Exists(SousRepComplet() + unMedia.NomFichierSM4D))
            {
                File.Delete(SousRepComplet() + unMedia.NomFichierSM4D);
            }
        }

        //////////////////
        /// liste des attributs BD requis pour le mappage
        ///  <summary>

        public int IdContributeur;
        public int IdResponsable;
        public int IdUtilisateurCreation;
        public int IdUtilisateurModification;

    }
}
