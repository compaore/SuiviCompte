using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviCompte.Model
{

    /// <summary>
    /// Nature de l'écriture : Récurrent, Exceptionnel, Non-récurrent
    /// </summary>
    //[Table("NATURE_ECRITURE")]
    public class NatureEcriture
    {
        //public int Id { get; set; }
        //[Key, MinLength(1), MaxLength(1)]
        public string Id { get; set; }

        [MinLength(0), MaxLength(255)]
        public string Libelle { get; set; }

        //[Column("COMMENTAIRE", TypeName="nvarchar")]
        public string Commentaire { get; set; }
    }
}
