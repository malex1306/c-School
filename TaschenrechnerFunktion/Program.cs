namespace TaschenrechnerFunktion
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Taschenrecher");

            Console.Write("Erste Zahl eingeben: ");
            double zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Zweite Zahl eingeben: ");
            double zahl2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Rechenoperation auswählen [(a)ddition | (m)ultiplikation | (d)ivision | (s)ubtraktion]: ");
            string rechenOperation = Convert.ToString(Console.ReadLine())!;

            double ergebnis = 0;
            Console.WriteLine("------------------------");

            switch (rechenOperation)
            {
                case "a":
                    ergebnis = Addition(zahl1, zahl2);
                    break;
                case "m":
                    ergebnis = Multiplication(zahl1, zahl2);
                    break;
                case "d":
                    if (zahl2 == 0)
                    {
                        Console.WriteLine("Division durch Null ist unzulässig!");
                    }
                    else
                    {
                        ergebnis = Division(zahl1, zahl2);
                    }

                    break;
                case "s":
                    ergebnis = Subtraction(zahl1, zahl2);
                    break;
                default:
                    Console.WriteLine("Ungültige Rechenoperation");
                    break;
            }

            Console.WriteLine($"Ergebnis = {ergebnis}");

            static double Addition(double a, double b)
            {
                return a + b;
            }

            static double Subtraction(double a, double b)
            {
                return a - b;
            }

            static double Multiplication(double a, double b)
            {
                return a * b;
            }

            static double Division(double a, double b)
            {
                return a / b;
            }
        }


    }
}