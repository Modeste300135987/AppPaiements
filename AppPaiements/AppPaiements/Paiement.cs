using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paiement
    {
        // Propriétés 
        public double Montant { get; set; }
        public string Description { get; set; }


        // Constructeur
        public Paiement(double montant, string description)
        {
            Montant = montant;
            Description = description;

        }

        // Méthode virtuelle 
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Montant :{Montant},Description:{Description}");

        }

    }
}
