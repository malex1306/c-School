using System;

namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            bool weitermachen = true;

            while (weitermachen)
            {
                try
                {
                    double gewicht = 0.0;
                    double groesse = 0.0;
                    double alter = 0.0;
                    double cm = 0.0;
                    double bmi = 0.0;

                
                    while (true)
                    {
                        Console.WriteLine("Bitte geben Sie Ihr Gewicht in kg ein:");
                        if (double.TryParse(Console.ReadLine(), out gewicht) && gewicht > 0)
                            break;
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive Zahl ein.");
                    }

                    
                    while (true)
                    {
                        Console.WriteLine("Bitte geben Sie Ihre Größe in cm ein:");
                        if (double.TryParse(Console.ReadLine(), out cm) && cm > 0)
                            break;
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive Zahl ein.");
                    }

                    
                    while (true)
                    {
                        Console.WriteLine("Bitte geben Sie Ihr Alter ein:");
                        if (double.TryParse(Console.ReadLine(), out alter) && alter > 0)
                            break;
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive Zahl ein.");
                    }

                    
                    groesse = cm / 100;
                    bmi = gewicht / Math.Pow(groesse, 2);

                    
                    if (alter >= 19 && alter <= 24)
                    {
                        if (bmi < 19)
                        {
                            Console.WriteLine("Untergewicht");
                        }
                        else if (bmi >= 19 && bmi <= 24)
                        {
                            Console.WriteLine("Normalgewicht");
                        }
                        else
                        {
                            Console.WriteLine("Übergewicht");
                        }
                    }
                    else if (alter >= 25 && alter <= 34)
                    {
                        if (bmi < 20)
                        {
                            Console.WriteLine("Untergewicht");
                        }
                        else if (bmi >= 20 && bmi <= 25)
                        {
                            Console.WriteLine("Normalgewicht");
                        }
                        else
                        {
                            Console.WriteLine("Übergewicht");
                        }
                    }
                    else if (alter >= 35)
                    {
                        if (bmi < 22)
                        {
                            Console.WriteLine("Untergewicht");
                        }
                        else if (bmi >= 22 && bmi <= 29)
                        {
                            Console.WriteLine("Normalgewicht");
                        }
                        else
                        {
                            Console.WriteLine("Übergewicht");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Für Ihr Alter gibt es keine spezifischen BMI-Grenzwerte.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ein unerwarteter Fehler ist aufgetreten: " + ex.Message);
                }

                
                Console.WriteLine("\nMöchten Sie eine weitere Berechnung durchführen? (j/n)");
                string antwort = Console.ReadLine().ToLower();
                if (antwort != "j" && antwort != "ja")
                {
                    weitermachen = false;
                    Console.WriteLine("Programm wird beendet. Auf Wiedersehen!");
                }
            }
        }
    }
}
