namespace Kundenverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            KundenVerwaltung verwaltung = new KundenVerwaltung();

            Console.WriteLine("Möchten Sie einen neuen Kunden hinzufügen? (ja/nein)");
            string addKundeAntwort = Console.ReadLine().ToLower();

            while (addKundeAntwort == "ja")
            {
                Console.WriteLine("\nGeben Sie den Namen des Kunden ein:");
                string name = Console.ReadLine();

                Console.WriteLine("Geben Sie die E-Mail des Kunden ein:");
                string email = Console.ReadLine();

                Console.WriteLine("Geben Sie das Guthaben des Kunden ein:");
                double guthaben;
                while (!double.TryParse(Console.ReadLine(), out guthaben) || guthaben < 0)
                {
                    Console.WriteLine("Ungültiges Guthaben. Bitte geben Sie einen gültigen Betrag ein:");
                }

                Kunde neuerKunde = new Kunde(name, email, guthaben);
                verwaltung.KundeHinzufuegen(neuerKunde);
                Console.WriteLine($"Kunde {name} wurde erfolgreich hinzugefügt.");

                // Bestellen nach der Kundenerstellung
                Console.WriteLine("\nMöchten Sie für diesen Kunden eine Bestellung tätigen? (ja/nein)");
                string bestellungAntwort = Console.ReadLine().ToLower();
                if (bestellungAntwort == "ja")
                {
                    Console.WriteLine("Geben Sie den Preis der Bestellung ein:");
                    double preis;
                    while (!double.TryParse(Console.ReadLine(), out preis) || preis < 0)
                    {
                        Console.WriteLine("Ungültiger Preis. Bitte geben Sie einen gültigen Betrag ein:");
                    }
                    neuerKunde.BestellungTaetigen(preis);
                }

                // Kunden anzeigen
                Console.WriteLine("\nMöchten Sie alle Kunden anzeigen? (ja/nein)");
                string anzeigenAntwort = Console.ReadLine().ToLower();
                if (anzeigenAntwort == "ja")
                {
                    verwaltung.KundenAnzeigen();
                }

                // Weitere Kunden hinzufügen
                Console.WriteLine("\nMöchten Sie einen weiteren Kunden hinzufügen? (ja/nein)");
                addKundeAntwort = Console.ReadLine().ToLower();
            }
        }
    }

    class Kunde
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Guthaben { get; set; }

        public Kunde(string name, string email, double guthaben)
        {
            Name = name;
            Email = email;
            Guthaben = guthaben;
        }

        public void BestellungTaetigen(double preis)
        {
            double rabatt = 0;
            if (Guthaben > 100)
            {
                rabatt = preis * 0.1;
            }
            double endpreis = preis - rabatt;

            if (endpreis > Guthaben)
            {
                Console.WriteLine("Nicht genug Guthaben für diese Bestellung.");
            }
            else
            {
                Guthaben -= endpreis;
                Console.WriteLine($"Bestellung erfolgreich. Rabatt: {rabatt}€. Endpreis: {endpreis}€. Neues Guthaben: {Guthaben}€.");
            }
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
            foreach (var kunde in kunden)
            {
                Console.WriteLine($"Name: {kunde.Name}, Email: {kunde.Email}, Guthaben: {kunde.Guthaben}");
            }
        }

        public Kunde KundeSuchen(string name)
        {
            return kunden.Find(k => k.Name == name);
        }
    }
}
