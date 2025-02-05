using System;

namespace Zinsen
{
    class Program
    {
        static void Main()
        {
            try
            {
                double kapital;
                do
                {
                    Console.WriteLine("Geben Sie das Kapital ein (Mindestbetrag 100 EUR):");
                    kapital = Convert.ToDouble(Console.ReadLine());

                    if (kapital < 100)
                    {
                        Console.WriteLine("Fehler: Das Kapital muss mindestens 100 EUR betragen.");
                    }

                } while (kapital < 100);

                Console.WriteLine("Geben Sie den momentanen Zinssatz in Prozent an:");
                double zinsen = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Geben Sie die Anlagedauer in Jahren an:");
                int anlagedauer = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nJahr\tZinsen\tKapital");
                Console.WriteLine("-------------------");

                // Jährliche Zinseszins-Berechnung
                for (int jahr = 1; jahr <= anlagedauer; jahr++)
                {
                    double zinsbetrag = kapital * (zinsen / 100);
                    kapital += zinsbetrag; // Zinsen dem Kapital hinzufügen

                    Console.WriteLine($"{jahr}\t{zinsbetrag:F2}\t{kapital:F2} EUR");
                }

                Console.WriteLine($"\nNach {anlagedauer} Jahren beträgt das Endkapital: {kapital:F2} EUR.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Fehler: Bitte geben Sie gültige Zahlen ein.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ein unerwarteter Fehler ist aufgetreten: {ex.Message}");
            }
        }
    }
}