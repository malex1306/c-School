using System;

namespace Schaltjahr
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Bitte geben Sie eine Jahreszahl ein: ");
                int jahresZahl = int.Parse(Console.ReadLine());

                
                if ((jahresZahl % 4 == 0 && jahresZahl % 100 != 0) || (jahresZahl % 400 == 0))
                {
                    Console.WriteLine($"{jahresZahl} ist ein Schaltjahr.");
                }
                else
                {
                    Console.WriteLine($"{jahresZahl} ist kein Schaltjahr.");
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