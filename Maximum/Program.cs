using System;

namespace Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Eingabe der drei Zahlen
                Console.Write("Bitte geben Sie die erste Zahl ein: ");
                double zahl1 = double.Parse(Console.ReadLine());
                Console.Write("Bitte geben Sie die zweite Zahl ein: ");
                double zahl2 = double.Parse(Console.ReadLine());
                Console.Write("Bitte geben Sie die dritte Zahl ein: ");
                double zahl3 = double.Parse(Console.ReadLine());

               
                if (zahl1 > zahl2 && zahl1 > zahl3)
                {
                    Console.WriteLine("Die größte Zahl ist: " + zahl1);
                }
                else if (zahl2 > zahl1 && zahl2 > zahl3)
                {
                    Console.WriteLine("Die größte Zahl ist: " + zahl2);
                }
                else if (zahl3 > zahl1 && zahl3 > zahl2)
                {
                    Console.WriteLine("Die größte Zahl ist: " + zahl3);
                }
                else
                {
                    Console.WriteLine("Es gibt mindestens zwei gleich große Zahlen.");
                }
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