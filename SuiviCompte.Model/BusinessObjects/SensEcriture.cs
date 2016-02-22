using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuiviCompte.Model
{
    /// <summary>
    /// Sens de l'écriture  : D : Débit, C : Crédit
    /// </summary>
    //[Table("SENS_ECRITURE")]
    public class SensEcriture
    {
        [Key, MinLength(1), MaxLength(1)]
        public string Code { get; set; }

        [MinLength(0), MaxLength(255)]
        public string Libelle { get; set; }
    }  
}
