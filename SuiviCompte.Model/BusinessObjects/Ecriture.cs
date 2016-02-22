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
    /// Ligne d'écriture
    /// </summary>
    //[Table("ECRITURE")]
    public class Ecriture
    {
        //[Key, Column("ID")]
        public int Id { get; set; }

        //[Column("MONTANT")]
        public decimal Montant { get; set; }

        //[Column("COMMENTAIRE", TypeName ="nvarchar")]
        public string Commentaire { get; set; }

        // Relations
        //[Column("SENS_ECRITURE_CODE")]
        public virtual SensEcriture Sens { get; set; }

        //[Column("NATURE_ECRITURE_CODE")]
        public virtual NatureEcriture Nature { get; set; }

        //[Column("TYPE_ECRITURE_CODE")]
        public virtual TypeEcriture TypeEcriture { get; set; }
    }
}
