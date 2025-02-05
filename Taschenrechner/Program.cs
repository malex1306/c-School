using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Geben Sie die erste Zahl ein:");
                double zahl1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Geben Sie die zweite Zahl ein:");
                double zahl2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Geben Sie einen Operator an (+, -, *, /):");
                string operatorInput = Console.ReadLine();

                double ergebnis = 0;

                switch (operatorInput)
                {
                    case "+":
                        ergebnis = zahl1 + zahl2;
                        break;
                    case "-":
                        ergebnis = zahl1 - zahl2;
                        break;
                    case "*":
                        ergebnis = zahl1 * zahl2;
                        break;
                    case "/":
                        if (zahl2 != 0)
                        {
                            ergebnis = zahl1 / zahl2;
                        }
                        else
                        {
                            Console.WriteLine("Fehler: geteilt durch Null ist nicht erlaubt.");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Fehler: Ungueltiger Operator.");
                        return;
                }

                Console.WriteLine($"Das Ergebnis ist: {ergebnis}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Fehler: Bitte geben Sie eine gueltige Zahl ein.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ein unerwarteter Fehler ist aufgetreten: " + ex.Message);
            }
        }
    }
}