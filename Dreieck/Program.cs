using System;

namespace Dreieck
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Gib die Höhe des Dreiecks ein: ");
                if (int.TryParse(Console.ReadLine(), out int hoehe) && hoehe > 0)
                { 
                    for (int i = 1; i <= hoehe; i++)
                    { 
                        // Leerzeichen für die Mitte ausrichten
                        Console.Write(new string(' ', hoehe - i));
                        // Sterne für die aktuelle Zeile ausgeben
                        Console.WriteLine(new string('*', 2 * i - 1));
                    }
                }
                else
                {
                    Console.WriteLine("Bitte eine gültige positive Zahl eingeben.");
                }
                    
                

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