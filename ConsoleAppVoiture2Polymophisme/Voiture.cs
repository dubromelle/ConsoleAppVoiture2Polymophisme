namespace ConsoleAppVoiture2Polymophisme
{
    public abstract class Voiture
    {
        protected string modele;
        protected string marque;
        protected int puissanceFiscale;

        public abstract void AfficherInfo();

        public abstract double CalculPrixCarteGrise();
    }
}
