using System;

namespace Resttage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hat Franziska Lust auf Lernen? 'j' für ja, 'n' für nein:");
                bool lustInput = Console.ReadLine().ToLower() == "j";

                Console.WriteLine("Hat ihr Freund Abendschicht? 'j' für ja, 'n' für nein:");
                bool abendschicht = Console.ReadLine().ToLower() == "j";

                Console.WriteLine("Denkt Franziska an ihre Prüfung? 'j' für ja, 'n' für nein:");
                bool pruefung = Console.ReadLine().ToLower() == "j";

                string entscheidung;

                if (lustInput && !abendschicht)
                {
                    entscheidung = "Franziska besucht die ganze Vorlesung.";
                }
                else if (lustInput && abendschicht)
                {
                    entscheidung = "Franziska geht aber in der Pause.";
                }
                else if (!lustInput && pruefung && abendschicht)
                {
                    entscheidung = "Franziska besucht die Vorlesung.";
                }
                else if (!lustInput && pruefung && !abendschicht)
                {
                    entscheidung = "Franziska bleibt zuhause.";
                }
                else
                {
                    entscheidung = "Franziska bleibt zuhause und beschäftigt sich anders.";
                }

                Console.WriteLine(entscheidung);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
            }
        }
    }
}