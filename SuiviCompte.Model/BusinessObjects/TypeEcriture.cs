using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuiviCompte.Model
{
    /// <summary>
    /// Type de l'écriture : repas, abonnement, sortie
    /// </summary>
    //[Table("TYPE_ECRITURE")]
    public class TypeEcriture
    {
        //[Key, Column("CODE", TypeName = "nvarchar"), MinLength(1), MaxLength(1)]
        public string Id { get; set; }

        [MinLength(0), MaxLength(255)]
        public string Libelle { get; set; }

        //[Column("COMMENTAIRE", TypeName ="nvarchar")]
        public string Commentaire { get; set; }
    }
}
