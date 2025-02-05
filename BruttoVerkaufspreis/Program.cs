using System;

namespace BruttoVerkaufspreis
{
    class Program
    {
        static void Main()
        {
            try
            {
                
                Console.WriteLine("Geben Sie den alten Zählerstand ein:");
                double zaehlerstandAlt = double.Parse(Console.ReadLine()!);

                
                Console.WriteLine("Geben Sie den neuen Zählerstand ein:");
                double zaehlerstandNeu = double.Parse(Console.ReadLine()!);

                
                double verbrauch = zaehlerstandNeu - zaehlerstandAlt;

                if (verbrauch <= 0)
                {
                    Console.WriteLine("Fehler: Der neue Zählerstand muss größer als der alte sein.");
                    return;
                }

                
                double preisProEinheit;
                if (verbrauch >= 1 && verbrauch <= 10)
                {
                    preisProEinheit = 0.12;
                }
                else if (verbrauch >= 11 && verbrauch <= 50)
                {
                    preisProEinheit = 0.07;
                }
                else if (verbrauch >= 51 && verbrauch <= 100)
                {
                    preisProEinheit = 0.06;
                }
                else
                {
                    preisProEinheit = 0.05;
                }

               
                double nettoVerkaufspreis = verbrauch * preisProEinheit;

                
                double mehrwertsteuer = nettoVerkaufspreis * 0.16;

                
                double bruttoVerkaufspreis = nettoVerkaufspreis + mehrwertsteuer;

                
                Console.WriteLine("\nErgebnisse:");
                Console.WriteLine($"Verbrauch: {verbrauch} Einheiten");
                Console.WriteLine($"Preis pro Einheit: {preisProEinheit:F2} €");
                Console.WriteLine($"Nettopreis: {nettoVerkaufspreis:F2} €");
                Console.WriteLine($"Mehrwertsteuer (16%): {mehrwertsteuer:F2} €");
                Console.WriteLine($"Bruttoverkaufspreis: {bruttoVerkaufspreis:F2} €");
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
