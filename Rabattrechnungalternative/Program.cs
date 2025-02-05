using System;

namespace Resttage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ist der Kunde Premium-Kunde? 'j' für ja, 'n' für nein:");
                bool premiumInput = Console.ReadLine().ToLower() == "j";

                Console.WriteLine("Ist die Bestellung über 100? 'j' für ja, 'n' für nein:");
                bool bestellung100 = Console.ReadLine().ToLower() == "j";

                string rabatt = (premiumInput && bestellung100) ? "20% Rabatt!" :
                    (premiumInput) ? "10% Rabatt." :
                    (bestellung100) ? "5% Rabatt." :
                    "Keine Rabatt.";

                Console.WriteLine(rabatt);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
            }
        }
    }
}