using System;

namespace Resttage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Geben Sie einen gültigen Tag ein (1-31):");
                int tag = int.Parse(Console.ReadLine()!);

                if (tag < 1 || tag > 31)
                {
                    Console.WriteLine("Fehler: Der Tag muss zwischen 1 und 31 liegen.");
                    return;
                }

                Console.WriteLine("Geben Sie einen gültigen Monat ein (1-12):");
                int monat = int.Parse(Console.ReadLine()!);

                if (monat < 1 || monat > 12)
                {
                    Console.WriteLine("Fehler: Der Monat muss zwischen 1 und 12 liegen.");
                    return;
                }

                
                int maxTageImMonat;
                switch (monat)
                {
                    case 2: 
                        Console.WriteLine("Geben Sie das Jahr ein:");
                        int jahr = int.Parse(Console.ReadLine()!);
                        // Schaltjahr prüfen
                        maxTageImMonat = IstSchaltjahr(jahr) ? 29 : 28;
                        break;

                    case 4: // April
                    case 6: // Juni
                    case 9: // September
                    case 11: // November
                        maxTageImMonat = 30;
                        break;

                    default: // Alle anderen Monate haben 31 Tage
                        maxTageImMonat = 31;
                        break;
                }

                if (tag > maxTageImMonat)
                {
                    Console.WriteLine($"Fehler: Der Monat {monat} hat nur {maxTageImMonat} Tage.");
                    return;
                }

                // Resttage des Monats berechnen
                int resttage = maxTageImMonat - tag;
                Console.WriteLine($"Der Monat {monat} hat noch {resttage} Tage.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Fehler: Bitte geben Sie eine gültige Zahl ein.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ein unerwarteter Fehler ist aufgetreten: " + ex.Message);
            }
        }

        static bool IstSchaltjahr(int jahr)
        {
           
            return (jahr % 4 == 0 && jahr % 100 != 0) || (jahr % 400 == 0);
        }
    }
}
