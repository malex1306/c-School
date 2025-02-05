using System;

namespace Brutto_Netto_Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Geben Sie einen Bruttowert in Prozent an:");
                double userInput = Convert.ToDouble(Console.ReadLine());

                // Berechnung des Nettowertes
                userInput = Math.Round(userInput / 1.19, 2);
                Console.WriteLine("Der Nettobetrag ist: " + userInput + " Euro");
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
    }
}