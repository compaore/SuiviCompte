using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviCompte.Model
{
    /// <summary>
    /// Sens de l'écriture  : D : Débit, C : Crédit
    /// </summary>
    public class SensEcriture
    {
        public string Id { get; set;  }
        public string Libelle { get; set; }
    }  
}
