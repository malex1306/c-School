using System;

namespace Forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine("zahl eingeben: "  );
                var n = Convert.ToInt32(Console.ReadLine());
                var summe = n * (n + 1) / 2;
                Console.WriteLine($"Die gausische Summe von 1 bis {n} ist: {summe}");

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