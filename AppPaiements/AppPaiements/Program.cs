using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Mr Younes");
        CarteCredit paiement1 = new CarteCredit(124.00, "Achat a sportchek", 76346367);
        CarteCredit paiement2 = new CarteCredit(381.00, "Achat assurance voiture", 2377661);
        CarteCredit paiement3 = new CarteCredit(25.00, "Achat Pizza", 8887);

        paiement1.AfficherDetails();
        paiement2.AfficherDetails();
        paiement3.AfficherDetails();


        Paypal paiementPaypal1 = new Paypal(166.00, "Achat en ligne", "Jennifer@exemple.ca");
        Paypal paiementPaypal2 = new Paypal(438.00, "Achat en ligne", "Wendy@exemple.ca");

        paiementPaypal1.AfficherDetails();
        paiementPaypal2.AfficherDetails();




        // Création de l'utilisateur
        Utilisateur utilisateur = new Utilisateur("Modeste Ewinsou");

        // paiements à l'utilisateur
        utilisateur.AjouterPaiement(paiement1);
        utilisateur.AjouterPaiement(paiement2);
        utilisateur.AjouterPaiement(paiement3);
        utilisateur.AjouterPaiement(paiementPaypal1);
        utilisateur.AjouterPaiement(paiementPaypal2);

        // Affichage info utilisateur et paiements
        utilisateur.AfficherInfos();

    }
}