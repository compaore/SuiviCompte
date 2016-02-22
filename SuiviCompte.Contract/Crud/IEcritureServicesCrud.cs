using SuiviCompte.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviCompte.Contract
{
    interface IEcritureServiceCrud
    {
        int Create(decimal montant, string commentaire, int nature, int sens, int typeEcriture);

        int Update(decimal montant, string commentaire, int nature, int sens, int typeEcriture);

        Ecriture Read(int id);

        bool Delete(int id);
    }
}
