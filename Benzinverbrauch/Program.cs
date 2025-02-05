using System;

namespace Benzinverbrauch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Geben Sie ihre gefahrenen Kilometer an:");
                double km = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Geben Sie ihren Tankinhalt gesamt (in Litern) an:");
                double tankInhalt = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Geben Sie ihren aktuellen Fuelstand (in Prozent) an:");
                double fuelStandProzent = Convert.ToDouble(Console.ReadLine());
                
                double fuelStandLiter = (fuelStandProzent / 100) * tankInhalt;
                double verbrauchLiter = tankInhalt - fuelStandLiter;
                double verbrauch = (verbrauchLiter / km) * 100;
                Console.WriteLine("Der Verbrauch (Liter/100km) ist: " + Math.Round(verbrauch, 2));
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