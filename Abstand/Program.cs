using System;

namespace Abstand
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Um den abstand zu berechnen geben sie zuerst einen x Wert an:");
                double userInput = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("jetzt den endpunkt y Wert angeben:");
                double userInput2 = Convert.ToDouble(Console.ReadLine()); 
                Console.WriteLine("nun geben sie ein x Wert an:");
                double userInput3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("jetzt den endpunkt y Wert angeben:");
                double userInput4 = Convert.ToDouble(Console.ReadLine());
                double abstand = Math.Sqrt(Math.Pow(userInput - userInput3, 2) + Math.Pow(userInput2 - userInput4, 2));
                Console.WriteLine("Der Abstand betraegt:" + abstand);
                
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