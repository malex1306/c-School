using System;

namespace Resttage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ist die Bonität hoch? 'j' für ja, 'n' für nein:");
                bool bonitaetInput = Console.ReadLine().ToLower() == "j";

                Console.WriteLine("Liegt das einkommen über 3000 Euro? 'j' für ja, 'n' für nein:");
                bool einkommen = Console.ReadLine().ToLower() == "j";

                string bewilligung = (bonitaetInput && einkommen) ? "Kredit bewilligen!" :
                    (bonitaetInput) ? "Kredit mit höheren Zinssatz bewilligen." :
                    (einkommen) ? "Kredit mit Sicherheitsnachweis bewilligen." :
                    "Kredit abgelehnt.";

                Console.WriteLine(bewilligung);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
            }
        }
    }
}