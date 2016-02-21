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
    public class Ecriture
    {
        public int Id { get; set; }
        public decimal Montant { get; set; }
        public string Commentaire { get; set; }
        public virtual SensEcriture Sens { get; set; }
        
        public virtual NatureEcriture Nature { get; set; }
        public virtual TypeEcriture TypeEcriture { get; set; }
    }
}
