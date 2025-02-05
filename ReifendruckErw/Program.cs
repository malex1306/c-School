using System;

namespace Resttage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Wählen Sie den Fahrzeugtyp aus (1: Kleinwagen, 2: SUV, 3: Sportwagen):");
                int fahrzeugTyp = int.Parse(Console.ReadLine());

                double minDruck = 2.0, maxDruck = 2.8;

                switch (fahrzeugTyp)
                {
                    case 1: // Kleinwagen
                        minDruck = 2.2; maxDruck = 2.8;
                        break;
                    case 2: // SUV
                        minDruck = 2.4; maxDruck = 2.8;
                        break;
                    case 3: // Sportwagen
                        minDruck = 2.0; maxDruck = 2.4;
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl! Standardwerte (2.0–2.8) werden verwendet.");
                        break;
                }

                Console.WriteLine("Ist das Fahrzeug beladen? (ja/nein):");
                string beladen = Console.ReadLine().ToLower();
                if (beladen == "ja")
                {
                    minDruck += 0.2;
                    maxDruck += 0.2;
                    Console.WriteLine($"Der empfohlene Reifendruck wurde für Beladung angepasst: {minDruck:F1}–{maxDruck:F1} bar.");
                }

                Console.WriteLine("Geben Sie den Wert des rechten Vorderreifens ein:");
                double rv = double.Parse(Console.ReadLine());
                Console.WriteLine("Geben Sie den Wert des linken Vorderreifens ein:");
                double lv = double.Parse(Console.ReadLine());
                Console.WriteLine("Geben Sie den Wert des rechten Hinterreifens ein:");
                double hr = double.Parse(Console.ReadLine());
                Console.WriteLine("Geben Sie den Wert des linken Hinterreifens ein:");
                double hl = double.Parse(Console.ReadLine());

                bool rvOk = rv >= minDruck && rv <= maxDruck;
                bool lvOk = lv >= minDruck && lv <= maxDruck;
                bool hrOk = hr >= minDruck && hr <= maxDruck;
                bool hlOk = hl >= minDruck && hl <= maxDruck;

                string ReifenDruckVorne = (Math.Abs(rv - lv) < 0.001 && rvOk && lvOk) 
                    ? "Reifendruck vorne OK" 
                    : "Reifendruck vorne NICHT OK";

                string ReifenDruckHinten = (Math.Abs(hr - hl) < 0.001 && hrOk && hlOk) 
                    ? "Reifendruck hinten OK" 
                    : "Reifendruck hinten NICHT OK";

                Console.WriteLine($"Reifendruck vorne rechts: {(rvOk ? "In Ordnung" : "NICHT in Ordnung")}");
                Console.WriteLine($"Reifendruck vorne links: {(lvOk ? "In Ordnung" : "NICHT in Ordnung")}");
                Console.WriteLine($"Reifendruck hinten rechts: {(hrOk ? "In Ordnung" : "NICHT in Ordnung")}");
                Console.WriteLine($"Reifendruck hinten links: {(hlOk ? "In Ordnung" : "NICHT in Ordnung")}");

                if (!rvOk)
                    Console.WriteLine($"Hinweis: Der empfohlene Druck für vorne rechts liegt zwischen {minDruck:F1} und {maxDruck:F1} bar.");
                if (!lvOk)
                    Console.WriteLine($"Hinweis: Der empfohlene Druck für vorne links liegt zwischen {minDruck:F1} und {maxDruck:F1} bar.");
                if (!hrOk)
                    Console.WriteLine($"Hinweis: Der empfohlene Druck für hinten rechts liegt zwischen {minDruck:F1} und {maxDruck:F1} bar.");
                if (!hlOk)
                    Console.WriteLine($"Hinweis: Der empfohlene Druck für hinten links liegt zwischen {minDruck:F1} und {maxDruck:F1} bar.");

                Console.WriteLine($"\n{ReifenDruckVorne}");
                Console.WriteLine($"{ReifenDruckHinten}");

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
