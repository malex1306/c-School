using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double zahl1 = GetInput("Geben Sie die erste Zahl ein:");
                double zahl2 = GetInput("Geben Sie die zweite Zahl ein:");
                Console.WriteLine("Geben Sie einen Operator an (+, -, *, /):");
                string operatorInput = Console.ReadLine();

                double ergebnis = operatorInput switch
                {
                    "+" => zahl1 + zahl2,
                    "-" => zahl1 - zahl2,
                    "*" => zahl1 * zahl2,
                    "/" => zahl2 != 0 ? zahl1 / zahl2 : throw new DivideByZeroException(),
                    _ => throw new InvalidOperationException("Ungültiger Operator")
                };

                Console.WriteLine($"Das Ergebnis ist: {ergebnis}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Fehler: Bitte geben Sie eine gültige Zahl ein.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Fehler: Geteilt durch Null ist nicht erlaubt.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
            }
        }

        static double GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                return result;
            }
            throw new FormatException();
        }
    }
}