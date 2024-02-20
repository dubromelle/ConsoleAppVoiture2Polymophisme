namespace ConsoleAppVoiture2Polymophisme
{
    public class Thermique : Voiture
    {
        private string carburant;

        public Thermique(string modele, string marque, int puissanceFiscale, string carburant)
        {
            this.modele = modele;
            this.marque = marque;
            this.puissanceFiscale = puissanceFiscale;
            this.carburant = carburant;
        }

        public void AjouterCarburant(string monCarburant)
        {
            carburant = monCarburant;
        }
        public override double CalculPrixCarteGrise()
        {
            return (puissanceFiscale * 44.5);
        }

        public override void AfficherInfo()
        {
            System.Console.WriteLine(modele + " " + marque + " " + carburant);
            System.Console.WriteLine("Puissance fiscale : " + puissanceFiscale + " cv");
            System.Console.WriteLine("Prix carte grise : " + CalculPrixCarteGrise() + " Euros");
            System.Console.WriteLine();
        }
    }
}
