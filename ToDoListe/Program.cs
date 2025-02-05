
using System.Text.Json;

namespace ToDoListe
{
    class Program
    {
        static List<Aufgabe> aufgabenListe = new List<Aufgabe>();
        private static readonly string dateiPfad = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads/todoListe.json");


        static void Main()
        {
            Laden();
            while (true)
            {
                Console.WriteLine("\n--- To-Do Liste ---");
                Console.WriteLine("1 - Aufgabe hinzufügen");
                Console.WriteLine("2 - Aufgabe entfernen");
                Console.WriteLine("3 - Aufgaben anzeigen");
                Console.WriteLine("4 - Aufgabe als erledigt markieren");
                Console.WriteLine("5 - Programm beenden");
                Console.Write("Wähle eine Option: ");

                string eingabe = Console.ReadLine()!;

                switch (eingabe)
                {
                    case "1": AufgabeHinzufuegen(); break;
                    case "2": AufgabeEntfernen(); break;
                    case "3": AlleAufgabenAnzeigen(); break;
                    case "4": AufgabeErledigen(); break;
                    case "5": Speichern(); return;
                    default: Console.WriteLine("Ungültige Eingabe."); break;
                }
            }
        }

        static void AufgabeHinzufuegen()
        {
            Console.Write("Aufgabe: ");
            string beschreibung = Console.ReadLine();
            Console.Write("Priorität (hoch/mittel/niedrig): ");
            string prioritaet = Console.ReadLine().ToLower();
            Console.Write("Fälligkeitsdatum (YYYY-MM-DD): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime faelligkeit))
            {
                aufgabenListe.Add(new Aufgabe { Beschreibung = beschreibung, Prioritaet = prioritaet, Faelligkeit = faelligkeit, Erledigt = false });
                Console.WriteLine("Aufgabe hinzugefügt!");
            }
            else
            {
                Console.WriteLine("Ungültiges Datum.");
            }
        }

        static void AufgabeEntfernen()
        {
            AlleAufgabenAnzeigen();
            Console.Write("Nummer der zu entfernenden Aufgabe: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= aufgabenListe.Count)
            {
                aufgabenListe.RemoveAt(index - 1);
                Console.WriteLine("Aufgabe entfernt!");
            }
            else
            {
                Console.WriteLine("Ungültige Nummer.");
            }
        }

        static void AlleAufgabenAnzeigen()
        {
            if (aufgabenListe.Count == 0)
            {
                Console.WriteLine("Keine Aufgaben vorhanden.");
            }
            else
            {
                Console.WriteLine("\nTo-Do Liste:");
                for (int i = 0; i < aufgabenListe.Count; i++)
                {
                    var aufgabe = aufgabenListe[i];
                    string status = aufgabe.Erledigt ? "[✔]" : "[ ]";
                    Console.WriteLine($"{i + 1}. {status} {aufgabe.Beschreibung} (Priorität: {aufgabe.Prioritaet}, Fällig: {aufgabe.Faelligkeit:yyyy-MM-dd})");
                }
            }
        }

        static void AufgabeErledigen()
        {
            AlleAufgabenAnzeigen();
            Console.Write("Nummer der erledigten Aufgabe: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= aufgabenListe.Count)
            {
                aufgabenListe[index - 1].Erledigt = true;
                Console.WriteLine("Aufgabe als erledigt markiert!");
            }
            else
            {
                Console.WriteLine("Ungültige Nummer.");
            }
        }

        static void Speichern()
        {
            File.WriteAllText(dateiPfad, JsonSerializer.Serialize(aufgabenListe));
            Console.WriteLine("Daten gespeichert!");
        }

        static void Laden()
        {
            if (File.Exists(dateiPfad))
            {
                aufgabenListe = JsonSerializer.Deserialize<List<Aufgabe>>(File.ReadAllText(dateiPfad)) ?? new List<Aufgabe>();
            }
        }
    }

    class Aufgabe
    {
        public string Beschreibung { get; set; }
        public string Prioritaet { get; set; }
        public DateTime Faelligkeit { get; set; }
        public bool Erledigt { get; set; }
    }
}
