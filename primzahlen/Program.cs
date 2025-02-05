

namespace Primzahlen
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Welcome to the Primzahlen-Programm!");
                Console.Write("Wie viele Zahlen möchten Sie eingeben? ");

                int anzahl = int.Parse(Console.ReadLine());
                int[] zahlen = new int[anzahl];
               

                // Zahlen vom Benutzer einlesen
                for (int i = 0; i < zahlen.Length; i++)
                {
                    Console.Write($"Geben Sie die {i + 1}. Zahl ein: ");
                    zahlen[i] = int.Parse(Console.ReadLine());
                }

                // Prüfen und ausgeben, ob die Zahlen Primzahlen sind
                Console.WriteLine("\nErgebnisse:");
                foreach (int zahl in zahlen)
                {
                    if (IstPrimzahl(zahl))
                        Console.WriteLine($"{zahl} ist eine Primzahl.");
                    else
                        Console.WriteLine($"{zahl} ist keine Primzahl.");
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

        static bool IstPrimzahl(int n)
        {
            if (n < 2)
                return false; // 0 und 1 sind keine Primzahlen

            for (int i = 2; i * i <= n; i++) // Nur bis zur Quadratwurzel von n prüfen
            {
                if (n % i == 0)
                    return false; // Wenn teilbar, keine Primzahl
            }

            return true; // Wenn nicht teilbar, dann Primzahl
        }
    }
}