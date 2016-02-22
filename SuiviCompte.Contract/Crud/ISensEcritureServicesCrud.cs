using SuiviCompte.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviCompte.Contract
{
    interface ISensEcritureServicesCrud
    {        
        SensEcriture Read(int id);        
    }
}
