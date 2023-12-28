using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM4D2Librairie.Modeles
{
    public class MediasFiltres
    {
        /// <summary>
        /// critere sur le Id
        /// </summary>
        public int Id { get; set; }
       /// <summary>
        /// Critere sur Nom du fichier attribue 
        /// </summary>
        public string NomFichierSM4D { get; set; } = "";
        /// <summary>
        /// criter sur Type de Media, i.e. Photo, Video, Document, Audio
        /// </summary>
        // todo implanter critere et domaines TypeMedia
        public string TypeMedia { get; set; } = "";
        /// <summary>
        /// criter sur Type de fichier du media, i.e. jpg, png, wmv, mp4, pdf, mp3
        /// </summary>
        // todo implanter critere et domaines TypeFichier
        public string TypeFichier { get; set; } = "";
        /// <summary>
        /// critere Date a laquelle le media aurait ete pris, debut
        /// </summary>
        public DateTime DatePriseDebut { get; set; }
        /// <summary>
        /// critere Date a laquelle le media aurait ete pris, Fin
        /// </summary>
        public DateTime DatePriseFin { get; set; }
        /// <summary>
        /// critere texte contenu dans Description generale du contenu du media
        /// </summary>
        public string Description { get; set; } = "";
        /// <summary>
        /// Critere d'indicateurs de Recherches Lieu où le media aurait ete pris
        /// </summary>
        public string IndicateurRecherches { get; set; }
        /// <summary>
        /// Critere sur le début de la date de creation
        /// </summary>
        public DateTime DateHeureCreationDebut { get; set; }
        /// <summary>
        /// Critere sur la fin de la date de creation
        /// </summary>
        public DateTime DateHeureCreationFin { get; set; }
        /// <summary>
        /// Critere sur le début de la date de modification
        /// </summary>
        public DateTime DateHeureModificationDebut { get; set; }
        /// <summary>
        /// Critere sur la fin de la date de modification
        /// </summary>
        public DateTime DateHeureModificationFin { get; set; }
        /// <summary>
        /// Critere sur la collection
        /// </summary>
        public int IdCollection { get; set; }
        /// <summary>
        /// Critere sur Lieu où le media aurait ete pris
        /// </summary>
        public int IdLieuPrise { get; set; }
        /// <summary>
        /// Critere sur l'evenement durant lequel le media aurait ete pris
        /// </summary>
        public int IdEvenement { get; set; }
        /// <summary>
        /// Critere sur le sujet 
        /// </summary>
        public float? IdSujet { get; set; }
        /// <summary>
        /// Critere sur le niveau du sujet
        /// </summary>
        public int NiveauSujet { get; set; }
        public MediasFiltres()
        {
            DatePriseDebut = new DateTime(1800,01,01);
            DatePriseFin = DateTime.Today;
            DateHeureCreationDebut = new DateTime(2023, 01, 01);
            DateHeureModificationDebut = new DateTime(2023, 01, 01);
            DateHeureModificationFin = DateTime.Now;
            DateHeureCreationFin = DateTime.Now;

            
        }
    }
 


}
