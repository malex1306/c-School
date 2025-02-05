using System;

namespace Forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double gewicht = 0.0;
                double groesse = 0.0;
                double alter = 0.0;
                double cm = 0.0;
                double bmi = 0.0;

                Console.WriteLine("Bitte geben Sie Ihr Gewicht in kg ein:");
                gewicht = Double.Parse(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie Ihre Größe in cm ein:");
                cm = Double.Parse(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie Ihr Alter ein:");
                alter = Double.Parse(Console.ReadLine());

                groesse = cm / 100; 
                bmi = gewicht / Math.Pow(groesse, 2); 

                if (alter >= 19 && alter <= 24 && bmi >= 19 && bmi <= 24)
                {
                    Console.WriteLine("Normalgewicht")
                }
                else if (alter >= 25 && alter <= 34 && bmi >= 20 && bmi <= 25)
                {
                    Console.WriteLine("Normalgewicht");
                }
                else if (alter >= 35 && bmi >= 22 && bmi <= 29)
                {
                    Console.WriteLine("Normalgewicht");
                }
                else
                {
                    Console.WriteLine("Übergewicht");
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