using System;

namespace BruttoVerkaufspreis
{
    class Program
    {
        static void Main()
        {
            try
            {
                
                Console.WriteLine("Welchen Artikel möchten Sie? Zur Auswahl steht Hummer:");
                string artikel = Console.ReadLine()!;

               
                Console.WriteLine("Für welchen Preis? Geben Sie einen Preis an:");
                double preis = double.Parse(Console.ReadLine()!);

               
                Console.WriteLine("Expressversand gewünscht? J für ja, N für nein:");
                string expressInput = Console.ReadLine()!.Trim().ToUpper();
                bool express = expressInput == "J";

                
                double versand = preis < 10 
                    ? (express ? preis + 7 : preis + 2) 
                    : (preis > 10 
                        ? (express ? preis + 8 : preis + 3)
                        : (express ? preis + 6 : preis)); 

               
                Console.WriteLine($"Artikel: {artikel}");
                Console.WriteLine($"Gesamtpreis inkl. Versand: {versand:F2} EUR");
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