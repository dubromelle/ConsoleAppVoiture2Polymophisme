using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVoiture2Polymophisme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Voiture> listeVoiture = new List<Voiture>();

            Electrique maVoiture1 = new Electrique("Opel", "Corsa",4 , 22);
            listeVoiture.Add(maVoiture1);

            Thermique maVoiture2 = new Thermique("Peugeot", "208", 6, "Essence");
            listeVoiture.Add(maVoiture2);

            Thermique maVoiture3 = new Thermique("Fiat", "1000tipla", 16, "Essence");
            listeVoiture.Add(maVoiture3);

            foreach (Voiture maVoiture in listeVoiture)
            {
                maVoiture.AfficherInfo();
            }

            Console.ReadKey();

        }
    }
}
