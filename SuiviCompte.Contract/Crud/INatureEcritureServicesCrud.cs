using SuiviCompte.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviCompte.Contract
{
    interface INatureServicesCrud
    {
        int Create(string libelle, string commentaire);

        int Update(string libelle, string commentaire);

        NatureEcriture Read(int id);

        bool Delete(int id);
    }
}
