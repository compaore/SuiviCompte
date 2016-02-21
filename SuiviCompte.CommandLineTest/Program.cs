using SuiviCompte.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviCompte.CommandLineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SuiviCompteModel())
            {
                var natureEcriture = new NatureEcriture();

                natureEcriture.Libelle = "Récurrent";
                natureEcriture.Commentaire = "le premier";
                context.NatureEcritureCollection.Add(natureEcriture);
                context.SaveChanges();

                Console.WriteLine("Ligne ajoutée");
            }

            Console.ReadLine();
        }
    }
}
