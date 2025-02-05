namespace Warenkorb
{
    class Program
    {
        // Dictionary zur Speicherung der Produkte und deren Mengen
        static Dictionary<string, int> produktListe = new Dictionary<string, int>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n--- Warenkorb ---");
                Console.WriteLine("1 - Produkt hinzufügen");
                Console.WriteLine("2 - Produkt entfernen");
                Console.WriteLine("3 - Produkt suchen");
                Console.WriteLine("4 - Alle Produkte anzeigen");
                
                Console.WriteLine("5 - Programm beenden");
                Console.Write("Wähle eine Option: ");

                string eingabe = Console.ReadLine();

                switch (eingabe)
                {
                    case "1":
                        Console.Write("Produktname eingeben: ");
                        string produktHinzufuegen = Console.ReadLine();
                        Console.Write("Anzahl eingeben: ");
                        if (int.TryParse(Console.ReadLine(), out int menge) && menge > 0)
                        {
                            ProduktHinzufuegen(produktHinzufuegen, menge);
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Anzahl.");
                        }

                        break;
                    case "2":
                        Console.Write("Produktname zum Entfernen eingeben: ");
                        string produktEntfernen = Console.ReadLine();
                        Console.Write("Anzahl eingeben: ");
                        if (int.TryParse(Console.ReadLine(), out int entferneMenge) && entferneMenge > 0)
                        {
                            ProduktEntfernen(produktEntfernen, entferneMenge);
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Anzahl.");
                        }

                        break;
                    case "3":
                        Console.Write("Produktname zum Suchen eingeben: ");
                        string produktSuchen = Console.ReadLine();
                        ProduktSuchen(produktSuchen);
                        break;
                    case "4":
                        AlleProdukteAnzeigen();
                        break;
                    case "5":
                        Console.WriteLine("Programm wird beendet...");
                        return;
                    default:
                        Console.WriteLine("Ungültige Eingabe, bitte erneut versuchen.");
                        break;
                }
            }
        }

        // Methode zum Hinzufügen eines Produkts mit Menge
        static void ProduktHinzufuegen(string produkt, int menge)
        {
            if (!string.IsNullOrWhiteSpace(produkt))
            {
                if (produktListe.ContainsKey(produkt))
                {
                    produktListe[produkt] += menge;
                }
                else
                {
                    produktListe[produkt] = menge;
                }

                Console.WriteLine($"Produkt '{produkt}' wurde um {menge} erhöht. Gesamt: {produktListe[produkt]}");
            }
            else
            {
                Console.WriteLine("Produktname darf nicht leer sein.");
            }
        }

        // Methode zum Entfernen einer bestimmten Menge eines Produkts
        static void ProduktEntfernen(string produkt, int menge)
        {
            if (produktListe.ContainsKey(produkt))
            {
                if (produktListe[produkt] > menge)
                {
                    produktListe[produkt] -= menge;
                    Console.WriteLine(
                        $"Produkt '{produkt}' wurde um {menge} reduziert. Verbleibend: {produktListe[produkt]}");
                }
                else
                {
                    produktListe.Remove(produkt);
                    Console.WriteLine($"Produkt '{produkt}' wurde komplett entfernt.");
                }
            }
            else
            {
                Console.WriteLine($"Produkt '{produkt}' ist nicht in der Liste.");
            }
        }

        // Methode zum Suchen eines Produkts
        static void ProduktSuchen(string produkt)
        {
            if (produktListe.ContainsKey(produkt))
            {
                Console.WriteLine($"Produkt '{produkt}' ist in der Liste mit {produktListe[produkt]} Stück.");
            }
            else
            {
                Console.WriteLine($"Produkt '{produkt}' wurde nicht gefunden.");
            }
        }

        // Methode zum Anzeigen aller Produkte mit Mengenangabe
        static void AlleProdukteAnzeigen()
        {
            if (produktListe.Count == 0)
            {
                Console.WriteLine("Die Produktliste ist leer.");
            }
            else
            {
                Console.WriteLine("Produkte in der Liste:");
                foreach (var produkt in produktListe)
                {
                    Console.WriteLine($"- {produkt.Key}: {produkt.Value} Stück");
                }
            }
        }
    }
}
