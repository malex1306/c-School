using System;

namespace Resttage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Geben Sie den Wert des rechten Vorderreifens ein:");
                double rv = double.Parse(Console.ReadLine().Replace(',', '.'));
                Console.WriteLine("Geben Sie den Wert des linken Vorderreifens ein:");
                double lv = double.Parse(Console.ReadLine().Replace(',', '.'));
                Console.WriteLine("Geben Sie den Wert des rechten Hinterreifens ein:");
                double hr = double.Parse(Console.ReadLine().Replace(',', '.'));
                Console.WriteLine("Geben Sie den Wert des linken Hinterreifens ein:");
                double hl = double.Parse(Console.ReadLine().Replace(',', '.'));

               
                double minDruck = 2.0 - 0.3;
                double maxDruck = 2.0 + 0.3;

              
                bool rvOk = rv >= minDruck && rv <= maxDruck;
                bool lvOk = lv >= minDruck && lv <= maxDruck;
                bool hrOk = hr >= minDruck && hr <= maxDruck;
                bool hlOk = hl >= minDruck && hl <= maxDruck;

               
                Console.WriteLine($"Reifendruck vorne rechts: {(rvOk ? "in Ordnung" : "NICHT in Ordnung")}");
                Console.WriteLine($"Reifendruck vorne links: {(lvOk ? "in Ordnung" : "NICHT in Ordnung")}");
                Console.WriteLine($"Reifendruck hinten rechts: {(hrOk ? "in Ordnung" : "NICHT in Ordnung")}");
                Console.WriteLine($"Reifendruck hinten links: {(hlOk ? "in Ordnung" : "NICHT in Ordnung")}");

               
                double toleranz = 0.3; 

                bool vorneOk = Math.Abs(rv - lv) <= toleranz;
                bool hintenOk = Math.Abs(hr - hl) <= toleranz;

                string reifenDruckVorne = vorneOk ? "Reifendruck vorne OK" : "Reifendruck vorne NICHT OK";
                string reifenDruckHinten = hintenOk ? "Reifendruck hinten OK" : "Reifendruck hinten NICHT OK";

                Console.WriteLine($"\n{reifenDruckVorne}");
                Console.WriteLine($"{reifenDruckHinten}");

                // Gesamtausgabe
                bool alleOk = rvOk && lvOk && hrOk && hlOk;
                string gesamtStatus = alleOk ? "Alle Reifendrücke sind im zulässigen Bereich." : "Mindestens ein Reifendruck ist NICHT im zulässigen Bereich.";
                Console.WriteLine($"\n{gesamtStatus}");
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
