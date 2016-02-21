using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviCompte.Model
{
    /// <summary>
    /// Type de l'écriture : repas, abonnement, sortie
    /// </summary>
    public class TypeEcriture
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Commentaire { get; set; }
    }
}
