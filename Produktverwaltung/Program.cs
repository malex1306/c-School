using System;
using System.Collections.Generic;

namespace Produktverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            ProduktVerwaltung verwaltung = new ProduktVerwaltung();

            while (true)
            {
                Console.WriteLine("\nWas möchtest du tun?");
                Console.WriteLine("1. Produkt hinzufügen");
                Console.WriteLine("2. Alle Produkte anzeigen");
                Console.WriteLine("3. Produkt suchen");
                Console.WriteLine("4. Produkt verkaufen");
                Console.WriteLine("5. Beenden");
                
                string auswahl = Console.ReadLine();

                switch (auswahl)
                {
                    case "1":
                        Console.WriteLine("\nGib den Namen des Produktes ein: ");
                        string namen = Console.ReadLine();
                        
                        double preis;
                        Console.WriteLine("Gib den Preis des Produktes ein: ");
                        while (!double.TryParse(Console.ReadLine(), out preis) || preis < 0)
                        {
                            Console.WriteLine("Ungültiger Preis. Bitte erneut eingeben: ");
                        }

                        int lagerbestand;
                        Console.WriteLine("Gib den Lagerbestand ein: ");
                        while (!int.TryParse(Console.ReadLine(), out lagerbestand) || lagerbestand < 0)
                        {
                            Console.WriteLine("Ungültiger Lagerbestand. Bitte erneut eingeben: ");
                        }

                        verwaltung.ProduktHinzufuegen(new Produkt(namen, preis, lagerbestand));
                        Console.WriteLine("✅ Produkt erfolgreich hinzugefügt!");
                        break;

                    case "2":
                        verwaltung.ProdukteAnzeigen();
                        break;

                    case "3":
                        Console.WriteLine("\nGib den Namen des Produkts ein, das du suchen möchtest:");
                        string suchName = Console.ReadLine();
                        Produkt gefundenesProdukt = verwaltung.ProduktSuchen(suchName);

                        if (gefundenesProdukt != null)
                        {
                            Console.WriteLine($"✅ Produkt gefunden: Name: {gefundenesProdukt.Name}, Preis: {gefundenesProdukt.Preis}€, Lagerbestand: {gefundenesProdukt.Lagerbestand}");
                        }
                        else
                        {
                            Console.WriteLine("❌ Produkt nicht gefunden!");
                        }
                        break;

                    case "4":
                        Console.WriteLine("\nGib den Namen des Produkts ein, das du verkaufen möchtest:");
                        string verkaufsName = Console.ReadLine();

                        int menge;
                        Console.WriteLine("Gib die Menge an, die du verkaufen möchtest:");
                        while (!int.TryParse(Console.ReadLine(), out menge) || menge <= 0)
                        {
                            Console.WriteLine("Ungültige Menge. Bitte erneut eingeben:");
                        }

                        verwaltung.ProduktVerkaufen(verkaufsName, menge);
                        break;

                    case "5":
                        Console.WriteLine("Programm beendet.");
                        return;

                    default:
                        Console.WriteLine("❌ Ungültige Eingabe, bitte erneut versuchen.");
                        break;
                }
            }
        }
    }

    class Produkt
    {
        public string Name { get; set; }
        public double Preis { get; set; }
        public int Lagerbestand { get; set; }  // Korrigiert: Lagerbestand ist jetzt `int`

        public Produkt(string name, double preis, int lagerbestand)
        {
            Name = name;
            Preis = preis;
            Lagerbestand = lagerbestand;
        }
    }

    class ProduktVerwaltung
    {
        private List<Produkt> produkte = new List<Produkt>();

        public void ProduktHinzufuegen(Produkt produkt)
        {
            produkte.Add(produkt);
        }

        public void ProdukteAnzeigen()
        {
            if (produkte.Count == 0)
            {
                Console.WriteLine("⚠ Keine Produkte vorhanden.");
                return;
            }

            Console.WriteLine("\n📜 Liste der Produkte:");
            foreach (var produkt in produkte)
            {
                Console.WriteLine($"🛒 Name: {produkt.Name}, 💰 Preis: {produkt.Preis}€, 📦 Lagerbestand: {produkt.Lagerbestand}");
            }
        }

        public Produkt ProduktSuchen(string name)
        {
            return produkte.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void ProduktVerkaufen(string name, int menge)
        {
            Produkt produkt = ProduktSuchen(name);

            if (produkt == null)
            {
                Console.WriteLine("❌ Produkt nicht gefunden!");
                return;
            }

            if (produkt.Lagerbestand < menge)
            {
                Console.WriteLine($"⚠ Nicht genug Lagerbestand! Verfügbar: {produkt.Lagerbestand}, benötigt: {menge}");
                return;
            }

            produkt.Lagerbestand -= menge;
            Console.WriteLine($"✅ Verkauf erfolgreich! {menge} Stück von {produkt.Name} verkauft. Neuer Lagerbestand: {produkt.Lagerbestand}");
        }
    }
}
