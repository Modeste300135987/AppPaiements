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

    }
}