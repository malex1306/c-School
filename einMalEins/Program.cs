using System;

namespace einMalEins
{
    class Program
    {
        static void Main()
        {
            try
            {

                Console.Write("    ");
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"{i,4}");
                }

                Console.WriteLine();
                Console.WriteLine(new string('-', 45));

                // Matrix generieren
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"{i,2} |");
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write($"{i * j,4}"); // Matrix-Werte mit Abstand
                    }

                    Console.WriteLine();
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