
namespace Informatik_2
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Hat Franziska Lust auf Lernen? (j/n): ");
                bool lustInput = Console.ReadLine()?.ToLower() == "j";

                Console.Write("Hat ihr Freund Abendschicht? (j/n) ");
                bool abendschicht = Console.ReadLine()?.ToLower() == "j";

                Console.Write("Denkt Franziska an ihre Prüfung? (j/n) ");
                bool pruefung = Console.ReadLine()?.ToLower() == "j";

                
                string entscheidung = 
                    ((lustInput && !abendschicht) || (!lustInput && pruefung && !abendschicht)) ? "Franziska besucht die Vorlesung.Geht aber in der Pause" :
                    ((lustInput && abendschicht) || (!lustInput && pruefung && abendschicht)) ? "Franziska besucht die ganze Vorlesung." :
                    "Franziska bleibt zuhause und beschäftigt sich anders.";

                Console.WriteLine(entscheidung);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
            }
        }
    }
}