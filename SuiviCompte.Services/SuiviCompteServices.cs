using SuiviCompte.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuiviCompte.Model;

namespace SuiviCompte.Services
{
    public class SuiviCompteServices : ISuiviCompteServices
    {
        public int AddEcriture(decimal montant, NatureEcriture nature, SensEcriture sens, TypeEcriture typeEcriture, string commentaire)
        {
            throw new NotImplementedException();

            // TODO : POCO ???
        }
    }
}
