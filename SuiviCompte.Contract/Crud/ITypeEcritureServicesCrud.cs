using SuiviCompte.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviCompte.Contract
{
    interface ITypeEcritureServicesCrud
    {
        int Create(string libelle, string commentaire);

        int Update(string libelle, string commentaire);

        TypeEcriture Read(int id);

        bool Delete(int id);
    }
}
