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
                string kunde = Console.ReadLine().ToLower(); 
                Console.WriteLine("Ist die Bestellung über 100? 'j' für ja, 'n' für nein:");
                string bestellung = Console.ReadLine().ToLower();

                bool premiumInput = kunde == "j";
                bool bestellung100 = bestellung == "j";

                if (premiumInput && bestellung100)
                {
                    Console.WriteLine("Der Kunde ist Premium und die Bestellung über 100. 20% Rabatt!");
                }
                else if (premiumInput && !bestellung100)
                {
                    Console.WriteLine("Der Kunde ist Premium, aber die Bestellung ist unter 100. 10% Rabatt.");
                }
                else if (!premiumInput && bestellung100)
                {
                    Console.WriteLine("Der Kunde ist kein Premium-Kunde, aber die Bestellung ist über 100. 5% Rabatt.");
                }
                else
                {
                    Console.WriteLine("Der Kunde ist kein Premium-Kunde und die Bestellung ist unter 100. Keine Rabatt.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Fehler: Bitte geben Sie eine gültige Eingabe ein.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ein unerwarteter Fehler ist aufgetreten: " + ex.Message);
            }
        }
    }
}