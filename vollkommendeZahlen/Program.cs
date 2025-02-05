using System;

namespace vollkommendeZahlen
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Vollkommene Zahlen zwischen 1 und 10.000:");

                for (int i = 1; i <= 100000000; i++)
                { 
                    if (IstVollkommeneZahl(i))
                    {
                        Console.WriteLine(i);
                    }
                }
                    

                static bool IstVollkommeneZahl(int zahl)
                    {
                        int summe = 0;

                        // Echte Teiler der Zahl finden
                        for (int i = 1; i <= zahl / 2; i++)
                        {
                            if (zahl % i == 0)
                            {
                                summe += i;
                            }
                        }

                        // Prüfen, ob die Summe der Teiler der Zahl entspricht
                        return summe == zahl;
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