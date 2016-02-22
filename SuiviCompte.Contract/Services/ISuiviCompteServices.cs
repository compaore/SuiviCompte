using SuiviCompte.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviCompte.Contract
{
    public interface ISuiviCompteServices
    {
        int AddEcriture(decimal montant, NatureEcriture nature, SensEcriture sens, TypeEcriture typeEcriture, string commentaire);
    }
}
