namespace ConsoleAppVoiture2Polymophisme
{
    public class Electrique : Voiture
    {
        private int capaciteBatterie;

        public Electrique(string modele, string marque, int puissanceFiscale, int capaciteBatterie)
        {
            this.modele = modele;
            this.marque = marque;
            this.puissanceFiscale = puissanceFiscale;
            this.capaciteBatterie = capaciteBatterie;
        }

        public void AjouterCapacite(int maCapacite)
        {
            capaciteBatterie = maCapacite;
        }

        public override double CalculPrixCarteGrise()
        {
                return (puissanceFiscale * 44.5 * 0.5);
        }

        public override void AfficherInfo()
        {
            System.Console.WriteLine(modele + " " + marque + " " + capaciteBatterie + "Kw");
            System.Console.WriteLine("Puissance fiscale : " + puissanceFiscale + " cv");
            System.Console.WriteLine("Prix carte grise : " + CalculPrixCarteGrise() + " Euros");
            System.Console.WriteLine();
        }
    }
}
