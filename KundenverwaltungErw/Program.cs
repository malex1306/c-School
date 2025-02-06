

namespace KundenProduktVerwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            KundenVerwaltung kundenVerwaltung = new KundenVerwaltung();
            ProduktVerwaltung produktVerwaltung = new ProduktVerwaltung();

            // Beispielprodukte hinzufügen
            produktVerwaltung.ProduktHinzufuegen(new Produkt("Apfel", 1.20, 50));
            produktVerwaltung.ProduktHinzufuegen(new Produkt("Banane", 0.90, 30));

            while (true)
            {
                Console.WriteLine("\nWas möchtest du tun?");
                Console.WriteLine("1. Kunde hinzufügen");
                Console.WriteLine("2. Alle Kunden anzeigen");
                Console.WriteLine("3. Kunde suchen");
                Console.WriteLine("4. Kunde kauft ein Produkt");
                Console.WriteLine("5. Beenden");

                string auswahl = Console.ReadLine();

                switch (auswahl)
                {
                    case "1":
                        Console.WriteLine("\nGib den Namen des Kunden ein:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Gib die E-Mail des Kunden ein:");
                        string email;
                        while (true)
                        {
                            email = Console.ReadLine();
                            if (email.Contains("@")) break;
                            Console.WriteLine("Ungültige E-Mail-Adresse. Bitte erneut eingeben:");
                        }

                        kundenVerwaltung.KundeHinzufuegen(new Kunde(name, email));
                        Console.WriteLine("Kunde erfolgreich hinzugefügt!");
                        break;

                    case "2":
                        kundenVerwaltung.KundenAnzeigen();
                        break;

                    case "3":
                        Console.WriteLine("\nGib den Namen des gesuchten Kunden ein:");
                        string suchName = Console.ReadLine();
                        Kunde kunde = kundenVerwaltung.KundeSuchen(suchName);
                        if (kunde != null)
                        {
                            Console.WriteLine($"Gefunden: {kunde.KundenNummer} - {kunde.Name}, {kunde.Email}");
                        }
                        else
                        {
                            Console.WriteLine("Kunde nicht gefunden.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("\nGib den Namen des Kunden ein:");
                        string kundeName = Console.ReadLine();
                        Kunde kaufenderKunde = kundenVerwaltung.KundeSuchen(kundeName);
                        if (kaufenderKunde == null)
                        {
                            Console.WriteLine("Kunde nicht gefunden.");
                            break;
                        }

                        Console.WriteLine("Gib den Namen des Produkts ein:");
                        string produktName = Console.ReadLine();
                        Produkt produkt = produktVerwaltung.ProduktSuchen(produktName);
                        if (produkt == null)
                        {
                            Console.WriteLine("Produkt nicht gefunden.");
                            break;
                        }

                        Console.WriteLine("Gib die Menge ein:");
                        int menge;
                        while (!int.TryParse(Console.ReadLine(), out menge) || menge <= 0)
                        {
                            Console.WriteLine("Ungültige Menge. Bitte erneut eingeben:");
                        }

                        if (produkt.Lagerbestand < menge)
                        {
                            Console.WriteLine("Nicht genügend Lagerbestand!");
                        }
                        else
                        {
                            produkt.Lagerbestand -= menge;
                            kaufenderKunde.Kaufhistorie.Add($"{menge}x {produkt.Name} für {menge * produkt.Preis}€");
                            Console.WriteLine("Kauf erfolgreich!");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Programm beendet.");
                        return;

                    default:
                        Console.WriteLine("Ungültige Eingabe.");
                        break;
                }
            }
        }
    }

    class Kunde
    {
        private static int naechsteKundenNummer = 1;
        public int KundenNummer { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Kaufhistorie { get; } = new List<string>();

        public Kunde(string name, string email)
        {
            KundenNummer = naechsteKundenNummer++;
            Name = name;
            Email = email;
        }
    }

    class Produkt
    {
        public string Name { get; set; }
        public double Preis { get; set; }
        public int Lagerbestand { get; set; }

        public Produkt(string name, double preis, int lagerbestand)
        {
            Name = name;
            Preis = preis;
            Lagerbestand = lagerbestand;
        }
    }

    class KundenVerwaltung
    {
        private List<Kunde> kunden = new List<Kunde>();

        public void KundeHinzufuegen(Kunde kunde)
        {
            kunden.Add(kunde);
        }

        public void KundenAnzeigen()
        {
            if (kunden.Count == 0)
            {
                Console.WriteLine("Keine Kunden vorhanden.");
                return;
            }
            foreach (var kunde in kunden)
            {
                Console.WriteLine($"{kunde.KundenNummer}: {kunde.Name} ({kunde.Email})");
            }
        }

        public Kunde KundeSuchen(string name)
        {
            return kunden.Find(k => k.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }

    class ProduktVerwaltung
    {
        private List<Produkt> produkte = new List<Produkt>();

        public void ProduktHinzufuegen(Produkt produkt)
        {
            produkte.Add(produkt);
        }

        public Produkt ProduktSuchen(string name)
        {
            return produkte.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
