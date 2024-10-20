using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilisateur
    {
        public string Nom { get; set; }
        public List<Paiement> liste_paiements { get; set; }

        public Utilisateur(string nom)
        {
            Nom = nom;
            liste_paiements = new List<Paiement>();
        }

        public void AjouterPaiement(Paiement paiement)
        {
            liste_paiements.Add(paiement);
        }

        public void AfficherInfos()
        {
            Console.WriteLine($"Utilisateur: {Nom}");
            Console.WriteLine("Liste des paiements:");
            foreach (var paiement in liste_paiements)
            {
                paiement.AfficherDetails();
            }
        }
    }
}
